using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaGraficzna
{
    interface IElementyInterfejsu
    {
        int DajWysokoscPrictureBoxa();
        int DajSzerokoscPrictureBoxa();
        void InvalidujPicturBoxa();
        void DodajZadrzenieMouseDownDoPictureBoxa(MouseEventHandler zdarzenie);
        void DodajZadrzenieDoPrzyciskuWczytaj(EventHandler zdarzenie);
        void DodajZadrzenieDoPrzyciskuZapisz(EventHandler zdarzenie);       
    }
}
