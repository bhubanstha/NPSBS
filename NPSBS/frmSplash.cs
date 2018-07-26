using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using NPSBS.Core;
using Utility;

namespace NPSBS
{
	public partial class frmSplash : Form
	{

		BackgroundWorker bWorker = new BackgroundWorker();
        public frmSplash()
		{
			InitializeComponent();
			lblComponents.Text = "Checking Server Connection...";
			bWorker.DoWork += new DoWorkEventHandler(bWorker_DoWork);
			bWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bWorker_RunWorkerCompleted);
			bWorker.RunWorkerAsync(lblComponents);
		}

		void bWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			var r = (bool)e.Result;
			if (r)
			{
				BackgroundWorker b = new BackgroundWorker();
				b.RunWorkerAsync();
                
                lblComponents.Text = "Connection Ok";
				Thread.Sleep(2000);
				//lblComponents.Text = "Global Function"; 
				frmMdiMain fm = new frmMdiMain();
                
				fm.Show();
				this.Hide();
			}
			else
			{
				lblComponents.Text = "Problem connecting with server";
				string a = ConnectionChecker.GetConnectionstring();
				Response.GenericError(a);

				this.Refresh();
				Thread.Sleep(2000);
				this.Close();
			}
		}

		void bWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			var lbl = (Label)e.Argument;
            bool result = ConnectionChecker.CheckConnection();
            if (result)
            {
                StartupCache sc = StartupCache.Instance;
                StartupCache.About = OnlineContent.GetAbout();
            }
            e.Result = result;
        }
	}
}
