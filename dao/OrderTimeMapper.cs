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
    public class OrderTimeMapper
    {
        private static Connection connection = new Connection();
        public static List<ordertime> getallOrdertime()
        { 
            connection.Conn.Open();
            MySqlDataReader ord = connection.getmysqlcmd("select * from ordertime");
            List<ordertime> work = new List<ordertime>();
            try
            {
                if (ord != null)
                {
                    while (ord.Read())
                    {
                        ordertime ot = new ordertime(int.Parse(ord[0].ToString()), Convert.ToDateTime(ord[1].ToString()), Convert.ToDateTime(ord[2].ToString()));
                        work.Add(ot);
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
        public static ordertime getTimebyTimeid(int timeid)
        {
            connection.Conn.Open();
            MySqlDataReader ord = connection.getmysqlcmd("select * from ordertime where timeid = " + timeid);
            ordertime work=new ordertime();

            try
            {
                if (ord != null)
                {
                    while (ord.Read())
                    {
                        ordertime ot = new ordertime(int.Parse(ord[0].ToString()), Convert.ToDateTime(ord[1].ToString()), Convert.ToDateTime(ord[2].ToString()));
                        work=ot;
                    }
                    ord.Close();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            connection.Conn.Close();
            return work;
        }
        
    }
}
