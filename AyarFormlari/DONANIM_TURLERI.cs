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
    public partial class DONANIM_TURLERI : Form
    {
        int id;

        public DONANIM_TURLERI(int bilgi, string Tur)
        {
            InitializeComponent();

            if (bilgi != 0)
            {
                this.Text = "Donanım Türü Güncelle";
                btnEkle.Text = "Kaydet";
                txtDonanimTuru.Text = Tur;
            }

            id = bilgi;
        }

        private void DONANIM_TURLERI_Load(object sender, EventArgs e)
        {
            this.Location = new Point(220, 50);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(txtDonanimTuru.Text != "")
                Ekle();
            else
                MessageBox.Show("Donanım türü boş bırakılamaz.","Uyarı!", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public void Ekle()
        {
            DonanimTurleri donanimTuru = new DonanimTurleri();
            donanimTuru.TurId = id; // ekleme yapılacagında id 0 gelir.
            donanimTuru.Tur = txtDonanimTuru.Text;

            if (donanimTuru.DonanimTuruEkleGuncelle() == 0)
            {
                MessageBox.Show("Bu donanım türü daha önce eklenmiş.", "HATA!", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                this.Close();
            }
        }
    }
}
