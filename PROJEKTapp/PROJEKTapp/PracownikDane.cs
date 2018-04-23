using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEKTapp
{
    class PracownikDane
    {
        KWZP_PROJEKTEntities db = new KWZP_PROJEKTEntities();

        public void Add(string nazwisko, string imie, string telefon, string pesel,
            string ulica, string nrbudynku, string nrlokalu, string kodpocztowy, int miasto, string kraj,
            DateTime data, int stanowisko)
        {
            PRACOWNICY pracownik = new PRACOWNICY
            {
                NAZWISKO = nazwisko,
                IMIE = imie,
                TELEFON = telefon,
                PESEL = pesel
            };
            ADRESY_PRACOWNICY adresypracownicy = new ADRESY_PRACOWNICY
            {
                ULICA = ulica,
                NR_BUDYNKU = nrbudynku,
                NR_LOKALU = nrlokalu,
                KOD_POCZTOWY = kodpocztowy,
                ID_MIASTA = miasto,
                KRAJ = kraj
            };
            db.PRACOWNICY.Add(pracownik);
            db.ADRESY_PRACOWNICY.Add(adresypracownicy);
            pracownik.ADRESY_PRACOWNICY.Add(adresypracownicy);

            STANOWISKO_PRACOWNICY stanowiskopracownicy = new STANOWISKO_PRACOWNICY
            {
                ID_PRACOWNIK = pracownik.ID_PRACOWNIK,
                ID_STANOWISKO = stanowisko,
                DATA_START = data
            };
            db.STANOWISKO_PRACOWNICY.Add(stanowiskopracownicy);
            db.SaveChanges();
        }
        public void UpdatePracownik(PRACOWNICY pracownik)
        {
            var prac = (from o in db.PRACOWNICY
                        where o.ID_PRACOWNIK == pracownik.ID_PRACOWNIK
                        select o).First();
            prac.NAZWISKO = pracownik.NAZWISKO;
            prac.IMIE = pracownik.IMIE;
            prac.TELEFON = pracownik.TELEFON;
            //dodać pozostałe dane i tabele
            db.SaveChanges();
        }
        public void DeletePracownik(int ID_Pracownik)
        {
            var user = (from o in db.PRACOWNICY
                        where o.ID_PRACOWNIK == ID_Pracownik
                        select o).First();
            //dodać pozostałe dane i tabele
            db.PRACOWNICY.Remove(user);
            db.SaveChanges();
        }
    }
}
