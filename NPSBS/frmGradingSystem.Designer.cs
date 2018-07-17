namespace NPSBS
{
    partial class frmGradingSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGradingSystem));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarksFrom = new System.Windows.Forms.TextBox();
            this.txtMarksTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gvGradingSystem = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.epMarksFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMarksTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epGrade = new System.Windows.Forms.ErrorProvider(this.components);
            this.epRemarks = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblGradingId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvGradingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMarksFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMarksTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRemarks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marks From :";
            // 
            // txtMarksFrom
            // 
            this.txtMarksFrom.Location = new System.Drawing.Point(122, 49);
            this.txtMarksFrom.Name = "txtMarksFrom";
            this.txtMarksFrom.Size = new System.Drawing.Size(271, 29);
            this.txtMarksFrom.TabIndex = 1;
            // 
            // txtMarksTo
            // 
            this.txtMarksTo.Location = new System.Drawing.Point(545, 49);
            this.txtMarksTo.Name = "txtMarksTo";
            this.txtMarksTo.Size = new System.Drawing.Size(277, 29);
            this.txtMarksTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marks To :";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(122, 94);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(271, 29);
            this.txtGrade.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grade";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(122, 140);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(700, 92);
            this.txtRemarks.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Remarks :";
            // 
            // gvGradingSystem
            // 
            this.gvGradingSystem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gvGradingSystem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvGradingSystem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGradingSystem.Location = new System.Drawing.Point(27, 296);
            this.gvGradingSystem.Name = "gvGradingSystem";
            this.gvGradingSystem.RowTemplate.Height = 24;
            this.gvGradingSystem.Size = new System.Drawing.Size(795, 203);
            this.gvGradingSystem.TabIndex = 8;
            this.gvGradingSystem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvGradingSystem_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(122, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 37);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epMarksFrom
            // 
            this.epMarksFrom.ContainerControl = this;
            // 
            // epMarksTo
            // 
            this.epMarksTo.ContainerControl = this;
            // 
            // epGrade
            // 
            this.epGrade.ContainerControl = this;
            // 
            // epRemarks
            // 
            this.epRemarks.ContainerControl = this;
            // 
            // lblGradingId
            // 
            this.lblGradingId.AutoSize = true;
            this.lblGradingId.Location = new System.Drawing.Point(371, 243);
            this.lblGradingId.Name = "lblGradingId";
            this.lblGradingId.Size = new System.Drawing.Size(19, 21);
            this.lblGradingId.TabIndex = 10;
            this.lblGradingId.Text = "0";
            this.lblGradingId.Visible = false;
            // 
            // frmGradingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(842, 507);
            this.Controls.Add(this.lblGradingId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gvGradingSystem);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarksTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarksFrom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGradingSystem";
            this.Text = "frmGradingSystem";
            ((System.ComponentModel.ISupportInitialize)(this.gvGradingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMarksFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMarksTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRemarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarksFrom;
        private System.Windows.Forms.TextBox txtMarksTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gvGradingSystem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider epMarksFrom;
        private System.Windows.Forms.ErrorProvider epMarksTo;
        private System.Windows.Forms.ErrorProvider epGrade;
        private System.Windows.Forms.ErrorProvider epRemarks;
        private System.Windows.Forms.Label lblGradingId;
    }
}