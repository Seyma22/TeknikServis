using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TeknikServis.Models
{
    public class Kullanicilar
    {
        public int KullaniciId { get; set; }
        public int FirmaId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }
        public string DomainAdi { get; set; }

        public int KullaniciEkleGuncelle()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@KullaniciId", KullaniciId));
            prms.Add(new SqlParameter("@FirmaId", FirmaId));
            prms.Add(new SqlParameter("@Ad", Ad));
            prms.Add(new SqlParameter("@Soyad", Soyad));
            prms.Add(new SqlParameter("@Departman", Departman));
            prms.Add(new SqlParameter("@DomainAdi", DomainAdi));

            return Dal.executeProcedure("KullaniciEkleGuncelle", prms);
        }

        public static DataTable KullanicilariGetir()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            return Dal.getDataTableFromProcedure("KullanicilariGetir", prms);
        }

        public static int KullaniciSil(int kullaniciId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@KullaniciId", kullaniciId));

            return Dal.executeProcedure("KullaniciSil", prms);
        }
    }
}
