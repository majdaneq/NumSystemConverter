# NumSystemConverter
Numerical System Converter

Android App which converts the number given in binary, oct, dec, hex system to the others.
lab 18.04.2018

1. Lista oznaczeń

[tu dodajemy swoje oznaczenia użyte w tym dokumencie]

2. Wstęp

Dokument dotyczy opracowania wizyjnego systemu monitoringu stanu kierowcy. Celem tego systemu jest wykrycie oraz wszczęcie alarmu w przypadku wykrycia przyśnięcia lub braku należytej koncentracji kierującego pojazdem mechanicznym. 


3.	Wymagania systemowe (requirements)


Podstawowe założenia projektu:

Przygotowanie syntetycznego opisu ….
Opracowanie architektury systemu przetwarzania sygnałów cyfrowych oraz dalsze dookreślenie potrzeb i założeń takich jak m.in. interfejsy modułów …. 
Opracowanie modułu … 



4.Funkcjonalność (functionality)


[punkty, tabelki, odpowiednie formatowanie tekstu, język, prostota wyrażania myśli]

5.Analiza problemu (problem analysis)



Sygnał s można zdefiniować jako pewną funkcję, która opisuje zależność wartościami wyjściowymi, takimi jak amplituda, a wejściowymi, takimi jak czas. W zależności od natury zjawiska użyta funkcja, np.
,
(1)
może być jedno- lub wielo-wymiarowa, może być opisana wzorem analitycznym lub też podana w postaci tabeli, itd. Co więcej wartości x mogą być zarówno rzeczywiste, jak i zespolone.

Tabela 31. Zależność między chwilami czasowymi ti oraz próbkami sygnału xi.

…
t0
t1
t2
t3
…
…
x0
x1
x2
x3
…



Rysunek 31 przedstawia przykładowy ciągły sygnał s(t), którego próbki pobierane są co okres T. W ten sposób otrzymywany jest sygnał dyskretny s[n], gdzie n oznacza numer kolejnej próbki.


Rysunek 31. Ciągły sygnał s(t) oraz ciąg próbek otrzymany z s(t) w stałych interwałach czasowych T.









[w czym rysować - np. Visio]




Rysunek 32. Schemat cyfrowego systemu LTI o wejściu x[n], wyjściu y[n], zadanego skończonymi ciągami wartości {pk} oraz {dk}.



6.Projekt techniczny (technical design)


[diagramy UML]

[diagram klas]


Parę Uwag Wstępnych

Równie istotna jest strona edycyjna utworzonego dokumentu (data utworzenia i kolejnych modyfikacji, nazwisko osoby oraz e-mail kontaktowy, copyrights, nazwa projektu, itd.)

W przypadku dużych projektów, każdy z wyżej wymienionych rozdziałów może być realizowany w postaci oddzielnego dokumentu.

Kod źródłowy rzadko umieszcza się w dokumentacji gdyż ulega on częstym zmianom. Nie oznacza to jednak, że kod źródłowy jest zupełnie nieopisany. Wręcz przeciwnie - kod źródłowy powinien dokumentować się sam, tzn. odpowiednie jego fragmenty powinny być uzupełnione treściwym, ale zwięzłym, komentarzem. W zależności od fragmentu kodu przypisany mu komentarz powinien przede wszystkim opisywać główną ideę, cel lub też specyfikę tego fragmentu kodu. W razie konieczności można automatycznie wygenerować dokumentację z opisem fragmentów kodu na podstawie jego struktury oraz zawartych tam komentarzy. Istnieje kilka narzędzi do tego celu, np. Doxygen […]. 

Poniżej przedstawiany przykładowe fragmenty funkcji wraz z przyjętym w naszych projektach formatem ich komentowania.


 
///////////////////////////////////////////////////////////
// This function does k-means on the input image.
///////////////////////////////////////////////////////////
//		
// INPUT:
//		tu opisujemy argumenty funkcji, ich typ i role
//		
// OUTPUT:
//		tu opisujemy co zwraca dana funkcja
//		
// REMARKS:
//		tutaj zapisujemy dodatkowe uwagi, np. dodatkowe
//		opcje wywołań, specjalny format argumentów, itd.
//		

Powyższy opis użyty w pewny fragmencie rzeczywistego projektu

 
///////////////////////////////////////////////////////////
// This function does k-means on the input image.
///////////////////////////////////////////////////////////
//		
// INPUT:
//		inImage - a color image
//		initialMeans - external table of the initial means
//		outMeanCenters - optional repository for output of final
//			k means
//		maxAllowableIteration - a fuse for max number of iterations
//		madeIterations - optional parameter for actual number
//			of iterations
//		
// OUTPUT:
//		status of the operation (see k_Means_Message)
//		
// REMARKS:
//		
//		
k_Means_Message k_MeansForImage::operator () ( 	const ColorImage & inImage, 
								const DataRepository & initialMeans, 
								ColorImage * & outImage, 
								int maxAllowableIteration /*= 1000*/ );
 


Podobnie dla klas, dla przykładu

 
///////////////////////////////////////////////////////////
// This class implements my vision of eye recognition.
///////////////////////////////////////////////////////////
class TEyeRecognition
 
 
 6.1
 Przykład - Main Class Hierarchy

Video streams are composed of strictly timed image frames. Rysunek 41 depicts class hierarchy for this video data structure. Data organization of a video object is presented in …. 

Rysunek 41. TVideoFor<> class hierarchy

The template class TVideoFor<> contains a vector of pointers to the frame images. Each frame is an object of the TImageFor<> class. 





7.Opis realizacji (implementation report)

[dokładny opis platformy testowej - maszyna, narzędzia, kompilatory, system utrzymania źródeł, bcup, itd.]



Podsumowując, zaobserwowane problemy do rozwiązania to:
Próba określenia funkcji ...
Próba matematycznego zamodelowania funkcji ….
Zbudowanie cyfrowego generatora funkcji ….

8.Opis wykonanych testów (testing report) - lista buggów, uzupełnień, itd.

9.Podręcznik użytkownika (user's manual)


Test Application for Windows

With the help of the HIL a simple Win32 application was created. This is a standard multi document-view architecture of the MFC platform, depicted in Rysunek 71. Visible are the original image of a road scene with its affinely warped version (behind) and below the 5x5 median filtered (below).

10.Metodologia rozwoju i utrzymania systemu (system maintenance and deployment)

Bibliografia

[Stroustrup, Sommervile, McConnel, Hunt & Thomas]

