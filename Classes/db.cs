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
        private static string server = "localhost";
        private static string user = "root";
        private static string pass = "";
        private static string database = "cerdas_cermat";
        public static MySqlConnection conn = new MySqlConnection("server=" + server + ";uid=" + user + ";pwd=" + pass + ";database=" + database);
    }
}
