using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Society_Management_System
{
    class DbConnect
    {
        public MySqlConnection DatabaseConnect()
        {
            string connetionString = null;
            MySqlConnection connection;
            connetionString = @"Server=127.0.0.1;Port=3306;Uid=root;Pwd=;Database=societymanagement";
            connection = new MySqlConnection(connetionString);
            return connection;
        }
    }
}
