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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MyFirstApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FacultiesList : Page
    {
        public FacultiesList()
        {
            this.InitializeComponent();
        }

        private void Faculty1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            BL_PageContent.Faculty1();
            Frame.Navigate(typeof(Faculty));
        }
        private void Faculty2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            BL_PageContent.Faculty2();
            Frame.Navigate(typeof(Faculty));
        }

        private void Faculty3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            BL_PageContent.Faculty3();
            Frame.Navigate(typeof(Faculty));
        }
        private void Faculty4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            BL_PageContent.Faculty4();
            Frame.Navigate(typeof(Faculty));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

     
    }
}
