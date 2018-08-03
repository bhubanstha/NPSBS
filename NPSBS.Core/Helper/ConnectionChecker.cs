using Utility;

namespace NPSBS.Core
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
            catch
            {
                connection = false;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return connection;
                
        }

        public static string GetConnectionstring()
        {
            return Connection.GetNPSBSConnection();
        }


    }
}
