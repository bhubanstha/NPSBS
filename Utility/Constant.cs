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

    }
}


