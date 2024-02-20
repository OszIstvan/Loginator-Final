using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGINATOR___ProjectMunka
{
    class Uveg : Gongyoleg
    {
        string tipus;
        double mennyiseg;
        long osszertek;

        public Uveg(string tipus, double mennyiseg, long osszertek) : base(tipus, mennyiseg, osszertek)
        {
            this.Tipus = tipus;
            this.Mennyiseg = mennyiseg;
            this.Osszertek = osszertek;
        }

        //public string Tipus { get => tipus; set => tipus = value; }
        //public double Mennyiseg { get => mennyiseg; set => mennyiseg = value; }
        //public long Osszertek { get => osszertek; set => osszertek = value; }

        public override string ToString()
        {
            return Tipus + " - " + Mennyiseg + " - " + Osszertek;
        }
    }
}
