using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGINATOR___ProjectMunka
{
    enum KTermek
    {
        Fagyasztottáru,
        Frissáru,
        Gyümölcs,
        Szárazáru,
        Műszakicikk,
        Tejtermék,
        Zöldség,
        Vegyes
    }

    enum KRaklapTipus
    {
        EUR,
        CEP,
        Egyutas,
        Egyéb_betétes,
        Egyéb_nem_betétes
    }

    enum MennyisegiEgyseg
    {
        Darab,
        Kg,
        Liter
    }

    class Kiszallitas
    {
        string cikkszam;
        string megnevezes;
        int mennyiseg;
        int osszertek;
        KTermek termekjelleg;
        string fuvarozo;
        string nyugtaszam;
        int raklap;
        KRaklapTipus rtipus;
        int fuvarszam;
        DateTime kiszallit;
        MennyisegiEgyseg egyseg;

        public Kiszallitas(string cikkszam, string megnevezes, int mennyiseg, int osszertek, KTermek termekjelleg, string fuvarozo, string nyugtaszam, int raklap, KRaklapTipus rtipus, int fuvarszam, DateTime kiszallit, MennyisegiEgyseg egyseg)
        {
            Cikkszam = cikkszam;
            Megnevezes = megnevezes;
            Mennyiseg = mennyiseg;
            this.Osszertek = osszertek;
            this.Termekjelleg = termekjelleg;
            this.Fuvarozo = fuvarozo;
            this.Nyugtaszam = nyugtaszam;
            this.Raklap = raklap;
            this.Rtipus = rtipus;
            this.Fuvarszam = fuvarszam;
            this.Kiszallit = kiszallit;
            Egyseg = egyseg;
        }

        public string Fuvarozo { get => fuvarozo; set => fuvarozo = value; }
        public string Nyugtaszam { get => nyugtaszam; set => nyugtaszam = value; }
        public int Raklap { get => raklap; set => raklap = value; }
        public int Fuvarszam { get => fuvarszam; set => fuvarszam = value; }
        public int Osszertek { get => osszertek; set => osszertek = value; }
        public DateTime Kiszallit { get => kiszallit; set => kiszallit = value; }
        public int Mennyiseg { get => mennyiseg; set => mennyiseg = value; }
        public MennyisegiEgyseg Egyseg { get => egyseg; set => egyseg = value; }
        public string Cikkszam { get => cikkszam; set => cikkszam = value; }
        public string Megnevezes { get => megnevezes; set => megnevezes = value; }
        internal KTermek Termekjelleg { get => termekjelleg; set => termekjelleg = value; }
        internal KRaklapTipus Rtipus { get => rtipus; set => rtipus = value; }

        public override string ToString()
        {
            return Cikkszam + " - " + Megnevezes + " - " + Mennyiseg + " - " + Osszertek + " - " + Termekjelleg + " - " + Fuvarozo + " - " + Nyugtaszam + " - " + Raklap + " - " + Rtipus + " - " + Fuvarszam + " - " + Kiszallit+" - "+Egyseg;
        }
    }
}
