using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LOGINATOR___ProjectMunka
{
    abstract class Termekek : IComparable
    {
        string cikkszam;
        string megnevezes;
        int db;
        int ar;

        protected Termekek(string cikkszam, string megnevezes, int db, int ar)
        {
            Cikkszam = cikkszam;
            this.Megnevezes = megnevezes;
            this.Db = db;
            this.Ar = ar;
        }

        public string Megnevezes
        {
            get => megnevezes;
            set { if (value.Length > 2) { megnevezes = value; } else { throw new ArgumentException("Túl kevés karaktert adott meg, a terméket így nem lehet beazonosítani. Kérem próbálja újra."); } }
        }
        
        public int Ar
        {
            get => ar;
            set { if (value > 1) { ar = value; } else { value = 100; } }
        }

        public string Cikkszam { get => cikkszam; private set => cikkszam = value; }
        public int Db { get => db; set => db = value; }

        public abstract int Arszamitas();

        public override string ToString()
        {
            return Megnevezes + "\ta termék eladási ára: " + Arszamitas() + " Ft";
        }

        public int CompareTo(object obj)
        {
            if(obj is Termekek termekek)
            {
                return Arszamitas().CompareTo(termekek.Arszamitas());
            }
            throw new ArgumentException("A megadott termékek nem összehasonlíthatók!");
        }

        public virtual string CSVFormatum()
        {
            return $" {Megnevezes}; {Db}; {Ar};";
        }

        /*public static void CSVMentes(List<Termekek> termekek, string fajlnev)
        {
            StreamWriter sw = new StreamWriter(fajlnev);
            foreach (Termekek item in termekek)
            {
                sw.WriteLine(item.CSVFormatum());
            }sw.Close();
        }*/

        public virtual string TxtFormatum()
        {
            return $" {Megnevezes}, {Db}, {Ar},";
        }

        /*public static void TxtMentes(List<Termekek> termekek, string fajlnev)
        {
            StreamWriter sw = new StreamWriter(fajlnev);
            foreach (Termekek item in termekek)
            {
                sw.WriteLine(item.TxtFormatum());
            }sw.Close();
        }*/

        public static double AtlagAr(List<Termekek> termekek)
        {
            double atlag = 0;
            foreach (Termekek item in termekek)
            {
                atlag = atlag + item.Arszamitas(); ;
            }
            atlag = atlag / termekek.Count;
            return atlag;
        }
    }
}
