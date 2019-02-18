using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TeknikServis.AyarFormlari;
using TeknikServis.Models;

namespace TeknikServis
{
    public partial class AYARLAR : Form
    {
        public AYARLAR()
        {
            InitializeComponent();
        }

        FIRMALAR FirmalarForm;
        DONANIM_TURLERI DonanimTurleriForm;
        LISANS_TIPLERI LisansTipleriForm;
        TEKNIK_SERVIS_FIRMALARI TeknikServisFirmalariForm;
        GONDERIM_SEKILLERI GonderimSekilleriForm;
        SERVIS_SEKILLERI ServisSekilleriForm;
        UYELER UyelerForm;

        int btnIndex = 0;
        DataTable dt = new DataTable();

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

        private void btnFirmalar_Click(object sender, EventArgs e) // tüm tuşlar tek eventte.
        {
            Button btn = (Button)sender;

            switch (btn.TabIndex)
            {
                case 2:
                    btnIndex = 2;
                    ls.Y1 = 126;
                    ls.Y2 = 126;
                    dt = Firmalar.FirmalariGetir();
                    dgvGenel.DataSource = dt;
                    dgvGenel.Columns["FirmaId"].Visible = false;
                    break;
                case 3:
                    btnIndex = 3;
                    ls.Y1 = 170;
                    ls.Y2 = 170;
                    dt = DonanimTurleri.DonanimTurleriniGetir();
                    dgvGenel.DataSource = dt;
                    dgvGenel.Columns["TurId"].Visible = false;
                    break;
                case 4:
                    btnIndex = 4;
                    ls.Y1 = 214;
                    ls.Y2 = 214;
                    dt = LisansTipleri.LisansTipleriniGetir();
                    dgvGenel.DataSource = dt;
                    dgvGenel.Columns["TipId"].Visible = false;
                    break;
                case 5:
                    btnIndex = 5;
                    ls.Y1 = 258;
                    ls.Y2 = 258;
                    dt = ServisFirmalari.ServisFirmalariniGetir();
                    dgvGenel.DataSource = dt;
                    dgvGenel.Columns["ServisFirmaId"].Visible = false;
                    break;
                case 6:
                    btnIndex = 6;
                    ls.Y1 = 302;
                    ls.Y2 = 302;
                    dt = GonderimSekilleri.GonderimSekilleriniGetir();
                    dgvGenel.DataSource = dt;
                    dgvGenel.Columns["GonderimSekliId"].Visible = false;
                    break;
                case 7:
                    btnIndex = 7;
                    ls.Y1 = 346;
                    ls.Y2 = 346;
                    dt = ServisSekilleri.ServisSekilleriniGetir();
                    dgvGenel.DataSource = dt;
                    dgvGenel.Columns["ServisSekliId"].Visible = false;
                    break;
                case 8:
                    btnIndex = 8;
                    ls.Y1 = 390;
                    ls.Y2 = 390;
                    dt = Uyeler.UyeleriGetir();
                    dgvGenel.DataSource = dt;
                    dgvGenel.Columns["UyeId"].Visible = false;
                    break;
                default:
                    MessageBox.Show("Yanlış işlem seçimi.", "HATA!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;
            }

            ls.Visible = true;

            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            btnYeni.Enabled = true;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            switch (btnIndex)
            {
                case 2:
                    FirmalarForm = new FIRMALAR(0,"","","","");
                    FirmalarForm.ShowDialog();
                    dt = Firmalar.FirmalariGetir();
                    dgvGenel.DataSource = dt;
                    break;
                case 3:
                    DonanimTurleriForm = new DONANIM_TURLERI(0,"");
                    DonanimTurleriForm.ShowDialog();
                    dt = DonanimTurleri.DonanimTurleriniGetir();
                    dgvGenel.DataSource = dt;
                    break;
                case 4:
                    LisansTipleriForm = new LISANS_TIPLERI(0,"");
                    LisansTipleriForm.ShowDialog();
                    dt = LisansTipleri.LisansTipleriniGetir();
                    dgvGenel.DataSource = dt;
                    break;
                case 5:
                    TeknikServisFirmalariForm = new TEKNIK_SERVIS_FIRMALARI(0,"","","","","","");
                    TeknikServisFirmalariForm.ShowDialog();
                    dt = ServisFirmalari.ServisFirmalariniGetir();
                    dgvGenel.DataSource = dt;
                    break;
                case 6:
                    GonderimSekilleriForm = new GONDERIM_SEKILLERI(0,"");
                    GonderimSekilleriForm.ShowDialog();
                    dt = GonderimSekilleri.GonderimSekilleriniGetir();
                    dgvGenel.DataSource = dt;
                    break;
                case 7:
                    ServisSekilleriForm = new SERVIS_SEKILLERI(0,"");
                    ServisSekilleriForm.ShowDialog();
                    dt = ServisSekilleri.ServisSekilleriniGetir();
                    dgvGenel.DataSource = dt;
                    break;
                case 8:
                    UyelerForm = new UYELER(0,"","","","","");
                    UyelerForm.ShowDialog();
                    dt = Uyeler.UyeleriGetir();
                    dgvGenel.DataSource = dt;
                    break;
                default:
                    MessageBox.Show("Yanlış işlem seçimi.", "HATA!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var soru = MessageBox.Show("Silmek istediğinize emin misiniz?","Uyarı!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (soru == DialogResult.Yes)
            {
                Sil();
            }
        }

        public void Guncelle()
        {
            switch (btnIndex)
            {
                case 2:
                    FirmalarForm = new FIRMALAR(
                        Convert.ToInt32(dgvGenel.CurrentRow.Cells["FirmaId"].Value),
                        dgvGenel.CurrentRow.Cells["FİRMALAR"].Value.ToString(),
                        dgvGenel.CurrentRow.Cells["ADRES"].Value.ToString(),
                        dgvGenel.CurrentRow.Cells["VERGİ DAİRESİ"].Value.ToString(),
                        dgvGenel.CurrentRow.Cells["VERGİ NUMARASI"].Value.ToString()
                        );
                    FirmalarForm.ShowDialog();
                    dt = Firmalar.FirmalariGetir();
                    dgvGenel.DataSource = dt;
                    break;
                case 3:
                    DonanimTurleriForm = new DONANIM_TURLERI(Convert.ToInt32(dgvGenel.CurrentRow.Cells["TurId"].Value), dgvGenel.CurrentRow.Cells["DONANIM TÜRLERİ"].Value.ToString());
                    DonanimTurleriForm.ShowDialog();
                    dt = DonanimTurleri.DonanimTurleriniGetir();
                    dgvGenel.DataSource = dt;
                    break;
                case 4:
                    LisansTipleriForm = new LISANS_TIPLERI(Convert.ToInt32(dgvGenel.CurrentRow.Cells["TipId"].Value), dgvGenel.CurrentRow.Cells["LİSANS TİPLERİ"].Value.ToString());
                    LisansTipleriForm.ShowDialog();
                    dt = LisansTipleri.LisansTipleriniGetir();
                    dgvGenel.DataSource = dt;
                    break;
                case 5:
                    TeknikServisFirmalariForm = new TEKNIK_SERVIS_FIRMALARI(Convert.ToInt32(dgvGenel.CurrentRow.Cells["ServisFirmaId"].Value), dgvGenel.CurrentRow.Cells["FİRMA ADI"].Value.ToString(), dgvGenel.CurrentRow.Cells["ADRES"].Value.ToString(), dgvGenel.CurrentRow.Cells["TEL"].Value.ToString(), dgvGenel.CurrentRow.Cells["FAX"].Value.ToString(), dgvGenel.CurrentRow.Cells["GSM"].Value.ToString(), dgvGenel.CurrentRow.Cells["E-MAİL"].Value.ToString());
                    TeknikServisFirmalariForm.ShowDialog();
                    dt = ServisFirmalari.ServisFirmalariniGetir();
                    dgvGenel.DataSource = dt;
                    break;
                case 6:
                    GonderimSekilleriForm = new GONDERIM_SEKILLERI(Convert.ToInt32(dgvGenel.CurrentRow.Cells["GonderimSekliId"].Value), dgvGenel.CurrentRow.Cells["GÖNDERİM ŞEKİLLERİ"].Value.ToString());
                    GonderimSekilleriForm.ShowDialog();
                    dt = GonderimSekilleri.GonderimSekilleriniGetir();
                    dgvGenel.DataSource = dt;
                    break;
                case 7:
                    ServisSekilleriForm = new SERVIS_SEKILLERI(Convert.ToInt32(dgvGenel.CurrentRow.Cells["ServisSekliId"].Value), dgvGenel.CurrentRow.Cells["SERVİS ŞEKİLLERİ"].Value.ToString());
                    ServisSekilleriForm.ShowDialog();
                    dt = ServisSekilleri.ServisSekilleriniGetir();
                    dgvGenel.DataSource = dt;
                    break;
                case 8:
                    UyelerForm = new UYELER(Convert.ToInt32(dgvGenel.CurrentRow.Cells["UyeId"].Value), dgvGenel.CurrentRow.Cells["ROL"].Value.ToString(), dgvGenel.CurrentRow.Cells["AD"].Value.ToString(), dgvGenel.CurrentRow.Cells["SOYAD"].Value.ToString(), dgvGenel.CurrentRow.Cells["KULLANICI ADI"].Value.ToString(), dgvGenel.CurrentRow.Cells["ŞİFRE"].Value.ToString());
                    UyelerForm.ShowDialog();
                    dt = Uyeler.UyeleriGetir();
                    dgvGenel.DataSource = dt;
                    break;
                default:
                    MessageBox.Show("Yanlış işlem seçimi.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public void Sil()
        {
            switch (btnIndex)
            {
                case 2:
                    if (Firmalar.FirmaSil(Convert.ToInt32(dgvGenel.CurrentRow.Cells["FirmaId"].Value)) == 0)
                    {
                        MessageBox.Show("Bu firmaya ait donanımlar var.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dt = Firmalar.FirmalariGetir();
                    dgvGenel.DataSource = dt;
                    break;
                case 3:
                    if (DonanimTurleri.DonanimTuruSil(Convert.ToInt32(dgvGenel.CurrentRow.Cells["TurId"].Value)) == 0)
                    {
                        MessageBox.Show("Bu donanım türüne ait donanımlar var.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dt = DonanimTurleri.DonanimTurleriniGetir();
                    dgvGenel.DataSource = dt;
                    break;
                case 4:
                    if (LisansTipleri.LisasnTipiSil(Convert.ToInt32(dgvGenel.CurrentRow.Cells["TipId"].Value)) == 0)
                    {
                        MessageBox.Show("Bu lisans tipinde tanımlanmış lisanslar var.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dt = LisansTipleri.LisansTipleriniGetir();
                    dgvGenel.DataSource = dt;
                    break;
                case 5:
                    ServisFirmalari.ServisFirmasiSil(Convert.ToInt32(dgvGenel.CurrentRow.Cells["ServisFirmaId"].Value));
                    dt = ServisFirmalari.ServisFirmalariniGetir();
                    dgvGenel.DataSource = dt;
                    break;
                case 6:
                    if (GonderimSekilleri.GonderimSekliSil(Convert.ToInt32(dgvGenel.CurrentRow.Cells["GonderimSekliId"].Value)) == 0)
                    {
                        MessageBox.Show("Bu gönderim şeklinde tanımlanmış teknik servis kayıtları var.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dt = GonderimSekilleri.GonderimSekilleriniGetir();
                    dgvGenel.DataSource = dt;
                    break;
                case 7:
                    if (ServisSekilleri.ServisSekliSil(Convert.ToInt32(dgvGenel.CurrentRow.Cells["ServisSekliId"].Value)) == 0)
                    {
                        MessageBox.Show("Bu servis şeklinde tanımlanmış teknik servis kayıtları var.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dt = ServisSekilleri.ServisSekilleriniGetir();
                    dgvGenel.DataSource = dt;
                    break;
                case 8:
                    Uyeler.UyeSil(Convert.ToInt32(dgvGenel.CurrentRow.Cells["UyeId"].Value));
                    dt = Uyeler.UyeleriGetir();
                    dgvGenel.DataSource = dt;
                    break;
                default:
                    MessageBox.Show("Yanlış işlem seçimi.", "HATA!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;
            }
        }

        private void dgvGenel_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnSil.Enabled = true;
            btnGuncelle.Enabled = true;
        }

        private void dgvGenel_DoubleClick(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void dgvGenel_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvGenel.ClearSelection();
            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
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

        private void btnYedekle_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            pBar.Visible = true;
            bgw.RunWorkerAsync();
        }

        private void btnYedekYukle_Click(object sender, EventArgs e)
        {
            var soru = MessageBox.Show("Var olan veritabanını kaldırıp, yerine yedeği kurmak istediğinize\nemin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (soru == DialogResult.Yes)
            {
                timer.Enabled = true;
                pBar.Visible = true;
                bgw2.RunWorkerAsync();
            }
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            string sqlQuery = "";

            sqlQuery = @" BACKUP DATABASE BilgiIslem TO DISK = N'C:\\BilgiIslem.bak' WITH INIT";

            if (Dal.BackUpOrRestore(sqlQuery))
            {
                timer.Enabled = false;
                MessageBox.Show("Veritabanı yedeklendi. (C:\\BilgiIslem.bak)", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                timer.Enabled = false;
                MessageBox.Show("Veritabanı yedeklenemedi.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pBar.Visible = false;
            pBar.Value = 0;
            dt.Clear();
            dgvGenel.DataSource = dt;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pBar.Value >= 100) pBar.Value = 0;
            else pBar.Value += 5;
        }

        private void bgw2_DoWork(object sender, DoWorkEventArgs e)
        {
            string sqlQuery = "";

            sqlQuery = @" USE [master] RESTORE DATABASE BilgiIslem FROM DISK = N'C:\\BilgiIslem.bak' WITH RECOVERY";

            if (Dal.BackUpOrRestore(sqlQuery))
            {
                timer.Enabled = false;
                MessageBox.Show("Veritabanı yüklendi. (C:\\BilgiIslem.bak)", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                timer.Enabled = false;
                MessageBox.Show("Veritabanı yüklenemedi.\nYedeğin doğru dizinde(C:\\BilgiIslem.bak) olduğundan emin olun.\nVeritabanı kullanımda olabilir.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
