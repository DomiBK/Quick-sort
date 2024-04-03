# Quick-sort
Zadanie:
Napisz algorytm sortowania szybkiego i przetestuj go na losowej tablicy liczb całkowitych. Porównaj jego wydajność z innymi algorytmami sortowania, takimi jak sortowanie przez scalanie czy sortowanie bąbelkowe.

Opis działania algorytmu sortowania szybkiego:
Wybór elementu podziału (pivot):
Wybierz jeden z elementów tablicy jako pivot. Możesz wybrać pierwszy, ostatni, środkowy element lub losowy.

Podział tablicy:
Podziel tablicę na dwie części: elementy mniejsze lub równe pivotowi oraz elementy większe od pivota.
Elementy mniejsze umieść po lewej stronie pivotu, a większe po prawej.

Rekurencyjne sortowanie podtablic:
Powtórz proces sortowania szybkiego dla podtablic mniejszych i większych od pivotu.

Scalanie wyników:
Po posortowaniu wszystkich podtablic, scal je w jedną posortowaną tablicę.

Przykład działania:
Weźmy tablicę liczb: [7, 2, 1, 6, 8, 5, 3, 4].
Wybierzmy pivot, np. ostatni element: 4.
Podzielmy tablicę na elementy mniejsze i większe od pivota: [2, 1, 3], 4, [7, 6, 8, 5].
Rekurencyjnie posortujmy podtablice [2, 1, 3] i [7, 6, 8, 5].
Po scaleniu wynik będzie wyglądał tak: [1, 2, 3, 4, 5, 6, 7, 8]

Na cel utwórz algorytm quick-sort dla macierzy o dowolnych rozmiarach losowych wartościach zmiennoprzecinkowych 
Moja praca
