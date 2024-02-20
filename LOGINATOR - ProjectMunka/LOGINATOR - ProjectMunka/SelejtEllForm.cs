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
    public partial class SelejtEllForm : Form
    {
        string termek;
        string cikkszam;
        int mennyiseg;
        Mertekegyseg mertekegyseg;
        long osszar;

        internal SelejtEllForm(string Termek, string Cikkszam, int Mennyiseg, Mertekegyseg Mertekegyseg, long Osszar)
        {
            InitializeComponent();
            textBox1.Enabled = false;
            termek = Termek;
            textBox5.Enabled = false;
            cikkszam = Cikkszam;
            textBox2.Enabled = false;
            mennyiseg = Mennyiseg;
            textBox3.Enabled = false;
            mertekegyseg = Mertekegyseg;
            textBox4.Enabled = false;
            osszar = Osszar;
        }

        public string Cikkszam { get => cikkszam; set => cikkszam = value; }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelejtEllForm_Activated(object sender, EventArgs e)
        {
            textBox1.Text = termek;
            textBox5.Text = cikkszam;
            textBox2.Text = Convert.ToString(mennyiseg);
            textBox3.Text = Convert.ToString(mertekegyseg);
            textBox4.Text = Convert.ToString(osszar);
        }
    }
}
