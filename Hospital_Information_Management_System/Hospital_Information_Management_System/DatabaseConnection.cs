using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hospital_Information_Management_System
{
    internal class DatabaseConnection
    {
        private MySqlConnection connection;
        public DatabaseConnection()
        {
            string connectionString = "Server = 127.0.0.1; Database = HospitalDB; Uid = root; Pwd = @Sus12345";
            connection = new MySqlConnection(connectionString);

        }

        public MySqlConnection Getconnection()
        {
            return connection;
        }
    }
}
