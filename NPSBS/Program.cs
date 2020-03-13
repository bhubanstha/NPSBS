﻿using System;
using System.Threading;
using System.Windows.Forms;
using NPSBS.Core;
using Registration;
using Utility;

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
				Application.ThreadException += Application_ThreadException;
				frmSplash splash;
				if ( register.IsSoftwareRegistered(RegInfo.AppKey, RegInfo.AppKey, false))
				{
					splash  = new frmSplash();
					//Logger l = Logger.Instance;
					Application.Run(splash);
					mutext.ReleaseMutex();
				}
				else
				{
					DialogResult result = MessageBox.Show("Software registration is expired. Do you want to enter new registration key.", "Registration", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
					if (result == DialogResult.Yes)
					{
						bool isKeyApplied = register.ShowRegistrationForm(RegInfo.AppName, RegInfo.AppKey, Properties.Resources.AppIcon);
						if (isKeyApplied)
						{
							Application.Restart();
						}
						else
						{
							Application.Exit();
						}
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
				MessageBox.Show("Another instance of application is already running. If you don't see application icon in taskbar, please close application from task manager.", RegInfo.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}

		private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
		{

		}
	}
}
