using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Education.Common;
using Montessori.Core;
using Registration;
using Utility;

namespace Montessori
{
	public partial class frmMain : Form
	{
		private DataAccess dataAccess;
		public frmMain()
		{
			InitializeComponent();
			dataAccess = new DataAccess(App.KidsZone);
			SetBackground();
		}


		private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmSubject fs = new frmSubject();
			fs.MdiParent = this;
			fs.Show();
		}

		frmExam fexam = null;
		private void examToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (fexam != null && fexam.Disposing)
			{
				fexam.Dispose();
			}
			if (fexam == null)
			{
				fexam = new frmExam();
			}
			try
			{
				fexam.Show();
			}
			catch
			{
				fexam = null;
				fexam = new frmExam();
			}
			finally
			{
				fexam.MdiParent = this;
				fexam.WindowState = FormWindowState.Maximized;
				fexam.Show();
			}
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmStudent fs = new frmStudent();
			fs.MdiParent = this;
			fs.Show();
		}

		private void transferToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmTransferStudent fsTran = new frmTransferStudent();
			fsTran.MdiParent = this;
			fsTran.Show();
		}

		private void markEntryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmMarkEntry markEntry = new frmMarkEntry();
			markEntry.MdiParent = this;
			markEntry.WindowState = FormWindowState.Maximized;
			markEntry.Show();
		}

		frmResult fResult = null;
		private void resultToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (fResult == null)
			{
				fResult = new frmResult();
			}
			//fResult.MdiParent = this;
			fResult.ShowDialog();
		}

		/*
		frmGradingSystem fsGs = null;
		private void gradingSystemToolStripMenuItem_Click(object sender, EventArgs e)
		{            
				if (fsGs != null &&  fsGs.Disposing)
				{
						fsGs.Dispose();
				}
				if (fsGs == null)
				{
						fsGs = new frmGradingSystem();
				}
				try
				{
						fsGs.Show();
				}
				catch (Exception ex)
				{
						fsGs = null;
						fsGs = new frmGradingSystem(); 
				}
				finally{
						fsGs.MdiParent = this;
						fsGs.WindowState = FormWindowState.Maximized;
						fsGs.Show();
				}

		}
		*/
		private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void SetBackground()
		{
			foreach (Control ctrl in this.Controls)
			{
				if (ctrl is MdiClient)
				{
					Bitmap bg = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\Images\\MainBg.jpg");
					//ctrl.BackgroundImageLayout = ImageLayout.Stretch;
					ctrl.BackgroundImage = bg;
					ctrl.BackgroundImageLayout = ImageLayout.Stretch;
					break;
				}
			}
		}


		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			this.Refresh();
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		frmExtraActivities fExtra = null;
		private void extraActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fExtra = new frmExtraActivities();
			fExtra.MdiParent = this;
			fExtra.WindowState = FormWindowState.Maximized;
			fExtra.Show();
		}

		private void indexToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog sf = new SaveFileDialog();
			sf.Title = "Backup Database";
			sf.DefaultExt = "bak";
			sf.Filter = "Backup (*.bak)|*.bak";
			if (sf.ShowDialog() == DialogResult.OK && sf.FileName.Length > 0)
			{
				try
				{
					this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
					string q = "Backup database KidsZone to disk = '" + sf.FileName + "'";
					var cmd = dataAccess.CreateCommand();
					cmd.CommandType = CommandType.Text;
					cmd.CommandText = q;
					dataAccess.ExecuteNonQuery(cmd);
					Response.Success("Database backup successfully.");
				}
				catch (Exception ex)
				{
					Response.GenericError(ex.Message.ToString());
				}
				finally
				{
					this.Cursor = Cursors.Default;
				}

			}

		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAbout fa = new frmAbout();
			fa.ShowDialog();
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == NativeMethods.WM_SHOWME)
			{
				ShowMe();
			}
			base.WndProc(ref m);
		}
		private void ShowMe()
		{
			if (WindowState == FormWindowState.Minimized)
			{
				WindowState = FormWindowState.Maximized;
			}
			// get our current "TopMost" value (ours will always be false though)
			bool top = TopMost;
			// make our form jump to the top of everything
			TopMost = true;
			// set it back to whatever it was
			TopMost = top;
		}

		private void remarksToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmRemarks fr = new frmRemarks();
			fr.MdiParent = this;
			fr.WindowState = FormWindowState.Maximized;
			fr.Show();
		}

		private void registerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Register register = Register.Instance;
			register.ShowRegistrationForm(RegInfo.AppName, RegInfo.AppKey, this.Icon);
		}
	}
}
