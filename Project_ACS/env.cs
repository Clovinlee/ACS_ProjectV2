using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ACS
{
    class env
    {
        //ganti di sini untuk oracle masing masing
        private static string username = "mk";
        private static string password = "mk";
        static string oracle_version = "11g"; //diisi 11g atau 18c
       
        public static string oracle_connection_string()
        {
            switch (oracle_version)
            {
                case "11g":
                    return $"USER ID={username};DATA SOURCE=XE;PASSWORD={password}";
                default:
                    return $"USER ID={username};PASSWORD={password};DATA SOURCE=localhost:1521/XEPDB1;PERSIST SECURITY INFO=True"; 
            }
        }
    }
}
