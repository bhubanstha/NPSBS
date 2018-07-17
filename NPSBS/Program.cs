using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace NPSBS
{
    static class Program
    {

        static Mutex mutext = new Mutex(true, "{0fc6fc12-7568-4a8e-9bae-525315aec6fa}");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if(mutext.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmSplash());
                mutext.ReleaseMutex();
            }
            else
            {
                NativeMethods.PostMessage(
                 (IntPtr)NativeMethods.HWND_BROADCAST,
                 NativeMethods.WM_SHOWME,
                 IntPtr.Zero,
                 IntPtr.Zero);
            }   
            
        }
    }
}
