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
    public partial class YENI_DONANIM : Form
    {
        int id;
        string _firmaAdi;
        string _donanimTuru;
        DataTable dt = new DataTable();

        public YENI_DONANIM(int bilgi,string firmaAdi,string donanimTuru)
        {
            InitializeComponent();

            if (bilgi != 0)
            {
                this.Text = "Donanım Bilgileri";
                _firmaAdi = firmaAdi;
                _donanimTuru = donanimTuru;
            }

            id = bilgi;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YENI_DONANIM_Load(object sender, EventArgs e)
        {
            this.Location = new Point(220, 50);
            YukseklikAzalt();

            dt = DonanimTurleri.DonanimTurleriniGetir();
            cbTur.DataSource = dt;
            cbTur.DisplayMember = "DONANIM TÜRLERİ";
            cbTur.ValueMember = "TurId";

            dt = Firmalar.FirmalariGetir();
            cbFirma.DataSource = dt;
            cbFirma.DisplayMember = "FİRMALAR";
            cbFirma.ValueMember = "FirmaId";

            if (id != 0)
            {
                dt = Donanimlar.DonanimGetirDonanimIdIle(id);
                txtGarantiDurumu.Text = dt.Rows[0].Field<string>("GARANTİ DURUMU").ToString();
                txtİsletimSistemi.Text = dt.Rows[0].Field<string>("İŞLETİM SİSTEMİ").ToString();
                txtLisansKey.Text = dt.Rows[0].Field<string>("LİSANS KEY").ToString();
                txtMarka.Text = dt.Rows[0].Field<string>("MARKA").ToString();
                txtModel.Text = dt.Rows[0].Field<string>("MODEL").ToString();
                txtRam.Text = dt.Rows[0].Field<string>("RAM").ToString();
                txtSeriNo.Text = dt.Rows[0].Field<string>("SERİ NO").ToString();
                txtUrunNo.Text = dt.Rows[0].Field<string>("ÜRÜN NO").ToString();
                dtpBakimTarihi.Value = dt.Rows[0].Field<DateTime>("BAKIM TARİHİ");
                cbFirma.SelectedIndex = cbFirma.FindString(_firmaAdi);
                cbTur.SelectedIndex = cbTur.FindString(_donanimTuru);

                dt = Hurdalar.HurdaGetirDonanimIdIle(id);
                if (dt.Rows.Count > 0)
                {
                    gbHurdaBilgisi.Enabled = true;
                    rbHurda.Checked = true;
                    YukseklikArttir();
                    txtHurdaNotu.Text = dt.Rows[0].Field<string>("Notu").ToString();
                    dtpHurdaTarihi.Value = dt.Rows[0].Field<DateTime>("HurdaTarihi");
                }
                else rbSaglam.Checked = true;
            }
            else
            {
                cbFirma.SelectedValue = false;
                cbTur.SelectedValue = false;
                rbSaglam.Checked = true;
            }
        }

        private void rbHurda_CheckedChanged(object sender, EventArgs e)
        {
            YukseklikArttir();
        }

        private void rbSaglam_CheckedChanged(object sender, EventArgs e)
        {
            YukseklikAzalt();
        }

        public void YukseklikAzalt()
        {
            this.Height = 520;
            btnKaydet.Location = new Point(233, 440);
            btnVazgec.Location = new Point(152, 440);
            gbHurdaBilgisi.Enabled = false;
            gbHurdaBilgisi.Visible = false;
        }

        public void YukseklikArttir()
        {
            this.Height = 634;
            btnKaydet.Location = new Point(233, 555);
            btnVazgec.Location = new Point(152, 555);
            gbHurdaBilgisi.Enabled = true;
            gbHurdaBilgisi.Visible = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtSeriNo.Text == "" || txtUrunNo.Text == "")
            {
                MessageBox.Show("Seri no ve ürün no boş bırakılamaz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cbFirma.Text == "" || cbTur.Text == "")
            {
                MessageBox.Show("Firma ve tür boş bırakılamaz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Kaydet();
            }
        }

        public void Kaydet()
        {
            Donanimlar donanim = new Donanimlar();
            donanim.DonanimId = id;
            donanim.BakimTarihi = dtpBakimTarihi.Value.ToString("yyyy-MM-dd");
            donanim.GarantiDurumu = txtGarantiDurumu.Text;
            donanim.IsletimSistemi = txtİsletimSistemi.Text;
            donanim.LisansKey = txtLisansKey.Text;
            donanim.Marka = txtMarka.Text;
            donanim.Model = txtModel.Text;
            donanim.Ram = txtRam.Text;
            donanim.SeriNo = txtSeriNo.Text;
            donanim.UrunNo = txtUrunNo.Text;
            donanim.FirmaId = Convert.ToInt32(cbFirma.SelectedValue);
            donanim.TurId = Convert.ToInt32(cbTur.SelectedValue);

            if (donanim.DonanimEkleGuncelle() != 0) //belirtilen urunno ve serino tekrar etmıyorsa.
            {
                if (rbHurda.Checked == true)
                {
                    Hurdalar hurda = new Hurdalar();
                    hurda.HurdaTarihi = dtpHurdaTarihi.Value.ToString("yyyy-MM-dd");
                    hurda.Notu = txtHurdaNotu.Text;
                    hurda.DonanimId = id;

                    hurda.HurdaEkleGuncelle();
                }
                else
                {
                    Hurdalar.HurdaSil(id);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Bu Ürün No ve Seri No'ya ait kayıt zaten mevcut.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
