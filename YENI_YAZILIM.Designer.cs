namespace TeknikServis
{
    partial class YENI_YAZILIM
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
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dtpGuncellemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtYazilimAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLisansSayisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVazgec
            // 
            this.btnVazgec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVazgec.Location = new System.Drawing.Point(148, 124);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(75, 39);
            this.btnVazgec.TabIndex = 5;
            this.btnVazgec.Text = "VAZGEÇ";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKaydet.Location = new System.Drawing.Point(229, 124);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 39);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dtpGuncellemeTarihi
            // 
            this.dtpGuncellemeTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGuncellemeTarihi.Location = new System.Drawing.Point(120, 89);
            this.dtpGuncellemeTarihi.Name = "dtpGuncellemeTarihi";
            this.dtpGuncellemeTarihi.Size = new System.Drawing.Size(110, 20);
            this.dtpGuncellemeTarihi.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Güncelleme Tarihi";
            // 
            // txtYazilimAdi
            // 
            this.txtYazilimAdi.Location = new System.Drawing.Point(120, 17);
            this.txtYazilimAdi.Name = "txtYazilimAdi";
            this.txtYazilimAdi.Size = new System.Drawing.Size(184, 20);
            this.txtYazilimAdi.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Yazılım Adı";
            // 
            // txtLisansSayisi
            // 
            this.txtLisansSayisi.Location = new System.Drawing.Point(120, 53);
            this.txtLisansSayisi.Name = "txtLisansSayisi";
            this.txtLisansSayisi.Size = new System.Drawing.Size(87, 20);
            this.txtLisansSayisi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Lisans Sayısı";
            // 
            // YENI_YAZILIM
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVazgec;
            this.ClientSize = new System.Drawing.Size(321, 176);
            this.Controls.Add(this.txtLisansSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtpGuncellemeTarihi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtYazilimAdi);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YENI_YAZILIM";
            this.ShowInTaskbar = false;
            this.Text = "Yeni Yazılım";
            this.Load += new System.EventHandler(this.YENI_YAZILIM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DateTimePicker dtpGuncellemeTarihi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtYazilimAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLisansSayisi;
        private System.Windows.Forms.Label label1;
    }
}