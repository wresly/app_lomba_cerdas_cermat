using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace app_lomba_cerdas_cermat.Classes
{
    internal class db
    {
        private static string server = "192.168.43.91";
        private static string user = "root";
        private static string pass = "godt123";
        private static string database = "cerdas_cermat";
        public static string connectionString = "";
        //"server=" + server + ";uid=" + user + ";pwd=" + pass + ";database=" + database
        public static MySqlConnection conn = new MySqlConnection(connectionString);
    }
}
