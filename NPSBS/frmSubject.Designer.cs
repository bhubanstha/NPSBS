namespace NPSBS
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.gvSubjects = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ddlClassSearch = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.ddlClass = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblSubjectID = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtPracticalMarks = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtTheoryMarks = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtSubject = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.epClass = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSubject = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTheory = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPractical = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlClassSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTheory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPractical)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(957, 522);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(0, 152);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.gvSubjects);
            this.kryptonGroupBox2.Panel.Controls.Add(this.ddlClassSearch);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(957, 370);
            this.kryptonGroupBox2.TabIndex = 5;
            this.kryptonGroupBox2.Values.Heading = "Subject Information";
            // 
            // gvSubjects
            // 
            this.gvSubjects.AllowUserToAddRows = false;
            this.gvSubjects.AllowUserToDeleteRows = false;
            this.gvSubjects.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvSubjects.Location = new System.Drawing.Point(0, 47);
            this.gvSubjects.Name = "gvSubjects";
            this.gvSubjects.ReadOnly = true;
            this.gvSubjects.Size = new System.Drawing.Size(953, 299);
            this.gvSubjects.TabIndex = 13;
            this.gvSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSubjects_CellContentClick);
            // 
            // ddlClassSearch
            // 
            this.ddlClassSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlClassSearch.DropDownWidth = 260;
            this.ddlClassSearch.Location = new System.Drawing.Point(65, 10);
            this.ddlClassSearch.Name = "ddlClassSearch";
            this.ddlClassSearch.Size = new System.Drawing.Size(270, 31);
            this.ddlClassSearch.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ddlClassSearch.StateCommon.ComboBox.Border.Rounding = 15;
            this.ddlClassSearch.TabIndex = 12;
            this.ddlClassSearch.SelectedIndexChanged += new System.EventHandler(this.ddlClassSearch_SelectedIndexChanged);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel5.Location = new System.Drawing.Point(10, 14);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(38, 20);
            this.kryptonLabel5.TabIndex = 11;
            this.kryptonLabel5.Values.Text = "Class";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 45);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.ddlClass);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblSubjectID);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnSave);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtPracticalMarks);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtTheoryMarks);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtSubject);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(957, 107);
            this.kryptonGroupBox1.TabIndex = 4;
            this.kryptonGroupBox1.Values.Heading = "Subject Entry";
            // 
            // ddlClass
            // 
            this.ddlClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlClass.DropDownWidth = 260;
            this.ddlClass.Location = new System.Drawing.Point(107, 7);
            this.ddlClass.Name = "ddlClass";
            this.ddlClass.Size = new System.Drawing.Size(270, 31);
            this.ddlClass.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ddlClass.StateCommon.ComboBox.Border.Rounding = 15;
            this.ddlClass.TabIndex = 10;
            // 
            // lblSubjectID
            // 
            this.lblSubjectID.Location = new System.Drawing.Point(812, 13);
            this.lblSubjectID.Name = "lblSubjectID";
            this.lblSubjectID.Size = new System.Drawing.Size(17, 20);
            this.lblSubjectID.TabIndex = 9;
            this.lblSubjectID.Values.Text = "0";
            this.lblSubjectID.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(782, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 35);
            this.btnSave.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 15;
            this.btnSave.TabIndex = 8;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPracticalMarks
            // 
            this.txtPracticalMarks.Location = new System.Drawing.Point(506, 44);
            this.txtPracticalMarks.Name = "txtPracticalMarks";
            this.txtPracticalMarks.Size = new System.Drawing.Size(270, 33);
            this.txtPracticalMarks.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPracticalMarks.StateCommon.Border.Rounding = 15;
            this.txtPracticalMarks.TabIndex = 7;
            this.txtPracticalMarks.Text = "0";
            this.txtPracticalMarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPracticalMarks_KeyPress);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel4.Location = new System.Drawing.Point(409, 52);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(92, 20);
            this.kryptonLabel4.TabIndex = 6;
            this.kryptonLabel4.Values.Text = "Practical Marks";
            // 
            // txtTheoryMarks
            // 
            this.txtTheoryMarks.Location = new System.Drawing.Point(107, 44);
            this.txtTheoryMarks.Name = "txtTheoryMarks";
            this.txtTheoryMarks.Size = new System.Drawing.Size(270, 33);
            this.txtTheoryMarks.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTheoryMarks.StateCommon.Border.Rounding = 15;
            this.txtTheoryMarks.TabIndex = 5;
            this.txtTheoryMarks.Text = "0";
            this.txtTheoryMarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTheoryMarks_KeyPress);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(10, 52);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(84, 20);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Theory Marks";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(506, 5);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(270, 33);
            this.txtSubject.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSubject.StateCommon.Border.Rounding = 15;
            this.txtSubject.TabIndex = 3;
            this.txtSubject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubject_KeyPress);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(409, 13);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(51, 20);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Subject";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(10, 13);
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
            this.kryptonPanel2.Size = new System.Drawing.Size(957, 45);
            this.kryptonPanel2.TabIndex = 3;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 522);
            this.Controls.Add(this.kryptonPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSubject";
            this.Text = "Subject";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlClassSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddlClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTheory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPractical)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
		private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
		private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
		private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlClass;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSubjectID;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPracticalMarks;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTheoryMarks;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSubject;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
		private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
		private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gvSubjects;
		private ComponentFactory.Krypton.Toolkit.KryptonComboBox ddlClassSearch;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
		private System.Windows.Forms.ErrorProvider epClass;
		private System.Windows.Forms.ErrorProvider epSubject;
		private System.Windows.Forms.ErrorProvider epTheory;
		private System.Windows.Forms.ErrorProvider epPractical;
	}
}