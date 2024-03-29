# Numer PESEL
### Numer PESEL to 11-cyfrowy kod, jednoznacznie identyfikujący określoną osobę fizyczną. Dla wszystkich urodzonych przed 1.1.2000 r. skonstruowany został w następujący sposób: 
- cyfry od 1 do 6 to data urodzenia (w kolejności: rok, miesiąc, dzień), 
- cyfry od 7 do 9 to liczba porządkowa, 
- cyfra 10-ta to płeć (cyfra parzysta dla kobiet, nieparzysta dla mężczyzn), 
- cyfra 11-ta to cyfra kontrolna. 

Przykład: Numer  PESEL  75121968629  oznacza  kobietę  (bo  przedostatnia  cyfra  w  numerze  jest parzysta), urodzoną 19 grudnia 1975 roku, której nadano liczbę porządkową 686. Cyfra kontrolna jest obliczana wg następującego algorytmu: 
1.  Każdą cyfrę numeru PESEL (oprócz ostatniej, która jest cyfrą kontrolną) mnożymy przez odpowiadającą jej wagę. Tablica wag ma postać: 1, 3, 7, 9, 1, 3, 7, 9, 1, 3.
2.  W podanym powyżej numerze PESEL cyfrą kontrolną jest 9. PESEL:  7 5 1 2 1 9 6 8 6 2 9 (ostatnią cyfrę pomijamy, bo to cyfra kontrolna) WAGI:   1 3 7 9 1 3 7 9 1 3WYNIKI: 7x1=7; 5x3=15; 1x7=7; 2x9=18 ;1x1=1; 9x3=27; 6x7=42; 8x9=72; 6x1=6; 2x3=62.
3.  Wyniki sumujemy: 7 + 15 + 7 + 18 + 1 + 27 + 42 + 72 + 6 + 6 = 201 3.
4.  Wyznaczamy resztę z dzielenia sumy przez 10:   201:10 = 20 reszta = 1 4.
5.  Jeżeli reszta = 0, to cyfra kontrolna wynosi 0.
6.  Jeżeli reszta ≠ 0, to cyfra kontrolna będzie uzupełnieniem reszty do 10, czyli w podanym przykładzie jest to cyfra 9.
7.  Plik pesel.txt zawiera numery PESEL 150 osób zatrudnionych w biurze obliczeniowym „Statystyk”.
8.  Korzystając  z  informacji  zawartych  w  pliku pesel.txt  oraz  dostępnych narzędzi  informatycznych,  wykonaj  poniższe  polecenia.

Polecenia:

-  Ile osób urodziło się w grudniu?
-  Podaj, ile kobiet pracuje w biurze obliczeniowym.
-  Podaj rok, w którym urodziło się najwięcej osób pracujących w biurze.
-  Wyszukaj  nieprawidłowe  numery  PESEL,  w  których  nie  zgadza  się  cyfra  kontrolna.Posortuj te numery PESEL rosnąco.
-  Sporządź zestawienie liczby osób urodzonych w kolejnych dziesięcioleciach, tzn. w latach pięćdziesiątych,  sześćdziesiątych,  siedemdziesiątych,  osiemdziesiątych  i  dziewięć-dziesiątych.

