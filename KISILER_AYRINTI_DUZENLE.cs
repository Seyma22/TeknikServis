using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TeknikServis.Models;
using System.Globalization;

namespace TeknikServis
{
    public partial class KISILER_AYRINTI_DUZENLE : Form
    {
        int id;
        string _firma;
        int sayac = 0;

        DataTable dt = new DataTable();
        DataTable arananDt = new DataTable();
        DataTable dtDonanim = new DataTable();
        DataTable dtYazilim = new DataTable();
        DataTable dtLisans = new DataTable();

        Boolean LisanslarTiklandi = false;
        Boolean YazilimlarTiklandi = false;

        public KISILER_AYRINTI_DUZENLE(int bilgi,string firma,string departman,string ad,string soyad,string domainAdi)
        {
            InitializeComponent();

            txtAd.Text = ad;
            txtDepartman.Text = departman;
            txtDomainAdi.Text = domainAdi;
            txtSoyad.Text = soyad;

            _firma = firma;
            id = bilgi;
        }

        /*protected override void WndProc(ref Message msj)
        {
            const int WM_SYSCOMMAND = 0X0112;
            const int SC_MOVE = 0xF010;

            switch (msj.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = msj.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref msj);
        }*/

        private void KISILER_AYRINTI_DUZENLE_Load(object sender, EventArgs e)
        {
            this.Location = new Point(220, 50);
        }

        ////////////////// DONANIMLAR ////////////////////

        private void btnDonanimListele_Click(object sender, EventArgs e)
        {
            if (btnDonanimListele.Text == "Listele")
            {
                dtDonanim = Donanimlar.DonanimlariGetir(id);
                dgvDonanim.DataSource = dtDonanim;
                DonanimAyrintiGizle();
                btnDonanimListele.Text = "Detay";
                txtDonanimAra.Enabled = true;
                dgvDonanim.Visible = true;
                btnDonanimEkle.Visible = true;
                btnDonanimSil.Visible = true;
                txtDonanimAra.Visible = true;
                cbArananDonanimStunu.Visible = true;
            }
            else if (btnDonanimListele.Text == "Detay")
            {
                DonanimAyrintiGoster();
                btnDonanimListele.Text = "Gizle";
            }
            else
            {
                DonanimAyrintiGizle();
                btnDonanimListele.Text = "Detay";
            }

            cbArananDonanimStunu.Items.Clear();
            for (int i = 1; i < dgvDonanim.Columns.Count; i++)
            {
                if (dgvDonanim.Columns[i].Visible == true)
                    cbArananDonanimStunu.Items.Add(dgvDonanim.Columns[i].HeaderText);
            }
            cbArananDonanimStunu.SelectedItem = cbArananDonanimStunu.Items[0];
        }

        private void DonanimAyrintiGoster()
        {
            dgvDonanim.Columns["FİRMA"].Visible = true;
            dgvDonanim.Columns["İŞLETİM SİSTEMİ"].Visible = true;
            dgvDonanim.Columns["LİSANS KEY"].Visible = true;
            dgvDonanim.Columns["RAM"].Visible = true;
            dgvDonanim.Columns["GARANTİ DURUMU"].Visible = true;
            dgvDonanim.Columns["BAKIM TARİHİ"].Visible = true;
            dgvDonanim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        private void DonanimAyrintiGizle()
        {
            dgvDonanim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonanim.Columns["DonanimId"].Visible = false;
            dgvDonanim.Columns["FİRMA"].Visible = false;
            dgvDonanim.Columns["İŞLETİM SİSTEMİ"].Visible = false;
            dgvDonanim.Columns["LİSANS KEY"].Visible = false;
            dgvDonanim.Columns["RAM"].Visible = false;
            dgvDonanim.Columns["GARANTİ DURUMU"].Visible = false;
            dgvDonanim.Columns["BAKIM TARİHİ"].Visible = false;
        }

        private void DonanimKullaniciAyrintiGoster()
        {
            dgvKullaniciDonanimlar.Columns["FİRMA"].Visible = true;
            dgvKullaniciDonanimlar.Columns["İŞLETİM SİSTEMİ"].Visible = true;
            dgvKullaniciDonanimlar.Columns["LİSANS KEY"].Visible = true;
            dgvKullaniciDonanimlar.Columns["RAM"].Visible = true;
            dgvKullaniciDonanimlar.Columns["GARANTİ DURUMU"].Visible = true;
            dgvKullaniciDonanimlar.Columns["BAKIM TARİHİ"].Visible = true;
            dgvKullaniciDonanimlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        private void DonanimKullaniciAyrintiGizle()
        {
            dgvKullaniciDonanimlar.Columns["DonanimId"].Visible = false;
            dgvKullaniciDonanimlar.Columns["FİRMA"].Visible = false;
            dgvKullaniciDonanimlar.Columns["İŞLETİM SİSTEMİ"].Visible = false;
            dgvKullaniciDonanimlar.Columns["LİSANS KEY"].Visible = false;
            dgvKullaniciDonanimlar.Columns["RAM"].Visible = false;
            dgvKullaniciDonanimlar.Columns["GARANTİ DURUMU"].Visible = false;
            dgvKullaniciDonanimlar.Columns["BAKIM TARİHİ"].Visible = false;
            dgvKullaniciDonanimlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDonanimKullanici_Click(object sender, EventArgs e)
        {
            if (btnDonanimKullanici.Text == "Detay")
            {
                btnDonanimKullanici.Text = "Gizle";
                DonanimKullaniciAyrintiGoster();
            }
            else
            {
                btnDonanimKullanici.Text = "Detay";
                DonanimKullaniciAyrintiGizle();
            }
        }

        private void KISILER_AYRINTI_DUZENLE_StyleChanged(object sender, EventArgs e)
        {
            dt = Firmalar.FirmalariGetir();
            cbFirma.DataSource = dt;
            cbFirma.DisplayMember = "FİRMALAR";
            cbFirma.ValueMember = "FirmaId";
            cbFirma.SelectedIndex = cbFirma.FindString(_firma);

            dt = Donanimlar.DonanimGetirKullaniciIdIle(id);
            dgvKullaniciDonanimlar.DataSource = dt;
            DonanimKullaniciAyrintiGizle();
        }

        private void btnDonanimEkle_Click(object sender, EventArgs e)
        {
            Donanimlar.DonanimKullaniciGuncelle(id, Convert.ToInt32(dgvDonanim.CurrentRow.Cells["DonanimId"].Value));

            dtDonanim = Donanimlar.DonanimlariGetir(id);
            dgvDonanim.DataSource = dtDonanim;

            dt = Donanimlar.DonanimGetirKullaniciIdIle(id);
            dgvKullaniciDonanimlar.DataSource = dt;

            timer.Enabled = true;
        }

        private void btnDonanimSil_Click(object sender, EventArgs e)
        {
            Donanimlar.DonanimKullaniciGuncelle(0, Convert.ToInt32(dgvKullaniciDonanimlar.CurrentRow.Cells["DonanimId"].Value));

            dt = Donanimlar.DonanimGetirKullaniciIdIle(id);
            dgvKullaniciDonanimlar.DataSource = dt;

            if (dgvDonanim.Columns.Count > 0)
            {
                dt = Donanimlar.DonanimlariGetir(id);
                dgvDonanim.DataSource = dt;
            }

            timer.Enabled = true;
        }

        private void dgvDonanim_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.Name == "dgvDonanim")
            {
                btnDonanimEkle.Enabled = true;
            }
            else
            {
                btnDonanimSil.Enabled = true;
            }
        }

        //////////////////////////////////////////////////
        ////////////////// YAZILIMLAR ////////////////////

        private void btnYazilimListele_Click(object sender, EventArgs e)
        {
            dtYazilim = Yazilimlar.YazilimlariGetir(id);
            dgvYazilim.DataSource = dtYazilim;

            dgvYazilim.Columns["YazilimId"].Visible = false;
                
            txtYazilimAra.Enabled = true;
            dgvYazilim.Visible = true;
            btnYazilimEkle.Visible = true;
            btnYazilimSil.Visible = true;
            txtYazilimAra.Visible = true;
            cbArananYazilimStunu.Visible = true;

            cbArananYazilimStunu.Items.Clear();
            for (int i = 1; i < dgvYazilim.Columns.Count; i++)
            {
                if (dgvYazilim.Columns[i].Visible == true)
                    cbArananYazilimStunu.Items.Add(dgvYazilim.Columns[i].HeaderText);
            }
            cbArananYazilimStunu.SelectedItem = cbArananYazilimStunu.Items[0];
        }

        private void dgvYazilim_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.Name == "dgvYazilim")
            {
                btnYazilimEkle.Enabled = true;
            }
            else
            {
                btnYazilimSil.Enabled = true;
            }
        }

        private void tpYazilimlar_Enter(object sender, EventArgs e)
        {
            if (!YazilimlarTiklandi)
            {
                dt = Yazilimlar.YazilimGetirKullaniciIdIle(id);
                dgvKullaniciYazilimlar.DataSource = dt;
                dgvKullaniciYazilimlar.Columns["YazilimId"].Visible = false;
            }
            YazilimlarTiklandi = true;
        }

        private void btnYazilimEkle_Click(object sender, EventArgs e)
        {
            Yazilimlar.YazilimKullaniciGuncelle(id, Convert.ToInt32(dgvYazilim.CurrentRow.Cells["YazilimId"].Value));

            dtYazilim = Yazilimlar.YazilimlariGetir(id);
            dgvYazilim.DataSource = dtYazilim;

            dt = Yazilimlar.YazilimGetirKullaniciIdIle(id);
            dgvKullaniciYazilimlar.DataSource = dt;

            timer.Enabled = true;
        }

        private void btnYazilimSil_Click(object sender, EventArgs e)
        {
            Yazilimlar.YazilimKullaniciGuncelle(0, Convert.ToInt32(dgvKullaniciYazilimlar.CurrentRow.Cells["YazilimId"].Value));

            dt = Yazilimlar.YazilimlariGetir(id);
            dgvYazilim.DataSource = dt;

            dt = Yazilimlar.YazilimGetirKullaniciIdIle(id);
            dgvKullaniciYazilimlar.DataSource = dt;

            timer.Enabled = true;
        }

        //////////////////////////////////////////////////
        ////////////////// LİSANSLAR ////////////////////

        private void btnLisansListele_Click(object sender, EventArgs e)
        {
            if (btnLisansListele.Text == "Listele")
            {
                dtLisans = Lisanslar.LisanslariGetir(id);
                dgvLisans.DataSource = dtLisans;
                txtLisansAra.Enabled = true;
                LisansAyrintiGizle();
                btnLisansListele.Text = "Detay";
                dgvLisans.Visible = true;
                btnLisansSil.Visible = true;
                btnLisansEkle.Visible = true;
                txtLisansAra.Visible = true;
                cbArananLisansStunu.Visible = true;
            }
            else if (btnLisansListele.Text == "Detay")
            {
                LisansAyrintiGoster();
                btnLisansListele.Text = "Gizle";
            }
            else
            {
                LisansAyrintiGizle();
                btnLisansListele.Text = "Detay";
            }

            cbArananLisansStunu.Items.Clear();
            for (int i = 1; i < dgvLisans.Columns.Count; i++)
            {
                if (dgvLisans.Columns[i].Visible == true)
                    cbArananLisansStunu.Items.Add(dgvLisans.Columns[i].HeaderText);
            }
            cbArananLisansStunu.SelectedItem = cbArananLisansStunu.Items[0];
        }

        private void LisansAyrintiGoster()
        {
            dgvLisans.Columns["LİSANS SAYISI"].Visible = true;
            dgvLisans.Columns["TİP ADI"].Visible = true;
            dgvLisans.Columns["LİSANS KEY"].Visible = true;
            dgvLisans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        private void LisansAyrintiGizle()
        {
            dgvLisans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLisans.Columns["LisansId"].Visible = false;
            dgvLisans.Columns["LİSANS SAYISI"].Visible = false;
            dgvLisans.Columns["TİP ADI"].Visible = false;
            dgvLisans.Columns["KullaniciId"].Visible = false;
            dgvLisans.Columns["TipId"].Visible = false;
            dgvLisans.Columns["YazilimId"].Visible = false;
            dgvLisans.Columns["LİSANS KEY"].Visible = false;
        }

        private void LisansKullaniciAyrintiGoster()
        {
            dgvKullaniciLisanslar.Columns["LİSANS SAYISI"].Visible = true;
            dgvKullaniciLisanslar.Columns["TİP ADI"].Visible = true;
            dgvKullaniciLisanslar.Columns["LİSANS KEY"].Visible = true;
            dgvKullaniciLisanslar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        private void LisansKullaniciAyrintiGizle()
        {
            dgvKullaniciLisanslar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKullaniciLisanslar.Columns["LisansId"].Visible = false;
            dgvKullaniciLisanslar.Columns["LİSANS SAYISI"].Visible = false;
            dgvKullaniciLisanslar.Columns["TİP ADI"].Visible = false;
            dgvKullaniciLisanslar.Columns["KullaniciId"].Visible = false;
            dgvKullaniciLisanslar.Columns["TipId"].Visible = false;
            dgvKullaniciLisanslar.Columns["YazilimId"].Visible = false;
            dgvKullaniciLisanslar.Columns["LİSANS KEY"].Visible = false;
        }

        private void tpLisanslar_Enter(object sender, EventArgs e)
        {
            if (!LisanslarTiklandi)
            {
                dt = Lisanslar.LisanslariGetirKullaniciIdIle(id);
                dgvKullaniciLisanslar.DataSource = dt;
                LisansKullaniciAyrintiGizle();
            }
            LisanslarTiklandi = true;
        }

        private void btnLisansEkle_Click(object sender, EventArgs e)
        {
            Lisanslar.LisansKullaniciGuncelle(id, Convert.ToInt32(dgvLisans.CurrentRow.Cells["LisansId"].Value));

            dtLisans = Lisanslar.LisanslariGetir(id);
            dgvLisans.DataSource = dtLisans;

            dt = Lisanslar.LisanslariGetirKullaniciIdIle(id);
            dgvKullaniciLisanslar.DataSource = dt;

            timer.Enabled = true;
        }

        private void btnLisansSil_Click(object sender, EventArgs e)
        {
            Lisanslar.LisansKullaniciGuncelle(0, Convert.ToInt32(dgvKullaniciLisanslar.CurrentRow.Cells["LisansId"].Value));

            dt = Lisanslar.LisanslariGetir(id);
            dgvLisans.DataSource = dt;

            dt = Lisanslar.LisanslariGetirKullaniciIdIle(id);
            dgvKullaniciLisanslar.DataSource = dt;

            timer.Enabled = true;
        }

        private void btnLisansKullanici_Click(object sender, EventArgs e)
        {
            if (btnLisansKullanici.Text == "Detay")
            {
                btnLisansKullanici.Text = "Gizle";
                LisansKullaniciAyrintiGoster();
            }
            else
            {
                btnLisansKullanici.Text = "Detay";
                LisansKullaniciAyrintiGizle();
            }
        }

        private void dgvLisans_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.Name == "dgvLisans")
            {
                btnLisansEkle.Enabled = true;
            }
            else
            {
                btnLisansSil.Enabled = true;
            }
        }

        //////////////////////////////////////////////////
        ////////////////// GENEL ////////////////////

        private void dgvDonanimlar_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.Name == "dgvDonanim" || dgv.Name == "dgvKullaniciDonanimlar")
            {
                dgvKullaniciDonanimlar.ClearSelection();
                dgvDonanim.ClearSelection();
                GridRenklendir(dgvDonanim);
                GridRenklendir(dgvKullaniciDonanimlar);

                btnDonanimSil.Enabled = false;
                btnDonanimEkle.Enabled = false;
            }
            else if (dgv.Name == "dgvYazilim" || dgv.Name == "dgvKullaniciYazilimlar")
            {
                dgvKullaniciYazilimlar.ClearSelection();
                dgvYazilim.ClearSelection();
                GridRenklendir(dgvKullaniciYazilimlar);
                GridRenklendir(dgvYazilim);

                btnYazilimEkle.Enabled = false;
                btnYazilimSil.Enabled = false;
            }
            else
            {
                dgvLisans.ClearSelection();
                dgvKullaniciLisanslar.ClearSelection();
                GridRenklendir(dgvKullaniciLisanslar);
                GridRenklendir(dgvLisans);

                btnLisansEkle.Enabled = false;
                btnLisansSil.Enabled = false;
            }
        }

        private void txtDonanimAra_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text != "Ara...") //arama sonucuna dahil olmayan satırları gorunmez olsun:)
            {
                if (txt.Name == "txtDonanimAra")
                {
                    dgvDonanim.DataSource = Ara(txtDonanimAra.Text, dtDonanim, cbArananDonanimStunu.Text);
                }
                if (txt.Name == "txtYazilimAra")
                {
                    dgvYazilim.DataSource = Ara(txtYazilimAra.Text, dtYazilim, cbArananYazilimStunu.Text);
                }
                else
                {
                    dgvLisans.DataSource = Ara(txtLisansAra.Text, dtLisans, cbArananLisansStunu.Text);
                }
            }
        }

        private void txtDonanimAra_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text == "Ara...") txt.Text = "";
        }

        private void txtDonanimAra_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text == "") txt.Text = "Ara...";
        }

        private DataTable Ara(string aranan, DataTable dt, string arananStun)
        {
            arananDt = dt.Copy();
            arananDt.Clear();
            CompareInfo karsilastirma = CultureInfo.InvariantCulture.CompareInfo;

            foreach (DataRow row in dt.Rows)
            {
                if (karsilastirma.IndexOf(row[arananStun].ToString(), aranan, CompareOptions.IgnoreCase) == 0)
                {
                    arananDt.ImportRow(row);
                }
            }

            return arananDt;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GridRenklendir(DataGridView dgdListe)
        {
            int sayi = 0;
            for (int i = 0; i < dgdListe.Rows.Count; i++)
            {
                Application.DoEvents();
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (sayi % 2 == 0)
                {
                    renk.BackColor = Color.White;
                }
                else
                {
                    renk.BackColor = Color.Gainsboro;
                }
                dgdListe.Rows[i].DefaultCellStyle = renk;
                sayi++;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtSoyad.Text != "")
                Ekle();
            else
                MessageBox.Show("Ad ve soyad boş bırakılamaz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Ekle()
        {
            Kullanicilar kullanici = new Kullanicilar();
            kullanici.Ad = txtAd.Text;
            kullanici.Soyad = txtSoyad.Text;
            kullanici.Departman = txtDepartman.Text;
            kullanici.DomainAdi = txtDomainAdi.Text;
            kullanici.KullaniciId = id;
            kullanici.FirmaId = Convert.ToInt32(cbFirma.SelectedValue);

            kullanici.KullaniciEkleGuncelle();

            this.Close();
        }

        private void tcKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
                dgvKullaniciDonanimlar.ClearSelection();
                dgvDonanim.ClearSelection();

                btnDonanimSil.Enabled = false;
                btnDonanimEkle.Enabled = false;

                dgvKullaniciYazilimlar.ClearSelection();
                dgvYazilim.ClearSelection();

                btnYazilimEkle.Enabled = false;
                btnYazilimSil.Enabled = false;

                dgvLisans.ClearSelection();
                dgvKullaniciLisanslar.ClearSelection();

                btnLisansEkle.Enabled = false;
                btnLisansSil.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (sayac == 0) lblBilgi.Visible = true;

            sayac++;

            if (sayac > 4)
            {
                lblBilgi.Visible = false;
                sayac = 0;
                timer.Enabled = false;
            }
        }

        //////////////////////////////////////////////////
    }
}
