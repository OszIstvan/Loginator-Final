using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGINATOR___ProjectMunka
{
    enum BTermek
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

    enum RaklapTipus
    {
        EUR,
        CEP,
        Egyutas,
        Egyéb_betétes,
        Egyéb_nem_betétes
    }

    enum MennyisegEgyseg
    {
        Darab,
        Kg,
        Liter
    }

    class Beszallitas
    {
        string cikkszam;
        string megnevezes;
        int db;
        int ar;
        BTermek termekjelleg;
        string beszallito;
        string nyugtaszam;
        int raklapdb;
        RaklapTipus rtipus;
        int fuvarszam;
        DateTime beerkezes;
        MennyisegEgyseg egyseg;

        public Beszallitas(string cikkszam, string megnevezes, int db, int ar, BTermek termekjelleg, string beszallito, string nyugtaszam, int raklapdb, RaklapTipus rtipus, int fuvarszam, DateTime beerkezes, MennyisegEgyseg egyseg)
        {
            Cikkszam = cikkszam;
            Megnevezes = megnevezes;
            Db = db;
            Ar = ar;
            Termekjelleg = termekjelleg;
            Beszallito = beszallito;
            Nyugtaszam = nyugtaszam;
            Raklapdb = raklapdb;
            Rtipus = rtipus;
            Fuvarszam = fuvarszam;
            Beerkezes = beerkezes;
            Egyseg = egyseg;
        }

        public string Beszallito { get => beszallito; set => beszallito = value; }
        public string Nyugtaszam { get => nyugtaszam; set => nyugtaszam = value; }
        public int Fuvarszam { get => fuvarszam; set => fuvarszam = value; }
        public DateTime Beerkezes { get => beerkezes; set => beerkezes = value; }
        public string Cikkszam { get => cikkszam; set => cikkszam = value; }
        public string Megnevezes { get => megnevezes; set => megnevezes = value; }
        public int Ar { get => ar; set => ar = value; }
        public int Raklapdb { get => raklapdb; set => raklapdb = value; }
        public int Db { get => db; set => db = value; }
        internal RaklapTipus Rtipus { get => rtipus; set => rtipus = value; }
        internal MennyisegEgyseg Egyseg { get => egyseg; set => egyseg = value; }
        internal BTermek Termekjelleg { get => termekjelleg; set => termekjelleg = value; }

        public override string ToString()
        {
            return Cikkszam + " - " + Megnevezes + " - " + Db +" - " + Ar + " - " + Termekjelleg + " - " + Beszallito + " - " + Nyugtaszam + " - " + Raklapdb+" - "+ Rtipus + " - " + Fuvarszam + " - " + Beerkezes +" - "+Egyseg;
        }
    }
}
