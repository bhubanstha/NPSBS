using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using NPSBS.Core;

namespace NPSBS
{
	public partial class frmExtraActivities : KryptonForm
	{
		Exam exam = new Exam();
		int rows = 0;

		public frmExtraActivities()
		{
			InitializeComponent();
			AutoComplete();
			GridViewEditDelete.FixView(dgvExtraActivity);
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

		private void txtYear_Leave(object sender, EventArgs e)
		{
			if (CheckAcademicYear())
			{
				GetExams(txtYear.Text);
			}
		}

		private void btnLoadStudent_Click(object sender, EventArgs e)
		{
			if (Validate())
			{
				this.Cursor = Cursors.AppStarting;
				DataTable tbl = ExtraActivities.GetExtraActivities(txtYear.Text, ddlExam.SelectedValue.ToString());
				if (tbl.Rows.Count > 0)
				{
					dgvExtraActivity.DataSource = tbl;
					dgvExtraActivity.Columns[0].Visible = false; //Student Id
					dgvExtraActivity.Columns[3].Visible = false; //School Days
					dgvExtraActivity.Columns[1].Width = 100;
					dgvExtraActivity.Columns[1].ReadOnly = true;
					dgvExtraActivity.Columns[2].Width = 200;
					dgvExtraActivity.Columns[2].ReadOnly = true;

					txtSchoolDays.Text = tbl.Rows[0][3].ToString();
					dgvExtraActivity.EditMode = DataGridViewEditMode.EditOnEnter;
				}
				else
				{
					MessageBox.Show("There are no student in Nursery class for this year.", "No Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				this.Cursor = Cursors.Default;
			}
		}

		void tb1_GotFocus(object sender, EventArgs e)
		{
			this.AcceptButton = btnSubmitMarks;
		}



		private void btnSubmitMarks_Click(object sender, EventArgs e)
		{
			int examinationId = 0, year = 0, schoolDays = 0;
			Int32.TryParse(ddlExam.SelectedValue.ToString(), out examinationId);
			Int32.TryParse(txtYear.Text, out year);
			Int32.TryParse(txtSchoolDays.Text, out schoolDays);

			if(schoolDays<1) {
				Response.GenericError("Enter school days.");
				return;
			}
			if(examinationId == 0 || year == 0)
			{
				Response.GenericError("Select examination and provide session year");
				return;
			}

			foreach (DataGridViewRow row in dgvExtraActivity.Rows)
			{
				try
				{
					ExtraActivities ea = new ExtraActivities()
					{
						StudentId = Convert.ToInt32(row.Cells[0].Value.ToString()),
						RollNumber = row.Cells[1].Value.ToString(),
						ActivitiesYear = year.ToString(),
						ExaminationId = examinationId,
						SchoolDays = schoolDays,
						PresentDays = string.IsNullOrEmpty(row.Cells[4].Value.ToString()) ? 0 : Convert.ToInt32(row.Cells[4].Value.ToString()),
						Drawing = row.Cells[5].Value.ToString().ToUpper(),
						Games = row.Cells[6].Value.ToString().ToUpper(),
						Conduct = row.Cells[7].Value.ToString().ToUpper(),
						PersonalClenliness = row.Cells[8].Value.ToString().ToUpper(),
						Cooperation = row.Cells[9].Value.ToString().ToUpper()
					};
					rows += ea.Save(ea);
				}
				catch (Exception ex)
				{
					Response.GenericError(ex.Message.ToString());
					break;
				}
			}

			if (rows > 0)
			{
				Response.SaveMessage(rows);
			}
		}


		private void dgvExtraActivity_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (e.ColumnIndex == 4)
			{
				int presentDays = 0;
				Int32.TryParse(e.FormattedValue.ToString(), out presentDays);
				int schoolDays = 0;
				Int32.TryParse(txtSchoolDays.Text, out schoolDays);
				if (presentDays > schoolDays)
				{
					dgvExtraActivity.Rows[e.RowIndex].ErrorText = "Student present days can't be more than school days.";
					e.Cancel = true;
				}
				else
				{
					dgvExtraActivity.Rows[e.RowIndex].ErrorText = "";
				}
			}
		}
	}
}
