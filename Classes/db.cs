﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace app_lomba_cerdas_cermat.Classes
{
    internal class db
    {
        //private static string server = "192.168.119.46";
        //private static string user = "root";
        //private static string pass = "";
        //private static string database = "cerdas_cermat";

        public static int dbDelayTimer = 2;
        public static MySqlCommand cmd;
        public static MySqlDataReader reader;

        public static string connectionString = "";
        public static MySqlConnection conn = new MySqlConnection(connectionString);
    }
}
