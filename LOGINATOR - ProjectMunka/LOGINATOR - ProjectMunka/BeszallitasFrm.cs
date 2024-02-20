using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGINATOR___ProjectMunka
{
    public partial class BeszallitasFrm : Form
    {
        Beszallitas beszallitas;
        string cikkszam;
        string termeknev;
        int mennyiseg;
        int osszertek;
        BTermek termekjelleg;
        string beszallito;
        string nyugtaszam;
        int raklapszam;
        RaklapTipus raklaptipus;
        int fuvarszam;
        DateTime datum;
        MennyisegEgyseg egyseg;

        internal Beszallitas Beszallitas { get => beszallitas; set => beszallitas = value; }
        public string Beszallito { get => beszallito; set => beszallito = value; }
        public string Nyugtaszam { get => nyugtaszam; set => nyugtaszam = value; }
        public string Termeknev { get => termeknev; set => termeknev = value; }
        public int Raklapszam { get => raklapszam; set => raklapszam = value; }
        internal RaklapTipus Raklaptipus { get => raklaptipus; set => raklaptipus = value; }
        public int Fuvarszam { get => fuvarszam; set => fuvarszam = value; }
        public int Osszertek { get => osszertek; set => osszertek = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public int Mennyiseg { get => mennyiseg; set => mennyiseg = value; }
        internal MennyisegEgyseg Egyseg { get => egyseg; set => egyseg = value; }
        public string Cikkszam { get => cikkszam; set => cikkszam = value; }
        internal BTermek Termekjelleg { get => termekjelleg; set => termekjelleg = value; }

        public BeszallitasFrm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AruFelvetel arufelvetel = new AruFelvetel();
            if (arufelvetel.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void BeszallitasFrm_Load(object sender, EventArgs e)
        {

        }

        private void megseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void erkeztetesBtn_Click(object sender, EventArgs e)
        {
            ErkeztetesForm erkeztetes = new ErkeztetesForm();
            if (erkeztetes.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Beszallitas = erkeztetes.Beerkezes;
                    cikkszam = erkeztetes.Beerkezes.Cikkszam;
                    termeknev = erkeztetes.Beerkezes.Megnevezes;
                    mennyiseg = erkeztetes.Beerkezes.Db;
                    osszertek = erkeztetes.Beerkezes.Ar;
                    Termekjelleg = erkeztetes.Beerkezes.Termekjelleg;
                    beszallito = erkeztetes.Beerkezes.Beszallito;
                    nyugtaszam = erkeztetes.Beerkezes.Nyugtaszam;
                    raklapszam = erkeztetes.Beerkezes.Raklapdb;
                    raklaptipus = erkeztetes.Beerkezes.Rtipus;
                    fuvarszam = erkeztetes.Beerkezes.Fuvarszam;
                    datum = erkeztetes.Beerkezes.Beerkezes;
                    egyseg = erkeztetes.Beerkezes.Egyseg;
                }
                catch (Exception)
                {

                    MessageBox.Show("A mezők kitöltése kötelező!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SzamlazasForm szamlazas = new SzamlazasForm(Cikkszam, Termeknev, Mennyiseg, Osszertek, Termekjelleg, Beszallito, Nyugtaszam,  Raklapszam, Raklaptipus, Fuvarszam,  Datum,  Egyseg);
            szamlazas.ShowDialog();
        }
    }
}
