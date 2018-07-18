namespace Montessori
{
    partial class frmMarkEntry
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarkEntry));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ddlSubject = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.ddlClass = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnLoadStudent = new System.Windows.Forms.Button();
			this.ddlExam = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.epYear = new System.Windows.Forms.ErrorProvider(this.components);
			this.epExam = new System.Windows.Forms.ErrorProvider(this.components);
			this.epClass = new System.Windows.Forms.ErrorProvider(this.components);
			this.gbStudentContainer = new System.Windows.Forms.GroupBox();
			this.pnlStudentContainer = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnSubmitMarks = new System.Windows.Forms.Button();
			this.dgvMarkEntry = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.epYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epExam)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epClass)).BeginInit();
			this.gbStudentContainer.SuspendLayout();
			this.pnlStudentContainer.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvMarkEntry)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ddlSubject);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.ddlClass);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnLoadStudent);
			this.groupBox1.Controls.Add(this.ddlExam);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtYear);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(812, 193);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Exam Detail";
			// 
			// ddlSubject
			// 
			this.ddlSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.ddlSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.ddlSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlSubject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ddlSubject.FormattingEnabled = true;
			this.ddlSubject.Location = new System.Drawing.Point(437, 82);
			this.ddlSubject.Name = "ddlSubject";
			this.ddlSubject.Size = new System.Drawing.Size(352, 29);
			this.ddlSubject.TabIndex = 4;
			this.ddlSubject.SelectedIndexChanged += new System.EventHandler(this.ddlSubject_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(367, 85);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 21);
			this.label4.TabIndex = 9;
			this.label4.Text = "Subject:";
			// 
			// ddlClass
			// 
			this.ddlClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.ddlClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.ddlClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ddlClass.FormattingEnabled = true;
			this.ddlClass.Location = new System.Drawing.Point(108, 79);
			this.ddlClass.Name = "ddlClass";
			this.ddlClass.Size = new System.Drawing.Size(216, 29);
			this.ddlClass.TabIndex = 3;
			this.ddlClass.SelectedIndexChanged += new System.EventHandler(this.ddlClass_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(52, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 21);
			this.label1.TabIndex = 7;
			this.label1.Text = "Class:";
			// 
			// btnLoadStudent
			// 
			this.btnLoadStudent.Location = new System.Drawing.Point(108, 128);
			this.btnLoadStudent.Name = "btnLoadStudent";
			this.btnLoadStudent.Size = new System.Drawing.Size(216, 36);
			this.btnLoadStudent.TabIndex = 5;
			this.btnLoadStudent.Text = "Load Students";
			this.btnLoadStudent.UseVisualStyleBackColor = true;
			this.btnLoadStudent.Click += new System.EventHandler(this.btnLoadStudent_Click);
			// 
			// ddlExam
			// 
			this.ddlExam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.ddlExam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.ddlExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ddlExam.FormattingEnabled = true;
			this.ddlExam.Location = new System.Drawing.Point(437, 44);
			this.ddlExam.Name = "ddlExam";
			this.ddlExam.Size = new System.Drawing.Size(352, 29);
			this.ddlExam.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(377, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "Exam :";
			// 
			// txtYear
			// 
			this.txtYear.Location = new System.Drawing.Point(108, 44);
			this.txtYear.MaxLength = 4;
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(216, 29);
			this.txtYear.TabIndex = 1;
			this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
			this.txtYear.Leave += new System.EventHandler(this.txtYear_Leave);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "Exam Year :";
			// 
			// epYear
			// 
			this.epYear.ContainerControl = this;
			// 
			// epExam
			// 
			this.epExam.ContainerControl = this;
			// 
			// epClass
			// 
			this.epClass.ContainerControl = this;
			// 
			// gbStudentContainer
			// 
			this.gbStudentContainer.Controls.Add(this.pnlStudentContainer);
			this.gbStudentContainer.Controls.Add(this.panel2);
			this.gbStudentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbStudentContainer.Location = new System.Drawing.Point(0, 193);
			this.gbStudentContainer.Name = "gbStudentContainer";
			this.gbStudentContainer.Size = new System.Drawing.Size(812, 461);
			this.gbStudentContainer.TabIndex = 11;
			this.gbStudentContainer.TabStop = false;
			this.gbStudentContainer.Text = "Student List";
			// 
			// pnlStudentContainer
			// 
			this.pnlStudentContainer.Controls.Add(this.dgvMarkEntry);
			this.pnlStudentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlStudentContainer.Location = new System.Drawing.Point(3, 25);
			this.pnlStudentContainer.Name = "pnlStudentContainer";
			this.pnlStudentContainer.Size = new System.Drawing.Size(806, 389);
			this.pnlStudentContainer.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnSubmitMarks);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(3, 414);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(806, 44);
			this.panel2.TabIndex = 2;
			// 
			// btnSubmitMarks
			// 
			this.btnSubmitMarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSubmitMarks.Location = new System.Drawing.Point(625, 7);
			this.btnSubmitMarks.Name = "btnSubmitMarks";
			this.btnSubmitMarks.Size = new System.Drawing.Size(172, 34);
			this.btnSubmitMarks.TabIndex = 0;
			this.btnSubmitMarks.Text = "Submit Marks";
			this.btnSubmitMarks.UseVisualStyleBackColor = true;
			this.btnSubmitMarks.Click += new System.EventHandler(this.btnSubmitMarks_Click);
			// 
			// dgvMarkEntry
			// 
			this.dgvMarkEntry.AllowUserToAddRows = false;
			this.dgvMarkEntry.AllowUserToDeleteRows = false;
			this.dgvMarkEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvMarkEntry.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvMarkEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMarkEntry.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvMarkEntry.Location = new System.Drawing.Point(0, 0);
			this.dgvMarkEntry.Name = "dgvMarkEntry";
			this.dgvMarkEntry.RowHeadersWidth = 20;
			this.dgvMarkEntry.RowTemplate.Height = 30;
			this.dgvMarkEntry.Size = new System.Drawing.Size(806, 389);
			this.dgvMarkEntry.TabIndex = 0;
			// 
			// frmMarkEntry
			// 
			this.AcceptButton = this.btnLoadStudent;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoScrollMinSize = new System.Drawing.Size(100, 0);
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(812, 654);
			this.Controls.Add(this.gbStudentContainer);
			this.Controls.Add(this.groupBox1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = System.Windows.Forms.ImeMode.On;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmMarkEntry";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Marks Entry";
			this.Load += new System.EventHandler(this.frmMarkEntry_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.epYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epExam)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epClass)).EndInit();
			this.gbStudentContainer.ResumeLayout(false);
			this.pnlStudentContainer.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvMarkEntry)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadStudent;
        private System.Windows.Forms.ComboBox ddlExam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider epYear;
        private System.Windows.Forms.ErrorProvider epExam;
        private System.Windows.Forms.ErrorProvider epClass;
        private System.Windows.Forms.GroupBox gbStudentContainer;
        private System.Windows.Forms.Panel pnlStudentContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSubmitMarks;
        private System.Windows.Forms.ComboBox ddlSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlClass;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvMarkEntry;
	}
}