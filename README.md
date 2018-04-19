## Numerical System Converter
# Dokumtacja

<p align="center">
<b>
Spis Treści:<br>
1. Lista oznaczeń<br>
2. Wstęp<br>
3. Wymagania systemowe<br>
4. Funkcjonalność<br>
5. Analiza problemu<br>
6. Projekt techniczny <br>
7. Opis realizacji<br>
8. Opis wykonanych testów<br>
9. Podręcznik użytkownika<br>
</b></p>



<b>1. Lista oznaczeń</b>

BIN - 
OCT - 
DEC - 
HEX - 

<b>2. Wstęp</b>

Aplikacja moblina na systemy Android obliczająca wartość liczby z zadanego systemu liczbowego (BIN, OCT, DEC, HEX) na pozostałe systemy. Aplikacja jest zarówno polsko jak i angielskojęzyczna. 


**3.	Wymagania systemowe** 




**4.Funkcjonalność **

- obliczanie liczby zadanej w określonym formacie na pozostałe systemy dostępne w ramach aplikacji
- możliwość zmiany języku 


**5.Analiza problemu** 

Zamiana  systemów liczbowych: 



**6.Projekt techniczny **


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





**7.Opis realizacji**

[dokładny opis platformy testowej - maszyna, narzędzia, kompilatory, system utrzymania źródeł, bcup, itd.]



Podsumowując, zaobserwowane problemy do rozwiązania to:
Próba określenia funkcji ...
Próba matematycznego zamodelowania funkcji ….
Zbudowanie cyfrowego generatora funkcji ….

**8.Opis wykonanych testów ** - lista buggów, uzupełnień, itd.

**9.Podręcznik użytkownika **


Test Application for Windows

With the help of the HIL a simple Win32 application was created. This is a standard multi document-view architecture of the MFC platform, depicted in Rysunek 71. Visible are the original image of a road scene with its affinely warped version (behind) and below the 5x5 median filtered (below).

10.Metodologia rozwoju i utrzymania systemu (system maintenance and deployment)

Bibliografia

[Stroustrup, Sommervile, McConnel, Hunt & Thomas]

