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
    public partial class GameOver : PhoneApplicationPage
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void GoPuntajes(object sender, RoutedEventArgs e)
        {
         
            //NavigationService.Navigate(new Uri("/Puntajes.xaml", UriKind.Relative));
        }
       
        
      //  protected override void OnNavigatedTo(NavigationEventArgs e)
    //    {
      //      base.OnNavigatedTo(e);
            
          //  if (NavigationContext.QueryString.ContainsKey("dato"))
        //    {

            //    string dato = NavigationContext.QueryString["dato"];
             //   NavigationService.Navigate(new Uri("/Puntajes.xaml?dato="+dato, UriKind.Relative));

//            }


           


        
    }
}