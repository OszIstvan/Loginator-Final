using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LOGINATOR___ProjectMunka
{
    enum FrTermekTipus
    {
       Hús_hentesáru,
        Felvágott,
        Száritotthús
    }

    class Frissaru : Termekek
    {
        FrTermekTipus tipus;
        int suly;
        DateTime szavido;

        public Frissaru(string cikkszam, string megnevezes, int db, int ar, FrTermekTipus tipus, int suly,  DateTime szavido) : base(cikkszam, megnevezes, db, ar)
        {
            this.Tipus = tipus;
            this.Suly = suly;
            this.Szavido = szavido;
        }

        public int Suly
        {
            get => suly;
            set { if (value > 10 || Db > 1) { suly = value; } else { throw new ArgumentException("Nem megfelelő súlymennyiséget illetve darabszámot adott meg! Próbálja újra!"); } }
        }
        public DateTime Szavido
        {
            get => szavido;
            set { if (value > DateTime.Now) { szavido = value; } else { throw new ArgumentException("Nem jó a megadott dátum"); } }
        }

        public FrTermekTipus Tipus { get => tipus; private set => tipus = value; }

        public override string ToString()
        {
            return "Termék megnevezése: "+Megnevezes + " - db: " + Db + " - súly: " + Suly + " - egységár: " + Ar + " - összár: " + Arszamitas() + " Ft " + " - típus: " + Tipus + " - szavidő: " + Szavido + " - cikkszám: " + Cikkszam;
        }

        public override int Arszamitas()
        {
            if (suly > 10) { return (int)Suly * Ar; }
            else { return Db * Ar; }
            
        }

        public override string CSVFormatum()
        {
            return "Frissáru megnevezése: " + base.CSVFormatum() + $"{Arszamitas()};{Suly};{Tipus};{Szavido};{Cikkszam};";
        }

        /*public static void FrissCSVMentes(List<Frissaru> termekek, string fajlnev)
        {
            StreamWriter sw = new StreamWriter(fajlnev);
            foreach (Termekek item in termekek)
            {
                sw.WriteLine(item.CSVFormatum());
            }
            sw.Close();
        }*/

        public override string TxtFormatum()
        {
            return "Frissáru megnevezése: " + base.TxtFormatum() + $" {Arszamitas()}, {Suly}, {Tipus}, {Szavido}, {Cikkszam}";
        }
    }
}
