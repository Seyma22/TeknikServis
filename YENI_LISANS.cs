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
    public partial class YENI_LISANS : Form
    {
        DataTable dtLisansTipleri = new DataTable();
        DataTable dtYazilimlar = new DataTable();
        int id;
        string _tipAdi;
        string _yazilimAdi;

        public YENI_LISANS(int bilgi,string yazilimAdi,string tipAdi,string lisansKey,string lisansNumarasi,string lisansAdi,int lisansSayisi)
        {
            InitializeComponent();

            if (bilgi != 0)
            {
                this.Text = "Lisans Bilgileri";
                txtKey.Text = lisansKey;
                txtLisansAdi.Text = lisansAdi;
                txtLisansNumarasi.Text = lisansNumarasi;
                txtLisansSayisi.Text = lisansSayisi.ToString();
                _tipAdi = tipAdi;
                _yazilimAdi = yazilimAdi;
            }

            id = bilgi;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YENI_LISANS_Load(object sender, EventArgs e)
        {
            this.Location = new Point(220, 50);

            dtLisansTipleri = LisansTipleri.LisansTipleriniGetir();
            dtYazilimlar = Yazilimlar.YazilimlariGetir(0);

            cbLisansTipi.DataSource = dtLisansTipleri;
            cbLisansTipi.DisplayMember = "LİSANS TİPLERİ";
            cbLisansTipi.ValueMember = "TipId";

            cbYazilimTipi.DataSource = dtYazilimlar;
            cbYazilimTipi.DisplayMember = "YAZILIM ADI";
            cbYazilimTipi.ValueMember = "YazilimId";

            if (id != 0)
            {
                cbLisansTipi.SelectedIndex = cbLisansTipi.FindString(_tipAdi);
                if (_yazilimAdi != "") 
                    cbYazilimTipi.SelectedIndex = cbYazilimTipi.FindString(_yazilimAdi);
                else 
                    cbYazilimTipi.SelectedValue = false;

            }
            else
            {
                cbLisansTipi.SelectedValue = false;
                cbYazilimTipi.SelectedValue = false;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cbLisansTipi.Text == "" || txtLisansAdi.Text == "" || txtLisansNumarasi.Text == "")
            {
                MessageBox.Show("Lisans numarası, adı ve tipi boş bırakılamaz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Kaydet();
            }
        }

        public void Kaydet()
        {
            Lisanslar lisans = new Lisanslar();
            lisans.LisansId = id;
            lisans.LisansAdi = txtLisansAdi.Text;
            lisans.LisansKey = txtKey.Text;
            lisans.LisansNumarasi = txtLisansNumarasi.Text;
            try
            {
                lisans.LisansSayisi = Convert.ToInt32(txtLisansSayisi.Text);
                if (cbLisansTipi.SelectedValue != null)
                    lisans.TipId = Convert.ToInt32(cbLisansTipi.SelectedValue);
                if (cbYazilimTipi.SelectedValue != null)
                    lisans.YazilimId = Convert.ToInt32(cbYazilimTipi.SelectedValue);
                else
                lisans.YazilimId = 0;

                lisans.LisansEkleGuncelle();

                this.Close();
            }
            catch
            {
                MessageBox.Show("Lisans sayısını numerik giriniz.","Hata!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
