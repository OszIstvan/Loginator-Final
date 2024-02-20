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
    public partial class KiSzamlazas : Form
    {
        string cikkszam;
        string megnevezes;
        int mennyiseg;
        int osszertek;
        KTermek termekjelleg;
        string kiszallito;
        int nyugtaszam;
        int raklapszam;
        KRaklapTipus raklaptipus;
        int fuvarszam;
        DateTime datum;
        MennyisegiEgyseg egyseg;

        Kiszallitas kiszallitas;

        internal Kiszallitas Kiszallitas { get => kiszallitas; set => kiszallitas = value; }

        internal KiSzamlazas(string Cikkszam, string Megnevezes, int Mennyiseg, int Osszertek, KTermek Termekjelleg, string Kiszallito, int Nyugtaszam, int Raklapszam, KRaklapTipus Raklaptipus, int Fuvarszam,  DateTime Datum,  MennyisegiEgyseg Egyseg)
        {
            InitializeComponent();
            textBox1.Enabled = false;
            cikkszam = Cikkszam;
            textBox2.Enabled = false;
            megnevezes = Megnevezes;
            textBox3.Enabled = false;
            mennyiseg = Mennyiseg;
            textBox4.Enabled = false;
            osszertek = Osszertek;
            textBox5.Enabled = false;
            termekjelleg = Termekjelleg;
            textBox6.Enabled = false;
            kiszallito = Kiszallito;
            textBox7.Enabled = false;
            nyugtaszam = Nyugtaszam;
            textBox8.Enabled = false;
            raklapszam = Raklapszam;
            textBox9.Enabled = false;
            raklaptipus = Raklaptipus;
            textBox10.Enabled = false;
            fuvarszam = Fuvarszam;
            textBox11.Enabled = false;
            datum = Datum;
            textBox12.Enabled = false;
            egyseg = Egyseg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog nyomtatas = new PrintDialog();
            if (nyomtatas.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void KiSzamlazas_Activated(object sender, EventArgs e)
        {
            textBox1.Text = cikkszam;
            textBox2.Text = megnevezes;
            textBox3.Text = Convert.ToString(mennyiseg);
            textBox4.Text = Convert.ToString(osszertek);
            textBox5.Text = Convert.ToString(termekjelleg);
            textBox6.Text = kiszallito;
            textBox7.Text = Convert.ToString(nyugtaszam);
            textBox8.Text = Convert.ToString(raklapszam);
            textBox9.Text = Convert.ToString(raklaptipus);
            textBox10.Text = Convert.ToString(fuvarszam);
            textBox11.Text = Convert.ToString(datum);
            textBox12.Text = Convert.ToString(egyseg);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
