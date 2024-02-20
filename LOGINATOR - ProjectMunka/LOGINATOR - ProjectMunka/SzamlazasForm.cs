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
    public partial class SzamlazasForm : Form
    {
        Beszallitas szamlazas;

        string cikkszam;
        string termeknev;
        int mennyiseg;
        int ar;
        BTermek termekjelleg;
        string beszallito;
        string nyugtaszam;
        int raklapszam;
        RaklapTipus raklaptipus;
        int fuvarszam;
        DateTime datum;
        MennyisegEgyseg egyseg;
        internal Beszallitas Szamlazas { get => szamlazas; set => szamlazas = value; }

        internal SzamlazasForm(string Cikkszam, string Termeknev, int Mennyiseg, int Ar, BTermek Termekjelleg, string Beszallito, string Nyugtaszam, int Raklapszam, RaklapTipus Raklaptipus, int Fuvarszam, DateTime Datum, MennyisegEgyseg Egyseg)
        {
            InitializeComponent();
            textBox1.Enabled = false;
            cikkszam = Cikkszam;
            textBox2.Enabled = false;
            termeknev = Termeknev;
            textBox3.Enabled = false;
            mennyiseg = Mennyiseg;
            textBox4.Enabled = false;
            ar = Ar;
            textBox5.Enabled = false;
            termekjelleg = Termekjelleg;
            textBox6.Enabled = false;
            beszallito = Beszallito;
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

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog nyomtatas = new PrintDialog();
            if (nyomtatas.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void SzamlazasForm_Activated(object sender, EventArgs e)
        {
            textBox1.Text = cikkszam;
            textBox2.Text = termeknev;
            textBox3.Text = Convert.ToString(mennyiseg);
            textBox4.Text = Convert.ToString(ar);
            textBox5.Text = Convert.ToString(termekjelleg);
            textBox6.Text = beszallito;
            textBox7.Text = nyugtaszam;
            textBox8.Text = Convert.ToString(raklapszam);
            textBox9.Text = Convert.ToString(raklaptipus);
            textBox10.Text = Convert.ToString(fuvarszam);
            textBox11.Text = Convert.ToString(datum);
            textBox12.Text = Convert.ToString(egyseg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
