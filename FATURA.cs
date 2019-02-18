using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class FATURA : Form
    {
        public FATURA(Image img)
        {
            InitializeComponent();
            if (img != null)
            {
                pbFatura.Width = img.Width;
                pbFatura.Height = img.Height;
                this.Height = pbFatura.Height + 25;
                this.Width = pbFatura.Width + 6;
                pbFatura.Image = img;
            }
        }

        private void FATURA_Load(object sender, EventArgs e)
        {
        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
