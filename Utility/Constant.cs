using System;

namespace Utility
{
    public static class Constant
    {
        private static string path = AppDomain.CurrentDomain.BaseDirectory;

        public static string MainBackground { get { return path + "mainbg.png"; } }
        public static string Logo { get { return path + "Logo.png"; } }

        public static string Background { get { return path + "Background.png"; } }



        public static string AppVersion { get { return "2.0.0"; } }

    }
}


