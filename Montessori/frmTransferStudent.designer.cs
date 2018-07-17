namespace Montessori
{
    partial class frmTransferStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransferStudent));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetStudent = new System.Windows.Forms.Button();
            this.txtOldAcademicYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlOldClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.ddlNewClass = new System.Windows.Forms.ComboBox();
            this.txtNewAcademicYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gvTranferStudent = new System.Windows.Forms.DataGridView();
            this.epClass = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAcademicYear = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTranferStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAcademicYear)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetStudent);
            this.groupBox1.Controls.Add(this.txtOldAcademicYear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ddlOldClass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(928, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Old Class";
            // 
            // btnGetStudent
            // 
            this.btnGetStudent.Location = new System.Drawing.Point(720, 27);
            this.btnGetStudent.Name = "btnGetStudent";
            this.btnGetStudent.Size = new System.Drawing.Size(103, 30);
            this.btnGetStudent.TabIndex = 4;
            this.btnGetStudent.Text = "Get Student";
            this.btnGetStudent.UseVisualStyleBackColor = true;
            this.btnGetStudent.Click += new System.EventHandler(this.btnGetStudent_Click);
            // 
            // txtOldAcademicYear
            // 
            this.txtOldAcademicYear.Location = new System.Drawing.Point(551, 28);
            this.txtOldAcademicYear.MaxLength = 4;
            this.txtOldAcademicYear.Name = "txtOldAcademicYear";
            this.txtOldAcademicYear.Size = new System.Drawing.Size(150, 29);
            this.txtOldAcademicYear.TabIndex = 3;
            this.txtOldAcademicYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOldAcademicYear_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Academic Year :";
            // 
            // ddlOldClass
            // 
            this.ddlOldClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlOldClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlOldClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlOldClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlOldClass.FormattingEnabled = true;
            this.ddlOldClass.Location = new System.Drawing.Point(165, 27);
            this.ddlOldClass.Name = "ddlOldClass";
            this.ddlOldClass.Size = new System.Drawing.Size(215, 29);
            this.ddlOldClass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTransfer);
            this.groupBox2.Controls.Add(this.ddlNewClass);
            this.groupBox2.Controls.Add(this.txtNewAcademicYear);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 85);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(928, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Class";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Enabled = false;
            this.btnTransfer.Location = new System.Drawing.Point(720, 25);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(103, 30);
            this.btnTransfer.TabIndex = 9;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // ddlNewClass
            // 
            this.ddlNewClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlNewClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlNewClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlNewClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlNewClass.FormattingEnabled = true;
            this.ddlNewClass.Location = new System.Drawing.Point(165, 25);
            this.ddlNewClass.Name = "ddlNewClass";
            this.ddlNewClass.Size = new System.Drawing.Size(215, 29);
            this.ddlNewClass.TabIndex = 6;
            // 
            // txtNewAcademicYear
            // 
            this.txtNewAcademicYear.Location = new System.Drawing.Point(551, 26);
            this.txtNewAcademicYear.MaxLength = 4;
            this.txtNewAcademicYear.Name = "txtNewAcademicYear";
            this.txtNewAcademicYear.Size = new System.Drawing.Size(150, 29);
            this.txtNewAcademicYear.TabIndex = 8;
            this.txtNewAcademicYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewAcademicYear_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Class :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Academic Year :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gvTranferStudent);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 166);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(928, 220);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Class Student";
            // 
            // gvTranferStudent
            // 
            this.gvTranferStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvTranferStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTranferStudent.Location = new System.Drawing.Point(7, 24);
            this.gvTranferStudent.Name = "gvTranferStudent";
            this.gvTranferStudent.RowTemplate.Height = 24;
            this.gvTranferStudent.Size = new System.Drawing.Size(914, 191);
            this.gvTranferStudent.TabIndex = 0;
            // 
            // epClass
            // 
            this.epClass.ContainerControl = this;
            // 
            // epAcademicYear
            // 
            this.epAcademicYear.ContainerControl = this;
            // 
            // frmTransferStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(928, 386);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTransferStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transfer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvTranferStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAcademicYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetStudent;
        private System.Windows.Forms.TextBox txtOldAcademicYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlOldClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.ComboBox ddlNewClass;
        private System.Windows.Forms.TextBox txtNewAcademicYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ErrorProvider epClass;
        private System.Windows.Forms.ErrorProvider epAcademicYear;
        private System.Windows.Forms.DataGridView gvTranferStudent;
    }
}