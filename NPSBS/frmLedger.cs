using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using NPSBS.Core;

namespace NPSBS
{
	public partial class frmLedger : frmBase
	{
		Exam exam = new Exam();
		string year, examName, className, fileName;
		int classId, examId;
		public frmLedger()
		{
			InitializeComponent();
			AutoComplete();
		}

		private void btnLedger_Click(object sender, EventArgs e)
		{
			if (Validate())
			{
				year = txtAcademicYear.Text;
				examName = ddlExamination.Text.ToString();
				className = ddlClass.Text.ToString();
				classId = Convert.ToInt16(ddlClass.SelectedValue.ToString());
				examId = Convert.ToInt32(ddlExamination.SelectedValue.ToString());

				//ClassEightLedger cel = new ClassEightLedger(11, 26, "Eight", "First Terminal Examination", "2073");
				SaveFileDialog sf = new SaveFileDialog();
				sf.Title = "Publish Result";
				sf.DefaultExt = "pdf";
				sf.Filter = "PDF (*.pdf)|*.pdf";
				if (sf.ShowDialog() == DialogResult.OK && sf.FileName.Length > 0)
				{
					fileName = sf.FileName;
					this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
					BackgroundWorker bWorker = new BackgroundWorker();
					bWorker.DoWork += new DoWorkEventHandler(bWorker_DoWork);
					bWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bWorker_RunWorkerCompleted);
					bWorker.RunWorkerAsync();
				}
			}
		}

		void bWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Cursor = System.Windows.Forms.Cursors.Default;
			if (fileName != null) AppRunner.Run(fileName);

		}

		void bWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			if (classId < 11)
			{
				try
				{
					UpToSeven s = new UpToSeven(classId, examId, className, examName, year);
					s.GetLeadger(fileName);
				}
				catch (Exception ex)
				{
					Response.GenericError(ex.Message.ToString());
				}
			}
			else
			{
				try
				{
					ClassEightLedger cel = new ClassEightLedger(classId, examId, className, examName, year);
					cel.GetLeadger(fileName);
				}
				catch (Exception ex)
				{
					Response.GenericError(ex.Message.ToString());
				}
			}
		}
		private void frmLedger_Load(object sender, EventArgs e)
		{
			GetClass();
			txtAcademicYear.Text = "2073";
			txtAcademicYear_Leave(sender, e);
		}

		private void AutoComplete()
		{
			List<string> years = new Student().AcademicYears();
			ControlHelper.Autocomplete(years, txtAcademicYear);
		}

		private void GetExams(string year)
		{

			ddlExamination.DataSource = null;
			ddlExamination.Items.Clear();
			var tbl = exam.GetExamsByYear(year);
			ddlExamination.DataSource = tbl;
			ddlExamination.DisplayMember = "Exam";
			ddlExamination.ValueMember = "ExaminationId";
		}

		private void GetClass()
		{
			var tbl = new Classes().Select();
			ddlClass.DataSource = tbl;
			ddlClass.DisplayMember = "Class Name";
			ddlClass.ValueMember = "ClassId";
		}


		private void txtAcademicYear_Leave(object sender, EventArgs e)
		{
			if (CheckAcademicYear())
			{
				GetExams(txtAcademicYear.Text);
			}
		}

		private bool CheckAcademicYear()
		{
			bool status = true;
			epAcademicYear.Clear();
			epAcademicYear.Clear();
			epClass.Clear();
			if (txtAcademicYear.Text.Length != 4)
			{
				epAcademicYear.SetError(txtAcademicYear, "Please provide 4 digit academic year.");
				status = false;
			}
			return status;
		}

		private bool Validate()
		{
			bool status = true;
			epAcademicYear.Clear();
			epClass.Clear();
			if (ddlExamination.SelectedValue.ToString() == "0")
			{
				epExamination.SetError(ddlExamination, "Please select examination name.");
				status = false;
			}
			if (ddlClass.SelectedValue.ToString() == "0")
			{
				epClass.SetError(ddlClass, "Please select class.");
				status = false;
			}
			return status;
		}

		private void txtAcademicYear_KeyPress(object sender, KeyPressEventArgs e)
		{
			NumberOnly.Yes(txtAcademicYear, sender, e);
		}

	}
}
