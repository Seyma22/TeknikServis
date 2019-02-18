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
    public partial class GONDERIM_SEKILLERI : Form
    {
        int id;

        public GONDERIM_SEKILLERI(int bilgi,string gonderimSekli)
        {
            InitializeComponent();

            if (bilgi != 0)
            {
                this.Text = "T. Servise Göderim Şekli Güncelle";
                btnEkle.Text = "Kaydet";
                txtGonderimSekli.Text = gonderimSekli;
            }

            id = bilgi;
        }

        private void GONDERIM_SEKILLERI_Load(object sender, EventArgs e)
        {
            this.Location = new Point(220, 50);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtGonderimSekli.Text != "")
                Ekle();
            else
                MessageBox.Show("Gönderim şekli boş bırakılamaz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Ekle()
        {
            GonderimSekilleri GonderimSekli = new GonderimSekilleri();
            GonderimSekli.GonderimSekliId = id; // ekleme yapılacagında id 0 gelir.
            GonderimSekli.GonderimSekli = txtGonderimSekli.Text;

            if (GonderimSekli.GonderimSekliEkleGuncelle() == 0)
            {
                MessageBox.Show("Bu gönderim şekli daha önce eklenmiş.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();
            }
        }
    }
}
