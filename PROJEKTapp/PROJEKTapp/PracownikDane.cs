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
        public void UpdatePracownik(int ID, string nazwisko, string imie, string telefon, string pesel,
string ulica, string nrbudynku, string nrlokalu, string kodpocztowy, int miasto, string kraj)
           // DateTime data, int stanowisko)
        {
            //var stan = (from p in db.PRACOWNICY
            //            join sp in db.STANOWISKO_PRACOWNICY on p.ID_PRACOWNIK equals sp.ID_PRACOWNIK
            //            join s in db.STANOWISKO on p.ID_PRACOWNIK equals s.ID_STANOWISKO
            //            where p.ID_PRACOWNIK == ID
            //            select s).First();
            var prac = (from p in db.PRACOWNICY
                        where p.ID_PRACOWNIK == ID
                        select p).First();
            var adr = (from p in db.PRACOWNICY
                       from ap in p.ADRESY_PRACOWNICY
                       join ap1 in db.ADRESY_PRACOWNICY on ap.ID_ADRESU equals ap1.ID_ADRESU
                       where p.ID_PRACOWNIK == ID
                       select ap).First();
            prac.NAZWISKO = nazwisko;
            prac.IMIE = imie;
            prac.TELEFON = telefon;
            prac.PESEL = pesel;
            adr.ULICA = ulica;
            adr.NR_BUDYNKU = nrbudynku;
            adr.NR_LOKALU = nrlokalu;
            adr.ID_MIASTA = miasto;
            adr.KRAJ = kraj;

            //prac.STANOWISKO = pracownikDane.STANOWISKO;
            //prac.DATA_START = pracownikDane.DATA_START;
            ////dodać pozostałe dane i tabele
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