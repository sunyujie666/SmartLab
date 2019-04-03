using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLab.APP.User
{
    public partial class Appointment_schedule : Form
    {
        private User1 user1;
        public Appointment_schedule(User1 user1)
        {
            InitializeComponent();
            this.user1 = user1;
        }

        private void returnSelection_Click(object sender, EventArgs e)
        {
            user1.Show();
            user1.connVideo();
            this.Close();
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
    }
}
