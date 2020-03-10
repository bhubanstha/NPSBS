using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using NPSBS.Core;

namespace NPSBS
{
	public partial class frmMarkEntry : KryptonForm
	{
		Exam exam = new Exam();
		int rows = 0;
		public frmMarkEntry()
		{
			InitializeComponent();
			AutoComplete();
			GridViewEditDelete.FixView(dgvMarkEntry);
		}


		private void frmMarkEntry_Load(object sender, EventArgs e)
		{
			GetClass();
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
				//dgvMarkEntry.Columns[0].Visible = false;
				//dgvMarkEntry.Columns[1].Visible = false;
				//dgvMarkEntry.Columns[2].Visible = false;
				dgvMarkEntry.Columns[0].Width = 100;
				dgvMarkEntry.Columns[0].ReadOnly = true;
				dgvMarkEntry.Columns[1].Width = 200;
				dgvMarkEntry.Columns[1].ReadOnly = true;
				//dgvMarkEntry.Columns[3].MinimumWidth = 130;
				//dgvMarkEntry.Columns[4].MinimumWidth = 300;
				dgvMarkEntry.Columns[4].Visible = false;//full marks theory
				dgvMarkEntry.Columns[5].Visible = false;//full marks practical
				dgvMarkEntry.Columns[6].Visible = false;//student id
				
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
			Int32 examinationId = 0, classId = 0, subjectId = 0, examYear = 0;
			
			Int32.TryParse(ddlExam.SelectedValue.ToString(), out examinationId);
			Int32.TryParse(ddlClass.SelectedValue.ToString(), out classId);
			Int32.TryParse(ddlSubject.SelectedValue.ToString(), out subjectId);
			Int32.TryParse(txtYear.Text.Trim(), out examYear);

			foreach (DataGridViewRow row in dgvMarkEntry.Rows)
			{
				decimal theory = string.IsNullOrEmpty(row.Cells[2].Value.ToString()) ? 0 : Convert.ToDecimal(row.Cells[2].Value.ToString());
				decimal practical = string.IsNullOrEmpty(row.Cells[3].Value.ToString()) ? 0 : Convert.ToDecimal(row.Cells[3].Value.ToString());
				int studentId = Convert.ToInt32(row.Cells[6].Value.ToString());
				string rollNumber = row.Cells[0].Value.ToString();

				if (IsMarksOk(theory,practical,subjectId, rollNumber))
				{
					rows = exam.SubmitMark(classId, examinationId, subjectId, studentId, theory, practical, examYear, rollNumber);
				}
			}

			if (rows > 0)
			{
				Response.SaveMessage(rows);
			}
		}

		private bool IsMarksOk(decimal theory, decimal practical, int subjectId, string rollNumber)
		{
			bool status = true;
			bool isTheoryOk = exam.CheckTheory(theory, subjectId.ToString());
			bool isPracticalOk = exam.CheckPractical(practical, subjectId.ToString());
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
			ValidateInput.Yes(txtYear, sender, e);
		}

		private void dgvMarkEntry_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if(e.ColumnIndex==2) //validate theory
			{
				decimal fullMark = Convert.ToDecimal(dgvMarkEntry.Rows[e.RowIndex].Cells[4].Value.ToString());
				decimal obtained = 0;
				decimal.TryParse(e.FormattedValue.ToString(), out obtained);
				if(obtained>fullMark)
				{
					dgvMarkEntry.Rows[e.RowIndex].ErrorText = "Obtained theory marks is greater than full mark (" + fullMark.ToString() + ")";
					e.Cancel = true;
				}
				else
				{
					dgvMarkEntry.Rows[e.RowIndex].ErrorText = "";
				}
			}
			else if(e.ColumnIndex==3) //validate pratical
			{
				decimal fullMark = Convert.ToDecimal(dgvMarkEntry.Rows[e.RowIndex].Cells[5].Value.ToString());
				decimal obtained = 0;
				decimal.TryParse(e.FormattedValue.ToString(), out obtained);
				if (obtained > fullMark)
				{
					dgvMarkEntry.Rows[e.RowIndex].ErrorText = "Obtained practical marks is greater than full mark (" + fullMark.ToString() + ")";
					e.Cancel = true;
				}
				else
				{
					dgvMarkEntry.Rows[e.RowIndex].ErrorText = "";
				}
			}
		}

		private void dgvMarkEntry_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			e.Control.KeyPress -= CellControl_Editing;
			int colIndex = ((KryptonDataGridView)sender).CurrentCell.ColumnIndex;
			if (colIndex == 2 || colIndex == 3)
			{
				e.Control.KeyPress += CellControl_Editing;
			}
		}

		private void CellControl_Editing(object sender, KeyPressEventArgs e)
		{
			ValidateInput.DecimalType((DataGridViewTextBoxEditingControl)sender, e);
		}

		private void dgvMarkEntry_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
			{
				dgvMarkEntry.BeginEdit(true);
			}
		}
	}
}
