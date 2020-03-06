using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NPSBS.Core;
using Utility;

namespace NPSBS
{
	public partial class frmAbout : Form
	{
		public frmAbout()
		{
			InitializeComponent();
			lblVersion.Text = "Version: " + Constant.AppVersion;
			Image image = ImageUtility.GetImage(Constant.SchoolLogo);
			picLogo.BackgroundImage = image;

		}



		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmAbout_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawRectangle(new Pen(Color.Black, 3), this.DisplayRectangle);
		}

		private void frmAbout_Shown(object sender, EventArgs e)
		{
			lblCopyRight.Text = StartupCache.About.SchoolSoftwareAbout;
		}

	}
}
