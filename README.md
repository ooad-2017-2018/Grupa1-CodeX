# AV-MAU SARAJEVO CITY SHELTER



Članovi tima:

1. Ajna Zatrić

2. Nadir Avdagić

3. Edin Avdić



## Opis teme


Sistem je namijenjen za rad (poslovanje) azila za nezbrinute životinje.
 Azil pruža privremeno sklonište životinjama (psi i mačke), omogućuje njihovo udomljavanje, veterinarske preglede i dresuru.
 Osnovna svrha informacionog sistema je da pruži efikasno i jednostavno obavljanje gore
 navedenih zahtjeva koji se postavljaju pred savremeno sklonište za životinje.


Problem prekomjernog broja  pasa i maca lutalica je poznat široj javnosti u Sarajevu.
 Neuređenost i decentralizovanost procesa prihvatanja životinja u azilima kod kojih se
 evidencije vrše manuelno doprinose greškama na svakodnevnom nivou,
 i otežavaju i usporavaju proces pružanja pomoći i zaštite životinja,
 a svakako i umanjuju učinak i trud uposlenih.

Predloženi sistem pruža korisniku mogućnost jednostavnog i efikasnog
 smještanja nezbrinutih životinja u azil, te udomljavanje istih iz azila. 
Aplikacija će također pružati pogodnosti poput: jedinstvena evidencija o uposlenicima,
 zatim o udomiteljima, i naposlijetku psima i macama.
 Sistematizacija podataka predviđena aplikacijom bi, također,
 omogućila bržu i jednostavniju saradnju uposlenika (vozača, veterinara, higijeničara, upravitelja,  udomitelja...).


Razlog kupovine/unajmljivanja sistema je činjenica da u Sarajevu  ne postoji sličan informacioni sistem koji
 bi olakšao djelovanje u ovoj sferi,
  te posljedično sveo mogućnost grešaka na minimum.
 Sistem će pružiti lakši vid saradnje sa korisnicima i udomiteljima,
 i u konačnici, omogućiti bolji i humaniji suživot stanovnika i četveronožnih
 stanovnika u gradu Sarajevu.



## Procesi



- Prijava životinje

Korisnik (guest - neregistrovani ili registrovani) šalje zahtjev za zbrinjavanje pronađene životinje-lutalice.
 Zahtjev uključuje lokaciju pronađene životinje, te stanje u kojem je životinja zatečena.
 Taj zahtjev se procesira i izvršava od strane odgovornog
 osoblja iz azila (vozač ide na teren po psa/macu).
 Životinja se sprema u privremeni smještaj do veterinarskog pregleda nadležne osobe.




- Sistematski pregled

Nadležni veterinar koji preuzme zahtjev odgovorne osobe koja je zaprimila životinju
 prije svega daje  stručno mišljenje o tome da li je životinja podobna za udomljavanje.
 Ukoliko nije, slijedi proces eutanazije, a ako jeste slijedi veterinarski pregled
 i registracija životinje nakon čega se  ista smješta  u azil za udomljavanje.  
Sistematski pregled uključuje: 
osnovne podatke (mjerenje težine i visine, procjena starosti i, eventualno, rase),
anamneza i utvrđivanje zdravstvenog stanja. 
Veterinar također vrši procjenu stadija dresiranosti životinje (za pse), 
odnosno naučenosti na život u domaćinstvu (za mace).
Sve navedene podatke veterinar unosi, obavljajući
 pri tom istovremeno i registraciju (evidenciju) životinje u azil. 
Po finaliziranom pregledu, pas/maca se smešta u odgovarajući boks u azilu.




- Udomljavanje 

Registrirani korisnik šalje zahtjev za udomljavanje životinje koju je izabrao iz
 kataloga životinja (petbook-a) spremnih za udomljavanje.
 Nadležna osoba uviđa da li je potencijalni udomitelj 
ispunio uvjete (mjesto, broj ljubimaca koje već posjeduje, finansijsko stanje) za
 udomljavanje, i ako jeste, zahtjev se odobrava. U suprotnom se šalje odbijenica.




- Veterinarske usluge i usluge dresure
 
Registrirani korisnik koji je udomio 1 ili više životinja iz azila “Av-Mau” šalje
 zahtjev za veterinarskim pregledom/dresurom. 
Jedna od pogodnosti koju nudi azil jesu besplatni pregledi i/ili dresura za 
svoje “matične” životinje, odnosno životinje udomljene iz azila.
 Nadležna osoba zaprima zahtjev(veterinar ili dreser) i obavlja datu uslugu.
 Provjera da li se radi o životinji koja je prethodno bila u azilu ostvaruje se 
putem čipa (jedinstveni QR kod životinje).
 Po obavljenom pregledu/dresuri šalje se povratna informacija
 o stanju životinje ili stupnju dresure.



## Funkcionalnosti



Funkcionalnosti koje će biti realizovane u sklopu aplikacije:


Funkcionalnosti za aktera "Korisnik":

- Za guest-korisnik-a:

- Mogućnost prijave nezbrinute životinje notifikacijom za online korisnike koji nisu registrovani (guest)


- Za korisnika koji bi želio udomiti životinju: 

 - Omogućuje se registracija (forma sa detaljnim unosom podataka koji sistem validira) za potencijalne udomitelje

 - Mogućnost prijave u sistem i pregled kataloga dostupnih životinja za udomljavanje (mogućnost pretrage kataloga životinja po različitim filterima (mace/psi, spol, starosna dob..itd.))
 
 - Mogućnost slanja zahtjeva za udomljavanje sa specifičnom formom koja sadrži motivaciono pismo, uvjete koje udomitelj nudi itd.
 
 - Mogućnost primanja odobrenja administracije ili odbijenice za zahtjev
 
 - Mogućnost grafičkog statističkog prikaza strukture azila (po odnosu mačaka i pasa, starosnoj dobi, i spolu)
 
 
- Za već registriranog korisnika i/ili korisnika koji je već udomio životinju iz azila:

- Mogućnost slanja zahtjeva za dresuru životinje

- Mogućnost slanja zahtjeva za pregled udomljene životinje
 
 

Funkcionalnosti za aktera "Uposlenik":


- Mogućnost prijave u sistem sa različitim privilegijama (mogućnost da svaki član ima formu na kojoj bira (verificira) različit nivo pristupa kada su u pitanju privilegije u sistemu (upravitelj, veterinar, vozač, itd.))

- Mogućnost online komunikacije različitih profila uposlenika zahtjevima/notifikacijama

- Mogućnost pretrage kataloga životinja po različitim filterima (mace/psi, spol, starosna dob..itd.)


Za vozača:
- Mogućnost pregleda prijava nezbrinutih životinja od strane korisnika

- Mogućnost slanja zahtjeva veterinaru, za pregled novo-pristigle životinje u azil

Za veterinara:
- Mogućnost registracije životinja (unos osnovnih podataka i zdravstvenog stanja u karton), čime životinja dobija jedinstven kod i profil u katalogu

- Mogućnost primanja zahtjeva za čisto veterinarske usluge (za udomljene životinje)

- Mogućnost odgovora na zahtjev

- Mogućnost korištenja forme za manipulaciju sa eksternim uređajem (skeniranje jedinstvenog QR koda sa čipa životinje kako bi se omogućilo prepoznavanje životinje koja je boravila u azilu)

- Mogućnost unosa zdravstvenog stanje životinje u postojeći karton 



Za upravitelja i direktora:
- Mogućnost upozorenja o stanju zaliha hrane i popunjenosti kapaciteta azila (u vidu grafikona)

- Mogućnost grafičkog statističkog prikaza strukture azila (po odnosu mačaka i pasa, starosnoj dobi, i spolu)

- Mogućnost pregleda zahtjeva za udomljavanje i slanja odbijenice ili odobrenja korisniku

- Mogućnost brisanja životinje po udomljavanju

- Mogućnost korištenja forme za manipulaciju sa eksternim uređajem (skeniranje jedinstvenog QR koda sa čipa životinje kako bi se omogućilo prepoznavanje životinje koja je boravila u azilu)


Za dresera:
- Mogućnost primanja zahtjeva za dresuru  (za udomljene životinje)

- Mogućnost odgovora na zahtjev

- Mogućnost korištenja forme za manipulaciju sa eksternim uređajem (skeniranje jedinstvenog QR koda sa čipa životinje kako bi se omogućilo prepoznavanje životinje koja je boravila u azilu)



## Akteri


1.Korisnik (udomitelj, online udomitelj)
Korisnik usluga je osoba koja ima mogućnost prijave nezbrinute životinje i udomljavanja na licu mjesta ili putem online aplikacije. 


2.Uposlenik - Uposlenik je osoba koja radi za firmu “Av-Mau Shelter”, na nekoj od sljedećih pozicija:

2.1.Vozač - vozačima zadatak da po prijavi životinje vrši usluge odlaska po životinju na teren i dovoženje u azi.

2.2. Upravni administrativni kadar - direktor azila i upravitelj

2.3. Veterinari - veterinarsko osoblje zaduženo za preglede zdravstvenog stanja životinja pri prijemu u azil i preglede životinja nakon udomljavanja

2.4. Dreseri -profesionalni dreseri zaduženi za dresuru životinja, kao jednog od dopunskih usluga azila

2.5.Higijeničari/ hranitelji- osoblje koje održava higijenu azila i hrani životinje

2.6.Zaštitari (volonteri)
