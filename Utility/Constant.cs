using System;

namespace Utility
{
    public static class Constant
    {
        private static string path = AppDomain.CurrentDomain.BaseDirectory;

        public static string MainBackground { get { return path + "mainbg.png"; } }
        public static string MLogo { get { return path + "MLogo.png"; } }
        public static string NLogo { get { return path + "NLogo.png"; } }

        public static string MBackground { get { return path + "MBackground.png"; } }
        public static string NBackground { get { return path + "NBackground.png"; } }



        public static string AppVersion { get { return "2.0.0"; } }


        public static string AboutString 
        { get 
            { 
                return "{\"DeveloperContactNo\": \"(+977) 9823 07 4545, (+977) 9869 06 4050\",\"SchoolSoftwareAbout\": \"This Software is protected by copyright law and international treaties. This Software is licensed (not sold), and its use is subject to a valid WRITTEN AND SIGNED Communique(r) License Agreement. The unauthorized use, copying or distribution of this Software may result in severe criminal or civil penalties, and will be prosecuted to the maximum extent allowed by law. *NewLine**NewLine* Remote Verification *NewLine* You acknowledge and agree that the Software may contain verification and reporting functionality that allows the remote reporting of your usage of the Software for the purpose of verifying your compliance with these terms and conditions. If remote verification reveals that you are using the Software in violation of these terms and conditions, you agree to cease such unauthorized use and to pay Developer's reasonable expenses and a penalty fee associated with such remote verification and your unauthorized use.*NewLine**NewLine* *ShortName*, the *ShortName* logo are the trademarks of *SchoolName* (*Address*).\"}"; 
            } 
        }


    }
}


