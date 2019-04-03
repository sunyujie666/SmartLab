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
    public class AdminMapper
    {
        private static Connection connection = new Connection();
        public static List<admin> getallAdmin()
        {
            connection.Conn.Open();
            MySqlDataReader ord = connection.getmysqlcmd("select * from admin");
            List<admin> work = new List<admin>();
            try
            {
                if (ord != null)
                {
                    while (ord.Read())
                    {
                        admin ad = new admin(ord[0].ToString(), ord[1].ToString(), ord[2].ToString(), ord[3].ToString(), ord[4].ToString());
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
        public static List<admin> getAdminbyAdminname(string adminname)
        { 
            connection.Conn.Open();
            MySqlDataReader ord = connection.getmysqlcmd("select * from admin where adminid =" + adminname);
            List<admin> work = new List<admin>();
            try
            {
                if (ord != null)
                {
                    while (ord.Read())
                    {
                        admin ad = new admin(ord[0].ToString(), ord[1].ToString(), ord[2].ToString(), ord[3].ToString(), ord[4].ToString());
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
        public static String GetpasswordByUsername(String adminname)
        {
            connection.Conn.Open();
            String sql = "select adminpassword from admin where BINARY adminid = \'" + adminname + "\'";

            MySqlDataReader rdr = connection.getmysqlcmd(sql);
            try
            {
                if (rdr != null)
                {
                    if (rdr.Read())//读取
                    {
                        return rdr[0].ToString();
                    }
                    rdr.Close();
                }
                return null;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("2" + ex.Message);
                return null;
            }
            finally
            {
                connection.Conn.Close();
            }

        }
    }
}
