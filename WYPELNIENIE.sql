SET IDENTITY_INSERT ADRESY ON
INSERT ADRESY (ID_ADRESU, ULICA, NR_BUDYNKU, NR_LOKALU, KOD_POCZTOWY, ID_MIASTA, KRAJ) VALUES (1,'Wile�ska', '5', '22', '03555', 2,'Polska') 
INSERT ADRESY (ID_ADRESU, ULICA, NR_BUDYNKU, NR_LOKALU, KOD_POCZTOWY, ID_MIASTA, KRAJ) VALUES (2,'G�rczewska', '155', '45', '07585', 1,'Polska') 
INSERT ADRESY (ID_ADRESU, ULICA, NR_BUDYNKU, NR_LOKALU, KOD_POCZTOWY, ID_MIASTA, KRAJ) VALUES (3,'Warszawaska', '78', '29', '09177', 5,'Polska') 
INSERT ADRESY (ID_ADRESU, ULICA, NR_BUDYNKU, NR_LOKALU, KOD_POCZTOWY, ID_MIASTA, KRAJ) VALUES (4,'Pozna�ska', '11', '23', '08795', 12,'Polska') 
INSERT ADRESY (ID_ADRESU, ULICA, NR_BUDYNKU, NR_LOKALU, KOD_POCZTOWY, ID_MIASTA, KRAJ) VALUES (5,'Krakowska', '445', '212', '01347', 20,'Polska') 
Go
SET IDENTITY_INSERT ADRESY OFF
SET IDENTITY_INSERT MIASTA ON
INSERT MIASTA (ID_MIASTA, nazwa) VALUES (1,'Warszawa') 
INSERT MIASTA (ID_MIASTA, nazwa) VALUES (2,'Wroc�aw') 
INSERT MIASTA (ID_MIASTA, nazwa) VALUES (3,'Gda�sk') 
INSERT MIASTA (ID_MIASTA, nazwa) VALUES (4,'Gdynia') 
INSERT MIASTA (ID_MIASTA, nazwa) VALUES (5,'Tou�') 
INSERT MIASTA (ID_MIASTA, nazwa) VALUES (6,'��d�') 
INSERT MIASTA (ID_MIASTA, nazwa) VALUES (7,'Pu�tusk') 
INSERT MIASTA (ID_MIASTA, nazwa) VALUES (8,'Radom') 
INSERT MIASTA (ID_MIASTA, nazwa) VALUES (9,'Krak�w') 
INSERT MIASTA (ID_MIASTA, nazwa) VALUES (10,'Tarn�w') 
INSERT MIASTA (ID_MIASTA, nazwa) VALUES (11,'Wa�cz') 
INSERT MIASTA (ID_MIASTA, nazwa) VALUES (12,'Lublin') 
INSERT MIASTA (ID_MIASTA, nazwa) VALUES (13,'Bydgoszcz') 
INSERT MIASTA (ID_MIASTA, nazwa) VALUES (14,'Pozna�') 
INSERT MIASTA (ID_MIASTA, nazwa) VALUES (15,'Katowice') 
INSERT MIASTA (ID_MIASTA, nazwa) VALUES (16,'Rzesz�w') 
INSERT MIASTA (ID_MIASTA, nazwa) VALUES (17,'Bia�ystok') 
INSERT MIASTA (ID_MIASTA, nazwa) VALUES (18,'Kielce') 
INSERT MIASTA (ID_MIASTA, nazwa) VALUES (19,'Olsztyn') 
INSERT MIASTA (ID_MIASTA, nazwa) VALUES (20,'Cz�stochowa') 
GO
SET IDENTITY_INSERT MIASTA OFF
SET IDENTITY_INSERT OKRES ON
INSERT OKRES(ID_OKRES, nazwa) VALUES (1,'Miesiac') 
INSERT OKRES(ID_OKRES, nazwa) VALUES (2,'Tydzien') 
INSERT OKRES(ID_OKRES, nazwa) VALUES (3,'Dzien')
INSERT OKRES(ID_OKRES, nazwa) VALUES (4,'Zlecenie')
INSERT OKRES(ID_OKRES, nazwa) VALUES (5,'Godzina')

Go
SET IDENTITY_INSERT OKRES OFF
SET IDENTITY_INSERT PODATEK ON
INSERT PODATEK (ID_PODATEK, stawka, data) VALUES (1, 0.18, '1999-01-01') 
INSERT PODATEK (ID_PODATEK, stawka, data) VALUES (2, 0.23, '1998-01-01')
INSERT PODATEK (ID_PODATEK, stawka, data) VALUES (3, 0.32, '1999-01-01')
INSERT PODATEK (ID_PODATEK, stawka, data) VALUES (4, 0.19, '1999-01-01')
INSERT PODATEK (ID_PODATEK, stawka, data) VALUES (5, 0.0775, '1999-01-01')
Go
SET IDENTITY_INSERT PODATEK OFF
SET IDENTITY_INSERT PRACOWNICY ON
INSERT PRACOWNICY(ID_PRACOWNIK, nazwisko, imie,telefon, ID_ADRESU, pesel) VALUES (1,'Lis', 'Miros�aw', '447888999', 2, 94052177964) 
INSERT PRACOWNICY(ID_PRACOWNIK, nazwisko, imie,telefon, ID_ADRESU, pesel) VALUES (2, 'Stro�ek', 'Piotr', '505176947', 1, 94011667964)
INSERT PRACOWNICY(ID_PRACOWNIK, nazwisko, imie,telefon, ID_ADRESU, pesel) VALUES (3,'Brodecka', 'El�bieta', '174265463', 3, 94040675967)
INSERT PRACOWNICY(ID_PRACOWNIK, nazwisko, imie,telefon, ID_ADRESU, pesel) VALUES (4,'Szczesniak', 'Damian', '117854365', 5, 93071456662)
INSERT PRACOWNICY(ID_PRACOWNIK, nazwisko, imie,telefon, ID_ADRESU, pesel) VALUES (5,'Rajkowski', 'Kamil', '147582364', 4, 94121145736)
Go
SET IDENTITY_INSERT PRACOWNICY OFF
SET IDENTITY_INSERT STANOWISKOPRACOWNICY ON
INSERT STANOWISKOPRACOWNICY (ID_PRACOWNIK, ID_STANOWISKO, data_start) VALUES (1, 3, '2017-09-28')
INSERT STANOWISKOPRACOWNICY (ID_PRACOWNIK, ID_STANOWISKO, data_start) VALUES (2, 7, '2017-09-28')
INSERT STANOWISKOPRACOWNICY (ID_PRACOWNIK, ID_STANOWISKO, data_start) VALUES (3, 6, '2017-09-28')
INSERT STANOWISKOPRACOWNICY (ID_PRACOWNIK, ID_STANOWISKO, data_start) VALUES (4, 1, '2017-09-28')
INSERT STANOWISKOPRACOWNICY (ID_PRACOWNIK, ID_STANOWISKO, data_start) VALUES (5, 10, '2017-09-28')
SET IDENTITY_INSERT STANOWISKOPRACOWNICY OFF
Go
SET IDENTITY_INSERT STANOWISKO ON
INSERT STANOWISKO (ID_STANOWISKO, nazwa) VALUES (1,'Prezes') 
INSERT STANOWISKO (ID_STANOWISKO, nazwa) VALUES (2,'Kierownik_produkcji') 
INSERT STANOWISKO (ID_STANOWISKO, nazwa) VALUES (3,'Konstruktor')
INSERT STANOWISKO (ID_STANOWISKO, nazwa) VALUES (4,'Frezer')
INSERT STANOWISKO (ID_STANOWISKO, nazwa) VALUES (5,'Tokarz')
INSERT STANOWISKO (ID_STANOWISKO, nazwa) VALUES (6,'Ksi�gowa')
INSERT STANOWISKO (ID_STANOWISKO, nazwa) VALUES (7,'Dyrektor')
INSERT STANOWISKO (ID_STANOWISKO, nazwa) VALUES (8,'Sprz�taczka')
INSERT STANOWISKO (ID_STANOWISKO, nazwa) VALUES (9,'Kraw�dziarz')
INSERT STANOWISKO (ID_STANOWISKO, nazwa) VALUES (10,'Technolog')
INSERT STANOWISKO (ID_STANOWISKO, nazwa) VALUES (11,'Lakiernik')
INSERT STANOWISKO (ID_STANOWISKO, nazwa) VALUES (12,'Kierowca')
Go
SET IDENTITY_INSERT STANOWISKO OFF
SET IDENTITY_INSERT STAWKAPRACOWNICY ON
INSERT STAWKAPRACOWNICY (ID_PRACOWNIK, ID_STAWKA, data_start) VALUES (1, 1, '2017-09-28')
INSERT STAWKAPRACOWNICY (ID_PRACOWNIK, ID_STAWKA, data_start) VALUES (2, 3, '2017-09-28')
INSERT STAWKAPRACOWNICY (ID_PRACOWNIK, ID_STAWKA, data_start) VALUES (3, 5, '2017-09-28')
INSERT STAWKAPRACOWNICY (ID_PRACOWNIK, ID_STAWKA, data_start) VALUES (4, 2, '2017-09-28')
INSERT STAWKAPRACOWNICY (ID_PRACOWNIK, ID_STAWKA, data_start) VALUES (5, 4, '2017-09-28')
SET IDENTITY_INSERT STAWKAPRACOWNICY OFF
Go
SET IDENTITY_INSERT STAWKA ON
INSERT STAWKA(ID_STAWKA, wartosc, ID_OKRES) VALUES (1, 5500, 1)
INSERT STAWKA(ID_STAWKA, wartosc, ID_OKRES) VALUES (2, 10000, 1)
INSERT STAWKA(ID_STAWKA, wartosc, ID_OKRES) VALUES (3, 880, 2)
INSERT STAWKA(ID_STAWKA, wartosc, ID_OKRES) VALUES (4, 200, 3)
INSERT STAWKA(ID_STAWKA, wartosc, ID_OKRES) VALUES (5, 1500, 4)
SET IDENTITY_INSERT STAWKA OFF
Go
SET IDENTITY_INSERT SZKOLENIA ON
INSERT SZKOLENIA (ID_SZKOLENIA, nazwa_szkolenia, opis_szkolenia, data_start, data_koniec) VALUES (1,'BHP_2017', 'Szkolenie BHP rok 2017', '2017-01-25', '2017-01-26') 
INSERT SZKOLENIA (ID_SZKOLENIA, nazwa_szkolenia, opis_szkolenia, data_start, data_koniec) VALUES (2,'BHP_2016', 'Szkolenie BHP rok 2016', '2016-01-25', '2016-01-26')
INSERT SZKOLENIA (ID_SZKOLENIA, nazwa_szkolenia, opis_szkolenia, data_start, data_koniec) VALUES (3,'BHP_2015', 'Szkolenie BHP rok 2015', '2015-01-25', '2015-01-26')  
INSERT SZKOLENIA (ID_SZKOLENIA, nazwa_szkolenia, opis_szkolenia, data_start, data_koniec) VALUES (4,'Soliworks_Mech', 'Szkolenie z Solidworks z modulu mechanical', '2017-10-05', '2017-10-10') 
INSERT SZKOLENIA (ID_SZKOLENIA, nazwa_szkolenia, opis_szkolenia, data_start, data_koniec) VALUES (5,'Zarz_prod', 'Efektywne planowanie i zarz�dzanie produkcj�', '2017-10-05', '2017-10-10')
Go
SET IDENTITY_INSERT SZKOLENIA OFF
SET IDENTITY_INSERT SZKOLENIEPRACOWNICY ON
INSERT SZKOLENIEPRACOWNICY (ID_PRACOWNIK, ID_SZKOLENIA) VALUES (1, 4)
INSERT SZKOLENIEPRACOWNICY (ID_PRACOWNIK, ID_SZKOLENIA) VALUES (4, 2)
INSERT SZKOLENIEPRACOWNICY (ID_PRACOWNIK, ID_SZKOLENIA) VALUES (3, 1)
INSERT SZKOLENIEPRACOWNICY (ID_PRACOWNIK, ID_SZKOLENIA) VALUES (2, 1)
INSERT SZKOLENIEPRACOWNICY (ID_PRACOWNIK, ID_SZKOLENIA) VALUES (5, 1)
INSERT SZKOLENIEPRACOWNICY (ID_PRACOWNIK, ID_SZKOLENIA) VALUES (1, 1)
INSERT SZKOLENIEPRACOWNICY (ID_PRACOWNIK, ID_SZKOLENIA) VALUES (4, 1)
SET IDENTITY_INSERT SZKOLENIEPRACOWNICY OFF
Go
SET IDENTITY_INSERT WALUTY ON
INSERT WALUTY(ID_WALUTY, nazwa, kurs_do_pln) VALUES (1,'EUR', 4.1582) 
INSERT WALUTY(ID_WALUTY, nazwa, kurs_do_pln) VALUES (2,'GBP', 4.8102) 
INSERT WALUTY(ID_WALUTY, nazwa, kurs_do_pln) VALUES (3,'USD', 3.3572) 
INSERT WALUTY(ID_WALUTY, nazwa, kurs_do_pln) VALUES (4,'CHF', 3.4921) 
INSERT WALUTY(ID_WALUTY, nazwa, kurs_do_pln) VALUES (5,'RUB', 0.0546) 
SET IDENTITY_INSERT WALUTY OFF
Go