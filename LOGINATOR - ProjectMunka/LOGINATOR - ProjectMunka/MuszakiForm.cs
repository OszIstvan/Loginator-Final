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
    public partial class MuszakiForm : Form
    {
        MuszakiCikk muszakiCikk;
        List<MuszakiCikk> mCikkek;
        MuszakiCikk abMuszaki;

        public MuszakiForm()
        {
            InitializeComponent();
            mCikkek = new List<MuszakiCikk>();
            comboBox1.DataSource = Enum.GetValues(typeof(MTermekTipus));
            comboBox2.DataSource = Enum.GetValues(typeof(Besorolas));
        }

        internal MuszakiCikk MuszakiCikk { get => muszakiCikk; set => muszakiCikk = value; }
        internal MuszakiCikk AbMuszaki { get => abMuszaki; set => abMuszaki = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    MuszakiCikk = new MuszakiCikk(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (MTermekTipus)comboBox1.SelectedIndex, (Besorolas)comboBox2.SelectedIndex);

                    foreach (MuszakiCikk item in mCikkek)
                    {
                        mCikkek.Add(item);
                    }

                    if (AbMuszaki == null)
                    {
                        AbMuszaki = new MuszakiCikk(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (MTermekTipus)comboBox1.SelectedIndex, (Besorolas)comboBox2.SelectedIndex);
                    }
                    ABKezelo.Beszuras(AbMuszaki);
                    ABForm abMForm = new ABForm();
                    abMForm.ShowDialog();
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

        private void MuszakiForm_Load(object sender, EventArgs e)
        {

        }
    }
}
