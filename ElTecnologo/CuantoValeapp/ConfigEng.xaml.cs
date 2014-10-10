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
    public partial class ConfigEng : PhoneApplicationPage
    {
        public ConfigEng()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MenuEng.xaml", UriKind.Relative));
        }

        private void GoBack2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MenuEng.xaml", UriKind.Relative));
        }

        private void Aespanol(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ConfigEsp.xaml", UriKind.Relative));
        }
    }
}