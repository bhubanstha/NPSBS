using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BCrypt;

namespace Montessori.Core
{
    public class Encrypt
    {
        private static string mySalt = "$2a$10$rBV2JDeWW3.vKyeWEM1fFO";

        public static string Hash(string plainText)
        {
            string encrypt = BCrypt.Net.BCrypt.HashPassword(plainText, mySalt);
            string hashed = encrypt.Replace(mySalt, "");
            return hashed;
        }
    }
}
