using PROJEKTapp.Froms_Logistyka;
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
    public partial class FormZmianaStanuMagazynu : Form
    {
        KWZP_PROJEKTEntities db;
        int id;
        int jakaAkcja;
        public FormZmianaStanuMagazynu(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        public FormZmianaStanuMagazynu(KWZP_PROJEKTEntities db, int id, int jakaAkcja)
        {
            this.jakaAkcja = jakaAkcja;
            this.id = id;
            this.db = db;
            InitializeComponent();
            
        }

        private void akcjaSwitch()
        {
            switch(jakaAkcja)
            {
                case 1:
                    {
                        checkBWszystkie.Checked = false;
                        checkBProdukty.Checked = false;
                        checkBMaterialy.Checked = true;

                        var dict = new Dictionary<int, string>();
                        foreach (ZLECENIA row in db.ZLECENIA.Where(a => a.ID_ZLECENIA == id).ToList())
                        {
                            dict.Add(row.ID_ZLECENIA, "  ID_ZLECENIA : " + row.ID_ZLECENIA + " FIRMA : " + row.FIRMY.NAZWA_FIRMY + "  DATA REALIZACJI : " + row.DATA_REALIZACJI.ToShortDateString());
                        }

                        cBoxFlitracja.DataSource = dict.ToList();
                        cBoxFlitracja.ValueMember = "Key";
                        cBoxFlitracja.DisplayMember = "Value";
                        cBoxFlitracja.SelectedIndex = 0;

                        DGV_PRODUKTY.Hide();
                        DGV_MATERIALY.Show();
                        checkBProdukty.Hide();
                        checkBWszystkie.Hide();
                        checkBMaterialy.Hide();
                        btnZdejmij.Hide();
                        dGV_Lista_pobranych_materialow.Hide();
                        dGV_Produkty_Do_Dodania.Hide();
                        dgvListaMaterialowDoZmagazynowania.Show();
                        dgvLokalizacje.Show();

                        dgvLokalizacje.DataSource = db.LOKALIZACJA.Where(a => a.CzyPelne == false).ToList();


                        sTANMATERIALYNAZWYBindingSource.DataSource = db.STAN_MATERIALY_NAZWY.Where(i => i.ID_ZLECENIA == id).ToList();
                        mATERIALYPODODANIUBindingSource.DataSource = db.MATERIALY_PO_DODANIU.Where(i => i.ID_ZLECENIA == id).ToList();

                        if(db.MATERIALY_PO_DODANIU.Where(i => i.ID_ZLECENIA == id).ToList().Count == 0)
                        {
                            DateTime data = DateTime.Now;
                            DATA_STATUSU_ZLECENIA dATA_STATUSU_ = new DATA_STATUSU_ZLECENIA();
                            dATA_STATUSU_.DATA_ZMIANY = data;
                            dATA_STATUSU_.ID_ZLECENIA = id;
                            dATA_STATUSU_.ID_STATUSU_ZLECENIA = 4;
                            db.DATA_STATUSU_ZLECENIA.Add(dATA_STATUSU_);
                            db.SaveChanges();
                            KWZP_PROJEKTEntities kWZP_ = new KWZP_PROJEKTEntities();
                            db = kWZP_;
                            db.SaveChanges();
                            MessageBox.Show("Zrealizowano magazynowanie wszystkich materiałów." + Environment.NewLine + "  Nastąpi zamknięcie formularza . ", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        return;
                    }
                case 2:
                    {
                        checkBWszystkie.Checked = false;
                        checkBProdukty.Checked = false;
                        checkBMaterialy.Checked = true;

                        var dict = new Dictionary<int, string>();
                        foreach (ZLECENIA row in db.ZLECENIA.Where(a => a.ID_ZLECENIA == id).ToList())
                        {
                            dict.Add(row.ID_ZLECENIA, "  ID_ZLECENIA : " + row.ID_ZLECENIA + " FIRMA : " + row.FIRMY.NAZWA_FIRMY + "  DATA REALIZACJI : " + row.DATA_REALIZACJI.ToShortDateString());
                        }

                        cBoxFlitracja.DataSource = dict.ToList();
                        cBoxFlitracja.ValueMember = "Key";
                        cBoxFlitracja.DisplayMember = "Value";
                        cBoxFlitracja.SelectedIndex = 0;

                        DGV_PRODUKTY.Hide();
                        DGV_MATERIALY.Show();
                        checkBProdukty.Hide();
                        checkBWszystkie.Hide();
                        checkBMaterialy.Hide();
                        ButtonDodajRekord.Hide();
                        btnZdejmij.Show();
                        dgvLokalizacje.Hide();
                        lbl_Lokalizacje_Nie_Pelne.Hide();
                        dgvListaMaterialowDoZmagazynowania.Hide();
                        dGV_Produkty_Do_Dodania.Hide();
                        dGV_Lista_pobranych_materialow.Show();


                        dgvLokalizacje.DataSource = db.LOKALIZACJA.Where(a => a.CzyPelne == false).ToList();
                        lbl_Lista_Materialow.Text = "Materiały pobrane przez produkcje do tej pory :";

                       
                        sTANMATERIALYNAZWYBindingSource.DataSource = db.STAN_MATERIALY_NAZWY.Where(i => i.ID_ZLECENIA == id).ToList();
                        mATERIALZDJETYBindingSource.DataSource = db.MATERIAL_ZDJETY.Where(i => i.ID_ZLECENIA == id).ToList();

                        if (db.STAN_MATERIALY_NAZWY.Where(i => i.ID_ZLECENIA == id).ToList().Count == 0)
                        {
                           
                            MessageBox.Show("W magazynie brak materiałów do pobrania." , "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        return;
                    }
                case 3:
                    {
                        checkBWszystkie.Checked = false;
                        checkBProdukty.Checked = true;
                        checkBMaterialy.Checked = false;

                        var dict = new Dictionary<int, string>();
                        foreach (ZLECENIA row in db.ZLECENIA.Where(a => a.ID_ZLECENIA == id).ToList())
                        {
                            dict.Add(row.ID_ZLECENIA, "  ID_ZLECENIA : " + row.ID_ZLECENIA + " FIRMA : " + row.FIRMY.NAZWA_FIRMY + "  DATA REALIZACJI : " + row.DATA_REALIZACJI.ToShortDateString());
                        }

                        cBoxFlitracja.DataSource = dict.ToList();
                        cBoxFlitracja.ValueMember = "Key";
                        cBoxFlitracja.DisplayMember = "Value";
                        cBoxFlitracja.SelectedIndex = 0;

                        DGV_PRODUKTY.Show();
                        DGV_MATERIALY.Hide();
                        checkBProdukty.Hide();
                        checkBWszystkie.Hide();
                        checkBMaterialy.Hide();
                        ButtonDodajRekord.Show();
                        btnZdejmij.Hide();
                        dgvLokalizacje.Hide();
                        lbl_Lokalizacje_Nie_Pelne.Show();
                        dgvLokalizacje.Show();
                        dgvLokalizacje.DataSource = db.LOKALIZACJA.Where(a => a.CzyPelne == false).ToList();
                        dgvListaMaterialowDoZmagazynowania.Hide();
                        dGV_Lista_pobranych_materialow.Hide();
                        dGV_Produkty_Do_Dodania.Show();


                        
                        lbl_Lista_Materialow.Text = "Produkty do wyprodukowania i dostarczenia :";
                        lbl_Lista_Materialow.Text = "Zmagazynowane produkty z danego zlecenia :";

                        //


                        //sTANMATERIALYNAZWYBindingSource.DataSource = db.STAN_MATERIALY_NAZWY.Where(i => i.ID_ZLECENIA == id).ToList();
                        //mATERIALZDJETYBindingSource.DataSource = db.MATERIAL_ZDJETY.Where(i => i.ID_ZLECENIA == id).ToList();

                        //if (db.STAN_MATERIALY_NAZWY.Where(i => i.ID_ZLECENIA == id).ToList().Count == 0)
                        //{

                        //    MessageBox.Show("W magazynie brak materiałów do pobrania.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    this.Close();
                        //}
                        return;
                    }



            }

        }




        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void FormZmianaStanuMagazynu_Load(object sender, EventArgs e)
        {
            akcjaSwitch();
        }

        

        private void btnZdejmij_Click(object sender, EventArgs e)
        {
            int operacja = 2;
            if (checkBMaterialy.Checked)
            {
                using (AkcjaMagazynProduktów AMP = new AkcjaMagazynProduktów(db, checkBMaterialy.Checked, sTANMATERIALYNAZWYBindingSource.Current as STAN_MATERIALY_NAZWY, operacja))
                {
                    if (AMP.ShowDialog() == DialogResult.OK)
                    {
                        zapisZmianWidok();
                    }

                }
            }
            //else
            //{
            //    using (AkcjaMagazynProduktów AMP = new AkcjaMagazynProduktów(db, checkBMaterialy.Checked, sTANPRODUKTYNAZWYBindingSource.Current as STAN_PRODUKTY_NAZWY))
            //    {
            //        if (AMP.ShowDialog() == DialogResult.OK)
            //        {
            //            zapisZmianWidok();
            //        }
                    
            //    }
            //}
        }

        public void zapisZmianWidok()
        {
            db.SaveChanges();
            KWZP_PROJEKTEntities ndb = new KWZP_PROJEKTEntities();
            db.STAN_MATERIALY_NAZWY = ndb.STAN_MATERIALY_NAZWY;
            db.STAN_PRODUKTY_NAZWY = ndb.STAN_PRODUKTY_NAZWY;
            db.MATERIALY_PO_DODANIU = ndb.MATERIALY_PO_DODANIU;
            db.MATERIAL_ZDJETY = ndb.MATERIAL_ZDJETY;
            db = ndb;
            db.SaveChanges();
            akcjaSwitch();

        //    if (checkBWszystkie.Checked)
        //    {
        //        sTANMATERIALYNAZWYBindingSource.DataSource = db.STAN_MATERIALY_NAZWY.ToList();
        //        sTANPRODUKTYNAZWYBindingSource.DataSource = db.STAN_PRODUKTY_NAZWY.ToList();
        //    }
        //    else
        //    {
        //        int g = int.Parse(cBoxFlitracja.SelectedValue.ToString());
        //        sTANMATERIALYNAZWYBindingSource.DataSource = db.STAN_MATERIALY_NAZWY.Where(i => i.ID_ZLECENIA == g).ToList();
        //        sTANPRODUKTYNAZWYBindingSource.DataSource = db.STAN_PRODUKTY_NAZWY.Where(i => i.ID_ZLECENIA == g).ToList();
        //    }
        }

        private void ButtonDodajRekord_Click(object sender, EventArgs e)
        {
            int operacja = 1;
            using (AkcjaMagazynProduktów AMP = new AkcjaMagazynProduktów(db, checkBMaterialy.Checked, mATERIALYPODODANIUBindingSource.Current, operacja) )
            {
                if (AMP.ShowDialog() == DialogResult.OK)
                {
                    zapisZmianWidok();
                }
            }
        }
    }
}
