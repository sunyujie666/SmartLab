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
    class EquipmentMapper
    {
        private static Connection connection = new Connection();
        public static List<equipment> getAllEquipment()
        {
            connection.Conn.Open();
            MySqlDataReader ord = connection.getmysqlcmd("select * from equipment ");
            List<equipment> work = new List<equipment>();
            try
            {
                if (ord != null)
                {
                    while (ord.Read())
                    {
                        equipment ad = new equipment(int.Parse(ord[0].ToString()), ord[1].ToString(), char.Parse(ord[2].ToString()), Convert.ToDateTime(ord[3].ToString()), ord[4].ToString(), ord[5].ToString(), ord[6].ToString(), ord[7].ToString(),ord[8].ToString());
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
        public static Boolean IntoEquipment(equipment equipment)
        {
            connection.Conn.Open();
            try
            {
                MySqlDataReader ord = connection.getmysqlcmd("insert into equipment (Eid,Ename,Emodel,Time,Port,E_brand,E_type,E_info,Adminid) values(" +"\""+equipment.Eid1+ "\",\"" +equipment.Ename1+ "\",\""+equipment.Emodel1+"\",\""+equipment.Time1+"\",\""+equipment.Port1+"\",\""+equipment.E_brand1+"\",\""+equipment.E_type1+"\",\""+equipment.E_info1+"\",\""+equipment.Adminid1+"\")");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            connection.Conn.Close();
            return true;
        }
        public static Boolean UpdateEquipment(equipment equipment)
        {
            connection.Conn.Open();
            try
            {
                MySqlDataReader ord = connection.getmysqlcmd("update equipment set Ename =" + equipment.Ename1 + "," + "Emode1=" + equipment.Emodel1 + "," + "Time=" + equipment.Time1 + "," + "Port=" + equipment.Port1 + "," + "E_brand=" + equipment.E_brand1 + "," + "E_type=" + equipment.E_type1 + "," + "E_info=" + equipment.E_info1 + "," + "Adminid=" + equipment.Adminid1 + "where Eid =" + equipment.Eid1);
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
