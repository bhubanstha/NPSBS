namespace NPSBS.Core
{
	public class Encrypt
	{
		private static string mySalt = "$2a$10$rBV2JDeWW3.vKyeWEM1fFO";

		public static string Hash(string plainText)
		{
			return plainText;
			//string encrypt = BCrypt.Net.BCrypt.HashPassword(plainText, mySalt);
			//string hashed = encrypt.Replace(mySalt, "");
			//return hashed;
		}
	}
}
