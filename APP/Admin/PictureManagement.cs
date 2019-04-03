using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLab.APP.Admin
{
    public partial class PictureManagement : Form
    {
        private PicmanageUP picmanageUP;

        public PictureManagement()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void PictureManagement_Load(object sender, EventArgs e)
        {
            picshow();
        }

        private void SingOut_Click(object sender, EventArgs e)
        {
            AdministratorLogin administratorLogin = new AdministratorLogin();
            administratorLogin.Show();
            if (this.picmanageUP != null)
            {
                picmanageUP.Close();
            }
            this.Close();
        }

 

        private void uppic_Click(object sender, EventArgs e)
        {
            if (picmanageUP == null)
            {
                picmanageUP = new PicmanageUP(this);
            }
            picmanageUP.Show();
            this.Hide();
        }

        public void picshow()
        {
            CurtainRight.Controls.Clear();
            String path = "../../img";
            DirectoryInfo folder = new DirectoryInfo(path);

            int i = 0;
            foreach (FileInfo file in folder.GetFiles("*.jpg"))
            {
                int j = i % 3;
                int k = i / 3;
                PictureBox pictureBox = new PictureBox();
                CurtainRight.BackColor = Color.FromArgb(255, 255, 255, 255);
                CurtainRight.Controls.Add(pictureBox);

                pictureBox.Size = new Size(320, 180);
                pictureBox.BackColor = Color.FromArgb(255, 255, 255, 255);
                pictureBox.Location = new System.Drawing.Point(50 + j * 400, 40+200 * k);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.ImageLocation = file.FullName;
                i++;
            }
        }

        private void returnSelection_Click(object sender, EventArgs e)
        {
            AdminFunctionalSelection adminFunctionalSelection = new AdminFunctionalSelection();
            adminFunctionalSelection.Show();
            this.Close();
        }
    }
}
