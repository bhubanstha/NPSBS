using System;
using Utility;
namespace Montessori.Core
{
    public class ConnectionChecker
    {
        public ConnectionChecker()
        {
            Connection con = Connection.Instance;
        }

        static ConnectionChecker()
        {
            Connection con = Connection.Instance;
        }

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

            return Connection.GetMontessoriConnection();
        }


    }
}
