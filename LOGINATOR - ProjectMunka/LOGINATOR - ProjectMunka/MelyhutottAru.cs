using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGINATOR___ProjectMunka
{
    enum FTermekTipus
    {
        Fagyasztott_Zöldség,
        Fagyasztott_Gyümölcs,
        Fagyasztott_Készétel,
        Fagyasztott_Dessszert
    }

    class MelyhutottAru : Termekek
    {
        FTermekTipus ftipus;
        DateTime szavido;

        public MelyhutottAru(string cikkszam, string megnevezes, int db, int ar, FTermekTipus ftipus, DateTime szavido) : base(cikkszam, megnevezes, db, ar)
        {
            this.Ftipus = ftipus;
            this.Szavido = szavido;
        }

        public DateTime Szavido
        {
            get => szavido;
            set { if (value > DateTime.Now) { szavido = value; } else { throw new ArgumentException("Nem jó a megadott dátum!"); } }
        }
        public FTermekTipus Ftipus { get => ftipus; private set => ftipus = value; }

        public override int Arszamitas()
        {
            if (Db > 0) { return Db * Ar; }
            else throw new ArgumentException("Nincs megadva mennyiség érték! Kérem javítsa ki a hibás adatot!");
        }

        public override string ToString()
        {
            return "Termék megnevezése: " + Megnevezes + " - db: " + Db + " - egységár: " + Ar + " - összár: " + Arszamitas() + "Ft - típus: " + Ftipus + " - szavidő: " + Szavido + " - cikkszám: " + Cikkszam;
        }

        public override string CSVFormatum()
        {
            return "Fagyasztott termék: "+base.CSVFormatum()+$"{Arszamitas()};{Ftipus};{Szavido};{Cikkszam}";
        }

        public override string TxtFormatum()
        {
            return "Fagyasztott termék: " + base.TxtFormatum()+$" {Arszamitas()}, {Ftipus}, {Szavido}, {Cikkszam}";
        }
    }
}
