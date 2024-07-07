using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrrad
{
    public class Rohware
    {
        private int rwNr;
        private string rwBezeichnung;
        private double rwPreis;

        public Rohware( int nr, string bez, double preis)
        {
            rwNr = nr;
            rwBezeichnung = bez;
            rwPreis = preis;
        }

        public int RwNr { get => rwNr; set => rwNr = value; }
        public string RwBezeichnung { get => rwBezeichnung; set => rwBezeichnung = value; }
        public double RwPreis { get => rwPreis; set => rwPreis = value; }
    }
}
