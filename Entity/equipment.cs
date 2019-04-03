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
    public class equipment
    {
        private int Eid;

        public int Eid1
        {
            get { return Eid; }
            set { Eid = value; }
        }
        private string Ename;

        public string Ename1
        {
            get { return Ename; }
            set { Ename = value; }
        }
        private char Emodel;

        public char Emodel1
        {
            get { return Emodel; }
            set { Emodel = value; }
        }
        private DateTime Time;

        public DateTime Time1
        {
            get { return Time; }
            set { Time = value; }
        }
        private string Port;

        public string Port1
        {
            get { return Port; }
            set { Port = value; }
        }
        private string E_brand;

        public string E_brand1
        {
            get { return E_brand; }
            set { E_brand = value; }
        }
        private string E_type;

        public string E_type1
        {
            get { return E_type; }
            set { E_type = value; }
        }
        private string E_info;

        public string E_info1
        {
            get { return E_info; }
            set { E_info = value; }
        }
        private string Adminid;

        public string Adminid1
        {
            get { return Adminid; }
            set { Adminid = value; }
        }

        public equipment(int eid, string ename, char emodel, DateTime time, string port, string e_brand, string e_type, string e_info, string adminid)
        {
            Eid = eid;
            Ename = ename;
            Emodel = emodel;
            Time = time;
            Port = port;
            E_brand = e_brand;
            E_type = e_type;
            E_info = e_info;
            Adminid = adminid;
        }


    }
}
