using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices.Sync;
using System.Collections.Generic;
using System.Linq;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MyFirstApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static string VarOutput { get; set; } //place property within the class

        public MainPage()
        {
            this.InitializeComponent();

            txtBoxRas.Text = "Rasmussen College";
            txtBoxRas.FontSize = 14;
            BL_PageContent.CreatedBy = "Created By: Smitha Sasidharan Nair";
            txtBoxFooter.Text = BL_PageContent.CreatedBy;
            txtBoxUserId.Focus(FocusState.Programmatic);

        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            ProcessCalc();
        }
        private void ProcessCalc()
        {
            Int32 Var1 = Convert.ToInt32(txtBoxInput1.Text) + Convert.ToInt32(txtBoxInput2.Text);
            txtBoxDisplay.Text = Convert.ToString(Var1);
        }

       

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(FacultiesList));
        }

        private void btnFaculty_Click(object sender, RoutedEventArgs e)
        {
             Frame.Navigate(typeof(FacultiesList));
        }

        private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CourseList));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Library));
        }

        //private void button1_Click(object sender, RoutedEventArgs e)
        //{
        //    Frame.Navigate(typeof(UserAuth));
        //}


        //Auth related code

        public int IsAuth { get; set; }

        //[DataTable("Auth_Cred")]
        public class User_Cred
        {
            public string id { get; set; }
            public string FullName { get; set; }
            public string UserID { get; set; }
            public string Password { get; set; }
        }

        private IMobileServiceSyncTable<User_Cred> todoGetTable = App.MobileService.GetSyncTable<User_Cred>();

        private async Task InitLocalStoreAsync()
        {
            //if (!App.MobileService.SyncContext.IsInitialized)
            //{
            //    var store = new MobileServiceSQLiteStore("Rasmussen.db");
            //    store.DefineTable<User_Cred>();
            //    await App.MobileService.SyncContext.InitializeAsync(store);
            //}
           // await SyncAsync();
        }

        private async Task SyncAsync()
        {
            await App.MobileService.SyncContext.PushAsync();
            await todoGetTable.PullAsync("User_Cred", todoGetTable.CreateQuery());
        }



        async private void btnSubmit_Login(object sender, RoutedEventArgs e)
        {
            InitLocalStoreAsync();

            GetAuthentication();

        }

        async public void GetAuthentication()
        {
            try
            {

                //IMobileServiceTable<User_Cred> todoTable = App.MobileService.GetTable<User_Cred>();

                List<User_Cred> items = await todoGetTable
                    .Where(User_Cred => User_Cred.UserID == txtBoxUserId.Text)
                    .ToListAsync();

                IsAuth = items.Count();

                foreach (var value in items)
                {
                    var dialog = new MessageDialog("UserID: " + value.UserID);
                    await dialog.ShowAsync();
                }


                if (IsAuth > 0)
                {
                    var dialog = new MessageDialog("You are Authenticated");
                    await dialog.ShowAsync();

                }
                else
                {
                    var dialog = new MessageDialog("User Must Register - Account Does Not Exist");
                    await dialog.ShowAsync();
                }
            }
            catch (Exception em)
            {
                var dialog = new MessageDialog("An Error Occured: " + em.Message);
                await dialog.ShowAsync();
            }
        }

        async private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User_Cred itemReg = new User_Cred
                {
                    FullName = "System Test",
                    UserID = txtBoxUserId.Text,
                    Password = txtBoxPasswd.Text
                };
                await App.MobileService.GetTable<User_Cred>().InsertAsync(itemReg);
                var dialog = new MessageDialog("Successful!");
                await dialog.ShowAsync();
            }
            catch (Exception em)
            {
                var dialog = new MessageDialog("An Error Occured: " + em.Message);
                await dialog.ShowAsync();
            }

        }

        private void btnSync_Click(object sender, RoutedEventArgs e)
        {
            InitLocalStoreAsync();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
                this.Frame.Navigate(typeof(GoogleAuth));
            

        }

        private void wbVewPostAuthentication_LoadCompleted(object sender, Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {

        }
        private void HyperlinkButton_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

    }
}
