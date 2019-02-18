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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();

            this.Opacity = 0.0;
            tmrOpacityArttir = new Timer();

            tmrOpacityArttir.Interval = 20;

            tmrOpacityArttir.Tick += new EventHandler(Opacity_Artir);
            tmrOpacityArttir.Enabled = true;
        }

        KAYITLAR KayitlarFormu;
        TEKNIK_SERVIS TeknikServisFormu;
        AYARLAR AyarlarFormu;
        GIRIS GirisFormu;

        Timer tmrOpacityArttir = new Timer();

        public void FrmKapat()
        {
            for (int i = Application.OpenForms.Count - 1; i > 0; i--)
            {
                Application.OpenForms[i].Close();
            }
        }

        private void kAYITLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[1].Name != "KAYITLAR")
            {
                FrmKapat();

                KayitlarFormu = new KAYITLAR();
                KayitlarFormu.MdiParent = this;
                KayitlarFormu.Show();
            }
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tEKNİKSERVİSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[1].Name != "TEKNIK_SERVIS")
            {
                FrmKapat();

                TeknikServisFormu = new TEKNIK_SERVIS();
                TeknikServisFormu.MdiParent = this;
                TeknikServisFormu.Show();
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            msAnaMenu.Enabled = false;
            this.Location = new Point(200,15);

            GirisFormu = new GIRIS();
            GirisFormu.MdiParent = this;
            GirisFormu.msChild = msAnaMenu;
            GirisFormu.Show();
        }

        private void aYARLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[1].Name != "AYARLAR")
            {
                FrmKapat();

                AyarlarFormu = new AYARLAR();
                AyarlarFormu.MdiParent = this;
                AyarlarFormu.Show();
            }
        }

        private void Opacity_Artir(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
            if (this.Opacity == 1.0)
            {
                tmrOpacityArttir.Enabled = false;
            }
        }
    }
}
