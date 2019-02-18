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
    public partial class TEKNIK_SERVIS_FIRMALARI : Form
    {
        int id;

        public TEKNIK_SERVIS_FIRMALARI(int bilgi,string firmaAdi,string adres,string tel,string fax,string gsm,string eMail)
        {
            InitializeComponent();

            if (bilgi != 0)
            {
                this.Text = "Teknik Servis Firması Güncelle";
                btnEkle.Text = "Kaydet";
                txtAdres.Text = adres;
                txtEmail.Text = eMail;
                txtFax.Text = fax;
                txtGsm.Text = gsm;
                txtTeknikServisFirmaAdi.Text = firmaAdi;
                txtTelefon.Text = tel;
            }

            id = bilgi;
        }

        private void TEKNIK_SERVIS_FIRMALARI_Load(object sender, EventArgs e)
        {
            this.Location = new Point(220, 50);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtTeknikServisFirmaAdi.Text != "")
                Ekle();
            else
                MessageBox.Show("Firma adı boş bırakılamaz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Ekle()
        {
            ServisFirmalari ServisFirmasi = new ServisFirmalari();
            ServisFirmasi.ServisFirmaId = id; // ekleme yapılacagında id 0 gelir.
            ServisFirmasi.FirmaAdi = txtTeknikServisFirmaAdi.Text;
            ServisFirmasi.Adres = txtAdres.Text;
            ServisFirmasi.Tel = txtTelefon.Text;
            ServisFirmasi.Fax = txtFax.Text;
            ServisFirmasi.Gsm = txtGsm.Text;
            ServisFirmasi.Email = txtEmail.Text;

            if (ServisFirmasi.ServisFirmasiEkleGuncelle() == 0)
            {
                MessageBox.Show("Bu teknik servis firması daha önce eklenmiş.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();
            }
        }
    }
}
