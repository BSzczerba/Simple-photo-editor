using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaGraficzna
{
    class EdytorGraficzny
    {
        protected INarzedzia narzedzia;
        protected IFormEdytoraGraficznego formularz;
        protected IZarzadzaniePlikami zarzadzaniePlikami;
        protected IElementyInterfejsu elementyInterfejsu;
        protected float X;
        protected float Y;
        public EdytorGraficzny(INarzedzia narzedzia, IFormEdytoraGraficznego formularz,
            IZarzadzaniePlikami zarzadzaniePlikami, IElementyInterfejsu elementyInterfejsu)
        {
            this.zarzadzaniePlikami = zarzadzaniePlikami;
            this.narzedzia = narzedzia;
            this.formularz = formularz;
            this.elementyInterfejsu = elementyInterfejsu;
            formularz.ZmianaRozmiaruNarzedzia += narzedzia.ZmianaRozmiaruNarzedzia;
            formularz.ZmianaKoloru += narzedzia.ZmianaKoloru;
            formularz.Rysuj += this.Rysuj;
            elementyInterfejsu.DodajZadrzenieDoPrzyciskuZapisz(zarzadzaniePlikami.Zapisz);
            elementyInterfejsu.DodajZadrzenieDoPrzyciskuWczytaj(zarzadzaniePlikami.Wczytaj);
            elementyInterfejsu.DodajZadrzenieMouseDownDoPictureBoxa(this.ZmienKoordynaty);
            zarzadzaniePlikami.NowyPlikWczytany += formularz.ZmianaWyswietlanegoObrazu;                  
        }
        public virtual void UruchomEdytor()
        {
            formularz.Otworz();
        }
        public virtual void WylaczEdytor()
        {
            formularz.Zamknij();
        }
        public virtual void Rysuj(MouseEventArgs e)
        {
            using (Graphics g = Graphics.FromImage(zarzadzaniePlikami.Bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawLine(narzedzia.Pedzel, (X / elementyInterfejsu.DajSzerokoscPrictureBoxa()) * zarzadzaniePlikami.Bmp.Width,
                    (Y / elementyInterfejsu.DajWysokoscPrictureBoxa()) * zarzadzaniePlikami.Bmp.Height,
                    ((float)e.X / elementyInterfejsu.DajSzerokoscPrictureBoxa()) * zarzadzaniePlikami.Bmp.Width, 
                    ((float)e.Y / elementyInterfejsu.DajWysokoscPrictureBoxa()) * zarzadzaniePlikami.Bmp.Height);
                X = e.X;
                Y = e.Y;
            }
            elementyInterfejsu.InvalidujPicturBoxa();
        }
        protected virtual void ZmienKoordynaty(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
        }
    }
}
