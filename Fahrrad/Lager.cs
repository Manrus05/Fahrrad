using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrrad
{
    public class Lager
    {
        private int lnr;
        private int lbestand;

        public int Lnr { get => lnr; set => lnr = value; }
        public int Lbestand { get => lbestand; set => lbestand = value; }

        public Lager( int nr, int anz)
        {
            lnr = nr;
            lbestand = anz; 
        }
    }
}
