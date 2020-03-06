using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Montessori.Core;

namespace Montessori
{
	public partial class frmRemarks : KryptonForm
	{
		Exam exam = new Exam();
		int totalStudents = 0;
		int rows = 0;

		public frmRemarks()
		{
			InitializeComponent();
			AutoComplete();
			GetClass();
		}

		private void btnLoadStudent_Click(object sender, EventArgs e)
		{
			if (Validate())
			{
				try
				{
					this.Cursor = Cursors.AppStarting;
					var tbl = Remarks.GetRemark(ddlExam.SelectedValue.ToString(), ddlClass.SelectedValue.ToString(), txtYear.Text);
					totalStudents = tbl.Rows.Count;
					if (totalStudents > 0)
					{
						dgvRemarks.DataSource = tbl;
						dgvRemarks.Columns[0].Visible = false;
						dgvRemarks.Columns[1].Visible = false;
						dgvRemarks.Columns[2].Width = 50;
						dgvRemarks.Columns[3].Width = 300;
						dgvRemarks.Columns[2].ReadOnly = true;
						dgvRemarks.Columns[3].ReadOnly = true;
						dgvRemarks.EditMode = DataGridViewEditMode.EditOnEnter;
					}
					else
					{
						Response.GenericError("There are no student for remarks entry.");
					}
				}
				catch (Exception ex)
				{
					Response.GenericError(ex.Message);
				}
			}
		}

		private void btnSubmitReMarks_Click(object sender, EventArgs e)
		{
			string examinationId = ddlExam.SelectedValue.ToString();
			string year = txtYear.Text;
			string classId = ddlClass.SelectedValue.ToString();
			foreach (DataGridViewRow row in dgvRemarks.Rows)
			{

				string studentId = row.Cells[1].Value.ToString();
				string remarks = row.Cells[4].Value.ToString();
				int remarksId = row.Cells[0].Value == DBNull.Value ? 0 : Convert.ToInt32(row.Cells[0].Value.ToString());
				Remarks rm = new Remarks()
				{
					StudentId = Convert.ToInt32(studentId),
					ExaminationId = examinationId,
					ClassId = classId,
					ExamHeldYear = year,
					Remark = remarks,
					RemarksId = remarksId
				};
				rows += Remarks.SaveOrUpdate(rm);
			}
			if (rows > 0)
			{
				Response.SaveMessage(rows);
			}
		}

		private bool Validate()
		{
			bool status = true;
			status = CheckAcademicYear();
			if (ddlExam.Items.Count == 0)
			{
				epExam.SetError(ddlExam, "No exam are present for the academic year.");
				status = false;
			}
			else if (ddlExam.SelectedValue.ToString() == "0")
			{
				epExam.SetError(ddlExam, "Please select exam");
				status = false;
			}
			return status;
		}

		private bool CheckAcademicYear()
		{
			bool status = true;
			epYear.Clear();
			epExam.Clear();
			epClass.Clear();
			if (txtYear.Text.Length != 4)
			{
				epYear.SetError(txtYear, "Please provide 4 digit academic year.");
				status = false;
			}
			return status;
		}

		private void AutoComplete()
		{
			List<string> years = new Student().AcademicYears();
			ControlHelper.Autocomplete(years, txtYear);
		}

		private void GetExams(string year)
		{
			ddlExam.DataSource = null;
			ddlExam.Items.Clear();
			var tbl = exam.GetExamsByYear(year);
			ddlExam.DataSource = tbl;
			ddlExam.DisplayMember = "Exam";
			ddlExam.ValueMember = "ExaminationId";
		}
		private void GetClass()
		{
			var tbl = new Classes().Select();
            ddlClass.DataSource = tbl;
            ddlClass.DisplayMember = "Class Name";
            ddlClass.ValueMember = "ClassId";
		}

		private void txtYear_Leave(object sender, EventArgs e)
		{
			if (CheckAcademicYear())
			{
				GetExams(txtYear.Text);
			}
		}
	}
}
