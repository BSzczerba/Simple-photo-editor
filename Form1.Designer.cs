
namespace AplikacjaGraficzna
{
    partial class FormEdytoraGraficznego
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonWczytaj = new System.Windows.Forms.Button();
            this.ButtonZapisz = new System.Windows.Forms.Button();
            this.TrackBarRozmiar = new System.Windows.Forms.TrackBar();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.ButtonKolor = new System.Windows.Forms.Button();
            this.LabelRozmiar = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panelPrzyrzadow = new System.Windows.Forms.Panel();
            this.KolorowyKwadrat = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRozmiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelPrzyrzadow.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonWczytaj
            // 
            this.ButtonWczytaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonWczytaj.Location = new System.Drawing.Point(127, 507);
            this.ButtonWczytaj.Name = "ButtonWczytaj";
            this.ButtonWczytaj.Size = new System.Drawing.Size(75, 23);
            this.ButtonWczytaj.TabIndex = 0;
            this.ButtonWczytaj.Text = "Wczytaj";
            this.ButtonWczytaj.UseVisualStyleBackColor = true;
            // 
            // ButtonZapisz
            // 
            this.ButtonZapisz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonZapisz.Location = new System.Drawing.Point(23, 507);
            this.ButtonZapisz.Name = "ButtonZapisz";
            this.ButtonZapisz.Size = new System.Drawing.Size(75, 23);
            this.ButtonZapisz.TabIndex = 1;
            this.ButtonZapisz.Text = "Zapisz";
            this.ButtonZapisz.UseVisualStyleBackColor = true;
            // 
            // TrackBarRozmiar
            // 
            this.TrackBarRozmiar.Location = new System.Drawing.Point(23, 81);
            this.TrackBarRozmiar.Maximum = 100;
            this.TrackBarRozmiar.Minimum = 1;
            this.TrackBarRozmiar.Name = "TrackBarRozmiar";
            this.TrackBarRozmiar.Size = new System.Drawing.Size(104, 45);
            this.TrackBarRozmiar.TabIndex = 2;
            this.TrackBarRozmiar.Value = 5;
            this.TrackBarRozmiar.Scroll += new System.EventHandler(this.TrackBarRozmiar_Scroll);
            // 
            // ButtonKolor
            // 
            this.ButtonKolor.Location = new System.Drawing.Point(23, 23);
            this.ButtonKolor.Name = "ButtonKolor";
            this.ButtonKolor.Size = new System.Drawing.Size(104, 24);
            this.ButtonKolor.TabIndex = 3;
            this.ButtonKolor.Text = "Zmina Koloru";
            this.ButtonKolor.UseVisualStyleBackColor = true;
            this.ButtonKolor.Click += new System.EventHandler(this.ButtonKolor_Click);
            // 
            // LabelRozmiar
            // 
            this.LabelRozmiar.AutoSize = true;
            this.LabelRozmiar.Location = new System.Drawing.Point(133, 81);
            this.LabelRozmiar.Name = "LabelRozmiar";
            this.LabelRozmiar.Size = new System.Drawing.Size(13, 13);
            this.LabelRozmiar.TabIndex = 4;
            this.LabelRozmiar.Text = "5";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox.Location = new System.Drawing.Point(94, 9);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(30, 30, 100, 30);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1500, 1000);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "saveFileDialog";
            // 
            // panelPrzyrzadow
            // 
            this.panelPrzyrzadow.BackColor = System.Drawing.Color.Silver;
            this.panelPrzyrzadow.Controls.Add(this.KolorowyKwadrat);
            this.panelPrzyrzadow.Controls.Add(this.ButtonWczytaj);
            this.panelPrzyrzadow.Controls.Add(this.ButtonZapisz);
            this.panelPrzyrzadow.Controls.Add(this.LabelRozmiar);
            this.panelPrzyrzadow.Controls.Add(this.ButtonKolor);
            this.panelPrzyrzadow.Controls.Add(this.TrackBarRozmiar);
            this.panelPrzyrzadow.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPrzyrzadow.Location = new System.Drawing.Point(967, 0);
            this.panelPrzyrzadow.Margin = new System.Windows.Forms.Padding(0);
            this.panelPrzyrzadow.Name = "panelPrzyrzadow";
            this.panelPrzyrzadow.Padding = new System.Windows.Forms.Padding(20);
            this.panelPrzyrzadow.Size = new System.Drawing.Size(214, 569);
            this.panelPrzyrzadow.TabIndex = 6;
            // 
            // KolorowyKwadrat
            // 
            this.KolorowyKwadrat.BackColor = System.Drawing.Color.Black;
            this.KolorowyKwadrat.Location = new System.Drawing.Point(136, 23);
            this.KolorowyKwadrat.Name = "KolorowyKwadrat";
            this.KolorowyKwadrat.Size = new System.Drawing.Size(23, 24);
            this.KolorowyKwadrat.TabIndex = 7;
            // 
            // FormEdytoraGraficznego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1181, 569);
            this.Controls.Add(this.panelPrzyrzadow);
            this.Controls.Add(this.pictureBox);
            this.Name = "FormEdytoraGraficznego";
            this.Text = "Edytor Graficzny";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRozmiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelPrzyrzadow.ResumeLayout(false);
            this.panelPrzyrzadow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar TrackBarRozmiar;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button ButtonKolor;
        private System.Windows.Forms.Label LabelRozmiar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        public System.Windows.Forms.Button ButtonWczytaj;
        public System.Windows.Forms.Button ButtonZapisz;
        public System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panelPrzyrzadow;
        private System.Windows.Forms.Panel KolorowyKwadrat;
    }
}

