using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp
{
    public partial class FormPracownicy : Form
    {
        public FormPracownicy()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("KWZP_PROJEKTEntities");
                SqlCommand cmd = new SqlCommand("AddPracownik", con);
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }

                cmd.Parameters.Add("@Imie", SqlDbType.VarChar, 30.Value = txtboxImie.Text);
                cmd.Parameters.Add("@Nazwisko", SqlDbType.VarChar, 30.Value = txtboxNazwisko.Text);
                cmd.Parameters.Add("@Tel", SqlDbType.VarChar, 12.Value = txtboxTel.Text);
                cmd.Parameters.Add("@PESEL", SqlDbType.VarChar, 11.Value = txtboxPesel.Text);
                cmd.Parameters.Add("@Stanowisko", SqlDbType.Char, 30.Value = txtboxStanowisko.Text);
                cmd.Parameters.Add("@Ulica", SqlDbType.VarChar, 30.Value = txtboxUlica.Text);
                cmd.Parameters.Add("@Nrbudynku", SqlDbType.VarChar, 10.Value = textboxNrbudynku.Text);
                cmd.Parameters.Add("@Nrlokalu", SqlDbType.VarChar, 10.Value = txtboxNrlokalu.Text);
                cmd.Parameters.Add("@Kodpocztowy", SqlDbType.VarChar, 5.Value = txtboxKodpocztowy.Text);
                cmd.Parameters.Add("@Kraj", SqlDbType.VarChar, 15.Value = txtboxKraj.Text);
                cmd.Parameters.Add("@Miasto", SqlDbType.VarChar, 50.Value = txtboxMiasto.Text);
                cmd.Parameters.Add("@DataRozpoczeciaPracy", SqlDbType.Date.Value = txtDataRozpoczeciaPracy.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
