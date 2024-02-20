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
    public partial class KiszallitasFrm : Form
    {
        string cikkszam;
        string megnevezes;
        int mennyiseg;
        int osszertek;
        KTermek termekjelleg;
        string fuvarozo;
        string nyugtaszam;
        int raklap;
        KRaklapTipus rtipus;
        int fuvarszam;
        DateTime kiszallit;
        MennyisegiEgyseg egyseg;

        public KiszallitasFrm()
        {
            InitializeComponent();
        }

        private void megseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aruOsszekeszitesBtn_Click(object sender, EventArgs e)
        {
            KisszallitForm kiForm = new KisszallitForm();
            if (kiForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    cikkszam = kiForm.Kiszallitas.Cikkszam;
                    megnevezes = kiForm.Kiszallitas.Megnevezes;
                    mennyiseg = kiForm.Kiszallitas.Mennyiseg;
                    osszertek = kiForm.Kiszallitas.Osszertek;
                    termekjelleg = kiForm.Kiszallitas.Termekjelleg;
                    fuvarozo = kiForm.Kiszallitas.Fuvarozo;
                    nyugtaszam = kiForm.Kiszallitas.Nyugtaszam;
                    raklap = kiForm.Kiszallitas.Raklap;
                    rtipus = (KRaklapTipus)kiForm.Kiszallitas.Rtipus;
                    fuvarszam = kiForm.Kiszallitas.Fuvarszam;
                    kiszallit = kiForm.Kiszallitas.Kiszallit;
                    egyseg = kiForm.Kiszallitas.Egyseg;
                }
                catch (Exception)
                {

                    MessageBox.Show("A mezők kitöltése kötelező!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void gongyolegBtn_Click(object sender, EventArgs e)
        {
            GongyolegForm gongyoleg = new GongyolegForm();
            if (gongyoleg.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void szamlazasBtn_Click(object sender, EventArgs e)
        {
            KiSzamlazas kiszamlazas = new KiSzamlazas(cikkszam, megnevezes, mennyiseg, osszertek, termekjelleg, fuvarozo, Convert.ToInt32(nyugtaszam), raklap, (KRaklapTipus)rtipus, fuvarszam,  kiszallit,  egyseg);
            kiszamlazas.ShowDialog();
        }
    }
}
