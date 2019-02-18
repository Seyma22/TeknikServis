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
    public partial class UYELER : Form
    {
        int id;

        public UYELER(int bilgi,string rol,string ad,string soyad,string kullaniciAdi,string sifre)
        {
            InitializeComponent();

            if (bilgi != 0)
            {
                this.Text = "Üye (Kullanıcı) Güncelle";
                btnEkle.Text = "Kaydet";
                txtAd.Text = ad;
                txtKullaniciAdi.Text = kullaniciAdi;
                txtSifre.Text = sifre;
                txtSoyad.Text = soyad;
                cbRol.SelectedIndex = cbRol.FindString(rol);
            }
            else
                cbRol.SelectedIndex = cbRol.FindString("Admin");

            id = bilgi;
        }

        private void UYELER_Load(object sender, EventArgs e)
        {
            this.Location = new Point(220, 50);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtKullaniciAdi.Text !="" && txtSifre.Text!="" && txtSoyad.Text!="")
                Ekle();
            else
                MessageBox.Show("Hiçbir alan boş bırakılamaz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Ekle()
        {
            Uyeler uye = new Uyeler();
            uye.UyeId = id;
            uye.Rol = cbRol.Text;
            uye.Ad = txtAd.Text;
            uye.Soyad = txtSoyad.Text;
            uye.KullaniciAdi = txtKullaniciAdi.Text;
            uye.Sifre = txtSifre.Text;

            if (uye.UyeEkleGuncelle() == 0)
            {
                MessageBox.Show("Bu üye adı daha önce kullanılmış.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();
            }
        }
    }
}
