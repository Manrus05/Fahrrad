using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrrad
{
    public class FwRw
    {
        public int lfdnr;
        public int FwNr;
        public int RwNr;
        public int Menge;

        public FwRw( int nr, int fw, int rw, int menge )
        {
            lfdnr = nr;
            FwNr = fw;
            RwNr = rw;
            Menge = menge;
        }
    }
}
