using System;
using System.Runtime.InteropServices;
using NPSBS.Core;

namespace NPSBSEnrypter
{
	class Program
    {
        const int STD_INPUT_HANDLE = -10;
        const int ENABLE_QUICK_EDIT_MODE = 0x40 | 0x80;

        static void Main(string[] args)
        {
            EnableQuickEditMode();
            string myKey = "";
            bool continueGen = true;
            Console.Title = "Encrypter";
            do
            {
                Console.Clear();
                Console.Write("Enter Text : ");
                myKey = Console.ReadLine().ToUpper().Replace("-","");
                myKey = Encrypt.Hash(myKey);
                Console.WriteLine("\nEncrypted Text : " + myKey);
                Console.WriteLine("\n================================================================================");
               // Clipboard.SetText(myKey);
                Console.Write("Do you want to continue <y/n>?");
                string dec = Console.ReadLine();
               
                continueGen = dec.Substring(0, 1).ToLower() == "y" ? true : false;
            } while (continueGen);
          

        }


        [DllImport("kernel32.dll")]
        static extern bool SetConsoleMode(IntPtr hConsoleHandle, int mode);

        [DllImport("kernel32.dll")]
        static extern bool GetConsoleMode(IntPtr hConsoleHandle, out int mode);
        [DllImport("kernel32.dll")]
        static extern IntPtr GetStdHandle(int handle);

        public static void EnableQuickEditMode()
        {
            int mode;
            IntPtr handle = GetStdHandle(STD_INPUT_HANDLE);
            GetConsoleMode(handle, out mode);
            mode |= ENABLE_QUICK_EDIT_MODE;
            SetConsoleMode(handle, mode);
        }
    }
}
