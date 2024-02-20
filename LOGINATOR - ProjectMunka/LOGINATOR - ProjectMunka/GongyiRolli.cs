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
    public partial class GongyiRolli : Form
    {
        public GongyiRolli()
        {
            InitializeComponent();
        }

        Raklap gongyirolli;

        internal Raklap Gongyirolli { get => gongyirolli; set => gongyirolli = value; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GongyiRolli_Load(object sender, EventArgs e)
        {

        }

        private void GongyiRolli_Activated(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox1.Text = Convert.ToString(Gongyirolli.Tipus);
            textBox2.Text = Convert.ToString(Gongyirolli.Mennyiseg);
            textBox3.Text = Convert.ToString(Gongyirolli.Osszertek);
        }
    }
}
