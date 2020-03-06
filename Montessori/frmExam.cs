using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Montessori.Core;
namespace Montessori
{
    public partial class frmExam : KryptonForm
    {
        Exam exam = new Exam();
        private int rows = 0;
        public frmExam()
        {
            InitializeComponent();
            AutoComplete();
            GetExams();
            GetExamination();
            Montessori.Core.GridViewEditDelete.AddActions(dgvExam);
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaveValidation())
                {
                    exam.ExamId = Convert.ToInt32(ddlExam.SelectedValue);
                    exam.ExamHeldYear = txtYear.Text;
                    exam.ResultPrintDate = Convert.ToDateTime(dpResultPrintDate.Value);
                    if (btnAction.Text.ToLower() == "save")
                    {
                        rows = exam.Save(exam);
                        Response.SaveMessage(rows);
                    }
                    else if (btnAction.Text.ToLower() == "update")
                    {
                        exam.ExaminationId = Convert.ToInt32(lblExaminationId.Text);
                        rows = exam.Update(exam);
                        btnAction.Text = "Save";
                        lblExaminationId.Text = "0";
                        Response.UpdateMessage(rows);
                    }
                    if (rows > 0)
                    {
                        Clear();
                        GetExamination();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.GenericError(ex.Message.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(SearchValidation())
            {
                dgvExam.DataSource = exam.GetExaminationByYear(txtYearSearch.Text);
            }
        }

       
        private void dgvExam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string action = dgvExam.CurrentCell.Value.ToString().ToLower();
            int ind = dgvExam.CurrentCell.RowIndex;
            DataGridViewRow row = dgvExam.Rows[ind];
            string examinationId = row.Cells["ExaminationId"].Value.ToString();

            if (action == "edit")
            {
                var tbl = exam.SelectById(Convert.ToInt32(examinationId));
                if (tbl.Rows.Count > 0)
                {
                    ddlExam.SelectedValue = tbl.Rows[0]["ExamId"].ToString();
                    txtYear.Text = tbl.Rows[0]["ExamHeldYear"].ToString();
                    dpResultPrintDate.Value = Convert.ToDateTime(tbl.Rows[0]["ResultPrintDate"].ToString()).AddHours(2);
                    lblExaminationId.Text = tbl.Rows[0]["ExaminationId"].ToString();
                    btnAction.Text = "Update";
                }
                else
                {
                    GetExamination();
                }
            }
            else if (action == "delete")
            {
                DialogResult option = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (option == DialogResult.Yes)
                {
                    rows = exam.Delete(Convert.ToInt32(examinationId));
                    Response.DeleteMessage(rows);
                    GetExamination();
                }
            }
        }



        private void Clear()
        {
            txtYear.Text = "";
            //dpResultPrintDate.Value = DateTime.Now;
            txtYear.Focus();
        }

        private void AutoComplete()
        {
            List<string> years = new Student().AcademicYears();
            ControlHelper.Autocomplete(years, txtYear);
            ControlHelper.Autocomplete(years, txtYearSearch);
        }

        private void GetExams()
        {
            var tbl  = exam.GetExams();
            ddlExam.DataSource = tbl;
            ddlExam.DisplayMember = "ExamName";
            ddlExam.ValueMember = "ExamId";
        }

        private bool SaveValidation()
        {
            bool status = true;
            epExam.Clear();
            epYear.Clear();
            epPrintDate.Clear();
            if(ddlExam.SelectedValue.ToString()=="0")
            {
                epExam.SetError(ddlExam,"Exam name is required.");
                status = false;
            }
            if(txtYear.Text.Length != 4)
            {
                epYear.SetError(txtYear,"Exam held year is required. Provide 4 digit year.");
                status = false;
            }
            if(Convert.ToDateTime(dpResultPrintDate.Value.ToShortDateString()) < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
            {
                epPrintDate.SetError(dpResultPrintDate,"Result print date should not be less than today date.");
                status = false;
            }
            return status;
        }

        private bool SearchValidation()
        {
            bool status = true;
            epExam.Clear();
            epYear.Clear();
            epPrintDate.Clear();
            if(txtYearSearch.Text.Length ==0)
            {
                epYear.SetError(txtYearSearch,"Exam held year is required.");
                status = false;
            }
            else if (txtYearSearch.Text.Length != 4)
            {
                epYear.SetError(txtYearSearch, "Exam held year should be 4 digit number.");
                status = false;
            }
             return status;
        }

        private void GetExamination()
        {
            var tbl = exam.Select();
            dgvExam.DataSource = tbl;
        }

        private void txtYear_Leave(object sender, EventArgs e)
        {
            if (txtYear.Text.Length == 4)
            {
                int year = Convert.ToInt32(txtYear.Text);
                var addYear = year - DateTime.Now.Year;
                dpResultPrintDate.MinDate = DateTime.Now.AddYears(addYear).AddMonths(-(DateTime.Now.Month-1));
                dpResultPrintDate.MaxDate = DateTime.Now.AddYears(addYear + 1).AddMonths(12-DateTime.Now.Month);
                dpResultPrintDate.Value = new DateTime(year, DateTime.Now.Month, DateTime.Now.Day);
            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.Yes(txtYear, sender, e);
        }

        private void txtYearSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.Yes(txtYearSearch, sender, e);
        }
    }
}
