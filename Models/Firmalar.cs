using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

namespace TeknikServis.Models
{
    public class Firmalar
    {
        public int FirmaId { get; set; }
        public string Firma { get; set; }
        public string Adres { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNumarasi { get; set; }

        public int FirmaEkleGuncelle()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@FirmaId",FirmaId));
            prms.Add(new SqlParameter("@Firma",Firma));
            prms.Add(new SqlParameter("@Adres", Adres));
            prms.Add(new SqlParameter("@VergiDairesi", VergiDairesi));
            prms.Add(new SqlParameter("@VergiNumarasi", VergiNumarasi));

            return Dal.executeProcedure("FirmaEkleGuncelle", prms);
        }

        public static DataTable FirmalariGetir()
        { 
            List<SqlParameter> prms = new List<SqlParameter>();

            return Dal.getDataTableFromProcedure("FirmalariGetir", prms);
        }

        public static int FirmaSil(int firmaId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@FirmaId", firmaId));

            return Dal.executeProcedure("FirmaSil", prms);
        }

        public static DataTable FirmaGetirDonanimIdIle(int donanimId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@DonanimId", donanimId));

            return Dal.getDataTableFromProcedure("FirmaGetirDonanimIdIle", prms);
        }
    }
}
