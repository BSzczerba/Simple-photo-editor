using System.Drawing;

namespace AplikacjaGraficzna
{
    public interface IFormEdytoraGraficznego
    {
        event RysujHandler Rysuj;
        event ColorHandler ZmianaKoloru;
        event SizeHandler ZmianaRozmiaruNarzedzia;

        void ZmianaWyswietlanegoObrazu(Image obraz);
        void Zamknij();
        void Otworz();
    
    }
}