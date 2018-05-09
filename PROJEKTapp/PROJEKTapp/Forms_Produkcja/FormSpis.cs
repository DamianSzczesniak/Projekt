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
                MODELE_MASZYN send = (MODELE_MASZYN)EwidencjaMaszynyNarzedzia.CurrentRow.DataBoundItem;
                Forms_Produkcja.FormZmiana_Maszyny zmianaMaszyny = new Forms_Produkcja.FormZmiana_Maszyny(db, send, tryb);
                zmianaMaszyny.Show();

            }
            else
            {
                NARZEDZIA send = (NARZEDZIA)EwidencjaMaszynyNarzedzia.CurrentRow.DataBoundItem;
                Forms_Produkcja.FormZmiana_Narzedzia zmianaNarzedzia = new Forms_Produkcja.FormZmiana_Narzedzia(db, send, tryb);
                zmianaNarzedzia.Show();
            }

       


            


        }

        private void Usun_Click(object sender, EventArgs e)
        {
            if (tryb == "Ewidencja Maszyn")
            {

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

        private void buttonUtworz_Click(object sender, EventArgs e)
        {
            if (tryb == "Ewidencja Maszyn")
            {
                Forms_Produkcja.FormNowaMaszyna nowaMaszyna = new Forms_Produkcja.FormNowaMaszyna(db);
                nowaMaszyna.Show();
                
            }
            else
            {
                
                Forms_Produkcja.FormNoweNarzedzie noweNarzedzia = new Forms_Produkcja.FormNoweNarzedzie(db);
                noweNarzedzia.Show();
            }
        }
    }
}
