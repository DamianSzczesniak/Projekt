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
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnGeneruj_Click(object sender, EventArgs e)
        {
            FAKTURY nowaFaktura = new FAKTURY();
            nowaFaktura.ID_ZLECENIA = zlecenie.ID_ZLECENIA;
            DateTime dataWystawienia = DateTime.Now;
            DateTime dataPlatnosci = dataWystawienia.AddDays(30);
            nowaFaktura.DATA_WYSTAWIENIA = dataWystawienia;
            nowaFaktura.DATA_PLATNOSCI = dataPlatnosci;
            //nowaFaktura.KWOTA = 


            //db.SaveChanges();   
            
        }

        private void listBox_dane_firmy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox_dane_firmy.DataSource = db.FIRMY.ToArray();
        }


    }

}
