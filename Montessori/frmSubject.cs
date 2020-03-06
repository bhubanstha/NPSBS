using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Montessori.Core;

namespace Montessori
{
	public partial class frmSubject : KryptonForm
    {
        Subject s = new Subject();
        int rows = 0;
        public frmSubject()
        {
            InitializeComponent();
            GetSubject();            
            GetClass();
        }
        private void frmSubject_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                try
                {
                    s.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
                    s.SubjectName = txtSubject.Text.Trim();
                    if (btnSave.Text.ToLower() == "save")
                    {
                        rows = s.Save(s);
                        Clear();
                        Response.SaveMessage(rows);
                    }
                    else if (btnSave.Text.ToLower() == "update")
                    {
                        s.SubjectId = Convert.ToInt32(lblSubjectID.Text);
                        rows = s.Update(s);
                        Clear();
                        lblSubjectID.Text = "0";
                        btnSave.Text = "Save";
                        Response.UpdateMessage(rows);
                    }
                    ddlClassSearch_SelectedIndexChanged(sender, e);
                    
                }
                catch (Exception ex)
                {
                    Response.GenericError(ex.Message.ToSentenceCase());
                }
                
            }
        }

        private void ddlClassSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvSubjects.Columns.Clear();
            gvSubjects.DataSource = s.SubjectByClassId(ddlClassSearch.SelectedValue.ToString());
            GridViewEditDelete.AddActions(gvSubjects);
        }

        private void Clear()
        {
            txtSubject.Text = "";
            txtSubject.Focus();
        }

        private bool Validate()
        {
            bool status = true;
            epClass.Clear();
            epSubject.Clear();
            epTheory.Clear();
            epPractical.Clear();
            if (ddlClass.SelectedValue.ToString() == "0")
            {
                epClass.SetError(ddlClass, "Class Name is required.");
                status = false;
            }
            if (txtSubject.Text.Length == 0)
            {
                epSubject.SetError(txtSubject, "Subject Name is required.");
                status = false;
            }
            
            return status;
        }

        private void GetClass()
        {
            var tbl = new Classes().Select();
            ddlClass.DataSource = tbl;
            ddlClass.DisplayMember = "Class Name";
            ddlClass.ValueMember = "ClassId";

            ddlClassSearch.DataSource = tbl.Copy();
            ddlClassSearch.DisplayMember = "Class Name";
            ddlClassSearch.ValueMember = "ClassId";
        }

        private void GetSubject()
        {
            var tbl = s.Select();
            gvSubjects.DataSource = tbl;
        }

        private void gvSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string action = gvSubjects.CurrentCell.Value.ToString().ToLower();
            int ind = gvSubjects.CurrentCell.RowIndex;
            DataGridViewRow row = gvSubjects.Rows[ind];
            string subjectId = row.Cells["SubjectId"].Value.ToString();

            if (action == "edit")
            {
                var tbl = s.SelectById(Convert.ToInt32(subjectId));
                ddlClass.SelectedValue = tbl.Rows[0]["ClassId"].ToString();
                txtSubject.Text = tbl.Rows[0]["SubjectName"].ToString();
                lblSubjectID.Text = subjectId;
                btnSave.Text = "Update";
            }
            else if (action == "delete")
            {
                DialogResult option = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (option == DialogResult.Yes)
                {
                    rows = s.Delete(Convert.ToInt32(subjectId));
                    Response.DeleteMessage(rows);
                    GetSubject();
                }
            }
        }
        
        private void txtSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly.StringOnly(txtSubject, sender, e, true);
        }

      
    }
}
