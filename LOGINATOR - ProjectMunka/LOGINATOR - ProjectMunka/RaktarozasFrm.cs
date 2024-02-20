using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LOGINATOR___ProjectMunka
{
    public partial class RaktarozasFrm : Form
    {
        List<Termekek> osszesTermek;
        List<Frissaru> frissKeszlet;
        List<MelyhutottAru> MHKeszlet;
        List<Tejtermek> tejkeszlet;
        List<Szarazaru> szarazKeszlet;
        List<MuszakiCikk> muszakiKeszlet;

        public RaktarozasFrm()
        {
            InitializeComponent();
            osszesTermek = new List<Termekek>();
            frissKeszlet = new List<Frissaru>();
            MHKeszlet = new List<MelyhutottAru>();
            tejkeszlet = new List<Tejtermek>();
            szarazKeszlet = new List<Szarazaru>();
            muszakiKeszlet = new List<MuszakiCikk>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RaktarozasFrm_Load(object sender, EventArgs e)
        {


        }

        public void FrissBoxF()
        {
            try
            {
                FrissaruForm frissFelvitel = new FrissaruForm();
                if (frissFelvitel.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Add(frissFelvitel.Frissaru);
                }
                foreach (Frissaru item in frissKeszlet)
                {
                    frissKeszlet.Add(item);
                }
                foreach (Frissaru item in frissKeszlet)
                {
                    listBox1.Items.Add(item);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("A mezők kitöltése kötelező!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FrissBoxF();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && MessageBox.Show("Valóban törölni kívánja a kijelölt elemet?", "TÖRLÉS!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

        }

        public void MelyHBoxF()
        {
            MHAruForm MHFelvitel = new MHAruForm();
            if (MHFelvitel.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(MHFelvitel.MelyhutottAru);
            }
            foreach (MelyhutottAru item in MHKeszlet)
            {
                MHKeszlet.Add(item);
            }
            foreach (MelyhutottAru item in MHKeszlet)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MelyHBoxF();
            }
            catch (Exception)
            {
                MessageBox.Show("A mezők kitöltése kötelező!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (osszesTermek.Count != -1)
            {
                foreach (Termekek item in listBox1.Items)
                {
                    osszesTermek.Add(item);
                }
                if (listBox1.Items.Count > 0 && saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.UTF8);
                    foreach (Termekek item in osszesTermek)
                    {
                        sw.WriteLine(item.CSVFormatum());
                    }
                    sw.Close();
                }
                else
                {
                    MessageBox.Show("A lista nem tartalmaz elemeket!\nKérem töltse fel a listát a nyomtatás előtt!", "Üres lista!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (osszesTermek.Count != -1)
            {
                foreach (Termekek item in listBox1.Items)
                {
                    osszesTermek.Add(item);
                }
                if (listBox1.Items.Count > 0 && saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.UTF8);
                    foreach (Termekek item in osszesTermek)
                    {
                        sw.WriteLine(item.TxtFormatum());
                    }
                    sw.Close();
                }
                else
                {
                    MessageBox.Show("A lista nem tartalmaz elemeket!\nKérem töltse fel a listát a nyomtatás előtt!", "Üres lista!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void TejBoxF()
        {
            TejtermekForm TejFelvitel = new TejtermekForm();
            if (TejFelvitel.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(TejFelvitel.Tejaru);
            }
            foreach (Tejtermek item in tejkeszlet)
            {
                tejkeszlet.Add(item);
            }
            foreach (Tejtermek item in tejkeszlet)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                TejBoxF();
            }
            catch (Exception)
            {
                MessageBox.Show("A mezők kitöltése kötelező!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SzarazBoxF()
        {
            SzarazaruForm SzarazFelvitel = new SzarazaruForm();
            if (SzarazFelvitel.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(SzarazFelvitel.SzarazAru);
            }
            foreach (Szarazaru item in szarazKeszlet)
            {
                szarazKeszlet.Add(item);
            }
            foreach (Szarazaru item in szarazKeszlet)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SzarazBoxF();
            }
            catch (Exception)
            {
                MessageBox.Show("A mezők kitöltése kötelező!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void MuszakiBoxF()
        {
            MuszakiForm MuszakiFelvitel = new MuszakiForm();
            if (MuszakiFelvitel.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(MuszakiFelvitel.MuszakiCikk);
            }
            foreach (MuszakiCikk item in muszakiKeszlet)
            {
                muszakiKeszlet.Add(item);
            }
            foreach (MuszakiCikk item in muszakiKeszlet)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MuszakiBoxF();
            }
            catch (Exception)
            {
                MessageBox.Show("A mezők kitöltése kötelező!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ABForm adatForm = new ABForm();
            adatForm.ShowDialog();
        }
    }
}
