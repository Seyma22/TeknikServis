using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TeknikServis.Models;

namespace TeknikServis.AyarFormlari
{
    public partial class LISANS_TIPLERI : Form
    {
        int id;

        public LISANS_TIPLERI(int bilgi,string TipAdi)
        {
            InitializeComponent();

            if (bilgi != 0)
            {
                this.Text = "Lisans Tipi Güncelle";
                btnEkle.Text = "Kaydet";
                txtLisansTipi.Text = TipAdi;
            }

            id = bilgi;
        }

        private void LISANS_TIPLERI_Load(object sender, EventArgs e)
        {
            this.Location = new Point(220, 50);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtLisansTipi.Text != "")
                Ekle();
            else
                MessageBox.Show("Lisans tipi boş bırakılamaz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Ekle()
        {
            LisansTipleri LisansTipi = new LisansTipleri();
            LisansTipi.TipId = id; // ekleme yapılacagında id 0 gelir.
            LisansTipi.TipAdi = txtLisansTipi.Text;

            if (LisansTipi.LisansTipiEkleGuncelle() == 0)
            {
                MessageBox.Show("Bu lisans tipi daha önce eklenmiş.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();
            }
        }
    }
}
