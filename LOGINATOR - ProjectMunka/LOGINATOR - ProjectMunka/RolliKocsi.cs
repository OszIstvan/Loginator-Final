using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGINATOR___ProjectMunka
{
    class RolliKocsi : Gongyoleg
    {
        string tipus;
        double mennyiseg;
        long osszertek;

        public RolliKocsi(string tipus, double mennyiseg, long osszertek) : base(tipus, mennyiseg, osszertek)
        {
            this.Tipus1 = tipus;
            this.Mennyiseg1 = mennyiseg;
            this.Osszertek1 = osszertek;
        }

        public string Tipus1 { get => tipus; set => tipus = value; }
        public double Mennyiseg1 { get => mennyiseg; set => mennyiseg = value; }
        public long Osszertek1 { get => osszertek; set => osszertek = value; }

        public override string ToString()
        {
            return Tipus + " - " + mennyiseg + " - " + Osszertek;
        }
    }
}
