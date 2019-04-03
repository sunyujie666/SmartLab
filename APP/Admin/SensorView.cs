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
    public partial class SensorView : Form
    {
        public SensorView()
        {
            InitializeComponent();
        }

        private void returnSelection_Click(object sender, EventArgs e)
        {
            AdminFunctionalSelection adminFunctionalSelection = new AdminFunctionalSelection();
            adminFunctionalSelection.Show();
            this.Close();
        }

        private void SingOut_Click(object sender, EventArgs e)
        {
            AdministratorLogin administratorLogin = new AdministratorLogin();
            administratorLogin.Show();
            this.Close();
        }
    }
}
