using System;
using System.Drawing;

namespace AplikacjaGraficzna
{
    interface IZarzadzaniePlikami
    {
        Bitmap Bmp { get; set; }

        event BitmapHandler NowyPlikWczytany;

        void Wczytaj(object sender, EventArgs e);
        void Zapisz(object sender, EventArgs e);
    }
}