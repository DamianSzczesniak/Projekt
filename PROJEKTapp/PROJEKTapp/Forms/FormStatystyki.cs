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
    public partial class FormStatystyki : Form
    {
        KWZP_PROJEKTEntities db;
        bool ladowanieformularzazokienkami;
        int uprawnienia;
        List<zestawienie> listZest = new List<zestawienie>();


        public FormStatystyki(KWZP_PROJEKTEntities db, bool ladowanieformularzazokienkami)
        {
            this.db = db;
            this.ladowanieformularzazokienkami = ladowanieformularzazokienkami;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStatystyki_Load(object sender, EventArgs e)
        {
            if (ladowanieformularzazokienkami == true)
            {
                ladowanieformularzazokienkami = false;
                btnRozliczenieProjektow.Show();
                dateTimePickerPoczatek.Value = DateTime.Today.AddYears(-1);
                dateTimePickerKoniec.Value = DateTime.Today;
                zrodloDanych();
                polaSum();
            }
            else
            {
                ladowanieformularzazokienkami = true;
                btnRozliczenieProjektow.Hide();
                pnlRozliczenie.Hide();
            }
        }

        private void btnPracownicy_Click(object sender, EventArgs e)
        {
            ladowanieformularzazokienkami = true;
            FormKadry kadry = new FormKadry(db, ladowanieformularzazokienkami);
            kadry.Show();
            this.Close();
        }

        private void btnWynagrodzenia_Click(object sender, EventArgs e)
        {
            ladowanieformularzazokienkami = true;
            FormWynagordzenie wynagrodzenie = new FormWynagordzenie(db, ladowanieformularzazokienkami);
            wynagrodzenie.Show();
            this.Close();
        }

        private void btnUrlopy_Click(object sender, EventArgs e)
        {
            ladowanieformularzazokienkami = true;
            FormUrlopy urlopy = new FormUrlopy(db, ladowanieformularzazokienkami);
            urlopy.Show();
            this.Close();
        }

        private void btnSzkolenia_Click(object sender, EventArgs e)
        {
            ladowanieformularzazokienkami = true;
            FormSzkolenie szkolenie = new FormSzkolenie(db, ladowanieformularzazokienkami);
            szkolenie.Show();
            this.Close();
        }

        private void btnStatystyki_Click(object sender, EventArgs e)
        {
            if (ladowanieformularzazokienkami == true)
            {
                ladowanieformularzazokienkami = false;
                btnRozliczenieProjektow.Show();
                dateTimePickerPoczatek.Value = DateTime.Today.AddYears(-1);
                dateTimePickerKoniec.Value = DateTime.Today;
                zrodloDanych();
                polaSum();
            }
            else
            {
                ladowanieformularzazokienkami = true;
                btnRozliczenieProjektow.Hide();
                pnlRozliczenie.Hide();
            }
        }

        private void btnRozliczenieProjektow_Click(object sender, EventArgs e)
        {
            pnlRozliczenie.Show();
            dateTimePickerPoczatek.Value = DateTime.Today.AddYears(-1);
            dateTimePickerKoniec.Value = DateTime.Today;
            zrodloDanych();
            polaSum();
        }
        private void zrodloDanych()
        {
            listZest.Clear();
            foreach (zestawienie element in db.zestawienie.Where(a => a.DATA_REALIZACJI >= dateTimePickerPoczatek.Value && a.DATA_REALIZACJI <= dateTimePickerKoniec.Value && a.ID_STATUSU_ZLECENIA == 11).ToList())
            {
                
                int id = element.ID_ZLECENIA;
                zestawienie zestawienie = new zestawienie();
                FAKTURY fAKTURY = db.FAKTURY.Where(a => a.ID_ZLECENIA == id).First();
                int intprzychod;
                if (fAKTURY.CZY_OPLACONA == true)
                {
                    decimal przychod = decimal.Parse(element.Kwota_pobrana_za_zlecenie.ToString());
                    intprzychod = Decimal.ToInt32(przychod);

                }
                else
                {
                    intprzychod = 0;
                }
                
                decimal koszt = decimal.Parse(element.Kosz_wykonania_zlecenia.ToString());
                int intkoszt = Decimal.ToInt32(koszt);
                
                
                int intdochod = intprzychod - intkoszt;
                zestawienie.ID_ZLECENIA = element.ID_ZLECENIA;
                zestawienie.ID_STATUSU_ZLECENIA = element.ID_STATUSU_ZLECENIA;
                zestawienie.DATA_REALIZACJI = element.DATA_REALIZACJI;
                zestawienie.DATA_ZLECENIA = element.DATA_ZLECENIA;
                zestawienie.Kosz_wykonania_zlecenia = intkoszt;
                zestawienie.Kwota_pobrana_za_zlecenie = intprzychod;
                zestawienie.Saldo = intdochod;
                listZest.Add(zestawienie);
            }
            zestawienieBindingSource.DataSource = null;
            if (listZest.Count != 0)
            {
                zestawienieBindingSource.DataSource = listZest;
            }
            dgvRozliczenie.Refresh();

            foreach (DataGridViewRow Myrow in dgvRozliczenie.Rows)
            {
                if (Convert.ToInt32(Myrow.Cells[3].Value) < 0)
                {
                    Myrow.Cells[3].Style.BackColor = Color.Red;
                }
                else
                {
                    Myrow.Cells[3].Style.BackColor = Color.Green;
                }
            }
        }



        private void polaSum()
        {
            int sumPrzychod = 0;
            int sumKoszt = 0;
            int sumDochod = 0;
            foreach (zestawienie element in db.zestawienie.Where(a => a.DATA_REALIZACJI >= dateTimePickerPoczatek.Value && a.DATA_REALIZACJI <= dateTimePickerKoniec.Value && a.ID_STATUSU_ZLECENIA > 8).ToList())
            {
                int id = element.ID_ZLECENIA;

                FAKTURY fAKTURY = db.FAKTURY.Where(a => a.ID_ZLECENIA == id).First();
                int intprzychod;
                if (fAKTURY.CZY_OPLACONA == true)
                {
                    decimal przychod = decimal.Parse(element.Kwota_pobrana_za_zlecenie.ToString());
                    intprzychod = Decimal.ToInt32(przychod);
                    
                }
                else
                {
                    intprzychod = 0;
                }
                sumPrzychod += intprzychod;
                decimal koszt = decimal.Parse(element.Kosz_wykonania_zlecenia.ToString());
                int intkoszt = Decimal.ToInt32(koszt);
                sumKoszt += intkoszt;
                int intdochod = intprzychod - intkoszt;
                sumDochod += intdochod;
            }
            txtBoxSPrzychod.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", sumPrzychod);
            txtBoxSKoszty.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", sumKoszt);
            txtBoxSDochod.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", sumDochod);
            if (sumDochod > 0)
            {
                txtBoxSDochod.BackColor = Color.Green;
            }
            else if (sumDochod == 0)
            {
                txtBoxSDochod.BackColor = Color.Yellow;
            }
            else
            {
                txtBoxSDochod.BackColor = Color.Red;
            }
        }

        private void dateTimePickerPoczatek_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerKoniec.Value <= dateTimePickerPoczatek.Value)
            {
                MessageBox.Show("Data początku okresu powinna być mniejsz od daty konca okresu. ");
                dateTimePickerPoczatek.Focus();
                zrodloDanych();
                polaSum();
            }
            else
            {
                zrodloDanych();
                polaSum();
            }
        }

        private void dateTimePickerKoniec_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerKoniec.Value <= dateTimePickerPoczatek.Value)
            {
                MessageBox.Show("Data początku okresu powinna być mniejsz od daty konca okresu. ");
                dateTimePickerKoniec.Focus();
                zrodloDanych();
                polaSum();
            }
            else
            {
                zrodloDanych();
                polaSum();
            }
        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvRozliczenie.CurrentRow.Cells[0].Value);
            Forms_NoweZlecenie.SzczegolyZlecenia szczegoly = new Forms_NoweZlecenie.SzczegolyZlecenia(id, db, uprawnienia);
            szczegoly.Show();
        }

        private void label5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
        }
    }
}
