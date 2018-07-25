using System;
using System.Drawing;
using System.Windows.Forms;

namespace NPSBS
{
    public partial class frmSchoolSetup : frmBase
    {
        private string imageFile = string.Empty;
        public frmSchoolSetup()
        {
            InitializeComponent();
        }

        private void frmSchoolSetup_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofd.RestoreDirectory = true;
            ofd.Filter = "Image File|*.jpg;*.jpeg;*.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                imageFile = ofd.FileName;
                Image image = Image.FromFile(ofd.FileName);
                picLogo.Image = image;
            }
        }

        private void btnRemoveLogo_Click(object sender, EventArgs e)
        {
            imageFile = string.Empty;
            picLogo.Image = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
