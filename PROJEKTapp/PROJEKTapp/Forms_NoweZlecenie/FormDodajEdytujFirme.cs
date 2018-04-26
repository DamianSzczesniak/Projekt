using System.Windows.Forms;

namespace PROJEKTapp.Forms_NoweZlecenie
{
    public partial class FormDodajEdytujFirme : Form
    {
        KWZP_PROJEKTEntities db;

        public FormDodajEdytujFirme(FIRMY obj)
        {
            InitializeComponent();
            db = new KWZP_PROJEKTEntities();
              
            if (obj == null)
            {
                FirmyBindingSource.DataSource = new FIRMY();
                db.FIRMY.Add(FirmyBindingSource.Current as FIRMY);
            }
            else
            {
                FirmyBindingSource.DataSource = obj;
              //  db.FIRMY.Attach(FirmyBindingSource.Current as FIRMY); 
            }
        }

        private void FormDodajEdytujFirme_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtBoxNazwa.Text))
                {
                    MessageBox.Show("Prosze wypełnić pole Nazwa Firmy", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBoxNazwa.Focus();
                    e.Cancel = true;
                    return;
                }
                else if (string.IsNullOrEmpty(txtBoxAdresEmail.Text))
                {
                    MessageBox.Show("Prosze wypełnić pole Adress Email", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBoxAdresEmail.Focus();
                    e.Cancel = true;
                    return;
                }
                else if (string.IsNullOrEmpty(txtBoxNrTelefonu.Text))
                {
                    MessageBox.Show("Prosze wypełnić pole Nr Telefonu", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBoxNrTelefonu.Focus();
                    e.Cancel = true;
                    return;
                }
                else if (string.IsNullOrEmpty(txtBoxNrTelefonu.Text))
                {
                    MessageBox.Show("Prosze wypełnić pole Nr Telefonu", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBoxNrTelefonu.Focus();
                    e.Cancel = true;
                    return;
                }
                else if (string.IsNullOrEmpty(txtBoxNIP.Text))
                {
                    MessageBox.Show("Prosze wypełnić pole NIP", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBoxNIP.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
        
    }
}
