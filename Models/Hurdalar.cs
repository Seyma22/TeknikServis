using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TeknikServis.Models
{
    public class Hurdalar
    {
        public int HurdaId { get; set; }
        public int DonanimId { get; set; }
        public string HurdaTarihi { get; set; }
        public string Notu { get; set; }

        public int HurdaEkleGuncelle()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@DonanimId", DonanimId));
            prms.Add(new SqlParameter("@HurdaTarihi", HurdaTarihi));
            prms.Add(new SqlParameter("@Notu", Notu));

            return Dal.executeProcedure("HurdaEkleGuncelle", prms);
        }

        public static DataTable HurdaGetirDonanimIdIle(int donanimId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@DonanimId", donanimId));

            return Dal.getDataTableFromProcedure("HurdaGetirDonanimIdIle", prms);
        }

        public static int HurdaSil(int donanimId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@DonanimId", donanimId));

            return Dal.executeProcedure("HurdaSil", prms);
        }
    }
}
