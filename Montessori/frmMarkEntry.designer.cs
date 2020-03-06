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
            this.epYear = new System.Windows.Forms.ErrorProvider(this.components);
            this.epExam = new System.Windows.Forms.ErrorProvider(this.components);
            this.epClass = new System.Windows.Forms.ErrorProvider(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgvMarkEntry = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnSubmitMarks = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ddlSubject = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblYear = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ddlClass = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnLoadStudent = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ddlExam = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtYear = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.epYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.SuspendLayout();
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
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(812, 452);
            this.kryptonPanel1.TabIndex = 12;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(0, 188);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.dgvMarkEntry);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonPanel3);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(812, 264);
            this.kryptonGroupBox2.TabIndex = 2;
            this.kryptonGroupBox2.Values.Heading = "Student List";
            // 
            // dgvMarkEntry
            // 
            this.dgvMarkEntry.AllowUserToAddRows = false;
            this.dgvMarkEntry.AllowUserToDeleteRows = false;
            this.dgvMarkEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMarkEntry.Location = new System.Drawing.Point(0, 0);
            this.dgvMarkEntry.Name = "dgvMarkEntry";
            this.dgvMarkEntry.ReadOnly = true;
            this.dgvMarkEntry.Size = new System.Drawing.Size(808, 192);
            this.dgvMarkEntry.TabIndex = 12;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.btnSubmitMarks);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 192);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(808, 48);
            this.kryptonPanel3.TabIndex = 0;
            // 
            // btnSubmitMarks
            // 
            this.btnSubmitMarks.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSubmitMarks.Location = new System.Drawing.Point(649, 4);
            this.btnSubmitMarks.Name = "btnSubmitMarks";
            this.btnSubmitMarks.Size = new System.Drawing.Size(154, 35);
            this.btnSubmitMarks.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSubmitMarks.StateCommon.Border.Rounding = 15;
            this.btnSubmitMarks.TabIndex = 4;
            this.btnSubmitMarks.Values.Text = "Submit Marks";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 50);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ddlSubject);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblYear);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ddlClass);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnLoadStudent);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ddlExam);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtYear);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(812, 138);
            this.kryptonGroupBox1.TabIndex = 1;
            this.kryptonGroupBox1.Values.Heading = "Exam Detail";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel4.Location = new System.Drawing.Point(374, 41);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(51, 20);
            this.kryptonLabel4.TabIndex = 8;
            this.kryptonLabel4.Values.Text = "Subject";
            // 
            // ddlSubject
            // 
            this.ddlSubject.DropDownWidth = 276;
            this.ddlSubject.Location = new System.Drawing.Point(447, 36);
            this.ddlSubject.Name = "ddlSubject";
            this.ddlSubject.Size = new System.Drawing.Size(286, 31);
            this.ddlSubject.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ddlSubject.StateCommon.ComboBox.Border.Rounding = 15;
            this.ddlSubject.TabIndex = 7;
            this.ddlSubject.SelectedIndexChanged += new System.EventHandler(this.ddlSubject_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.lblYear.Location = new System.Drawing.Point(10, 36);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(38, 20);
            this.lblYear.TabIndex = 6;
            this.lblYear.Values.Text = "Class";
            // 
            // ddlClass
            // 
            this.ddlClass.DropDownWidth = 276;
            this.ddlClass.Location = new System.Drawing.Point(97, 36);
            this.ddlClass.Name = "ddlClass";
            this.ddlClass.Size = new System.Drawing.Size(237, 31);
            this.ddlClass.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ddlClass.StateCommon.ComboBox.Border.Rounding = 15;
            this.ddlClass.TabIndex = 5;
            this.ddlClass.SelectedIndexChanged += new System.EventHandler(this.ddlClass_SelectedIndexChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(374, 8);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Exam";
            // 
            // btnLoadStudent
            // 
            this.btnLoadStudent.Location = new System.Drawing.Point(97, 73);
            this.btnLoadStudent.Name = "btnLoadStudent";
            this.btnLoadStudent.Size = new System.Drawing.Size(237, 35);
            this.btnLoadStudent.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLoadStudent.StateCommon.Border.Rounding = 15;
            this.btnLoadStudent.TabIndex = 3;
            this.btnLoadStudent.Values.Text = "Load Students";
            this.btnLoadStudent.Click += new System.EventHandler(this.btnLoadStudent_Click);
            // 
            // ddlExam
            // 
            this.ddlExam.DropDownWidth = 276;
            this.ddlExam.Location = new System.Drawing.Point(447, 3);
            this.ddlExam.Name = "ddlExam";
            this.ddlExam.Size = new System.Drawing.Size(286, 31);
            this.ddlExam.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ddlExam.StateCommon.ComboBox.Border.Rounding = 15;
            this.ddlExam.TabIndex = 2;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(97, 3);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(237, 33);
            this.txtYear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtYear.StateCommon.Border.Rounding = 15;
            this.txtYear.TabIndex = 1;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            this.txtYear.Leave += new System.EventHandler(this.txtYear_Leave);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(10, 9);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(67, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Exam Year";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(812, 50);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // frmMarkEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(100, 0);
            this.ClientSize = new System.Drawing.Size(812, 452);
            this.Controls.Add(this.kryptonPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMarkEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Marks Entry";
            this.Load += new System.EventHandler(this.frmMarkEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddlSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider epYear;
        private System.Windows.Forms.ErrorProvider epExam;
        private System.Windows.Forms.ErrorProvider epClass;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlSubject;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblYear;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlClass;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLoadStudent;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlExam;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtYear;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvMarkEntry;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubmitMarks;
    }
}