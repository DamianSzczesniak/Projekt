--procedure new stored procedure
create procedure AddPracownik
(
@Imie		varchar(30),
@Nazwisko	varchar(30),
@Tel		varchar(12),
@PESEL		varchar(11),
@Stanowisko	char(30),
@Ulica		varchar(30),
@Nrbudynku	varchar(10),
@Nrlokalu	varchar(10),
@Kodpocztowy	varchar(5),
@Kraj		varchar(15),
@Miasto		varchar(50),
@DataRozpoczeciaPracy	date
)

as
begin
insert into PRACOWNICY (IMIE, NAZWISKO, TELEFON, PESEL) values (@Imie, @Nazwisko, @Tel, @PESEL)
insert into STANOWISKO (NAZWA) values (@Stanowisko)
insert into ADRESY_PRACOWNICY (ULICA, NR_BUDYNKU, NR_LOKALU, KOD_POCZTOWY, KRAJ) 
			values (@Ulica, @Nrbudynku, @Nrlokalu, @Kodpocztowy, @Kraj)
insert into MIASTA (NAZWA) values (@Miasto)
insert into STANOWISKO_PRACOWNICY (DATA_START) values (@DataRozpoczeciaPracy)	
end