using System;
using ComponentFactory.Krypton.Ribbon;
using ComponentFactory.Krypton.Toolkit;

namespace NPSBS
{
    public partial class frmMdiMain : frmBase
    {
        public frmMdiMain()
        {
            InitializeComponent();
            string themeName = Properties.Settings.Default.ThemeName;
            SetTheme(themeName);
            CheckButton(themeName);
        }

        private void btnSchoolSetup_Click(object sender, EventArgs e)
        {
            frmSchoolSetup frmSchool = new frmSchoolSetup();
            frmSchool.MdiParent = this;
            frmSchool.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            frmSchool.Show();
        }
        
        private void btnApplyTheme_Click(object sender, EventArgs e)
        {
            var button = sender as KryptonRibbonGroupButton;
            string themeName = button.TextLine1;
            SetTheme(themeName);
            button.Checked = true;
        }


        private void SetTheme(string themeName)
        {
            btn13Blue.Checked = false;
            btn13White.Checked = false;
            btn10Black.Checked = false;
            btn10Blue.Checked = false;
            btn10Silver.Checked = false;
            btn07Black.Checked = false;
            btn07Blue.Checked = false;
            btn07Silver.Checked = false;
            btnSBlue.Checked = false;
            btnWin2003.Checked = false;
            switch (themeName)
            {
                case "2013 Default":
                    themeManager.GlobalPaletteMode = PaletteModeManager.Office2013;
                    break;
                case "2013 White":
                    themeManager.GlobalPaletteMode = PaletteModeManager.Office2013White;
                    break;
                case "2010 Blue":
                    themeManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
                    break;
                case "2010 Silver":
                    themeManager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
                    break;
                case "2010 Black":
                    themeManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
                    break;
                case "2007 Blue":
                    themeManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
                    break;
                case "2007 Silver":
                    themeManager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
                    break;
                case "2007 Black":
                    themeManager.GlobalPaletteMode = PaletteModeManager.Office2007Black;
                    break;
                case "Sparkle":
                    themeManager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
                    break;
                case "Windows 2003":
                    themeManager.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
                    break;
                default:
                    themeManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
                    break;
            }
            Properties.Settings.Default.ThemeName = themeName;
            Properties.Settings.Default.Save();
        }
        private void CheckButton(string themeName)
        {
            switch (themeName)
            {
                case "2013 Default":
                    btn13Blue.Checked = true;
                    break;
                case "2013 White":
                    btn13White.Checked = true;
                    break;
                case "2010 Blue":
                    btn10Blue.Checked = true;
                    break;
                case "2010 Silver":
                    btn10Silver.Checked = true;
                    break;
                case "2010 Black":
                    btn10Black.Checked = true;
                    break;
                case "2007 Blue":
                    btn07Blue.Checked = true;
                    break;
                case "2007 Silver":
                    btn07Silver.Checked = true;
                    break;
                case "2007 Black":
                    btn07Black.Checked = true;
                    break;
                case "Sparkle":
                    btnSBlue.Checked = true;
                    break;
                case "Windows 2003":
                    btnWin2003.Checked = true;
                    break;
                default:
                    btn10Blue.Checked = true;
                    break;
            }
        }
    }
}
