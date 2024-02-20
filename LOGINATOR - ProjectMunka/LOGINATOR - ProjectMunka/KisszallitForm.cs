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
    public partial class KisszallitForm : Form
    {
        Kiszallitas kiszallitas;

        internal Kiszallitas Kiszallitas { get => kiszallitas; set => kiszallitas = value; }

        public KisszallitForm()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(KTermek));
            comboBox2.DataSource = Enum.GetValues(typeof(KRaklapTipus));
            comboBox3.DataSource = Enum.GetValues(typeof(MennyisegEgyseg));
        }

        private void KisszallitForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                try
                {
                    Kiszallitas = new Kiszallitas(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (KTermek)comboBox1.SelectedIndex, textBox3.Text, textBox4.Text, (int)numericUpDown3.Value, (KRaklapTipus)comboBox2.SelectedIndex, Convert.ToInt32(textBox5.Text), Convert.ToDateTime(textBox6.Text).Date, (MennyisegiEgyseg)comboBox3.SelectedIndex);

                    KiSzamlazas kiszamlazas1 = new KiSzamlazas(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (KTermek)comboBox1.SelectedIndex, textBox3.Text, Convert.ToInt32(textBox4.Text), (int)numericUpDown3.Value, (KRaklapTipus)comboBox2.SelectedIndex, Convert.ToInt32(textBox5.Text), Convert.ToDateTime(textBox6.Text).Date, (MennyisegiEgyseg)comboBox3.SelectedIndex);

                    kiszamlazas1.Kiszallitas = new Kiszallitas(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (KTermek)comboBox1.SelectedIndex, textBox3.Text, textBox4.Text, (int)numericUpDown3.Value, (KRaklapTipus)comboBox2.SelectedIndex, Convert.ToInt32(textBox5.Text), Convert.ToDateTime(textBox6.Text).Date, (MennyisegiEgyseg)comboBox3.SelectedIndex);
                    kiszamlazas1.ShowDialog();

                    KiSzamlazas kiszamlazas = new KiSzamlazas(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (KTermek)comboBox1.SelectedIndex, textBox3.Text, Convert.ToInt32(textBox4.Text), (int)numericUpDown3.Value, (KRaklapTipus)comboBox2.SelectedIndex, Convert.ToInt32(textBox5.Text), Convert.ToDateTime(textBox6.Text).Date, (MennyisegiEgyseg)comboBox3.SelectedIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba történt az adatfelvitel közben!\n\nKérem ellenőrizze a mezőkbe felvitt adatok helyességét!\n\nA hiba részletei:\n\n" + ex, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("A megnevezése mező kitöltése kötelező!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }   

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
