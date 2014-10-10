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
    public partial class MenuEng : PhoneApplicationPage
    {
        public MenuEng()
        {
            InitializeComponent();
        }

        private void GoConfig(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (sender == btnConfig)
            {


                NavigationService.Navigate(new Uri("/ConfigEng.xaml", UriKind.Relative));
            }
        }

        private void Finished(object sender, RoutedEventArgs e)
        {
            media.Play();
        }

        private void Play(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Nivel1.xaml",UriKind.Relative));
        }

        private void GoRanking(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Ranking.xaml", UriKind.Relative));
        }

    }
}