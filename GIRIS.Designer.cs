namespace TeknikServis
{
    partial class GIRIS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GIRIS));
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.gbGiris = new System.Windows.Forms.GroupBox();
            this.lblGiris = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msChild = new System.Windows.Forms.MenuStrip();
            this.lblKarsilama = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbOK = new System.Windows.Forms.PictureBox();
            this.pbNO = new System.Windows.Forms.PictureBox();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.gbBaglantiAyar = new System.Windows.Forms.GroupBox();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVeritabani = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.gbGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNO)).BeginInit();
            this.gbBaglantiAyar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(144, 49);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(215, 22);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // gbGiris
            // 
            this.gbGiris.Controls.Add(this.lblGiris);
            this.gbGiris.Controls.Add(this.btnGiris);
            this.gbGiris.Controls.Add(this.label2);
            this.gbGiris.Controls.Add(this.txtSifre);
            this.gbGiris.Controls.Add(this.label1);
            this.gbGiris.Controls.Add(this.txtKullaniciAdi);
            this.gbGiris.Enabled = false;
            this.gbGiris.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbGiris.Location = new System.Drawing.Point(150, 170);
            this.gbGiris.Name = "gbGiris";
            this.gbGiris.Size = new System.Drawing.Size(400, 200);
            this.gbGiris.TabIndex = 1;
            this.gbGiris.TabStop = false;
            this.gbGiris.Text = "Kullanıcı Girişi";
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.ForeColor = System.Drawing.Color.Maroon;
            this.lblGiris.Location = new System.Drawing.Point(33, 139);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(0, 14);
            this.lblGiris.TabIndex = 20;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(293, 129);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(66, 34);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(144, 85);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(215, 22);
            this.txtSifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // msChild
            // 
            this.msChild.Location = new System.Drawing.Point(0, 0);
            this.msChild.Name = "msChild";
            this.msChild.Size = new System.Drawing.Size(700, 24);
            this.msChild.TabIndex = 2;
            this.msChild.Text = "msChild";
            this.msChild.Visible = false;
            // 
            // lblKarsilama
            // 
            this.lblKarsilama.AutoSize = true;
            this.lblKarsilama.ForeColor = System.Drawing.Color.Black;
            this.lblKarsilama.Location = new System.Drawing.Point(148, 145);
            this.lblKarsilama.Name = "lblKarsilama";
            this.lblKarsilama.Size = new System.Drawing.Size(0, 13);
            this.lblKarsilama.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 579);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Server";
            // 
            // pbOK
            // 
            this.pbOK.Image = ((System.Drawing.Image)(resources.GetObject("pbOK.Image")));
            this.pbOK.Location = new System.Drawing.Point(51, 579);
            this.pbOK.Name = "pbOK";
            this.pbOK.Size = new System.Drawing.Size(13, 13);
            this.pbOK.TabIndex = 32;
            this.pbOK.TabStop = false;
            this.pbOK.Visible = false;
            // 
            // pbNO
            // 
            this.pbNO.Image = ((System.Drawing.Image)(resources.GetObject("pbNO.Image")));
            this.pbNO.Location = new System.Drawing.Point(52, 580);
            this.pbNO.Name = "pbNO";
            this.pbNO.Size = new System.Drawing.Size(13, 13);
            this.pbNO.TabIndex = 33;
            this.pbNO.TabStop = false;
            this.pbNO.Visible = false;
            // 
            // bgw
            // 
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // gbBaglantiAyar
            // 
            this.gbBaglantiAyar.Controls.Add(this.btnBaglan);
            this.gbBaglantiAyar.Controls.Add(this.txtIP);
            this.gbBaglantiAyar.Controls.Add(this.label7);
            this.gbBaglantiAyar.Controls.Add(this.txtPass);
            this.gbBaglantiAyar.Controls.Add(this.label6);
            this.gbBaglantiAyar.Controls.Add(this.txtID);
            this.gbBaglantiAyar.Controls.Add(this.label5);
            this.gbBaglantiAyar.Controls.Add(this.txtVeritabani);
            this.gbBaglantiAyar.Controls.Add(this.label4);
            this.gbBaglantiAyar.Location = new System.Drawing.Point(81, 559);
            this.gbBaglantiAyar.Name = "gbBaglantiAyar";
            this.gbBaglantiAyar.Size = new System.Drawing.Size(607, 42);
            this.gbBaglantiAyar.TabIndex = 34;
            this.gbBaglantiAyar.TabStop = false;
            this.gbBaglantiAyar.Visible = false;
            // 
            // btnBaglan
            // 
            this.btnBaglan.Image = ((System.Drawing.Image)(resources.GetObject("btnBaglan.Image")));
            this.btnBaglan.Location = new System.Drawing.Point(573, 11);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(28, 25);
            this.btnBaglan.TabIndex = 35;
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(467, 13);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 4;
            this.txtIP.Text = "10.1.1.52";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "IP";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(338, 13);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.Text = "BOYS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Pass";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(196, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "BOYS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "ID";
            // 
            // txtVeritabani
            // 
            this.txtVeritabani.Location = new System.Drawing.Point(66, 13);
            this.txtVeritabani.Name = "txtVeritabani";
            this.txtVeritabani.Size = new System.Drawing.Size(100, 20);
            this.txtVeritabani.TabIndex = 1;
            this.txtVeritabani.Text = "BilgiIslem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Veritabanı";
            // 
            // timer
            // 
            this.timer.Interval = 800;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(15, 550);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(49, 10);
            this.pBar.TabIndex = 35;
            // 
            // GIRIS
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 613);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.gbBaglantiAyar);
            this.Controls.Add(this.pbNO);
            this.Controls.Add(this.pbOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKarsilama);
            this.Controls.Add(this.gbGiris);
            this.Controls.Add(this.msChild);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.msChild;
            this.Name = "GIRIS";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "33";
            this.Load += new System.EventHandler(this.GIRIS_Load);
            this.gbGiris.ResumeLayout(false);
            this.gbGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNO)).EndInit();
            this.gbBaglantiAyar.ResumeLayout(false);
            this.gbBaglantiAyar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.GroupBox gbGiris;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGiris;
        public System.Windows.Forms.MenuStrip msChild=null;
        private System.Windows.Forms.Label lblKarsilama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbOK;
        private System.Windows.Forms.PictureBox pbNO;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.GroupBox gbBaglantiAyar;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVeritabani;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar pBar;
    }
}