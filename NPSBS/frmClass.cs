using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Education.Common;
using NPSBS.Core;

namespace NPSBS
{
    public partial class frmClass : KryptonForm
    {
        private int  rowsAffected;
        Classes cl = null;

        public frmClass()
        {
            InitializeComponent();
            GetClasses();

            GridViewEditDelete.AddActions(dgvClasses);
        }

        private void btnAction_Click(object sender, EventArgs e)
        {  
            epClassName.Clear();
            if (btnAction.Text.ToLower() == "save")
            {
                if(Validate())
                {                    
                    cl = new Classes();
                    cl.ClassName = txtClassName.Text;
                    rowsAffected = cl.Save(cl);
                    txtClassName.Text = "";
                    Response.SaveMessage(rowsAffected);
                    GetClasses();
                }
            }
            else if (btnAction.Text.ToLower() == "update")
            {
                if (Validate())
                {
                    cl = new Classes();
                    cl.ClassName = txtClassName.Text;
                    cl.ClassId = Convert.ToInt32(lblClassId.Text);
                    rowsAffected = cl.Update(cl);
                    Response.UpdateMessage(rowsAffected);
                    btnAction.Text = "Save";
                    lblClassId.Text = "0";
                    txtClassName.Text = "";
                    GetClasses();
                }
            }
            txtClassName.Focus();
        }

        private void GetClasses()
        {
            cl = new Classes();
            var tbl = cl.Select();
            dgvClasses.DataSource = tbl;            
        }

        private void dgvClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string action = dgvClasses.CurrentCell.Value.ToString().ToLower();
            int ind = dgvClasses.CurrentCell.RowIndex;
            DataGridViewRow row = dgvClasses.Rows[ind];
            string classId = row.Cells["ClassId"].Value.ToString();

            if (action == "edit")
            {
                string className = row.Cells["Class Name"].Value.ToString();
                txtClassName.Text = className;
                lblClassId.Text = classId;
                btnAction.Text = "Update";
            }
            else if (action == "delete")
            {
              DialogResult option=  MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
              if (option == DialogResult.Yes)
              {
                  cl = new Classes();
                  rowsAffected = cl.Delete(Convert.ToInt32(classId));
                  Response.DeleteMessage(rowsAffected);
                  GetClasses();
              }
            }
            
        }

        private new bool Validate()
        {
            if (txtClassName.Text.Length == 0)
            {
                epClassName.SetError(txtClassName, "Please provide class name.");
                txtClassName.Focus();
                return false;
            }
            else if (txtClassName.Text.Length > 10)
            {
                epClassName.SetError(txtClassName, "Please provide class name with less than 10 characters.");
                txtClassName.Focus();
                return false;
            }
            return true;
        }
    }
}
