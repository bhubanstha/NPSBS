using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Montessori
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            Bitmap bmp = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\Images\\close.png");           
            Bitmap bmp1 = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\Images\\NPSBS.png");
            Bitmap bmp2 = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\Images\\Me.jpg");
           
            InitializeComponent();
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://www.bhubanshrestha.blogspot.com/";
            linkLabel1.Links.Add(link);
            pictureBox1.BackgroundImage = bmp;
            pictureBox2.BackgroundImage = bmp1;
            pictureBox3.BackgroundImage = bmp2;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }
    }
}
