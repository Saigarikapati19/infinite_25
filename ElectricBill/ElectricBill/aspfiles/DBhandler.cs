using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ElectricBill.aspfiles
{
    public class DBhandler
    {
        public static SqlConnection GetConnection()
        {
            try
            {
                string conStr = ConfigurationManager
                                .ConnectionStrings["Connection"]
                                .ConnectionString;

                return new SqlConnection(conStr);
            }
            catch (Exception ex)
            {
                throw new Exception("Database connection failed", ex);
            }
        }


    }
}