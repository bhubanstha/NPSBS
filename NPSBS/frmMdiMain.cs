﻿using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Ribbon;
using ComponentFactory.Krypton.Toolkit;
using NPSBS.Core;
using System.Data;
using Registration;

namespace NPSBS
{
	public partial class frmMdiMain : frmBase
	{
		private Timer timer;
		private frmSubject frmSubject = null;
		private frmSchoolSetup frmSchool = null;
		private frmExam frmExam = null;
		private frmStudent frmStudent = null;
		private frmTransferStudent frmTransfer = null;
		private frmMarkEntry frmMarkEntry = null;
		private frmExtraActivities frmExtraActivities = null;
		private frmAttendance frmAttendance = null;
		private frmResult frmResult = null;
		private frmLedger frmLedger = null;

		public frmMdiMain()
		{
			InitializeComponent();
			this.ControlBox = true;
			timer = new Timer();
			timer.Interval = 1000;
			timer.Tick += Timer_Tick;
			timer.Start();
			SetBackground();
			string themeName = Properties.Settings.Default.ThemeName;
			SetTheme(themeName);
			CheckButton(themeName);
		}
		private void Timer_Tick(object sender, EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
		}

		private void btnSchoolSetup_Click(object sender, EventArgs e)
		{
			if (frmSchool == null || frmSchool.IsDisposed || frmSchool.Disposing)
			{
				frmSchool = new frmSchoolSetup();
			}
			frmSchool.MdiParent = this;
			frmSchool.Show();
		}

		private void btnApplyTheme_Click(object sender, EventArgs e)
		{
			var button = sender as KryptonRibbonGroupButton;
			string themeName = button.TextLine1;
			SetTheme(themeName);
			button.Checked = true;
		}


		private void SetTheme(string themeName)
		{
			btn13Blue.Checked = false;
			btn13White.Checked = false;
			btn10Black.Checked = false;
			btn10Blue.Checked = false;
			btn10Silver.Checked = false;
			btn07Black.Checked = false;
			btn07Blue.Checked = false;
			btn07Silver.Checked = false;
			btnSBlue.Checked = false;
			btnWin2003.Checked = false;
			switch (themeName)
			{
				case "2013 Default":
					themeManager.GlobalPaletteMode = PaletteModeManager.Office2013;
					break;
				case "2013 White":
					themeManager.GlobalPaletteMode = PaletteModeManager.Office2013White;
					break;
				case "2010 Blue":
					themeManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
					break;
				case "2010 Silver":
					themeManager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
					break;
				case "2010 Black":
					themeManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
					break;
				case "2007 Blue":
					themeManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
					break;
				case "2007 Silver":
					themeManager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
					break;
				case "2007 Black":
					themeManager.GlobalPaletteMode = PaletteModeManager.Office2007Black;
					break;
				case "Sparkle":
					themeManager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
					break;
				case "Windows 2003":
					themeManager.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
					break;
				default:
					themeManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
					break;
			}
			Properties.Settings.Default.ThemeName = themeName;
			Properties.Settings.Default.Save();
		}
		private void CheckButton(string themeName)
		{
			switch (themeName)
			{
				case "2013 Default":
					btn13Blue.Checked = true;
					break;
				case "2013 White":
					btn13White.Checked = true;
					break;
				case "2010 Blue":
					btn10Blue.Checked = true;
					break;
				case "2010 Silver":
					btn10Silver.Checked = true;
					break;
				case "2010 Black":
					btn10Black.Checked = true;
					break;
				case "2007 Blue":
					btn07Blue.Checked = true;
					break;
				case "2007 Silver":
					btn07Silver.Checked = true;
					break;
				case "2007 Black":
					btn07Black.Checked = true;
					break;
				case "Sparkle":
					btnSBlue.Checked = true;
					break;
				case "Windows 2003":
					btnWin2003.Checked = true;
					break;
				default:
					btn10Blue.Checked = true;
					break;
			}
		}
		private void SetBackground()
		{
			foreach (Control ctrl in this.Controls)
			{
				if (ctrl is MdiClient)
				{
					ctrl.BackgroundImage = Properties.Resources._1906811;
					ctrl.BackgroundImageLayout = ImageLayout.Stretch;
					break;
				}
			}
		}

		private void btnSubject_Click(object sender, EventArgs e)
		{
			if (frmSubject == null || frmSubject.Disposing || frmSubject.IsDisposed)
			{
				frmSubject = new frmSubject();
			}
			frmSubject.MdiParent = this;
			frmSubject.Show();
		}

		private void kryptonRibbonGroupButton3_Click(object sender, EventArgs e)
		{
			if (frmExam == null || frmExam.Disposing || frmExam.IsDisposed)
			{
				frmExam = new frmExam();
			}
			frmExam.MdiParent = this;
			frmExam.Show();
		}

		private void kryptonRibbonGroupButton1_Click(object sender, EventArgs e)
		{
			if (frmStudent == null || frmStudent.Disposing || frmStudent.IsDisposed)
			{
				frmStudent = new frmStudent();
			}
			frmStudent.MdiParent = this;
			frmStudent.Show();
		}

		private void rbnTransferStudent_Click(object sender, EventArgs e)
		{
			if (frmTransfer == null || frmTransfer.Disposing || frmTransfer.IsDisposed)
			{
				frmTransfer = new frmTransferStudent();
			}
			frmTransfer.MdiParent = this;
			frmTransfer.Show();
		}

		private void rbnMarkEntry_Click(object sender, EventArgs e)
		{
			if (frmMarkEntry == null || frmMarkEntry.Disposing || frmMarkEntry.IsDisposed)
			{
				frmMarkEntry = new frmMarkEntry();
			}
			frmMarkEntry.MdiParent = this;
			frmMarkEntry.Show();
		}

		private void rbnExtraActivity_Click(object sender, EventArgs e)
		{
			if (frmExtraActivities == null || frmExtraActivities.Disposing || frmExtraActivities.IsDisposed)
			{
				frmExtraActivities = new frmExtraActivities();
			}
			frmExtraActivities.MdiParent = this;
			frmExtraActivities.Show();
		}

		private void rbnAttendance_Click(object sender, EventArgs e)
		{
			if (frmAttendance == null || frmAttendance.Disposing || frmAttendance.IsDisposed)
			{
				frmAttendance = new frmAttendance();
			}
			frmAttendance.MdiParent = this;
			frmAttendance.Show();
		}

		private void rbnResult_Click(object sender, EventArgs e)
		{
			if (frmResult == null || frmResult.Disposing || frmResult.IsDisposed)
			{
				frmResult = new frmResult();
			}
			frmResult.MdiParent = this;
			frmResult.Show();
		}

		private void rbnLedger_Click(object sender, EventArgs e)
		{
			if (frmLedger == null || frmLedger.Disposing || frmLedger.IsDisposed)
			{
				frmLedger = new frmLedger();
			}
			frmLedger.MdiParent = this;
			frmLedger.Show();
		}

		private void rbnBackup_Click(object sender, EventArgs e)
		{
			SaveFileDialog sf = new SaveFileDialog();
			sf.Title = "Backup Database";
			sf.DefaultExt = "bak";
			sf.Filter = "Backup (*.bak)|*.bak";
			if (sf.ShowDialog() == DialogResult.OK && sf.FileName.Length > 0)
			{
				try
				{
					this.Cursor = Cursors.WaitCursor;
					string q = "Backup database NPSBS to disk = '" + sf.FileName + "'";
					var cmd = DataAccess.CreateCommand();
					cmd.CommandType = CommandType.Text;
					cmd.CommandText = q;
					DataAccess.ExecuteNonQuery(cmd);
					Response.Success("Database backup successfully.");
					this.Cursor = Cursors.Default;
				}
				catch (Exception ex)
				{
					Response.GenericError(ex.Message.ToString());
				}
			}
		}

		private void rbnRegister_Click(object sender, EventArgs e)
		{
			Register register = Register.Instance;
			register.ShowRegistrationForm(RegInfo.AppName, RegInfo.AppKey, this.Icon);
		}

		private void rbnAbout_Click(object sender, EventArgs e)
		{
			frmAbout frmAbout = new frmAbout();
			frmAbout.ShowDialog();
		}
	}
}
