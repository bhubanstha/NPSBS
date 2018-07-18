namespace Montessori
{
    partial class frmExtraActivities
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExtraActivities));
			this.btnSubmitMarks = new System.Windows.Forms.Button();
			this.btnLoadStudent = new System.Windows.Forms.Button();
			this.ddlExam = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.gbStudentContainer = new System.Windows.Forms.GroupBox();
			this.pnlStudentContainer = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtSchoolDays = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.epClass = new System.Windows.Forms.ErrorProvider(this.components);
			this.txtYear = new System.Windows.Forms.TextBox();
			this.epYear = new System.Windows.Forms.ErrorProvider(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.epExam = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ddlClass = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dgvExtraActivities = new System.Windows.Forms.DataGridView();
			this.gbStudentContainer.SuspendLayout();
			this.pnlStudentContainer.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.epClass)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epExam)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvExtraActivities)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSubmitMarks
			// 
			this.btnSubmitMarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSubmitMarks.Location = new System.Drawing.Point(666, 7);
			this.btnSubmitMarks.Name = "btnSubmitMarks";
			this.btnSubmitMarks.Size = new System.Drawing.Size(172, 34);
			this.btnSubmitMarks.TabIndex = 0;
			this.btnSubmitMarks.Text = "Submit Marks";
			this.btnSubmitMarks.UseVisualStyleBackColor = true;
			this.btnSubmitMarks.Click += new System.EventHandler(this.btnSubmitMarks_Click);
			// 
			// btnLoadStudent
			// 
			this.btnLoadStudent.Location = new System.Drawing.Point(437, 88);
			this.btnLoadStudent.Name = "btnLoadStudent";
			this.btnLoadStudent.Size = new System.Drawing.Size(216, 36);
			this.btnLoadStudent.TabIndex = 4;
			this.btnLoadStudent.Text = "Load Students";
			this.btnLoadStudent.UseVisualStyleBackColor = true;
			this.btnLoadStudent.Click += new System.EventHandler(this.btnLoadStudent_Click);
			// 
			// ddlExam
			// 
			this.ddlExam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.ddlExam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.ddlExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlExam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ddlExam.FormattingEnabled = true;
			this.ddlExam.Location = new System.Drawing.Point(437, 44);
			this.ddlExam.Name = "ddlExam";
			this.ddlExam.Size = new System.Drawing.Size(352, 28);
			this.ddlExam.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(377, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Exam :";
			// 
			// gbStudentContainer
			// 
			this.gbStudentContainer.Controls.Add(this.pnlStudentContainer);
			this.gbStudentContainer.Controls.Add(this.panel1);
			this.gbStudentContainer.Controls.Add(this.panel2);
			this.gbStudentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbStudentContainer.Location = new System.Drawing.Point(0, 131);
			this.gbStudentContainer.Name = "gbStudentContainer";
			this.gbStudentContainer.Size = new System.Drawing.Size(853, 269);
			this.gbStudentContainer.TabIndex = 13;
			this.gbStudentContainer.TabStop = false;
			this.gbStudentContainer.Text = "Student List";
			// 
			// pnlStudentContainer
			// 
			this.pnlStudentContainer.Controls.Add(this.dgvExtraActivities);
			this.pnlStudentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlStudentContainer.Location = new System.Drawing.Point(3, 58);
			this.pnlStudentContainer.Name = "pnlStudentContainer";
			this.pnlStudentContainer.Size = new System.Drawing.Size(847, 164);
			this.pnlStudentContainer.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtSchoolDays);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(3, 22);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(847, 36);
			this.panel1.TabIndex = 3;
			// 
			// txtSchoolDays
			// 
			this.txtSchoolDays.Location = new System.Drawing.Point(137, 4);
			this.txtSchoolDays.MaxLength = 4;
			this.txtSchoolDays.Name = "txtSchoolDays";
			this.txtSchoolDays.Size = new System.Drawing.Size(184, 26);
			this.txtSchoolDays.TabIndex = 5;
			this.txtSchoolDays.Text = "70";
			this.txtSchoolDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSchoolDays_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "School Days: ";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnSubmitMarks);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(3, 222);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(847, 44);
			this.panel2.TabIndex = 2;
			// 
			// epClass
			// 
			this.epClass.ContainerControl = this;
			// 
			// txtYear
			// 
			this.txtYear.Location = new System.Drawing.Point(108, 44);
			this.txtYear.MaxLength = 4;
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(216, 26);
			this.txtYear.TabIndex = 1;
			this.txtYear.Leave += new System.EventHandler(this.txtYear_Leave);
			// 
			// epYear
			// 
			this.epYear.ContainerControl = this;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Exam Year :";
			// 
			// epExam
			// 
			this.epExam.ContainerControl = this;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ddlClass);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btnLoadStudent);
			this.groupBox1.Controls.Add(this.ddlExam);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtYear);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(853, 131);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Exam Detail";
			// 
			// ddlClass
			// 
			this.ddlClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.ddlClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.ddlClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ddlClass.FormattingEnabled = true;
			this.ddlClass.Location = new System.Drawing.Point(108, 88);
			this.ddlClass.Name = "ddlClass";
			this.ddlClass.Size = new System.Drawing.Size(216, 28);
			this.ddlClass.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(48, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Class :";
			// 
			// dgvExtraActivities
			// 
			this.dgvExtraActivities.AllowUserToAddRows = false;
			this.dgvExtraActivities.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.dgvExtraActivities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvExtraActivities.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvExtraActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvExtraActivities.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvExtraActivities.Location = new System.Drawing.Point(0, 0);
			this.dgvExtraActivities.Name = "dgvExtraActivities";
			this.dgvExtraActivities.RowHeadersWidth = 15;
			this.dgvExtraActivities.RowTemplate.Height = 30;
			this.dgvExtraActivities.Size = new System.Drawing.Size(847, 164);
			this.dgvExtraActivities.TabIndex = 0;
			// 
			// frmExtraActivities
			// 
			this.AcceptButton = this.btnLoadStudent;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(853, 400);
			this.Controls.Add(this.gbStudentContainer);
			this.Controls.Add(this.groupBox1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmExtraActivities";
			this.Text = "Extra Activities";
			this.gbStudentContainer.ResumeLayout(false);
			this.pnlStudentContainer.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.epClass)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epExam)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvExtraActivities)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitMarks;
        private System.Windows.Forms.Button btnLoadStudent;
        private System.Windows.Forms.ComboBox ddlExam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbStudentContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider epClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider epYear;
        private System.Windows.Forms.ErrorProvider epExam;
        private System.Windows.Forms.Panel pnlStudentContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSchoolDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlClass;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgvExtraActivities;
	}
}