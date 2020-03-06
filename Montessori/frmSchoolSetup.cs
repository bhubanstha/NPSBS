﻿using ComponentFactory.Krypton.Toolkit;
using Montessori.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;

namespace Montessori
{
    public partial class frmSchoolSetup : KryptonForm
    {

        private string imageFile = string.Empty;
        private string appPath = AppDomain.CurrentDomain.BaseDirectory;
        private frmMdiMain mdiForm;
        private bool isNewLogoSelected = false;
        BackgroundWorker worker = new BackgroundWorker();
        School s;
        public frmSchoolSetup(frmMdiMain frmMain)
        {
            InitializeComponent();

            mdiForm = frmMain;
            lblSchoolId.Visible = false;
            worker.DoWork += UpdateContent;
        }

        private void UpdateContent(object sender, DoWorkEventArgs e)
        {
            StartupCache.School = s;
            StartupCache.About = OnlineContent.ChangeAbout(StartupCache.About, s.ShortName, s.SchoolName, s.Address);

        }


		private void frmSchoolSetup_Load(object sender, EventArgs e)
		{
			s = new School();
			txtSchoolName.Text = s.SchoolName;
			txtShortName.Text = s.ShortName;
			txtAddress.Text = s.Address;
			txtPhoneNo.Text = s.PhoneNo;
			txtEmail.Text = s.Email;
			txtWebsite.Text = s.WebSite;
			if (s.Logo != null && s.Logo.Length > 0)
			{
				Image image = ImageUtility.GetImage(Constant.MontessoriLogo).ResizeImage(200, 200);// ImageUtility.ByteToImage(school.Logo);
				if (image != null)
				{
					picLogo.Image = image;
				}
			}
			lblSchoolId.Text = s.Id.ToString();
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
				Image image = ImageUtility.GetImage(ofd.FileName).ResizeImage(200, 200);
				picLogo.Image = image;
				isNewLogoSelected = true;
			}
		}

		private void btnRemoveLogo_Click(object sender, EventArgs e)
		{
			imageFile = string.Empty;
			picLogo.Image = null;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			s = new School()
			{
				SchoolName = txtSchoolName.Text.Trim(),
				ShortName = txtShortName.Text.Trim(),
				Address = txtAddress.Text.Trim(),
				PhoneNo = txtPhoneNo.Text.Trim(),
				Email = txtEmail.Text.Trim(),
				WebSite = txtWebsite.Text.Trim(),
				Id = Convert.ToInt32(lblSchoolId.Text),
				EstiblishedYear = txtEstablishedYear.Text,
				Slogan = txtSlogan.Text
			};
			if (picLogo.Image != null && isNewLogoSelected)
			{
				s.Logo = ImageUtility.ImageToByteArray(picLogo.Image);
				CreateNewBackground();
				picLogo.Image.Save(Constant.SchoolLogo, ImageFormat.Png);
			}
			int id = s.SaveOrUdate();
			lblSchoolId.Text = id.ToString();
			if (!worker.IsBusy)
			{
				worker.RunWorkerAsync();
			}
			if (id > 0)
			{
				Response.Success("School information updated.");
			}
		}


		private void CreateNewBackground()
		{
			Image bgImage = Image.FromFile(Constant.MainBackground);
			Image newBg = ImageUtility.SetWaterMark(bgImage, picLogo.Image, 0.5f, StartupCache.About.DeveloperContactNo);
			if (File.Exists(Constant.SchoolBackground))
			{
				File.Delete(Constant.SchoolBackground);
			}
			picLogo.Image = ImageUtility.RemoveTransparency(picLogo.Image);
			newBg.Save(Constant.SchoolBackground);
			mdiForm.SetBackground();
		}
	}
}
