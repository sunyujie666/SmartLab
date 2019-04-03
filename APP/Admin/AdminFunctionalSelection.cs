using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLab.APP.Admin
{
    public partial class AdminFunctionalSelection : Form
    {
        public AdminFunctionalSelection()
        {
            InitializeComponent();
        }

        private void AdminFunctionalSelection_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            PictureManagement pictureManagement = new PictureManagement();
            this.Close();
            pictureManagement.Show();
            
        }

        private void InfoManagement_Click(object sender, EventArgs e)
        {
            SensorView sensorView = new SensorView();
            sensorView.Show();
            this.Close();
            
        }

        private void ElectricalManagement_Click(object sender, EventArgs e)
        {

        }
    }
}
