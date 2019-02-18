using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TeknikServis.Models
{
    public class DonanimTurleri
    {
        public int TurId { get; set; }
        public string Tur { get; set; }

        public static DataTable DonanimTurleriniGetir()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            return Dal.getDataTableFromProcedure("DonanimTurleriniGetir", prms);
        }

        public int DonanimTuruEkleGuncelle()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@TurId", TurId));
            prms.Add(new SqlParameter("@Tur", Tur));

            return Dal.executeProcedure("DonanimTuruEkleGuncelle", prms);
        }

        public static int DonanimTuruSil(int turId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@TurId", turId));

            return Dal.executeProcedure("DonanimTuruSil", prms);
        }
    }
}
