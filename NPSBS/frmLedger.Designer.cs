namespace NPSBS
{
    partial class frmLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLedger));
            this.btnLedger = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ddlClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlExamination = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAcademicYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.epAcademicYear = new System.Windows.Forms.ErrorProvider(this.components);
            this.epClass = new System.Windows.Forms.ErrorProvider(this.components);
            this.epExamination = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epAcademicYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epExamination)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLedger
            // 
            this.btnLedger.Location = new System.Drawing.Point(465, 72);
            this.btnLedger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLedger.Name = "btnLedger";
            this.btnLedger.Size = new System.Drawing.Size(127, 33);
            this.btnLedger.TabIndex = 3;
            this.btnLedger.Text = "Get Ledger";
            this.btnLedger.UseVisualStyleBackColor = true;
            this.btnLedger.Click += new System.EventHandler(this.btnLedger_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ddlClass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ddlExamination);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAcademicYear);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLedger);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(771, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exam Details";
            // 
            // ddlClass
            // 
            this.ddlClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlClass.FormattingEnabled = true;
            this.ddlClass.Location = new System.Drawing.Point(171, 69);
            this.ddlClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlClass.Name = "ddlClass";
            this.ddlClass.Size = new System.Drawing.Size(152, 28);
            this.ddlClass.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Class :";
            // 
            // ddlExamination
            // 
            this.ddlExamination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlExamination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlExamination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlExamination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlExamination.FormattingEnabled = true;
            this.ddlExamination.Location = new System.Drawing.Point(465, 34);
            this.ddlExamination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlExamination.Name = "ddlExamination";
            this.ddlExamination.Size = new System.Drawing.Size(286, 28);
            this.ddlExamination.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Examination :";
            // 
            // txtAcademicYear
            // 
            this.txtAcademicYear.Location = new System.Drawing.Point(171, 34);
            this.txtAcademicYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAcademicYear.MaxLength = 4;
            this.txtAcademicYear.Name = "txtAcademicYear";
            this.txtAcademicYear.Size = new System.Drawing.Size(152, 26);
            this.txtAcademicYear.TabIndex = 0;
            this.txtAcademicYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcademicYear_KeyPress);
            this.txtAcademicYear.Leave += new System.EventHandler(this.txtAcademicYear_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Academic Year :";
            // 
            // epAcademicYear
            // 
            this.epAcademicYear.ContainerControl = this;
            // 
            // epClass
            // 
            this.epClass.ContainerControl = this;
            // 
            // epExamination
            // 
            this.epExamination.ContainerControl = this;
            // 
            // frmLedger
            // 
            this.AcceptButton = this.btnLedger;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(771, 124);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLedger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marks Ledger";
            this.Load += new System.EventHandler(this.frmLedger_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epAcademicYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epExamination)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLedger;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ddlClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlExamination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAcademicYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider epAcademicYear;
        private System.Windows.Forms.ErrorProvider epClass;
        private System.Windows.Forms.ErrorProvider epExamination;
    }
}