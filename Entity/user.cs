using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SmartLab.Entity
{
    public class user
    {
        private string userid;
        private string username;
        private string college;
        private string role;
        private int state;
        private DateTime regtime;
        private string userface;
        private string userpicturedir;
        private string iccard;

        public user(string userid, string username, string college, string role, int state, DateTime regtime, string userface, string userpicturedir, string iccard)
        {
            this.userid = userid;
            this.username = username;
            this.college = college;
            this.role = role;
            this.state = state;
            this.regtime = regtime;
            this.userface = userface;
            this.userpicturedir = userpicturedir;
            this.iccard = iccard;
        }

        public string Userid { get {return userid;} set { userid = value; }}
        public string Username { get {return username;} set {username = value;} }
        public string College { get {return college;} set {college = value;} }
        public string Role { get {return role;} set { role = value; }}
        public int State { get {return state;} set { state = value; }}
        public DateTime Regtime { get {return regtime;} set { regtime = value; }}
        public string Userface { get {return userface;} set { userface = value; }}
        public string Userpicturedir { get {return userpicturedir;} set { userpicturedir = value; }}
        public string Iccard { get {return iccard;} set {iccard = value; }}

        
    }
}
