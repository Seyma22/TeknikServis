using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TeknikServis.Models
{
    public class Uyeler
    {
        public int UyeId { get; set; }
        public string Rol { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public int UyeEkleGuncelle()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@UyeId", UyeId));
            prms.Add(new SqlParameter("@Rol", Rol));
            prms.Add(new SqlParameter("@Ad", Ad));
            prms.Add(new SqlParameter("@Soyad", Soyad));
            prms.Add(new SqlParameter("@KullaniciAdi", KullaniciAdi));
            prms.Add(new SqlParameter("@Sifre", Sifre));

            return Dal.executeProcedure("UyeEkleGuncelle", prms);
        }

        public static DataTable UyeleriGetir()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            return Dal.getDataTableFromProcedure("UyeleriGetir", prms);
        }

        public static int UyeSil(int uyeId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@UyeId", uyeId));

            return Dal.executeProcedure("UyeSil", prms);
        }
    }
}
