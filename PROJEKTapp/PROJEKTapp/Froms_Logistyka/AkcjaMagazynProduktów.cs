using System;

using System.Data;
using System.Data.Entity;
using System.Linq;

using System.Windows.Forms;

namespace PROJEKTapp.Froms_Logistyka
{
    public partial class AkcjaMagazynProduktów : Form
    {
        KWZP_PROJEKTEntities db;
        bool materialy;
        object dane;
        public AkcjaMagazynProduktów(KWZP_PROJEKTEntities db, bool materialy,object dane)
        {
            this.db = db;
            this.materialy = materialy;
            this.dane = dane;
            InitializeComponent();
        }

        private void AkcjaMagazynProduktów_Load(object sender, EventArgs e)
        {
            txtBoxData.Text = DateTime.Now.ToString("dd/MM/yyyy");

            if (materialy)
            {
                if (dane == null)
                {
                    lblItem.Text = "Materiał :";
                    cBoxSurPro.DataSource = db.MATERIAL.ToList();
                    cBoxSurPro.DisplayMember = "PELNA_NAZWA_MATERIALU";
                    cBoxSurPro.ValueMember = "ID_MATERIALU";
                    txtBoxRAkcji.Text = "DODAWANIE";
                    cBoxLokalizacja.DataSource = db.LOKALIZACJA.Where(a => a.CzyPelne == false).ToList();
                    cBoxLokalizacja.DisplayMember = "ID_LOKALIZACJI";
                    cBoxLokalizacja.ValueMember = "ID_LOKALIZACJI";
                    cBoxPrzypisaneZlecenie.DataSource = db.ZLECENIA.ToList();
                    cBoxPrzypisaneZlecenie.DisplayMember = "ID_ZLECENIA";
                    cBoxPrzypisaneZlecenie.ValueMember = "ID_ZLECENIA";
                }
                else
                {
                    STAN_MATERIALY_NAZWY sTAN_MATERIALY_NAZWY = dane as STAN_MATERIALY_NAZWY;
                    txtBoxRAkcji.Text = "ODBIÓR";
                    lblItem.Text = "Materiał :";
                    cBoxSurPro.DataSource = db.MATERIAL.Where( a => a.ID_MATERIALU == sTAN_MATERIALY_NAZWY.ID_MATERIALU).ToList();
                    cBoxSurPro.DisplayMember = "PELNA_NAZWA_MATERIALU";
                    cBoxSurPro.ValueMember = "ID_MATERIALU";
                    cBoxLokalizacja.DataSource = db.LOKALIZACJA.Where(a => a.ID_LOKALIZACJI == sTAN_MATERIALY_NAZWY.ID_LOKALIZACJI).ToList();
                    cBoxLokalizacja.DisplayMember = "ID_LOKALIZACJI";
                    cBoxLokalizacja.ValueMember = "ID_LOKALIZACJI";
                    cBoxPrzypisaneZlecenie.DataSource = db.ZLECENIA.Where(a => a.ID_ZLECENIA == sTAN_MATERIALY_NAZWY.ID_ZLECENIA).ToList();
                    cBoxPrzypisaneZlecenie.DisplayMember = "ID_ZLECENIA";
                    cBoxPrzypisaneZlecenie.ValueMember = "ID_ZLECENIA";
                    checkBoxPelne.Hide();
                }
            }
            else
            {
                if (dane == null)
                {
                    lblItem.Text = "Produkt :";
                    cBoxSurPro.DataSource = db.PRODUKT.ToList();
                    cBoxSurPro.DisplayMember = "NAZWA_PRODUKTU";
                    cBoxSurPro.ValueMember = "ID_PRODUKTU";
                    txtBoxRAkcji.Text = "DODAWANIE";
                    cBoxLokalizacja.DataSource = db.LOKALIZACJA.Where(a => a.CzyPelne == false).ToList();
                    cBoxLokalizacja.DisplayMember = "ID_LOKALIZACJI";
                    cBoxLokalizacja.ValueMember = "ID_LOKALIZACJI";
                    cBoxPrzypisaneZlecenie.DataSource = db.ZLECENIA.ToList();
                  
                    cBoxPrzypisaneZlecenie.DisplayMember = "ID_ZLECENIA";
                    cBoxPrzypisaneZlecenie.ValueMember = "ID_ZLECENIA";
                }
                else
                {
                    STAN_PRODUKTY_NAZWY sTAN_PRODUKTY_NAZWY = dane as STAN_PRODUKTY_NAZWY;
                    txtBoxRAkcji.Text = "ODBIÓR";
                    lblItem.Text = "Produkt :";
                    cBoxSurPro.DataSource = db.PRODUKT.Where(a => a.ID_PRODUKTU == sTAN_PRODUKTY_NAZWY.ID_PRODUKTU).ToList();
                    cBoxSurPro.DisplayMember = "NAZWA_PRODUKTU";
                    cBoxSurPro.ValueMember = "ID_PRODUKTU";
                    cBoxLokalizacja.DataSource = db.LOKALIZACJA.Where(a => a.ID_LOKALIZACJI == sTAN_PRODUKTY_NAZWY.ID_LOKALIZACJI).ToList();
                    cBoxLokalizacja.DisplayMember = "ID_LOKALIZACJI";
                    cBoxLokalizacja.ValueMember = "ID_LOKALIZACJI";
                    cBoxPrzypisaneZlecenie.DataSource = db.ZLECENIA.Where(a => a.ID_ZLECENIA == sTAN_PRODUKTY_NAZWY.ID_ZLECENIA).ToList();
                    cBoxPrzypisaneZlecenie.DisplayMember = "ID_ZLECENIA";
                    cBoxPrzypisaneZlecenie.ValueMember = "ID_ZLECENIA";
                    checkBoxPelne.Hide();
                }
            }
        }



        private void AkcjaMagazynProduktów_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (! String.IsNullOrEmpty(txtBoxIlosc.Text))
                {
                    if (materialy)
                    {
                        if (dane == null)
                        {
                            ZMIANA_STANU_MAGAZYNU_MATERIALOW zMIANA_STANU_MAGAZYNU_MATERIALOW = new ZMIANA_STANU_MAGAZYNU_MATERIALOW();
                            zMIANA_STANU_MAGAZYNU_MATERIALOW.ID_LOKALIZACJI = int.Parse(cBoxLokalizacja.SelectedValue.ToString());
                            zMIANA_STANU_MAGAZYNU_MATERIALOW.ID_MATERIALU = int.Parse(cBoxSurPro.SelectedValue.ToString());
                            zMIANA_STANU_MAGAZYNU_MATERIALOW.ID_ZLECENIA = int.Parse(cBoxPrzypisaneZlecenie.SelectedValue.ToString());
                            int s = int.Parse(txtBoxIlosc.Text);
                            zMIANA_STANU_MAGAZYNU_MATERIALOW.ILOSC = s;
                            zMIANA_STANU_MAGAZYNU_MATERIALOW.DATA_WPISU = DateTime.Parse(txtBoxData.Text);
                            db.ZMIANA_STANU_MAGAZYNU_MATERIALOW.Add(zMIANA_STANU_MAGAZYNU_MATERIALOW);
                            if (checkBoxPelne.Checked)
                            {
                                LOKALIZACJA lOKALIZACJA = new LOKALIZACJA();
                                lOKALIZACJA = db.LOKALIZACJA.FirstOrDefault(l => l.ID_LOKALIZACJI == zMIANA_STANU_MAGAZYNU_MATERIALOW.ID_LOKALIZACJI);
                                lOKALIZACJA.CzyPelne = true;
                                db.Entry(lOKALIZACJA).State = EntityState.Modified;

                            }
                            db.SaveChanges();
                            MessageBox.Show("Akcje zapisano pomyślne .", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            e.Cancel = false;
                        }
                        else
                        {
                            STAN_MATERIALY_NAZWY sTAN_MATERIALY_NAZWY = dane as STAN_MATERIALY_NAZWY;
                            if (int.Parse(txtBoxIlosc.Text) > 0 && int.Parse(txtBoxIlosc.Text) <= int.Parse(sTAN_MATERIALY_NAZWY.STAN.ToString()))
                            {
                                ZMIANA_STANU_MAGAZYNU_MATERIALOW zMIANA_STANU_MAGAZYNU_MATERIALOW = new ZMIANA_STANU_MAGAZYNU_MATERIALOW();
                                zMIANA_STANU_MAGAZYNU_MATERIALOW.ID_LOKALIZACJI = sTAN_MATERIALY_NAZWY.ID_LOKALIZACJI;
                                zMIANA_STANU_MAGAZYNU_MATERIALOW.ID_MATERIALU = sTAN_MATERIALY_NAZWY.ID_MATERIALU;
                                zMIANA_STANU_MAGAZYNU_MATERIALOW.ID_ZLECENIA = sTAN_MATERIALY_NAZWY.ID_ZLECENIA;
                                int s = int.Parse(txtBoxIlosc.Text);
                                s = -s;
                                zMIANA_STANU_MAGAZYNU_MATERIALOW.ILOSC = s;
                                zMIANA_STANU_MAGAZYNU_MATERIALOW.DATA_WPISU = DateTime.Parse(txtBoxData.Text);
                                db.ZMIANA_STANU_MAGAZYNU_MATERIALOW.Add(zMIANA_STANU_MAGAZYNU_MATERIALOW);
                                LOKALIZACJA lOKALIZACJA = new LOKALIZACJA();
                                lOKALIZACJA = db.LOKALIZACJA.FirstOrDefault(l => l.ID_LOKALIZACJI == zMIANA_STANU_MAGAZYNU_MATERIALOW.ID_LOKALIZACJI);
                                if (lOKALIZACJA.CzyPelne == true)
                                {
                                    lOKALIZACJA.CzyPelne = false;
                                    db.Entry(lOKALIZACJA).State = EntityState.Modified;
                                }
                                db.SaveChanges();
                                MessageBox.Show("Akcje zapisano pomyślne .", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                e.Cancel = false;
                            }
                            else
                            {
                                MessageBox.Show("Nie można pobrać z danej lokalizacji większej liczby materiałów, przypisanych danemu zleceniu, niż się w niej znajduje .", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                e.Cancel = true;
                                return;
                            }
                        }

                    }
                    else
                    {
                        if (dane == null)
                        {
                            ZMIANA_STANU_MAGAZYNU_PRODUKTOW zMIANA_STANU_MAGAZYNU_PRODUKTOW = new ZMIANA_STANU_MAGAZYNU_PRODUKTOW();
                            zMIANA_STANU_MAGAZYNU_PRODUKTOW.ID_LOKALIZACJI = int.Parse(cBoxLokalizacja.SelectedValue.ToString());
                            zMIANA_STANU_MAGAZYNU_PRODUKTOW.ID_PRODUKTU = int.Parse(cBoxSurPro.SelectedValue.ToString());
                            zMIANA_STANU_MAGAZYNU_PRODUKTOW.ID_ZLECENIA = int.Parse(cBoxPrzypisaneZlecenie.SelectedValue.ToString());
                            int s = int.Parse(txtBoxIlosc.Text);
                            zMIANA_STANU_MAGAZYNU_PRODUKTOW.ILOSC = s;
                            zMIANA_STANU_MAGAZYNU_PRODUKTOW.DATA_WPISU = DateTime.Parse(txtBoxData.Text);
                            db.ZMIANA_STANU_MAGAZYNU_PRODUKTOW.Add(zMIANA_STANU_MAGAZYNU_PRODUKTOW);
                            if (checkBoxPelne.Checked)
                            {
                                LOKALIZACJA lOKALIZACJA = new LOKALIZACJA();
                                lOKALIZACJA = db.LOKALIZACJA.FirstOrDefault(l => l.ID_LOKALIZACJI == zMIANA_STANU_MAGAZYNU_PRODUKTOW.ID_LOKALIZACJI);
                                lOKALIZACJA.CzyPelne = true;
                                db.Entry(lOKALIZACJA).State = EntityState.Modified;

                            }
                            db.SaveChanges();
                            MessageBox.Show("Akcje zapisano pomyślne .", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            e.Cancel = false;
                        }
                        else
                        {
                            STAN_PRODUKTY_NAZWY sTAN_PRODUKTY_NAZWY = dane as STAN_PRODUKTY_NAZWY;
                            if (int.Parse(txtBoxIlosc.Text) > 0 && int.Parse(txtBoxIlosc.Text) <= int.Parse(sTAN_PRODUKTY_NAZWY.STAN.ToString()))
                            {
                                ZMIANA_STANU_MAGAZYNU_PRODUKTOW zMIANA_STANU_MAGAZYNU_PRODUKTOW = new ZMIANA_STANU_MAGAZYNU_PRODUKTOW();
                                zMIANA_STANU_MAGAZYNU_PRODUKTOW.ID_LOKALIZACJI = sTAN_PRODUKTY_NAZWY.ID_LOKALIZACJI;
                                zMIANA_STANU_MAGAZYNU_PRODUKTOW.ID_PRODUKTU = sTAN_PRODUKTY_NAZWY.ID_PRODUKTU;
                                zMIANA_STANU_MAGAZYNU_PRODUKTOW.ID_ZLECENIA = sTAN_PRODUKTY_NAZWY.ID_ZLECENIA;
                                int s = int.Parse(txtBoxIlosc.Text);
                                s = -s;
                                zMIANA_STANU_MAGAZYNU_PRODUKTOW.ILOSC = s;
                                zMIANA_STANU_MAGAZYNU_PRODUKTOW.DATA_WPISU = DateTime.Parse(txtBoxData.Text);
                                db.ZMIANA_STANU_MAGAZYNU_PRODUKTOW.Add(zMIANA_STANU_MAGAZYNU_PRODUKTOW);
                                LOKALIZACJA lOKALIZACJA = new LOKALIZACJA();
                                lOKALIZACJA = db.LOKALIZACJA.FirstOrDefault(l => l.ID_LOKALIZACJI == zMIANA_STANU_MAGAZYNU_PRODUKTOW.ID_LOKALIZACJI);
                                if (lOKALIZACJA.CzyPelne == true)
                                {
                                    lOKALIZACJA.CzyPelne = false;
                                    db.Entry(lOKALIZACJA).State = EntityState.Modified;
                                }
                                db.SaveChanges();
                                MessageBox.Show("Akcje zapisano pomyślne .", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                e.Cancel = false;
                            }
                            else
                            {
                                MessageBox.Show("Nie można pobrać z danej lokalizacji większej liczby produktów, przypisanych danemu zleceniu, niż się w niej znajduje .", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                e.Cancel = true;
                                return;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Proszę wypełnić pole ilość .", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                    return;
                }
            }
        }

   

        private void cBoxPrzypisaneZlecenie_Click(object sender, EventArgs e)
        {
            if (materialy)
            {
                if (dane == null)
                {

                    int ktoreZlecenia = int.Parse(cBoxSurPro.SelectedValue.ToString());
                    cBoxPrzypisaneZlecenie.DataSource = db.ZLECENIA_MATERIALY.Where(b => b.ID_MATERIAL == ktoreZlecenia).ToList();
                    cBoxPrzypisaneZlecenie.DisplayMember = "ID_ZLECENIA";
                    cBoxPrzypisaneZlecenie.ValueMember = "ID_ZLECENIA";
                }

            }
            else
            {
                if (dane == null)
                {

                    int ktoreZlecenia = int.Parse(cBoxSurPro.SelectedValue.ToString());

                    cBoxPrzypisaneZlecenie.DataSource = db.ZLECENIE_PRODUKT.Where(b => b.ID_PRODUKTU == ktoreZlecenia).ToList();
                    cBoxPrzypisaneZlecenie.DisplayMember = "ID_ZLECENIA";
                    cBoxPrzypisaneZlecenie.ValueMember = "ID_ZLECENIA";
                }

            }
        }
    }
}
