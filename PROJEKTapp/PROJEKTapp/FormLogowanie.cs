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
            Application.Exit();
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
                        Form1 form1 = new Form1(db, user.UPRAWNIENIA, user.ID_UZYTKOWNIKA);
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

        private void FormLogowanie_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormLogowanie_DoubleClick(object sender, EventArgs e)
        {
            txtBoxLogin.Text = "PREZES";
            txtBoxHaslo.Text = "PREZES";
            if (!String.IsNullOrWhiteSpace(txtBoxLogin.Text) && !String.IsNullOrWhiteSpace(txtBoxHaslo.Text))
            {
                var user = db.UZYTKOWNICY.FirstOrDefault(u => u.NAZWA_LOGOWANIE == txtBoxLogin.Text);
                if (user != null)
                {
                    if (user.HASLO == txtBoxHaslo.Text)
                    {
                        Form1 form1 = new Form1(db, user.UPRAWNIENIA, user.ID_UZYTKOWNIKA);
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
