using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using HyperstarManagementSystem.BL;

namespace HyperstarManagementSystem.DL
{
    public class DataBaseHelper
    {
        private static String constring = "Server = localhost; Uid= root; Pwd =tayyab1075; Database = hyperstarfinal;";
        public static void ExecuteDML(string dml)
        {
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(dml, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static DataTable GetTable(string sql)
        {
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
