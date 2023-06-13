using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaGraficzna
{
    class Narzedzia : INarzedzia
    {
        public event ColorHandler ZmianaKoloruNarzedzi;
        private Pen pedzel;
        public Pen Pedzel
        {
            get { return pedzel; }
            set { pedzel = value; }
        }

        private Color kolor;
        public Color Kolor
        {
            get { return kolor; }
            set
            {
                kolor = value;
                ZmianaKoloruNarzedzi?.Invoke(kolor);
            }
        }
        public Narzedzia()
        {
            kolor = Color.Black;
            pedzel = new Pen(kolor, 5);
            pedzel.StartCap = pedzel.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            ZmianaKoloruNarzedzi += (Color) =>
            {
                pedzel.Color = Color;
            };
        }

        public virtual void ZmianaRozmiaruNarzedzia(float rozmiar)
        {
            pedzel.Width = rozmiar;
        }

        public virtual void ZmianaKoloru(Color kolor)
        {
            this.Kolor = kolor;
        }

    }
}
