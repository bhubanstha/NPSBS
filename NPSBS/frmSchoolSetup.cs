using System;
using System.Drawing;
using NPSBS.Core;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Drawing.Imaging;

using Utility;

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
            lblSchoolId.Visible = false;
        }

		private void frmSchoolSetup_Load(object sender, EventArgs e)
		{
            School school = new School();
            txtSchoolName.Text = school.SchoolName;
            txtShortName.Text = school.ShortName;
            txtAddress.Text = school.Address;
            txtPhoneNo.Text = school.PhoneNo;
            txtEmail.Text = school.Email;
            txtWebsite.Text = school.WebSite;
            if(school.Logo.Length>0)
            {
                Image image = ImageUtility.GetImage(Constant.NPSBSLogo);// ImageUtility.ByteToImage(school.Logo);
                if (image != null)
                {
                    picLogo.Image = image;
                }
            }
            lblSchoolId.Text = school.Id.ToString();            
		}

		private void btnLoadLogo_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			ofd.RestoreDirectory = true;
			ofd.Filter = "Image File|*.jpg;*.jpeg;*.png";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				imageFile = ofd.FileName;
				Image image = ImageUtility.GetImage(ofd.FileName).ResizeImage(200,200);
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
            School s = new School()
            {
             SchoolName = txtSchoolName.Text.Trim(),
             ShortName = txtShortName.Text.Trim(),
             Address = txtAddress.Text.Trim(),
             PhoneNo = txtPhoneNo.Text.Trim(),
             Email = txtEmail.Text.Trim(),
             WebSite = txtWebsite.Text.Trim(),
             Id = Convert.ToInt32(lblSchoolId.Text)
            };
            if(picLogo.Image != null)
            {
                s.Logo = ImageUtility.ImageToByteArray(picLogo.Image);                
                CreateNewBackground();
                picLogo.Image.Save(Constant.NPSBSLogo, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            int id = s.SaveOrUdate();
            lblSchoolId.Text = id.ToString();
		}


		private void CreateNewBackground()
		{
			Image bgImage = Image.FromFile(Constant.MainBackground);			
			Image newBg = ImageUtility.SetWaterMark(bgImage, picLogo.Image, 0.5f, StartupCache.About.DeveloperContactNo);
			if (File.Exists(Constant.NPSBSBackground))
			{
				File.Delete(Constant.NPSBSBackground);
			}
            picLogo.Image = ImageUtility.RemoveTransparency(picLogo.Image);
			newBg.Save(Constant.NPSBSBackground);
			mdiForm.SetBackground();
		}

        
	}
}
