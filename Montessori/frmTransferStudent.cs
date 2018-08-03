using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Montessori.Core;

namespace Montessori
{
	public partial class frmTransferStudent : frmBase
    {
        Student s = new Student();
        int rows = 0;
        public frmTransferStudent()
        {
            InitializeComponent();
            GridViewEditDelete.FixView(gvTranferStudent);
            AutoComplete();
            GetClass();
        }

        

        private void btnGetStudent_Click(object sender, EventArgs e)
        {
            if (ValidateGet())
            {
                GetStudent();
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            bool pkException = false;
            if (ValidateTransfer())
            {
                rows = 0;
                string classId = ddlNewClass.SelectedValue.ToString();
                string academicYear = txtNewAcademicYear.Text;
                for (int i = 0; i < gvTranferStudent.Rows.Count; i++)
                {
                    string newRoll = gvTranferStudent.Rows[i].Cells[7].Value.ToString();
                    string studentId = gvTranferStudent.Rows[i].Cells[0].Value.ToString();
                    if (newRoll == "")
                    {
                        newRoll = gvTranferStudent.Rows[i].Cells[6].Value.ToString();
                    }
                    try
                    {
                        rows += s.Transfer(newRoll, classId, academicYear, studentId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pkException = true;
                        break;
                    }                                       
                }
                if (!pkException)
                {
                    Response.TeansferMessage(rows);
                }
                
            }
        }

        private void AutoComplete()
        {
            List<string> years = s.AcademicYears();
            ControlHelper.Autocomplete(years, txtOldAcademicYear);
            ControlHelper.Autocomplete(years, txtNewAcademicYear);
        }

        private void GetClass()
        {
            var tbl = new Classes().Select();
            ddlOldClass.DataSource = tbl;
            ddlOldClass.DisplayMember = "Class Name";
            ddlOldClass.ValueMember = "ClassId";

            ddlNewClass.DataSource = tbl.Copy();
            ddlNewClass.DisplayMember = "Class Name";
            ddlNewClass.ValueMember = "ClassId";
        }

        private void GetStudent()
        {
            string classId = ddlOldClass.SelectedValue.ToString();
            string academicYear = txtOldAcademicYear.Text.Trim();
            var tbl = s.GetTransferStudent(classId, academicYear);
            gvTranferStudent.DataSource  = tbl;
            gvTranferStudent.Columns[0].Visible = false;
            btnTransfer.Enabled = true;

        }

        private bool ValidateGet()
        {
            bool status = true;
            epClass.Clear();
            epAcademicYear.Clear();
            if (ddlOldClass.SelectedValue.ToString() == "0")
            {
                epClass.SetError(ddlOldClass, "Class Name is required.");
                status = false;
            }
            if (txtOldAcademicYear.Text.Length < 4)
            {
                epAcademicYear.SetError(txtOldAcademicYear, "Academic Year is required.");
                status = false;
            }
            return status;
        }
        private bool ValidateTransfer()
        {
            bool status = true;
            epClass.Clear();
            epAcademicYear.Clear();
            if (ddlNewClass.SelectedValue.ToString() == "0")
            {
                epClass.SetError(ddlNewClass, "Class Name is required.");
                status = false;
            }
            if (txtNewAcademicYear.Text.Length < 4)
            {
                epAcademicYear.SetError(txtNewAcademicYear, "Academic Year is required.");
                status = false;
            }
            return status;
        }

        private void txtOldAcademicYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly.Yes(txtOldAcademicYear, sender, e);
        }

        private void txtNewAcademicYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly.Yes(txtNewAcademicYear, sender, e);
        }
    }
}
