﻿using System;
using System.Drawing;
using NPSBS.Core;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Drawing.Imaging;
using Utility;
using System.ComponentModel;
using ComponentFactory.Krypton.Toolkit;

namespace NPSBS
{
	public partial class frmSchoolSetup : KryptonForm
	{
		private string imageFile = string.Empty;
		private string appPath = AppDomain.CurrentDomain.BaseDirectory;
		private frmMdiMain mdiForm;
		private bool isNewLogoSelected = false;
		BackgroundWorker worker = new BackgroundWorker();
		School s;
		public frmSchoolSetup(frmMdiMain frmMdiMain)
		{
			InitializeComponent();
			mdiForm = frmMdiMain;
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
				Image image = ImageUtility.GetImage(Constant.Logo).ResizeImage(200, 200);// ImageUtility.ByteToImage(school.Logo);
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
			if (SaveValidation())
			{
				s = StartupCache.School;// new School()
										//{
										//	SchoolName = txtSchoolName.Text.Trim(),
										//	ShortName = txtShortName.Text.Trim(),
										//	Address = txtAddress.Text.Trim(),
										//	PhoneNo = txtPhoneNo.Text.Trim(),
										//	Email = txtEmail.Text.Trim(),
										//	WebSite = txtWebsite.Text.Trim(),
										//	Id = Convert.ToInt32(lblSchoolId.Text),
										//	EstiblishedYear = txtEstablishedYear.Text,
										//	Slogan = txtSlogan.Text
										//};
				if (picLogo.Image != null && isNewLogoSelected)
				{
					s.Logo = ImageUtility.ImageToByteArray(picLogo.Image);
					CreateNewBackground();
					picLogo.Image.Save(Constant.Logo, ImageFormat.Png);
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
		}


		private void CreateNewBackground()
		{
			Image bgImage = Image.FromFile(Constant.MainBackground);
			Image newBg = ImageUtility.SetWaterMark(bgImage, picLogo.Image, 0.5f, StartupCache.About.DeveloperContactNo);
			if (File.Exists(Constant.Background))
			{
				File.Delete(Constant.Background);
			}
			picLogo.Image = ImageUtility.RemoveTransparency(picLogo.Image);
			newBg.Save(Constant.Background);
			mdiForm.SetBackground();
		}


		private bool SaveValidation()
		{
			bool status = true;
			errorProvider1.Clear();
			errorProvider2.Clear();
			errorProvider3.Clear();
			errorProvider4.Clear();
			errorProvider5.Clear();
			errorProvider6.Clear();
			errorProvider7.Clear();

			if (txtSchoolName.Text.Trim().Length == 0)
			{
				errorProvider1.SetError(txtSchoolName, "School name is required.");
				status = false;
			}
			if (txtShortName.Text.Trim().Length == 0)
			{
				errorProvider2.SetError(txtShortName, "School short name is required.");
				status = false;
			}
			if (txtAddress.Text.Trim().Length == 0)
			{
				errorProvider3.SetError(txtShortName, "School address is required.");
				status = false;
			}
			if (txtPhoneNo.Text.Trim().Length == 0)
			{
				errorProvider4.SetError(txtPhoneNo, "School phone number is required.");
				status = false;
			}
			if (txtEstablishedYear.Text.Trim().Length == 0)
			{
				errorProvider5.SetError(txtEstablishedYear, "School established year is required.");
				status = false;
			}
			if (txtSlogan.Text.Trim().Length == 0)
			{
				errorProvider6.SetError(txtSlogan, "School slogan is required.");
				status = false;
			}
			if (picLogo.Image == null)
			{
				errorProvider7.SetError(picLogo, "School Logo is required.");
				status = false;
			}

			return status;
		}

	}
}
