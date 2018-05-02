﻿using PROJEKTapp.Forms;
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
    public partial class Form1 : Form
    {
        KWZP_PROJEKTEntities db;
        int uprawnienia;

        public Form1(KWZP_PROJEKTEntities db, int uprawnienia)
        {
            InitializeComponent();
            this.db = db;
            this.uprawnienia = uprawnienia;

            switch (uprawnienia)
                {
                case 1:
                    btnStatusyZlecen.Hide();
                    btnNoweZlecenie.Hide();
                    break;
                case 2:
                    btnKadry.Hide();
                    btnProdukcja.Hide();
                    btnNoweZlecenie.Hide();
                    btnZlecenia.Hide();
                    break;
                case 3:
                    btnKadry.Hide();
                    btnNoweZlecenie.Hide();
                    btnLogistyka.Hide();
                    btnZlecenia.Hide();
                    break;
                case 4:
                    btnProdukcja.Hide();
                    btnNoweZlecenie.Hide();
                    btnLogistyka.Hide();
                    btnZlecenia.Hide();
                    break;
                case 5:
                    btnProdukcja.Hide();
                    btnKadry.Hide();
                    btnLogistyka.Hide();
                    btnStatusyZlecen.Hide();
                    btnZlecenia.Hide();
                    break;
            }

        }

        private void btnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogistyka_Click(object sender, EventArgs e)
        {
            FormLogistyka Logistyka = new FormLogistyka(db);
            Logistyka.Show();
        }

        private void btnKadry_Click(object sender, EventArgs e)
        {
            bool ladowanieformularzazokienkami = false;
            FormKadry Kadry = new FormKadry(db, ladowanieformularzazokienkami);
            Kadry.Show();
        }

        private void btnProdukcja_Click(object sender, EventArgs e)
        {
            Produkcja_glowny Produkcja_glowny = new Produkcja_glowny();
            Produkcja_glowny.Show();
        }

        private void btnNoweZlecenie_Click(object sender, EventArgs e)
        {
            FormNoweZlecenie NoweZlecenie = new FormNoweZlecenie(db);
            NoweZlecenie.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(db);
            form2.Show();
        }

        private void btnZlecenia_Click(object sender, EventArgs e)
        {
            ZleceniaPosredniczacy zleceniaPosredniczacy = new ZleceniaPosredniczacy(db, uprawnienia);
            zleceniaPosredniczacy.Show();
        }

        private void btnStatusyZlecen_Click(object sender, EventArgs e)
        {
            ZleceniaStatusy zleceniaStatusy = new ZleceniaStatusy(db, uprawnienia);
            zleceniaStatusy.Show();
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            FormLogowanie formLogowanie = new FormLogowanie();
            formLogowanie.Show();
            this.Close();
        }
    }
}