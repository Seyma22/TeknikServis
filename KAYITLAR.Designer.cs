namespace TeknikServis
{
    partial class KAYITLAR
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KAYITLAR));
            this.tc = new System.Windows.Forms.TabControl();
            this.tpKullanicilar = new System.Windows.Forms.TabPage();
            this.lblKullaniciSayisi = new System.Windows.Forms.Label();
            this.cbArananKullaniciStunu = new System.Windows.Forms.ComboBox();
            this.txtKullaniciAra = new System.Windows.Forms.TextBox();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            this.btnAyrintiDuzenle = new System.Windows.Forms.Button();
            this.btnYeniKisi = new System.Windows.Forms.Button();
            this.dgvKullanici = new System.Windows.Forms.DataGridView();
            this.tpDonanim = new System.Windows.Forms.TabPage();
            this.lblDonanimSayisi = new System.Windows.Forms.Label();
            this.cbArananDonanimStunu = new System.Windows.Forms.ComboBox();
            this.txtDonanimAra = new System.Windows.Forms.TextBox();
            this.btnDonanimSil = new System.Windows.Forms.Button();
            this.btnYeniDonanim = new System.Windows.Forms.Button();
            this.btnDonanimAyrintiDuzenle = new System.Windows.Forms.Button();
            this.dgvDonanim = new System.Windows.Forms.DataGridView();
            this.tpYazilim = new System.Windows.Forms.TabPage();
            this.lblYazilimSayisi = new System.Windows.Forms.Label();
            this.cbArananYazilimStunu = new System.Windows.Forms.ComboBox();
            this.txtYazilimAra = new System.Windows.Forms.TextBox();
            this.btnYazilimSil = new System.Windows.Forms.Button();
            this.btnYeniYazilim = new System.Windows.Forms.Button();
            this.btnYazilimAyrintiDuzenle = new System.Windows.Forms.Button();
            this.dgvYazilim = new System.Windows.Forms.DataGridView();
            this.tpLisans = new System.Windows.Forms.TabPage();
            this.lblLisansSayisi = new System.Windows.Forms.Label();
            this.cbArananLisansStunu = new System.Windows.Forms.ComboBox();
            this.txtLisansAra = new System.Windows.Forms.TextBox();
            this.btnLisansSil = new System.Windows.Forms.Button();
            this.btnYeniLisans = new System.Windows.Forms.Button();
            this.btnLisansAyrintiDuzenle = new System.Windows.Forms.Button();
            this.dgvLisans = new System.Windows.Forms.DataGridView();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pb = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tc.SuspendLayout();
            this.tpKullanicilar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanici)).BeginInit();
            this.tpDonanim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonanim)).BeginInit();
            this.tpYazilim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYazilim)).BeginInit();
            this.tpLisans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLisans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tpKullanicilar);
            this.tc.Controls.Add(this.tpDonanim);
            this.tc.Controls.Add(this.tpYazilim);
            this.tc.Controls.Add(this.tpLisans);
            this.tc.ItemSize = new System.Drawing.Size(96, 30);
            this.tc.Location = new System.Drawing.Point(0, 0);
            this.tc.Name = "tc";
            this.tc.Padding = new System.Drawing.Point(0, 0);
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(705, 618);
            this.tc.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc.TabIndex = 0;
            // 
            // tpKullanicilar
            // 
            this.tpKullanicilar.Controls.Add(this.pb);
            this.tpKullanicilar.Controls.Add(this.lblKullaniciSayisi);
            this.tpKullanicilar.Controls.Add(this.cbArananKullaniciStunu);
            this.tpKullanicilar.Controls.Add(this.txtKullaniciAra);
            this.tpKullanicilar.Controls.Add(this.btnKullaniciSil);
            this.tpKullanicilar.Controls.Add(this.btnAyrintiDuzenle);
            this.tpKullanicilar.Controls.Add(this.btnYeniKisi);
            this.tpKullanicilar.Controls.Add(this.dgvKullanici);
            this.tpKullanicilar.Location = new System.Drawing.Point(4, 34);
            this.tpKullanicilar.Name = "tpKullanicilar";
            this.tpKullanicilar.Padding = new System.Windows.Forms.Padding(3);
            this.tpKullanicilar.Size = new System.Drawing.Size(697, 580);
            this.tpKullanicilar.TabIndex = 0;
            this.tpKullanicilar.Text = "KULLANICI";
            this.tpKullanicilar.UseVisualStyleBackColor = true;
            // 
            // lblKullaniciSayisi
            // 
            this.lblKullaniciSayisi.AutoSize = true;
            this.lblKullaniciSayisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKullaniciSayisi.Location = new System.Drawing.Point(42, 547);
            this.lblKullaniciSayisi.Name = "lblKullaniciSayisi";
            this.lblKullaniciSayisi.Size = new System.Drawing.Size(0, 13);
            this.lblKullaniciSayisi.TabIndex = 8;
            // 
            // cbArananKullaniciStunu
            // 
            this.cbArananKullaniciStunu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbArananKullaniciStunu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbArananKullaniciStunu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArananKullaniciStunu.FormattingEnabled = true;
            this.cbArananKullaniciStunu.Location = new System.Drawing.Point(1, 8);
            this.cbArananKullaniciStunu.Name = "cbArananKullaniciStunu";
            this.cbArananKullaniciStunu.Size = new System.Drawing.Size(156, 21);
            this.cbArananKullaniciStunu.TabIndex = 7;
            // 
            // txtKullaniciAra
            // 
            this.txtKullaniciAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAra.Location = new System.Drawing.Point(163, 9);
            this.txtKullaniciAra.Name = "txtKullaniciAra";
            this.txtKullaniciAra.Size = new System.Drawing.Size(200, 20);
            this.txtKullaniciAra.TabIndex = 8;
            this.txtKullaniciAra.Text = "Ara...";
            this.txtKullaniciAra.TextChanged += new System.EventHandler(this.txtKullaniciAra_TextChanged);
            this.txtKullaniciAra.Enter += new System.EventHandler(this.txtKullaniciAra_Enter);
            this.txtKullaniciAra.Leave += new System.EventHandler(this.txtKullaniciAra_Leave);
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Enabled = false;
            this.btnKullaniciSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciSil.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciSil.Image")));
            this.btnKullaniciSil.Location = new System.Drawing.Point(525, 527);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(49, 40);
            this.btnKullaniciSil.TabIndex = 3;
            this.btnKullaniciSil.UseVisualStyleBackColor = true;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // btnAyrintiDuzenle
            // 
            this.btnAyrintiDuzenle.Enabled = false;
            this.btnAyrintiDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyrintiDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnAyrintiDuzenle.Image")));
            this.btnAyrintiDuzenle.Location = new System.Drawing.Point(580, 527);
            this.btnAyrintiDuzenle.Name = "btnAyrintiDuzenle";
            this.btnAyrintiDuzenle.Size = new System.Drawing.Size(49, 40);
            this.btnAyrintiDuzenle.TabIndex = 2;
            this.btnAyrintiDuzenle.UseVisualStyleBackColor = true;
            this.btnAyrintiDuzenle.Click += new System.EventHandler(this.btnAyrintiDuzenle_Click);
            // 
            // btnYeniKisi
            // 
            this.btnYeniKisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnYeniKisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniKisi.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniKisi.Image")));
            this.btnYeniKisi.Location = new System.Drawing.Point(635, 527);
            this.btnYeniKisi.Name = "btnYeniKisi";
            this.btnYeniKisi.Size = new System.Drawing.Size(49, 40);
            this.btnYeniKisi.TabIndex = 1;
            this.btnYeniKisi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeniKisi.UseVisualStyleBackColor = true;
            this.btnYeniKisi.Click += new System.EventHandler(this.btnYeniKisi_Click);
            // 
            // dgvKullanici
            // 
            this.dgvKullanici.AllowUserToAddRows = false;
            this.dgvKullanici.AllowUserToDeleteRows = false;
            this.dgvKullanici.AllowUserToResizeRows = false;
            this.dgvKullanici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKullanici.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKullanici.BackgroundColor = System.Drawing.Color.White;
            this.dgvKullanici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKullanici.ColumnHeadersHeight = 34;
            this.dgvKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKullanici.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvKullanici.Location = new System.Drawing.Point(0, 35);
            this.dgvKullanici.MultiSelect = false;
            this.dgvKullanici.Name = "dgvKullanici";
            this.dgvKullanici.ReadOnly = true;
            this.dgvKullanici.RowHeadersVisible = false;
            this.dgvKullanici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKullanici.Size = new System.Drawing.Size(694, 475);
            this.dgvKullanici.TabIndex = 25;
            this.dgvKullanici.Visible = false;
            this.dgvKullanici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKullanici_CellDoubleClick);
            this.dgvKullanici.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKullanici_CellMouseClick);
            this.dgvKullanici.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvLisans_DataBindingComplete);
            // 
            // tpDonanim
            // 
            this.tpDonanim.Controls.Add(this.pictureBox1);
            this.tpDonanim.Controls.Add(this.lblDonanimSayisi);
            this.tpDonanim.Controls.Add(this.cbArananDonanimStunu);
            this.tpDonanim.Controls.Add(this.txtDonanimAra);
            this.tpDonanim.Controls.Add(this.btnDonanimSil);
            this.tpDonanim.Controls.Add(this.btnYeniDonanim);
            this.tpDonanim.Controls.Add(this.btnDonanimAyrintiDuzenle);
            this.tpDonanim.Controls.Add(this.dgvDonanim);
            this.tpDonanim.Location = new System.Drawing.Point(4, 34);
            this.tpDonanim.Name = "tpDonanim";
            this.tpDonanim.Padding = new System.Windows.Forms.Padding(3);
            this.tpDonanim.Size = new System.Drawing.Size(697, 580);
            this.tpDonanim.TabIndex = 1;
            this.tpDonanim.Text = "DONANIM";
            this.tpDonanim.UseVisualStyleBackColor = true;
            this.tpDonanim.Enter += new System.EventHandler(this.tpDonanim_Enter);
            // 
            // lblDonanimSayisi
            // 
            this.lblDonanimSayisi.AutoSize = true;
            this.lblDonanimSayisi.Location = new System.Drawing.Point(42, 547);
            this.lblDonanimSayisi.Name = "lblDonanimSayisi";
            this.lblDonanimSayisi.Size = new System.Drawing.Size(66, 13);
            this.lblDonanimSayisi.TabIndex = 8;
            this.lblDonanimSayisi.Text = "Kayıt Sayısı :";
            // 
            // cbArananDonanimStunu
            // 
            this.cbArananDonanimStunu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbArananDonanimStunu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbArananDonanimStunu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArananDonanimStunu.FormattingEnabled = true;
            this.cbArananDonanimStunu.Location = new System.Drawing.Point(1, 8);
            this.cbArananDonanimStunu.Name = "cbArananDonanimStunu";
            this.cbArananDonanimStunu.Size = new System.Drawing.Size(156, 21);
            this.cbArananDonanimStunu.TabIndex = 7;
            // 
            // txtDonanimAra
            // 
            this.txtDonanimAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDonanimAra.Location = new System.Drawing.Point(163, 9);
            this.txtDonanimAra.Name = "txtDonanimAra";
            this.txtDonanimAra.Size = new System.Drawing.Size(200, 20);
            this.txtDonanimAra.TabIndex = 8;
            this.txtDonanimAra.Text = "Ara...";
            this.txtDonanimAra.TextChanged += new System.EventHandler(this.txtKullaniciAra_TextChanged);
            this.txtDonanimAra.Enter += new System.EventHandler(this.txtKullaniciAra_Enter);
            this.txtDonanimAra.Leave += new System.EventHandler(this.txtKullaniciAra_Leave);
            // 
            // btnDonanimSil
            // 
            this.btnDonanimSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonanimSil.Image = ((System.Drawing.Image)(resources.GetObject("btnDonanimSil.Image")));
            this.btnDonanimSil.Location = new System.Drawing.Point(525, 527);
            this.btnDonanimSil.Name = "btnDonanimSil";
            this.btnDonanimSil.Size = new System.Drawing.Size(49, 40);
            this.btnDonanimSil.TabIndex = 3;
            this.btnDonanimSil.UseVisualStyleBackColor = true;
            this.btnDonanimSil.Click += new System.EventHandler(this.btnDonanimSil_Click);
            // 
            // btnYeniDonanim
            // 
            this.btnYeniDonanim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniDonanim.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniDonanim.Image")));
            this.btnYeniDonanim.Location = new System.Drawing.Point(635, 527);
            this.btnYeniDonanim.Name = "btnYeniDonanim";
            this.btnYeniDonanim.Size = new System.Drawing.Size(49, 40);
            this.btnYeniDonanim.TabIndex = 1;
            this.btnYeniDonanim.UseVisualStyleBackColor = true;
            this.btnYeniDonanim.Click += new System.EventHandler(this.btnYeniDonanim_Click);
            // 
            // btnDonanimAyrintiDuzenle
            // 
            this.btnDonanimAyrintiDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonanimAyrintiDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnDonanimAyrintiDuzenle.Image")));
            this.btnDonanimAyrintiDuzenle.Location = new System.Drawing.Point(580, 527);
            this.btnDonanimAyrintiDuzenle.Name = "btnDonanimAyrintiDuzenle";
            this.btnDonanimAyrintiDuzenle.Size = new System.Drawing.Size(49, 40);
            this.btnDonanimAyrintiDuzenle.TabIndex = 2;
            this.btnDonanimAyrintiDuzenle.UseVisualStyleBackColor = true;
            this.btnDonanimAyrintiDuzenle.Click += new System.EventHandler(this.btnDonanimAyrintiDuzenle_Click);
            // 
            // dgvDonanim
            // 
            this.dgvDonanim.AllowUserToAddRows = false;
            this.dgvDonanim.AllowUserToDeleteRows = false;
            this.dgvDonanim.AllowUserToResizeRows = false;
            this.dgvDonanim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonanim.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDonanim.BackgroundColor = System.Drawing.Color.White;
            this.dgvDonanim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDonanim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonanim.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDonanim.Location = new System.Drawing.Point(0, 35);
            this.dgvDonanim.MultiSelect = false;
            this.dgvDonanim.Name = "dgvDonanim";
            this.dgvDonanim.RowHeadersVisible = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonanim.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonanim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonanim.Size = new System.Drawing.Size(694, 475);
            this.dgvDonanim.TabIndex = 25;
            this.dgvDonanim.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonanim_CellDoubleClick);
            this.dgvDonanim.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDonanim_CellMouseClick);
            this.dgvDonanim.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvLisans_DataBindingComplete);
            // 
            // tpYazilim
            // 
            this.tpYazilim.Controls.Add(this.pictureBox2);
            this.tpYazilim.Controls.Add(this.lblYazilimSayisi);
            this.tpYazilim.Controls.Add(this.cbArananYazilimStunu);
            this.tpYazilim.Controls.Add(this.txtYazilimAra);
            this.tpYazilim.Controls.Add(this.btnYazilimSil);
            this.tpYazilim.Controls.Add(this.btnYeniYazilim);
            this.tpYazilim.Controls.Add(this.btnYazilimAyrintiDuzenle);
            this.tpYazilim.Controls.Add(this.dgvYazilim);
            this.tpYazilim.Location = new System.Drawing.Point(4, 34);
            this.tpYazilim.Name = "tpYazilim";
            this.tpYazilim.Padding = new System.Windows.Forms.Padding(3);
            this.tpYazilim.Size = new System.Drawing.Size(697, 580);
            this.tpYazilim.TabIndex = 2;
            this.tpYazilim.Text = "YAZILIM";
            this.tpYazilim.UseVisualStyleBackColor = true;
            this.tpYazilim.Enter += new System.EventHandler(this.tpYazilim_Enter);
            // 
            // lblYazilimSayisi
            // 
            this.lblYazilimSayisi.AutoSize = true;
            this.lblYazilimSayisi.Location = new System.Drawing.Point(42, 547);
            this.lblYazilimSayisi.Name = "lblYazilimSayisi";
            this.lblYazilimSayisi.Size = new System.Drawing.Size(66, 13);
            this.lblYazilimSayisi.TabIndex = 7;
            this.lblYazilimSayisi.Text = "Kayıt Sayısı :";
            // 
            // cbArananYazilimStunu
            // 
            this.cbArananYazilimStunu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbArananYazilimStunu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbArananYazilimStunu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArananYazilimStunu.FormattingEnabled = true;
            this.cbArananYazilimStunu.Location = new System.Drawing.Point(1, 8);
            this.cbArananYazilimStunu.Name = "cbArananYazilimStunu";
            this.cbArananYazilimStunu.Size = new System.Drawing.Size(156, 21);
            this.cbArananYazilimStunu.TabIndex = 6;
            // 
            // txtYazilimAra
            // 
            this.txtYazilimAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazilimAra.Location = new System.Drawing.Point(163, 9);
            this.txtYazilimAra.Name = "txtYazilimAra";
            this.txtYazilimAra.Size = new System.Drawing.Size(200, 20);
            this.txtYazilimAra.TabIndex = 7;
            this.txtYazilimAra.Text = "Ara...";
            this.txtYazilimAra.TextChanged += new System.EventHandler(this.txtKullaniciAra_TextChanged);
            this.txtYazilimAra.Enter += new System.EventHandler(this.txtKullaniciAra_Enter);
            this.txtYazilimAra.Leave += new System.EventHandler(this.txtKullaniciAra_Leave);
            // 
            // btnYazilimSil
            // 
            this.btnYazilimSil.Enabled = false;
            this.btnYazilimSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazilimSil.Image = ((System.Drawing.Image)(resources.GetObject("btnYazilimSil.Image")));
            this.btnYazilimSil.Location = new System.Drawing.Point(525, 527);
            this.btnYazilimSil.Name = "btnYazilimSil";
            this.btnYazilimSil.Size = new System.Drawing.Size(49, 40);
            this.btnYazilimSil.TabIndex = 3;
            this.btnYazilimSil.UseVisualStyleBackColor = true;
            this.btnYazilimSil.Click += new System.EventHandler(this.btnYazilimSil_Click);
            // 
            // btnYeniYazilim
            // 
            this.btnYeniYazilim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniYazilim.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniYazilim.Image")));
            this.btnYeniYazilim.Location = new System.Drawing.Point(635, 527);
            this.btnYeniYazilim.Name = "btnYeniYazilim";
            this.btnYeniYazilim.Size = new System.Drawing.Size(49, 40);
            this.btnYeniYazilim.TabIndex = 1;
            this.btnYeniYazilim.UseVisualStyleBackColor = true;
            this.btnYeniYazilim.Click += new System.EventHandler(this.btnYeniYazilim_Click);
            // 
            // btnYazilimAyrintiDuzenle
            // 
            this.btnYazilimAyrintiDuzenle.Enabled = false;
            this.btnYazilimAyrintiDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazilimAyrintiDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnYazilimAyrintiDuzenle.Image")));
            this.btnYazilimAyrintiDuzenle.Location = new System.Drawing.Point(580, 527);
            this.btnYazilimAyrintiDuzenle.Name = "btnYazilimAyrintiDuzenle";
            this.btnYazilimAyrintiDuzenle.Size = new System.Drawing.Size(49, 40);
            this.btnYazilimAyrintiDuzenle.TabIndex = 2;
            this.btnYazilimAyrintiDuzenle.UseVisualStyleBackColor = true;
            this.btnYazilimAyrintiDuzenle.Click += new System.EventHandler(this.btnYazilimAyrintiDuzenle_Click);
            // 
            // dgvYazilim
            // 
            this.dgvYazilim.AllowUserToAddRows = false;
            this.dgvYazilim.AllowUserToDeleteRows = false;
            this.dgvYazilim.AllowUserToResizeRows = false;
            this.dgvYazilim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYazilim.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvYazilim.BackgroundColor = System.Drawing.Color.White;
            this.dgvYazilim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvYazilim.ColumnHeadersHeight = 34;
            this.dgvYazilim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvYazilim.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvYazilim.Location = new System.Drawing.Point(0, 35);
            this.dgvYazilim.MultiSelect = false;
            this.dgvYazilim.Name = "dgvYazilim";
            this.dgvYazilim.RowHeadersVisible = false;
            this.dgvYazilim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYazilim.Size = new System.Drawing.Size(694, 475);
            this.dgvYazilim.TabIndex = 25;
            this.dgvYazilim.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvYazilim_CellMouseClick);
            this.dgvYazilim.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvLisans_DataBindingComplete);
            this.dgvYazilim.DoubleClick += new System.EventHandler(this.dgvYazilim_DoubleClick);
            // 
            // tpLisans
            // 
            this.tpLisans.Controls.Add(this.pictureBox3);
            this.tpLisans.Controls.Add(this.lblLisansSayisi);
            this.tpLisans.Controls.Add(this.cbArananLisansStunu);
            this.tpLisans.Controls.Add(this.txtLisansAra);
            this.tpLisans.Controls.Add(this.btnLisansSil);
            this.tpLisans.Controls.Add(this.btnYeniLisans);
            this.tpLisans.Controls.Add(this.btnLisansAyrintiDuzenle);
            this.tpLisans.Controls.Add(this.dgvLisans);
            this.tpLisans.Location = new System.Drawing.Point(4, 34);
            this.tpLisans.Name = "tpLisans";
            this.tpLisans.Padding = new System.Windows.Forms.Padding(3);
            this.tpLisans.Size = new System.Drawing.Size(697, 580);
            this.tpLisans.TabIndex = 3;
            this.tpLisans.Text = "LİSANS";
            this.tpLisans.UseVisualStyleBackColor = true;
            this.tpLisans.Enter += new System.EventHandler(this.tpLisans_Enter);
            // 
            // lblLisansSayisi
            // 
            this.lblLisansSayisi.AutoSize = true;
            this.lblLisansSayisi.Location = new System.Drawing.Point(42, 547);
            this.lblLisansSayisi.Name = "lblLisansSayisi";
            this.lblLisansSayisi.Size = new System.Drawing.Size(66, 13);
            this.lblLisansSayisi.TabIndex = 8;
            this.lblLisansSayisi.Text = "Kayıt Sayısı :";
            // 
            // cbArananLisansStunu
            // 
            this.cbArananLisansStunu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbArananLisansStunu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbArananLisansStunu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArananLisansStunu.FormattingEnabled = true;
            this.cbArananLisansStunu.Location = new System.Drawing.Point(1, 8);
            this.cbArananLisansStunu.Name = "cbArananLisansStunu";
            this.cbArananLisansStunu.Size = new System.Drawing.Size(156, 21);
            this.cbArananLisansStunu.TabIndex = 7;
            // 
            // txtLisansAra
            // 
            this.txtLisansAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLisansAra.Location = new System.Drawing.Point(163, 9);
            this.txtLisansAra.Name = "txtLisansAra";
            this.txtLisansAra.Size = new System.Drawing.Size(200, 20);
            this.txtLisansAra.TabIndex = 8;
            this.txtLisansAra.Text = "Ara...";
            this.txtLisansAra.TextChanged += new System.EventHandler(this.txtKullaniciAra_TextChanged);
            this.txtLisansAra.Enter += new System.EventHandler(this.txtKullaniciAra_Enter);
            this.txtLisansAra.Leave += new System.EventHandler(this.txtKullaniciAra_Leave);
            // 
            // btnLisansSil
            // 
            this.btnLisansSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLisansSil.Image = ((System.Drawing.Image)(resources.GetObject("btnLisansSil.Image")));
            this.btnLisansSil.Location = new System.Drawing.Point(525, 527);
            this.btnLisansSil.Name = "btnLisansSil";
            this.btnLisansSil.Size = new System.Drawing.Size(49, 40);
            this.btnLisansSil.TabIndex = 3;
            this.btnLisansSil.UseVisualStyleBackColor = true;
            this.btnLisansSil.Click += new System.EventHandler(this.btnLisansSil_Click);
            // 
            // btnYeniLisans
            // 
            this.btnYeniLisans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniLisans.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniLisans.Image")));
            this.btnYeniLisans.Location = new System.Drawing.Point(635, 527);
            this.btnYeniLisans.Name = "btnYeniLisans";
            this.btnYeniLisans.Size = new System.Drawing.Size(49, 40);
            this.btnYeniLisans.TabIndex = 1;
            this.btnYeniLisans.UseVisualStyleBackColor = true;
            this.btnYeniLisans.Click += new System.EventHandler(this.btnYeniLisans_Click);
            // 
            // btnLisansAyrintiDuzenle
            // 
            this.btnLisansAyrintiDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLisansAyrintiDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnLisansAyrintiDuzenle.Image")));
            this.btnLisansAyrintiDuzenle.Location = new System.Drawing.Point(580, 527);
            this.btnLisansAyrintiDuzenle.Name = "btnLisansAyrintiDuzenle";
            this.btnLisansAyrintiDuzenle.Size = new System.Drawing.Size(49, 40);
            this.btnLisansAyrintiDuzenle.TabIndex = 2;
            this.btnLisansAyrintiDuzenle.UseVisualStyleBackColor = true;
            this.btnLisansAyrintiDuzenle.Click += new System.EventHandler(this.btnLisansAyrintiDuzenle_Click);
            // 
            // dgvLisans
            // 
            this.dgvLisans.AllowUserToAddRows = false;
            this.dgvLisans.AllowUserToDeleteRows = false;
            this.dgvLisans.AllowUserToResizeColumns = false;
            this.dgvLisans.AllowUserToResizeRows = false;
            this.dgvLisans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLisans.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLisans.BackgroundColor = System.Drawing.Color.White;
            this.dgvLisans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLisans.ColumnHeadersHeight = 34;
            this.dgvLisans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLisans.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLisans.Location = new System.Drawing.Point(0, 35);
            this.dgvLisans.MultiSelect = false;
            this.dgvLisans.Name = "dgvLisans";
            this.dgvLisans.RowHeadersVisible = false;
            this.dgvLisans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLisans.Size = new System.Drawing.Size(694, 475);
            this.dgvLisans.TabIndex = 25;
            this.dgvLisans.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLisans_CellDoubleClick);
            this.dgvLisans.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLisans_CellMouseClick);
            this.dgvLisans.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvLisans_DataBindingComplete);
            // 
            // bgw
            // 
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            // 
            // pb
            // 
            this.pb.Image = ((System.Drawing.Image)(resources.GetObject("pb.Image")));
            this.pb.Location = new System.Drawing.Point(8, 537);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(31, 30);
            this.pb.TabIndex = 26;
            this.pb.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 537);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 537);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 30);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 537);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 30);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // KAYITLAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 613);
            this.Controls.Add(this.tc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KAYITLAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KAYITLAR";
            this.Shown += new System.EventHandler(this.KAYITLAR_Shown);
            this.tc.ResumeLayout(false);
            this.tpKullanicilar.ResumeLayout(false);
            this.tpKullanicilar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanici)).EndInit();
            this.tpDonanim.ResumeLayout(false);
            this.tpDonanim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonanim)).EndInit();
            this.tpYazilim.ResumeLayout(false);
            this.tpYazilim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYazilim)).EndInit();
            this.tpLisans.ResumeLayout(false);
            this.tpLisans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLisans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tpKullanicilar;
        private System.Windows.Forms.TabPage tpDonanim;
        private System.Windows.Forms.TabPage tpYazilim;
        private System.Windows.Forms.TabPage tpLisans;
        private System.Windows.Forms.DataGridView dgvKullanici;
        private System.Windows.Forms.Button btnAyrintiDuzenle;
        private System.Windows.Forms.Button btnYeniKisi;
        private System.Windows.Forms.DataGridView dgvDonanim;
        private System.Windows.Forms.Button btnYeniDonanim;
        private System.Windows.Forms.Button btnDonanimAyrintiDuzenle;
        private System.Windows.Forms.Button btnKullaniciSil;
        private System.Windows.Forms.Button btnDonanimSil;
        private System.Windows.Forms.Button btnYazilimSil;
        private System.Windows.Forms.Button btnYeniYazilim;
        private System.Windows.Forms.Button btnYazilimAyrintiDuzenle;
        private System.Windows.Forms.DataGridView dgvYazilim;
        private System.Windows.Forms.Button btnLisansSil;
        private System.Windows.Forms.Button btnYeniLisans;
        private System.Windows.Forms.Button btnLisansAyrintiDuzenle;
        private System.Windows.Forms.DataGridView dgvLisans;
        private System.Windows.Forms.TextBox txtKullaniciAra;
        private System.Windows.Forms.TextBox txtDonanimAra;
        private System.Windows.Forms.TextBox txtYazilimAra;
        private System.Windows.Forms.TextBox txtLisansAra;
        private System.Windows.Forms.ComboBox cbArananYazilimStunu;
        private System.Windows.Forms.ComboBox cbArananKullaniciStunu;
        private System.Windows.Forms.ComboBox cbArananDonanimStunu;
        private System.Windows.Forms.ComboBox cbArananLisansStunu;
        private System.Windows.Forms.Label lblYazilimSayisi;
        private System.Windows.Forms.Label lblKullaniciSayisi;
        private System.Windows.Forms.Label lblDonanimSayisi;
        private System.Windows.Forms.Label lblLisansSayisi;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}