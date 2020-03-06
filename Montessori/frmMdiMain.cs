using ComponentFactory.Krypton.Ribbon;
using ComponentFactory.Krypton.Toolkit;
using Montessori.Core;
using Registration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;

namespace Montessori
{
    public partial class frmMdiMain : KryptonForm
    {
		private Timer timer, timer1;
		private frmSubject frmSubject = null;
		private frmSchoolSetup frmSchool = null;
		private frmExam frmExam = null;
		private frmStudent frmStudent = null;
		private frmTransferStudent frmTransfer = null;
		private frmMarkEntry frmMarkEntry = null;
		private frmExtraActivities frmExtraActivities = null;
		private frmRemarks frmRemarks = null;
		private frmResult frmResult = null;

		private string path = AppDomain.CurrentDomain.BaseDirectory;
		public frmMdiMain()
        {
            InitializeComponent();

			this.ControlBox = true;
			tabManager.Visible = false;
			tabManager.AutoDetectMdiChildWindows = false;
			timer = new Timer();
			timer.Interval = 1000;
			timer.Tick += Timer_Tick;
			timer1 = new Timer();
			timer1.Interval = 100;
			timer1.Tick += Timer1_Tick;
			timer.Start();
			timer1.Start();
			SetBackground();
			string themeName = Properties.Settings.Default.ThemeName;
			SetTheme(themeName);
			CheckButton(themeName);
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			if (CheckFormOpen())
			{
				tabManager.Visible = true;
			}
			else
			{
				tabManager.Visible = false;
			}
		}

		private bool CheckFormOpen()
		{
			bool isFormOpen = Application.OpenForms.Cast<Form>()
					.Any(form => (!form.Name.Equals("frmSplash", StringComparison.OrdinalIgnoreCase)
					&& !form.Name.Equals("frmMdiMain", StringComparison.OrdinalIgnoreCase)
					&& !form.Name.Equals("frmAbout", StringComparison.OrdinalIgnoreCase)
					&& !form.Name.Equals("frmRegistration", StringComparison.OrdinalIgnoreCase)
					));
			return isFormOpen;
		}
		private void SetTheme(string themeName)
		{
			kryptonManager1.ResetGlobalPalette();
			kryptonManager1.GlobalAllowFormChrome = true;
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
				case "2010 Blue":
					kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
					break;
				case "2010 Silver":
					kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
					break;
				case "2010 Black":
					kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2010Black;
					break;
				case "2007 Blue":
					kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
					break;
				case "2007 Silver":
					kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
					break;
				case "2007 Black":
					kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2007Black;
					break;
				case "Sparkle":
					kryptonManager1.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
					break;
				case "Windows 2003":
					kryptonManager1.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
					break;
				default:
					kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
					break;
			}
			Properties.Settings.Default.ThemeName = themeName;
			Properties.Settings.Default.Save();
		}

		private void CheckButton(string themeName)
		{
			switch (themeName)
			{
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

		public void SetBackground()
		{
			foreach (Control ctrl in this.Controls)
			{
				if (ctrl is MdiClient)
				{

					Image image = ImageUtility.GetImage(Constant.MainBackground);
					if (File.Exists(Constant.Background))
					{
						image = new Bitmap(ImageUtility.GetImage(Constant.Background));
					}
					ctrl.BackgroundImage = image;
					ctrl.BackgroundImageLayout = ImageLayout.Zoom;
					break;
				}
			}
		}

		private void btnSubject_Click(object sender, EventArgs e)
		{
			if (frmSubject == null || frmSubject.IsDisposed || frmSubject.Disposing)
			{
				frmSubject = new frmSubject();
			}
			tabManager.AddWindow(frmSubject);
			tabManager.SetActiveWindow(frmSubject);
			frmSubject.Invalidate();
		}

		private void kryptonRibbonGroupButton3_Click(object sender, EventArgs e)
		{
			if (frmExam == null || frmExam.IsDisposed || frmExam.Disposing)
			{
				frmExam = new frmExam();
			}
			tabManager.AddWindow(frmExam);
			tabManager.SetActiveWindow(frmExam);
			frmExam.Invalidate();
		}

		private void rbnAddStudent_Click(object sender, EventArgs e)
		{
			if (frmStudent == null || frmStudent.IsDisposed || frmStudent.Disposing)
			{
				frmStudent = new frmStudent();
			}
			tabManager.AddWindow(frmStudent);
			tabManager.SetActiveWindow(frmStudent);
			frmStudent.Invalidate();
		}

		private void rbnTransferStudent_Click(object sender, EventArgs e)
		{
			if (frmTransfer == null || frmTransfer.IsDisposed || frmTransfer.Disposing)
			{
				frmTransfer = new frmTransferStudent();
			}
			tabManager.AddWindow(frmTransfer);
			tabManager.SetActiveWindow(frmTransfer);
			frmTransfer.Invalidate();
		}

		private void rbnMarkEntry_Click(object sender, EventArgs e)
		{
			if (frmMarkEntry == null || frmMarkEntry.IsDisposed || frmMarkEntry.Disposing)
			{
				frmMarkEntry = new frmMarkEntry();
			}
			tabManager.AddWindow(frmMarkEntry);
			tabManager.SetActiveWindow(frmMarkEntry);
			frmMarkEntry.Invalidate();
		}

		private void rbnExtraActivity_Click(object sender, EventArgs e)
		{
			if (frmExtraActivities == null || frmExtraActivities.IsDisposed || frmExtraActivities.Disposing)
			{
				frmExtraActivities = new frmExtraActivities();
			}
			tabManager.AddWindow(frmExtraActivities);
			tabManager.SetActiveWindow(frmExtraActivities);
			frmExtraActivities.Invalidate();
		}

		private void rbnAttendance_Click(object sender, EventArgs e)
		{

			if (frmRemarks == null || frmRemarks.IsDisposed || frmRemarks.Disposing)
			{
				frmRemarks = new frmRemarks();
			}
			tabManager.AddWindow(frmRemarks);
			tabManager.SetActiveWindow(frmRemarks);
			frmRemarks.Invalidate();
		}

		private void rbnResult_Click(object sender, EventArgs e)
		{
			if (frmResult == null || frmResult.IsDisposed || frmResult.Disposing)
			{
				frmResult = new frmResult();
			}
			tabManager.AddWindow(frmResult);
			tabManager.SetActiveWindow(frmResult);
			frmResult.Invalidate();
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
					string q = "Backup database KidsZone to disk = '" + sf.FileName + "'";
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

		private void frmMdiMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void btnApplyTheme_Click(object sender, EventArgs e)
		{
			var button = sender as KryptonRibbonGroupButton;
			string themeName = button.TextLine1;
			SetTheme(themeName);
			button.Checked = true;
		}

		private void btnSchoolSetup_Click(object sender, EventArgs e)
		{
			if (frmSchool == null || frmSchool.IsDisposed || frmSchool.Disposing)
			{
				frmSchool = new frmSchoolSetup(this);
			}
			tabManager.AddWindow(frmSchool);
			tabManager.SetActiveWindow(frmSchool);
			frmSchool.Invalidate();
		}

	}
}
