using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGINATOR___ProjectMunka
{
    class Selejt
    {
        string megnevezes;
        long mennyiseg;
        Mertekegyseg mertekegyseg;
        long osszar;

        public Selejt(string megnevezes, long mennyiseg, Mertekegyseg mertekegyseg, long osszar)
        {
            this.Megnevezes = megnevezes;
            this.Mennyiseg = mennyiseg;
            this.Mertekegyseg = mertekegyseg;
            this.Osszar = osszar;
        }

        public string Megnevezes { get => megnevezes; set => megnevezes = value; }
        public long Mennyiseg { get => mennyiseg; set => mennyiseg = value; }
        public long Osszar { get => osszar; set => osszar = value; }
        internal Mertekegyseg Mertekegyseg { get => mertekegyseg; set => mertekegyseg = value; }

        public override string ToString()
        {
            return Megnevezes + " - " + Mennyiseg + " - " + Mertekegyseg + " - " + Osszar;
        }
    }
}
