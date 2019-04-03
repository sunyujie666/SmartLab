using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SmartLab.Entity
{
     public class pass
    {
        private string uuid;
        private string userid;
        private int passtype;
        private int door;
        private DateTime passtime;

        public pass(string uuid, string userid, int passtype, int door, DateTime passtime)
        {
            this.uuid = uuid;
            this.userid = userid;
            this.passtype = passtype;
            this.door = door;
            this.passtime = passtime;
        }

        public string Uuid { get {return uuid;} set { uuid = value;} }
        public string Userid { get {return userid;} set { userid = value;} }
        public int Passtype { get {return passtype;} set { passtype = value;} }
        public int Door { get {return door;} set {door = value; }}
        public DateTime Passtime { get { return passtime; } set { passtime = value; } }
    }
}
