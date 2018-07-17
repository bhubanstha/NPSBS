using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Montessori.Core;

namespace Montessori
{
    public partial class frmRemarks : Form
    {
        Exam exam = new Exam();
        int totalStudents = 0;
        TableLayoutPanel table = null;
        int rows = 0;

        public frmRemarks()
        {
            InitializeComponent();
            AutoComplete();
            GetClass();
        }

        private void btnLoadStudent_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                this.Cursor = Cursors.AppStarting;
                var tbl = Remarks.GetRemark(ddlExam.SelectedValue.ToString(), ddlClass.SelectedValue.ToString(), txtYear.Text);
                totalStudents = tbl.Rows.Count;
                if (totalStudents > 0)
                {
                    CreateTable();
                    for (int i = 0; i < tbl.Rows.Count; i++)
                    {
                        table.RowCount = table.RowCount + 1;
                        Label lb = new Label();
                        lb.Text = (i + 1).ToString();
                        lb.Width = 150;
                        lb.Name = "SN" + i;
                        lb.AutoSize = true;
                        table.Controls.Add(lb, 0, table.RowCount - 1);

                        string name = tbl.Rows[i]["StudentFullName"].ToString();
                        Label lb1 = new Label();
                        lb1.Text = name;
                        lb1.Width = 150;
                        lb1.Name = "StudentName" + i;
                        lb1.AutoSize = true;
                        table.Controls.Add(lb1, 1, table.RowCount - 1);

                        TextBox tb = new TextBox();
                        tb.Text = (i + 1).ToString();
                        //tb.Width = 150;
                        tb.Text = tbl.Rows[i]["Remarks"].ToString();
                        tb.Name = "Remarks" + i;
                        tb.Dock = DockStyle.Fill;
                        table.Controls.Add(tb, 2, table.RowCount - 1);
                    }
                    table.Controls.Add(new Label { Text = "" }, 0, table.RowCount);
                    table.Controls.Add(new Label { Text = "" }, 1, table.RowCount);
                    table.Controls.Add(new Label { Text = "" }, 2, table.RowCount);
                    pnlStudentContainer.Controls.Add(table);
                    TextBox tbFirst = table.Controls.Find("Remarks0", true).FirstOrDefault() as TextBox;                   
                    this.Cursor = Cursors.Default;
                    pnlStudentContainer.Visible = true;
                    tbFirst.Focus();
                }
                else
                {
                    Response.GenericError("There are no student for remarks entry.");
                    try
                    {
                        pnlStudentContainer.Controls.Remove(table);
                    }
                    catch (Exception ex)
                    {
                        
                        throw;
                    }
                }
            }
        }

        private void btnSubmitReMarks_Click(object sender, EventArgs e)
        {
            string examinationId = ddlExam.SelectedValue.ToString();
            string year = txtYear.Text;
            string classId = ddlClass.SelectedValue.ToString();
            for (int i = 0; i < totalStudents; i++)
            {
                Label lb = table.Controls.Find("StudentName" + i.ToString(), true).FirstOrDefault() as Label;
                string studentId = lb.Text.Split('-')[1].Trim();

                TextBox tb = table.Controls.Find("Remarks" + i, true).FirstOrDefault() as TextBox;
                string remarks = tb.Text;

                Remarks rm = new Remarks()
                {
                    StudentId = Convert.ToInt32(studentId),
                    ExaminationId = examinationId,
                    ClassId = classId,
                    ExamHeldYear = year,
                    Remark = remarks
                };
                rows += Remarks.SaveOrUpdate(rm);                
            }
            if (rows > 0)
            {
                Response.SaveMessage(rows);
            }
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

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYear_Leave(object sender, EventArgs e)
        {
            if (CheckAcademicYear())
            {
                GetExams(txtYear.Text);
            }
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
            pnlStudentContainer.Visible = false;
            table = new TableLayoutPanel();
            table.ColumnCount = 3;
            table.RowCount = 1;
            table.RowStyles.Clear();
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            table.Controls.Add(new Label() { Text = "S.N", AutoSize = true, Width = 100 }, 0, 0);
            table.Controls.Add(new Label() { Text = "Student Name", AutoSize = true, Width = 100 }, 1, 0);
            table.Controls.Add(new Label() { Text = "Remarks", AutoSize = true, Width = 100 }, 1, 0);
            table.Width = this.Width - 10;
            //table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            table.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            table.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            table.AutoScroll = true;
            //table.Location = new Point(gbStudentContainer.Top - 5, 500);
            table.Dock = DockStyle.Fill;
            pnlStudentContainer.Controls.Add(table);
        }
    }
}
