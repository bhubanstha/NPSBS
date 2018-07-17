using NPSBS.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NPSBS
{
    public partial class frmAttendance : Form
    {
        Exam exam = new Exam();
        TableLayoutPanel table = null;
        int totalStudent = 0;
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
            SubmitAttendance(txtYear.Text, ddlExam.SelectedValue.ToString(), ddlClass.SelectedValue.ToString());
        }

        private void txtYear_Leave(object sender, EventArgs e)
        {
            if(ExamValidation())
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
            else if(txtYear.Text.Length !=4)
            {
                epYear.SetError(txtYear, "Exam held year should be 4 digit number.");
                status = false;
            }
            return status;
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
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
            table.Controls.Add(new Label() { Text = "S.N", AutoSize = true, Width = 100 }, 0, 0);
            table.Controls.Add(new Label() { Text = "Roll Number", AutoSize = true, Width = 150 }, 1, 0);
            table.Controls.Add(new Label() { Text = "Student Name", AutoSize = true, Width = 150 }, 2, 0);
            table.Controls.Add(new Label() { Text = "Present Days", Width = 150, AutoSize = true }, 3, 0);
            table.Width = this.Width - 10;
            table.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            table.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            table.AutoScroll = true;
            table.Dock = DockStyle.Fill;           
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
            if(ddlClass.SelectedValue.ToString() == "0")
            {
                epClass.SetError(ddlClass, "Class name is required.");
                status = false;
            }
            return status;
        }

        private void LoadStudent(string examYear, string examinationId, string classId)
        {
            if(LoadValidation())
            {
                var tbl = new Student().GetStudentByAcademicYearClass(classId, examYear, examinationId);
                totalStudent = tbl.Rows.Count;
                if(totalStudent>0)
                {
                    CreateTable();
                    txtSchoolDays.Text = tbl.Rows[0]["SchoolDays"].ToString();
                    for (int i = 0; i < tbl.Rows.Count; i++)
                    {
                        
                        table.RowCount = table.RowCount + 1;
                        TextBox tb = new TextBox();
                        tb.Name = "PresentDays" + i;
                        tb.Width = 150;
                        tb.MaxLength = 3;
                        tb.Text = tbl.Rows[i]["PresentDays"].ToString() == "" ? "0" : tbl.Rows[i]["PresentDays"].ToString();
                        tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
                        tb.GotFocus += tb_GotFocus;
                        tb.KeyPress += tb_KeyPress;

                        Label lb0 = new Label();
                        lb0.Text = (i + 1).ToString();
                        lb0.Width = 150;
                        lb0.Name = "SN" + i;
                        lb0.AutoSize = true;

                        Label lb = new Label();
                        lb.Text = tbl.Rows[i]["RollNumber"].ToString();
                        lb.Width = 150;
                        lb.Name = "RollNumber" + i;
                        lb.AutoSize = true;

                        Label lb1 = new Label();
                        lb1.Text = tbl.Rows[i]["StudentFullName"].ToString(); ;
                        lb1.Width = 250;
                        lb1.AutoSize = true;

                        table.Controls.Add(lb0, 0, table.RowCount - 1);
                        table.Controls.Add(lb, 1, table.RowCount - 1);
                        table.Controls.Add(lb1, 2, table.RowCount - 1);
                        table.Controls.Add(tb, 3, table.RowCount - 1);
                    }
                    table.Controls.Add(new Label { Text = "" }, 0, table.RowCount);
                    table.Controls.Add(new Label { Text = "" }, 1, table.RowCount);
                    table.Controls.Add(new Label { Text = "" }, 2, table.RowCount);
                    table.Controls.Add(new Label { Text = "" }, 3, table.RowCount);                    
                    pnlStudentContainer.Controls.Add(table);
                    TextBox tbFirst = table.Controls.Find("PresentDays0", true).FirstOrDefault() as TextBox;
                    tbFirst.Focus();
                }
            }
        }

        private void SubmitAttendance(string examYear, string examinationId, string classId)
        {
            int rows = 0;
            string msg = "";
            bool isError = false;
            for (int i = 0; i < totalStudent; i++)
            {
                string attendance = "PresentDays" + i;
                string roll = "RollNumber" + i;
                TextBox tb = table.Controls.Find(attendance, true).FirstOrDefault() as TextBox;
                string presentDays = tb.Text == "" ? "0" : tb.Text;

                Label rollNo = table.Controls.Find(roll, true).FirstOrDefault() as Label;
                string rollNumber = rollNo.Text == "" ? "0" : rollNo.Text;

                Attendance att = new Attendance
                {
                    ExamYear = examYear,
                    ExaminationId = Convert.ToInt32(examinationId),
                    ClassId = Convert.ToInt32(classId),
                    RollNumber = rollNumber,
                    SchoolDays = Convert.ToInt32(txtSchoolDays.Text),
                    PresentDays = Convert.ToInt32(presentDays)
                };
                try
                {
                    rows = att.SaveAttendance(att);
                }
                catch (Exception ex)
                {
                    isError = true;
                    msg = ex.Message.ToString();
                }
               
            }
            if (isError)
            {
                Response.GenericError(msg);
            }
            else
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

    }
}
