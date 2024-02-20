using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGINATOR___ProjectMunka
{
    class Gongyoleg
    {
        string tipus;
        double mennyiseg;
        long osszertek;

        public Gongyoleg(string tipus, double mennyiseg, long osszertek)
        {
            this.Tipus = tipus;
            this.Mennyiseg = mennyiseg;
            this.Osszertek = osszertek;
        }

        public string Tipus { get => tipus; set => tipus = value; }
        public double Mennyiseg { get => mennyiseg; set => mennyiseg = value; }
        public long Osszertek { get => osszertek; set => osszertek = value; }

        public override string ToString()
        {
            return Tipus + " - " + Mennyiseg + " - " + Osszertek;
        }
    }
}
