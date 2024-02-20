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
    public partial class GongyiRaklap : Form
    { 
        public GongyiRaklap()
        {
            InitializeComponent();
        }

        Raklap gongyiraklap;

        internal Raklap Gongyiraklap { get => gongyiraklap; set => gongyiraklap = value; }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GongyiRaklap_Activated(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox1.Text = Convert.ToString(Gongyiraklap.Tipus);
            textBox2.Text = Convert.ToString(Gongyiraklap.Mennyiseg);
            textBox3.Text = Convert.ToString(Gongyiraklap.Osszertek);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
