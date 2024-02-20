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
    public partial class SzarazaruForm : Form
    {
        List<Szarazaru> szarazAruk;
        Szarazaru szarazAru;
        Szarazaru abSzarazaru;

        public SzarazaruForm()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(SzTermekek));
            szarazAruk = new List<Szarazaru>();
        }

        internal Szarazaru SzarazAru { get => szarazAru; set => szarazAru = value; }
        internal Szarazaru AbSzarazaru { get => abSzarazaru; set => abSzarazaru = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    SzarazAru = new Szarazaru(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (SzTermekek)comboBox1.SelectedIndex, (int)numericUpDown3.Value, Convert.ToDateTime(textBox3.Text).Date);

                    foreach (Szarazaru item in szarazAruk)
                    {
                        szarazAruk.Add(SzarazAru);
                    }
                    if (AbSzarazaru == null)
                    {
                        AbSzarazaru = new Szarazaru(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (SzTermekek)comboBox1.SelectedIndex, (int)numericUpDown3.Value, Convert.ToDateTime(textBox3.Text).Date);
                    }
                    ABKezelo.Beszuras(AbSzarazaru);
                    ABForm szarazFrm = new ABForm();
                    szarazFrm.ShowDialog();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Hiba történt az adatfelvitel közben!\n\nKérem ellenőrizze a mezőkbe felvitt adatok helyességét!\n\nA hiba részletei:\n" + ex, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("A megnevezés mező kitöltése kötelező!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SzarazaruForm_Load(object sender, EventArgs e)
        {

        }
    }
}
