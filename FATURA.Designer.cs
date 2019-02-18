namespace TeknikServis
{
    partial class FATURA
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
            this.pbFatura = new System.Windows.Forms.PictureBox();
            this.btnCik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFatura)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFatura
            // 
            this.pbFatura.Location = new System.Drawing.Point(0, 0);
            this.pbFatura.MaximumSize = new System.Drawing.Size(594, 695);
            this.pbFatura.Name = "pbFatura";
            this.pbFatura.Size = new System.Drawing.Size(424, 402);
            this.pbFatura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFatura.TabIndex = 0;
            this.pbFatura.TabStop = false;
            // 
            // btnCik
            // 
            this.btnCik.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCik.Location = new System.Drawing.Point(0, 0);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(0, 0);
            this.btnCik.TabIndex = 1;
            this.btnCik.UseVisualStyleBackColor = true;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // FATURA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCik;
            this.ClientSize = new System.Drawing.Size(423, 402);
            this.Controls.Add(this.btnCik);
            this.Controls.Add(this.pbFatura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 720);
            this.MinimizeBox = false;
            this.Name = "FATURA";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Fatura";
            this.Load += new System.EventHandler(this.FATURA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFatura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFatura;
        private System.Windows.Forms.Button btnCik;
    }
}