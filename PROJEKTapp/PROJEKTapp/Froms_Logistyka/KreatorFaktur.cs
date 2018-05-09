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
    public partial class KreatorFaktur : Form
    {
        KWZP_PROJEKTEntities db;
        FIRMY firma;
        FAKTURY faktury;
        ZLECENIA zlecenie;

        public KreatorFaktur(KWZP_PROJEKTEntities db, ZLECENIA zlecenie)
        {
            
            this.zlecenie = zlecenie;
            this.db = db;
            InitializeComponent();

            comboBoxPracownik.DataSource = db.PRACOWNICY.ToList();
            comboBoxPracownik.DisplayMember = "Nazwisko";
            FAKTURY nowaFaktura = new FAKTURY();
            nowaFaktura.ID_ZLECENIA = zlecenie.ID_ZLECENIA;
            DateTime dataWystawienia = DateTime.Now;
            DateTime dataPlatnosci = dataWystawienia.AddDays(30);
            nowaFaktura.DATA_WYSTAWIENIA = dataWystawienia;
            nowaFaktura.DATA_PLATNOSCI = dataPlatnosci;
            //nowaFaktura.KWOTA = KOSZT?

            txtbox_data_plat.Text = dataPlatnosci.ToShortDateString();
            txtbox_data_wyst.Text = dataWystawienia.ToShortDateString();
            int kwota = 50000;
            txtbox_kwota.Text = kwota.ToString();
            //txtbox_kwota;
            //txtbox_kwota_zl;
            //txtbox_nr_faktury.Text = ;
            // txtbox_nr_zlec;
            //txtbox_wal;
            comboBox_kwotaWal.DataSource = db.FAKTURY.ToList();

            comboBox_kwotaWal.DisplayMember = "WALUTA";
            

        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    } 

}
