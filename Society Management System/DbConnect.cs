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
            connetionString = @"server=localhost; port=3306 userid=root;password='';database=societymanagement";
            connection = new MySqlConnection(connetionString);
            return connection;
        }
    }
}
