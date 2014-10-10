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
    public partial class MenuEsp : PhoneApplicationPage
    {
        public MenuEsp()
        {
            InitializeComponent();
            
           
        }

      

        private void GoConfig(object sender, System.Windows.Input.GestureEventArgs e)
        {

           

            if (sender == btnConfig)
            {


                NavigationService.Navigate(new Uri("/ConfigEsp.xaml", UriKind.Relative));
            }
        }
   

        private void media_MediaEnded_1(object sender, RoutedEventArgs e)
        {
            media.Play();
        }

        public void volume(double d) {

          // media.Volume = d;
          
           

            //String llego = NavigationContext.QueryString["Volumen"];
            //var volumenlisto = Convert.ToDouble(llego);
           // media.Volume = volumenlisto;
        }

        private void GoPlay(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Nivel1.xaml", UriKind.Relative));
        }

        private void GoRanking(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Ranking.xaml", UriKind.Relative));
        }
    }
    
}