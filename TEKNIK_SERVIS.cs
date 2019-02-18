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
    public partial class TEKNIK_SERVIS : Form
    {
        public TEKNIK_SERVIS()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        TEKNIK_SERVIS_YENI_KAYIT TeknikServisYeniKayitForm;

        DataTable dt = new DataTable();
        DataTable arananDt = new DataTable();

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

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            TeknikServisYeniKayitForm = new TEKNIK_SERVIS_YENI_KAYIT(0,"","","","","",0,"","","","",0);
            TeknikServisYeniKayitForm.ShowDialog();

            dt = TeknikServisler.TeknikServisleriGetir(1);
            dgvTeknikServis.DataSource = dt;
            cbListelemeTuru.Text = "Servistekiler";

            btnAyrintiDuzenle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void btnAyrintiDuzenle_Click(object sender, EventArgs e)
        {
            TeknikServisYeniKayitForm = new TEKNIK_SERVIS_YENI_KAYIT(Convert.ToInt32(dgvTeknikServis.CurrentRow.Cells["KayitId"].Value), 
                dgvTeknikServis.CurrentRow.Cells["ÜRÜN NO"].Value.ToString(),
                dgvTeknikServis.CurrentRow.Cells["SERİ NO"].Value.ToString(),
                dgvTeknikServis.CurrentRow.Cells["FİRMA ADI"].Value.ToString(),
                dgvTeknikServis.CurrentRow.Cells["GÖNDERİM ŞEKLİ"].Value.ToString(),
                dgvTeknikServis.CurrentRow.Cells["SERVİS ŞEKLİ"].Value.ToString(),
                Convert.ToInt32(dgvTeknikServis.CurrentRow.Cells["DonanimId"].Value),
                dgvTeknikServis.CurrentRow.Cells["AKSESUAR"].Value.ToString(),
                dgvTeknikServis.CurrentRow.Cells["ŞİKAYET"].Value.ToString(),
                dgvTeknikServis.CurrentRow.Cells["TARİH"].Value.ToString(),
                dgvTeknikServis.CurrentRow.Cells["KARAR"].Value.ToString(),
                Convert.ToInt32(dgvTeknikServis.CurrentRow.Cells["DURUM"].Value)
                );
            TeknikServisYeniKayitForm.ShowDialog();

            dt = TeknikServisler.TeknikServisleriGetir(1);
            dgvTeknikServis.DataSource = dt;
            cbListelemeTuru.Text = "Servistekiler";

            btnAyrintiDuzenle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void TEKNIK_SERVIS_Load(object sender, EventArgs e)
        {
            btnAyrintiDuzenle.Enabled = false;
            btnSil.Enabled = false;
            bgw.RunWorkerAsync();
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            dt = TeknikServisler.TeknikServisleriGetir(1);

            gridDoldur();
        }

        private void gridDoldur()
        {
            if (dt.Columns.Count > 0)
            {
                dgvTeknikServis.DataSource = dt;

                dgvTeknikServis.Columns["KayitId"].Visible = false;
                dgvTeknikServis.Columns["DonanimId"].Visible = false;
                dgvTeknikServis.Columns["GÖNDERİM ŞEKLİ"].Visible = false;
                dgvTeknikServis.Columns["SERVİS ŞEKLİ"].Visible = false;
                dgvTeknikServis.Columns["FİRMA ADI"].Visible = false;
                dgvTeknikServis.Columns["DURUM"].Visible = false;
                dgvTeknikServis.Visible = true;
                cbListelemeTuru.SelectedIndex = cbListelemeTuru.FindString("Servistekiler");

                cbArananServisStunu.Items.Clear();
                for (int i = 1; i < dgvTeknikServis.Columns.Count; i++)
                {
                    if (dgvTeknikServis.Columns[i].Visible)
                        cbArananServisStunu.Items.Add(dgvTeknikServis.Columns[i].HeaderText);
                }
                cbArananServisStunu.SelectedItem = cbArananServisStunu.Items[0];
                btnYeniKayit.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sisteme Bağlanılamadı.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTeknikServis_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAyrintiDuzenle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void dgvTeknikServis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TeknikServisYeniKayitForm = new TEKNIK_SERVIS_YENI_KAYIT(Convert.ToInt32(dgvTeknikServis.CurrentRow.Cells["KayitId"].Value),
                dgvTeknikServis.CurrentRow.Cells["ÜRÜN NO"].Value.ToString(),
                dgvTeknikServis.CurrentRow.Cells["SERİ NO"].Value.ToString(),
                dgvTeknikServis.CurrentRow.Cells["FİRMA ADI"].Value.ToString(),
                dgvTeknikServis.CurrentRow.Cells["GÖNDERİM ŞEKLİ"].Value.ToString(),
                dgvTeknikServis.CurrentRow.Cells["SERVİS ŞEKLİ"].Value.ToString(),
                Convert.ToInt32(dgvTeknikServis.CurrentRow.Cells["DonanimId"].Value),
                dgvTeknikServis.CurrentRow.Cells["AKSESUAR"].Value.ToString(),
                dgvTeknikServis.CurrentRow.Cells["ŞİKAYET"].Value.ToString(),
                dgvTeknikServis.CurrentRow.Cells["TARİH"].Value.ToString(),
                dgvTeknikServis.CurrentRow.Cells["KARAR"].Value.ToString(),
                Convert.ToInt32(dgvTeknikServis.CurrentRow.Cells["DURUM"].Value)
                );
            TeknikServisYeniKayitForm.ShowDialog();

            dt = TeknikServisler.TeknikServisleriGetir(1);
            dgvTeknikServis.DataSource = dt;
            cbListelemeTuru.Text = "Servistekiler";

            btnAyrintiDuzenle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void dgvTeknikServis_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvTeknikServis.ClearSelection();
            GridRenklendir(dgvTeknikServis);

            lblServisSayisi.Text = dgvTeknikServis.Rows.Count.ToString();
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

        private void txtServisAra_TextChanged(object sender, EventArgs e)
        {
            if (txtServisAra.Text != "Ara...") //arama sonucuna dahil olmayan satırları gorunmez olsun:)
            {
                dgvTeknikServis.DataSource = Ara(txtServisAra.Text, dt, cbArananServisStunu.Text);
                lblServisSayisi.Text = dgvTeknikServis.Rows.Count.ToString();
            }
        }

        private void txtServisAra_Enter(object sender, EventArgs e)
        {
            if (txtServisAra.Text == "Ara...") txtServisAra.Text = "";
        }

        private void txtServisAra_Leave(object sender, EventArgs e)
        {
            if (txtServisAra.Text == "") txtServisAra.Text = "Ara...";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var soru = MessageBox.Show("Bu yazılımın bağlı olduğu lisanlar ve kullanıcılar olabilir.\n Yine de silinsin mi?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (soru == DialogResult.Yes)
            {
                TeknikServisler.TeknikServisSil(Convert.ToInt32(dgvTeknikServis.CurrentRow.Cells["KayitId"].Value));
                dt = TeknikServisler.TeknikServisleriGetir(1);
                dgvTeknikServis.DataSource = dt;
            }
        }

        private void cbListelemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbListelemeTuru.Text == "Servistekiler")
            {
                dt = TeknikServisler.TeknikServisleriGetir(1);
                dgvTeknikServis.DataSource = dt;
            }
            else if (cbListelemeTuru.Text == "Tümü")
            {
                dt = TeknikServisler.TeknikServisleriGetir(0);
                dgvTeknikServis.DataSource = dt;
            }

            btnAyrintiDuzenle.Enabled = false;
            btnSil.Enabled = false;
        }

    }
}
