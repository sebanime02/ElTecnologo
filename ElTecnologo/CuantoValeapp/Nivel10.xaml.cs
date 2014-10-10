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
    public partial class Nivel10 : PhoneApplicationPage
    {
        public Nivel10()
        {
            InitializeComponent();
        }

        private void Resultado(object sender, RoutedEventArgs e)
        {
            string puntos = "10000";
            

            NavigationService.Navigate(new Uri("/Puntajes.xaml?dato=" + puntos, UriKind.Relative));
        }
    }
}