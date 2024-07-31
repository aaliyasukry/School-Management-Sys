using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project__CSE_22._2___033_
{
    internal class cls_connection
    {
        const string cs = @"Server=localhost;userid=root;password=;database=bridgerton";
        public static MySqlConnection con = new MySqlConnection(cs);

        public static void Open_connection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }    
        }
        public static void Close_connection()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
