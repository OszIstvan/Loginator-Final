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
    public partial class GongyiUveg : Form
    {
        public GongyiUveg()
        {
            InitializeComponent();
        }

        Raklap gongyiuveg;

        internal Raklap Gongyiuveg { get => gongyiuveg; set => gongyiuveg = value; }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GongyiUveg_Activated(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox1.Text = Gongyiuveg.Tipus;
            textBox2.Text = Convert.ToString(Gongyiuveg.Mennyiseg);
            textBox3.Text = Convert.ToString(Gongyiuveg.Osszertek);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
