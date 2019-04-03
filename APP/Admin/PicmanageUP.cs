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
    public partial class PicmanageUP : Form
    {
        private PictureManagement pictureManagement;
        public PicmanageUP(PictureManagement pictureManagement)
        {
            InitializeComponent();
            this.pictureManagement = pictureManagement;
        }

        private void PicmanageUP_Load(object sender, EventArgs e)
        {
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

        private void SingOut_Click(object sender, EventArgs e)
        {
            AdministratorLogin administratorLogin = new AdministratorLogin();
            administratorLogin.Show();
            this.Close();
        }

        private void ALLPIC_Click(object sender, EventArgs e)
        {
            this.pictureManagement.Show();
            this.Hide();
        }

        private void fileselect_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "图片文件(*.JPEG,*.TIFF,*.RAW,*.BMP,*.GIF,*.PNG,*.JPG)|*.JPEG;*.TIFF;*.RAW;*.BMP;*.GIF;*.PNG;*.JPG";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;//返回文件的完整路径   
                textBox1.Text = file;
                Show.ImageLocation = file;
            }
        }

        private void Areyousure_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                String[] name = textBox1.Text.Split('\\');
                System.IO.File.Copy(textBox1.Text, "../../img/"+name[name.Length-1]);
                this.pictureManagement.picshow();
                MessageBox.Show("上传完毕！");
            }
            else
            {
                MessageBox.Show("请选择文件！");
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
