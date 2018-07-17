namespace NPSBS
{
    partial class frmExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExam));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblExaminationId = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.dpResultPrintDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlExam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtYearSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvExam = new System.Windows.Forms.DataGridView();
            this.epExam = new System.Windows.Forms.ErrorProvider(this.components);
            this.epYear = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrintDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrintDate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblExaminationId);
            this.groupBox1.Controls.Add(this.btnAction);
            this.groupBox1.Controls.Add(this.dpResultPrintDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ddlExam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exam Detail";
            // 
            // lblExaminationId
            // 
            this.lblExaminationId.AutoSize = true;
            this.lblExaminationId.Location = new System.Drawing.Point(276, 114);
            this.lblExaminationId.Name = "lblExaminationId";
            this.lblExaminationId.Size = new System.Drawing.Size(18, 20);
            this.lblExaminationId.TabIndex = 5;
            this.lblExaminationId.Text = "0";
            this.lblExaminationId.Visible = false;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(127, 106);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(116, 37);
            this.btnAction.TabIndex = 3;
            this.btnAction.Text = "Save";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // dpResultPrintDate
            // 
            this.dpResultPrintDate.Location = new System.Drawing.Point(441, 74);
            this.dpResultPrintDate.Name = "dpResultPrintDate";
            this.dpResultPrintDate.Size = new System.Drawing.Size(280, 26);
            this.dpResultPrintDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result Printing Date :";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(127, 74);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(116, 26);
            this.txtYear.TabIndex = 1;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            this.txtYear.Leave += new System.EventHandler(this.txtYear_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Exam Year :";
            // 
            // ddlExam
            // 
            this.ddlExam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlExam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlExam.FormattingEnabled = true;
            this.ddlExam.Location = new System.Drawing.Point(127, 33);
            this.ddlExam.Name = "ddlExam";
            this.ddlExam.Size = new System.Drawing.Size(594, 28);
            this.ddlExam.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exam :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtYearSearch);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dgvExam);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 260);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exam List";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(263, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 28);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtYearSearch
            // 
            this.txtYearSearch.Location = new System.Drawing.Point(127, 25);
            this.txtYearSearch.MaxLength = 4;
            this.txtYearSearch.Name = "txtYearSearch";
            this.txtYearSearch.Size = new System.Drawing.Size(116, 26);
            this.txtYearSearch.TabIndex = 3;
            this.txtYearSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearSearch_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Exam Year :";
            // 
            // dgvExam
            // 
            this.dgvExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExam.Location = new System.Drawing.Point(12, 59);
            this.dgvExam.Name = "dgvExam";
            this.dgvExam.Size = new System.Drawing.Size(743, 189);
            this.dgvExam.TabIndex = 0;
            this.dgvExam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExam_CellClick);
            // 
            // epExam
            // 
            this.epExam.ContainerControl = this;
            // 
            // epYear
            // 
            this.epYear.ContainerControl = this;
            // 
            // epPrintDate
            // 
            this.epPrintDate.ContainerControl = this;
            // 
            // frmExam
            // 
            this.AcceptButton = this.btnAction;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(767, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Examination";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrintDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.DateTimePicker dpResultPrintDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlExam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtYearSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvExam;
        private System.Windows.Forms.ErrorProvider epExam;
        private System.Windows.Forms.ErrorProvider epYear;
        private System.Windows.Forms.ErrorProvider epPrintDate;
        private System.Windows.Forms.Label lblExaminationId;
    }
}