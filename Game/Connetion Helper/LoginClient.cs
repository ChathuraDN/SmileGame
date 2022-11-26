using Game.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Connetion_Helper
{
    class LoginClient
    {
        Response r = new Response();

        //Create Account Connection
        public Response createAccount(String name, String userName, String password, String confirmPassword) {
            try
            {
                DBClient.startConnection();
                string sql = "INSERT INTO Login(name,username,password,conpassword) VALUES ('" + name + "','" + userName + "','" + password + "','" + confirmPassword + "')";
                SqlCommand com = new SqlCommand(sql, DBClient.con);
                com.ExecuteNonQuery();
                DBClient.closeConnection();
                r.Status = true;
                r.Message = "User Created Successfully";
                return r;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        //Login connection
        public Response loginToAccount(String userName, String password)
        {
            try
            {
                DBClient.startConnection();
                String sql = "select * from Login where username = '" + userName + "' and password ='" + password + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, DBClient.con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    r.Status = true;
                    r.Message = "Loged in Successfully";
                }
                else
                {
                    r.Status = false;
                    r.Message = "Loging fail. Invalid user name or password!";
                }

                DBClient.closeConnection();
               
                return r;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
