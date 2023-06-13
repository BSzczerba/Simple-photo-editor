using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaGraficzna
{
    public delegate void BitmapHandler(Bitmap x);
    class ZarzadzaniePlikami : IZarzadzaniePlikami
    {
        public event BitmapHandler NowyPlikWczytany;
        protected Bitmap bmp;
        public Bitmap Bmp { get { return bmp; } set { bmp = value; } }
        protected OpenFileDialog openFileDialog;
        public ZarzadzaniePlikami()
        {
            openFileDialog = new OpenFileDialog();
        }
        public virtual void Zapisz(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                SaveFileDialog zapisz = new SaveFileDialog();
                zapisz.Filter = "Images|*.png;*.bmp;*.jpg";
                if (zapisz.ShowDialog() == DialogResult.OK)
                {
                    string ext = Path.GetExtension(zapisz.FileName);
                    switch (ext)
                    {
                        case ".png": { bmp.Save(zapisz.FileName, ImageFormat.Png); break; }
                        case ".jpg": { bmp.Save(zapisz.FileName, ImageFormat.Jpeg); break; }
                        case ".bmp": { bmp.Save(zapisz.FileName, ImageFormat.Bmp); break; }
                        case "": { bmp.Save(zapisz.FileName, ImageFormat.Png); break; }
                        default: { MessageBox.Show("Nieprwidłowy format danych"); Zapisz(sender, e); break; }
                    }
                }
            }
            else
            {
                MessageBox.Show("Żaden obraz nie został wczytany");
            }
        }
        public virtual void Wczytaj(object sender, EventArgs e)
        {
            DialogResult dialog = openFileDialog.ShowDialog();
            bool zlyformat = true;
            if (dialog == DialogResult.OK)
            {
                string ext = Path.GetExtension(openFileDialog.FileName);
                List<string> ListaExt = new List<string>();
                ListaExt.Add(".png");
                ListaExt.Add(".jpg");
                ListaExt.Add(".bmp");
                foreach (var item in ListaExt)
                {
                    if (item == ext || item.ToUpper() == ext)
                    {
                        Image Plik = Image.FromFile(openFileDialog.FileName);
                        bmp = (Bitmap)Plik;
                        NowyPlikWczytany?.Invoke(bmp);
                        zlyformat = false;
                    }
                }
                if (zlyformat)
                {
                    MessageBox.Show("Nieprwidłowy format danych");
                    Wczytaj(sender, e);
                }
            }
        }
    }
}
