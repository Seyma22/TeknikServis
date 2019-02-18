namespace TeknikServis
{
    partial class YENI_LISANS
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
            this.txtLisansAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLisansNumarasi = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLisansSayisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLisansTipi = new System.Windows.Forms.ComboBox();
            this.cbYazilimTipi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtLisansAdi
            // 
            this.txtLisansAdi.Location = new System.Drawing.Point(124, 47);
            this.txtLisansAdi.Name = "txtLisansAdi";
            this.txtLisansAdi.Size = new System.Drawing.Size(329, 20);
            this.txtLisansAdi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Lisans Adı";
            // 
            // btnVazgec
            // 
            this.btnVazgec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVazgec.Location = new System.Drawing.Point(297, 234);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(75, 39);
            this.btnVazgec.TabIndex = 8;
            this.btnVazgec.Text = "VAZGEÇ";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(378, 234);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 39);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Lisans Numarası";
            // 
            // txtLisansNumarasi
            // 
            this.txtLisansNumarasi.Location = new System.Drawing.Point(124, 11);
            this.txtLisansNumarasi.Name = "txtLisansNumarasi";
            this.txtLisansNumarasi.Size = new System.Drawing.Size(329, 20);
            this.txtLisansNumarasi.TabIndex = 1;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(124, 83);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(329, 20);
            this.txtKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Key";
            // 
            // txtLisansSayisi
            // 
            this.txtLisansSayisi.Location = new System.Drawing.Point(124, 119);
            this.txtLisansSayisi.Name = "txtLisansSayisi";
            this.txtLisansSayisi.Size = new System.Drawing.Size(127, 20);
            this.txtLisansSayisi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Lisans Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Yazılım Tipi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Lisans Tipi";
            // 
            // cbLisansTipi
            // 
            this.cbLisansTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLisansTipi.Location = new System.Drawing.Point(124, 155);
            this.cbLisansTipi.MaxDropDownItems = 20;
            this.cbLisansTipi.Name = "cbLisansTipi";
            this.cbLisansTipi.Size = new System.Drawing.Size(127, 21);
            this.cbLisansTipi.TabIndex = 5;
            // 
            // cbYazilimTipi
            // 
            this.cbYazilimTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYazilimTipi.Location = new System.Drawing.Point(124, 191);
            this.cbYazilimTipi.MaxDropDownItems = 20;
            this.cbYazilimTipi.Name = "cbYazilimTipi";
            this.cbYazilimTipi.Size = new System.Drawing.Size(127, 21);
            this.cbYazilimTipi.TabIndex = 6;
            // 
            // YENI_LISANS
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVazgec;
            this.ClientSize = new System.Drawing.Size(465, 285);
            this.Controls.Add(this.cbYazilimTipi);
            this.Controls.Add(this.cbLisansTipi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLisansSayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLisansAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtLisansNumarasi);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YENI_LISANS";
            this.ShowInTaskbar = false;
            this.Text = "Yeni Lisans";
            this.Load += new System.EventHandler(this.YENI_LISANS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLisansAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLisansNumarasi;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLisansSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLisansTipi;
        private System.Windows.Forms.ComboBox cbYazilimTipi;
    }
}