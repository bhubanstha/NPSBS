using System;
using System.Drawing;
using NPSBS.Core;
using System.Windows.Forms;
using System.Collections.Generic;

namespace NPSBS
{
    public partial class frmSchoolSetup : frmBase
    {
        private string imageFile = string.Empty;
        private string appPath = AppDomain.CurrentDomain.BaseDirectory;
        private frmMdiMain mdiForm;

        public frmSchoolSetup(frmMdiMain frmMdiMain)
        {
            InitializeComponent();
            mdiForm = frmMdiMain;
        }

        private void frmSchoolSetup_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofd.RestoreDirectory = true;
            ofd.Filter = "Image File|*.jpg;*.jpeg;*.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                imageFile = ofd.FileName;
                Image image = Image.FromFile(ofd.FileName);
                picLogo.Image = image;
            }
        }

        private void btnRemoveLogo_Click(object sender, EventArgs e)
        {
            imageFile = string.Empty;
            picLogo.Image = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            picLogo.Image.Save(appPath + "schoolLogo.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            CreateNewBackground();
        }


        private void CreateNewBackground()
        {
            string bg = appPath + "mainbg.jpg";
            string logo = appPath + "schoolLogo.jpg";
            string newBg = appPath + "bgMain.jpg";
            StartupCache.CreateBackgroundImage(bg, logo, newBg);
            mdiForm.SetBackground();
        }
    }
}
