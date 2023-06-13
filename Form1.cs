using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaGraficzna
{
    public delegate void SizeHandler(float x);
    public delegate void ColorHandler(Color x);
    public delegate void RysujHandler(MouseEventArgs e);
    public partial class FormEdytoraGraficznego : Form,IFormEdytoraGraficznego,IElementyInterfejsu
    {
        public event SizeHandler ZmianaRozmiaruNarzedzia;
        public event ColorHandler ZmianaKoloru;
        public event RysujHandler Rysuj;
        public FormEdytoraGraficznego()
        {
            InitializeComponent();

        }
        public void Otworz()
        {
            this.ShowDialog();
        }
        public void Zamknij()
        {
            this.Close();
        }

        public void ZmianaWyswietlanegoObrazu(Image obraz)
        {
            if (obraz.Height > 1000 || obraz.Width > 1500)
            {
                if (obraz.Height > obraz.Width)
                {
                    var skala = (double)obraz.Width/obraz.Height;
                    pictureBox.Height = 1000;
                    pictureBox.Width = (int)(1000 * skala);
                }
                else
                {
                    var skala = (double)obraz.Height/obraz.Width;
                    pictureBox.Width = 1000;
                    pictureBox.Height = (int)(1000 * skala);
                }
            }
            else
            {
                pictureBox.Width = obraz.Width;
                pictureBox.Height = obraz.Height;
            }
            pictureBox.Image = obraz;
        }

        private void ButtonKolor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ZmianaKoloru?.Invoke(colorDialog.Color);
                KolorowyKwadrat.BackColor = colorDialog.Color;

            }
        }

        private void TrackBarRozmiar_Scroll(object sender, EventArgs e)
        {
            ZmianaRozmiaruNarzedzia?.Invoke(TrackBarRozmiar.Value);
            LabelRozmiar.Text = TrackBarRozmiar.Value.ToString();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && pictureBox.Image != null)
            {
                Rysuj?.Invoke(e);
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }

        public int DajWysokoscPrictureBoxa()
        {
            return pictureBox.Height;
        }

        public int DajSzerokoscPrictureBoxa()
        {
            return pictureBox.Width;
        }

        public void InvalidujPicturBoxa()
        {
            pictureBox.Invalidate();
        }

        public void DodajZadrzenieMouseDownDoPictureBoxa(MouseEventHandler zdarzenie)
        {
            pictureBox.MouseDown += zdarzenie;
        }

        public void DodajZadrzenieDoPrzyciskuWczytaj(EventHandler zdarzenie)
        {
            ButtonWczytaj.Click += zdarzenie;
        }

        public void DodajZadrzenieDoPrzyciskuZapisz(EventHandler zdarzenie)
        {
            ButtonZapisz.Click += zdarzenie;
        }
    }
}
