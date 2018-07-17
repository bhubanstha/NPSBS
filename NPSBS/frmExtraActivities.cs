using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPSBS.Core;

namespace NPSBS
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
            AutoComplete();
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
            table.ColumnCount = 8;
            table.RowCount = 1;
            table.RowStyles.Clear();
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
            table.Controls.Add(new Label() { Text = "Roll Number", AutoSize = true, Width = 100 }, 0, 0);
            table.Controls.Add(new Label() { Text = "Name", AutoSize = true, Width = 150 }, 1, 0);
            table.Controls.Add(new Label() { Text = "Present Days", AutoSize = true, Width = 150 }, 2, 0);
            table.Controls.Add(new Label() { Text = "Drawing", Width = 150, AutoSize = true }, 3, 0);
            table.Controls.Add(new Label() { Text = "Games", Width = 150, AutoSize = true }, 4, 0);
            table.Controls.Add(new Label() { Text = "Conduct", Width = 150, AutoSize = true }, 5, 0);
            table.Controls.Add(new Label() { Text = "Personal Cleanliness", Width = 150, AutoSize = true }, 6, 0);
            table.Controls.Add(new Label() { Text = "Co- operation", Width = 150, AutoSize = true }, 7, 0);
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
                var tbl = ExtraActivities.GetExtraActivities(txtYear.Text,ddlExam.SelectedValue.ToString());
                totalStudents = tbl.Rows.Count;               
                if (totalStudents > 0)
                {
                    txtSchoolDays.Text = tbl.Rows[0]["SchoolDays"].ToString() == "" ? "70" : 
                                            tbl.Rows[0]["SchoolDays"].ToString();
                    CreateTable();
                    for (int i = 0; i < tbl.Rows.Count; i++)
                    {
                        table.RowCount = table.RowCount + 1;
                        TextBox tb = new TextBox();
                        tb.Name = "PresentDays" + i;
                        tb.Width = 150;
                        tb.Text = tbl.Rows[i]["PresentDays"].ToString();
                        tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
                        tb.GotFocus += tb1_GotFocus;

                        TextBox tb1 = new TextBox();
                        tb1.Name = "Drawing" + i;
                        tb1.Width = 150;
                        tb1.Text =  tbl.Rows[i]["Drawing"].ToString();
                        tb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
                       


                        TextBox tb2 = new TextBox();
                        tb2.Name = "Game" + i;
                        tb2.Width = 150;
                        tb2.Text = tbl.Rows[i]["Games"].ToString();
                        tb2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));

                        TextBox tb3 = new TextBox();
                        tb3.Name = "Conduct" + i;
                        tb3.Width = 150;
                        tb3.Text = tbl.Rows[i]["Conduct"].ToString();
                        tb3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));

                        TextBox tb4 = new TextBox();
                        tb4.Name = "Cleanliness" + i;
                        tb4.Width = 150;
                        tb4.Text = tbl.Rows[i]["PersonalCleanliness"].ToString();
                        tb4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));

                        TextBox tb5 = new TextBox();
                        tb5.Name = "Cooperation" + i;
                        tb5.Width = 150;
                        tb5.Text = tbl.Rows[i]["Cooperation"].ToString();
                        tb5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));


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
                        table.Controls.Add(tb1, 3, table.RowCount - 1);
                        table.Controls.Add(tb2, 4, table.RowCount - 1);
                        table.Controls.Add(tb3, 5, table.RowCount - 1);
                        table.Controls.Add(tb4, 6, table.RowCount - 1);
                        table.Controls.Add(tb5, 7, table.RowCount - 1);
                    }
                    table.Controls.Add(new Label { Text = "" }, 0, table.RowCount);
                    table.Controls.Add(new Label { Text = "" }, 1, table.RowCount);
                    table.Controls.Add(new Label { Text = "" }, 2, table.RowCount);
                    table.Controls.Add(new Label { Text = "" }, 3, table.RowCount);
                    table.Controls.Add(new Label { Text = "" }, 4, table.RowCount);
                    table.Controls.Add(new Label { Text = "" }, 5, table.RowCount);
                    table.Controls.Add(new Label { Text = "" }, 6, table.RowCount);
                    table.Controls.Add(new Label { Text = "" }, 7, table.RowCount);

                    TextBox tbFirst = table.Controls.Find("PresentDays0", true).FirstOrDefault() as TextBox;
                    tbFirst.Focus();
                   

                }
                else
                {
                    MessageBox.Show("There are no student in Nursery class for this year.", "No Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Cursor = Cursors.Default;
                pnlStudentContainer.Visible = true;
            }
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
                string presentDays = "PresentDays" + i;
                string drawing = "Drawing" + i;
                string game = "Game" + i;
                string conduct = "Conduct" + i;
                string cleanliness = "Cleanliness" + i;
                string cooperation = "Cooperation" + i;
                string rollNumber = "RollNumber" + i;

                TextBox tb = table.Controls.Find(presentDays, true).FirstOrDefault() as TextBox;
                string prDays = tb.Text;

                TextBox tb1 = table.Controls.Find(drawing, true).FirstOrDefault() as TextBox;
                string drw = tb1.Text;

                TextBox tb2 = table.Controls.Find(game, true).FirstOrDefault() as TextBox;
                string gm = tb2.Text;

                TextBox tb3 = table.Controls.Find(conduct, true).FirstOrDefault() as TextBox;
                string con = tb3.Text;

                TextBox tb4 = table.Controls.Find(cleanliness, true).FirstOrDefault() as TextBox;
                string clean = tb4.Text;

                TextBox tb5 = table.Controls.Find(cooperation, true).FirstOrDefault() as TextBox;
                string cop = tb5.Text;


                Label lbl = table.Controls.Find(rollNumber, true).FirstOrDefault() as Label;
                string rol = lbl.Text;

                ExtraActivities ea = new ExtraActivities();
                ea.RollNumber = rol;
                ea.ActivitiesYear = year;
                ea.ExaminationId = Convert.ToInt32(examinationId);
                ea.SchoolDays = Convert.ToInt32(schoolDays);
                ea.PresentDays = Convert.ToInt32(prDays);
                ea.Drawing = drw;
                ea.Games = gm;
                ea.Conduct = con;
                ea.PersonalClenliness = clean;
                ea.Cooperation = cop;
                rows += ea.Save(ea);

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
    }
}
