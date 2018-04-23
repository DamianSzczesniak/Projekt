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
        public void UpdatePracownik(PRACOWNIK_DANE pracownikDane)
        {
            //var prac = (from p in db.PRACOWNICY
            //            join sp in db.STANOWISKO_PRACOWNICY on p.ID_PRACOWNIK equals sp.ID_PRACOWNIK
            //            join s in db.STANOWISKO on p.ID_PRACOWNIK equals s.ID_STANOWISKO
            //            where p.ID_PRACOWNIK == pracownikDane.ID_PRACOWNIK
            //            select p);
            var prac = (from PRACOWNIK_DANE in db.PRACOWNIK_DANE
                        where PRACOWNIK_DANE.ID_PRACOWNIK == pracownikDane.ID_PRACOWNIK
                        select PRACOWNIK_DANE).First();
            //var prac = (from PRACOWNICY in db.PRACOWNICY
            //            where PRACOWNICY.ID_PRACOWNIK == pracownikDane.ID_PRACOWNIK
            //            select PRACOWNICY).First();

            prac.NAZWISKO = pracownikDane.NAZWISKO;
            prac.IMIE = pracownikDane.IMIE;
            prac.TELEFON = pracownikDane.TELEFON;
            prac.PESEL = pracownikDane.PESEL;
            prac.ULICA = pracownikDane.ULICA;
            prac.NR_LOKALU = pracownikDane.NR_LOKALU;
            prac.NR_BUDYNKU = pracownikDane.NR_BUDYNKU;
            prac.KOD_POCZTOWY = pracownikDane.KOD_POCZTOWY;
            prac.MIASTO = pracownikDane.MIASTO;
            prac.KRAJ = pracownikDane.KRAJ;
            prac.STANOWISKO = pracownikDane.STANOWISKO;
            prac.DATA_START = pracownikDane.DATA_START;
            //dodać pozostałe dane i tabele
            db.SaveChanges();
        }
        public void DeletePracownik(int ID_Pracownik)
        {
            var user = (from p in db.PRACOWNICY
                        where p.ID_PRACOWNIK == ID_Pracownik
                        select p).First();
            var stan = (from s in db.STANOWISKO_PRACOWNICY where s.ID_PRACOWNIK == ID_Pracownik select s).First();
            var pracownicy = db.PRACOWNICY.FirstOrDefault(p => p.ID_PRACOWNIK == ID_Pracownik);
            var adresy = db.ADRESY_PRACOWNICY.FirstOrDefault(s => s.ID_ADRESU == (from p in db.PRACOWNICY from ad in p.ADRESY_PRACOWNICY
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