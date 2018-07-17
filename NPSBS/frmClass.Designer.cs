namespace NPSBS
{
    partial class frmClass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClass));
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.btnAction = new System.Windows.Forms.Button();
            this.epClassName = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblClassId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClassName)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(25, 47);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(102, 20);
            this.lblClassName.TabIndex = 0;
            this.lblClassName.Text = "Class Name :";
            // 
            // txtClassName
            // 
            this.txtClassName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassName.Location = new System.Drawing.Point(135, 44);
            this.txtClassName.MaxLength = 10;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(339, 26);
            this.txtClassName.TabIndex = 1;
            // 
            // dgvClasses
            // 
            this.dgvClasses.AllowUserToAddRows = false;
            this.dgvClasses.AllowUserToDeleteRows = false;
            this.dgvClasses.AllowUserToResizeColumns = false;
            this.dgvClasses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvClasses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasses.BackgroundColor = System.Drawing.Color.White;
            this.dgvClasses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvClasses.ColumnHeadersHeight = 30;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClasses.Location = new System.Drawing.Point(29, 121);
            this.dgvClasses.MultiSelect = false;
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowHeadersVisible = false;
            this.dgvClasses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClasses.RowTemplate.Height = 30;
            this.dgvClasses.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasses.Size = new System.Drawing.Size(445, 194);
            this.dgvClasses.TabIndex = 2;
            this.dgvClasses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_CellClick);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(135, 76);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(119, 31);
            this.btnAction.TabIndex = 3;
            this.btnAction.Text = "Save";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // epClassName
            // 
            this.epClassName.ContainerControl = this;
            // 
            // lblClassId
            // 
            this.lblClassId.AutoSize = true;
            this.lblClassId.Location = new System.Drawing.Point(25, 81);
            this.lblClassId.Name = "lblClassId";
            this.lblClassId.Size = new System.Drawing.Size(18, 20);
            this.lblClassId.TabIndex = 4;
            this.lblClassId.Text = "0";
            this.lblClassId.Visible = false;
            // 
            // frmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(502, 337);
            this.Controls.Add(this.lblClassId);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.dgvClasses);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.lblClassName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmClass";
            this.Text = "Class";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClassName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ErrorProvider epClassName;
        private System.Windows.Forms.Label lblClassId;
    }
}