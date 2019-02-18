using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;

namespace TeknikServis.Models
{
    public class Dal
    {
        public static int dbType;  //0 - mssql, 1 mysql, 2 oracle , 3 db2
        public static string cnnStr;

        public static DataTable getDataTableFromProcedure(string procedureName, List<SqlParameter> prms)
        {
            switch (dbType)
            {
                case 0:
                    return getDataTableFromMsSQLProcedure(procedureName, prms);


            }
            return null;
        }

        private static DataTable getDataTableFromMsSQLProcedure(string procedureName, List<SqlParameter> prms)
        {
            DataTable result = new DataTable();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = cnnStr;// web configten aldık.
            try
            {
                cn.Open();//baglantıyı açmak istiyorum
            }
            catch{}
            
            if (cn.State == System.Data.ConnectionState.Open) //baglantı açıldı mı kontrolü.
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = procedureName;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;

                foreach (SqlParameter s in prms)
                {
                    cmd.Parameters.Add(s);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(result);

                cmd.Dispose();// bellekte yer kaplamasın diye komutu yok ediyoruz.
                cn.Close();
                cn.Dispose();

            }

            return result;
        }

        public static int executeProcedure(string procedureName, List<SqlParameter> prms)
        {
            switch (dbType)
            {
                case 0:
                    return executeMsSqlProcedure(procedureName, prms);

            }
            return 0;
        }

        private static int executeMsSqlProcedure(string procedureName, List<SqlParameter> prms)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = cnnStr;// web configten aldık.
            try
            {
                cn.Open();//baglantıyı açmak istiyorum
            }
            catch{}
            if (cn.State == System.Data.ConnectionState.Open) //baglantı açıldı mı kontrolü.
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = procedureName;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;

                SqlParameter prm0 = new SqlParameter();//prosedürden dönücek değer için tanımlandı.
                prm0.Direction = System.Data.ParameterDirection.ReturnValue;
                prm0.ParameterName = "@returnvalue";
                cmd.Parameters.Add(prm0);

                foreach (SqlParameter s in prms)
                {
                    cmd.Parameters.Add(s);
                }

                cmd.ExecuteNonQuery();

                int result = Convert.ToInt32(cmd.Parameters[0].Value.ToString());

                cmd.Dispose();// bellekte yer kaplamasın diye komutu yok ediyoruz.
                cn.Close();
                cn.Dispose();
                return result;
            }

            return -1;
        }

        // BACKUP AND RESTORE -- EK Tarihi 08/2012

        public static Boolean BackUpOrRestore(string sqlQuery)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = cnnStr;
            SqlCommand cmd = new SqlCommand(sqlQuery, cn);

            try
            {
                cn.Open();
                cmd.ExecuteScalar();
                cn.Close();
                return true;
            }
            catch
            {
                cn.Close();
                return false;
            }
        }
    }
}
