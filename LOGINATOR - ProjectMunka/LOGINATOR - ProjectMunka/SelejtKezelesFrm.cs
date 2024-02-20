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
    public partial class SelejtKezelesFrm : Form
    {
        
        public SelejtKezelesFrm()
        {
            InitializeComponent();
        }

        private void megseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selejtFelvetelBtn_Click(object sender, EventArgs e)
        {
            SelejtForm selejt = new SelejtForm();
            if (selejt.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
