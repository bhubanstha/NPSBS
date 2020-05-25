namespace NPSBS
{
    partial class frmMdiMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMdiMain));
            this.tabManager = new MDIWindowManager.WindowManagerPanel();
            this.ribbonMenu = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.kryptonRibbonTab1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnSchoolSetup = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnSubject = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.ribbonGTheme = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupLines1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines();
            this.btn10Blue = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btn10Silver = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btn10Black = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btn07Blue = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btn07Silver = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btn07Black = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnSBlue = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnWin2003 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.rbnAddStudent = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.rbnTransferStudent = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.rbnMarkEntry = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.rbnExtraActivity = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.rbnAttendance = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.rbnResult = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.rbnLedger = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup5 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple5 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.rbnBackup = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.rbnRegister = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.rbnAbout = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnAppMenuInfo = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.btnAppMenuClose = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMenu)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabManager
            // 
            this.tabManager.AllowUserVerticalRepositioning = false;
            this.tabManager.AutoDetectMdiChildWindows = true;
            this.tabManager.AutoHide = false;
            this.tabManager.ButtonRenderMode = MDIWindowManager.ButtonRenderMode.Standard;
            this.tabManager.DisableCloseAction = false;
            this.tabManager.DisableHTileAction = false;
            this.tabManager.DisablePopoutAction = false;
            this.tabManager.DisableTileAction = false;
            this.tabManager.EnableTabPaintEvent = false;
            this.tabManager.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabManager.Location = new System.Drawing.Point(2, 117);
            this.tabManager.MinMode = false;
            this.tabManager.Name = "tabManager";
            this.tabManager.Orientation = MDIWindowManager.WindowManagerOrientation.Top;
            this.tabManager.ShowCloseButton = true;
            this.tabManager.ShowIcons = false;
            this.tabManager.ShowLayoutButtons = false;
            this.tabManager.ShowTitle = false;
            this.tabManager.Size = new System.Drawing.Size(1149, 30);
            this.tabManager.Style = MDIWindowManager.TabStyle.AngledHiliteTabs;
            this.tabManager.TabIndex = 0;
            this.tabManager.TabRenderMode = MDIWindowManager.TabsProvider.Standard;
            this.tabManager.TitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabManager.TitleForeColor = System.Drawing.Color.Transparent;
            this.tabManager.WindowPoppingOut += new System.EventHandler<MDIWindowManager.WrappedWindowCancelEventArgs>(this.tabManager_WindowPoppingOut);
            this.tabManager.WindowActivated += new System.EventHandler<MDIWindowManager.WrappedWindowEventArgs>(this.tabManager_WindowActivated);
            // 
            // ribbonMenu
            // 
            this.ribbonMenu.InDesignHelperMode = true;
            this.ribbonMenu.Name = "ribbonMenu";
            this.ribbonMenu.QATLocation = ComponentFactory.Krypton.Ribbon.QATLocation.Hidden;
            this.ribbonMenu.RibbonAppButton.AppButtonBaseColorDark = System.Drawing.Color.Navy;
            this.ribbonMenu.RibbonAppButton.AppButtonImage = null;
            this.ribbonMenu.RibbonAppButton.AppButtonVisible = false;
            this.ribbonMenu.RibbonTabs.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab[] {
            this.kryptonRibbonTab1,
            this.kryptonRibbonTab2,
            this.kryptonRibbonTab3,
            this.kryptonRibbonTab4});
            this.ribbonMenu.SelectedContext = null;
            this.ribbonMenu.SelectedTab = this.kryptonRibbonTab4;
            this.ribbonMenu.Size = new System.Drawing.Size(1153, 115);
            this.ribbonMenu.TabIndex = 1;
            // 
            // kryptonRibbonTab1
            // 
            this.kryptonRibbonTab1.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1,
            this.ribbonGTheme});
            this.kryptonRibbonTab1.Text = "Setup";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.DialogBoxLauncher = false;
            this.kryptonRibbonGroup1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1});
            this.kryptonRibbonGroup1.TextLine1 = "Setting";
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btnSchoolSetup,
            this.btnSubject,
            this.kryptonRibbonGroupButton3});
            // 
            // btnSchoolSetup
            // 
            this.btnSchoolSetup.ImageLarge = global::NPSBS.Properties.Resources.school;
            this.btnSchoolSetup.ImageSmall = global::NPSBS.Properties.Resources.school;
            this.btnSchoolSetup.KeyTip = "CTRL+SHIFT+S";
            this.btnSchoolSetup.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.btnSchoolSetup.Tag = "Ctrl+Shift+S";
            this.btnSchoolSetup.TextLine1 = "School Setup";
            this.btnSchoolSetup.ToolTipBody = "Setup school general information\r\nCtrl+Shift+S";
            this.btnSchoolSetup.ToolTipTitle = "School Setup";
            this.btnSchoolSetup.Click += new System.EventHandler(this.btnSchoolSetup_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.ImageLarge = global::NPSBS.Properties.Resources.book;
            this.btnSubject.ImageSmall = global::NPSBS.Properties.Resources.book;
            this.btnSubject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSubject.TextLine1 = "Subject";
            this.btnSubject.ToolTipBody = "Manage class wise subjects\r\nCtrl+S";
            this.btnSubject.ToolTipTitle = "Subject Management";
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // kryptonRibbonGroupButton3
            // 
            this.kryptonRibbonGroupButton3.ImageLarge = global::NPSBS.Properties.Resources.exam;
            this.kryptonRibbonGroupButton3.ImageSmall = global::NPSBS.Properties.Resources.exam;
            this.kryptonRibbonGroupButton3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.kryptonRibbonGroupButton3.TextLine1 = "Exam";
            this.kryptonRibbonGroupButton3.ToolTipBody = "Academic year wise examination management\r\nCtrl+E";
            this.kryptonRibbonGroupButton3.ToolTipTitle = "Exam Management";
            this.kryptonRibbonGroupButton3.Click += new System.EventHandler(this.kryptonRibbonGroupButton3_Click);
            // 
            // ribbonGTheme
            // 
            this.ribbonGTheme.DialogBoxLauncher = false;
            this.ribbonGTheme.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupLines1});
            this.ribbonGTheme.TextLine1 = "Theme";
            // 
            // kryptonRibbonGroupLines1
            // 
            this.kryptonRibbonGroupLines1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btn10Blue,
            this.btn10Silver,
            this.btn10Black,
            this.btn07Blue,
            this.btn07Silver,
            this.btn07Black,
            this.btnSBlue,
            this.btnWin2003});
            // 
            // btn10Blue
            // 
            this.btn10Blue.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.btn10Blue.Checked = true;
            this.btn10Blue.ImageLarge = null;
            this.btn10Blue.ImageSmall = null;
            this.btn10Blue.TextLine1 = "2010 Blue";
            this.btn10Blue.Click += new System.EventHandler(this.btnApplyTheme_Click);
            // 
            // btn10Silver
            // 
            this.btn10Silver.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.btn10Silver.ImageLarge = null;
            this.btn10Silver.ImageSmall = null;
            this.btn10Silver.TextLine1 = "2010 Silver";
            this.btn10Silver.Click += new System.EventHandler(this.btnApplyTheme_Click);
            // 
            // btn10Black
            // 
            this.btn10Black.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.btn10Black.ImageLarge = null;
            this.btn10Black.ImageSmall = null;
            this.btn10Black.TextLine1 = "2010 Black";
            this.btn10Black.Click += new System.EventHandler(this.btnApplyTheme_Click);
            // 
            // btn07Blue
            // 
            this.btn07Blue.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.btn07Blue.ImageLarge = null;
            this.btn07Blue.ImageSmall = null;
            this.btn07Blue.TextLine1 = "2007 Blue";
            this.btn07Blue.Click += new System.EventHandler(this.btnApplyTheme_Click);
            // 
            // btn07Silver
            // 
            this.btn07Silver.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.btn07Silver.ImageLarge = null;
            this.btn07Silver.ImageSmall = null;
            this.btn07Silver.TextLine1 = "2007 Silver";
            this.btn07Silver.Click += new System.EventHandler(this.btnApplyTheme_Click);
            // 
            // btn07Black
            // 
            this.btn07Black.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.btn07Black.ImageLarge = null;
            this.btn07Black.ImageSmall = null;
            this.btn07Black.TextLine1 = "2007 Black";
            this.btn07Black.Click += new System.EventHandler(this.btnApplyTheme_Click);
            // 
            // btnSBlue
            // 
            this.btnSBlue.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.btnSBlue.ImageLarge = null;
            this.btnSBlue.ImageSmall = null;
            this.btnSBlue.TextLine1 = "Sparkle";
            this.btnSBlue.Click += new System.EventHandler(this.btnApplyTheme_Click);
            // 
            // btnWin2003
            // 
            this.btnWin2003.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.btnWin2003.ImageLarge = null;
            this.btnWin2003.ImageSmall = null;
            this.btnWin2003.TextLine1 = "Windows 2003";
            this.btnWin2003.Click += new System.EventHandler(this.btnApplyTheme_Click);
            // 
            // kryptonRibbonTab2
            // 
            this.kryptonRibbonTab2.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup2});
            this.kryptonRibbonTab2.Text = "Student";
            // 
            // kryptonRibbonGroup2
            // 
            this.kryptonRibbonGroup2.DialogBoxLauncher = false;
            this.kryptonRibbonGroup2.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple2});
            // 
            // kryptonRibbonGroupTriple2
            // 
            this.kryptonRibbonGroupTriple2.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.rbnAddStudent,
            this.rbnTransferStudent});
            // 
            // rbnAddStudent
            // 
            this.rbnAddStudent.ImageLarge = global::NPSBS.Properties.Resources.student;
            this.rbnAddStudent.ImageSmall = global::NPSBS.Properties.Resources.student;
            this.rbnAddStudent.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.rbnAddStudent.TextLine1 = "Add";
            this.rbnAddStudent.ToolTipBody = "Enroll new student in a academic year class.\r\nCtrl+A";
            this.rbnAddStudent.ToolTipTitle = "Add Student";
            this.rbnAddStudent.Click += new System.EventHandler(this.kryptonRibbonGroupButton1_Click);
            // 
            // rbnTransferStudent
            // 
            this.rbnTransferStudent.ImageLarge = global::NPSBS.Properties.Resources.transfer;
            this.rbnTransferStudent.ImageSmall = global::NPSBS.Properties.Resources.transfer;
            this.rbnTransferStudent.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.rbnTransferStudent.TextLine1 = "Transfer";
            this.rbnTransferStudent.ToolTipBody = "Promote existing student into new academic year class.\r\nCtrl+T";
            this.rbnTransferStudent.ToolTipTitle = "Transfer Student";
            this.rbnTransferStudent.Click += new System.EventHandler(this.rbnTransferStudent_Click);
            // 
            // kryptonRibbonTab3
            // 
            this.kryptonRibbonTab3.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup3,
            this.kryptonRibbonGroup4});
            this.kryptonRibbonTab3.Text = "Exam";
            // 
            // kryptonRibbonGroup3
            // 
            this.kryptonRibbonGroup3.DialogBoxLauncher = false;
            this.kryptonRibbonGroup3.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple3});
            this.kryptonRibbonGroup3.TextLine1 = "Data Entry";
            // 
            // kryptonRibbonGroupTriple3
            // 
            this.kryptonRibbonGroupTriple3.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.rbnMarkEntry,
            this.rbnExtraActivity,
            this.rbnAttendance});
            // 
            // rbnMarkEntry
            // 
            this.rbnMarkEntry.ImageLarge = global::NPSBS.Properties.Resources.markentry;
            this.rbnMarkEntry.ImageSmall = global::NPSBS.Properties.Resources.markentry;
            this.rbnMarkEntry.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.rbnMarkEntry.TextLine1 = "Mark Entry";
            this.rbnMarkEntry.ToolTipBody = "Manage student\'s marks obtained in exam\r\nCtrl+M";
            this.rbnMarkEntry.ToolTipTitle = "Mark Entry";
            this.rbnMarkEntry.Click += new System.EventHandler(this.rbnMarkEntry_Click);
            // 
            // rbnExtraActivity
            // 
            this.rbnExtraActivity.ImageLarge = global::NPSBS.Properties.Resources.extraactivity;
            this.rbnExtraActivity.ImageSmall = global::NPSBS.Properties.Resources.extraactivity;
            this.rbnExtraActivity.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.rbnExtraActivity.TextLine1 = "Extra Activities";
            this.rbnExtraActivity.ToolTipBody = "Manage student extra activities\r\nCtrl+X";
            this.rbnExtraActivity.ToolTipTitle = "Extra Activities";
            this.rbnExtraActivity.Click += new System.EventHandler(this.rbnExtraActivity_Click);
            // 
            // rbnAttendance
            // 
            this.rbnAttendance.ImageLarge = global::NPSBS.Properties.Resources.attendance;
            this.rbnAttendance.ImageSmall = global::NPSBS.Properties.Resources.attendance;
            this.rbnAttendance.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.rbnAttendance.TextLine1 = "Attendance";
            this.rbnAttendance.ToolTipBody = "Manage student attendance in academic year exam wise\r\nCtrl+Shift+A";
            this.rbnAttendance.ToolTipTitle = "Attendance";
            this.rbnAttendance.Click += new System.EventHandler(this.rbnAttendance_Click);
            // 
            // kryptonRibbonGroup4
            // 
            this.kryptonRibbonGroup4.DialogBoxLauncher = false;
            this.kryptonRibbonGroup4.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple4});
            this.kryptonRibbonGroup4.TextLine1 = "Result";
            // 
            // kryptonRibbonGroupTriple4
            // 
            this.kryptonRibbonGroupTriple4.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.rbnResult,
            this.rbnLedger});
            // 
            // rbnResult
            // 
            this.rbnResult.ImageLarge = global::NPSBS.Properties.Resources.result;
            this.rbnResult.ImageSmall = global::NPSBS.Properties.Resources.result;
            this.rbnResult.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.rbnResult.TextLine1 = "Result";
            this.rbnResult.ToolTipBody = "Generate Pdf Report of Student Examination Result\r\nCtrl+P";
            this.rbnResult.ToolTipTitle = "Print Result";
            this.rbnResult.Click += new System.EventHandler(this.rbnResult_Click);
            // 
            // rbnLedger
            // 
            this.rbnLedger.ImageLarge = global::NPSBS.Properties.Resources.ledger;
            this.rbnLedger.ImageSmall = global::NPSBS.Properties.Resources.ledger;
            this.rbnLedger.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.rbnLedger.TextLine1 = "Ledger";
            this.rbnLedger.ToolTipBody = "Generate Students Exam marks ledger in pdf file\r\nCtrl+L";
            this.rbnLedger.ToolTipTitle = "Ledger";
            this.rbnLedger.Click += new System.EventHandler(this.rbnLedger_Click);
            // 
            // kryptonRibbonTab4
            // 
            this.kryptonRibbonTab4.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup5});
            this.kryptonRibbonTab4.Text = "Utilities";
            // 
            // kryptonRibbonGroup5
            // 
            this.kryptonRibbonGroup5.DialogBoxLauncher = false;
            this.kryptonRibbonGroup5.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple5});
            this.kryptonRibbonGroup5.TextLine1 = "Utilities";
            // 
            // kryptonRibbonGroupTriple5
            // 
            this.kryptonRibbonGroupTriple5.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.rbnBackup,
            this.rbnRegister,
            this.rbnAbout});
            // 
            // rbnBackup
            // 
            this.rbnBackup.ImageLarge = global::NPSBS.Properties.Resources.database;
            this.rbnBackup.ImageSmall = global::NPSBS.Properties.Resources.database;
            this.rbnBackup.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.rbnBackup.TextLine1 = "Backup Data";
            this.rbnBackup.ToolTipBody = "Take backup of data upto now so that it can be \r\nrestored at any point if somethi" +
    "ng goes wrong\r\nCtrl+B";
            this.rbnBackup.ToolTipTitle = "Backup Data";
            this.rbnBackup.Click += new System.EventHandler(this.rbnBackup_Click);
            // 
            // rbnRegister
            // 
            this.rbnRegister.ImageLarge = global::NPSBS.Properties.Resources.registration;
            this.rbnRegister.ImageSmall = global::NPSBS.Properties.Resources.registration;
            this.rbnRegister.TextLine1 = "Register";
            this.rbnRegister.ToolTipBody = "Register application to fully use";
            this.rbnRegister.ToolTipTitle = "Registration";
            this.rbnRegister.Click += new System.EventHandler(this.rbnRegister_Click);
            // 
            // rbnAbout
            // 
            this.rbnAbout.ImageLarge = global::NPSBS.Properties.Resources.info;
            this.rbnAbout.ImageSmall = global::NPSBS.Properties.Resources.info;
            this.rbnAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.rbnAbout.TextLine1 = "About";
            this.rbnAbout.ToolTipBody = "Know software license agreement\r\nF1";
            this.rbnAbout.ToolTipTitle = "About";
            this.rbnAbout.Click += new System.EventHandler(this.rbnAbout_Click);
            // 
            // btnAppMenuInfo
            // 
            this.btnAppMenuInfo.Text = "Menu Item";
            // 
            // btnAppMenuClose
            // 
            this.btnAppMenuClose.Text = "Menu Item";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime});
            this.statusStrip2.Location = new System.Drawing.Point(0, 428);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1153, 22);
            this.statusStrip2.TabIndex = 3;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(31, 17);
            this.lblTime.Text = "time";
            // 
            // frmMdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 450);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.ribbonMenu);
            this.Controls.Add(this.tabManager);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMdiMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "National Peace SBS Result Processing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMdiMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMenu)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MDIWindowManager.WindowManagerPanel tabManager;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbon ribbonMenu;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btnSchoolSetup;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btnSubject;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem btnAppMenuInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem btnAppMenuClose;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup ribbonGTheme;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines kryptonRibbonGroupLines1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btn10Blue;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btn10Silver;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btn07Black;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btnWin2003;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btn10Black;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btn07Blue;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btn07Silver;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btnSBlue;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab2;
		private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup2;
		private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple2;
		private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton rbnAddStudent;
		private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton rbnTransferStudent;
		private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab3;
		private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup3;
		private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple3;
		private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton rbnMarkEntry;
		private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton rbnExtraActivity;
		private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton rbnAttendance;
		private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple4;
		private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton rbnResult;
		private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton rbnLedger;
		private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab4;
		private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup5;
		private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple5;
		private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton rbnRegister;
		private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton rbnAbout;
		private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton rbnBackup;
		private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup4;
		private System.Windows.Forms.StatusStrip statusStrip2;
		private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
    }
}