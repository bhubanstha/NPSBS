using Utility;
namespace Education.Common
{
    public class ConnectionChecker
    { 

        public ConnectionChecker()
        {
            Setting con = Setting.Instance;
        }

        static ConnectionChecker()
        {
            Setting con = Setting.Instance;
        }

        public static bool CheckConnection(App app)
        {
            bool connection = true;
            DataAccess dataAccess = new DataAccess(app);
            var cmd = dataAccess.CreateCommand();
            cmd.CommandTimeout = 2;
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

        public static string GetConnectionstring(App app)
        {

            return app == App.KidsZone ?
                    Setting.GetMontessoriConnection() :
                    Setting.GetNPSBSConnection() ;
        }
    }
}
