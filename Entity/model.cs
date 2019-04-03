using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLab.Entity
{
     public class model
    {
        private String result;
        private int code;
        private String message;
        private String values;

        public string Result { get { return result; } set { result = value; } }
        public int Code { get {return code;} set { code = value; }}
        public string Message { get {return message;} set {message = value;} }
        public string Values { get {return values;} set { values = value; }}
    }
}
