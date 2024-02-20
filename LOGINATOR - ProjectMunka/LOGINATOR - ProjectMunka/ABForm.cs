using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.VisualBasic;

namespace LOGINATOR___ProjectMunka
{
    public partial class ABForm : Form
    {
        public ABForm()
        {
            InitializeComponent();
        }

        private void LBFrissit()
        {
            try
            {
                listBox1.DataSource = null;
                List<Termekek> termekek = ABKezelo.Olvasas();
                listBox1.DataSource = termekek;
                listView1.View = View.Details;
                listView1.Items.Clear();
                if (listView1.Columns.Count == 0)
                {
                    foreach (PropertyInfo item in typeof(Termekek).GetProperties())
                    {
                        listView1.Columns.Add(item.Name);
                    }
                }
                foreach (Termekek item in termekek)
                {
                    string[] sor = new string[typeof(Termekek).GetProperties().Length];
                    int i = 0;
                    foreach (PropertyInfo info in typeof(Termekek).GetProperties())
                    {
                        sor[i] = info.GetValue(item).ToString();
                        i++;
                    }
                    listView1.Items.Add(new ListViewItem(sor));
                }
            }
            catch (ABKivetel ex)
            {

                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ABForm_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    LBFrissit();
            //}
            //catch (ABKivetel ex)
            //{

            //    MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex != -1)
                {
                    if (listBox1.SelectedIndex != -1 && MessageBox.Show("Valóban törli a kijelölt terméket az adatbázisból?", "Törlés?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            ABKezelo.Torol((Termekek)listBox1.SelectedItem);
                            LBFrissit();
                        }
                        catch (ABKivetel ex)
                        {
                            MessageBox.Show(ex.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    LBFrissit();
                }
            }
            catch (ABKivetel ex)
            {
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Interaction.InputBox("Az adatbázisba a felvitel sikeresen megtörtént!", "Sikeres felvitel!");
            MessageBox.Show("Az adatok felvitele az adatbázisba sikeresen megtörtént!", "Sikeres felvitel!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ABForm_Activated(object sender, EventArgs e)
        {
            try
            {
                LBFrissit();
            }
            catch (ABKivetel ex)
            {

                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
