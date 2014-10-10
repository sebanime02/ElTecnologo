using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuantoValeapp.Models
{
   public class Rank
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Puntaje { get; set; }
    }
}