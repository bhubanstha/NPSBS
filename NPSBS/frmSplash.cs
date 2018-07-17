using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using NPSBS.Core;
using System.Configuration;

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

        void b_DoWork(object sender, DoWorkEventArgs e)
        {
            var sc = StartupCache.Instance;
            if (!StartupCache.IsComputerAuthorized)
            {
                Response.GenericError("You are not authorized to use the computer software in this machine.");
                Application.Exit();
            }
        }


        void bWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var r = (bool)e.Result;
            if (r)
            {
                BackgroundWorker b = new BackgroundWorker();
                b.DoWork += b_DoWork;
                b.RunWorkerAsync();

                lblComponents.Text = "Connection Ok";
                Thread.Sleep(200);
                //lblComponents.Text = "Global Function"; 
                frmMain fm = new frmMain();
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

            e.Result = ConnectionChecker.CheckConnection();

        }
    }
}
