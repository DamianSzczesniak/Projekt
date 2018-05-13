using System.Windows.Forms;

namespace PROJEKTapp.Forms_NoweZlecenie
{
    public partial class FormDodajEdytujFirme : Form
    {
        KWZP_PROJEKTEntities db;
        FIRMY obj;

        public FormDodajEdytujFirme(FIRMY obj, KWZP_PROJEKTEntities db)
        {
            InitializeComponent();
            this.db = db;
            this.obj = obj;
              
            if (obj == null)
            {
                FirmyBindingSource.DataSource = new FIRMY();
                
                
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
                else if (txtBoxNazwa.Text.Length < 3 )
                {
                    MessageBox.Show("Nazwa firmy powinna się składać z min. 3 znaków. ");
                    txtBoxNIP.Focus();
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
                else if (!txtBoxAdresEmail.Text.ToLower().Contains("@"))
                {
                    MessageBox.Show("Wpisany e-mail ma nie prawidłowy format. ");
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
                else if (txtBoxNrTelefonu.Text.Length > 12 || txtBoxNrTelefonu.Text.Length < 9)
                {
                    MessageBox.Show("Podany numer telefonu zawiera nieprawidłową liczbę cyfr.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else if (txtBoxNIP.Text.Length != 10)
                {
                    MessageBox.Show("Wpisany nip ma nieprawidłową liczbe cyfr. ");
                    txtBoxNIP.Focus();
                    e.Cancel = true;
                    return;
                }
                else
                {
                    if (obj == null)
                    {
                        db.FIRMY.Add(FirmyBindingSource.Current as FIRMY);
                    }
                }
                e.Cancel = false;
                db.SaveChanges();
                MessageBox.Show("Akcje zapisano pomyślne .", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            e.Cancel = false;
            
        }

        

        private void txtBoxNrTelefonu_TextChanged(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxNrTelefonu.Text))
            {
                System.Int64 parsedVal;
                if (!System.Int64.TryParse(txtBoxNrTelefonu.Text, out parsedVal))
                {
                    MessageBox.Show("To pole może zawierać tylko liczbę. ");
                    txtBoxNrTelefonu.Clear();
                    return;
                }
            }
        }

        private void txtBoxNIP_TextChanged(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxNIP.Text))
            {
                System.Int64 parsedVal;
                if (!System.Int64.TryParse(txtBoxNIP.Text, out parsedVal))
                {
                    MessageBox.Show("To pole może zawierać tylko liczbę. ");
                    txtBoxNIP.Clear();
                    return;
                }
            }
        }


    
    }   
}
