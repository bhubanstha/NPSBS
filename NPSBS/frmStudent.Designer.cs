namespace NPSBS
{
    partial class frmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlClass = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtRollNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAcademicYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblExcelSample = new System.Windows.Forms.LinkLabel();
            this.lblReading = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAcademicYearSearch = new System.Windows.Forms.TextBox();
            this.gvStudents = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtStudentNameSearch = new System.Windows.Forms.TextBox();
            this.ddlClassSearch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.epStudentName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epClass = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAcademicYear = new System.Windows.Forms.ErrorProvider(this.components);
            this.epRollNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStudentName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAcademicYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRollNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name :";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(137, 41);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(224, 29);
            this.txtStudentName.TabIndex = 0;
            this.txtStudentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class :";
            // 
            // ddlClass
            // 
            this.ddlClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlClass.FormattingEnabled = true;
            this.ddlClass.Location = new System.Drawing.Point(457, 41);
            this.ddlClass.Name = "ddlClass";
            this.ddlClass.Size = new System.Drawing.Size(185, 29);
            this.ddlClass.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStudentID);
            this.groupBox1.Controls.Add(this.txtRollNumber);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rdoFemale);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAcademicYear);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAction);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.ddlClass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manual  Student Entry";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(325, 127);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(19, 21);
            this.lblStudentID.TabIndex = 18;
            this.lblStudentID.Text = "0";
            this.lblStudentID.Visible = false;
            // 
            // txtRollNumber
            // 
            this.txtRollNumber.Location = new System.Drawing.Point(137, 75);
            this.txtRollNumber.MaxLength = 4;
            this.txtRollNumber.Name = "txtRollNumber";
            this.txtRollNumber.Size = new System.Drawing.Size(224, 29);
            this.txtRollNumber.TabIndex = 3;
            this.txtRollNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRollNumber_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Roll Number :";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(549, 76);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(78, 25);
            this.rdoFemale.TabIndex = 5;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.Location = new System.Drawing.Point(469, 76);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(62, 25);
            this.rdoMale.TabIndex = 4;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Gender :";
            // 
            // txtAcademicYear
            // 
            this.txtAcademicYear.Location = new System.Drawing.Point(795, 41);
            this.txtAcademicYear.MaxLength = 4;
            this.txtAcademicYear.Name = "txtAcademicYear";
            this.txtAcademicYear.Size = new System.Drawing.Size(104, 29);
            this.txtAcademicYear.TabIndex = 2;
            this.txtAcademicYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcademicYear_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(672, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Academic Year :";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(137, 118);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(119, 30);
            this.btnAction.TabIndex = 6;
            this.btnAction.Text = "Save";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblExcelSample);
            this.groupBox2.Controls.Add(this.lblReading);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(925, 86);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excel Importer";
            // 
            // lblExcelSample
            // 
            this.lblExcelSample.AutoSize = true;
            this.lblExcelSample.Location = new System.Drawing.Point(398, 50);
            this.lblExcelSample.Name = "lblExcelSample";
            this.lblExcelSample.Size = new System.Drawing.Size(100, 21);
            this.lblExcelSample.TabIndex = 3;
            this.lblExcelSample.TabStop = true;
            this.lblExcelSample.Text = "View Sample";
            this.lblExcelSample.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExcelSample_LinkClicked);
            // 
            // lblReading
            // 
            this.lblReading.AutoSize = true;
            this.lblReading.Location = new System.Drawing.Point(378, 43);
            this.lblReading.Name = "lblReading";
            this.lblReading.Size = new System.Drawing.Size(0, 21);
            this.lblReading.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Import From Excel File :";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(221, 35);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(151, 36);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.TabStop = false;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAcademicYearSearch);
            this.groupBox3.Controls.Add(this.gvStudents);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.txtStudentNameSearch);
            this.groupBox3.Controls.Add(this.ddlClassSearch);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(925, 282);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student List";
            // 
            // txtAcademicYearSearch
            // 
            this.txtAcademicYearSearch.Location = new System.Drawing.Point(797, 28);
            this.txtAcademicYearSearch.MaxLength = 4;
            this.txtAcademicYearSearch.Name = "txtAcademicYearSearch";
            this.txtAcademicYearSearch.Size = new System.Drawing.Size(104, 29);
            this.txtAcademicYearSearch.TabIndex = 10;
            this.txtAcademicYearSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcademicYearSearch_KeyPress);
            // 
            // gvStudents
            // 
            this.gvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudents.Location = new System.Drawing.Point(8, 99);
            this.gvStudents.Name = "gvStudents";
            this.gvStudents.RowTemplate.Height = 24;
            this.gvStudents.Size = new System.Drawing.Size(911, 174);
            this.gvStudents.TabIndex = 12;
            this.gvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStudents_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(672, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Academic Year :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(127, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 30);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtStudentNameSearch
            // 
            this.txtStudentNameSearch.Location = new System.Drawing.Point(127, 28);
            this.txtStudentNameSearch.Name = "txtStudentNameSearch";
            this.txtStudentNameSearch.Size = new System.Drawing.Size(234, 29);
            this.txtStudentNameSearch.TabIndex = 8;
            this.txtStudentNameSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentNameSearch_KeyPress);
            // 
            // ddlClassSearch
            // 
            this.ddlClassSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlClassSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlClassSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlClassSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlClassSearch.FormattingEnabled = true;
            this.ddlClassSearch.Location = new System.Drawing.Point(455, 28);
            this.ddlClassSearch.Name = "ddlClassSearch";
            this.ddlClassSearch.Size = new System.Drawing.Size(185, 29);
            this.ddlClassSearch.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Student Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Class :";
            // 
            // epStudentName
            // 
            this.epStudentName.ContainerControl = this;
            // 
            // epClass
            // 
            this.epClass.ContainerControl = this;
            // 
            // epAcademicYear
            // 
            this.epAcademicYear.ContainerControl = this;
            // 
            // epRollNumber
            // 
            this.epRollNumber.ContainerControl = this;
            // 
            // frmStudent
            // 
            this.AcceptButton = this.btnAction;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(925, 524);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStudentName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAcademicYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRollNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtStudentNameSearch;
        private System.Windows.Forms.ComboBox ddlClassSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAcademicYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gvStudents;
        private System.Windows.Forms.ErrorProvider epStudentName;
        private System.Windows.Forms.ErrorProvider epClass;
        private System.Windows.Forms.ErrorProvider epAcademicYear;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRollNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider epRollNumber;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblReading;
        private System.Windows.Forms.TextBox txtAcademicYearSearch;
        private System.Windows.Forms.LinkLabel lblExcelSample;
    }
}