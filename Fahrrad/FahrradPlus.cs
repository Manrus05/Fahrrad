using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrrad
{
    public class FahrradPlus : Fertigware
    {
        private int Menge;

        public FahrradPlus( int nr, string bez, int preis, int menge )
            : base( nr, bez, preis)
        {
            Menge = menge;
        }

        public int Menge1 { get => Menge; set => Menge = value; }
    }
}
