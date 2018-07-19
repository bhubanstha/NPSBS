﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using NPSBS.Core;

namespace NPSBS
{
	public partial class frmAttendance : Form
	{
		Exam exam = new Exam();
		public frmAttendance()
		{
			InitializeComponent();
			AutoComplete();
			GetClass();
		}

		private void btnLoadStudent_Click(object sender, EventArgs e)
		{
			LoadStudent(txtYear.Text, ddlExam.SelectedValue.ToString(), ddlClass.SelectedValue.ToString());
		}

		private void btnSubmitAttendance_Click(object sender, EventArgs e)
		{
			int year = 0, examId = 0, classId = 0;
			Int32.TryParse(txtYear.Text, out year);
			Int32.TryParse(ddlExam.SelectedValue.ToString(), out examId);
			Int32.TryParse(ddlClass.SelectedValue.ToString(), out classId);
			SubmitAttendance(year, examId, classId);
		}

		private void txtYear_Leave(object sender, EventArgs e)
		{
			if (ExamValidation())
			{
				GetExamination(txtYear.Text);
			}
		}

		private void AutoComplete()
		{
			List<string> years = new Student().AcademicYears();
			ControlHelper.Autocomplete(years, txtYear);
		}

		private void GetExamination(string year)
		{
			ddlExam.DataSource = null;
			ddlExam.Items.Clear();
			var tbl = exam.GetExamsByYear(year);
			ddlExam.DataSource = tbl;
			ddlExam.DisplayMember = "Exam";
			ddlExam.ValueMember = "ExaminationId";
			ddlExam.SelectedIndex = 0;
		}

		private void GetClass()
		{
			var tbl = new Classes().Select();
			ddlClass.DataSource = tbl;
			ddlClass.DisplayMember = "Class Name";
			ddlClass.ValueMember = "ClassId";
			ddlClass.SelectedIndex = 0;
		}

		private bool ExamValidation()
		{
			bool status = true;
			epYear.Clear();
			if (txtYear.Text.Length == 0)
			{
				epYear.SetError(txtYear, "Exam held year is required.");
				status = false;
			}
			else if (txtYear.Text.Length != 4)
			{
				epYear.SetError(txtYear, "Exam held year should be 4 digit number.");
				status = false;
			}
			return status;
		}

		private bool LoadValidation()
		{
			bool status = true;
			epClass.Clear();
			epExam.Clear();
			epYear.Clear();
			status = ExamValidation();
			if (ddlExam.SelectedValue.ToString() == "0")
			{
				epExam.SetError(ddlExam, "Exam name is required.");
				status = false;
			}
			if (ddlClass.SelectedValue.ToString() == "0")
			{
				epClass.SetError(ddlClass, "Class name is required.");
				status = false;
			}
			return status;
		}

		private void LoadStudent(string examYear, string examinationId, string classId)
		{
			if (LoadValidation())
			{
				DataTable tbl = new Student().GetStudentByAcademicYearClass(classId, examYear, examinationId);
				dgvAttendance.DataSource = tbl;
				dgvAttendance.Columns[0].Visible = false; //student id column
				dgvAttendance.Columns[3].Visible = false; // school days column
				dgvAttendance.Columns[1].Width = 200;
				dgvAttendance.Columns[2].Width = 350;
				dgvAttendance.Columns[1].ReadOnly = true;
				dgvAttendance.Columns[2].ReadOnly = true;
				if (tbl.Rows.Count > 0)
				{
					txtSchoolDays.Text = tbl.Rows[0][3].ToString();
				}
				dgvAttendance.EditMode = DataGridViewEditMode.EditOnEnter;
			}
		}

		private void SubmitAttendance(int examYear, int examinationId, int classId)
		{
			int rows = 0;
			foreach (DataGridViewRow row in dgvAttendance.Rows)
			{
				try
				{
					Attendance att = new Attendance
					{
						ExamYear = examYear,
						ExaminationId = examinationId,
						ClassId = classId,
						StudentId = Convert.ToInt32(row.Cells[0].Value.ToString()),
						SchoolDays = Convert.ToInt32(txtSchoolDays.Text),
						PresentDays = string.IsNullOrEmpty(row.Cells[4].Value.ToString()) ? 0 : Convert.ToInt32(row.Cells[4].Value.ToString())
					};
					rows += att.SaveAttendance(att);
				}
				catch (Exception ex)
				{
					Response.GenericError(ex.Message.ToString());
				}
			}
			if (rows > 0)
			{
				Response.SaveMessage(rows);
			}
		}


		void tb_KeyPress(object sender, KeyPressEventArgs e)
		{
			NumberOnly.Yes(sender as TextBox, sender, e);
		}

		void tb_GotFocus(object sender, EventArgs e)
		{
			this.AcceptButton = btnSubmitAttendance;
		}

		private void dgvAttendance_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (e.ColumnIndex == 4)
			{
				int presentDays = 0;
				Int32.TryParse(e.FormattedValue.ToString(), out presentDays);
				int schoolDays = 0;
				Int32.TryParse(txtSchoolDays.Text, out schoolDays);
				if (presentDays > schoolDays)
				{
					dgvAttendance.Rows[e.RowIndex].ErrorText = "Student present days can't be more than school days.";
					e.Cancel = true;
				}else{
					dgvAttendance.Rows[e.RowIndex].ErrorText = "";
				}
			}

		}
	}
}
