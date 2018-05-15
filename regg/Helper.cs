using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regg
{
    public static class Helper
    {
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static bool CreateDataBase(string ConnectionString)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(ConnectionString);

            string Query = "CREATE DATABASE regaBaza";

            SqlCommand comand = new SqlCommand(Query, con);
            try
            {
                con.Open();
                comand.ExecuteNonQuery();
                result = true;
            }
            catch (System.Exception ex)
            {
                result = false;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }
    }
}
