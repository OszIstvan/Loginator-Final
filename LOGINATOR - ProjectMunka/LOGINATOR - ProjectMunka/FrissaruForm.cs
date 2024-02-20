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
public partial class FrissaruForm : Form
    {
        List<Frissaru> frissKeszlet;
        Frissaru frissaru;
        Frissaru abfrissaru;

        public FrissaruForm()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(FrTermekTipus));
            frissKeszlet = new List<Frissaru>();
        }

        internal Frissaru Frissaru { get => frissaru; set => frissaru = value; }
        internal Frissaru Abfrissaru { get => abfrissaru; set => abfrissaru = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    Frissaru = new Frissaru(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (FrTermekTipus)comboBox1.SelectedIndex, (int)numericUpDown3.Value, Convert.ToDateTime(textBox3.Text).Date);

                    foreach (Frissaru item in frissKeszlet)
                    {
                        frissKeszlet.Add(item);
                    }
                    if(Abfrissaru == null)
                    {
                        Abfrissaru = new Frissaru(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (FrTermekTipus)comboBox1.SelectedIndex, (int)numericUpDown3.Value, Convert.ToDateTime(textBox3.Text).Date);
                    }
                    ABKezelo.Beszuras(Abfrissaru);
                    ABForm frissAb = new ABForm();
                    frissAb.ShowDialog();
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
    }
}
