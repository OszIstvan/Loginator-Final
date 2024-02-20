using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGINATOR___ProjectMunka
{
    class Raklap : Gongyoleg
    {
        string tipus;
        double mennyiseg;
        long osszertek;

        public Raklap(string tipus, double mennyiseg, long osszertek) : base(tipus, mennyiseg, osszertek)
        {
            this.tipus = tipus;
            this.mennyiseg = mennyiseg;
            this.osszertek = osszertek;
        }

        public override string ToString()
        {
            return Tipus + " - " + Mennyiseg + " - " + osszertek;
        }
    }
}
