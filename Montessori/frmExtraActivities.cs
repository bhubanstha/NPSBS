using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Montessori.Core;

namespace Montessori
{
	public partial class frmExtraActivities : KryptonForm
	{
		Exam exam = new Exam();
		int totalStudents = 0;
		int rows = 0;

		public frmExtraActivities()
		{
			InitializeComponent();
			GetClass();
			AutoComplete();
			GridViewEditDelete.FixView(dgvExtraActivities);
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
				this.Cursor = Cursors.WaitCursor;
				var tbl = ExtraActivities.GetExtraActivities(txtYear.Text, ddlExam.SelectedValue.ToString(), ddlClass.SelectedValue.ToString());
				totalStudents = tbl.Rows.Count;
				txtSchoolDays.Text = tbl.Rows[0]["SchoolDays"].ToString() == "" ? "70" : tbl.Rows[0]["SchoolDays"].ToString();
				dgvExtraActivities.DataSource = FormatDataTable(tbl);
				dgvExtraActivities.Columns[0].ReadOnly = true;
				dgvExtraActivities.Columns[1].Visible = false;
				dgvExtraActivities.Columns[0].Width = 300;
				dgvExtraActivities.EditMode = DataGridViewEditMode.EditOnEnter;
				this.Cursor = Cursors.Default;
			}
		}

		private DataTable FormatDataTable(DataTable tbl)
		{
			DataTable table = null;
			if (tbl != null && tbl.Rows.Count > 0)
			{
				table = new DataTable();
				table.Columns.Add(CreateColumn("Extra Activity", typeof(string)));
				table.Columns.Add(CreateColumn("School Days", typeof(Int32)));

				foreach (DataRow row in tbl.Rows)
				{
					string columnName = row["StudentFullName"] + "-" + row["StudentId"];
					table.Columns.Add(columnName, typeof(string));
				}

				for (int i = 3; i < tbl.Columns.Count; i++)
				{
					List<object> values = new List<object>();
					values.Add(tbl.Columns[i].ColumnName.Replace("_", " "));
					values.Add(tbl.Rows[0][2]);
					foreach (DataRow row in tbl.Rows)
					{
						values.Add(row[i]);
					}
					table.Rows.Add(values.ToArray());
				}
			}
			return table;
		}
		
		private DataColumn CreateColumn(string columnName, Type type)
		{
			DataColumn column = new DataColumn(columnName, type);
			column.Caption = columnName;
			return column;
		}

		void tb_KeyPress(object sender, KeyPressEventArgs e)
		{
			NumberOnly.GradeOnly(sender, e);
		}

		void tb1_GotFocus(object sender, EventArgs e)
		{
			this.AcceptButton = btnSubmitMarks;
		}

		private void btnSubmitMarks_Click(object sender, EventArgs e)
		{
			try
			{
				int examinationId = Convert.ToInt32(ddlExam.SelectedValue.ToString());
				string year = txtYear.Text;
				int schoolDays = 0;
				Int32.TryParse(txtSchoolDays.Text, out schoolDays);


				for (int i = 2; i < dgvExtraActivities.Columns.Count; i++)
				{

					string[] std = dgvExtraActivities.Columns[i].Name.Split('-');
					ExtraActivities ea = new ExtraActivities()
					{
						StudentId = std[1],
						ActivitiesYear = year,
						ExaminationId = examinationId,
						SchoolDays = schoolDays,
						PresentDays = String.IsNullOrEmpty(dgvExtraActivities.Rows[0].Cells[i].Value.ToString().Trim()) ? 0 : Convert.ToInt32(dgvExtraActivities.Rows[0].Cells[i].Value.ToString().Trim()),
						English = dgvExtraActivities.Rows[1].Cells[i].Value.ToString(),
						Nepali = dgvExtraActivities.Rows[2].Cells[i].Value.ToString(),
						CopyingSkill = dgvExtraActivities.Rows[3].Cells[i].Value.ToString(),
						Concentration = dgvExtraActivities.Rows[4].Cells[i].Value.ToString(),
						Cooperation = dgvExtraActivities.Rows[5].Cells[i].Value.ToString(),
						Memory = dgvExtraActivities.Rows[6].Cells[i].Value.ToString(),
						Curiosity = dgvExtraActivities.Rows[7].Cells[i].Value.ToString(),
						Understanding = dgvExtraActivities.Rows[8].Cells[i].Value.ToString(),
						Conduct = dgvExtraActivities.Rows[9].Cells[i].Value.ToString(),
						Neatness = dgvExtraActivities.Rows[10].Cells[i].Value.ToString(),
						Punctuality = dgvExtraActivities.Rows[11].Cells[i].Value.ToString(),
						Politeness = dgvExtraActivities.Rows[12].Cells[i].Value.ToString(),
						HeightAndWeight = dgvExtraActivities.Rows[13].Cells[i].Value.ToString(),
						Drill = dgvExtraActivities.Rows[14].Cells[i].Value.ToString(),
						Dance = dgvExtraActivities.Rows[15].Cells[i].Value.ToString(),
						Rhymes = dgvExtraActivities.Rows[16].Cells[i].Value.ToString()
					};
					rows += ea.Save(ea);
				}


				if (rows > 0)
				{
					Response.SaveMessage(rows);
				}
			}
			catch (Exception ex)
			{
				Response.GenericError(ex.Message.ToString());
			}
		}
		
		private void txtSchoolDays_KeyPress(object sender, KeyPressEventArgs e)
		{
			NumberOnly.Yes(txtSchoolDays, sender, e);
		}

		private void kryptonPanel4_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
