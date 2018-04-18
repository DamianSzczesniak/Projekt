--USE master
--DROP DATABASE PROJEKTv9;
--GO
CREATE DATABASE PROJEKTv9;
GO
USE PROJEKTv9;

--CREATING TABLES
CREATE TABLE Miasta (id_miasta INT IDENTITY(1,1) PRIMARY KEY NOT NULL, nazwa VARCHAR(50) NOT NULL);
CREATE TABLE Adresy (id_Adresu int IDENTITY(1,1) PRIMARY KEY NOT NULL, Ulica varchar(30), Nr_budynku varchar(10), Nr_lokalu varchar(10), Kod_pocztowy varchar(5), id_miasta int FOREIGN KEY REFERENCES miasta(id_miasta), Kraj varchar(15))
CREATE TABLE Lokalizacja (id_Lokalizacji int IDENTITY(1,1) PRIMARY KEY NOT NULL, Sektor varchar(30), Alejka varchar(30), Regał varchar(30), Poziom varchar(30), Kosz varchar(30))
CREATE TABLE Produkt (id_Produktu int IDENTITY(1,1) PRIMARY KEY NOT NULL, Nazwa_Produktu varchar(30) NOT NULL, Opis nvarchar(50) NOT NULL)
CREATE TABLE Status_zam (id_Statusu_zam int IDENTITY(1,1) PRIMARY KEY NOT NULL, Nazwa varchar(30))
CREATE TABLE Status_zlec (id_Statusu_zlec int IDENTITY(1,1) PRIMARY KEY NOT NULL, Etap varchar(30))
CREATE TABLE Dostawcy (id_Dostawcy int IDENTITY(1,1) PRIMARY KEY NOT NULL, Marka varchar(30), Model varchar(30), Numer_rejestracyjny varchar(7), Stawka money, Nosnosc varchar(10), Gabaryty varchar(20))
CREATE TABLE Pracownicy (id_pracownik INT IDENTITY(1,1) PRIMARY KEY NOT NULL, nazwisko VARCHAR(30) NOT NULL, imie VARCHAR(30) NOT NULL, telefon VARCHAR(12) NULL, Id_Adresu int FOREIGN KEY REFERENCES Adresy(Id_Adresu),Pesel nvarchar(11) NOT NULL  )
CREATE TABLE Dostawa (id_Dostawy int IDENTITY(1,1) PRIMARY KEY NOT NULL, id_Pracownika int FOREIGN KEY REFERENCES Pracownicy(id_Pracownik), Id_Adresu int FOREIGN KEY REFERENCES Adresy(Id_Adresu), Id_Pojazdu int FOREIGN KEY REFERENCES Dostawcy(Id_Dostawcy), Długość_Trasy int)
CREATE TABLE Dost_Prod (id_Produktu int FOREIGN KEY REFERENCES Produkt(Id_Produktu), Id_Dostawy int FOREIGN KEY REFERENCES Dostawa(Id_Dostawy), Ilosc int)
CREATE TABLE Firmy (id_Firmy int IDENTITY(1,1) PRIMARY KEY NOT NULL, Nazwa_firmy varchar(30), Adres_email varchar(30), Nr_telefonu varchar(12), NIP varchar(10))
CREATE TABLE Zlecenia (id_Zlecenia int IDENTITY(1,1) PRIMARY KEY NOT NULL, Data_zlecenia varchar(8), Data_realizacji varchar(8), Id_Firmy int FOREIGN KEY REFERENCES Firmy(Id_Firmy), Id_Statusu_zlec int FOREIGN KEY REFERENCES Status_zlec(Id_Statusu_zlec))
CREATE TABLE Zlec_Dost (id_Zlecenia int FOREIGN KEY REFERENCES Zlecenia(Id_Zlecenia), Id_Dostawy int FOREIGN KEY REFERENCES Dostawa(Id_Dostawy), Ilość int)
CREATE TABLE Faktury (id_Faktury int IDENTITY(1,1) PRIMARY KEY NOT NULL, Id_Zlecenia int FOREIGN KEY REFERENCES Zlecenia(Id_Zlecenia), Id_Pracownika int FOREIGN KEY REFERENCES Pracownicy(id_Pracownik), Data_wystawienia varchar(8))
CREATE TABLE Firma_adres (id_Firmy int FOREIGN KEY REFERENCES Firmy(Id_Firmy), Id_Adresu int FOREIGN KEY REFERENCES Adresy(Id_Adresu))  
CREATE TABLE Material (id_Materialu int IDENTITY(1,1) PRIMARY KEY NOT NULL, Nazwa varchar(30) NOT NULL, Pelna_nazwa_materialu varchar(30) NOT NULL, Oznaczenie_surowca varchar(15))
CREATE TABLE StanMag_Mat (id_Lokalizacji int FOREIGN KEY REFERENCES Lokalizacja(Id_Lokalizacji), ID_Materialu int FOREIGN KEY REFERENCES Material(Id_Materialu),Ilosc int, Data_wpisu varchar(8))
CREATE TABLE StanMag_Prod (id_Lokalizacji int FOREIGN KEY REFERENCES Lokalizacja(Id_Lokalizacji), Id_Produktu int FOREIGN KEY REFERENCES Produkt(Id_Produktu),Ilosc int, Data_wpisu varchar(8))
CREATE TABLE Zamowienia (id_Zamowienia int IDENTITY(1,1) PRIMARY KEY NOT NULL, Data_zamowienia varchar(30), Data_realizacji varchar(8), Id_Firmy int FOREIGN KEY REFERENCES Firmy(Id_Firmy), Id_Statusu_zam int FOREIGN KEY REFERENCES Status_zam(Id_Statusu_zam)) 
CREATE TABLE Zam_mat (id_Zamowienia int FOREIGN KEY REFERENCES Zamowienia(id_Zamowienia), id_Materialu int FOREIGN KEY REFERENCES Material(Id_Materialu), Ilosc int)
CREATE TABLE Zlec_prod (id_Zlecenia int FOREIGN KEY REFERENCES Zlecenia(id_Zlecenia), Id_Produktu int FOREIGN KEY REFERENCES Produkt(Id_Produktu), Ilosc int NOT NULL)
CREATE TABLE Stanowisko (id_stanowisko INT IDENTITY(1,1) PRIMARY KEY NOT NULL , nazwa char(30) NOT NULL);
CREATE TABLE StanowiskoPracownicy (id_pracownik INT FOREIGN KEY REFERENCES pracownicy(id_pracownik) NOT NULL, id_stanowisko INT FOREIGN KEY REFERENCES stanowisko(id_stanowisko) NOT NULL, data_start DATE DEFAULT GETDATE() NOT NULL, data_koniec DATE NULL);
CREATE TABLE Podatek (id_podatek INT IDENTITY(1,1) PRIMARY KEY NOT NULL, stawka FLOAT NOT NULL, data DATE DEFAULT GETDATE() NOT NULL);
CREATE TABLE Waluty (id_waluty INT IDENTITY(1,1) PRIMARY KEY NOT NULL, nazwa CHAR(30) NOT NULL, kurs_do_pln float(24) DEFAULT 1 NOT NULL, data_kurs DATE DEFAULT GETDATE() NOT NULL);
CREATE TABLE Szkolenia (id_szkolenia INT IDENTITY(1,1) PRIMARY KEY NOT NULL, nazwa_szkolenia VARCHAR(50) NOT NULL, opis_szkolenia VARCHAR NULL, data_start DATE DEFAULT GETDATE() NOT NULL, data_koniec DATE NOT NULL);
CREATE TABLE Wolne (id_wolne INT IDENTITY(1,1) PRIMARY KEY NOT NULL, symbol CHAR(10) NOT NULL, nazwa VARCHAR(30) NOT NULL);
CREATE TABLE WolnePracownicy (id_wolne INT FOREIGN KEY REFERENCES wolne(id_wolne) NOT NULL, id_pracownik INT FOREIGN KEY REFERENCES pracownicy(id_pracownik) NOT NULL, data_start DATE DEFAULT GETDATE() NOT NULL, data_koniec DATE DEFAULT GETDATE() NOT NULL);
CREATE TABLE Miesiac (id_miesiac INT IDENTITY(1,1) PRIMARY KEY NOT NULL, miesiac CHAR NOT NULL);
CREATE TABLE Okres (id_okres INT IDENTITY(1,1) PRIMARY KEY NOT NULL, nazwa VARCHAR(50) NOT NULL);
CREATE TABLE Stawka (id_stawka INT IDENTITY(1,1) PRIMARY KEY NOT NULL, wartosc MONEY NOT NULL, id_okres INT FOREIGN KEY REFERENCES okres(id_okres) NOT NULL);
CREATE TABLE StawkaPracownicy (id_pracownik INT FOREIGN KEY REFERENCES pracownicy(id_pracownik) NOT NULL, id_stawka INT FOREIGN KEY REFERENCES stawka(id_stawka)NOT NULL, data_start DATE NOT NULL DEFAULT GETDATE(), data_koniec DATE NULL); 
CREATE TABLE SzkoleniePracownicy (id_pracownik INT FOREIGN KEY REFERENCES pracownicy(id_pracownik) NOT NULL, id_szkolenia INT FOREIGN KEY REFERENCES szkolenia(id_szkolenia) NOT NULL);
CREATE TABLE PARAMETRY (ID_Parametr int IDENTITY(1,1) PRIMARY KEY NOT NULL,Nazwa nvarchar(50) NOT NULL,Jednostka_miary nvarchar(50) NOT NULL)
CREATE TABLE MODELE_MASZYN (ID_Model_maszyny int IDENTITY(1,1) PRIMARY KEY NOT NULL,Model nvarchar(50) NOT NULL,Marka nvarchar(50) NOT NULL,Typ_Maszyny nvarchar(50) NOT NULL,Prędkość int NOT NULL,Posuw int NOT NULL,Koszt_za_h money NOT NULL)
CREATE TABLE PAR_MASZYNY (ID_Parametr int FOREIGN KEY REFERENCES PARAMETRY(ID_Parametr),ID_Model_maszyny int FOREIGN KEY REFERENCES MODELE_MASZYN(ID_Model_maszyny),Wartość int NOT NULL)
CREATE TABLE MASZYNY (ID_Maszyny int IDENTITY(1,1) PRIMARY KEY NOT NULL,ID_Model_maszyny int FOREIGN KEY REFERENCES MODELE_MASZYN(ID_Model_maszyny),Nr_ewidencyjny nvarchar(20) NOT NULL)
CREATE TABLE NARZEDZIA (ID_Narzedzia int IDENTITY(1,1) PRIMARY KEY NOT NULL,Nazwa nvarchar(50) NOT NULL,Model nvarchar(50) NOT NULL,Nr_ewidencyjny nvarchar(20) NOT NULL,Koszt_za_h money NOT NULL)
CREATE TABLE SLOWNIK_PROCES_TECHNOLOGICZNY(ID_Slownik_proces_technologiczny int IDENTITY(1,1) PRIMARY KEY NOT NULL,Nazwa_procesu nvarchar(50) NOT NULL)
CREATE TABLE PROCES (ID_Procesu int IDENTITY(1,1) PRIMARY KEY NOT NULL,ID_Slownik_proces_technologiczny int FOREIGN KEY REFERENCES SLOWNIK_PROCES_TECHNOLOGICZNY(ID_Slownik_proces_technologiczny),ID_Maszyny int FOREIGN KEY REFERENCES MASZYNY(ID_Maszyny),Nazwa_procesu nvarchar(50) NOT NULL,Czas_trwania int )
CREATE TABLE PROCES_NARZEDZIA (ID_Narzedzia int FOREIGN KEY REFERENCES NARZEDZIA(ID_Narzedzia),ID_Procesu int FOREIGN KEY REFERENCES PROCES(ID_Procesu))
CREate TABLE PROJEKT (ID_Projektu int IDENTITY(1,1) PRIMARY KEY NOT NULL,Czy_istnieje bit NOT NULL,Koszt money NOT NULL,Czas_realizacji datetime NOT NULL)
CREATE TABLE DOKUMENTACJA (ID_Dokumentacji int IDENTITY(1,1) PRIMARY KEY NOT NULL,Nr_rysunku nvarchar(15) NOT NULL,Data_wprowadzenia datetime NOT NULL,ID_Pracownik int FOREIGN KEY REFERENCES PRACOWNICY(ID_Pracownik),ID_Projektu int FOREIGN KEY REFERENCES PROJEKT(ID_Projektu))
CREATE TABLE DOKUMENTACJA_PROCES (ID_Dokumentacji int FOREIGN KEY REFERENCES DOKUMENTACJA(ID_Dokumentacji),ID_Procesu int FOREIGN KEY REFERENCES PROCES(ID_Procesu))
CREATE TABLE PAR_MAT(ID_Material int FOREIGN KEY REFERENCES MATERIAL(id_Materialu),ID_Parametr int FOREIGN KEY REFERENCES PARAMETRY(ID_Parametr),Wartość int NOT NULL)
CREATE TABLE POLPRODUKTY (ID_Polproduktu int IDENTITY(1,1) PRIMARY KEY NOT NULL,ID_Material int FOREIGN KEY REFERENCES MATERIAL(ID_Materialu),ID_Dokumentacji int FOREIGN KEY REFERENCES DOKUMENTACJA(ID_Dokumentacji),Liczba_sztuk int NOT NULL)
CREATE TABLE PROD_POLPROD (ID_Polproduktu int FOREIGN KEY REFERENCES POLPRODUKTY(ID_Polproduktu),ID_Produktu int FOREIGN KEY REFERENCES PRODUKT(ID_Produktu),Czas_realizacji_montazu date NOT NULL,Koszt_realizacji_montazu money NOT NULL)
--Tej tabeli nie wypełniamy
CREATE TABLE Zlecenia_KOSZTY(Id_Zlecenia int FOREIGN KEY REFERENCES Zlecenia(id_Zlecenia), Koszt_Materialu int, Koszt_Transportu int, Koszt_Produkcji int, Kodzt_Dostarczenia int)
