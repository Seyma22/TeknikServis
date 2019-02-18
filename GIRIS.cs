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
    public partial class GIRIS : Form
    {
        public GIRIS()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        FileStream fs;
        StreamReader sr;
        StreamWriter sw;

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

        private void GIRIS_Load(object sender, EventArgs e)
        {
            Oku();

            timer.Enabled = true;
            pBar.Visible = true;

            bgw.RunWorkerAsync();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.KullaniciAdi = txtKullaniciAdi.Text;
            giris.Sifre = txtSifre.Text;

            if (giris.KullaniciKontrolEt() != 0)
            {
                msChild.Enabled = true;
                gbGiris.Visible = false;
                lblKarsilama.Text = "Hoşgeldiniz " + txtKullaniciAdi.Text + ",\n\nÜst menüden yapmak istediğiniz işlemi\nseçebilirsiniz.";
            }
            else
                lblGiris.Text = "Yanlış kullanıcı adı veya şifre";
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            Dal.cnnStr = "server=" + txtIP.Text + "; database=" + txtVeritabani.Text + ";User Id=" + txtID.Text + ";Password=" + txtPass.Text + ";trusted_connection=NO;";

            dt = Uyeler.UyeleriGetir();
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (dt.Columns.Count != 0)
            {
                pbOK.Visible = true;
                pbNO.Visible = false;
                gbGiris.Enabled = true;
                gbBaglantiAyar.Visible = false;
                gbBaglantiAyar.Enabled = false;
            }
            else
            {
                pbNO.Visible = true;
                pbOK.Visible = false;
                gbGiris.Enabled = false;
                gbBaglantiAyar.Visible = true;
                gbBaglantiAyar.Enabled = true;
            }

            timer.Enabled = false;
            pBar.Visible = false;
            pBar.Value = 0;
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            pBar.Visible = true;
            gbBaglantiAyar.Enabled = false;

            bgw.RunWorkerAsync();

            Yaz();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pBar.Value >= 100) pBar.Value = 0;
            else pBar.Value += 5;
        }

        public void Oku()
        {
            try
            {
                fs = new FileStream("c:\\Baglanti.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                txtVeritabani.Text = sr.ReadLine();
                txtID.Text = sr.ReadLine();
                txtPass.Text = sr.ReadLine();
                txtIP.Text = sr.ReadLine();

                sr.Close();
                fs.Close();
            }
            catch 
            {
            }
        }

        public void Yaz()
        {
            try
            {
                fs = new FileStream("c:\\Baglanti.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                sw = new StreamWriter(fs);
                
                sw.WriteLine(txtVeritabani.Text);
                sw.WriteLine(txtID.Text);
                sw.WriteLine(txtPass.Text);
                sw.WriteLine(txtIP.Text);

                sw.Close();
                fs.Close();
            }
            catch 
            {
                MessageBox.Show("asdfsd");
            }
        }
    }
}
