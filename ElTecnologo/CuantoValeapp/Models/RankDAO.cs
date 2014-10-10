using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace CuantoValeapp.Models
{
  public class RankDAO
    {


        SQLiteConnection con;
        string path = Path.Combine(ApplicationData.Current.LocalFolder.Path,"ran.sqlite");

        public RankDAO() {
            con = new SQLiteConnection(path);
            con.CreateTable<Rank>();
        }

        public void InsertRank(Rank ran) {
            con.Insert(ran);
        }

        public void UpdateRank(Rank ran)
        {
            con.Update(ran);
        }

        public void DeleteRank(Rank ran)
        {
            con.Delete(ran);
        }

        public List<Rank> GetAllUsuarios() {
            List<Rank>  ran = con.Table<Rank>().ToList<Rank>();
            return ran;
        }

        public List<Rank> GetRankingByOrder(string name,int puntaje)
        {
            List<Rank> resultado = con.Query<Rank>("SELECT Nombre"+name+"Puntaje"+puntaje+ "FROM Rank ORDER BY Puntaje DESC");
            
            return resultado;
        }
    }
}
