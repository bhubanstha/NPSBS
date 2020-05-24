using System.Windows.Forms;

namespace Education.Common
{
    public class GridViewEditDelete
    {
        public static void AddActions(DataGridView gridView)
        {
            FixView(gridView);
            if (gridView.Columns.Count > 0)
            {
                gridView.Columns[0].Visible = false;
            }
            DataGridViewLinkColumn editLink = new DataGridViewLinkColumn();
            editLink.UseColumnTextForLinkValue = true;
            editLink.HeaderText = "Edit";
            editLink.DataPropertyName = "lnkColumn";
            editLink.LinkBehavior = LinkBehavior.SystemDefault;
            editLink.Text = "Edit";
            gridView.Columns.Add(editLink);

            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";
            gridView.Columns.Add(Deletelink);
        }

        public static void FixView(DataGridView gridView)
        {
            gridView.BackgroundColor = System.Drawing.SystemColors.Control;
            gridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToResizeRows = false;
            gridView.AllowUserToResizeColumns = false;
            gridView.AllowUserToDeleteRows = false;
            gridView.AllowUserToOrderColumns = false;
            gridView.RowHeadersVisible = false;
            gridView.MultiSelect = false;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridView.ColumnHeadersHeight = 30;
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridView.RowTemplate.Height = 30;
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewCellStyle dgvCellStyle = new DataGridViewCellStyle();
            dgvCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            gridView.AlternatingRowsDefaultCellStyle = dgvCellStyle;
            gridView.EditMode = DataGridViewEditMode.EditOnEnter;
            gridView.CellEnter += GridView_CellEnter;

        }

        private static void GridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            if (dataGridView.CurrentRow.Cells[e.ColumnIndex].ReadOnly)
            {
                SendKeys.Send("{tab}");
            }
           
        }

    }
}
