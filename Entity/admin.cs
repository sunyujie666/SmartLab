using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using until;
using MySql.Data.MySqlClient;

namespace SmartLab.Entity
{
    public class admin
    {
        private string adminid;
        private string Realname;
        private string Adminpassword;
        private string Phone;
        private string Colleage;

        public admin(string adminid, string realname, string adminpassword, string phone, string colleage)
        {
            this.adminid = adminid;
            Realname = realname;
            Adminpassword = adminpassword;
            Phone = phone;
            Colleage = colleage;
        }

        public string Adminid { get { return adminid;} set { adminid = value;} }
        public string Realname1 { get {return Realname;} set {Realname = value;} }
        public string Adminpassword1 { get{return Adminpassword;} set { Adminpassword = value;} }
        public string Phone1 { get {return Phone;} set { Phone = value;} }
        public string Colleage1 { get { return Colleage; } set { Colleage = value; } }
    }

   
}
