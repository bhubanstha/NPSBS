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
    public partial class frmExtraActivities : Form
    {
        Exam exam = new Exam();
        int totalStudents = 0;
        TableLayoutPanel table = null;
        int rows = 0;

        public frmExtraActivities()
        {
            InitializeComponent();
            GetClass();
            AutoComplete();
        }
        private void CreateTable(DataTable tbl)
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
            table.ColumnCount = tbl.Rows.Count + 2;
            //table.ColumnCount = 8;
            table.RowCount = 1;
            table.RowStyles.Clear();
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));

            table.Controls.Add(new Label() { Text = "S.N", AutoSize = true, Width = 100 }, 0, 0);
            table.Controls.Add(new Label() { Text = "Co-Curricular Activities", AutoSize = true, Width = 100 }, 1, 0);
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
                string name = tbl.Rows[i]["StudentFullName"].ToString() + " -" + tbl.Rows[i]["StudentId"].ToString() + "";
                table.Controls.Add(new Label() { Text = name, AutoSize = true, Width = 100, Name="StudentName"+i.ToString() }, i + 2, 0);
            }
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
                this.Cursor = Cursors.AppStarting;
                var tbl = ExtraActivities.GetExtraActivities(txtYear.Text, ddlExam.SelectedValue.ToString(), ddlClass.SelectedValue.ToString());
                totalStudents = tbl.Rows.Count;
                txtSchoolDays.Text = tbl.Rows[0]["SchoolDays"].ToString() == "" ? "70" : tbl.Rows[0]["SchoolDays"].ToString();
                if (totalStudents > 0)
                {
                    CreateTable(tbl);
                    for (int i = 3; i < tbl.Columns.Count; i++)
                    {
                        table.RowCount = table.RowCount + 1;
                        Label lb = new Label();
                        lb.Text = (i - 2).ToString();
                        lb.Width = 150;
                        lb.Name = "SN" + i;
                        lb.AutoSize = true;
                        table.Controls.Add(lb, 0, table.RowCount - 1);

                        Label lb1 = new Label();
                        lb1.Text = tbl.Columns[i].ColumnName.ToString().Replace("_", " ");
                        lb1.Width = 250;
                        lb1.AutoSize = true;
                        table.Controls.Add(lb1, 1, table.RowCount - 1);

                       
                        for (int j = 0; j < tbl.Rows.Count; j++)
                        {
                            string id = "Txt" + i.ToString() + j.ToString();
                            TextBox tb = new TextBox();
                            tb.Name = id;
                            tb.Width = 150;
                            tb.MaxLength = 50;
                            if (i == 3)
                            {
                                tb.Text = tbl.Rows[j][i].ToString();// txtSchoolDays.Text.ToString();
                               // tb.Enabled = false;
                            }
                            else
                            {
                                tb.Text =  tbl.Rows[j][i].ToString();
                            }
                            tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
                            //tb.KeyPress += tb_KeyPress;
                            table.Controls.Add(tb, j + 2, table.RowCount - 1);
                        }
                    }
                }
                else
                {
                    try
                    {
                        pnlStudentContainer.Controls.Remove(table);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    MessageBox.Show("There are no student in Nursery class for this year.", "No Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Cursor = Cursors.Default;
                pnlStudentContainer.Visible = true;
            }
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
            string examinationId = ddlExam.SelectedValue.ToString();
            string year = txtYear.Text;
            string schoolDays = txtSchoolDays.Text;

            for (int i = 0; i < totalStudents; i++)
            {
                Label lb = table.Controls.Find("StudentName"+i.ToString(), true).FirstOrDefault() as Label;
                string studentId = lb.Text.Split('-')[1].Trim();

                TextBox tb = table.Controls.Find("Txt3"+i, true).FirstOrDefault() as TextBox;
                string presentDays = tb.Text;

                //TextBox tb1 = table.Controls.Find("Txt4" + i, true).FirstOrDefault() as TextBox;
                //string ReadingWriting = tb1.Text;

                //TextBox tb2 = table.Controls.Find("Txt5" + i, true).FirstOrDefault() as TextBox;
                //string Recognition = tb2.Text;

                TextBox tb3 = table.Controls.Find("Txt4" + i, true).FirstOrDefault() as TextBox;
                string English = tb3.Text;

                TextBox tb4 = table.Controls.Find("Txt5" + i, true).FirstOrDefault() as TextBox;
                string Nepali = tb4.Text;

                TextBox tb5 = table.Controls.Find("Txt6" + i, true).FirstOrDefault() as TextBox;
                string Copying = tb5.Text;

                //TextBox tb6 = table.Controls.Find("Txt9" + i, true).FirstOrDefault() as TextBox;
                //string AcademicAttitude = tb6.Text;

                TextBox tb7 = table.Controls.Find("Txt7" + i, true).FirstOrDefault() as TextBox;
                string Concentration = tb7.Text;

                TextBox tb8 = table.Controls.Find("Txt8" + i, true).FirstOrDefault() as TextBox;
                string Cooperation = tb8.Text;

                TextBox tb9 = table.Controls.Find("Txt9" + i, true).FirstOrDefault() as TextBox;
                string Memory = tb9.Text;

                TextBox tb10 = table.Controls.Find("Txt10" + i, true).FirstOrDefault() as TextBox;
                string Curiosity = tb10.Text;

                TextBox tb11 = table.Controls.Find("Txt11" + i, true).FirstOrDefault() as TextBox;
                string Understanding = tb11.Text;

                //TextBox tb12 = table.Controls.Find("Txt15" + i, true).FirstOrDefault() as TextBox;
                //string StudentDepart = tb12.Text;

                TextBox tb13 = table.Controls.Find("Txt12" + i, true).FirstOrDefault() as TextBox;
                string Conduct = tb13.Text;

                TextBox tb14 = table.Controls.Find("Txt13" + i, true).FirstOrDefault() as TextBox;
                string Neat = tb14.Text;

                TextBox tb15 = table.Controls.Find("Txt14" + i, true).FirstOrDefault() as TextBox;
                string Punctual = tb15.Text;

                TextBox tb16 = table.Controls.Find("Txt15" + i, true).FirstOrDefault() as TextBox;
                string Polite = tb16.Text;

                TextBox tb17 = table.Controls.Find("Txt16" + i, true).FirstOrDefault() as TextBox;
                string Height = tb17.Text;

                //TextBox tb18 = table.Controls.Find("Txt21" + i, true).FirstOrDefault() as TextBox;
                //string ExtraCurricular = tb18.Text;

                TextBox tb19 = table.Controls.Find("Txt17" + i, true).FirstOrDefault() as TextBox;
                string Drill = tb19.Text;

                TextBox tb20 = table.Controls.Find("Txt18" + i, true).FirstOrDefault() as TextBox;
                string Dance = tb20.Text;

                TextBox tb21 = table.Controls.Find("Txt19" + i, true).FirstOrDefault() as TextBox;
                string Rhymes = tb21.Text;
                
                ExtraActivities ea = new ExtraActivities();
                ea.StudentId = studentId;
                ea.ActivitiesYear = year;
                ea.ExaminationId = Convert.ToInt32(examinationId);
                ea.SchoolDays = Convert.ToInt32(schoolDays);
                ea.PresentDays = Convert.ToInt32(presentDays);
               // ea.RecognitionofLetter = Recognition;
                //ea.ReadingAndWriting = ReadingWriting;
                ea.English = English;
                ea.Nepali = Nepali;
                ea.CopyingSkill = Copying;
                //ea.StudentsAcademicAttitude = AcademicAttitude;
                ea.Concentration = Concentration;
                ea.Cooperation = Cooperation;
                ea.Memory = Memory;
                ea.Curiosity = Curiosity;
                ea.Understanding = Understanding;
                //ea.StudentDepartment = StudentDepart;
                ea.Conduct = Conduct;
                ea.Neatness = Neat;
                ea.Punctuality = Punctual;
                ea.Politeness = Polite;
                ea.HeightAndWeight = Height;
                //ea.ExtraCurricular = ExtraCurricular;
                ea.Drill = Drill;
                ea.Dance = Dance;
                ea.Rhymes = Rhymes;
                rows =  ea.Save(ea);
               

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

        private void txtSchoolDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly.Yes(txtSchoolDays, sender, e);
        }
    }
}
