using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using System.Xml;

namespace Utility
{
    public class Setting
    {
        private static Setting instance = null;
        private static readonly object padlock = new object();
        private static string NPSBSConnection = "";
        private static string MontessoriConnection = "";
        private static Dictionary<string, string> DatabaseInformation;
        public static string NpsbsDbName { get; private set; }
        public static string KidsZoneDbName { get; private set; }

        Setting()
        {
        }

        public static Setting Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        DatabaseInformation = new Dictionary<string, string>();
                        GetDatabaseInformation();
                        instance = new Setting();
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
        private static string ConnectionString(string dbName, out string databaseName)
        {
            var connectionString = "";
            databaseName = "";
            try
            {
                string source = DatabaseInformation["DataSource"];// ConfigurationManager.AppSettings["DataSource"];
                string user = DatabaseInformation["UserName"]; //  ConfigurationManager.AppSettings["UserName"];
                databaseName = DatabaseInformation[dbName]; //ConfigurationManager.AppSettings[dbName];
                string pwd = DatabaseInformation["Password"]; //ConfigurationManager.AppSettings["Password"];
                connectionString = "data source = " + source + "; database=" + databaseName + "; user id=" + user + "; password=" + pwd;
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
                string DbName;
                NPSBSConnection = ConnectionString("Database_NPSBS", out DbName);
                NpsbsDbName = DbName;
            }
            return NPSBSConnection;
        }

        public static string GetMontessoriConnection()
        {
            if (string.IsNullOrEmpty(MontessoriConnection))
            {
                string DbName;
                MontessoriConnection = ConnectionString("Database_KidsZone", out DbName);
                KidsZoneDbName = DbName;
            }
            return MontessoriConnection;
        }
    }
}
