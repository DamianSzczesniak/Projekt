using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace PROJEKTapp.Forms_NoweZlecenie
{
    public partial class FormFirmyDoZlecenia : Form
    {
        KWZP_PROJEKTEntities db;
        public FormFirmyDoZlecenia()
        {
            InitializeComponent();
        }

        private void FormFirmyDoZlecenia_Load(object sender, EventArgs e)
        {
            db = new KWZP_PROJEKTEntities();
            FirmyBindingSource.DataSource = db.FIRMY.ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (FormDodajEdytujFirme frmDEF = new FormDodajEdytujFirme(null))
            {
                if (frmDEF.ShowDialog() == DialogResult.OK)
                    FirmyBindingSource.DataSource = db.FIRMY.ToList();
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (FirmyBindingSource == null)
                return;
            using (FormDodajEdytujFirme frmDEF = new FormDodajEdytujFirme(FirmyBindingSource.Current as FIRMY))
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
                    db.FIRMY.Remove(FirmyBindingSource.Current as FIRMY);
                    try
                    {
                        db.SaveChanges();
                        FirmyBindingSource.RemoveCurrent();
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException exc)
                    {
                        MessageBox.Show("Ta Firma jest referencją dla innych danych, nie można jej usunąć.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
