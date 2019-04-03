using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLab.Entity
{
    public class ordertime
    {
        private int timeid;
        private DateTime starttime;
        private DateTime endtime;

        public ordertime(int timeid, DateTime starttime, DateTime endtime)
        {
            this.timeid = timeid;
            this.starttime = starttime;
            this.endtime = endtime;
        }
        public ordertime()
        {
        }

        public int Timeid { get {return timeid;} set { timeid = value; }}
        public DateTime Starttime { get {return starttime;} set { starttime = value; }}
        public DateTime Endtime { get {return endtime;} set { endtime = value; }}
    }
}
