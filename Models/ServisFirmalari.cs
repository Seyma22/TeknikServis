using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TeknikServis.Models
{
    public class ServisFirmalari
    {
        public int ServisFirmaId { get; set; }
        public string FirmaAdi { get; set; }
        public string Adres { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }

        public int ServisFirmasiEkleGuncelle()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@ServisFirmaId", ServisFirmaId));
            prms.Add(new SqlParameter("@FirmaAdi", FirmaAdi));
            prms.Add(new SqlParameter("@Adres", Adres));
            prms.Add(new SqlParameter("@Tel", Tel));
            prms.Add(new SqlParameter("@Fax", Fax));
            prms.Add(new SqlParameter("@Gsm", Gsm));
            prms.Add(new SqlParameter("@Email", Email));

            return Dal.executeProcedure("ServisFirmasiEkleGuncelle", prms);
        }

        public static DataTable ServisFirmalariniGetir()
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            return Dal.getDataTableFromProcedure("ServisFirmalariniGetir", prms);
        }

        public static DataTable ServisFirmasiGetirServisFirmaIdIle(int servisFirmaId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@ServisFirmaId", servisFirmaId));

            return Dal.getDataTableFromProcedure("ServisFirmasiGetirServisFirmaIdIle", prms);
        }

        public static int ServisFirmasiSil(int servisFirmaId)
        {
            List<SqlParameter> prms = new List<SqlParameter>();

            prms.Add(new SqlParameter("@ServisFirmaId", servisFirmaId));

            return Dal.executeProcedure("ServisFirmasiSil", prms);
        }
    }
}
