using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using NPSBS.Core;
using Utility;
using System;
using Education.Common;

namespace NPSBS
{
	public partial class frmSplash : Form
	{

		BackgroundWorker bWorker = new BackgroundWorker();
		BackgroundWorker bWorker1 = new BackgroundWorker();
		BackgroundWorker bWorker2 = new BackgroundWorker();
		System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
		public frmSplash()
		{
			InitializeComponent();
			lblComponents.Text = "Checking Server Connection...";
		}

		void CheckDatabaseConnection(object sender, DoWorkEventArgs e)
		{
			bool result = ConnectionChecker.CheckConnection(App.NPSBS);
			e.Result =  result;
		}

		void DatabaseCheckConnectionComplete(object sender, RunWorkerCompletedEventArgs e)
		{
			var r = (bool)e.Result;
			if (r)
			{

				lblComponents.Text = string.Format("{0}{1}{2}", "Connection Ok", Environment.NewLine, "Loading Required Data");
				bWorker1.DoWork += new DoWorkEventHandler(LoadData);
				bWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(DataLoadComplete);
				bWorker1.RunWorkerAsync(lblComponents);
			}
			else
			{
				lblComponents.Text = "Problem connecting with server";
				this.Refresh();
				Thread.Sleep(2000);
				Application.Exit();
			}
		}


		void LoadData(object sender, DoWorkEventArgs e)
		{
			StartupCache sc = StartupCache.Instance;
		}
		void DataLoadComplete(object sender, RunWorkerCompletedEventArgs e)
		{
			lblComponents.Text = string.Format("{0}{1}{2}", "Data Loading", Environment.NewLine, "Downloading content from online.");
			bWorker2.DoWork += new DoWorkEventHandler(GetOnlineContent);
			bWorker2.RunWorkerCompleted += new RunWorkerCompletedEventHandler(OnlineContentLoadComplete);
			bWorker2.RunWorkerAsync(lblComponents);
		}

		async void GetOnlineContent(object sender, DoWorkEventArgs e)
		{
			StartupCache.About = await OnlineContent.GetAbout(StartupCache.School.ShortName, StartupCache.School.SchoolName, StartupCache.School.Address);
		}

		void OnlineContentLoadComplete(object sender, RunWorkerCompletedEventArgs e)
		{
			frmMdiMain fm = new frmMdiMain();
			fm.Show();
			this.Hide();
		}

		private void frmSplash_Shown(object sender, EventArgs e)
		{
			t.Interval = 2000;
			t.Tick += T_Tick;
			t.Enabled = true;
		}
		private void T_Tick(object sender, EventArgs e)
		{
			t.Enabled = false;
			bWorker.DoWork += new DoWorkEventHandler(CheckDatabaseConnection);
			bWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(DatabaseCheckConnectionComplete);
			bWorker.RunWorkerAsync(lblComponents);
		}
	}
}
