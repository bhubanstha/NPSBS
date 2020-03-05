using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using iTextSharp.text;
using NPSBS.Core;

namespace NPSBS
{
	public partial class frmResult : KryptonForm
    {
        Exam exam = new Exam();
        SaveFileDialog sf = null;
        DataSet ds = null;
        int classId = 0;
        int ExaminationId = 0;
        public frmResult()
        {
            InitializeComponent();
            AutoComplete();

        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            GetClass();
            txtAcademicYear.Text = "2073";
            txtAcademicYear_Leave(sender, e);
            //ddlClass.SelectedValue = "13";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                classId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
                ExaminationId = Convert.ToInt32(ddlExamination.SelectedValue.ToString());
                ds = exam.GetClassResult(ExaminationId, classId);
                if (ds.Tables.Count < 1)
                {
                    Response.GenericError("No marks are available for this class");
                    return;
                }
                sf = new SaveFileDialog();
                sf.Title = "Publish Result";
                sf.DefaultExt = "pdf";
                sf.Filter = "PDF (*.pdf)|*.pdf";
                if (sf.ShowDialog() == DialogResult.OK && sf.FileName.Length > 0)
                {
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
            string fileName = (string)e.Result;
            this.Cursor = Cursors.Default;
            if(fileName != null) AppRunner.Run(fileName);

        }

        void bWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Document doc = null;
            try
            {
                if (classId == 1)
                {
                    doc = Nursery.Publish(sf.FileName, ds,ExaminationId, classId);
                    //Response.GenericError("Nursery class result processing on going.");
                }
                else if (classId >= 11)
                {
                    doc = ClassNineTen.Publish(sf.FileName, ds, classId);
                }
                else
                {
                    doc = pdfExtension.CreateDocument(true, sf.FileName, ds, classId);
                }
                e.Result = sf.FileName;
                if (doc.IsOpen())
                {
                    doc.CloseDocument();
                    doc.Close();
                }

            }
            catch (Exception ex)
            {
                Response.GenericError(ex.Message.ToString());
            }
            finally
            {

            }
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

        private void ddlExamination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAcademicYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly.Yes(txtAcademicYear, sender, e);
        }


    }
}
