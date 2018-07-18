using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using NPSBS.Core;
using Registration;


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
			if (mutext.WaitOne(TimeSpan.Zero, true))
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Register register = Register.Instance;
                register.SetSoftwareName(RegInfo.AppName);
                register.SetKey(RegInfo.AppKey);
                frmSplash splash = new frmSplash();
				if (register.IsSoftwareRegistered())
				{
					StartupCache sc = StartupCache.Instance;
					Application.Run(splash);
					mutext.ReleaseMutex();
				}
				else
				{
					DialogResult result = MessageBox.Show("Software registration is expired. Do you want to enter new registration key.", "Registration", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
					if (result == DialogResult.Yes)
					{
						register.ShowRegistrationForm(RegInfo.AppName, RegInfo.AppKey, splash.Icon);
					}
					else
					{
						Application.Exit();
					}
				}
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
