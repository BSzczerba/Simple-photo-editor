using System.Drawing;

namespace AplikacjaGraficzna
{
    interface INarzedzia
    {
        Color Kolor { get; set; }
        Pen Pedzel { get; set; }

        event ColorHandler ZmianaKoloruNarzedzi;

        void ZmianaKoloru(Color kolor);
        void ZmianaRozmiaruNarzedzia(float rozmiar);
    }
}