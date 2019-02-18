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
    public partial class YENI_KISI : Form
    {
        DataTable dt = new DataTable();

        public YENI_KISI()
        {
            InitializeComponent();
        }

        private void YENIKISI_Load(object sender, EventArgs e)
        {
            this.Location = new Point(220, 50);

            dt = Firmalar.FirmalariGetir();
            cbFirma.DataSource = dt;
            cbFirma.DisplayMember = "FİRMALAR";
            cbFirma.ValueMember = "FirmaId";
            cbFirma.SelectedValue = false;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cbFirma.Text == "" || txtAd.Text == "" || txtSoyad.Text == "" || txtDepartman.Text == "")
            {
                MessageBox.Show("Firma, ad, soyad ve departman boş bırakılamaz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Ekle();
            }
        }

        public void Ekle()
        {
            Kullanicilar kullanici = new Kullanicilar();
            kullanici.Ad = txtAd.Text;
            kullanici.Soyad = txtSoyad.Text;
            kullanici.Departman = txtDepartman.Text;
            kullanici.DomainAdi = txtDomainAdi.Text;
            kullanici.KullaniciId = 0;
            kullanici.FirmaId = Convert.ToInt32(cbFirma.SelectedValue);

            kullanici.KullaniciEkleGuncelle();

            this.Close();
        }
    }
}
