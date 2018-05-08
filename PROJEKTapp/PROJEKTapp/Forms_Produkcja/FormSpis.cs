using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTapp.Forms_Produkcja
{
    public partial class FormSpis : Form
    {

        string tryb;
        KWZP_PROJEKTEntities db;
        public FormSpis(KWZP_PROJEKTEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void lblNazwaProduktu_Click(object sender, EventArgs e)
        {

        }

        private void cboxWybierzTryb_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdswiezListe();
        }

        private void OdswiezListe()
        {
            tryb = cboxWybierzTryb.Text.ToString();



            if (tryb == "Ewidencja Maszyn")
            {
                this.EwidencjaMaszynyNarzedzia.DataSource = db.MODELE_MASZYN.ToList();
            }

            else
            {
                this.EwidencjaMaszynyNarzedzia.DataSource = db.NARZEDZIA.ToList();
            }
        }

        private void FormSpis_Load(object sender, EventArgs e)
        {
            OdswiezListe();
        }

        private void txtNazwaProduktu_TextChanged(object sender, EventArgs e)
        {
            if (tryb == "Ewidencja Maszyn")
            {
                this.EwidencjaMaszynyNarzedzia.DataSource = db.MODELE_MASZYN.Where(x => x.MODEL.StartsWith(txtNazwaProduktu.Text)).ToList();
            }

            else
            {
                this.EwidencjaMaszynyNarzedzia.DataSource = db.NARZEDZIA.Where(x => x.MODEL.StartsWith(txtNazwaProduktu.Text)).ToList();
            }

        }

        private void ZapiszEdytuj_Click(object sender, EventArgs e)
        {
            if (tryb == "Ewidencja Maszyn")
            {
                Forms_Produkcja.FormZmiana_Maszyny zmianaMaszyny = new Forms_Produkcja.FormZmiana_Maszyny(db);
                zmianaMaszyny.Show();
            }
            else
            {
                Forms_Produkcja.FormZmiana_Narzedzia zmianaNarzedzia = new Forms_Produkcja.FormZmiana_Narzedzia(db);
                zmianaNarzedzia.Show();
            }


        }

        private void Usun_Click(object sender, EventArgs e)
        {
            if (tryb == "Ewidencja Maszyn")
            {
                this.EwidencjaMaszynyNarzedzia.DataSource = db.MODELE_MASZYN.Where(x => x.MODEL.StartsWith(txtNazwaProduktu.Text)).ToList();

                DialogResult result = MessageBox.Show("Czy chcesz usunąć maszynę: " + EwidencjaMaszynyNarzedzia.CurrentRow.Cells[1].Value + " " + EwidencjaMaszynyNarzedzia.CurrentRow.Cells[2].Value, "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MODELE_MASZYN doUsuniecia = (MODELE_MASZYN)EwidencjaMaszynyNarzedzia.CurrentRow.DataBoundItem;
                    db.MODELE_MASZYN.Remove(doUsuniecia);

                    try
                    {
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        {
                            MessageBox.Show("Usunięcie zakończone nie powodzeniem. Powód: " + ex.Message, "Uwaga", MessageBoxButtons.OK);
                        }


                    }

                    OdswiezListe();
                }
            }

            else
            {
                this.EwidencjaMaszynyNarzedzia.DataSource = db.NARZEDZIA.Where(x => x.MODEL.StartsWith(txtNazwaProduktu.Text)).ToList();

                DialogResult result = MessageBox.Show("Czy chcesz usunąć narzedzie: " + EwidencjaMaszynyNarzedzia.CurrentRow.Cells[1].Value + " " + EwidencjaMaszynyNarzedzia.CurrentRow.Cells[2].Value, "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    NARZEDZIA doUsuniecia = (NARZEDZIA)EwidencjaMaszynyNarzedzia.CurrentRow.DataBoundItem;
                    db.NARZEDZIA.Remove(doUsuniecia);

                    try
                    {
                        db.SaveChanges();

                    }
                    catch (Exception ex)


                    {
                        MessageBox.Show("Usunięcie zakończone nie powodzeniem. Powód: " + ex.Message, "Uwaga", MessageBoxButtons.OK);
                    }


                    OdswiezListe();

                }
            }


        }
    }
}
