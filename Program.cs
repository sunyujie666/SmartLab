using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartLab.APP.Admin;
using SmartLab.APP.User;
using SmartLab.APP;
namespace SmartLab
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new AdministratorLogin());
            //Application.Run(new User1());
            Application.Run(new Main());
            //Application.Run(new User1());
        }
    }
}
