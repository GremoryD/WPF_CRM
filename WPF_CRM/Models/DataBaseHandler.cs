using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_CRM.Models
{
    public static class DataBaseHandler
    {

        public static void Connect()
        {
            string connectionString;
            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}", DataSetings.DBHost, 3306, DataSetings.DBUser, DataSetings.DBPassword,DataSetings.DBUser);
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open(); 

        }



    }
}
