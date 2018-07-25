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
			this.epAcademicYear = new System.Windows.Forms.ErrorProvider(this.components);
			this.epExamination = new System.Windows.Forms.ErrorProvider(this.components);
			this.epClass = new System.Windows.Forms.ErrorProvider(this.components);
			this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
			this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
			this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.ddlClass = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
			this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.ddlExamination = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
			this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.txtAcademicYear = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			((System.ComponentModel.ISupportInitialize)(this.epAcademicYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epExamination)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epClass)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
			this.kryptonPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ddlClass)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ddlExamination)).BeginInit();
			this.SuspendLayout();
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
			// kryptonPanel1
			// 
			this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
			this.kryptonPanel1.Name = "kryptonPanel1";
			this.kryptonPanel1.Size = new System.Drawing.Size(828, 45);
			this.kryptonPanel1.TabIndex = 1;
			// 
			// kryptonPanel2
			// 
			this.kryptonPanel2.Controls.Add(this.kryptonButton1);
			this.kryptonPanel2.Controls.Add(this.ddlClass);
			this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
			this.kryptonPanel2.Controls.Add(this.ddlExamination);
			this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
			this.kryptonPanel2.Controls.Add(this.txtAcademicYear);
			this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
			this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonPanel2.Location = new System.Drawing.Point(0, 45);
			this.kryptonPanel2.Name = "kryptonPanel2";
			this.kryptonPanel2.Size = new System.Drawing.Size(828, 94);
			this.kryptonPanel2.TabIndex = 2;
			// 
			// kryptonButton1
			// 
			this.kryptonButton1.Location = new System.Drawing.Point(332, 49);
			this.kryptonButton1.Name = "kryptonButton1";
			this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
			this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonButton1.StateCommon.Border.Rounding = 8;
			this.kryptonButton1.TabIndex = 6;
			this.kryptonButton1.Values.Text = "Publish";
			this.kryptonButton1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ddlClass
			// 
			this.ddlClass.DropDownWidth = 259;
			this.ddlClass.Location = new System.Drawing.Point(110, 41);
			this.ddlClass.Name = "ddlClass";
			this.ddlClass.Size = new System.Drawing.Size(181, 31);
			this.ddlClass.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ddlClass.StateCommon.ComboBox.Border.Rounding = 15;
			this.ddlClass.TabIndex = 5;
			// 
			// kryptonLabel3
			// 
			this.kryptonLabel3.Location = new System.Drawing.Point(13, 49);
			this.kryptonLabel3.Name = "kryptonLabel3";
			this.kryptonLabel3.Size = new System.Drawing.Size(38, 20);
			this.kryptonLabel3.TabIndex = 4;
			this.kryptonLabel3.Values.Text = "Class";
			// 
			// ddlExamination
			// 
			this.ddlExamination.DropDownWidth = 259;
			this.ddlExamination.Location = new System.Drawing.Point(429, 4);
			this.ddlExamination.Name = "ddlExamination";
			this.ddlExamination.Size = new System.Drawing.Size(269, 31);
			this.ddlExamination.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ddlExamination.StateCommon.ComboBox.Border.Rounding = 15;
			this.ddlExamination.TabIndex = 3;
			this.ddlExamination.SelectedIndexChanged += new System.EventHandler(this.ddlExamination_SelectedIndexChanged);
			// 
			// kryptonLabel2
			// 
			this.kryptonLabel2.Location = new System.Drawing.Point(332, 12);
			this.kryptonLabel2.Name = "kryptonLabel2";
			this.kryptonLabel2.Size = new System.Drawing.Size(77, 20);
			this.kryptonLabel2.TabIndex = 2;
			this.kryptonLabel2.Values.Text = "Examination";
			// 
			// txtAcademicYear
			// 
			this.txtAcademicYear.Location = new System.Drawing.Point(110, 3);
			this.txtAcademicYear.Name = "txtAcademicYear";
			this.txtAcademicYear.Size = new System.Drawing.Size(181, 33);
			this.txtAcademicYear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txtAcademicYear.StateCommon.Border.Rounding = 15;
			this.txtAcademicYear.TabIndex = 1;
			this.txtAcademicYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcademicYear_KeyPress);
			this.txtAcademicYear.Leave += new System.EventHandler(this.txtAcademicYear_Leave);
			// 
			// kryptonLabel1
			// 
			this.kryptonLabel1.Location = new System.Drawing.Point(13, 7);
			this.kryptonLabel1.Name = "kryptonLabel1";
			this.kryptonLabel1.Size = new System.Drawing.Size(91, 20);
			this.kryptonLabel1.TabIndex = 0;
			this.kryptonLabel1.Values.Text = "Academic Year";
			// 
			// frmResult
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(828, 139);
			this.Controls.Add(this.kryptonPanel2);
			this.Controls.Add(this.kryptonPanel1);
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
			((System.ComponentModel.ISupportInitialize)(this.epAcademicYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epExamination)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epClass)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
			this.kryptonPanel2.ResumeLayout(false);
			this.kryptonPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ddlClass)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ddlExamination)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ResultBindingSource;
        private System.Windows.Forms.ErrorProvider epAcademicYear;
        private System.Windows.Forms.ErrorProvider epExamination;
        private System.Windows.Forms.ErrorProvider epClass;
		private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
		private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlClass;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
		private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlExamination;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAcademicYear;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
		private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
	}
}