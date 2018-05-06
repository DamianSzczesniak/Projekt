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
        public FormZmianaStanuMagazynu(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonZmianaStanu_Click(object sender, EventArgs e)
        {

        }

        private void checkBSurowce_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBProdukty.Checked )
            {
                checkBMaterialy.Checked = false;
                DGV_PRODUKTY.Show();
                DGV_MATERIALY.Hide();
            }
            else
            {
                checkBMaterialy.Checked = true;
            }
        }

        private void checkBMaterialy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBMaterialy.Checked)
            {
                checkBProdukty.Checked = false;
                DGV_MATERIALY.Show();
                DGV_PRODUKTY.Hide();
            }
            else
            {
                checkBProdukty.Checked = true;
            }
        }

        private void FormZmianaStanuMagazynu_Load(object sender, EventArgs e)
        {
            
            sTANMATERIALYNAZWYBindingSource.DataSource = db.STAN_MATERIALY_NAZWY.ToList();
            sTANPRODUKTYNAZWYBindingSource.DataSource = db.STAN_PRODUKTY_NAZWY.ToList();
            checkBMaterialy.Checked = true;
            checkBWszystkie.Checked = true;
            cBoxFlitracja.DataSource = db.ZLECENIA.ToList();
            cBoxFlitracja.ValueMember = "ID_ZLECENIA";
            cBoxFlitracja.SelectedValue = "ID_ZLECENIA";
            





        }

        private void checkBWszystkie_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBWszystkie.Checked)
            {
               sTANMATERIALYNAZWYBindingSource.DataSource = db.STAN_MATERIALY_NAZWY.ToList();
                sTANPRODUKTYNAZWYBindingSource.DataSource = db.STAN_PRODUKTY_NAZWY.ToList();
            }
            else
            {
                int g = int.Parse(cBoxFlitracja.SelectedValue.ToString());
                sTANMATERIALYNAZWYBindingSource.DataSource = db.STAN_MATERIALY_NAZWY.Where(i => i.ID_ZLECENIA == g).ToList();
                sTANPRODUKTYNAZWYBindingSource.DataSource = db.STAN_PRODUKTY_NAZWY.Where(i => i.ID_ZLECENIA == g).ToList();
            }
        }

        private void cBoxFlitracja_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             if   (checkBWszystkie.Checked == false)
            {
                int g = int.Parse(cBoxFlitracja.SelectedValue.ToString());
                sTANMATERIALYNAZWYBindingSource.DataSource = db.STAN_MATERIALY_NAZWY.Where(i => i.ID_ZLECENIA == g).ToList();
                sTANPRODUKTYNAZWYBindingSource.DataSource = db.STAN_PRODUKTY_NAZWY.Where(i => i.ID_ZLECENIA == g).ToList();
            }
            



        }

        private void btnZdejmij_Click(object sender, EventArgs e)
        {
            if (checkBMaterialy.Checked)
            {
                using (AkcjaMagazynProduktów AMP = new AkcjaMagazynProduktów(db, checkBMaterialy.Checked, sTANMATERIALYNAZWYBindingSource.Current as STAN_MATERIALY_NAZWY))
                {
                    if (AMP.ShowDialog() == DialogResult.OK)
                    {
                        // FirmyBindingSource.DataSource = db.FIRMY.ToList();
                        db.SaveChanges();
                    }

                }
            }
            else
            {
                using (AkcjaMagazynProduktów AMP = new AkcjaMagazynProduktów(db, checkBMaterialy.Checked, sTANPRODUKTYNAZWYBindingSource.Current as STAN_MATERIALY_NAZWY))
                {
                    if (AMP.ShowDialog() == DialogResult.OK)
                    {
                        // FirmyBindingSource.DataSource = db.FIRMY.ToList();
                        db.SaveChanges();
                    }

                }
            }
        }

        private void ButtonDodajRekord_Click(object sender, EventArgs e)
        {
            using (AkcjaMagazynProduktów AMP = new AkcjaMagazynProduktów(db, checkBMaterialy.Checked, null) )
            {
                if (AMP.ShowDialog() == DialogResult.OK)
                {
                   // FirmyBindingSource.DataSource = db.FIRMY.ToList();
                    db.SaveChanges();
                }
            }
        }
    }
}
