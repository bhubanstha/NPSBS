using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Education.Common;
using Montessori.Core;

namespace Montessori
{
    public partial class frmMarkEntry : KryptonForm
    {
        Exam exam = new Exam();
        int rows = 0;
        public frmMarkEntry()
        {
            InitializeComponent();
            AutoComplete();
        }

        private void frmMarkEntry_Load(object sender, EventArgs e)
        {
            GetClass();
            GridViewEditDelete.FixView(dgvMarkEntry);
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

        private new bool Validate()
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
                dgvMarkEntry.Columns[1].Width = 100;
                dgvMarkEntry.Columns[1].ReadOnly = true;
                dgvMarkEntry.Columns[2].Width = 350;
                dgvMarkEntry.Columns[2].ReadOnly = true;
                dgvMarkEntry.EditMode = DataGridViewEditMode.EditOnEnter;
            }
        }

        void tb_GotFocus(object sender, EventArgs e)
        {
            this.AcceptButton = btnSubmitMarks;
        }

        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInput.GradeOnly(sender, e);
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
            try
            {
                string examinationId = ddlExam.SelectedValue.ToString();
                string classId = ddlClass.SelectedValue.ToString();
                string subjectId = ddlSubject.SelectedValue.ToString();
                string examYear = lblYear.Text.Trim();
                foreach (DataGridViewRow row in dgvMarkEntry.Rows)
                {
                    string rollNumber = row.Cells[1].Value.ToString();
                    string grade = row.Cells[3].Value.ToString();
                    grade = grade == "" ? "D" : grade.ToUpper();
                    string studentId = row.Cells[0].Value.ToString();
                    rows += exam.SubmitMark(classId, examinationId, subjectId, rollNumber, studentId, grade, examYear);
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
        
        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInput.Yes(txtYear, sender, e);
        }

        private void ddlSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.AcceptButton = btnLoadStudent;
            }
            catch
            {

            }
        }

        private void dgvMarkEntry_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        { 
            e.Control.KeyPress -= CellControl_Editing;
            if ((int)(((System.Windows.Forms.DataGridView)(sender)).CurrentCell.ColumnIndex) == 3)
            {
                e.Control.KeyPress += CellControl_Editing;
            }

        }

        private void CellControl_Editing(object sender, KeyPressEventArgs e)
        {
            ValidateInput.GradeOnlyGrid(sender as DataGridViewTextBoxEditingControl, e);
        }

        private void dgvMarkEntry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==3)
            {
                dgvMarkEntry.BeginEdit(true);
            }
        }
    }
}
