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
    public partial class SERVIS_SEKILLERI : Form
    {
        int id;

        public SERVIS_SEKILLERI(int bilgi,string servisSekli)
        {
            InitializeComponent();

            if (bilgi != 0)
            {
                this.Text = "Servis Şekli Güncelle";
                btnEkle.Text = "Kaydet";
                txtServisSekli.Text = servisSekli;
            }

            id = bilgi;
        }

        private void SERVIS_SEKILLERI_Load(object sender, EventArgs e)
        {
            this.Location = new Point(220, 50);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtServisSekli.Text != "")
                Ekle();
            else
                MessageBox.Show("Servis şekli boş bırakılamaz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Ekle()
        {
            ServisSekilleri ServisSekli = new ServisSekilleri();
            ServisSekli.ServisSekliId = id; // ekleme yapılacagında id 0 gelir.
            ServisSekli.ServisSekli = txtServisSekli.Text;

            if (ServisSekli.ServisSekliEkleGuncelle() == 0)
            {
                MessageBox.Show("Bu servis şekli daha önce eklenmiş.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();
            }
        }
    }
}
