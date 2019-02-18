namespace TeknikServis
{
    partial class TEKNIK_SERVIS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TEKNIK_SERVIS));
            this.cbListelemeTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAyrintiDuzenle = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.dgvTeknikServis = new System.Windows.Forms.DataGridView();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.cbArananServisStunu = new System.Windows.Forms.ComboBox();
            this.txtServisAra = new System.Windows.Forms.TextBox();
            this.lblServisSayisi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeknikServis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbListelemeTuru
            // 
            this.cbListelemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListelemeTuru.FormattingEnabled = true;
            this.cbListelemeTuru.Items.AddRange(new object[] {
            "Servistekiler",
            "Tümü"});
            this.cbListelemeTuru.Location = new System.Drawing.Point(613, 21);
            this.cbListelemeTuru.Name = "cbListelemeTuru";
            this.cbListelemeTuru.Size = new System.Drawing.Size(84, 21);
            this.cbListelemeTuru.TabIndex = 5;
            this.cbListelemeTuru.SelectedIndexChanged += new System.EventHandler(this.cbListelemeTuru_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listeleme Türü:";
            // 
            // btnSil
            // 
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.Location = new System.Drawing.Point(529, 561);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(49, 40);
            this.btnSil.TabIndex = 3;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAyrintiDuzenle
            // 
            this.btnAyrintiDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyrintiDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnAyrintiDuzenle.Image")));
            this.btnAyrintiDuzenle.Location = new System.Drawing.Point(584, 561);
            this.btnAyrintiDuzenle.Name = "btnAyrintiDuzenle";
            this.btnAyrintiDuzenle.Size = new System.Drawing.Size(49, 40);
            this.btnAyrintiDuzenle.TabIndex = 2;
            this.btnAyrintiDuzenle.UseVisualStyleBackColor = true;
            this.btnAyrintiDuzenle.Click += new System.EventHandler(this.btnAyrintiDuzenle_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Enabled = false;
            this.btnYeniKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniKayit.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniKayit.Image")));
            this.btnYeniKayit.Location = new System.Drawing.Point(639, 561);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(49, 40);
            this.btnYeniKayit.TabIndex = 1;
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // dgvTeknikServis
            // 
            this.dgvTeknikServis.AllowUserToAddRows = false;
            this.dgvTeknikServis.AllowUserToDeleteRows = false;
            this.dgvTeknikServis.AllowUserToResizeRows = false;
            this.dgvTeknikServis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeknikServis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTeknikServis.BackgroundColor = System.Drawing.Color.White;
            this.dgvTeknikServis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTeknikServis.ColumnHeadersHeight = 34;
            this.dgvTeknikServis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTeknikServis.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTeknikServis.Location = new System.Drawing.Point(3, 69);
            this.dgvTeknikServis.MultiSelect = false;
            this.dgvTeknikServis.Name = "dgvTeknikServis";
            this.dgvTeknikServis.ReadOnly = true;
            this.dgvTeknikServis.RowHeadersVisible = false;
            this.dgvTeknikServis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeknikServis.Size = new System.Drawing.Size(694, 475);
            this.dgvTeknikServis.TabIndex = 26;
            this.dgvTeknikServis.Visible = false;
            this.dgvTeknikServis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeknikServis_CellDoubleClick);
            this.dgvTeknikServis.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTeknikServis_CellMouseClick);
            this.dgvTeknikServis.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTeknikServis_DataBindingComplete);
            // 
            // bgw
            // 
            this.bgw.WorkerReportsProgress = true;
            this.bgw.WorkerSupportsCancellation = true;
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            // 
            // cbArananServisStunu
            // 
            this.cbArananServisStunu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbArananServisStunu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbArananServisStunu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArananServisStunu.FormattingEnabled = true;
            this.cbArananServisStunu.Location = new System.Drawing.Point(3, 21);
            this.cbArananServisStunu.Name = "cbArananServisStunu";
            this.cbArananServisStunu.Size = new System.Drawing.Size(156, 21);
            this.cbArananServisStunu.TabIndex = 27;
            // 
            // txtServisAra
            // 
            this.txtServisAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtServisAra.Location = new System.Drawing.Point(165, 22);
            this.txtServisAra.Name = "txtServisAra";
            this.txtServisAra.Size = new System.Drawing.Size(200, 20);
            this.txtServisAra.TabIndex = 28;
            this.txtServisAra.Text = "Ara...";
            this.txtServisAra.TextChanged += new System.EventHandler(this.txtServisAra_TextChanged);
            this.txtServisAra.Enter += new System.EventHandler(this.txtServisAra_Enter);
            this.txtServisAra.Leave += new System.EventHandler(this.txtServisAra_Leave);
            // 
            // lblServisSayisi
            // 
            this.lblServisSayisi.AutoSize = true;
            this.lblServisSayisi.Location = new System.Drawing.Point(46, 581);
            this.lblServisSayisi.Name = "lblServisSayisi";
            this.lblServisSayisi.Size = new System.Drawing.Size(0, 13);
            this.lblServisSayisi.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 571);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // TEKNIK_SERVIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 613);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblServisSayisi);
            this.Controls.Add(this.cbArananServisStunu);
            this.Controls.Add(this.txtServisAra);
            this.Controls.Add(this.dgvTeknikServis);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAyrintiDuzenle);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.cbListelemeTuru);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TEKNIK_SERVIS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TEKNIK_SERVIS";
            this.Load += new System.EventHandler(this.TEKNIK_SERVIS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeknikServis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbListelemeTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnAyrintiDuzenle;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.DataGridView dgvTeknikServis;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.ComboBox cbArananServisStunu;
        private System.Windows.Forms.TextBox txtServisAra;
        private System.Windows.Forms.Label lblServisSayisi;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}