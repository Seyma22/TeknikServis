using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TeknikServis.Models
{
    public class Donanimlar
    {
        public int DonanimId { get; set; }
        public int FirmaId { get; set; }
        public int KullaniciId { get; set; }
        public int TurId { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string SeriNo { get; set; }
        public string UrunNo { get; set; }
        public string LisansKey { get; set; }
        public string IsletimSistemi { get; set; }
        public string Ram { get; set; }
        public string GarantiDurumu { get; set; }
        public string BakimTarihi { get; set; }

        public int DonanimEkleGuncelle()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@DonanimId", DonanimId));
            prms.Add(new SqlParameter("@FirmaId", FirmaId));
            prms.Add(new SqlParameter("@TurId", TurId));
            prms.Add(new SqlParameter("@Marka", Marka));
            prms.Add(new SqlParameter("@Model", Model));
            prms.Add(new SqlParameter("@SeriNo", SeriNo));
            prms.Add(new SqlParameter("@UrunNo", UrunNo));
            prms.Add(new SqlParameter("@LisansKey", LisansKey));
            prms.Add(new SqlParameter("@IsletimSistemi", IsletimSistemi));
            prms.Add(new SqlParameter("@Ram", Ram));
            prms.Add(new SqlParameter("@GarantiDurumu", GarantiDurumu));
            prms.Add(new SqlParameter("@BakimTarihi", BakimTarihi));

            return Dal.executeProcedure("DonanimEkleGuncelle", prms);
        }

        public static DataTable DonanimlariGetir(int kullaniciId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@KullaniciId", kullaniciId));

            return Dal.getDataTableFromProcedure("DonanimlariGetir", prms);
        }

        public static DataTable DonanimGetirDonanimIdIle(int donanimId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@DonanimId", donanimId));

            return Dal.getDataTableFromProcedure("DonanimGetirDonanimIdIle", prms);
        }

        public static DataTable DonanimGetirKullaniciIdIle(int kullaniciId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@KullaniciId", kullaniciId));

            return Dal.getDataTableFromProcedure("DonanimGetirKullaniciIdIle", prms);
        }

        public static DataTable DonanimGetirUrunNoSeriNoIle(string urunNo,string seriNo)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@UrunNo", urunNo));
            prms.Add(new SqlParameter("@seriNo", seriNo));

            return Dal.getDataTableFromProcedure("DonanimGetirUrunNoSeriNoIle", prms);
        }


        public static int DonanimSil(int donanimId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@DonanimId", donanimId));

            return Dal.executeProcedure("DonanimSil", prms);
        }

        public static int DonanimKullaniciGuncelle(int kullaniciId,int donanimId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@KullaniciId", kullaniciId));
            prms.Add(new SqlParameter("@donanimId", donanimId));

            return Dal.executeProcedure("DonanimKullaniciGuncelle", prms);
        }
    }
}
