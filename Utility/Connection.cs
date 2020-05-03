using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Windows.Forms;
using System.Xml;

namespace Utility
{
    public class Connection
    {
        private static Connection instance = null;
        private static readonly object padlock = new object();
        private static string NPSBSConnection = "";
        private static string MontessoriConnection = "";
        private static Dictionary<string, string> DatabaseInformation;

        Connection()
        {
        }

        public static Connection Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        DatabaseInformation = new Dictionary<string, string>();
                        GetDatabaseInformation();
                        instance = new Connection();
                    }
                    return instance;
                }
            }
        }

        private static void GetDatabaseInformation()
        {
            string setupFile = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Setting.xml";
            XmlDocument xmlSetup = new XmlDocument();
            try
            {
                xmlSetup.Load(setupFile);
                for (int i = 0; i < xmlSetup["ComputerIdentification"].ChildNodes[0].ChildNodes.Count; i++)
                {
                    string name = xmlSetup["ComputerIdentification"].ChildNodes[0].ChildNodes[i].Attributes[0].Value;
                    string value = xmlSetup["ComputerIdentification"].ChildNodes[0].ChildNodes[i].Attributes[1].Value;
                    DatabaseInformation.Add(name, value);
                }
            }
            catch 
            {
            }
            finally
            {
                xmlSetup = null;
                GC.Collect();
            }
        }

        public static T GetSettingValue<T>(SettingEnum settingKey)
        {
            Dictionary<string, string> settingInformation = new Dictionary<string, string>();
            object settingValue=false;
            string setupFile = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Setting.xml";
            XmlDocument xmlSetup = new XmlDocument();
            try
            {
                xmlSetup.Load(setupFile);
                for (int i = 0; i < xmlSetup["ComputerIdentification"].ChildNodes[1].ChildNodes.Count; i++)
                {
                    string name = xmlSetup["ComputerIdentification"].ChildNodes[1].ChildNodes[i].Attributes[0].Value;
                    string value = xmlSetup["ComputerIdentification"].ChildNodes[1].ChildNodes[i].Attributes[1].Value;
                    settingInformation.Add(name, value);
                }
                settingValue = settingInformation[settingKey.ToString()];
            }
            catch
            {
            }
            finally
            {
                xmlSetup = null;
                GC.Collect();
            }

            
            return (T)Convert.ChangeType(settingValue, typeof(T));
        }
        private static string ConnectionString(string dbName)
        {
            var connectionString = "";
            try
            {
                string source = DatabaseInformation["DataSource"];// ConfigurationManager.AppSettings["DataSource"];
                string user = DatabaseInformation["UserName"]; //  ConfigurationManager.AppSettings["UserName"];
                string db = DatabaseInformation[dbName]; //ConfigurationManager.AppSettings[dbName];
                string pwd = DatabaseInformation["Password"]; //ConfigurationManager.AppSettings["Password"];
                connectionString = "data source = " + source + "; database=" + db + "; user id=" + user + "; password=" + pwd;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(CultureInfo.InvariantCulture), "Connection Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return connectionString;
        }

        public static string GetNPSBSConnection()
        {
            if (string.IsNullOrEmpty(NPSBSConnection))
            {
                NPSBSConnection = ConnectionString("Database_NPSBS");
            }
            return NPSBSConnection;
        }

        public static string GetMontessoriConnection()
        {
            if (string.IsNullOrEmpty(MontessoriConnection))
            {
                MontessoriConnection = ConnectionString("Database_KidsZone");
            }
            return MontessoriConnection;
        }
    }
}
