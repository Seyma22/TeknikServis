using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TeknikServis.Models
{
    public class Yazilimlar
    {
        public int YazilimId { get; set; }
        public string YazilimAdi { get; set; }
        public string GuncellemeTarihi { get; set; }
        public int LisansSayisi { get; set; }

        public int YazilimEkleGuncelle()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@YazilimId", YazilimId));
            prms.Add(new SqlParameter("@YazilimAdi", YazilimAdi));
            prms.Add(new SqlParameter("@GuncellemeTarihi", GuncellemeTarihi));
            prms.Add(new SqlParameter("@LisansSayisi", LisansSayisi));
            
            return Dal.executeProcedure("YazilimEkleGuncelle", prms);
        }

        public static DataTable YazilimlariGetir(int kullaniciId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@KullaniciId", kullaniciId));

            return Dal.getDataTableFromProcedure("YazilimlariGetir", prms);
        }

        public static DataTable YazilimGetirKullaniciIdIle(int kullaniciId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@KullaniciId", kullaniciId));

            return Dal.getDataTableFromProcedure("YazilimGetirKullaniciIdIle", prms);
        }

        public static int YazilimSil(int yazilimId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@YazilimId", yazilimId));

            return Dal.executeProcedure("YazilimSil", prms);
        }

        public static int YazilimKullaniciGuncelle(int kullaniciId,int yazilimId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@kullaniciId", kullaniciId));
            prms.Add(new SqlParameter("@YazilimId", yazilimId));

            return Dal.executeProcedure("YazilimKullaniciGuncelle", prms);
        }
    }
}
