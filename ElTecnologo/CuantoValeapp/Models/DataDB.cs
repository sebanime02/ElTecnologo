using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuantoValeapp.Models
{
   public  class DataDB
    {

       ObservableCollection<Rank> ran ;

        public ObservableCollection<Rank> Ran
        {
            set
            {
                ran = value;
            }
            get
            {
                if (ran == null)
                {
                    RankDAO rankDAO = new RankDAO();
                    ran = new ObservableCollection<Rank>(rankDAO.GetAllUsuarios());
                }
                return ran;
            }
        }

        ObservableCollection<Rank> resultado;

        public ObservableCollection<Rank> Resultado
        {
            set
            {
                resultado = value;
            }
            get
            {
                if (resultado == null)
                    resultado = new ObservableCollection<Rank>();
                return resultado;
            }

        }
    }
}
