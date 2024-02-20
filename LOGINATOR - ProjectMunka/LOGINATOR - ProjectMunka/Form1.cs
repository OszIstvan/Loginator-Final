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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Üdvözöljük!";
        }

        private void beszallitasBtn_Click(object sender, EventArgs e)
        {
            BeszallitasFrm beszallitas = new BeszallitasFrm();
            beszallitas.ShowDialog();
        }

        private void kiszallitasBtn_Click(object sender, EventArgs e)
        {
            KiszallitasFrm kiszallitas = new KiszallitasFrm();
            kiszallitas.ShowDialog();
        }

        private void raktarozasBtn_Click(object sender, EventArgs e)
        {
            RaktarozasFrm raktarozas = new RaktarozasFrm();
            raktarozas.ShowDialog();
        }

        private void selejtKezelesBtn_Click(object sender, EventArgs e)
        {
            SelejtKezelesFrm selejt = new SelejtKezelesFrm();
            selejt.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
