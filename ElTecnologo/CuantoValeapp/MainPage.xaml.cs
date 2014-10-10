using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace CuantoValeapp
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void GoPage(object sender, RoutedEventArgs e)
        {
            if (sender == Español)

            { NavigationService.Navigate(new Uri("/MenuEsp.xaml", UriKind.Relative)); }



        }
       

        private void Pag1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MenuEsp.xaml", UriKind.Relative));
        }

       
        
   
        }
}