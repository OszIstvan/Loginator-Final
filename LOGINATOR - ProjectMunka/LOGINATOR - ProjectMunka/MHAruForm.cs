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
    public partial class MHAruForm : Form
    {
        List<MelyhutottAru> MHKeszlet;
        MelyhutottAru melyhutottAru;
        MelyhutottAru abMelyhutott;

        public MHAruForm()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(FTermekTipus));
            MHKeszlet = new List<MelyhutottAru>();
        }

        internal MelyhutottAru MelyhutottAru { get => melyhutottAru; set => melyhutottAru = value; }
        internal MelyhutottAru AbMelyhutott { get => abMelyhutott; set => abMelyhutott = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    MelyhutottAru = new MelyhutottAru(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (FTermekTipus)comboBox1.SelectedIndex,  Convert.ToDateTime(textBox3.Text).Date);

                    foreach (MelyhutottAru item in MHKeszlet)
                    {
                        MHKeszlet.Add(item);
                    }
                    if (AbMelyhutott == null)
                    {
                        AbMelyhutott = new MelyhutottAru(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (FTermekTipus)comboBox1.SelectedIndex, Convert.ToDateTime(textBox3.Text).Date);
                    }
                    ABKezelo.Beszuras(AbMelyhutott);
                    ABForm melyHAB = new ABForm();
                    melyHAB.ShowDialog();
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

        private void MHAruForm_Load(object sender, EventArgs e)
        {

        }
    }
}
