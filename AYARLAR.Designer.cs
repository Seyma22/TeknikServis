namespace TeknikServis
{
    partial class AYARLAR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AYARLAR));
            this.btnFirmalar = new System.Windows.Forms.Button();
            this.btnDonanimTurleri = new System.Windows.Forms.Button();
            this.btnLisansTipleri = new System.Windows.Forms.Button();
            this.btnTeknikServisFirmalari = new System.Windows.Forms.Button();
            this.btnGonderimSekilleri = new System.Windows.Forms.Button();
            this.btnServisSekilleri = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvGenel = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnUyeler = new System.Windows.Forms.Button();
            this.btnYedekle = new System.Windows.Forms.Button();
            this.btnYedekYukle = new System.Windows.Forms.Button();
            this.gbYedek = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bgw2 = new System.ComponentModel.BackgroundWorker();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ls = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenel)).BeginInit();
            this.gbYedek.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFirmalar
            // 
            this.btnFirmalar.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmalar.Image")));
            this.btnFirmalar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFirmalar.Location = new System.Drawing.Point(12, 108);
            this.btnFirmalar.Name = "btnFirmalar";
            this.btnFirmalar.Size = new System.Drawing.Size(193, 38);
            this.btnFirmalar.TabIndex = 2;
            this.btnFirmalar.Text = "FİRMALAR";
            this.btnFirmalar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirmalar.UseVisualStyleBackColor = true;
            this.btnFirmalar.Click += new System.EventHandler(this.btnFirmalar_Click);
            // 
            // btnDonanimTurleri
            // 
            this.btnDonanimTurleri.Image = ((System.Drawing.Image)(resources.GetObject("btnDonanimTurleri.Image")));
            this.btnDonanimTurleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonanimTurleri.Location = new System.Drawing.Point(12, 152);
            this.btnDonanimTurleri.Name = "btnDonanimTurleri";
            this.btnDonanimTurleri.Size = new System.Drawing.Size(193, 38);
            this.btnDonanimTurleri.TabIndex = 3;
            this.btnDonanimTurleri.Text = "DONANIM TÜRLERİ";
            this.btnDonanimTurleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDonanimTurleri.UseVisualStyleBackColor = true;
            this.btnDonanimTurleri.Click += new System.EventHandler(this.btnFirmalar_Click);
            // 
            // btnLisansTipleri
            // 
            this.btnLisansTipleri.Image = ((System.Drawing.Image)(resources.GetObject("btnLisansTipleri.Image")));
            this.btnLisansTipleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLisansTipleri.Location = new System.Drawing.Point(12, 196);
            this.btnLisansTipleri.Name = "btnLisansTipleri";
            this.btnLisansTipleri.Size = new System.Drawing.Size(193, 38);
            this.btnLisansTipleri.TabIndex = 4;
            this.btnLisansTipleri.Text = "LİSANS TİPLERİ";
            this.btnLisansTipleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLisansTipleri.UseVisualStyleBackColor = true;
            this.btnLisansTipleri.Click += new System.EventHandler(this.btnFirmalar_Click);
            // 
            // btnTeknikServisFirmalari
            // 
            this.btnTeknikServisFirmalari.Image = ((System.Drawing.Image)(resources.GetObject("btnTeknikServisFirmalari.Image")));
            this.btnTeknikServisFirmalari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeknikServisFirmalari.Location = new System.Drawing.Point(12, 240);
            this.btnTeknikServisFirmalari.Name = "btnTeknikServisFirmalari";
            this.btnTeknikServisFirmalari.Size = new System.Drawing.Size(193, 38);
            this.btnTeknikServisFirmalari.TabIndex = 5;
            this.btnTeknikServisFirmalari.Text = "TEKNİK SERVİS FİRMALARI";
            this.btnTeknikServisFirmalari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeknikServisFirmalari.UseVisualStyleBackColor = true;
            this.btnTeknikServisFirmalari.Click += new System.EventHandler(this.btnFirmalar_Click);
            // 
            // btnGonderimSekilleri
            // 
            this.btnGonderimSekilleri.Image = ((System.Drawing.Image)(resources.GetObject("btnGonderimSekilleri.Image")));
            this.btnGonderimSekilleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGonderimSekilleri.Location = new System.Drawing.Point(12, 284);
            this.btnGonderimSekilleri.Name = "btnGonderimSekilleri";
            this.btnGonderimSekilleri.Size = new System.Drawing.Size(193, 38);
            this.btnGonderimSekilleri.TabIndex = 6;
            this.btnGonderimSekilleri.Text = "T. SERVİS GÖND. ŞEKİLLERİ";
            this.btnGonderimSekilleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGonderimSekilleri.UseVisualStyleBackColor = true;
            this.btnGonderimSekilleri.Click += new System.EventHandler(this.btnFirmalar_Click);
            // 
            // btnServisSekilleri
            // 
            this.btnServisSekilleri.Image = ((System.Drawing.Image)(resources.GetObject("btnServisSekilleri.Image")));
            this.btnServisSekilleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServisSekilleri.Location = new System.Drawing.Point(12, 328);
            this.btnServisSekilleri.Name = "btnServisSekilleri";
            this.btnServisSekilleri.Size = new System.Drawing.Size(193, 38);
            this.btnServisSekilleri.TabIndex = 7;
            this.btnServisSekilleri.Text = "SERVİS ŞEKİLLERİ";
            this.btnServisSekilleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServisSekilleri.UseVisualStyleBackColor = true;
            this.btnServisSekilleri.Click += new System.EventHandler(this.btnFirmalar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.dgvGenel);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnYeni);
            this.groupBox1.Location = new System.Drawing.Point(235, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 380);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(243, 336);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(64, 38);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgvGenel
            // 
            this.dgvGenel.AllowUserToAddRows = false;
            this.dgvGenel.AllowUserToDeleteRows = false;
            this.dgvGenel.AllowUserToResizeRows = false;
            this.dgvGenel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGenel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGenel.BackgroundColor = System.Drawing.Color.White;
            this.dgvGenel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGenel.Location = new System.Drawing.Point(6, 12);
            this.dgvGenel.MultiSelect = false;
            this.dgvGenel.Name = "dgvGenel";
            this.dgvGenel.RowHeadersVisible = false;
            this.dgvGenel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGenel.Size = new System.Drawing.Size(441, 297);
            this.dgvGenel.TabIndex = 0;
            this.dgvGenel.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGenel_CellMouseClick);
            this.dgvGenel.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvGenel_DataBindingComplete);
            this.dgvGenel.DoubleClick += new System.EventHandler(this.dgvGenel_DoubleClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(313, 336);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(64, 38);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Enabled = false;
            this.btnYeni.Location = new System.Drawing.Point(383, 336);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(64, 38);
            this.btnYeni.TabIndex = 9;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnUyeler
            // 
            this.btnUyeler.Image = ((System.Drawing.Image)(resources.GetObject("btnUyeler.Image")));
            this.btnUyeler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeler.Location = new System.Drawing.Point(12, 372);
            this.btnUyeler.Name = "btnUyeler";
            this.btnUyeler.Size = new System.Drawing.Size(193, 38);
            this.btnUyeler.TabIndex = 8;
            this.btnUyeler.Text = "ÜYELER (KULLANICILAR)";
            this.btnUyeler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUyeler.UseVisualStyleBackColor = true;
            this.btnUyeler.Click += new System.EventHandler(this.btnFirmalar_Click);
            // 
            // btnYedekle
            // 
            this.btnYedekle.Image = ((System.Drawing.Image)(resources.GetObject("btnYedekle.Image")));
            this.btnYedekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYedekle.Location = new System.Drawing.Point(6, 60);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(105, 38);
            this.btnYedekle.TabIndex = 63;
            this.btnYedekle.Text = "DIŞA AKTAR";
            this.btnYedekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYedekle.UseVisualStyleBackColor = true;
            this.btnYedekle.Click += new System.EventHandler(this.btnYedekle_Click);
            // 
            // btnYedekYukle
            // 
            this.btnYedekYukle.Image = ((System.Drawing.Image)(resources.GetObject("btnYedekYukle.Image")));
            this.btnYedekYukle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYedekYukle.Location = new System.Drawing.Point(6, 16);
            this.btnYedekYukle.Name = "btnYedekYukle";
            this.btnYedekYukle.Size = new System.Drawing.Size(105, 38);
            this.btnYedekYukle.TabIndex = 62;
            this.btnYedekYukle.Text = "İÇE AKTAR";
            this.btnYedekYukle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYedekYukle.UseVisualStyleBackColor = true;
            this.btnYedekYukle.Click += new System.EventHandler(this.btnYedekYukle_Click);
            // 
            // gbYedek
            // 
            this.gbYedek.Controls.Add(this.btnYedekYukle);
            this.gbYedek.Controls.Add(this.btnYedekle);
            this.gbYedek.Location = new System.Drawing.Point(12, 437);
            this.gbYedek.Name = "gbYedek";
            this.gbYedek.Size = new System.Drawing.Size(119, 104);
            this.gbYedek.TabIndex = 63;
            this.gbYedek.TabStop = false;
            this.gbYedek.Text = "Yedek (Back Up)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "BİLGİ İŞLEM GENEL AYARLAR, GÜNCELLEMELER VE YEDEK İŞLEMLERİ";
            // 
            // bgw
            // 
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(18, 547);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(105, 18);
            this.pBar.TabIndex = 65;
            this.pBar.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // bgw2
            // 
            this.bgw2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw2_DoWork);
            this.bgw2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ls});
            this.shapeContainer1.Size = new System.Drawing.Size(700, 613);
            this.shapeContainer1.TabIndex = 66;
            this.shapeContainer1.TabStop = false;
            // 
            // ls
            // 
            this.ls.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.ls.BorderWidth = 3;
            this.ls.Name = "ls";
            this.ls.Visible = false;
            this.ls.X1 = 246;
            this.ls.X2 = 266;
            this.ls.Y1 = 15;
            this.ls.Y2 = 15;
            // 
            // AYARLAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 613);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbYedek);
            this.Controls.Add(this.btnUyeler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnServisSekilleri);
            this.Controls.Add(this.btnGonderimSekilleri);
            this.Controls.Add(this.btnTeknikServisFirmalari);
            this.Controls.Add(this.btnLisansTipleri);
            this.Controls.Add(this.btnDonanimTurleri);
            this.Controls.Add(this.btnFirmalar);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AYARLAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AYARLAR";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenel)).EndInit();
            this.gbYedek.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirmalar;
        private System.Windows.Forms.Button btnDonanimTurleri;
        private System.Windows.Forms.Button btnTeknikServisFirmalari;
        private System.Windows.Forms.Button btnGonderimSekilleri;
        private System.Windows.Forms.Button btnServisSekilleri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgvGenel;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnUyeler;
        private System.Windows.Forms.Button btnLisansTipleri;
        private System.Windows.Forms.Button btnYedekle;
        private System.Windows.Forms.Button btnYedekYukle;
        private System.Windows.Forms.GroupBox gbYedek;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.BackgroundWorker bgw2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape ls;
    }
}