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
    enum Mertekegyseg
    {
        Kilogramm,
        Liter,
        Darab
    }

    public partial class SelejtForm : Form
    {
        Selejt selejt;
        List<Selejt> selejtKeszlet;

        internal Selejt Selejt { get => selejt; set => selejt = value; }
        internal List<Selejt> SelejtKeszlet { get => selejtKeszlet; set => selejtKeszlet = value; }

        public SelejtForm()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(Mertekegyseg));
            SelejtKeszlet  = new List<Selejt>();
        }

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
                    Selejt = new Selejt(textBox1.Text, (long)numericUpDown1.Value, (Mertekegyseg)comboBox1.SelectedItem, (long)numericUpDown2.Value);

                    SelejtEllForm selejtell = new SelejtEllForm(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (Mertekegyseg)comboBox1.SelectedItem, (long)numericUpDown2.Value);
                    selejtell.ShowDialog();

                    foreach (Selejt item in SelejtKeszlet)
                    {
                        SelejtKeszlet.Add(item);
                    }
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
    }
}
