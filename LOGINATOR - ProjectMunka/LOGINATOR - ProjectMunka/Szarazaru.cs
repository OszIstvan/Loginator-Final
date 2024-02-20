using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGINATOR___ProjectMunka
{
    enum SzTermekek
    {
        Pékáru,
        Házisütés,
        Üdítő,
        Szeszesital,
        Édesség,
        Vegyiáru
    }

    class Szarazaru : Termekek
    {
        SzTermekek sztipus;
        int suly;
        DateTime szavido;

        public Szarazaru(string cikkszam, string megnevezes, int db, int ar, SzTermekek sztipus,  int suly,   DateTime szavido) : base(cikkszam, megnevezes, db, ar)
        {
            this.Sztipus = sztipus;
            this.Szavido = szavido;
        }

        public DateTime Szavido
        {
            get => szavido;
            set { if (value > DateTime.Now) { szavido = value; } else { throw new ArgumentException("Nem jó a megadott dátum!"); } }
        }

        public int Suly
        {
            get => suly;
            set { if (value > 0 || Db > 0) { suly = value; } else { throw new ArgumentException("Nincs megadva súlymennyiség! Kérem adjon meg érvényes mennyiséget!"); } }
        }
        public SzTermekek Sztipus { get => sztipus; private set => sztipus = value; }

        public override int Arszamitas()
        {
            if (suly > 10) { return (int)Suly * Ar; }
            else { return Db * Ar; }
        }

        public override string ToString()
        {
            return "Termék megnevezése: " + Megnevezes + " - db: " + Db + " - súly: " + Suly + " Kg " + " - egységár: " + Ar + " - összár: " + Arszamitas() + "Ft - típus: " + Sztipus + " - szavidő: " + Szavido + " - cikkszám: " + Cikkszam;
        }

        public override string CSVFormatum()
        {
            return "Szárazáru megnevezése: "+base.CSVFormatum()+$";{Arszamitas()};{Suly};{Sztipus};{Szavido};{Cikkszam}";
        }

        public override string TxtFormatum()
        {
            return "Szárazáru megnevezése: " + base.TxtFormatum() + $",{Arszamitas()},{Suly},{Sztipus},{Szavido},{Cikkszam}";
        }
    }
}
