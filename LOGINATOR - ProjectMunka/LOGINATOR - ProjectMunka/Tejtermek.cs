using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGINATOR___ProjectMunka
{
    enum TTermekTipus
    {
        Tej,
        Vaj,
        Sajt,
        Túró,
        Desszert
    }

    class Tejtermek : Termekek
    {
        TTermekTipus ttipus;
        int liter;
        DateTime szavido;

        public Tejtermek(string cikkszam, string megnevezes, int db, int ar, TTermekTipus ttipus,  int liter,   DateTime szavido) : base(cikkszam, megnevezes, db, ar)
        {
            this.Ttipus = ttipus;
            this.Liter = liter;
            this.Szavido = szavido;
        }

        public int Liter
        {
            get => liter;
            set { if (value > 10 || Db > 1) { liter = value; } else { throw new ArgumentException("Nem megfelelő mennyiséget adott meg!"); } }
        }
        public DateTime Szavido
        {
            get => szavido;
            set { if (value > DateTime.Now) { szavido = value; } else { throw new ArgumentException("Nem megfelelő dátumot adott meg"); } }
        }
        public TTermekTipus Ttipus { get => ttipus; private set => ttipus = value; }

        public override int Arszamitas()
        {
            if (Db >= 1) { return Db * Ar; }
            else { return Liter * Ar; }
        }

        public override string ToString()
        {
            return "Tejtermék megnevezése: " + Megnevezes + " - liter: " + liter + " - db: " + Db + " - egységár: " + Ar + " - összár: " + Arszamitas() + "Ft - típus: " + Ttipus + " - szavidő: " + Szavido + " - cikkszám: " + Cikkszam;
        }

        public override string CSVFormatum()
        {
            return "Tejtermék megnevezése: "+ base.CSVFormatum()+$" ;{Liter};{Arszamitas()};{Ttipus};{Szavido};{Cikkszam}";
        }

        public override string TxtFormatum()
        {
            return "Tejtermék megnevezése: "+base.TxtFormatum()+$" {Liter}, {Arszamitas()}, {Ttipus}, {Szavido}, {Cikkszam}";
        }
    }
}
