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
    class PictureMapper
    {
        private static Connection connection = new Connection();
        public static List<picture> getallPicture()
        {
            connection.Conn.Open();
            MySqlDataReader ord = connection.getmysqlcmd("select * from picture");
            List<picture> work = new List<picture>();
            try
            {
                if (ord != null)
                {
                    while (ord.Read())
                    {
                        picture pic = new picture(int.Parse(ord[0].ToString()),char.Parse(ord[1].ToString()),ord[2].ToString());
                        work.Add(pic);
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
        public static List<picture> getAdminbyPsubject(string Type)
        { 
            connection.Conn.Open();
            MySqlDataReader ord = connection.getmysqlcmd("select * from picture where Type =" + Type);
            List<picture> work = new List<picture>();
            try
            {
                if (ord != null)
                {
                    while (ord.Read())
                    {
                        picture pic = new picture(int.Parse(ord[0].ToString()), char.Parse(ord[1].ToString()), ord[2].ToString());
                        work.Add(pic);
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
    
    
        
        public static Boolean updatePicture(String Picture_url, String Type)
        { 
            connection.Conn.Open();
            try
            {   
                MySqlDataReader ord = connection.getmysqlcmd("insert into picture (Type,Picture_url) values(" + Type + "," + Picture_url + ")");
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
        public static Boolean setPictureType(int pid, String type)
        { 
            connection.Conn.Open();
            try
            {   
                MySqlDataReader ord = connection.getmysqlcmd("update picture set Type = " + type + " where pid = "  + pid + ")");
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
        public static Boolean deletePicture(int pid)
        { 
            connection.Conn.Open();
            try
            {   
                MySqlDataReader ord = connection.getmysqlcmd("delete from picture where pid = "  + pid + ")");
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
