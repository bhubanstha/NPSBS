using System;
using System.Threading;
using System.Windows.Forms;
using Montessori.Core;
using Registration;


namespace Montessori
{
	static class Program
	{
		static Mutex mutext = new Mutex(true, "{97d61c9e-8cbf-4c7f-8c88-206abab06902}");
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
				frmSplash splash;
				if (register.IsSoftwareRegistered())
				{
					splash  = new frmSplash();
					Application.Run(splash);					
					mutext.ReleaseMutex();
				}
				else
				{
					DialogResult result = MessageBox.Show("Software registration is expired. Do you want to enter new registration key.", "Registration", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
					if (result == DialogResult.Yes)
					{
						register.ShowRegistrationForm(RegInfo.AppName, RegInfo.AppKey, Properties.Resources.AppIcon);
						Application.Restart();
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
