namespace Montessori
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
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ddlClass = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnGenerateResult = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ddlExamination = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtAcademicYear = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.epAcademicYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epExamination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlExamination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
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
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(828, 159);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 50);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ddlClass);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnGenerateResult);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ddlExamination);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtAcademicYear);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(828, 109);
            this.kryptonGroupBox1.TabIndex = 1;
            this.kryptonGroupBox1.Values.Heading = "Exam Detail";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(24, 50);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(38, 20);
            this.kryptonLabel3.TabIndex = 6;
            this.kryptonLabel3.Values.Text = "Class";
            // 
            // ddlClass
            // 
            this.ddlClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlClass.DropDownWidth = 291;
            this.ddlClass.Location = new System.Drawing.Point(113, 43);
            this.ddlClass.Name = "ddlClass";
            this.ddlClass.Size = new System.Drawing.Size(222, 31);
            this.ddlClass.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ddlClass.StateCommon.ComboBox.Border.Rounding = 15;
            this.ddlClass.TabIndex = 2;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(390, 13);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(77, 20);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Examination";
            // 
            // btnGenerateResult
            // 
            this.btnGenerateResult.Location = new System.Drawing.Point(487, 40);
            this.btnGenerateResult.Name = "btnGenerateResult";
            this.btnGenerateResult.Size = new System.Drawing.Size(160, 35);
            this.btnGenerateResult.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGenerateResult.StateCommon.Border.Rounding = 15;
            this.btnGenerateResult.TabIndex = 3;
            this.btnGenerateResult.Values.Text = "Publish";
            this.btnGenerateResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // ddlExamination
            // 
            this.ddlExamination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlExamination.DropDownWidth = 291;
            this.ddlExamination.Location = new System.Drawing.Point(487, 6);
            this.ddlExamination.Name = "ddlExamination";
            this.ddlExamination.Size = new System.Drawing.Size(301, 31);
            this.ddlExamination.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ddlExamination.StateCommon.ComboBox.Border.Rounding = 15;
            this.ddlExamination.TabIndex = 1;
            this.ddlExamination.SelectedIndexChanged += new System.EventHandler(this.ddlExamination_SelectedIndexChanged);
            // 
            // txtAcademicYear
            // 
            this.txtAcademicYear.Location = new System.Drawing.Point(113, 7);
            this.txtAcademicYear.Name = "txtAcademicYear";
            this.txtAcademicYear.Size = new System.Drawing.Size(222, 33);
            this.txtAcademicYear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAcademicYear.StateCommon.Border.Rounding = 15;
            this.txtAcademicYear.TabIndex = 0;
            this.txtAcademicYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcademicYear_KeyPress);
            this.txtAcademicYear.Leave += new System.EventHandler(this.txtAcademicYear_Leave);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(24, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(91, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Academic Year";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(828, 50);
            this.kryptonPanel2.TabIndex = 80;
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 159);
            this.Controls.Add(this.kryptonPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmResult";
            this.ShowInTaskbar = false;
            this.Text = "Result";
            this.Load += new System.EventHandler(this.frmResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epAcademicYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epExamination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddlClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlExamination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider epAcademicYear;
        private System.Windows.Forms.ErrorProvider epExamination;
        private System.Windows.Forms.ErrorProvider epClass;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlClass;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGenerateResult;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlExamination;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAcademicYear;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}