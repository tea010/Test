using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Clinik
{
   public class Pacijent
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime Rodjenje { get; set; }
        public string Adresa { get; set; }
        public bool Pol { get; set; }
        public int Telefon { get; set; } 
    }
}
