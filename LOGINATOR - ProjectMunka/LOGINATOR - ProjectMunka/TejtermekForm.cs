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
    public partial class TejtermekForm : Form
    {
        List<Tejtermek> tejtermekek;
        Tejtermek tejaru;
        Tejtermek abTejaru;

        public TejtermekForm()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(TTermekTipus));
            Tejtermekek = new List<Tejtermek>();
        }

        internal List<Tejtermek> Tejtermekek { get => tejtermekek; set => tejtermekek = value; }
        internal Tejtermek Tejaru { get => tejaru; set => tejaru = value; }
        internal Tejtermek AbTejaru { get => abTejaru; set => abTejaru = value; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    Tejaru = new Tejtermek(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (TTermekTipus)comboBox1.SelectedIndex, (int)numericUpDown3.Value, Convert.ToDateTime(textBox3.Text).Date);

                    foreach (Tejtermek item in Tejtermekek)
                    {
                        Tejtermekek.Add(item);
                    }
                    if (AbTejaru == null)
                    {
                        AbTejaru = new Tejtermek(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (TTermekTipus)comboBox1.SelectedIndex, (int)numericUpDown3.Value, Convert.ToDateTime(textBox3.Text).Date);
                    }
                    ABKezelo.Beszuras(AbTejaru);
                    ABForm tejAbFrm = new ABForm();
                    tejAbFrm.ShowDialog();
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

        private void TejtermekForm_Load(object sender, EventArgs e)
        {

        }
    }
}
