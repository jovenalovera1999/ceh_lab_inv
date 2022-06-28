using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ceh_lab_inv.functions
{
    internal class Logout
    {
        components.Connection con = new components.Connection();
        components.Value val = new components.Value();

        public bool LogoutUser(int id)
        {
           try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL logout(@id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", val.UserPrimaryID);

                        connection.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();
                        connection.Close();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error logging out user: " + ex.ToString());
                return false;
            }
        }
    }
}
