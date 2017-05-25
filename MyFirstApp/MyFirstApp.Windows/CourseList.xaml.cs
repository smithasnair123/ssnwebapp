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
    public sealed partial class CourseList : Page
    {
        public CourseList()
        {
            this.InitializeComponent();
        }
        async private void btnCourse1_Click(object sender, RoutedEventArgs e)

        {
            BL_PageContent.Course1();
            Frame.Navigate(typeof(CoursePage), null);
        }

        async private void btnCourse2_Click(object sender, RoutedEventArgs e)
        {
            BL_PageContent.Course2();
            Frame.Navigate(typeof(CoursePage), null);
        }

        async private void btnCourse3_Click(object sender, RoutedEventArgs e)
        {
            BL_PageContent.Course3();
            Frame.Navigate(typeof(CoursePage), null);
        }

        private void btnCourse4_Click(object sender, RoutedEventArgs e)
        {
            BL_PageContent.Course4();
            Frame.Navigate(typeof(CoursePage), null);
        }

        private void btnCourse5_Click(object sender, RoutedEventArgs e)
        {
            BL_PageContent.Course5();
            Frame.Navigate(typeof(CoursePage), null);
        }

        private void btnCourse6_Click(object sender, RoutedEventArgs e)
        {
            BL_PageContent.Course6();
            Frame.Navigate(typeof(CoursePage), null);
        }

        private void btnCourse7_Click(object sender, RoutedEventArgs e)
        {
            BL_PageContent.Course3();
            Frame.Navigate(typeof(CoursePage), null);
        }

        private void btnCourse8_Click(object sender, RoutedEventArgs e)
        {
            BL_PageContent.Course8();
            Frame.Navigate(typeof(CoursePage), null);
        }

        private void btnCourse9_Click(object sender, RoutedEventArgs e)
        {
            BL_PageContent.Course9();
            Frame.Navigate(typeof(CoursePage), null);
        }

        private void btnCourse10_Click(object sender, RoutedEventArgs e)
        {
            BL_PageContent.Course10();
            Frame.Navigate(typeof(CoursePage), null);
        }

        private void btnCourse11_Click(object sender, RoutedEventArgs e)
        {
            BL_PageContent.Course11();
            Frame.Navigate(typeof(CoursePage), null);
        }

        private void btnCourse12_Click(object sender, RoutedEventArgs e)
        {
            BL_PageContent.Course12();
            Frame.Navigate(typeof(CoursePage), null);
        }

        private void btnCourse13_Click(object sender, RoutedEventArgs e)
        {
            BL_PageContent.Course13();
            Frame.Navigate(typeof(CoursePage), null);
        }

        private void btnCourse14_Click(object sender, RoutedEventArgs e)
        {
            BL_PageContent.Course14();
            Frame.Navigate(typeof(CoursePage), null);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
