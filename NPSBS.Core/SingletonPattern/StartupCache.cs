using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Xml;
using System.Net.NetworkInformation;
using System.IO;
using System.Diagnostics;


namespace NPSBS.Core
{
    public class StartupCache
    {

        private static StartupCache instance = null;
        private static readonly object padlock = new object();
        public static string SettingJson = string.Empty;
        public static DataTable Class { get; private set; }
        public static DataTable Exam { get; private set; }
        public static List<GradingSystem> GradingSystem { get; private set; }
        public static ResultFont ResultFont { get; private set; }
        public static List<string> MacAddress { get;  set; }      
        private static string MyFirstMac { get;  set; }
        public static bool IsComputerAuthorized { get; private set; }

        StartupCache()
        {
            Class = GetClasses();
            Exam = GetExam();
            GradingSystem = GetGrading();
            SettingJson = GetUrlData();
            ResultFont = new ResultFont();
            MacAddress = GetMac();
            MyFirstMac = GetMyFirstMacAddress();
            IsComputerAuthorized = IsAuthenticateComputer(MacAddress, MyFirstMac);
        }

        public static StartupCache Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new StartupCache();
                    }
                    return instance;
                }
            }
        }

        private static DataTable GetClasses()
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Class_Select";
            DataTable tbl = DataAccess.ExecuteReaderCommand(cmd);
            DataRow dr = tbl.NewRow();
            dr[0] = "0";
            dr[1] = "0";
            dr[2] = "Select";
            tbl.Rows.InsertAt(dr, 0);
            return tbl;
        }

        private static DataTable GetExam()
        {
            var cmd = DataAccess.CreateCommand();
            cmd.CommandText = "usp_Exam_Select";
            var tbl = DataAccess.ExecuteReaderCommand(cmd);
            return tbl;
        }

        private static List<GradingSystem> GetGrading()
        {
            List<GradingSystem> gradingSystem = new List<GradingSystem>();
            gradingSystem.Add(new GradingSystem
            {
                LetterGrade = "A+",
                MinGradePoint = 3.61M,
                MaxGradePoint = 4.0M,
                EquivalentMarks = "90 to 100",
                Remarks = "Outstanding",
                MarksFrom = 90,
                MarksTo = 100
            });

            gradingSystem.Add(new GradingSystem
            {
                LetterGrade = "A",
                MinGradePoint = 3.21M,
                MaxGradePoint = 3.6M,
                EquivalentMarks = "80 to 90",
                Remarks = "Excellent",
                MarksFrom = 80,
                MarksTo = 89.99M
            });
            gradingSystem.Add(new GradingSystem
            {
                LetterGrade = "B+",
                MinGradePoint = 2.81M,
                MaxGradePoint = 3.2M,
                EquivalentMarks = "70 to 80",
                Remarks = "Very Good",
                MarksFrom = 70,
                MarksTo = 79.99M
            });

            gradingSystem.Add(new GradingSystem
            {
                LetterGrade = "B",
                MinGradePoint = 2.41M,
                MaxGradePoint = 2.8M,
                EquivalentMarks = "60 to 70",
                Remarks = "Good",
                MarksFrom = 60,
                MarksTo = 69.99M
            });

            gradingSystem.Add(new GradingSystem
            {
                LetterGrade = "C+",
                MinGradePoint = 2.01M,
                MaxGradePoint = 2.4M,
                EquivalentMarks = "50 to 60",
                Remarks = "Satisfactory",
                MarksFrom = 50,
                MarksTo = 59.99M
            });

            gradingSystem.Add(new GradingSystem
            {
                LetterGrade = "C",
                MinGradePoint = 1.61M,
                MaxGradePoint = 2.0M,
                EquivalentMarks = "40 to 50",
                Remarks = "Acceptable",
                MarksFrom = 40,
                MarksTo = 49.99M
            });
            gradingSystem.Add(new GradingSystem
            {
                LetterGrade = "D+",
                MinGradePoint = 1.21M,
                MaxGradePoint = 1.6M,
                EquivalentMarks = "30 to 40",
                Remarks = "Partially Acceptable",
                MarksFrom = 30,
                MarksTo = 39.99M
            });
            gradingSystem.Add(new GradingSystem
            {
                LetterGrade = "D",
                MinGradePoint = 0.81M,
                MaxGradePoint = 1.2M,
                EquivalentMarks = "20 to 30",
                Remarks = "Insufficient",
                MarksFrom = 20,
                MarksTo = 29.99M
            });
            gradingSystem.Add(new GradingSystem
            {
                LetterGrade = "E",
                MinGradePoint = 0.01M,
                MaxGradePoint = 0.8M,
                EquivalentMarks = "0 to 20",
                Remarks = "Very Insufficient",
                MarksFrom = 0,
                MarksTo = 19.99M
            });

            return gradingSystem;
        }

        private static string GetUrlData()
        {
            return new WebTextReader().ReadData();
        }

        private static List<string> GetMac()
        {
            List<string> ma = new List<string>();
            string setupFile = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Setting.xml";
            XmlDocument xmlSetup = new XmlDocument();
            try
            {
                xmlSetup.Load(setupFile);
                for (int i = 0; i < xmlSetup["ComputerIdentification"].ChildNodes.Count; i++)
                {
                    string add = xmlSetup["ComputerIdentification"].ChildNodes[i].InnerText;
                    ma.Add(add);
                }
            }
            catch (Exception ex)
            {
            }
            return ma;
        }

        private static string GetMyFirstMacAddress()
        {
            var macAddr = (
                               from nic in NetworkInterface.GetAllNetworkInterfaces()
                               //where nic.OperationalStatus == OperationalStatus.Up
                               select nic.GetPhysicalAddress().ToString()
                           ).First();

            string firstMac = macAddr;
            //foreach (var mac in macAddr)
            //{
            //    if(mac != "")
            //    {
            //        firstMac = mac;
            //        break;
            //    }
            //}

            firstMac = Encrypt.Hash(firstMac);
            EventLog.WriteEntry("Result Processing", "Your Registered Mac Address is : " + Environment.NewLine +  firstMac);
            return firstMac;
           

        }
      
        public static bool IsAuthenticateComputer(List<string> macs, string thisMac)
        {
            bool authenticate = true;
            authenticate = macs.Contains(thisMac) ? true : false;
            //var v = macs.Find(x => x.Mac == thisMac).Mac;
            //authenticate = v.Length >= 10 ? true : false; 
            return authenticate;
        }
    }
}
