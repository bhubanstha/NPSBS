namespace NPSBS
{
    partial class frmAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttendance));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlStudentContainer = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSubmitAttendance = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSchoolDays = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoadStudent = new System.Windows.Forms.Button();
            this.ddlClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlExam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.epYear = new System.Windows.Forms.ErrorProvider(this.components);
            this.epExam = new System.Windows.Forms.ErrorProvider(this.components);
            this.epClass = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClass)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendance Entry";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pnlStudentContainer);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 259);
            this.panel2.TabIndex = 1;
            // 
            // pnlStudentContainer
            // 
            this.pnlStudentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStudentContainer.Location = new System.Drawing.Point(0, 42);
            this.pnlStudentContainer.Name = "pnlStudentContainer";
            this.pnlStudentContainer.Size = new System.Drawing.Size(798, 182);
            this.pnlStudentContainer.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSubmitAttendance);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 224);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(798, 31);
            this.panel4.TabIndex = 1;
            // 
            // btnSubmitAttendance
            // 
            this.btnSubmitAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitAttendance.Location = new System.Drawing.Point(608, 4);
            this.btnSubmitAttendance.Name = "btnSubmitAttendance";
            this.btnSubmitAttendance.Size = new System.Drawing.Size(176, 27);
            this.btnSubmitAttendance.TabIndex = 5;
            this.btnSubmitAttendance.Text = "Submit Attendance";
            this.btnSubmitAttendance.UseVisualStyleBackColor = true;
            this.btnSubmitAttendance.Click += new System.EventHandler(this.btnSubmitAttendance_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSchoolDays);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 42);
            this.panel3.TabIndex = 0;
            // 
            // txtSchoolDays
            // 
            this.txtSchoolDays.Location = new System.Drawing.Point(117, 8);
            this.txtSchoolDays.MaxLength = 4;
            this.txtSchoolDays.Name = "txtSchoolDays";
            this.txtSchoolDays.Size = new System.Drawing.Size(85, 26);
            this.txtSchoolDays.TabIndex = 4;
            this.txtSchoolDays.Text = "70";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "School Days : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoadStudent);
            this.panel1.Controls.Add(this.ddlClass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ddlExam);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 111);
            this.panel1.TabIndex = 0;
            // 
            // btnLoadStudent
            // 
            this.btnLoadStudent.Location = new System.Drawing.Point(436, 56);
            this.btnLoadStudent.Name = "btnLoadStudent";
            this.btnLoadStudent.Size = new System.Drawing.Size(167, 29);
            this.btnLoadStudent.TabIndex = 3;
            this.btnLoadStudent.Text = "Load Student";
            this.btnLoadStudent.UseVisualStyleBackColor = true;
            this.btnLoadStudent.Click += new System.EventHandler(this.btnLoadStudent_Click);
            // 
            // ddlClass
            // 
            this.ddlClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlClass.FormattingEnabled = true;
            this.ddlClass.Location = new System.Drawing.Point(107, 57);
            this.ddlClass.Name = "ddlClass";
            this.ddlClass.Size = new System.Drawing.Size(216, 28);
            this.ddlClass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Class:";
            // 
            // ddlExam
            // 
            this.ddlExam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlExam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlExam.FormattingEnabled = true;
            this.ddlExam.Location = new System.Drawing.Point(436, 22);
            this.ddlExam.Name = "ddlExam";
            this.ddlExam.Size = new System.Drawing.Size(352, 28);
            this.ddlExam.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Exam :";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(107, 22);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(216, 26);
            this.txtYear.TabIndex = 0;
            this.txtYear.Leave += new System.EventHandler(this.txtYear_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 11;
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
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(808, 395);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAttendance";
            this.Text = "Attendance";
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlStudentContainer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSubmitAttendance;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSchoolDays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoadStudent;
        private System.Windows.Forms.ComboBox ddlClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlExam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider epYear;
        private System.Windows.Forms.ErrorProvider epExam;
        private System.Windows.Forms.ErrorProvider epClass;
    }
}