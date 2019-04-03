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
    public class OrderinFoMapper
    {
        private static Connection connection = new Connection();
        public static List<orderinfo> getOrderinfo()
        {
            connection.Conn.Open();
            //MySqlDataReader ord = connection.getmysqlcmd("select * from orderinfo where Date =" + dateTime);
            MySqlDataReader ord = connection.getmysqlcmd("select * from orderinfo" );
            List<orderinfo> work = new List<orderinfo>();
            try
            {
                if (ord != null)
                {
                    while (ord.Read())
                    {
                        orderinfo ad = new orderinfo(int.Parse(ord[0].ToString()), ord[1].ToString(), ord[2].ToString(), ord[3].ToString(),Convert.ToDateTime(ord[4].ToString()), ord[5].ToString(),int.Parse(ord[6].ToString()),ord[7].ToString(),char.Parse(ord[8].ToString()));
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
        public static List<orderinfo> getOrderHistoryByDate(DateTime starttime,DateTime endtime)
        {
            connection.Conn.Open();
            MySqlDataReader ord = connection.getmysqlcmd("select * from orderinfo where Date between  = " + starttime + " and " + endtime);
            List<orderinfo> work = new List<orderinfo>();
            try
            {
                if (ord != null)
                {
                    while (ord.Read())
                    {
                        orderinfo ad = new orderinfo(int.Parse(ord[0].ToString()), ord[1].ToString(), ord[2].ToString(), ord[3].ToString(), Convert.ToDateTime(ord[4].ToString()), ord[5].ToString(), int.Parse(ord[6].ToString()), ord[7].ToString(),char.Parse(ord[8].ToString()));
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
    }
}
