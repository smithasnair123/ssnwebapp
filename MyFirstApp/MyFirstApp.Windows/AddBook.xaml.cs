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
    public sealed partial class AddBook : Page
    {
        public AddBook()
        {
            this.InitializeComponent();
        }

        IMobileServiceTable<inventory> invetoryObj = App.MobileService.GetTable<inventory>();
        MobileServiceCollection<inventory, inventory> items;
        public class inventory
        {
            public string Id;
            public string BookNo;
            public string BookName;
            public string Description;
            public string Author;

            public override string ToString()
            {
                return BookName;
            }
        }

        async private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                inventory book = new inventory
                {
                    Author = txtAuthor.Text,
                    BookName = txtBookName.Text,
                    BookNo = txtBookNo.Text,
                    Description = txtDescription.Text
                };
                await App.MobileService.GetTable<inventory>().InsertAsync(book);
                var dialog = new MessageDialog("Successful!");
                await dialog.ShowAsync();


            }
            catch (Exception em)
            {
                var dialog = new MessageDialog("An Error Occured: " + em.Message);
                await dialog.ShowAsync();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
