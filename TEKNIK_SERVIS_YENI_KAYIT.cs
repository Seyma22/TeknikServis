using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TeknikServis.Models;
using System.IO;

namespace TeknikServis
{
    public partial class TEKNIK_SERVIS_YENI_KAYIT : Form
    {
        int id;
        int _donanimId;
        int _durum;
        string _urunNo;
        string _seriNo;
        string _firmaAdi;
        string _gonderimSekli;
        string _servisSekli;
        string _aksesuar;
        string _sikayet;
        string _tarih;
        string _karar;
        Boolean ilkGiris = true;
        byte[] byteResim = null;

        DataTable dt = new DataTable();

        public TEKNIK_SERVIS_YENI_KAYIT(int bilgi,
            string urunNo,
            string seriNo,
            string firmaAdi,
            string gonderimSekli,
            string servisSekli,
            int donanimId,
            string aksesuar,
            string sikayet,
            string tarih,
            string karar,
            int durum
            )
        {
            InitializeComponent();

            if (bilgi != 0)
            {
                this.Text = "Teknik Servis Kayıt Bilgileri";
                _urunNo = urunNo;
                _seriNo = seriNo;
                _firmaAdi = firmaAdi;
                _gonderimSekli = gonderimSekli;
                _servisSekli = servisSekli;
                _donanimId = donanimId;
                _aksesuar = aksesuar;
                _sikayet = sikayet;
                _tarih = tarih;
                _karar = karar;
                _durum = durum;
            }

            id=bilgi;
        }

        private void TEKNIK_SERVIS_YENI_KAYIT_Load(object sender, EventArgs e)
        {
            this.Location = new Point(220, 50);

            dt = GonderimSekilleri.GonderimSekilleriniGetir();
            cbGonderimSekli.DataSource = dt;
            cbGonderimSekli.DisplayMember = "GÖNDERİM ŞEKİLLERİ";
            cbGonderimSekli.ValueMember = "GonderimSekliId";
            cbGonderimSekli.SelectedValue = false;

            dt = ServisSekilleri.ServisSekilleriniGetir();
            cbServisSekli.DataSource = dt;
            cbServisSekli.DisplayMember = "SERVİS ŞEKİLLERİ";
            cbServisSekli.ValueMember = "ServisSekliId";
            cbServisSekli.SelectedValue = false;

            dt = ServisFirmalari.ServisFirmalariniGetir();
            cbFirmaAdi.DataSource = dt;
            cbFirmaAdi.DisplayMember = "FİRMA ADI";
            cbFirmaAdi.ValueMember = "ServisFirmaId";
            cbFirmaAdi.SelectedValue = false;

            ilkGiris = false;
            rbServiste.Checked = true;

            if (id != 0)
            {
                gbAranan.Enabled = false;
                gbAranan.Visible = false;
                gbDonanimBilgileri.Location = new Point(12, 11);
                gbServisBilgileri.Location = new Point(311, 11);
                gbFatura.Location = new Point(311, 287);
                btnYazdir.Location = new Point(406, 495);
                btnKaydet.Location = new Point(542, 495);
                btnVazgec.Location = new Point(474, 495);
                this.Height = 570;

                cbFirmaAdi.SelectedIndex = cbFirmaAdi.FindString(_firmaAdi);
                cbGonderimSekli.SelectedIndex = cbGonderimSekli.FindString(_gonderimSekli);
                cbServisSekli.SelectedIndex = cbServisSekli.FindString(_servisSekli);
                DonanimGetir(_urunNo, _seriNo);
                txtAksesuar.Text = _aksesuar;
                txtKarar.Text = _karar;
                txtSikayet.Text = _sikayet;
                if (_durum == 0) rbGeldi.Checked = true;
                bgw.RunWorkerAsync();
                dtpTarih.Text = _tarih;
            }
            else
            {
                btnKaydet.Enabled = false;
                btnYazdir.Enabled = false;
            }
        }

        private void FaturaResmiGetir()
        {
            Image FaturaResim = null;
            
            dt = TeknikServisler.TeknikServisFaturaResmiGetir(id);

            byte[] resim = dt.Rows[0].Field<byte[]>("FaturaResmi"); //Okuyucu ile üzerine tıkladığımız üyenin resmini byte dizisi tanımlayıp içine atıyoruz.

            if (resim != null)
            {
                byteResim = resim; // bu değişken de set edilmeli.

                MemoryStream ms = new MemoryStream(resim, 0, resim.Length); // System.IO isim uzayı altındaki MemoryStream sınıfıyla oluşturduğumuz byte dizisi için bir akım oluşturuyoruz.

                ms.Write(resim, 0, resim.Length);

                FaturaResim = Image.FromStream(ms, true); // Oluşturduğumuz akım üzerinden aldığımızı image imize atıyoruz.

                pbFatura.Image = FaturaResim;
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDonanimGetir_Click(object sender, EventArgs e)
        {
            DonanimGetir(txtUrunNo.Text, txtSeriNoAranan.Text);
        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cbGonderimSekli.Text != "" && cbServisSekli.Text != "" && cbFirmaAdi.Text != "")
                Ekle();
            else
                MessageBox.Show("Gönderim şekli, servis şekli ve servis firması boş bırakılamaz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Ekle()
        {
            TeknikServisler servisKaydi = new TeknikServisler();
            servisKaydi.Aksesuar = txtAksesuar.Text;
            servisKaydi.DonanimId = _donanimId;
            servisKaydi.GonderimSekliId = Convert.ToInt32(cbGonderimSekli.SelectedValue);
            servisKaydi.Karar = txtKarar.Text;
            servisKaydi.KayitId = id;
            servisKaydi.ServisFirmaId = Convert.ToInt32(cbFirmaAdi.SelectedValue);
            servisKaydi.ServisSekliId = Convert.ToInt32(cbServisSekli.SelectedValue);
            servisKaydi.Sikayet = txtSikayet.Text;
            servisKaydi.Tarih = dtpTarih.Value.ToString("yyyy-MM-dd");
            servisKaydi.FaturaResmi = byteResim;
            if (rbGeldi.Checked == true)
                servisKaydi.Durum = 0;
            else
                servisKaydi.Durum = 1;

            servisKaydi.TeknikServisEkleGuncelle();

            this.Close();
        }

        private void cbFirmaAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ilkGiris)
            {
                dt = ServisFirmalari.ServisFirmasiGetirServisFirmaIdIle(Convert.ToInt32(cbFirmaAdi.SelectedValue));
                txtAdres.Text = dt.Rows[0].Field<string>("ADRES").ToString();
                txtEmail.Text = dt.Rows[0].Field<string>("E-MAİL").ToString();
                txtFax.Text = dt.Rows[0].Field<string>("FAX").ToString();
                txtGsm.Text = dt.Rows[0].Field<string>("GSM").ToString();
                txtTel.Text = dt.Rows[0].Field<string>("TEL").ToString();
            }
        }

        public void DonanimGetir(string urunNo,string seriNo)
        {
            dt = Donanimlar.DonanimGetirUrunNoSeriNoIle(urunNo, seriNo);

            if (dt.Rows.Count == 1)
            {
                txtTur.Text = dt.Rows[0].Field<string>("TÜR").ToString();
                txtMarka.Text = dt.Rows[0].Field<string>("MARKA").ToString();
                txtModel.Text = dt.Rows[0].Field<string>("MODEL").ToString();
                txtSeriNo.Text = dt.Rows[0].Field<string>("SERİ NO").ToString();
                txtFirma.Text = dt.Rows[0].Field<string>("FİRMA").ToString();
                _donanimId = Convert.ToInt32(dt.Rows[0].Field<long>("DonanimId"));

                btnKaydet.Enabled = true;
                btnYazdir.Enabled = true;
            }
            else
            {
                MessageBox.Show("Bu ürün numarası ve seri numarasına ait donanım bulunamadı.\nDonanımın sistemde kayıtlı olduğundan emin olun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtTur.Text = "";
                txtMarka.Text = "";
                txtModel.Text = "";
                txtSeriNo.Text = "";
                txtFirma.Text = "";
                _donanimId = 0;

                btnKaydet.Enabled = false;
                btnYazdir.Enabled = false;
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (cbGonderimSekli.Text != "" && cbServisSekli.Text != "" && cbFirmaAdi.Text != "")
                Yazdir();
            else
                MessageBox.Show("Gönderim şekli, servis şekli ve servis firması boş bırakılamaz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Yazdir()
        {
            string prntTitle = "";
            DataTable dt = new DataTable();
            DataTable dtFirma = new DataTable();
            DataColumn dc;
            DataRow dr;

            dtFirma = Firmalar.FirmaGetirDonanimIdIle(_donanimId);

            //1. stun
            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "baslik";
            dt.Columns.Add(dc);

            //2. stun
            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "bilgi";
            dt.Columns.Add(dc);

            //Satırlar
            dr = dt.NewRow();
            dr["baslik"] = "FİRMA BİLGİLERİ";
            dr["bilgi"] = ".";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = "Firma Adı  :";
            dr["bilgi"] = cbFirmaAdi.Text;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = "Adres  :";
            if (txtAdres.Text == "") dr["bilgi"] = ".";
            else dr["bilgi"] = txtAdres.Text;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = "Telefon  :";
            if (txtTel.Text == "") dr["bilgi"] = ".";
            else dr["bilgi"] = txtTel.Text;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = "Fax  :";
            if (txtFax.Text == "") dr["bilgi"] = ".";
            else dr["bilgi"] = txtFax.Text;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = "Gsm  :";
            if (txtGsm.Text == "") dr["bilgi"] = ".";
            else dr["bilgi"] = txtGsm.Text;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = "E-mail  :";
            if (txtEmail.Text == "") dr["bilgi"] = ".";
            else dr["bilgi"] = txtEmail.Text;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = ".";
            dr["bilgi"] = ".";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = "DONANIM BİLGİLERİ";
            dr["bilgi"] = ".";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = "Tür  :";
            dr["bilgi"] = txtTur.Text;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = "Marka  :";
            dr["bilgi"] = txtMarka.Text;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = "Model  :";
            dr["bilgi"] = txtModel.Text;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = "Seri No  :";
            dr["bilgi"] = txtSeriNo.Text;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = "Firma  :";
            dr["bilgi"] = txtFirma.Text;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = "Adres  :";
            dr["bilgi"] = dtFirma.Rows[0].Field<string>("ADRES").ToString();
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = "Vergi Dairesi  :";
            dr["bilgi"] = dtFirma.Rows[0].Field<string>("VERGİ DAİRESİ").ToString();
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = "Vergi Numarası  :";
            dr["bilgi"] = dtFirma.Rows[0].Field<string>("VERGİ NUMARASI").ToString();
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = "Aksesuar  :";
            if (txtAksesuar.Text == "") dr["bilgi"] = ".";
            else dr["bilgi"] = txtAksesuar.Text;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = "Şikayet  :";
            if (txtSikayet.Text == "") dr["bilgi"] = ".";
            else dr["bilgi"] = txtSikayet.Text;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = ".";
            dr["bilgi"] = ".";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = "Şervis Şekli  :";
            dr["bilgi"] = cbServisSekli.Text;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["baslik"] = "Gönderim Şekli  :";
            dr["bilgi"] = cbGonderimSekli.Text;
            dt.Rows.Add(dr);

            dgv.DataSource = dt;
            PrintDataGrid.PrintDGV.Print_DataGridView(dgv, prntTitle, dtpTarih.Value);
        }

        private void btnFaturaEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdialog = new OpenFileDialog();//Resmi kullanıcıya seçtirmek için bir open file dialog oluşturuyoruz.

            fdialog.Filter = "Pictures|*.jpg";//Seçilecek dosyanın tipi sadece resim olacağı için resim dosya tiplerini filter olarak belirliyoruz.

            fdialog.InitialDirectory = "C://"; //Kullanıcının resimleri seçeceği dizinin C sabit diski olduğunu belirtiyoruz.

            if (DialogResult.OK == fdialog.ShowDialog())// Kullanıcı bir resim seçmiş mi kontrol ediyoruz.
            {

                string resimYol = fdialog.FileName; //Resmin yolunu alıyoruz.

                pbFatura.Image = Image.FromFile(resimYol); // Kullanıcının seçtiği resmi formumuza eklediğimiz picture box da gösteriyoruz.

                FileInfo fInfo = new FileInfo(resimYol); //System.IO isim uzayının altında bir FileInfo tanımlıyoruz.

                long sayac = fInfo.Length; //Resmimizin boyutunu alıyoruz. Bir long değişkeni tanımlayarak burda saklıyoruz.

                FileStream fStream = new FileStream(resimYol, FileMode.Open, FileAccess.Read); //Yine System.IO isim uzayının altında FileStream tanımlıyoruz. FileStream ile FileInfo ile belirtiğimiz uzantının üzerinde bir akım oluşturuyoruz.

                BinaryReader bReader = new BinaryReader(fStream); //Binary Reader sınıfıylada yukarıda tanımladığımız FileStream a istenilen türden verileri yazabilmek için bir BinaryReader tanımlıyoruz.

                byteResim = bReader.ReadBytes((int)sayac);
            }
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            FaturaResmiGetir();
        }

        private void btnFaturaGör_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count < 4 && pbFatura.Image != null)
            {
                FATURA faturaForm = new FATURA(pbFatura.Image);
                faturaForm.Show();
            }
        }
    }
}
