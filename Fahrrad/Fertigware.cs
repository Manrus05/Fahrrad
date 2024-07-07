using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrrad
{
    public class Fertigware
    {
        private int fwNr;
        private string fwModell;
        private double fwPreis;

        public Fertigware( int nr, string mod, double pr)
        {
            fwNr = nr;
            fwModell = mod;
            fwPreis = pr;
        }

        public int FwNr { get => fwNr; set => fwNr = value; }
        public string FwModell { get => fwModell; set => fwModell = value; }
        public double FwPreis { get => fwPreis; set => fwPreis = value; }
    }
}
