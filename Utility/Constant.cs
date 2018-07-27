using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility
{
    public static class Constant
    {
        private static string path = AppDomain.CurrentDomain.BaseDirectory;

        public static string MainBackground { get { return path + "mainbg.jpg"; } }
        public static string NPSBSLogo { get { return path + "schoolLogo.jpg"; } }
        public static string MontessoriLogo { get { return path + "montessoriLogo.jpg"; } }

        public static string NPSBSBackground { get { return path + "NPSBSBackground.jpg"; } }
        public static string MontessoriBackground { get { return path + "MontessoriBackground.jpg"; } }

    }
}
