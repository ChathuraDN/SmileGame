using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Game.Connetion_Helper
{
    //DB Connection
    static class DBClient
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=CHATHURA\SQLEXPRESS01;Initial Catalog=Game;Integrated Security=True");

        public static void startConnection() {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void closeConnection() {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
