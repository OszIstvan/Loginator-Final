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
    public partial class GongyolegForm : Form
    {
        internal Gongyoleg Gongyoleg
        {
            get;
            private set;
        }

        RolliKocsi rollikocsi;
        Rekesz rekesz;
        Uveg uveg;
        Raklap raklap;
        internal Raklap Raklap { get => raklap; set => raklap = value; }
        internal Uveg Uveg { get => uveg; set => uveg = value; }
        internal Rekesz Rekesz { get => rekesz; set => rekesz = value; }
        internal RolliKocsi Rollikocsi { get => rollikocsi; set => rollikocsi = value; }

        enum GRaklap
        {
            EUR,
            CEP,
            Egyutas,
            Egyéb,
            Nagyméretű
        }

        enum UvegT
        {
            Boros,
            Sörös,
            Szörpös,
            Üdítős,
            Pálinkás
        }

        enum RekeszT
        {
            Pék_alacsony,
            Pék_közepes,
            Pék_magas,
            Zöldséges_10,
            Zöldséges_30,
            Zöldséges_50,
            Boros,
            Pálinkás,
            NRW_sörös,
            Standard_sörös,
            Gyártó_Saját_sörös,
        }

        enum RolliTipus
        {
            Virágos,
            Komissiózó,
            Pékáru,
            Húsáru,
            Molnárkocsi,
            Non_Food,
            Zöldséges
        }

        public GongyolegForm()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(GRaklap));
            comboBox2.DataSource = Enum.GetValues(typeof(RekeszT));
            comboBox3.DataSource = Enum.GetValues(typeof(UvegT));
            comboBox4.DataSource = Enum.GetValues(typeof(RolliTipus));
        }

        internal GongyolegForm(Gongyoleg modosit) : this()
        {
            Gongyoleg = modosit;
            comboBox1.SelectedItem = modosit.Tipus;
            numericUpDown1.Value = Convert.ToDecimal(modosit.Mennyiseg);
            numericUpDown2.Value = Convert.ToDecimal(modosit.Osszertek);

            if (modosit is Raklap raklap)
            {
                Raklap = new Raklap(Convert.ToString(comboBox1.SelectedIndex), (double)numericUpDown1.Value, (long)numericUpDown2.Value);
            }
            else if (modosit is Uveg uveg)
            {
                Uveg = new Uveg(Convert.ToString(comboBox3.SelectedIndex), (double)numericUpDown5.Value, (long)numericUpDown6.Value);
            }
            else if(modosit is Rekesz rekesz)
            {
                Rekesz = new Rekesz(Convert.ToString(comboBox2.SelectedIndex), (double)numericUpDown3.Value, (long)numericUpDown4.Value);
            }
            else if(modosit is RolliKocsi rollikocsi)
            {
                Rollikocsi = new RolliKocsi(Convert.ToString(comboBox4.SelectedIndex), (double)numericUpDown7.Value, (long)numericUpDown8.Value);
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is GroupBox)
                {
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                    groupBox4.Enabled = false;
                    groupBox1.Enabled = true;
                }
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is GroupBox)
                {
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox4.Enabled = false;
                    groupBox3.Enabled = true;
                }
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is GroupBox)
                {
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                    groupBox4.Enabled = true;
                }
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is GroupBox)
                {
                    groupBox1.Enabled = false;
                    groupBox3.Enabled = false;
                    groupBox4.Enabled = false;
                    groupBox2.Enabled = true;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GongyiRaklap gongyirak = new GongyiRaklap();
            gongyirak.Gongyiraklap = new Raklap(Convert.ToString(comboBox1.SelectedItem), (double)numericUpDown1.Value, (long)numericUpDown2.Value);
            gongyirak.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GongyiUveg gongyiuveg = new GongyiUveg();
            gongyiuveg.Gongyiuveg = new Raklap(Convert.ToString(comboBox3.SelectedItem), (double)numericUpDown5.Value, (long)numericUpDown6.Value);
            gongyiuveg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GongyiRekesz gongyirekesz = new GongyiRekesz();
            gongyirekesz.Gongyirekesz = new Raklap(Convert.ToString(comboBox2.SelectedItem), (double)numericUpDown3.Value, (long)numericUpDown4.Value);
            gongyirekesz.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GongyiRolli gongyirolli = new GongyiRolli();
            gongyirolli.Gongyirolli = new Raklap(Convert.ToString(comboBox4.SelectedItem), (double)numericUpDown7.Value, (long)numericUpDown8.Value);
            gongyirolli.ShowDialog();
        }

        private void GongyolegForm_Load(object sender, EventArgs e)
        {

        }
    }
}
