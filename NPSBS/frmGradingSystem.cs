using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Education.Common;
using NPSBS.Core;

namespace NPSBS
{
    public partial class frmGradingSystem : Form
    {
        GradingSystem gs = new GradingSystem();
        int rows;
        public frmGradingSystem()
        {
            InitializeComponent();
            GetGradings();
            GridViewEditDelete.AddActions(gvGradingSystem);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                gs.MarksFrom = Convert.ToDecimal(txtMarksFrom.Text);
                gs.MarksTo = Convert.ToDecimal(txtMarksTo.Text);
                gs.Grade = txtGrade.Text;
                gs.Remarks = txtRemarks.Text;
                if (btnSave.Text.ToLower() == "save")
                {
                    rows = gs.Save(gs);                    
                    Response.SaveMessage(rows);
                }
                else if (btnSave.Text.ToLower() == "update")
                {
                    gs.GradingSystemId = Convert.ToInt32(lblGradingId.Text);
                    rows = gs.Update(gs);
                    lblGradingId.Text = "0";
                    btnSave.Text = "Save";
                    Response.UpdateMessage(rows);
                    
                }
                if (rows > 0)
                {
                    Clear();
                }
                GetGradings();
            }
        }


        private void GetGradings()
        {
            DataTable tbl = gs.Select();
            gvGradingSystem.DataSource = tbl;
        }
        private new bool Validate()
        {
            epGrade.Clear();
            epMarksFrom.Clear();
            epMarksTo.Clear();
            epRemarks.Clear();
            bool status = true;
            decimal mFrom = txtMarksFrom.Text == "" ? 0 : Convert.ToDecimal(txtMarksFrom.Text);
            decimal mTo = txtMarksTo.Text == "" ? 0 : Convert.ToDecimal(txtMarksTo.Text);
            if (txtMarksFrom.Text.Length < 1)
            {
                epMarksFrom.SetError(txtMarksFrom, "Marks from is required.");
                status = false;
            }
            if (txtMarksTo.Text.Length < 1)
            {
                epMarksTo.SetError(txtMarksTo, "Marks to mark is required.");
                status= false;
            }
            if (mFrom >= mTo)
            {
                epMarksFrom.SetError(txtMarksFrom, "Marks from should be less than Marks to marks");
                status= false;
            }
            if (mTo <= mFrom)
            {
                epMarksTo.SetError(txtMarksTo, "Marks to mark should be greater than marks from mark");
                status= false;
            }

            if (txtGrade.Text.Length == 0)
            {
                epGrade.SetError(txtGrade, "Grade is required");
                status= false;
            }
            if (txtRemarks.Text.Length == 0)
            {
                epRemarks.SetError(txtRemarks, "Remarks is required");
                status= false;
            }

            return status;
        }

        private void Clear()
        {
            txtMarksFrom.Text = "";
            txtMarksTo.Text = "";
            txtGrade.Text = "";
            txtRemarks.Text = "";
            txtMarksFrom.Focus();
        }

        private void gvGradingSystem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string action = gvGradingSystem.CurrentCell.Value.ToString().ToLower();
            int ind = gvGradingSystem.CurrentCell.RowIndex;
            DataGridViewRow row = gvGradingSystem.Rows[ind];
            string gradingId = row.Cells["GradingSystemId"].Value.ToString();

            if (action == "edit")
            {
                string markFrom = row.Cells["Marks From"].Value.ToString();
                string markTo = row.Cells["Marks To"].Value.ToString();
                string grade = row.Cells["Grade"].Value.ToString();
                string remarks = row.Cells["Remarks"].Value.ToString();
                txtMarksFrom.Text = markFrom;
                txtMarksTo.Text = markTo;
                txtGrade.Text = grade;
                txtRemarks.Text = remarks;
                lblGradingId.Text = gradingId;
                btnSave.Text = "Update";
            }
            else if (action == "delete")
            {
                DialogResult option = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (option == DialogResult.Yes)
                {
                    rows = gs.Delete(Convert.ToInt32(gradingId));
                    Response.DeleteMessage(rows);
                    GetGradings();
                }
            }
        }
    }
}
