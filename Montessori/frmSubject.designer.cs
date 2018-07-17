namespace Montessori
{
    partial class frmSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubject));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSubjectID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ddlClassSearch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gvSubjects = new System.Windows.Forms.DataGridView();
            this.epClass = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSubject = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTheory = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPractical = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTheory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPractical)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSubjectID);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtSubject);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ddlClass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject Entry";
            // 
            // lblSubjectID
            // 
            this.lblSubjectID.AutoSize = true;
            this.lblSubjectID.Location = new System.Drawing.Point(311, 116);
            this.lblSubjectID.Name = "lblSubjectID";
            this.lblSubjectID.Size = new System.Drawing.Size(19, 21);
            this.lblSubjectID.TabIndex = 9;
            this.lblSubjectID.Text = "0";
            this.lblSubjectID.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(133, 70);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 32);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(524, 35);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(317, 29);
            this.txtSubject.TabIndex = 3;
            this.txtSubject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubject_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject :";
            // 
            // ddlClass
            // 
            this.ddlClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlClass.FormattingEnabled = true;
            this.ddlClass.Location = new System.Drawing.Point(133, 35);
            this.ddlClass.Name = "ddlClass";
            this.ddlClass.Size = new System.Drawing.Size(214, 29);
            this.ddlClass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ddlClassSearch);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.gvSubjects);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(853, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Subject Information";
            // 
            // ddlClassSearch
            // 
            this.ddlClassSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlClassSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlClassSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlClassSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlClassSearch.FormattingEnabled = true;
            this.ddlClassSearch.Location = new System.Drawing.Point(133, 22);
            this.ddlClassSearch.Name = "ddlClassSearch";
            this.ddlClassSearch.Size = new System.Drawing.Size(214, 29);
            this.ddlClassSearch.TabIndex = 3;
            this.ddlClassSearch.SelectedIndexChanged += new System.EventHandler(this.ddlClassSearch_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Class :";
            // 
            // gvSubjects
            // 
            this.gvSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSubjects.Location = new System.Drawing.Point(6, 57);
            this.gvSubjects.Name = "gvSubjects";
            this.gvSubjects.RowTemplate.Height = 24;
            this.gvSubjects.Size = new System.Drawing.Size(841, 179);
            this.gvSubjects.TabIndex = 0;
            this.gvSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSubjects_CellContentClick);
            // 
            // epClass
            // 
            this.epClass.ContainerControl = this;
            // 
            // epSubject
            // 
            this.epSubject.ContainerControl = this;
            // 
            // epTheory
            // 
            this.epTheory.ContainerControl = this;
            // 
            // epPractical
            // 
            this.epPractical.ContainerControl = this;
            // 
            // frmSubject
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(853, 358);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.frmSubject_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTheory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPractical)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider epClass;
        private System.Windows.Forms.ErrorProvider epSubject;
        private System.Windows.Forms.ErrorProvider epTheory;
        private System.Windows.Forms.ErrorProvider epPractical;
        private System.Windows.Forms.ComboBox ddlClassSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvSubjects;
        private System.Windows.Forms.Label lblSubjectID;
    }
}