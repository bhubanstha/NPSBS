using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using NPSBS.Core;

namespace NPSBS
{
	public partial class frmMarkEntry : Form
	{
		Exam exam = new Exam();
		int totalStudents = 0;
		TableLayoutPanel table = null;
		int rows = 0;
		public frmMarkEntry()
		{
			InitializeComponent();
			AutoComplete();
		}


		private void frmMarkEntry_Load(object sender, EventArgs e)
		{
			GetClass();
		}

		private void CreateTable()
		{
			try
			{
				pnlStudentContainer.Controls.Remove(table);
			}
			catch (Exception)
			{

				throw;
			}

			table = new TableLayoutPanel();
			table.ColumnCount = 4;
			table.RowCount = 1;
			table.RowStyles.Clear();
			table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			table.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			table.Controls.Add(new Label() { Text = "Roll Number", AutoSize = true, Width = 100 }, 0, 0);
			table.Controls.Add(new Label() { Text = "Name", AutoSize = true, Width = 150 }, 1, 0);
			table.Controls.Add(new Label() { Text = "Theory Mark", AutoSize = true, Width = 150 }, 2, 0);
			table.Controls.Add(new Label() { Text = "Practical Mark", Width = 150, AutoSize = true }, 3, 0);
			table.Width = this.Width - 10;
			//table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
			table.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
			table.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			table.AutoScroll = true;
			//table.Location = new Point(gbStudentContainer.Top - 5, 500);
			table.Dock = DockStyle.Fill;
			pnlStudentContainer.Controls.Add(table);
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

		private void GetSubject(string classId)
		{
			var tbl = new Subject().SubjectByClassId(classId);
			//ddlSubject.Items.Clear();
			ddlSubject.DataSource = tbl;
			ddlSubject.DisplayMember = "Subject";
			ddlSubject.ValueMember = "SubjectId";
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
			if (ddlClass.SelectedValue.ToString() == "0")
			{
				epClass.SetError(ddlClass, "Please select class");
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
				DataTable tbl = new Student().GetStudentByAcademicYearClass(ddlClass.SelectedValue.ToString(), txtYear.Text, ddlSubject.SelectedValue.ToString(), ddlExam.SelectedValue.ToString());
				dgvMarkEntry.DataSource = tbl;
				dgvMarkEntry.Columns[0].Visible = false;
				dgvMarkEntry.Columns[1].Visible = false;
				dgvMarkEntry.Columns[2].Visible = false;
				dgvMarkEntry.Columns[3].Width = 130;
				dgvMarkEntry.Columns[4].Width = 130;
				dgvMarkEntry.Columns[3].ReadOnly = true;
				dgvMarkEntry.Columns[4].ReadOnly = true;
				dgvMarkEntry.EditMode = DataGridViewEditMode.EditOnEnter;
			}
		}

		void tb1_GotFocus(object sender, EventArgs e)
		{
			this.AcceptButton = btnSubmitMarks;
		}

		void tb_GotFocus(object sender, EventArgs e)
		{
			this.AcceptButton = btnSubmitMarks;
		}

		void tb_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			// only allow one decimal point
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}

		}

		void tb1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			// only allow one decimal point
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
			if (!char.IsControl(e.KeyChar))
			{

				TextBox textBox = (TextBox)sender;

				if (textBox.Text.IndexOf('.') > -1 &&
								 textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 3)
				{
					e.Handled = true;
				}

			}
		}

		private void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ddlClass.Items.Count > 0)
			{
				var val = ddlClass.SelectedValue.ToString();
				if (val != "System.Data.DataRowView")
				{
					GetSubject(val);
				}
			}
		}

		private void btnSubmitMarks_Click(object sender, EventArgs e)
		{
			string examinationId = ddlExam.SelectedValue.ToString();
			string classId = ddlClass.SelectedValue.ToString();
			string subjectId = ddlSubject.SelectedValue.ToString();
			string examYear = txtYear.Text.Trim();

			foreach (DataGridViewRow row in dgvMarkEntry.Rows)
			{

			}

			for (int i = 0; i < totalStudents; i++)
			{
				string prac = "Practical" + i;
				string the = "Theory" + i;
				string roll = "RollNumber" + i;
				TextBox tb = table.Controls.Find(prac, true).FirstOrDefault() as TextBox;
				string txt = tb.Text == "" ? "0" : tb.Text;

				TextBox tb1 = table.Controls.Find(the, true).FirstOrDefault() as TextBox;
				string txt1 = tb1.Text == "" ? "0" : tb1.Text;

				Label lbl = table.Controls.Find(roll, true).FirstOrDefault() as Label;
				string rollNumber = lbl.Text;

				if (IsMarksOk(Convert.ToDecimal(txt1), Convert.ToDecimal(txt), subjectId, rollNumber))
				{
					rows = exam.SubmitMark(classId, examinationId, subjectId, rollNumber, Convert.ToDecimal(txt1), Convert.ToDecimal(txt), examYear);
				}

			}
			if (rows > 0)
			{
				Response.SaveMessage(rows);
			}
		}

		private bool IsMarksOk(decimal theory, decimal practical, string subjectId, string rollNumber)
		{
			bool status = true;
			bool isTheoryOk = exam.CheckTheory(theory, subjectId);
			bool isPracticalOk = exam.CheckPractical(practical, subjectId);
			status = isTheoryOk ? true : false;
			if (status)
			{
				status = isPracticalOk ? true : false;
			}
			if (!isTheoryOk)
			{
				MessageBox.Show("Theory mark is out of range for student (" + rollNumber + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if (!isPracticalOk)
			{
				MessageBox.Show("Practical mark is out of range for student (" + rollNumber + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return status;
		}

		private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
		{
			NumberOnly.Yes(txtYear, sender, e);
		}

	}
}
