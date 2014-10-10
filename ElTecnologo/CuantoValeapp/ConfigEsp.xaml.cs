using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;

namespace CuantoValeapp
{
    public partial class ConfigEsp : PhoneApplicationPage
    {
        public ConfigEsp()
        {
            InitializeComponent();
        }

        private void GoPage(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/MenuEsp.xaml", UriKind.Relative));
        }

        private void GoPage3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MenuEsp.xaml", UriKind.Relative));
        }

       

     

        private void CambiaVolumen(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           //double Volume;
            //Volume = volumeSlider.Value;

         // MenuEsp mesp = new MenuEsp();
          // mesp.volume(Volume);
            //var os=e.NewValue;
           
            
            
            
            
            //var volString = Convert.ToString(vol);
            //value = (double)volumeSlider.ToString();
            
           // NavigationService.Navigate(new Uri("/MenuEsp.xaml?Volumen="+volString , UriKind.Relative));


        }

        public double Volume { get; set; }
        
    }
}