using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerProfiles
{
    public class MySQL
    {
        MySqlConnectionStringBuilder builder;
        public MySQL()
        {
            builder = new MySqlConnectionStringBuilder()
            {
                UserID = userName,
                Password = password,
                Server = serverName,
                Database = dbName,
                SslMode = MySqlSslMode.Required,
                Pooling = false
            };
        }
        public MySQL(string serverName, string userName, string dbName, string port, string password)
        {
            builder = new MySqlConnectionStringBuilder()
            {
                UserID = userName,
                Password = password,
                Server = serverName,
                Database = dbName,
                SslMode = MySqlSslMode.Required,
                Pooling = false
            };
        }
        public DataTable GetDataTableSQL(string sql)
        {
            DataTable dt = new DataTable();
            using (var connection = new MySqlConnection(builder.ConnectionString))
            {
                connection.Open();
                MySqlCommand sqlCom = new MySqlCommand(sql, connection);
                sqlCom.ExecuteNonQuery();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCom);
                dataAdapter.Fill(dt);
                connection.Close();
            }
            return dt;
        }
        public long InsertSQL(string SQL)
        {
            using (var connection = new MySqlConnection(builder.ConnectionString))
            {
                connection.Open();
                MySqlCommand sqlCom = new MySqlCommand(SQL, connection);
                sqlCom.ExecuteNonQuery();
                connection.Close();
                return sqlCom.LastInsertedId;
            }
        }
        public void SendSQL(string sql)
        {
            using (var connection = new MySqlConnection(builder.ConnectionString))
            {
                connection.Open();
                MySqlCommand sqlCom = new MySqlCommand(sql, connection);
                sqlCom.ExecuteNonQuery();
                connection.Close();
            }
        }
        //private string serverName = "localhost"; // Адрес сервера (для локальной базы пишите "localhost")
        //private string userName = "root"; // Имя пользователя
        //private string dbName = "zabbix"; //Имя базы данных
        //private string port = "3306"; // Порт для подключения
        //private string password = ""; // Пароль для подключения

        private string serverName = "astf3-stp5"; // Адрес сервера (для локальной базы пишите "localhost")
        private string userName = "zabbix"; // Имя пользователя
        private string dbName = "clicker"; //Имя базы данных
        private string password = "Ussd1801"; // Пароль для подключения
        public void WaitConnectToBD()
        {
            Console.WriteLine("Wait connection BD.");
            //while (true)
            //{
            //    if (Zabbix.Ping(serverName))
            //    {
            //        Console.WriteLine("Connection"); break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error connection BD. \nWait 5 sec.");
            //        Thread.Sleep(5000);
            //    }
            //}
        }
    }
}
