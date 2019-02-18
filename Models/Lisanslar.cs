using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TeknikServis.Models
{
    public class Lisanslar
    {
        public int LisansId { get; set; }
        public int YazilimId { get; set; }
        public int TipId { get; set; }
        public string LisansKey { get; set; }
        public string LisansNumarasi { get; set; }
        public string LisansAdi { get; set; }
        public int LisansSayisi { get; set; }
        public int KullanimDurumu { get; set; }
        public int KullaniciId { get; set; }

        public int LisansEkleGuncelle()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@LisansId", LisansId));
            prms.Add(new SqlParameter("@YazilimId", YazilimId));
            prms.Add(new SqlParameter("@TipId", TipId));
            prms.Add(new SqlParameter("@LisansKey", LisansKey));
            prms.Add(new SqlParameter("@LisansNumarasi", LisansNumarasi));
            prms.Add(new SqlParameter("@LisansAdi", LisansAdi));
            prms.Add(new SqlParameter("@LisansSayisi", LisansSayisi));

            return Dal.executeProcedure("LisansEkleGuncelle", prms);
        }

        public static DataTable LisanslariGetir(int kullaniciId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@KullaniciId", kullaniciId));

            return Dal.getDataTableFromProcedure("LisanslariGetir", prms);
        }

        public static DataTable LisanslariGetirKullaniciIdIle(int kullaniciId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@KullaniciId", kullaniciId));

            return Dal.getDataTableFromProcedure("LisanslariGetirKullaniciIdIle", prms);
        }

        public static int LisansSil(int lisansId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@LisansId", lisansId));

            return Dal.executeProcedure("LisansSil", prms);
        }

        public static int LisansKullaniciGuncelle(int kullaniciId,int lisansId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@KullaniciId", kullaniciId));
            prms.Add(new SqlParameter("@LisansId", lisansId));

            return Dal.executeProcedure("LisansKullaniciGuncelle", prms);
        }
    }
}
