using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Net.Mail;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Utility
{
    public class InternetConnection
    {
        public static bool InInternetConnected(string url = "https://google.com")
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead(url))
                    {
                        return true;
                    }
                }
            }
            catch
            {

                return false;
            }
        }


    }

    public class OnlineContent
    {
        public static About GetAbout(string shortName, string schoolName, string address)
        {
            About about = new About();
            try
            {

                if (InternetConnection.InInternetConnected("https://api.myjson.com"))
                {
                    using (var client = new WebClient())
                    {
                        //client.Headers.Add("secret-key", "$2a$10$S17h1HQFAD.AEQpef2TRC.G9SPsHzR1yCYPD1ZBE6AAMi8N9SK/Ta");
                        //Uri uri = new Uri("https://api.jsonbin.io/b/5b516f9d4d5ea95c8ba76abc/latest");
                        Uri uri = new Uri("https://api.myjson.com/bins/xfjlq");
                        Stream data = client.OpenRead(uri);
                        using (StreamReader reader = new StreamReader(data))
                        {
                            string s = reader.ReadToEnd();
                            about = JsonConvert.DeserializeObject<About>(s);
                        }

                    }
                }
                else
                {
                    about = JsonConvert.DeserializeObject<About>(Constant.AboutString);
                }
                about.SchoolSoftwareAboutOriginal = about.SchoolSoftwareAbout;
                about.SchoolSoftwareAbout = about.SchoolSoftwareAbout
                        .Replace("*NewLine*", Environment.NewLine)
                        .Replace("*ShortName*", shortName)
                        .Replace("*SchoolName*", schoolName)
                        .Replace("*Address*", address);
            }
            catch
            {

            }
            return about;
        }

        public static About ChangeAbout(About about, string shortName, string schoolName, string address)
        {
            about.SchoolSoftwareAbout = about.SchoolSoftwareAboutOriginal
                        .Replace("*NewLine*", Environment.NewLine)
                            .Replace("*ShortName*", shortName)
                            .Replace("*SchoolName*", schoolName)
                            .Replace("*Address*", address);
            return about;
        }
    }
}
