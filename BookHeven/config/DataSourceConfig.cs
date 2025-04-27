using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHeven.config
{
   public class DataSourceConfig {
        private static string connectionString = "Server=localhost;Port=3306;Database=bookhaven;Uid=root;Pwd=123456;";
        public static string role;
        public static MySqlConnection GetConnection() {
            return new MySqlConnection(connectionString);
        } 
    }
}
