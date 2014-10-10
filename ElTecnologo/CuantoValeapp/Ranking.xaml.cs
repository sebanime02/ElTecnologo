using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;
using System.IO;
using CuantoValeapp.Models;
using System.Collections.ObjectModel;

namespace CuantoValeapp
{
    public partial class Ranking : PhoneApplicationPage
    {
        const string FILE_NAME = "texto1.txt", FILE_NAME2 = "texto2.txt";
        
        public Ranking()
        {
            InitializeComponent();
            
           

        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            
           

            if (NavigationContext.QueryString.ContainsKey("puntaje")&& NavigationContext.QueryString.ContainsKey("username"))
            {

                string datop = NavigationContext.QueryString["puntaje"];
                string nombre = NavigationContext.QueryString["username"];
               int datope = Convert.ToInt32(datop);
               string name = Convert.ToString(nombre);
              
                
                
                
                
                RankDAO ranDAO = new RankDAO();

               List<Rank> resultado = ranDAO.GetRankingByOrder(name,datope);
                
               ObservableCollection<Rank> ran = new ObservableCollection<Rank>(resultado);
               
               var data = Application.Current.Resources["Ran"] as DataDB;

               data.Resultado.Clear();


               for (int i = 0; i < ran.Count; i++)
               {
                   data.Resultado.Add(ran.ElementAt<Rank>(i));
               }

                
                
               
            }

              




        }
        


        






        private void GoMenu(object sender, RoutedEventArgs e)
        {
           
             NavigationService.Navigate(new Uri("/MenuEsp.xaml", UriKind.Relative));  
            }

        
        }
    }

