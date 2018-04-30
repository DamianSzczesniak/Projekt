using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp
{
    

    public partial class FormLogowanie : Form
    {
        KWZP_PROJEKTEntities db;
        public FormLogowanie()
        {
            InitializeComponent();
            db = new KWZP_PROJEKTEntities();
        }

        private void btnWyjdz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBoxLogin.Text) && !String.IsNullOrWhiteSpace(txtBoxHaslo.Text))
                {
                var user = db.UZYTKOWNICY.FirstOrDefault(u => u.NAZWA_LOGOWANIE == txtBoxLogin.Text);
                if (user != null)
                {
                    if (user.HASLO == txtBoxHaslo.Text)
                    {
                        Form1 form1 = new Form1(db, user.UPRAWNIENIA);
                        form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wpisano niepoprawny login i/lub hasło.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBoxHaslo.Clear();
                        txtBoxLogin.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Wpisano niepoprawny login i/lub hasło.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBoxHaslo.Clear();
                    txtBoxLogin.Clear();
                }
            }
            else
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
