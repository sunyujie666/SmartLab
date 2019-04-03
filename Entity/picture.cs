using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLab.Entity
{
    public class picture
    {
        private int Pid;
        private char Type;
        private String Picture_url;

        public picture(int pid, char type, string picture_url)
        {
            Pid = pid;
            Type = type;
            Picture_url = picture_url;
        }

        public int Pid1 { get { return Pid; } set { Pid = value; } }
        public char Type1 { get {return Type;} set { Type = value; }}
        public string Picture_url1 { get {return Picture_url;} set { Picture_url = value; }}
    }
}
