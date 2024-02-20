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
    public partial class AruFelviteEll : Form
    {
        string termeknev;
        BTermek termektipus;
        long mennyiseg;
        string rakterulet;
        string pozicio;
        int cikkszam;
        int szamlaszam;

        internal AruFelviteEll(string termeknev, BTermek termektipus, long mennyiseg, string rakterulet, string pozicio, int cikkszam, int szamlaszam)
        {
            InitializeComponent();
            textBox1.Enabled = false;
            Termeknev = termeknev;
            textBox2.Enabled = false;
            Termektipus = termektipus;
            textBox3.Enabled = false;
            Mennyiseg = mennyiseg;
            textBox4.Enabled = false;
            Rakterulet = rakterulet;
            textBox5.Enabled = false;
            Pozicio = pozicio;
            textBox6.Enabled = false;
            Cikkszam = cikkszam;
            textBox7.Enabled = false;
            Szamlaszam = szamlaszam;
        }

        public string Termeknev { get => termeknev; set => termeknev = value; }
        public long Mennyiseg { get => mennyiseg; set => mennyiseg = value; }
        public string Rakterulet { get => rakterulet; set => rakterulet = value; }
        public string Pozicio { get => pozicio; set => pozicio = value; }
        internal BTermek Termektipus { get => termektipus; set => termektipus = value; }
        public int Cikkszam { get => cikkszam; set => cikkszam = value; }
        public int Szamlaszam { get => szamlaszam; set => szamlaszam = value; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AruFelviteEll_Activated(object sender, EventArgs e)
        {
            textBox1.Text = Termeknev;
            textBox2.Text = Convert.ToString(Termektipus);
            textBox3.Text = Convert.ToString(Mennyiseg);
            textBox4.Text = Rakterulet;
            textBox5.Text = Pozicio;
            textBox6.Text = Convert.ToString(Cikkszam);
            textBox7.Text = Convert.ToString(Szamlaszam);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
