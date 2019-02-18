using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TeknikServis.Models
{
    public class ServisSekilleri
    {
        public int ServisSekliId { get; set; }
        public string ServisSekli { get; set; }

        public int ServisSekliEkleGuncelle()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@ServisSekliId", ServisSekliId));
            prms.Add(new SqlParameter("@ServisSekli", ServisSekli));

            return Dal.executeProcedure("ServisSekliEkleGuncelle", prms);
        }

        public static DataTable ServisSekilleriniGetir()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            return Dal.getDataTableFromProcedure("ServisSekilleriniGetir", prms);
        }

        public static int ServisSekliSil(int servisSekliId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@ServisSekliId", servisSekliId));

            return Dal.executeProcedure("ServisSekliSil", prms);
        }
    }
}
