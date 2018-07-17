using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Montessori.Core;
using System.Collections;

namespace Montessori
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
            table.ColumnCount = 3;
            table.RowCount = 1;
            table.RowStyles.Clear();
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
            table.Controls.Add(new Label() { Text = "Roll Number", AutoSize = true, Width = 100 }, 0, 0);
            table.Controls.Add(new Label() { Text = "Name", AutoSize = true, Width = 150 }, 1, 0);
            table.Controls.Add(new Label() { Text = "Obtained Grade", AutoSize = true, Width = 150 }, 2, 0);
            table.Width = this.Width - 10;
            //table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            table.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            table.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            table.AutoScroll = true;
            //table.Location = new Point(gbStudentContainer.Top - 5, 500);
            table.Dock =DockStyle.Fill;
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
                var tbl = new Student().GetStudentByAcademicYearClass(ddlClass.SelectedValue.ToString(), txtYear.Text, ddlSubject.SelectedValue.ToString(), ddlExam.SelectedValue.ToString());
                totalStudents = tbl.Rows.Count;

                if (totalStudents > 0)
                {
                    CreateTable();
                    for (int i = 0; i < tbl.Rows.Count; i++)
                    {
                        string grade = tbl.Rows[i]["Grade"].ToString().Trim();
                        table.RowCount = table.RowCount + 1;
                        TextBox tb = new TextBox();
                        tb.Name = "Grade" + i;
                        tb.Width = 150;
                        tb.MaxLength = 2;
                        tb.Text = grade;
                        tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
                        tb.KeyPress += tb_KeyPress;
                        tb.GotFocus += tb_GotFocus;
                        
                        Label lb = new Label();
                        lb.Text = tbl.Rows[i]["RollNumber"].ToString();
                        lb.Width = 150;
                        lb.Name = "RollNumber" + i;
                        lb.AutoSize = true;

                        Label lb1 = new Label();
                        lb1.Text = tbl.Rows[i]["StudentFullName"].ToString(); ;
                        lb1.Width = 250;
                        lb1.AutoSize = true;

                        table.Controls.Add(lb, 0, table.RowCount - 1);
                        table.Controls.Add(lb1, 1, table.RowCount - 1);
                        table.Controls.Add(tb, 2, table.RowCount - 1);
                    }
                    table.Controls.Add(new Label { Text = "" },0, table.RowCount );
                    table.Controls.Add(new Label { Text = "" }, 1, table.RowCount);
                    table.Controls.Add(new Label { Text = "" }, 2, table.RowCount);

                    TextBox tbFirst = table.Controls.Find("Grade0", true).FirstOrDefault() as TextBox;
                        tbFirst.Focus();
                }
                else
                {
                    try
                    {
                        pnlStudentContainer.Controls.Remove(table);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        
        void tb_GotFocus(object sender, EventArgs e)
        {
            this.AcceptButton = btnSubmitMarks;
        }

        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly.GradeOnly(sender, e);
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
            for (int i = 0; i < totalStudents; i++)
            {
                string prac = "Grade" + i;
                string roll = "RollNumber" + i;
                TextBox tb = table.Controls.Find(prac, true).FirstOrDefault() as TextBox;
                string txt = tb.Text==""? "D" : tb.Text;     
           
                Label lbl = table.Controls.Find(roll, true).FirstOrDefault() as Label;
                string rollNumber = lbl.Text;

                rows = exam.SubmitMark(classId, examinationId, subjectId, rollNumber, txt, examYear);
                                
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
            if(status)
            {
                status = isPracticalOk? true : false;
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

        private void ddlSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.AcceptButton = btnLoadStudent;
                 pnlStudentContainer.Controls.Remove(table);
            }
            catch (Exception)
            {
                
            }
        }

    }
}
