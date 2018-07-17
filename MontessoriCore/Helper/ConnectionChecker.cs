using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Montessori.Core
{
    public class ConnectionChecker
    {

        public static bool CheckConnection()
        {
            bool connection = true;
            var cmd = DataAccess.CreateCommand();
            try
            {
                cmd.Connection.Open();
            }
            catch (Exception ex)
            {
                connection = false;
                //throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return connection;
                
        }

        public static string GetConnectionstring()
        {
            return DataAccess.ConnectionString();
        }


    }
}
