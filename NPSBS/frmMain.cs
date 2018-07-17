using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPSBS.Core;
using Registration;

namespace NPSBS
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
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
			catch (Exception ex)
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
					//ctrl.BackgroundImageLayout = ImageLayout.Stretch;
					ctrl.BackgroundImage = Properties.Resources._1906811;
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

		private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAttendance fa = new frmAttendance();
			fa.WindowState = FormWindowState.Maximized;
			fa.TopMost = true;
			fa.MdiParent = this;
			fa.Show();
		}

		private void ledgerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmLedger fl = new frmLedger();
			fl.ShowDialog();
		}

		private void registerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Register register = Register.Instance;
			register.ShowRegistrationForm(RegInfo.AppName, RegInfo.AppKey, this.Icon);
		}
	}
}
