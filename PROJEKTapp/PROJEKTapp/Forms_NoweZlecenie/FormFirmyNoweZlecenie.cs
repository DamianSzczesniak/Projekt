using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp.Forms
{
    public partial class FormFirmyNoweZlecenie : Form
    {
        KWZP_PROJEKTEntities db = new KWZP_PROJEKTEntities();
        public FormFirmyNoweZlecenie()
        {
            InitializeComponent();

            var firmyPodglad = from FIRMY in db.FIRMY
                               select new { FIRMY.NAZWA_FIRMY, FIRMY.NIP };


            

            dataGridFirmy.DataSource = firmyPodglad.ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajFirme_Click(object sender, EventArgs e)
        {
            FIRMY nowaFirma = new FIRMY();
            nowaFirma.NAZWA_FIRMY = txtB_NazwaFirmy.Text;
            nowaFirma.ADRES_EMAIL = txtBAdresEmail.Text;
            nowaFirma.NR_TELEFONU = txtB_NrTelefonu.Text;
            nowaFirma.NIP = txtB_Nip.Text;


            db.FIRMY.Add(nowaFirma);
            db.SaveChanges();
            var firmyPodglad = from FIRMY in db.FIRMY
                               select new { FIRMY.NAZWA_FIRMY, FIRMY.NIP };
            dataGridFirmy.Refresh();

           // txtB_NazwaFirmy.Clear();
            // txtB_NrTelefonu.Clear();
            // txtB_Nip.Clear();
            // txtBAdresEmail.Clear();
            this.Close();
            FormFirmyNoweZlecenie FormFirmyNoweZlecenie = new FormFirmyNoweZlecenie();
            FormFirmyNoweZlecenie.Show();
        }
    }
}
