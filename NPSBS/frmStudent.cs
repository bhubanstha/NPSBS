using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPSBS.Core;
using System.Diagnostics;
using OfficeOpenXml;
using System.IO;
using ComponentFactory.Krypton.Toolkit;
using Education.Common;

namespace NPSBS
{
    public partial class frmStudent : KryptonForm
    {
        Student s = new Student();
        int rows;
        private bool _searchApplied = false;
        public frmStudent()
        {
            InitializeComponent();
            GetClass();
            SetAutoComplete();
            GetStudent();
            GridViewEditDelete.AddActions(gvStudents);
            
        }


        private void btnAction_Click(object sender, EventArgs e)
        {
            if (SaveValidation())
            {
                s.StudentName = txtStudentName.Text;
                s.Gender = rdoMale.Checked ? 'M' : 'F';
                s.ClassId = Convert.ToInt32(ddlClass.SelectedValue);
                s.EnrolledYear = txtAcademicYear.Text;
                s.RollNumber = txtRollNumber.Text;

                if (btnAction.Text.ToLower() == "save")
                {
                    rows = s.Save(s);
                    Response.SaveMessage(rows);
                }
                else if (btnAction.Text.ToLower() == "update")
                {
                    s.StudentId = Convert.ToInt32(lblStudentID.Text);
                    rows = s.Update(s);
                    lblStudentID.Text = "0";
                    btnAction.Text = "Save";
                    Response.UpdateMessage(rows);
                }
                if (rows > 0)
                {
                    Clear();
                    GetStudent();
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            fd.Title = "Import Student List";
            fd.DefaultExt = "xlsx";
            fd.Filter = "Excel Worksheet (*.xlsx)|*.xlsx";
            if (fd.ShowDialog() == DialogResult.OK && fd.FileName.Length > 0)
            {
                var file = new FileInfo(fd.FileName);
                ExcelPackage package = new ExcelPackage(file);
                lblReading.Text = "Reading Excel File...";
                DataTable tbl = package.ToDataTable();
                lblReading.Text = "Uploading Excel Content...";
                rows = s.BulkUpload(tbl);
                lblReading.Text = "Excel Content Upload Complete.";
                Response.BulkUploadMessage(rows);
                lblReading.Text = "";
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (SearchValidation())
            {
                string name = txtStudentNameSearch.Text.Trim();
                string classId = ddlClassSearch.SelectedValue.ToString();
                string academicYear = txtAcademicYearSearch.Text.Trim();
                var tbl = s.Search(name, classId, academicYear);
                gvStudents.DataSource = tbl;
                _searchApplied = true;
            }
        }

        private void GetClass()
        {
            DataTable tbl = new Classes().Select();
            ddlClass.DataSource = tbl;
            ddlClass.DisplayMember = "Class Name";
            ddlClass.ValueMember = "ClassId";

            ddlClassSearch.DataSource = tbl.Copy();
            ddlClassSearch.DisplayMember = "Class Name";
            ddlClassSearch.ValueMember = "ClassId";
        }

        private void SetAutoComplete()
        {
            List<string> years = s.AcademicYears();
            ControlHelper.Autocomplete(years, txtAcademicYear);
            ControlHelper.Autocomplete(years, txtAcademicYearSearch);
            List<string> studentNames = s.StudentList();
            ControlHelper.Autocomplete(studentNames, txtStudentNameSearch);
        }

        private bool SaveValidation()
        {
            epAcademicYear.Clear();
            epClass.Clear();
            epStudentName.Clear();
            epRollNumber.Clear();
            bool status = true;
            if (txtStudentName.Text.Length == 0)
            {
                epStudentName.SetError(txtStudentName, "Student name is required");
                status = false;
            }
            if (ddlClass.SelectedValue.ToString() == "0")
            {
                epClass.SetError(ddlClass, "Class is required.");
                status = false;
            }
            if (txtAcademicYear.Text == "")
            {
                epAcademicYear.SetError(txtAcademicYear, "Academic Year is required.");
                status = false;
            }
            if (txtRollNumber.Text == "")
            {
                epRollNumber.SetError(txtRollNumber, "Roll number is required.");
                status = false;
            }

            return status;
        }
        private bool SearchValidation()
        {
            epAcademicYear.Clear();
            epClass.Clear();
            epStudentName.Clear();
            epRollNumber.Clear();
            bool status = true;
            //if (txtStudentNameSearch.Text.Length == 0)
            //{
            //    epStudentName.SetError(txtStudentNameSearch, "Student name is required");
            //    status = false;
            //}
            if (ddlClassSearch.SelectedValue.ToString() == "0")
            {
                epClass.SetError(ddlClassSearch, "Class is required.");
                status = false;
            }
            if (txtAcademicYearSearch.Text.Length == 0)
            {
                epAcademicYear.SetError(txtAcademicYearSearch, "Academic Year is required.");
                status = false;
            }

            return status;
        }

        private void Clear()
        {
            //txtAcademicYear.Text = "";
            txtStudentName.Text = "";
            txtStudentName.Focus();
            txtRollNumber.Text = txtRollNumber.Text == "" ? "1" : (Convert.ToInt32(txtRollNumber.Text)+ 1).ToString();

        }

        private void GetStudent()
        {
            var tbl = s.Select();
            gvStudents.DataSource = tbl;
        }
        private void gvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string action = gvStudents.CurrentCell.Value.ToString().ToLower();
            int ind = gvStudents.CurrentCell.RowIndex;
            DataGridViewRow row = gvStudents.Rows[ind];
            string studnetId = row.Cells["StudentId"].Value.ToString();
            string enrolledYear = row.Cells["Academic Year"].Value.ToString();

            if (action == "edit")
            {
                DataTable tbl = s.GetStudentById(studnetId, enrolledYear);
                if (tbl.Rows.Count > 0)
                {
                    txtStudentName.Text = tbl.Rows[0]["StudentFullName"].ToString();
                    ddlClass.SelectedValue = tbl.Rows[0]["ClassId"].ToString();
                    txtAcademicYear.Text = tbl.Rows[0]["EnrolledYear"].ToString();
                    txtRollNumber.Text = tbl.Rows[0]["RollNumber"].ToString();
                    lblStudentID.Text = studnetId;
                    if (tbl.Rows[0]["Gender"].ToString() == "M") { rdoMale.Checked = true; }
                    else { rdoFemale.Checked = true; }
                }
                btnAction.Text = "Update";
            }
            else if (action == "delete")
            {
                DialogResult option = MessageBox.Show("Are you sure you want to delete this student record?" + Environment.NewLine + 
                    "\t(Exam Record(s) will be removed)", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (option == DialogResult.Yes)
                {
                    rows = s.Delete(Convert.ToInt32(studnetId));
                    if (rows > 0)
                    {
                        Response.DeleteMessage(rows);
                        if (_searchApplied)
                        {
                            btnSearch_Click(sender, e);
                        }
                        else
                        {
                            GetStudent();
                        }
                    }
                    
                }
            }
        }

        private void lblExcelSample_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            var fileName =AppDomain.CurrentDomain.BaseDirectory +"\\Student.xlsx";
            AppRunner.Run(fileName);
        }

       
        private void txtStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInput.StringOnly(txtStudentName, sender, e);
        }

        private void txtAcademicYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInput.Yes(txtAcademicYear, sender, e);
        }

        private void txtRollNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInput.Yes(txtRollNumber, sender, e);
        }

        private void txtStudentNameSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
         //   NumberOnly.StringOnly(txtStudentNameSearch, sender, e);
        }

        private void txtAcademicYearSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //NumberOnly.Yes(txtAcademicYearSearch, sender, e);
        }

		private void lblExcelSample_LinkClicked1(object sender, EventArgs e)
		{
			var fileName = AppDomain.CurrentDomain.BaseDirectory + "\\Student.xlsx";
			AppRunner.Run(fileName);
		}
	}
}
