using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using CuantoValeapp.Models;

namespace CuantoValeapp
{
    public partial class Puntajes : PhoneApplicationPage
    {
        RankDAO ranDAO;//Conecta con RankDAO


        public Puntajes()
        {
            
            InitializeComponent();
            
        }
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (NavigationContext.QueryString.ContainsKey("dato"))
            {
               

                string dato = NavigationContext.QueryString["dato"];

                

               
     
                puntajetot.Text = dato;


                

            }
        }
       

        private void Repetir(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Nivel1.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (ranDAO == null){
           
                ranDAO = new RankDAO();
            }

            Rank  ran =new Rank() { Nombre = username.Text, Puntaje = puntajetot.Text };
            ranDAO.InsertRank(ran);


            var data = Application.Current.Resources["Data"] as DataDB;
            data.Ran.Add(ran);


            NavigationService.Navigate(new Uri("/Ranking.xaml?puntaje="+puntajetot.Text+"&username="+username.Text, UriKind.Relative));
           
        }

        

        private void GoMenu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MenuEsp.xaml", UriKind.Relative));
        }

        private void Borrar(object sender, System.Windows.Input.GestureEventArgs e)
        {
            username.Text = "";
        }

       
        








            // public void DarPuntaje(int a) { 
            //   string resultado=Convert.ToString(a);


            // puntajetot.Text = resultado;}

        

    }
}