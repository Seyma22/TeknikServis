using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TeknikServis.Models
{
    public class TeknikServisler
    {
        public int KayitId { get; set; }
        public int DonanimId { get; set; }
        public int ServisSekliId { get; set; }
        public int GonderimSekliId { get; set; }
        public int ServisFirmaId { get; set; }
        public string Aksesuar { get; set; }
        public string Sikayet { get; set; }
        public string Tarih { get; set; }
        public string Karar { get; set; }
        public int Durum { get; set; }
        public byte[] FaturaResmi { get; set; }

        public int TeknikServisEkleGuncelle()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@KayitId", KayitId));
            prms.Add(new SqlParameter("@DonanimId", DonanimId));
            prms.Add(new SqlParameter("@ServisSekliId", ServisSekliId));
            prms.Add(new SqlParameter("@GonderimSekliId", GonderimSekliId));
            prms.Add(new SqlParameter("@ServisFirmaId", ServisFirmaId));
            prms.Add(new SqlParameter("@Aksesuar", Aksesuar));
            prms.Add(new SqlParameter("@Sikayet", Sikayet));
            prms.Add(new SqlParameter("@Tarih", Tarih));
            prms.Add(new SqlParameter("@Karar", Karar));
            prms.Add(new SqlParameter("@Durum", Durum));
            prms.Add(new SqlParameter("@FaturaResmi", FaturaResmi));

            return Dal.executeProcedure("TeknikServisEkleGuncelle", prms);
        }

        public static DataTable TeknikServisleriGetir(int listeTipi)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@ListeTipi", listeTipi));

            return Dal.getDataTableFromProcedure("TeknikServisleriGetir", prms);
        }

        public static int TeknikServisSil(int kayitId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@KayitId", kayitId));

            return Dal.executeProcedure("TeknikServisSil", prms);
        }

        public static DataTable TeknikServisFaturaResmiGetir(int kayitId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@KayitId", kayitId));

            return Dal.getDataTableFromProcedure("TeknikServisFaturaResmiGetir", prms);
        }
    }
}
