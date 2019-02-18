using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TeknikServis.Models
{
    public class GonderimSekilleri
    {
        public int GonderimSekliId { get; set; }
        public string GonderimSekli { get; set; }

        public int GonderimSekliEkleGuncelle()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@GonderimSekliId", GonderimSekliId));
            prms.Add(new SqlParameter("@GonderimSekli", GonderimSekli));

            return Dal.executeProcedure("GonderimSekliEkleGuncelle", prms);
        }

        public static DataTable GonderimSekilleriniGetir()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            return Dal.getDataTableFromProcedure("GonderimSekilleriniGetir", prms);
        }

        public static int GonderimSekliSil(int gonderimSekliId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@GonderimSekliId", gonderimSekliId));

            return Dal.executeProcedure("GonderimSekliSil", prms);
        }
    }
}
