using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLab.Entity
{
    public class orderinfo
    {
        private int Id;
        private string Userid;
        private string Username;
        private string Department;
        private DateTime Date;
        private string Timeid;
        private int Person_num;
        private char State;
        private string Classinfo;


        public orderinfo(int id, string userid, string username,string department, DateTime date, string timeid, int person_num,string classinfo, char state)
        {
            Id = id;
            Userid = userid;
            Username = username;
            Department=department;
            Date = date;
            Timeid = timeid;
            Person_num = person_num;
            State = state;
            Classinfo = classinfo;


        }

        public int Id1 { get {return Id;} set { Id = value; }}
        public string Userid1 { get {return Userid;} set { Userid = value; }}
        public string Username1 { get {return Username;} set { Username = value; }}
        public DateTime Date1 { get {return Date;} set { Date = value; }}
        public string Timeid1 { get {return Timeid;} set { Timeid = value; }}
        public int Person_num1 { get {return Person_num;} set { Person_num = value; }}
        public char State1 { get {return State;} set { State = value; }}
        public string Classinfo1 { get { return Classinfo; } set { Classinfo = value; } }
        public string Department1 { get { return Department; } set { Department = value; } }


    }
}
