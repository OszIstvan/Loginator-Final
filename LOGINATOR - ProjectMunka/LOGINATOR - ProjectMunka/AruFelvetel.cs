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
    public partial class AruFelvetel : Form
    {
        public enum Rakterulet
        {
            Szárazáru,
            Hűtött_áru,
            Mélyhűtött_áru,
            Vegyiáru,
            Göngyöleg,
            Egyéb
        }

        string megnevezes;
        BTermek termektipus;
        long mennyiseg;
        Rakterulet terulet;
        string pozicio;
        int cikkszam;
        int szamlaszam;

        AruFelvetel arufelvetel;

        public string Megnevezes { get => megnevezes; set => megnevezes = value; }
        public long Mennyiseg { get => mennyiseg; set => mennyiseg = value; }
        public string Pozicio { get => pozicio; set => pozicio = value; }
        internal BTermek Termektipus { get => termektipus; set => termektipus = value; }
        public Rakterulet Terulet { get => terulet; set => terulet = value; }
        public AruFelvetel Arufelvetel { get => arufelvetel; set => arufelvetel = value; }
        public int Cikkszam { get => cikkszam; set => cikkszam = value; }
        public int Szamlaszam { get => szamlaszam; set => szamlaszam = value; }

        public AruFelvetel()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(BTermek));
            comboBox2.DataSource = Enum.GetValues(typeof(Rakterulet));
        }

        internal AruFelvetel(string megnevezes, BTermek termektipus, long mennyiseg, Rakterulet terulet, string pozicio, int cikkszam, int szamlaszam)
        {
            this.Megnevezes = megnevezes;
            this.Mennyiseg = mennyiseg;
            this.Pozicio = pozicio;
            Cikkszam = cikkszam;
            Szamlaszam = szamlaszam;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                try
                {
                    Arufelvetel = new AruFelvetel(textBox1.Text, (BTermek)comboBox1.SelectedIndex, (long)numericUpDown1.Value, (Rakterulet)comboBox2.SelectedIndex, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));

                    AruFelviteEll aruFelvEll = new AruFelviteEll(textBox1.Text, (BTermek)comboBox1.SelectedIndex, (long)numericUpDown1.Value, Convert.ToString((Rakterulet)comboBox2.SelectedIndex), textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
                    aruFelvEll.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba történt az adatfelvitel közben!\n\nKérem ellenőrizze a mezőkbe felvitt adatok helyességét!\n\nA hiba részletei:\n\n" + ex, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("A megnevezés mező kitöltése kötelező!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
            

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
