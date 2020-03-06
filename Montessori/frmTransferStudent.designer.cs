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
            this.epClass = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAcademicYear = new System.Windows.Forms.ErrorProvider(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox3 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.gvTranferStudent = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnTransfer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtNewAcademicYear = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ddlNewClass = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnGetStudent = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtOldAcademicYear = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ddlOldClass = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.epClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAcademicYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).BeginInit();
            this.kryptonGroupBox3.Panel.SuspendLayout();
            this.kryptonGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTranferStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlNewClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlOldClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
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
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox3);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(928, 508);
            this.kryptonPanel1.TabIndex = 3;
            // 
            // kryptonGroupBox3
            // 
            this.kryptonGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox3.Location = new System.Drawing.Point(0, 175);
            this.kryptonGroupBox3.Name = "kryptonGroupBox3";
            // 
            // kryptonGroupBox3.Panel
            // 
            this.kryptonGroupBox3.Panel.Controls.Add(this.gvTranferStudent);
            this.kryptonGroupBox3.Size = new System.Drawing.Size(928, 333);
            this.kryptonGroupBox3.TabIndex = 2;
            this.kryptonGroupBox3.Values.Heading = "Class Student";
            // 
            // gvTranferStudent
            // 
            this.gvTranferStudent.AllowUserToAddRows = false;
            this.gvTranferStudent.AllowUserToDeleteRows = false;
            this.gvTranferStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvTranferStudent.Location = new System.Drawing.Point(0, 0);
            this.gvTranferStudent.Name = "gvTranferStudent";
            this.gvTranferStudent.ReadOnly = true;
            this.gvTranferStudent.Size = new System.Drawing.Size(924, 309);
            this.gvTranferStudent.TabIndex = 0;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel3.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 50);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(928, 125);
            this.kryptonPanel3.TabIndex = 1;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(464, 0);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnTransfer);
            this.kryptonGroupBox2.Panel.Controls.Add(this.txtNewAcademicYear);
            this.kryptonGroupBox2.Panel.Controls.Add(this.ddlNewClass);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(464, 125);
            this.kryptonGroupBox2.TabIndex = 1;
            this.kryptonGroupBox2.Values.Heading = "New Class";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(27, 55);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(91, 20);
            this.kryptonLabel3.TabIndex = 9;
            this.kryptonLabel3.Values.Text = "Academic Year";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(284, 52);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(135, 35);
            this.btnTransfer.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTransfer.StateCommon.Border.Rounding = 15;
            this.btnTransfer.TabIndex = 8;
            this.btnTransfer.Values.Text = "Transfer";
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtNewAcademicYear
            // 
            this.txtNewAcademicYear.Location = new System.Drawing.Point(140, 54);
            this.txtNewAcademicYear.Name = "txtNewAcademicYear";
            this.txtNewAcademicYear.Size = new System.Drawing.Size(135, 33);
            this.txtNewAcademicYear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNewAcademicYear.StateCommon.Border.Rounding = 15;
            this.txtNewAcademicYear.TabIndex = 7;
            this.txtNewAcademicYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewAcademicYear_KeyPress);
            // 
            // ddlNewClass
            // 
            this.ddlNewClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlNewClass.DropDownWidth = 269;
            this.ddlNewClass.Location = new System.Drawing.Point(140, 17);
            this.ddlNewClass.Name = "ddlNewClass";
            this.ddlNewClass.Size = new System.Drawing.Size(279, 31);
            this.ddlNewClass.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ddlNewClass.StateCommon.ComboBox.Border.Rounding = 15;
            this.ddlNewClass.TabIndex = 6;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel4.Location = new System.Drawing.Point(27, 21);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(38, 20);
            this.kryptonLabel4.TabIndex = 5;
            this.kryptonLabel4.Values.Text = "Class";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnGetStudent);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtOldAcademicYear);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ddlOldClass);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(464, 125);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Old Class";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(10, 61);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(91, 20);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Academic Year";
            // 
            // btnGetStudent
            // 
            this.btnGetStudent.Location = new System.Drawing.Point(268, 54);
            this.btnGetStudent.Name = "btnGetStudent";
            this.btnGetStudent.Size = new System.Drawing.Size(135, 35);
            this.btnGetStudent.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGetStudent.StateCommon.Border.Rounding = 15;
            this.btnGetStudent.TabIndex = 3;
            this.btnGetStudent.Values.Text = "Get Student";
            this.btnGetStudent.Click += new System.EventHandler(this.btnGetStudent_Click);
            // 
            // txtOldAcademicYear
            // 
            this.txtOldAcademicYear.Location = new System.Drawing.Point(124, 54);
            this.txtOldAcademicYear.Name = "txtOldAcademicYear";
            this.txtOldAcademicYear.Size = new System.Drawing.Size(135, 33);
            this.txtOldAcademicYear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtOldAcademicYear.StateCommon.Border.Rounding = 15;
            this.txtOldAcademicYear.TabIndex = 2;
            this.txtOldAcademicYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOldAcademicYear_KeyPress);
            // 
            // ddlOldClass
            // 
            this.ddlOldClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlOldClass.DropDownWidth = 269;
            this.ddlOldClass.Location = new System.Drawing.Point(124, 17);
            this.ddlOldClass.Name = "ddlOldClass";
            this.ddlOldClass.Size = new System.Drawing.Size(279, 31);
            this.ddlOldClass.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ddlOldClass.StateCommon.ComboBox.Border.Rounding = 15;
            this.ddlOldClass.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(11, 24);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(38, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Class";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(928, 50);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // frmTransferStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 508);
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
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).EndInit();
            this.kryptonGroupBox3.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).EndInit();
            this.kryptonGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvTranferStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddlNewClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddlOldClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider epClass;
        private System.Windows.Forms.ErrorProvider epAcademicYear;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGetStudent;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtOldAcademicYear;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlOldClass;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTransfer;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNewAcademicYear;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlNewClass;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gvTranferStudent;
    }
}