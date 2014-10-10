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
using System.Windows.Media.Imaging;

namespace CuantoValeapp
{
    public partial class Nivel1 : PhoneApplicationPage
    {
        const string FILE_NAME = "tpre.txt", FILE_NAME2 = "tdes.txt";
        public Nivel1()
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
            int particulo = 49000;
          
             
            

            
             int rango=10000;
             
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

       
        
    
         public int random(){

            Random rnd1 = new Random();
            int randomNumber = rnd1.Next(0,5);
                 if(randomNumber==1){
                 int y = 49900;
                
                 
           
         
                    
                     return y;
                 }
         else if(randomNumber==2){int y = 43900;
         descripcion.Text = "Nokia 1100 Con Cargador";

         imag.Source = new BitmapImage(new Uri(@"E:\Universidad\Aplimovil\Windows Phone\cuantovale\cuantovaleapp\ElTecnologo\CuantoValeapp\Logotipo Interno INGLES.png"));
             return y;}
                 else if (randomNumber == 3) { int y = 34900;
                 descripcion.Text = "Nokia 1100 Con Cargador";
                 // imag.Source = new BitmapImage(new Uri(@"E:\Universidad\Aplimovil\Windows Phone\cuantovale\cuantovaleapp\ElTecnologo\CuantoValeapp\Logotipo Interno INGLES.png"));
                 BitmapImage img = new BitmapImage();
                 img.UriSource = new Uri(@"E:\Universidad\Aplimovil\Windows Phone\cuantovale\cuantovaleapp\ElTecnologo\CuantoValeapp\nokia 1100 mercadolibre.jpg");
                 imag.Source = img;
                     return y;}
                 
                 else if (randomNumber == 3)
                 {
                     int y = 54900;
                     descripcion.Text = "Nokia 1100 Con Cargador";

                     //imag.Source = new BitmapImage(new Uri(@"E:\Universidad\Aplimovil\Windows Phone\cuantovale\cuantovaleapp\ElTecnologo\CuantoValeapp\Logotipo Interno INGLES.png"));
                     BitmapImage img = new BitmapImage();
                     img.UriSource = new Uri(@"E:\Universidad\Aplimovil\Windows Phone\cuantovale\cuantovaleapp\ElTecnologo\CuantoValeapp\nokia 1100 mercadolibre.jpg");
                     imag.Source = img;
                     
                     return y;
                 }
                 
                 else
                 {
                     int y = 54900;
                     descripcion.Text = "Nokia 1100 Con Cargador";
                     //imag.Source = new BitmapImage(new Uri(@"E:\Universidad\Aplimovil\Windows Phone\cuantovale\cuantovaleapp\ElTecnologo\CuantoValeapp\Logotipo Interno INGLES.png"));

                     BitmapImage img = new BitmapImage();
                     img.UriSource = new Uri(@"E:\Universidad\Aplimovil\Windows Phone\cuantovale\cuantovaleapp\ElTecnologo\CuantoValeapp\nokia 1100 mercadolibre.jpg");
                     imag.Source = img;
                     return y;
                 }
         }

        


           
            

        

        private void Validar(object sender, RoutedEventArgs e)
        {

           if(box.Text!=""){
                int npuesto = Convert.ToInt32(box.Text);

                String resultado=Precio(npuesto);
                
                if(resultado=="siguiente"){
                    NavigationService.Navigate(new Uri("/Nivel2.xaml",UriKind.Relative));

                }
                else{
                    string puntos = "0";
                    
                    NavigationService.Navigate(new Uri("/Puntajes.xaml?dato="+puntos, UriKind.Relative));
                    //GameOver g = new GameOver();
                    //int puntos = 0;
                    //g.Puntos(puntos);


                }
            }
         //   else
           // {
             //   InitializeComponent();
           // }
        }

      // public int ran1(){
      //int valor =50000;
      // return;
}
       //public int ran2(){}
      //public int ran3(){}
      // public int ran4(){}}
            
        


    }
