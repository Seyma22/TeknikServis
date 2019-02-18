using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TeknikServis.Models
{
    public class LisansTipleri
    {
        public int TipId { get; set; }
        public string TipAdi { get; set; }

        public static DataTable LisansTipleriniGetir()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            return Dal.getDataTableFromProcedure("LisansTipleriniGetir", prms);
        }

        public int LisansTipiEkleGuncelle()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@TipId", TipId));
            prms.Add(new SqlParameter("@TipAdi", TipAdi));

            return Dal.executeProcedure("LisansTipiEkleGuncelle", prms);
        }

        public static int LisasnTipiSil(int tipId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@TipId", tipId));

            return Dal.executeProcedure("LisasnTipiSil", prms);
        }
    }
}
