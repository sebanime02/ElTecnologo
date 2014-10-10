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
    public partial class Nivel2 : PhoneApplicationPage
    {
        public Nivel2()
        {
            InitializeComponent();
        }

      
        
        private void R(object sender, RoutedEventArgs e)
        {
            musica.Play();
            
            
        }
        public String Precio(int a){
            string s;
            int m;
            int particulo = 88658;
            int rango=20000;
            if(a<=particulo){
                m=particulo-a;
                if (m <= rango)
                {
                    s = "siguiente";
                    return s;
                }
                else {

                    s = "perdio";
                    return s;
                }
            
            }
            else {


                m = a-particulo;
                if (m <= rango)
                {
                    s = "siguiente";
                    return s;
                }
                else
                {

                    s = "perdio";
                    return s;
                }
            }
        

        }

        private void Validar(object sender, RoutedEventArgs e)
        {

            if (box.Text != "")
            {
                int npuesto = Convert.ToInt32(box.Text);

                String resultado = Precio(npuesto);

                if (resultado == "siguiente")
                {
                    NavigationService.Navigate(new Uri("/Nivel3.xaml", UriKind.Relative));

                }
                else
                {

                    string puntos = "30";

                    NavigationService.Navigate(new Uri("/Puntajes.xaml?dato=" + puntos, UriKind.Relative));
                }

            }
            else {
                InitializeComponent();
            }

        }
    }
}