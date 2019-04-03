using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace until
{
    class Connection
    {
        private String host;
        private String name;
        private String password;
        private String datebase;
        private MySqlConnection conn;

        public Connection()
        {
            this.host = "47.100.1.162";
            this.name = "gavin";
            this.password ="g1126ang";
            this.datebase = "smartlabs";
            try
            {
                this.conn = this.getmysqlcon(host, name, password, datebase);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error connecting to the server: " + ex.Message);
            }
        }
        public Connection(String host,String name,String password,String datebase)
        {
            this.host = host;
            this.name = name;
            this.password = password;
            this.datebase = datebase;
            try
            {
                this.conn = this.getmysqlcon(host, name, password, datebase);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error connecting to the server: " + ex.Message);
            }
        }

        public MySqlConnection Conn { get { return conn; } set { conn = value; } }//封装

        private MySqlConnection getmysqlcon(String host,String name,String password,String datebase)//数据库连接
        {
            string M_str_sqlcon = "server="+host+";user id="+name+";password="+password+";database="+datebase;
            MySqlConnection myCon = new MySqlConnection(M_str_sqlcon);
            return myCon;
        }

        public MySqlDataReader getmysqlcmd(String sql)//执行sql语句并返回MySqlDaraReader对象
        {
            try
            {
                MySqlCommand mysqlcmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = mysqlcmd.ExecuteReader();
                return rdr;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("001" + ex.Message);
                return null;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("003" + ex.Message);
                return null;
            }
        }

    }
}
