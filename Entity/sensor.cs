using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLab.Entity
{
    public class sensor
    {
        private int Sid;
        private string Eid;
        private DateTime Time;
        private string info;

        public sensor(int sid, string eid, DateTime time, string info)
        {
            Sid = sid;
            Eid = eid;
            Time = time;
            this.info = info;
        }

        public int Sid1 { get {return Sid;} set { Sid = value;} }
        public string Eid1 { get {return Eid;} set { Eid = value;} }
        public DateTime Time1 { get {return Time;} set { Time = value;} }
        public string Info { get {return info;} set { info = value;} }
    }
}
