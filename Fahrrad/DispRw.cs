using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrrad
{
    public class DispRw
    {
        public int fwNr;
        public int rwNr;
        public string rwBezeichnung;
        public int rwMenge;
        public double rwPreis;

        public DispRw( int nr, int rNr, string bez, int menge, double preis)
        {
            fwNr = nr;
            rwNr = rNr;
            rwBezeichnung = bez;
            rwMenge = menge;
            rwPreis = preis;
        }
    }
}
