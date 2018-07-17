namespace NPSBS
{
    partial class frmResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResult));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerateResult = new System.Windows.Forms.Button();
            this.ddlClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlExamination = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAcademicYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.epAcademicYear = new System.Windows.Forms.ErrorProvider(this.components);
            this.epExamination = new System.Windows.Forms.ErrorProvider(this.components);
            this.epClass = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epAcademicYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epExamination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGenerateResult);
            this.panel1.Controls.Add(this.ddlClass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ddlExamination);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAcademicYear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 103);
            this.panel1.TabIndex = 0;
            // 
            // btnGenerateResult
            // 
            this.btnGenerateResult.Location = new System.Drawing.Point(489, 56);
            this.btnGenerateResult.Name = "btnGenerateResult";
            this.btnGenerateResult.Size = new System.Drawing.Size(111, 29);
            this.btnGenerateResult.TabIndex = 3;
            this.btnGenerateResult.Text = "Publish";
            this.btnGenerateResult.UseVisualStyleBackColor = true;
            this.btnGenerateResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // ddlClass
            // 
            this.ddlClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlClass.FormattingEnabled = true;
            this.ddlClass.Location = new System.Drawing.Point(155, 56);
            this.ddlClass.Name = "ddlClass";
            this.ddlClass.Size = new System.Drawing.Size(182, 28);
            this.ddlClass.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class :";
            // 
            // ddlExamination
            // 
            this.ddlExamination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlExamination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlExamination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlExamination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlExamination.FormattingEnabled = true;
            this.ddlExamination.Location = new System.Drawing.Point(489, 21);
            this.ddlExamination.Name = "ddlExamination";
            this.ddlExamination.Size = new System.Drawing.Size(301, 28);
            this.ddlExamination.TabIndex = 1;
            this.ddlExamination.SelectedIndexChanged += new System.EventHandler(this.ddlExamination_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Examination :";
            // 
            // txtAcademicYear
            // 
            this.txtAcademicYear.Location = new System.Drawing.Point(155, 18);
            this.txtAcademicYear.MaxLength = 4;
            this.txtAcademicYear.Name = "txtAcademicYear";
            this.txtAcademicYear.Size = new System.Drawing.Size(182, 26);
            this.txtAcademicYear.TabIndex = 0;
            this.txtAcademicYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcademicYear_KeyPress);
            this.txtAcademicYear.Leave += new System.EventHandler(this.txtAcademicYear_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Academic Year :";
            // 
            // epAcademicYear
            // 
            this.epAcademicYear.ContainerControl = this;
            // 
            // epExamination
            // 
            this.epExamination.ContainerControl = this;
            // 
            // epClass
            // 
            this.epClass.ContainerControl = this;
            // 
            // frmResult
            // 
            this.AcceptButton = this.btnGenerateResult;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(828, 104);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmResult";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.Load += new System.EventHandler(this.frmResult_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epAcademicYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epExamination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerateResult;
        private System.Windows.Forms.ComboBox ddlClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlExamination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAcademicYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ResultBindingSource;
        private System.Windows.Forms.ErrorProvider epAcademicYear;
        private System.Windows.Forms.ErrorProvider epExamination;
        private System.Windows.Forms.ErrorProvider epClass;
    }
}