using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartLab.Service;
using SmartLab.Entity;
using SmartLab.dao;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SmartLab.APP.Admin
{
    public partial class AdministratorLogin : Form
    {
        public AdministratorLogin()
        {
            InitializeComponent();
            
        }

        private void Singin_Click(object sender, EventArgs e)
        {
            //ShowService ss = new ShowService();
            //DateTime t=;
            //ss.getClassinfo();

            //EntranceService es = new EntranceService();

            //es.setEntryUser("xiaoming","18036523652","picture","xxxxx","123456");
            //es.deleteEntryUser(2);

            //Console.ReadKey();


            String adminname = account.Text;
            String adminpasswd = passwordtext.Text;
            
            if(adminname == "" || adminpasswd == "")
            {
                MessageBox.Show("用户名和密码不能为空！");
                return;
            }
            LoginService loginService = new LoginService();
            String jobject =  loginService.Login(adminname, adminpasswd);
            MessageBox.Show(jobject);
            model m1 = JsonConvert.DeserializeObject<model>(jobject);
           
            if (m1.Code==200)
            {
                AdminFunctionalSelection adminFunctionalSelection = new AdminFunctionalSelection();
                adminFunctionalSelection.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }

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

        private void ForgetPassword_Click(object sender, EventArgs e)
        {

        }

        private void bg_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
