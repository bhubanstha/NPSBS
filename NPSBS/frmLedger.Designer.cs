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
			this.epAcademicYear = new System.Windows.Forms.ErrorProvider(this.components);
			this.epClass = new System.Windows.Forms.ErrorProvider(this.components);
			this.epExamination = new System.Windows.Forms.ErrorProvider(this.components);
			this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
			this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
			this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.txtAcademicYear = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.ddlExamination = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
			this.btnGetLedger = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.ddlClass = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
			this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			((System.ComponentModel.ISupportInitialize)(this.epAcademicYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epClass)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epExamination)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
			this.kryptonGroupBox1.Panel.SuspendLayout();
			this.kryptonGroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ddlExamination)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ddlClass)).BeginInit();
			this.SuspendLayout();
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
			// kryptonPanel1
			// 
			this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
			this.kryptonPanel1.Name = "kryptonPanel1";
			this.kryptonPanel1.Size = new System.Drawing.Size(771, 45);
			this.kryptonPanel1.TabIndex = 2;
			// 
			// kryptonGroupBox1
			// 
			this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 45);
			this.kryptonGroupBox1.Name = "kryptonGroupBox1";
			// 
			// kryptonGroupBox1.Panel
			// 
			this.kryptonGroupBox1.Panel.Controls.Add(this.ddlClass);
			this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
			this.kryptonGroupBox1.Panel.Controls.Add(this.btnGetLedger);
			this.kryptonGroupBox1.Panel.Controls.Add(this.ddlExamination);
			this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
			this.kryptonGroupBox1.Panel.Controls.Add(this.txtAcademicYear);
			this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
			this.kryptonGroupBox1.Size = new System.Drawing.Size(771, 132);
			this.kryptonGroupBox1.TabIndex = 3;
			this.kryptonGroupBox1.Values.Heading = "Exam Details";
			// 
			// kryptonLabel1
			// 
			this.kryptonLabel1.Location = new System.Drawing.Point(10, 23);
			this.kryptonLabel1.Name = "kryptonLabel1";
			this.kryptonLabel1.Size = new System.Drawing.Size(91, 20);
			this.kryptonLabel1.TabIndex = 0;
			this.kryptonLabel1.Values.Text = "Academic Year";
			// 
			// txtAcademicYear
			// 
			this.txtAcademicYear.Location = new System.Drawing.Point(107, 18);
			this.txtAcademicYear.Name = "txtAcademicYear";
			this.txtAcademicYear.Size = new System.Drawing.Size(182, 33);
			this.txtAcademicYear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txtAcademicYear.StateCommon.Border.Rounding = 15;
			this.txtAcademicYear.TabIndex = 1;
			this.txtAcademicYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcademicYear_KeyPress);
			this.txtAcademicYear.Leave += new System.EventHandler(this.txtAcademicYear_Leave);
			// 
			// kryptonLabel2
			// 
			this.kryptonLabel2.Location = new System.Drawing.Point(338, 23);
			this.kryptonLabel2.Name = "kryptonLabel2";
			this.kryptonLabel2.Size = new System.Drawing.Size(77, 20);
			this.kryptonLabel2.TabIndex = 2;
			this.kryptonLabel2.Values.Text = "Examination";
			// 
			// ddlExamination
			// 
			this.ddlExamination.DropDownWidth = 289;
			this.ddlExamination.Location = new System.Drawing.Point(421, 18);
			this.ddlExamination.Name = "ddlExamination";
			this.ddlExamination.Size = new System.Drawing.Size(299, 31);
			this.ddlExamination.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ddlExamination.StateCommon.ComboBox.Border.Rounding = 15;
			this.ddlExamination.TabIndex = 3;
			// 
			// btnGetLedger
			// 
			this.btnGetLedger.Location = new System.Drawing.Point(421, 62);
			this.btnGetLedger.Name = "btnGetLedger";
			this.btnGetLedger.Size = new System.Drawing.Size(163, 25);
			this.btnGetLedger.TabIndex = 4;
			this.btnGetLedger.Values.Text = "Get Ledger";
			this.btnGetLedger.Click += new System.EventHandler(this.btnLedger_Click);
			// 
			// ddlClass
			// 
			this.ddlClass.DropDownWidth = 289;
			this.ddlClass.Location = new System.Drawing.Point(107, 57);
			this.ddlClass.Name = "ddlClass";
			this.ddlClass.Size = new System.Drawing.Size(182, 31);
			this.ddlClass.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ddlClass.StateCommon.ComboBox.Border.Rounding = 15;
			this.ddlClass.TabIndex = 6;
			// 
			// kryptonLabel3
			// 
			this.kryptonLabel3.Location = new System.Drawing.Point(11, 62);
			this.kryptonLabel3.Name = "kryptonLabel3";
			this.kryptonLabel3.Size = new System.Drawing.Size(38, 20);
			this.kryptonLabel3.TabIndex = 5;
			this.kryptonLabel3.Values.Text = "Class";
			// 
			// frmLedger
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(771, 177);
			this.Controls.Add(this.kryptonGroupBox1);
			this.Controls.Add(this.kryptonPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmLedger";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Marks Ledger";
			this.Load += new System.EventHandler(this.frmLedger_Load);
			((System.ComponentModel.ISupportInitialize)(this.epAcademicYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epClass)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epExamination)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
			this.kryptonGroupBox1.Panel.ResumeLayout(false);
			this.kryptonGroupBox1.Panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
			this.kryptonGroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ddlExamination)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ddlClass)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider epAcademicYear;
        private System.Windows.Forms.ErrorProvider epClass;
        private System.Windows.Forms.ErrorProvider epExamination;
		private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
		private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlClass;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnGetLedger;
		private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlExamination;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAcademicYear;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
		private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
	}
}