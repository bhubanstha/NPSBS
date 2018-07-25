namespace NPSBS
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
			this.epClass = new System.Windows.Forms.ErrorProvider(this.components);
			this.epAcademicYear = new System.Windows.Forms.ErrorProvider(this.components);
			this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
			this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
			this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.ddlOldClass = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
			this.txtOldAcademicYear = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.btnGetStudent = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
			this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.btnTransfer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.txtNewAcademicYear = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.ddlNewClass = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
			this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.kryptonGroupBox3 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
			this.gvTranferStudent = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
			((System.ComponentModel.ISupportInitialize)(this.epClass)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epAcademicYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
			this.kryptonGroupBox1.Panel.SuspendLayout();
			this.kryptonGroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ddlOldClass)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
			this.kryptonGroupBox2.Panel.SuspendLayout();
			this.kryptonGroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ddlNewClass)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).BeginInit();
			this.kryptonGroupBox3.Panel.SuspendLayout();
			this.kryptonGroupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvTranferStudent)).BeginInit();
			this.SuspendLayout();
			// 
			// epClass
			// 
			this.epClass.ContainerControl = this;
			// 
			// epAcademicYear
			// 
			this.epAcademicYear.ContainerControl = this;
			// 
			// kryptonPanel1
			// 
			this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
			this.kryptonPanel1.Name = "kryptonPanel1";
			this.kryptonPanel1.Size = new System.Drawing.Size(949, 45);
			this.kryptonPanel1.TabIndex = 3;
			// 
			// kryptonGroupBox1
			// 
			this.kryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 45);
			this.kryptonGroupBox1.Name = "kryptonGroupBox1";
			// 
			// kryptonGroupBox1.Panel
			// 
			this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
			this.kryptonGroupBox1.Panel.Controls.Add(this.btnGetStudent);
			this.kryptonGroupBox1.Panel.Controls.Add(this.txtOldAcademicYear);
			this.kryptonGroupBox1.Panel.Controls.Add(this.ddlOldClass);
			this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
			this.kryptonGroupBox1.Size = new System.Drawing.Size(949, 79);
			this.kryptonGroupBox1.TabIndex = 4;
			this.kryptonGroupBox1.Values.Heading = "Old Class";
			// 
			// kryptonLabel1
			// 
			this.kryptonLabel1.Location = new System.Drawing.Point(22, 16);
			this.kryptonLabel1.Name = "kryptonLabel1";
			this.kryptonLabel1.Size = new System.Drawing.Size(38, 20);
			this.kryptonLabel1.TabIndex = 0;
			this.kryptonLabel1.Values.Text = "Class";
			// 
			// ddlOldClass
			// 
			this.ddlOldClass.DropDownWidth = 193;
			this.ddlOldClass.Location = new System.Drawing.Point(66, 10);
			this.ddlOldClass.Name = "ddlOldClass";
			this.ddlOldClass.Size = new System.Drawing.Size(203, 31);
			this.ddlOldClass.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ddlOldClass.StateCommon.ComboBox.Border.Rounding = 15;
			this.ddlOldClass.TabIndex = 1;
			// 
			// txtOldAcademicYear
			// 
			this.txtOldAcademicYear.Location = new System.Drawing.Point(450, 10);
			this.txtOldAcademicYear.Name = "txtOldAcademicYear";
			this.txtOldAcademicYear.Size = new System.Drawing.Size(212, 33);
			this.txtOldAcademicYear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txtOldAcademicYear.StateCommon.Border.Rounding = 15;
			this.txtOldAcademicYear.TabIndex = 2;
			this.txtOldAcademicYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOldAcademicYear_KeyPress);
			// 
			// btnGetStudent
			// 
			this.btnGetStudent.Location = new System.Drawing.Point(678, 16);
			this.btnGetStudent.Name = "btnGetStudent";
			this.btnGetStudent.Size = new System.Drawing.Size(90, 25);
			this.btnGetStudent.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnGetStudent.StateCommon.Border.Rounding = 15;
			this.btnGetStudent.TabIndex = 3;
			this.btnGetStudent.Values.Text = "Get Student";
			this.btnGetStudent.Click += new System.EventHandler(this.btnGetStudent_Click);
			// 
			// kryptonLabel2
			// 
			this.kryptonLabel2.Location = new System.Drawing.Point(353, 16);
			this.kryptonLabel2.Name = "kryptonLabel2";
			this.kryptonLabel2.Size = new System.Drawing.Size(91, 20);
			this.kryptonLabel2.TabIndex = 4;
			this.kryptonLabel2.Values.Text = "Academic Year";
			// 
			// kryptonGroupBox2
			// 
			this.kryptonGroupBox2.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.kryptonGroupBox2.Location = new System.Drawing.Point(0, 124);
			this.kryptonGroupBox2.Name = "kryptonGroupBox2";
			// 
			// kryptonGroupBox2.Panel
			// 
			this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel3);
			this.kryptonGroupBox2.Panel.Controls.Add(this.btnTransfer);
			this.kryptonGroupBox2.Panel.Controls.Add(this.txtNewAcademicYear);
			this.kryptonGroupBox2.Panel.Controls.Add(this.ddlNewClass);
			this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel4);
			this.kryptonGroupBox2.Size = new System.Drawing.Size(949, 79);
			this.kryptonGroupBox2.TabIndex = 5;
			this.kryptonGroupBox2.Values.Heading = "New Class";
			// 
			// kryptonLabel3
			// 
			this.kryptonLabel3.Location = new System.Drawing.Point(353, 16);
			this.kryptonLabel3.Name = "kryptonLabel3";
			this.kryptonLabel3.Size = new System.Drawing.Size(91, 20);
			this.kryptonLabel3.TabIndex = 4;
			this.kryptonLabel3.Values.Text = "Academic Year";
			// 
			// btnTransfer
			// 
			this.btnTransfer.Location = new System.Drawing.Point(678, 16);
			this.btnTransfer.Name = "btnTransfer";
			this.btnTransfer.Size = new System.Drawing.Size(90, 25);
			this.btnTransfer.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnTransfer.StateCommon.Border.Rounding = 15;
			this.btnTransfer.TabIndex = 3;
			this.btnTransfer.Values.Text = "Transfer";
			this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
			// 
			// txtNewAcademicYear
			// 
			this.txtNewAcademicYear.Location = new System.Drawing.Point(450, 10);
			this.txtNewAcademicYear.Name = "txtNewAcademicYear";
			this.txtNewAcademicYear.Size = new System.Drawing.Size(212, 33);
			this.txtNewAcademicYear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txtNewAcademicYear.StateCommon.Border.Rounding = 15;
			this.txtNewAcademicYear.TabIndex = 2;
			this.txtNewAcademicYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewAcademicYear_KeyPress);
			// 
			// ddlNewClass
			// 
			this.ddlNewClass.DropDownWidth = 193;
			this.ddlNewClass.Location = new System.Drawing.Point(66, 10);
			this.ddlNewClass.Name = "ddlNewClass";
			this.ddlNewClass.Size = new System.Drawing.Size(203, 31);
			this.ddlNewClass.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ddlNewClass.StateCommon.ComboBox.Border.Rounding = 15;
			this.ddlNewClass.TabIndex = 1;
			// 
			// kryptonLabel4
			// 
			this.kryptonLabel4.Location = new System.Drawing.Point(22, 16);
			this.kryptonLabel4.Name = "kryptonLabel4";
			this.kryptonLabel4.Size = new System.Drawing.Size(38, 20);
			this.kryptonLabel4.TabIndex = 0;
			this.kryptonLabel4.Values.Text = "Class";
			// 
			// kryptonGroupBox3
			// 
			this.kryptonGroupBox3.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
			this.kryptonGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonGroupBox3.Location = new System.Drawing.Point(0, 203);
			this.kryptonGroupBox3.Name = "kryptonGroupBox3";
			// 
			// kryptonGroupBox3.Panel
			// 
			this.kryptonGroupBox3.Panel.Controls.Add(this.gvTranferStudent);
			this.kryptonGroupBox3.Size = new System.Drawing.Size(949, 292);
			this.kryptonGroupBox3.TabIndex = 6;
			this.kryptonGroupBox3.Values.Heading = "Class Student";
			// 
			// gvTranferStudent
			// 
			this.gvTranferStudent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gvTranferStudent.Location = new System.Drawing.Point(0, 0);
			this.gvTranferStudent.Name = "gvTranferStudent";
			this.gvTranferStudent.Size = new System.Drawing.Size(945, 270);
			this.gvTranferStudent.TabIndex = 0;
			// 
			// frmTransferStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(949, 495);
			this.Controls.Add(this.kryptonGroupBox3);
			this.Controls.Add(this.kryptonGroupBox2);
			this.Controls.Add(this.kryptonGroupBox1);
			this.Controls.Add(this.kryptonPanel1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmTransferStudent";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Transfer";
			((System.ComponentModel.ISupportInitialize)(this.epClass)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epAcademicYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
			this.kryptonGroupBox1.Panel.ResumeLayout(false);
			this.kryptonGroupBox1.Panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
			this.kryptonGroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ddlOldClass)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
			this.kryptonGroupBox2.Panel.ResumeLayout(false);
			this.kryptonGroupBox2.Panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
			this.kryptonGroupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ddlNewClass)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).EndInit();
			this.kryptonGroupBox3.Panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).EndInit();
			this.kryptonGroupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvTranferStudent)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider epClass;
        private System.Windows.Forms.ErrorProvider epAcademicYear;
		private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnGetStudent;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtOldAcademicYear;
		private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlOldClass;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
		private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
		private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnTransfer;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNewAcademicYear;
		private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlNewClass;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
		private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox3;
		private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gvTranferStudent;
	}
}