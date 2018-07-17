using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace NPSBS.Core
{
    
    class WebTextReader
    {
        System.Net.WebClient wc = new System.Net.WebClient();
        

        public string ReadData()
        {
            string webData = "";// wc.DownloadString("https://www.dropbox.com/s/jrtfw3em3ppuusb/json.json?dl=0");
            //webData = wc.DownloadString("https://www.dropbox.com/home/Public/Hosted_CSS_Blogspot?preview=json.json");
            return webData;
        }
    }
}
