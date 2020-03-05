using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPSBS.Core;
using ComponentFactory.Krypton.Toolkit;

namespace NPSBS
{
	public partial class frmSubject : KryptonForm
	{
		Subject s = new Subject();
		int rows = 0;
		public frmSubject()
		{
			InitializeComponent();
			this.Load += FrmSubject_Load;
			
		}

		private void FrmSubject_Load(object sender, EventArgs e)
		{
			GetSubject();
			GetClass();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (Validate())
			{
				try
				{
					s.ClassId = Convert.ToInt32(ddlClass.SelectedValue.ToString());
					s.SubjectName = txtSubject.Text.Trim();
					s.Theorymarks = Convert.ToDecimal(txtTheoryMarks.Text.Trim());
					s.Practicalmarks = Convert.ToDecimal(txtPracticalMarks.Text.Trim());
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
					MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			txtTheoryMarks.Text = "";
			txtPracticalMarks.Text = "0";
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
			if (txtTheoryMarks.Text.Length == 0 || txtTheoryMarks.Text.Length > 6)
			{
				if (txtTheoryMarks.Text.Length > 0 && Convert.ToDecimal(txtTheoryMarks.Text.Trim()) > 100)
				{
					epTheory.SetError(txtTheoryMarks, "Theory marks can not be greater than 100.");
				}
				else
				{
					epTheory.SetError(txtTheoryMarks, "Theory marks is required.");
				}
				status = false;
			}
			if (txtPracticalMarks.Text.Length == 0 || txtPracticalMarks.Text.Length > 6)
			{
				if (txtPracticalMarks.Text.Length > 0 && Convert.ToDecimal(txtPracticalMarks.Text.Trim()) > 50)
				{
					epPractical.SetError(txtPracticalMarks, "Practical marks can not be greater than 50.");
				}
				else
				{
					epPractical.SetError(txtPracticalMarks, "Practical marks is required.");
				}
				status = false;

			}
			if (txtPracticalMarks.Text.Length > 0)
			{
				if (Convert.ToDecimal(txtPracticalMarks.Text.Trim()) > 50)
				{
					epPractical.SetError(txtPracticalMarks, "Practical marks can not be greater than 50.");
					status = false;
				}

			}
			if (txtTheoryMarks.Text.Length > 0)
			{
				if (Convert.ToDecimal(txtTheoryMarks.Text.Trim()) > 100)
				{
					epTheory.SetError(txtTheoryMarks, "Theory marks can not be greater than 100.");
					status = false;
				}
			}
			if (txtTheoryMarks.Text.Length > 0 && txtPracticalMarks.Text.Length > 0)
			{
				decimal sum = Convert.ToDecimal(txtTheoryMarks.Text) + Convert.ToDecimal(txtPracticalMarks.Text);
				if (sum > 100)
				{
					epTheory.SetError(txtTheoryMarks, "Sum of theory and practical marks can not be greater than 100.");
					epPractical.SetError(txtPracticalMarks, "Sum of theory and practical marks can not be greater than 100.");
				}
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
				txtTheoryMarks.Text = tbl.Rows[0]["TheoryMarks"].ToString();
				txtPracticalMarks.Text = tbl.Rows[0]["PracticalMarks"].ToString();
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

		private void txtTheoryMarks_KeyPress(object sender, KeyPressEventArgs e)
		{
			NumberOnly.DecimalType(txtTheoryMarks, sender, e);
		}

		private void txtPracticalMarks_KeyPress(object sender, KeyPressEventArgs e)
		{
			NumberOnly.DecimalType(txtPracticalMarks, sender, e);
		}

		private void txtSubject_KeyPress(object sender, KeyPressEventArgs e)
		{
			NumberOnly.StringOnly(txtSubject, sender, e);
		}

	}
}
