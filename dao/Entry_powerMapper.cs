using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartLab.Entity;
using until;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace SmartLab.dao
{
    public class Entry_powerMapper
    {
        private static Connection connection = new Connection();
        public static Boolean doorOpen(String need)
        {
            connection.Conn.Open();
            MySqlDataReader ord = connection.getmysqlcmd("select * from entry_power where user_face ="+ need);
            if (ord != null)
            {
                return true;
            }
            else
            {
                MySqlDataReader ord1 = connection.getmysqlcmd("select * from entry_power where finger_print =" + need);
                if (ord != null)
                {
                    return true;
                }
                else
                    return false;
            }

        }

        public static List<entry_power> getEntryList() 
        {
            connection.Conn.Open();
            //MySqlDataReader ord = connection.getmysqlcmd("select * from orderinfo where Date =" + dateTime);
            MySqlDataReader ord = connection.getmysqlcmd("select * from entry_power");
            List<entry_power> work = new List<entry_power>();
            try
            {
                if (ord != null)
                {
                    while (ord.Read())
                    {
                        entry_power ad = new entry_power(int.Parse(ord[0].ToString()), ord[1].ToString(), ord[2].ToString(), ord[3].ToString(), ord[4].ToString(), Convert.ToDateTime(ord[5].ToString()), ord[6].ToString());
                        work.Add(ad);
                    }
                    ord.Close();
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Conn.Close();
            return work;
        }

        public static Boolean setEntryUser(String name, String phone, String user_face, String figer_print, String adminid)
        {
            connection.Conn.Open();
            DateTime time = DateTime.Now;
            try
            {
                string s = "insert into  entry_power (name,phone,user_face,finger_print,time,adminid) values(" + "\"" + name + "\"" + "," + "\"" + phone + "\"" + "," + "\"" + user_face + "\"" + "," + "\"" + figer_print + "\"" + "," + "\"" + time + "\"" + "," + "\"" + adminid + "\"" + ")";
                MySqlDataReader ord = connection.getmysqlcmd(s);
                ord.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            connection.Conn.Close();
            return true;
        }

        public static Boolean deleteEntryUser(int epid)
        {
            connection.Conn.Open();
            DateTime time = DateTime.Now;
            try
            {
                string s = "delete from entry_power where epid="+epid;
                MySqlDataReader ord = connection.getmysqlcmd(s);
                ord.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            connection.Conn.Close();
            return true;
        }

        public static Boolean adminPsdUpdate(string adminid,string psd)
        {
            connection.Conn.Open();
            DateTime time = DateTime.Now;
            try
            {
                string s = "update admin set adminpassword= "+psd+"  where adminid="+adminid;
                MySqlDataReader ord = connection.getmysqlcmd(s);
                ord.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            connection.Conn.Close();
            return true;
        }
        

    }
}
