using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartLab.APP.Admin;
using SmartLab.APP.User;

namespace SmartLab.APP
{
    public partial class Main : Form
    {
        public Main()
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
        private void Main_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;//设置父窗体是容器
            AdministratorLogin a = new AdministratorLogin();//实例化子窗体
            //User1 a = new User1();
            a.MdiParent = this;//设置窗体的父子关系
            a.Parent = panel1;//设置子窗体的容器为父窗体中的Panel
            a.Show();//显示子窗体，此句很重要，否则子窗体不会显示！
        }
    }
}
