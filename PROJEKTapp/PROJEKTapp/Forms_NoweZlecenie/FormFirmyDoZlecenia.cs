﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace PROJEKTapp.Forms_NoweZlecenie
{
    public partial class FormFirmyDoZlecenia : Form
    {
        KWZP_PROJEKTEntities db;
        
        public FormFirmyDoZlecenia(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            
            InitializeComponent();
            FirmyBindingSource.DataSource = db.FIRMY.ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (FormDodajEdytujFirme frmDEF = new FormDodajEdytujFirme(null, db))
            {
                if (frmDEF.ShowDialog() == DialogResult.OK)
                {
                    FirmyBindingSource.DataSource = db.FIRMY.ToList();
                    db.SaveChanges();
                    FirmyBindingSource.MoveLast();
                }
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (FirmyBindingSource == null)
                return;
            using (FormDodajEdytujFirme frmDEF = new FormDodajEdytujFirme(FirmyBindingSource.Current as FIRMY, db))
            {
                if (frmDEF.ShowDialog() == DialogResult.OK)
                {
                    FirmyBindingSource.DataSource = db.FIRMY.ToList();
                    db.Entry(FirmyBindingSource.Current as FIRMY).State = EntityState.Modified;
                    db.SaveChanges();
                    
                }

            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (FirmyBindingSource != null)
            {
                if (MessageBox.Show("Czy jesteś pewien że chcesz usunąć ten rekord?", "Informacja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    try
                    {
                        db.FIRMY.Remove(FirmyBindingSource.Current as FIRMY);
                        db.SaveChanges();
                        FirmyBindingSource.RemoveCurrent();

                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException exc)
                    {
                        db.FIRMY.Attach(FirmyBindingSource.Current as FIRMY);
                        MessageBox.Show("Ta Firma jest referencją dla innych danych, nie można jej usunąć.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                }
            }
        }

        private void FormFirmyDoZlecenia_FormClosed(object sender, FormClosedEventArgs e)
        {
            FIRMY firma = FirmyBindingSource.Current as FIRMY;
            FormNoweZlecenie.id_firmy = firma.ID_FIRMY;
        }
    }
}
