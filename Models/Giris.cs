using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TeknikServis.Models
{
    public class Giris
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public int KullaniciKontrolEt()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@KullaniciAdi", KullaniciAdi));
            prms.Add(new SqlParameter("@Sifre", Sifre));

            return Dal.executeProcedure("KullaniciKontrolEt", prms);
        }
    }
}
