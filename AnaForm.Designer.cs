namespace TeknikServis
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.msAnaMenu = new System.Windows.Forms.MenuStrip();
            this.kAYITLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEKNİKSERVİSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYARLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msAnaMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msAnaMenu
            // 
            this.msAnaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kAYITLARToolStripMenuItem,
            this.tEKNİKSERVİSToolStripMenuItem,
            this.aYARLARToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.msAnaMenu.Location = new System.Drawing.Point(0, 0);
            this.msAnaMenu.Name = "msAnaMenu";
            this.msAnaMenu.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.msAnaMenu.Size = new System.Drawing.Size(821, 46);
            this.msAnaMenu.TabIndex = 0;
            // 
            // kAYITLARToolStripMenuItem
            // 
            this.kAYITLARToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kAYITLARToolStripMenuItem.Image")));
            this.kAYITLARToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kAYITLARToolStripMenuItem.Name = "kAYITLARToolStripMenuItem";
            this.kAYITLARToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.kAYITLARToolStripMenuItem.Size = new System.Drawing.Size(99, 30);
            this.kAYITLARToolStripMenuItem.Text = "BİLGİ İŞLEM";
            this.kAYITLARToolStripMenuItem.Click += new System.EventHandler(this.kAYITLARToolStripMenuItem_Click);
            // 
            // tEKNİKSERVİSToolStripMenuItem
            // 
            this.tEKNİKSERVİSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tEKNİKSERVİSToolStripMenuItem.Image")));
            this.tEKNİKSERVİSToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tEKNİKSERVİSToolStripMenuItem.Name = "tEKNİKSERVİSToolStripMenuItem";
            this.tEKNİKSERVİSToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.tEKNİKSERVİSToolStripMenuItem.Size = new System.Drawing.Size(114, 30);
            this.tEKNİKSERVİSToolStripMenuItem.Text = "TEKNİK SERVİS";
            this.tEKNİKSERVİSToolStripMenuItem.Click += new System.EventHandler(this.tEKNİKSERVİSToolStripMenuItem_Click);
            // 
            // aYARLARToolStripMenuItem
            // 
            this.aYARLARToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aYARLARToolStripMenuItem.Image")));
            this.aYARLARToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.aYARLARToolStripMenuItem.Name = "aYARLARToolStripMenuItem";
            this.aYARLARToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.aYARLARToolStripMenuItem.Size = new System.Drawing.Size(88, 30);
            this.aYARLARToolStripMenuItem.Text = "AYARLAR";
            this.aYARLARToolStripMenuItem.Click += new System.EventHandler(this.aYARLARToolStripMenuItem_Click);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çIKIŞToolStripMenuItem.Image")));
            this.çIKIŞToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(64, 30);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 663);
            this.Controls.Add(this.msAnaMenu);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msAnaMenu;
            this.MaximizeBox = false;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "B.İ. Takip";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.msAnaMenu.ResumeLayout(false);
            this.msAnaMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msAnaMenu;
        private System.Windows.Forms.ToolStripMenuItem kAYITLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tEKNİKSERVİSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYARLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
    }
}

