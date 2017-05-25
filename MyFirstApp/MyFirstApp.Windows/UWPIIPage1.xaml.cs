using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.Storage;
using System.Net.Http;
using Newtonsoft.Json;



// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MyFirstApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
        }

        IMobileServiceTable<Smitha_TodoTable> todoTable = App.MobileService.GetTable<Smitha_TodoTable>();
        MobileServiceCollection<Smitha_TodoTable, Smitha_TodoTable> items;

        public class Contact
        {
            public int ID { get; set; }
            public string NAME { get; set; }
            public string EMAILADDRESS { get; set; }
        }


        public class Smitha_TodoTable
        {
            public string Id { get; set; }
            public string Text { get; set; }
            public bool Complete { get; set; }
        }
        async private void Submit_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Smitha_TodoTable item = new Smitha_TodoTable
                {
                    Text = txtBoxItem.Text,
                    Complete = false
                };
                await App.MobileService.GetTable<Smitha_TodoTable>().InsertAsync(item);
                var dialog = new MessageDialog("Successful!");
                await dialog.ShowAsync();
            }
            catch (Exception em)
            {
                var dialog = new MessageDialog("An Error Occured: " + em.Message);
                await dialog.ShowAsync();
            }
        }

        public void GetDBSync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new
                    Uri("https://cis4655c-webapp1.azurewebsites.net");

                var json = client.GetStringAsync("/").Result;
                var contacts = JsonConvert.DeserializeObject<Contact[]>(json);
            }
        }


        private async Task RefreshTodoItems()
        {
            MobileServiceInvalidOperationException exception = null;
            try
            {
                // This code refreshes the entries in the list view by querying the TodoItems table.
                // The query excludes completed TodoItems
                items = await todoTable
                    .Where(Smitha_TodoTable => Smitha_TodoTable.Complete == false)
                    .ToCollectionAsync();
            }
            catch (MobileServiceInvalidOperationException e)
            {
                exception = e;
            }

            if (exception != null)
            {
                await new MessageDialog(exception.Message, "Error loading items").ShowAsync();
            }
            else
            {
                ListItems.ItemsSource = items;
                this.btnRefresh.IsEnabled = true;
            }
        }

        private async void CheckBoxComplete_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            Smitha_TodoTable item = cb.DataContext as Smitha_TodoTable;
            await UpdateCheckedTodoItem(item);
        }

        private async Task UpdateCheckedTodoItem(Smitha_TodoTable item)
        {
            // This code takes a freshly completed TodoItem and updates the database. When the MobileService 
            // responds, the item is removed from the list 
            await todoTable.UpdateAsync(item);
            items.Remove(item);
            ListItems.Focus(Windows.UI.Xaml.FocusState.Unfocused);

            //await SyncAsync(); // offline sync
        }

        async private void btnRefresh_Click_1(object sender, RoutedEventArgs e)
        {
            await RefreshTodoItems();

        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

       
    }
}
