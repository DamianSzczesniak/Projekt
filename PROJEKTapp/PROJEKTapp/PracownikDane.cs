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
            prac.PESEL = pracownik.PESEL;
            //dodać pozostałe dane i tabele
            db.SaveChanges();
        }
        public void DeletePracownik(int ID_Pracownik)
        {
            var user = (from p in db.PRACOWNICY
                        //join sp in db.STANOWISKO_PRACOWNICY on p.ID_PRACOWNIK equals sp.ID_PRACOWNIK
                        //join apa in p.
                        where p.ID_PRACOWNIK == ID_Pracownik
                        select p).First();
            var stan = (from s in db.STANOWISKO_PRACOWNICY where s.ID_PRACOWNIK== ID_Pracownik select s).First();
            //from p in db.PRACOWNICY
            //from ad in p.ADRESY_PRACOWNICY
            //join c in db.ADRESY_PRACOWNICY on ad.ID_ADRESU equals c.ID_ADRESU
            //where p.ID_PRACOWNIK == ID_Pracownik
            //select ad.ID_ADRESU).First();

            //dodać pozostałe dane i tabele
            var pracownicy = db.PRACOWNICY.FirstOrDefault(p => p.ID_PRACOWNIK == ID_Pracownik);
            var adresy = db.ADRESY_PRACOWNICY.FirstOrDefault(s => s.ID_ADRESU == (from p in db.PRACOWNICY
                                                                                 from ad in p.ADRESY_PRACOWNICY
                                                                                 join c in db.ADRESY_PRACOWNICY on ad.ID_ADRESU equals c.ID_ADRESU
                                                                                 where p.ID_PRACOWNIK == ID_Pracownik
                                                                                 select ad.ID_ADRESU).FirstOrDefault());
            pracownicy.ADRESY_PRACOWNICY.Remove(adresy);
            db.STANOWISKO_PRACOWNICY.Remove(stan);
            db.PRACOWNICY.Remove(user);
            db.SaveChanges();
        }
    }
}