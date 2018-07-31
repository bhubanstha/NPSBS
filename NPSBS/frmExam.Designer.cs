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
			this.pnlContainer = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
			this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
			this.dgvExam = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
			this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.txtYearSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
			this.lblExaminationId = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.btnAction = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.dpResultPrintDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
			this.ddlExam = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
			this.txtYear = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
			this.epExam = new System.Windows.Forms.ErrorProvider(this.components);
			this.epYear = new System.Windows.Forms.ErrorProvider(this.components);
			this.epPrintDate = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).BeginInit();
			this.pnlContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
			this.kryptonGroupBox2.Panel.SuspendLayout();
			this.kryptonGroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvExam)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
			this.kryptonGroupBox1.Panel.SuspendLayout();
			this.kryptonGroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ddlExam)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epExam)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epPrintDate)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlContainer
			// 
			this.pnlContainer.Controls.Add(this.kryptonGroupBox2);
			this.pnlContainer.Controls.Add(this.kryptonGroupBox1);
			this.pnlContainer.Controls.Add(this.kryptonPanel1);
			this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContainer.Location = new System.Drawing.Point(0, 0);
			this.pnlContainer.Name = "pnlContainer";
			this.pnlContainer.Size = new System.Drawing.Size(800, 450);
			this.pnlContainer.TabIndex = 0;
			// 
			// kryptonGroupBox2
			// 
			this.kryptonGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.kryptonGroupBox2.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonGroupBox2.Location = new System.Drawing.Point(0, 195);
			this.kryptonGroupBox2.Name = "kryptonGroupBox2";
			// 
			// kryptonGroupBox2.Panel
			// 
			this.kryptonGroupBox2.Panel.Controls.Add(this.dgvExam);
			this.kryptonGroupBox2.Panel.Controls.Add(this.btnSearch);
			this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel4);
			this.kryptonGroupBox2.Panel.Controls.Add(this.txtYearSearch);
			this.kryptonGroupBox2.Size = new System.Drawing.Size(800, 255);
			this.kryptonGroupBox2.TabIndex = 5;
			this.kryptonGroupBox2.Values.Heading = "Exam List";
			// 
			// dgvExam
			// 
			this.dgvExam.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvExam.Location = new System.Drawing.Point(0, 39);
			this.dgvExam.Name = "dgvExam";
			this.dgvExam.Size = new System.Drawing.Size(796, 194);
			this.dgvExam.TabIndex = 9;
			this.dgvExam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExam_CellClick);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(232, 8);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(90, 25);
			this.btnSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnSearch.StateCommon.Border.Rounding = 8;
			this.btnSearch.TabIndex = 8;
			this.btnSearch.Values.Text = "Search";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// kryptonLabel4
			// 
			this.kryptonLabel4.Location = new System.Drawing.Point(20, 11);
			this.kryptonLabel4.Name = "kryptonLabel4";
			this.kryptonLabel4.Size = new System.Drawing.Size(67, 20);
			this.kryptonLabel4.TabIndex = 7;
			this.kryptonLabel4.Values.Text = "Exam Year";
			// 
			// txtYearSearch
			// 
			this.txtYearSearch.Location = new System.Drawing.Point(86, 3);
			this.txtYearSearch.Name = "txtYearSearch";
			this.txtYearSearch.Size = new System.Drawing.Size(140, 33);
			this.txtYearSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txtYearSearch.StateCommon.Border.Rounding = 15;
			this.txtYearSearch.TabIndex = 6;
			this.txtYearSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearSearch_KeyPress);
			// 
			// kryptonGroupBox1
			// 
			this.kryptonGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.kryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
			this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 45);
			this.kryptonGroupBox1.Name = "kryptonGroupBox1";
			// 
			// kryptonGroupBox1.Panel
			// 
			this.kryptonGroupBox1.Panel.Controls.Add(this.lblExaminationId);
			this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
			this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
			this.kryptonGroupBox1.Panel.Controls.Add(this.btnAction);
			this.kryptonGroupBox1.Panel.Controls.Add(this.dpResultPrintDate);
			this.kryptonGroupBox1.Panel.Controls.Add(this.ddlExam);
			this.kryptonGroupBox1.Panel.Controls.Add(this.txtYear);
			this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
			this.kryptonGroupBox1.Size = new System.Drawing.Size(800, 150);
			this.kryptonGroupBox1.TabIndex = 4;
			this.kryptonGroupBox1.Values.Heading = "Exam Detail";
			// 
			// lblExaminationId
			// 
			this.lblExaminationId.Location = new System.Drawing.Point(278, 86);
			this.lblExaminationId.Name = "lblExaminationId";
			this.lblExaminationId.Size = new System.Drawing.Size(17, 20);
			this.lblExaminationId.TabIndex = 7;
			this.lblExaminationId.Values.Text = "0";
			this.lblExaminationId.Visible = false;
			// 
			// kryptonLabel3
			// 
			this.kryptonLabel3.Location = new System.Drawing.Point(254, 50);
			this.kryptonLabel3.Name = "kryptonLabel3";
			this.kryptonLabel3.Size = new System.Drawing.Size(119, 20);
			this.kryptonLabel3.TabIndex = 6;
			this.kryptonLabel3.Values.Text = "Result Printing Date";
			// 
			// kryptonLabel2
			// 
			this.kryptonLabel2.Location = new System.Drawing.Point(20, 50);
			this.kryptonLabel2.Name = "kryptonLabel2";
			this.kryptonLabel2.Size = new System.Drawing.Size(67, 20);
			this.kryptonLabel2.TabIndex = 5;
			this.kryptonLabel2.Values.Text = "Exam Year";
			// 
			// btnAction
			// 
			this.btnAction.Location = new System.Drawing.Point(86, 81);
			this.btnAction.Name = "btnAction";
			this.btnAction.Size = new System.Drawing.Size(90, 25);
			this.btnAction.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnAction.StateCommon.Border.Rounding = 8;
			this.btnAction.TabIndex = 4;
			this.btnAction.Values.Text = "Save";
			this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
			// 
			// dpResultPrintDate
			// 
			this.dpResultPrintDate.CalendarShowWeekNumbers = true;
			this.dpResultPrintDate.Location = new System.Drawing.Point(388, 44);
			this.dpResultPrintDate.Name = "dpResultPrintDate";
			this.dpResultPrintDate.Size = new System.Drawing.Size(331, 31);
			this.dpResultPrintDate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.dpResultPrintDate.StateCommon.Border.Rounding = 15;
			this.dpResultPrintDate.TabIndex = 3;
			// 
			// ddlExam
			// 
			this.ddlExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlExam.DropDownWidth = 623;
			this.ddlExam.Location = new System.Drawing.Point(86, 5);
			this.ddlExam.Name = "ddlExam";
			this.ddlExam.Size = new System.Drawing.Size(633, 31);
			this.ddlExam.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ddlExam.StateCommon.ComboBox.Border.Rounding = 15;
			this.ddlExam.TabIndex = 2;
			// 
			// txtYear
			// 
			this.txtYear.Location = new System.Drawing.Point(86, 42);
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(140, 33);
			this.txtYear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txtYear.StateCommon.Border.Rounding = 15;
			this.txtYear.TabIndex = 1;
			this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
			this.txtYear.Leave += new System.EventHandler(this.txtYear_Leave);
			// 
			// kryptonLabel1
			// 
			this.kryptonLabel1.Location = new System.Drawing.Point(20, 12);
			this.kryptonLabel1.Name = "kryptonLabel1";
			this.kryptonLabel1.Size = new System.Drawing.Size(39, 20);
			this.kryptonLabel1.TabIndex = 0;
			this.kryptonLabel1.Values.Text = "Exam";
			// 
			// kryptonPanel1
			// 
			this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
			this.kryptonPanel1.Name = "kryptonPanel1";
			this.kryptonPanel1.Size = new System.Drawing.Size(800, 45);
			this.kryptonPanel1.TabIndex = 0;
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
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnlContainer);
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "frmExam";
			this.Text = "Examination";
			((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).EndInit();
			this.pnlContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
			this.kryptonGroupBox2.Panel.ResumeLayout(false);
			this.kryptonGroupBox2.Panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
			this.kryptonGroupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvExam)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
			this.kryptonGroupBox1.Panel.ResumeLayout(false);
			this.kryptonGroupBox1.Panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
			this.kryptonGroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ddlExam)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epExam)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epPrintDate)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlContainer;
		private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
		private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel lblExaminationId;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnAction;
		private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dpResultPrintDate;
		private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlExam;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtYear;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
		private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
		private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvExam;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtYearSearch;
		private System.Windows.Forms.ErrorProvider epExam;
		private System.Windows.Forms.ErrorProvider epYear;
		private System.Windows.Forms.ErrorProvider epPrintDate;
	}
}