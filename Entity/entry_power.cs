using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using until;
using MySql.Data.MySqlClient;
namespace SmartLab.Entity
{
    public class entry_power
    {
        private int epid;
        private string Name;
        private string Phone;
        private string User_face;
        private string Finger_print;
        private DateTime time;
        private string Adminid;

        public entry_power(int epid, string name, string phone, string user_face, string finger_print, DateTime time, string adminid)
        {
            this.epid = epid;
            Name = name;
            Phone = phone;
            User_face = user_face;
            Finger_print = finger_print;
            this.time = time;
            Adminid = adminid;
        }

        public int Epid { get {return epid;} set { epid = value;} }
        public string Name1 { get {return Name;} set {Name = value;} }
        public string Phone1 { get { return Phone; } set { Phone = value; } }
        public string User_face1 { get {return User_face;} set { User_face = value;} }
        public string Finger_print1 { get {return Finger_print;} set { Finger_print = value;} }
        public DateTime Time { get {return time;} set { time = value; }}
        public string Adminid1 { get {return Adminid;} set { Adminid = value;} }
    }
}
