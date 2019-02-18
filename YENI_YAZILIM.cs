using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TeknikServis.Models;

namespace TeknikServis
{
    public partial class YENI_YAZILIM : Form
    {
        int id;

        public YENI_YAZILIM(int bilgi,string yazilimAdi,int lisansSayisi,string guncellemeTarihi)
        {
            InitializeComponent();

            if (bilgi != 0)
            {
                this.Text = "Yazılım Bilgileri";
                txtYazilimAdi.Text = yazilimAdi;
                txtLisansSayisi.Text = lisansSayisi.ToString();
                dtpGuncellemeTarihi.Text = guncellemeTarihi;
            }

            id = bilgi;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YENI_YAZILIM_Load(object sender, EventArgs e)
        {
            this.Location = new Point(220, 50);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtYazilimAdi.Text == "")
            {
                MessageBox.Show("Yazılım adı boş bırakılamaz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Kaydet();
            }
        }

        private void Kaydet()
        {
            Yazilimlar yazilim = new Yazilimlar();
            yazilim.YazilimId = id;
            yazilim.YazilimAdi = txtYazilimAdi.Text;
            yazilim.LisansSayisi = Convert.ToInt32(txtLisansSayisi.Text);
            yazilim.GuncellemeTarihi = dtpGuncellemeTarihi.Value.ToString("yyyy-MM-dd");

            if (yazilim.YazilimEkleGuncelle() == 0)
            {
                MessageBox.Show("Bu Yazılım Daha Önce Eklenmiş.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();
            }
        }
    }
}
