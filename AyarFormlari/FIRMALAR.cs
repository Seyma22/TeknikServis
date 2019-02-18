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
    public partial class FIRMALAR : Form
    {
        int id;

        public FIRMALAR(int bilgi,string Firma,string adres,string vergiDairesi,string vergiNumarasi)
        {
            InitializeComponent();

            if (bilgi != 0)
            {
                this.Text = "Firma Güncelle";
                btnEkle.Text = "Kaydet";
                txtFirmaAdi.Text = Firma;
                txtAdres.Text = adres;
                txtVergiDairesi.Text = vergiDairesi;
                txtVergiNumarasi.Text = vergiNumarasi;
            }

            id = bilgi;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FIRMALAR_Load(object sender, EventArgs e)
        {
            this.Location = new Point(220, 50);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtFirmaAdi.Text != "")
                Ekle();
            else
                MessageBox.Show("Firma adı boş bırakılamaz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Ekle()
        {
            Firmalar firma = new Firmalar();
            firma.FirmaId = id; // ekleme yapılacagında id 0 gelir.
            firma.Firma = txtFirmaAdi.Text;
            firma.Adres = txtAdres.Text;
            firma.VergiDairesi = txtVergiDairesi.Text;
            firma.VergiNumarasi = txtVergiNumarasi.Text;

            if (firma.FirmaEkleGuncelle() == 0)
            {
                MessageBox.Show("Bu firma daha önce eklenmiş.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();
            }
        }
    }
}
