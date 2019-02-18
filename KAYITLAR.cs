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
    public partial class KAYITLAR : Form
    {
        public KAYITLAR()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        YENI_KISI YeniKisiForm;
        KISILER_AYRINTI_DUZENLE KisilerAyrintiDuzenleForm;
        YENI_DONANIM YeniDonanimForm;
        YENI_YAZILIM YeniYazilimForm;
        YENI_LISANS YeniLisansForm;

        DataTable dtYazilim = new DataTable();
        DataTable dtDonanim = new DataTable();
        DataTable dtLisans = new DataTable();
        DataTable dtKullanici = new DataTable();
        DataTable arananDt = new DataTable();

        Boolean LisanslarTiklandi = false;
        Boolean YazilimlarTiklandi = false;
        Boolean DonanimlarTiklandi = false;
        Boolean KullanicilarTiklandi = false;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                cp.ClassStyle |= 0x20000;

                cp.ExStyle |= 0x02000000;

                return cp;
            }
        }

        //////////////////////////////////////////////////////
        /////////////// YAZILIMLAR ///////////////////////////

        private void btnYeniYazilim_Click(object sender, EventArgs e)
        {
            YeniYazilimForm = new YENI_YAZILIM(0, "", 0, "");
            YeniYazilimForm.ShowDialog();

            dtYazilim = Yazilimlar.YazilimlariGetir(0);
            dgvYazilim.DataSource = dtYazilim;

            btnYazilimSil.Enabled = false;
            btnYazilimAyrintiDuzenle.Enabled = false;
        }

        private void btnYazilimAyrintiDuzenle_Click(object sender, EventArgs e)
        {
            YeniYazilimForm = new YENI_YAZILIM(Convert.ToInt32(dgvYazilim.CurrentRow.Cells["YazilimId"].Value), dgvYazilim.CurrentRow.Cells["YAZILIM ADI"].Value.ToString(), Convert.ToInt32(dgvYazilim.CurrentRow.Cells["LİSANS SAYISI"].Value), dgvYazilim.CurrentRow.Cells["GÜNCELLEME TARİHİ"].Value.ToString());
            YeniYazilimForm.ShowDialog();
            dtYazilim = Yazilimlar.YazilimlariGetir(0);
            dgvYazilim.DataSource = dtYazilim;

            btnYazilimAyrintiDuzenle.Enabled = false;
            btnYazilimSil.Enabled = false;
        }

        private void tpYazilim_Enter(object sender, EventArgs e)
        {
            if (YazilimlarTiklandi == false)
            {
                dtYazilim = Yazilimlar.YazilimlariGetir(0);
                dgvYazilim.DataSource = dtYazilim;
                dgvYazilim.Columns["YazilimId"].Visible = false;

                btnYazilimSil.Enabled = false;
                btnYazilimAyrintiDuzenle.Enabled = false;

                cbArananYazilimStunu.Items.Clear();
                for (int i = 1; i < dgvYazilim.Columns.Count; i++)
                {
                    cbArananYazilimStunu.Items.Add(dgvYazilim.Columns[i].HeaderText);
                }
                cbArananYazilimStunu.SelectedItem = cbArananYazilimStunu.Items[0];

                lblYazilimSayisi.Text = dgvYazilim.Rows.Count.ToString();

                YazilimlarTiklandi = true;
            }
            dgvYazilim.ClearSelection();
        }

        private void dgvYazilim_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnYazilimSil.Enabled = true;
            btnYazilimAyrintiDuzenle.Enabled = true;
        }

        private void dgvYazilim_DoubleClick(object sender, EventArgs e)
        {
            YeniYazilimForm = new YENI_YAZILIM(Convert.ToInt32(dgvYazilim.CurrentRow.Cells["YazilimId"].Value), dgvYazilim.CurrentRow.Cells["YAZILIM ADI"].Value.ToString(), Convert.ToInt32(dgvYazilim.CurrentRow.Cells["LİSANS SAYISI"].Value), dgvYazilim.CurrentRow.Cells["GÜNCELLEME TARİHİ"].Value.ToString());
            YeniYazilimForm.ShowDialog();
            dtYazilim = Yazilimlar.YazilimlariGetir(0);
            dgvYazilim.DataSource = dtYazilim;
        }

        private void btnYazilimSil_Click(object sender, EventArgs e)
        {
            var soru = MessageBox.Show("Bu yazılımın bağlı olduğu lisanlar ve kullanıcılar olabilir.\nYine de silinsin mi?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (soru == DialogResult.Yes)
            {
                Yazilimlar.YazilimSil(Convert.ToInt32(dgvYazilim.CurrentRow.Cells["YazilimId"].Value));
                dtYazilim = Yazilimlar.YazilimlariGetir(0);
                dgvYazilim.DataSource = dtYazilim;
            }
        }

        //////////////////////////////////////////////////////
        ////////////////// LİSANS ////////////////////////////

        private void btnYeniLisans_Click(object sender, EventArgs e)
        {
            YeniLisansForm = new YENI_LISANS(0, "", "", "", "", "", 0);
            YeniLisansForm.ShowDialog();

            dtLisans = Lisanslar.LisanslariGetir(0);
            dgvLisans.DataSource = dtLisans;

            btnLisansSil.Enabled = false;
            btnLisansAyrintiDuzenle.Enabled = false;
        }

        private void btnLisansAyrintiDuzenle_Click(object sender, EventArgs e)
        {
            YeniLisansForm = new YENI_LISANS(Convert.ToInt32(dgvLisans.CurrentRow.Cells["LisansId"].Value), dgvLisans.CurrentRow.Cells["YAZILIM ADI"].Value.ToString(), dgvLisans.CurrentRow.Cells["TİP ADI"].Value.ToString(), dgvLisans.CurrentRow.Cells["LİSANS KEY"].Value.ToString(), dgvLisans.CurrentRow.Cells["LİSANS NO"].Value.ToString(), dgvLisans.CurrentRow.Cells["LİSANS ADI"].Value.ToString(), Convert.ToInt32(dgvLisans.CurrentRow.Cells["LİSANS SAYISI"].Value));
            YeniLisansForm.ShowDialog();

            dtLisans = Lisanslar.LisanslariGetir(0);
            dgvLisans.DataSource = dtLisans;

            btnLisansSil.Enabled = false;
            btnLisansAyrintiDuzenle.Enabled = false;
        }

        private void tpLisans_Enter(object sender, EventArgs e)
        {
            if (LisanslarTiklandi == false)
            {
                dtLisans = Lisanslar.LisanslariGetir(0);
                dgvLisans.DataSource = dtLisans;
                dgvLisans.Columns["LisansId"].Visible = false;
                dgvLisans.Columns["KullaniciId"].Visible = false;
                dgvLisans.Columns["TipId"].Visible = false;
                dgvLisans.Columns["YazilimId"].Visible = false;

                btnLisansSil.Enabled = false;
                btnLisansAyrintiDuzenle.Enabled = false;

                cbArananLisansStunu.Items.Clear();
                for (int i = 1; i < dgvLisans.Columns.Count - 3; i++)
                {
                    cbArananLisansStunu.Items.Add(dgvLisans.Columns[i].HeaderText);
                }
                cbArananLisansStunu.SelectedItem = cbArananLisansStunu.Items[0];

                lblLisansSayisi.Text = dgvLisans.Rows.Count.ToString();

                LisanslarTiklandi = true;
            }
            dgvLisans.ClearSelection();
        }

        private void dgvLisans_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnLisansSil.Enabled = true;
            btnLisansAyrintiDuzenle.Enabled = true;
        }

        private void btnLisansSil_Click(object sender, EventArgs e)
        {
            var soru = MessageBox.Show("Bu lisans kullanıcı veya yazılım için atanmış olabilir.\nYine de silinsin mi?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (soru == DialogResult.Yes)
            {
                Lisanslar.LisansSil(Convert.ToInt32(dgvLisans.CurrentRow.Cells["LisansId"].Value));

                dtLisans = Lisanslar.LisanslariGetir(0);
                dgvLisans.DataSource = dtLisans;
            }
        }

        private void dgvLisans_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            YeniLisansForm = new YENI_LISANS(Convert.ToInt32(dgvLisans.CurrentRow.Cells["LisansId"].Value), dgvLisans.CurrentRow.Cells["YAZILIM ADI"].Value.ToString(), dgvLisans.CurrentRow.Cells["TİP ADI"].Value.ToString(), dgvLisans.CurrentRow.Cells["LİSANS KEY"].Value.ToString(), dgvLisans.CurrentRow.Cells["LİSANS NO"].Value.ToString(), dgvLisans.CurrentRow.Cells["LİSANS ADI"].Value.ToString(), Convert.ToInt32(dgvLisans.CurrentRow.Cells["LİSANS SAYISI"].Value));
            YeniLisansForm.ShowDialog();

            dtLisans = Lisanslar.LisanslariGetir(0);
            dgvLisans.DataSource = dtLisans;

            btnLisansSil.Enabled = false;
            btnLisansAyrintiDuzenle.Enabled = false;
        }

        //////////////////////////////////////////////////////
        ///////////////// DONANIM ////////////////////////////

        private void btnYeniDonanim_Click(object sender, EventArgs e)
        {
            YeniDonanimForm = new YENI_DONANIM(0,"","");
            YeniDonanimForm.ShowDialog();

            dtDonanim = Donanimlar.DonanimlariGetir(0);
            dgvDonanim.DataSource = dtDonanim;

            btnDonanimSil.Enabled = false;
            btnDonanimAyrintiDuzenle.Enabled = false;
        }

        private void btnDonanimAyrintiDuzenle_Click(object sender, EventArgs e)
        {
            YeniDonanimForm = new YENI_DONANIM(Convert.ToInt32(dgvDonanim.CurrentRow.Cells["DonanimId"].Value),dgvDonanim.CurrentRow.Cells["FİRMA"].Value.ToString(), dgvDonanim.CurrentRow.Cells["TÜR"].Value.ToString());
            YeniDonanimForm.ShowDialog();

            dtDonanim = Donanimlar.DonanimlariGetir(0);
            dgvDonanim.DataSource = dtDonanim;

            btnDonanimSil.Enabled = false;
            btnDonanimAyrintiDuzenle.Enabled = false;
        }

        private void tpDonanim_Enter(object sender, EventArgs e)
        {
            if (DonanimlarTiklandi == false)
            {
                dtDonanim = Donanimlar.DonanimlariGetir(0);
                dgvDonanim.DataSource = dtDonanim;
                dgvDonanim.Columns["DonanimId"].Visible = false;

                btnDonanimSil.Enabled = false;
                btnDonanimAyrintiDuzenle.Enabled = false;

                cbArananDonanimStunu.Items.Clear();
                for (int i = 1; i < dgvDonanim.Columns.Count; i++)
                {
                    cbArananDonanimStunu.Items.Add(dgvDonanim.Columns[i].HeaderText);
                }
                cbArananDonanimStunu.SelectedItem = cbArananDonanimStunu.Items[0];

                lblDonanimSayisi.Text = dgvDonanim.Rows.Count.ToString();

                DonanimlarTiklandi = true;
            }
            dgvDonanim.ClearSelection();
        }

        private void dgvDonanim_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDonanimSil.Enabled = true;
            btnDonanimAyrintiDuzenle.Enabled = true;
        }

        private void dgvDonanim_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            YeniDonanimForm = new YENI_DONANIM(Convert.ToInt32(dgvDonanim.CurrentRow.Cells["DonanimId"].Value), dgvDonanim.CurrentRow.Cells["FİRMA"].Value.ToString(), dgvDonanim.CurrentRow.Cells["TÜR"].Value.ToString());
            YeniDonanimForm.ShowDialog();

            dtDonanim = Donanimlar.DonanimlariGetir(0);
            dgvDonanim.DataSource = dtDonanim;

            btnDonanimSil.Enabled = false;
            btnDonanimAyrintiDuzenle.Enabled = false;
        }

        private void btnDonanimSil_Click(object sender, EventArgs e)
        {
            var soru = MessageBox.Show("Bu donanım kullanıcıya atanmış olabilir.\nYine de silinsin mi?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (soru == DialogResult.Yes)
            {
                Donanimlar.DonanimSil(Convert.ToInt32(dgvDonanim.CurrentRow.Cells["DonanimId"].Value));

                dtDonanim = Donanimlar.DonanimlariGetir(0);
                dgvDonanim.DataSource = dtDonanim;
            }
        }

        //////////////////////////////////////////////////////
        ///////////////// KİSİLER ////////////////////////////

        private void btnYeniKisi_Click(object sender, EventArgs e)
        {
            YeniKisiForm = new YENI_KISI();
            YeniKisiForm.ShowDialog();

            dtKullanici = Kullanicilar.KullanicilariGetir();
            dgvKullanici.DataSource = dtKullanici;

            btnKullaniciSil.Enabled = false;
            btnAyrintiDuzenle.Enabled = false;
        }

        private void btnAyrintiDuzenle_Click(object sender, EventArgs e)
        {
            KisilerAyrintiDuzenleForm = new KISILER_AYRINTI_DUZENLE(Convert.ToInt32(dgvKullanici.CurrentRow.Cells["KullaniciId"].Value), dgvKullanici.CurrentRow.Cells["FİRMA"].Value.ToString(), dgvKullanici.CurrentRow.Cells["DEPARTMAN"].Value.ToString(), dgvKullanici.CurrentRow.Cells["AD"].Value.ToString(), dgvKullanici.CurrentRow.Cells["SOYAD"].Value.ToString(), dgvKullanici.CurrentRow.Cells["DOMAIN ADI"].Value.ToString());
            KisilerAyrintiDuzenleForm.ShowDialog();

            dtKullanici = Kullanicilar.KullanicilariGetir();
            dgvKullanici.DataSource = dtKullanici;

            btnKullaniciSil.Enabled = false;
            btnAyrintiDuzenle.Enabled = false;
        }

        private void KAYITLAR_Shown(object sender, EventArgs e)
        {
            bgw.RunWorkerAsync();
        }

        private void tpKullanicilar_Enter(object sender, EventArgs e)
        {
            if (KullanicilarTiklandi)
            {
                btnAyrintiDuzenle.Enabled = false;
                btnKullaniciSil.Enabled = false;
            }
            KullanicilarTiklandi = true;
        }

        private void dgvKullanici_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnKullaniciSil.Enabled = true;
            btnAyrintiDuzenle.Enabled = true;
        }

        private void dgvKullanici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            KisilerAyrintiDuzenleForm = new KISILER_AYRINTI_DUZENLE(Convert.ToInt32(dgvKullanici.CurrentRow.Cells["KullaniciId"].Value), dgvKullanici.CurrentRow.Cells["FİRMA"].Value.ToString(), dgvKullanici.CurrentRow.Cells["DEPARTMAN"].Value.ToString(), dgvKullanici.CurrentRow.Cells["AD"].Value.ToString(), dgvKullanici.CurrentRow.Cells["SOYAD"].Value.ToString(), dgvKullanici.CurrentRow.Cells["DOMAIN ADI"].Value.ToString());
            KisilerAyrintiDuzenleForm.ShowDialog();

            dtKullanici = Kullanicilar.KullanicilariGetir();
            dgvKullanici.DataSource = dtKullanici;

            btnKullaniciSil.Enabled = false;
            btnAyrintiDuzenle.Enabled = false;
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            var soru = MessageBox.Show("Bu kullanıcıyı silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (soru == DialogResult.Yes)
            {
                Kullanicilar.KullaniciSil(Convert.ToInt32(dgvKullanici.CurrentRow.Cells["KullaniciId"].Value));

                dtKullanici = Kullanicilar.KullanicilariGetir();
                dgvKullanici.DataSource = dtKullanici;
            }
        }

        //////////////////////////////////////////////////////
        ////////////////// ORTAK /////////////////////////////

        private void txtKullaniciAra_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text != "Ara...") //arama sonucuna dahil olmayan satırları gorunmez olsun:)
            {
                if (txt.Name == "txtKullaniciAra")
                {
                    dgvKullanici.DataSource = Ara(txtKullaniciAra.Text, dtKullanici, cbArananKullaniciStunu.Text);
                    lblKullaniciSayisi.Text = dgvKullanici.Rows.Count.ToString();
                }
                if (txt.Name == "txtDonanimAra")
                {
                    dgvDonanim.DataSource = Ara(txtDonanimAra.Text, dtDonanim, cbArananDonanimStunu.Text);
                    lblDonanimSayisi.Text = dgvDonanim.Rows.Count.ToString();
                }
                if (txt.Name == "txtYazilimAra")
                {
                    dgvYazilim.DataSource = Ara(txtYazilimAra.Text, dtYazilim, cbArananYazilimStunu.Text);
                    lblYazilimSayisi.Text = dgvYazilim.Rows.Count.ToString();
                }
                else
                {
                    dgvLisans.DataSource = Ara(txtLisansAra.Text, dtLisans, cbArananLisansStunu.Text);
                    lblLisansSayisi.Text = dgvLisans.Rows.Count.ToString();
                }
            }
        }

        private void txtKullaniciAra_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text == "Ara...") txt.Text = "";
        }

        private void txtKullaniciAra_Leave(object sender, EventArgs e)
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

        private void dgvLisans_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvYazilim.ClearSelection();
            dgvLisans.ClearSelection();
            dgvKullanici.ClearSelection();
            dgvDonanim.ClearSelection();

            DataGridView dgv = (DataGridView)sender;
            if (dgv.Name == "dgvKullanici")
                GridRenklendir(dgvKullanici);
            else if(dgv.Name == "dgvYazilim")
                GridRenklendir(dgvYazilim);
            else if (dgv.Name == "dgvDonanim")
                GridRenklendir(dgvDonanim);
            else
                GridRenklendir(dgvLisans);
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

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            dtKullanici = Kullanicilar.KullanicilariGetir();

            dgvKullanici.DataSource = dtKullanici;
            dgvKullanici.Columns["KullaniciId"].Visible = false;
            dgvKullanici.Columns["FirmaId"].Visible = false;
            dgvKullanici.Visible = true;

            cbArananKullaniciStunu.Items.Clear();
            for (int i = 1; i < dgvKullanici.Columns.Count - 1; i++)
            {
                cbArananKullaniciStunu.Items.Add(dgvKullanici.Columns[i].HeaderText);
            }
            cbArananKullaniciStunu.SelectedItem = cbArananKullaniciStunu.Items[0];

            lblKullaniciSayisi.Text = dgvKullanici.Rows.Count.ToString();

            dgvKullanici.ClearSelection();
        }

        //////////////////////////////////////////////////////
    }
}
