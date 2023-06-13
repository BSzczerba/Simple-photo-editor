using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaGraficzna
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormEdytoraGraficznego form = new FormEdytoraGraficznego();
            Narzedzia narzedzia = new Narzedzia();
            ZarzadzaniePlikami zarzadzaniePlikami = new ZarzadzaniePlikami();
            EdytorGraficzny aplikacja = new EdytorGraficzny(narzedzia,form,zarzadzaniePlikami,form);
            aplikacja.UruchomEdytor();
        }
    }
}
