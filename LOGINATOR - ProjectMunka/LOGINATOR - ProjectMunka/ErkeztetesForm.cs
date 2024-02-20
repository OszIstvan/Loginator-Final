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
    public partial class ErkeztetesForm : Form
    {
        Beszallitas beerkezes;

        public ErkeztetesForm()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(BTermek));
            comboBox2.DataSource = Enum.GetValues(typeof(RaklapTipus));
            comboBox3.DataSource = Enum.GetValues(typeof(MennyisegEgyseg));
        }

        internal Beszallitas Beerkezes { get => beerkezes; set => beerkezes = value; }

        private void button1_Click(object sender, EventArgs e)
        {
           if(textBox1.Text != "")
            {
                try
                {
                    Beerkezes = new Beszallitas(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (BTermek)comboBox1.SelectedIndex, textBox3.Text, textBox4.Text, (int)numericUpDown3.Value, (RaklapTipus)comboBox2.SelectedIndex, Convert.ToInt32(textBox5.Text), Convert.ToDateTime(textBox6.Text).Date, (MennyisegEgyseg)comboBox3.SelectedIndex);

                    SzamlazasForm szamlazas = new SzamlazasForm(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (BTermek)comboBox1.SelectedIndex, textBox3.Text, textBox4.Text, (int)numericUpDown3.Value, (RaklapTipus)comboBox2.SelectedIndex, Convert.ToInt32(textBox5.Text), Convert.ToDateTime(textBox6.Text).Date, (MennyisegEgyseg)comboBox3.SelectedIndex);

                    szamlazas.Szamlazas = new Beszallitas(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (BTermek)comboBox1.SelectedIndex, textBox3.Text, textBox4.Text, (int)numericUpDown3.Value, (RaklapTipus)comboBox2.SelectedIndex, Convert.ToInt32(textBox5.Text), Convert.ToDateTime(textBox6.Text).Date, (MennyisegEgyseg)comboBox3.SelectedIndex);
                    szamlazas.ShowDialog();

                    SzamlazasForm beszamlazas = new SzamlazasForm(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (BTermek)comboBox1.SelectedIndex, textBox3.Text, textBox4.Text, (int)numericUpDown3.Value, (RaklapTipus)comboBox2.SelectedIndex, Convert.ToInt32(textBox5.Text), Convert.ToDateTime(textBox6.Text).Date, (MennyisegEgyseg)comboBox3.SelectedIndex);
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

        private void ErkeztetesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
