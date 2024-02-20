using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGINATOR___ProjectMunka
{
    enum MTermekTipus
    {
        Háztartásigép,
        Barkácseszköz,
        Autó_motor,
        Szórakoztatóelektronika
    }

    enum Besorolas
    {
        A_Osztály,
        B_Osztály,
        C_Osztály
    }

    class MuszakiCikk : Termekek
    {
        MTermekTipus mtipus;
        Besorolas besorolas;

        public MuszakiCikk(string cikkszam, string megnevezes, int db, int ar, MTermekTipus mtipus, Besorolas besorolas) : base(cikkszam, megnevezes, db, ar)
        {
            this.Mtipus = mtipus;
            this.Besorolas = besorolas;
        }

        public MTermekTipus Mtipus { get => mtipus; private set => mtipus = value; }
        public Besorolas Besorolas { get => besorolas; private set => besorolas = value; }

        public override int Arszamitas()
        {
            if (Db > 0)
            {
                int szorzo;
                switch (Besorolas)
                {
                    case Besorolas.A_Osztály:
                        szorzo = 5; break;
                    case Besorolas.B_Osztály:
                        szorzo = 3; break;
                    case Besorolas.C_Osztály:
                        szorzo = 1; break;
                    default: szorzo = 1; break;
                }
                return Ar * Db * szorzo;
            }
            else
            {
                throw new ArgumentException("Hibás mennyiséget adott meg! Kérem javítsa ki a hibás adatot!");
            }
        }

        public override string ToString()
        {
            return "Termék megnevezése: " + Megnevezes + " - db: " + Db + " - egységár: " + Ar + " - összár: " + Arszamitas() + " Ft - típus: " + Mtipus + " - besorolás: " + Besorolas + " - cikkszám: " + Cikkszam;
        }

        public override string CSVFormatum()
        {
            return "Műszaki cikk: "+ base.CSVFormatum()+$"{Arszamitas()};{Besorolas};{Mtipus};{Cikkszam};";
        }

        public override string TxtFormatum()
        {
            return "Műszaki cikk: "+base.TxtFormatum()+$",{Arszamitas()},{Besorolas},{Mtipus},{Cikkszam}";
        }
    }
}
