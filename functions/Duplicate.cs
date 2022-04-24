using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ceh_lab_inv.functions
{
    internal class Duplicate
    {
        components.Connection con = new components.Connection();
        components.Value val = new components.Value();

        public bool Username(string username)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL duplicate_username(@username);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count > 0)
                        {
                            connection.Close();
                            return true;
                        }
                        else
                        {
                            connection.Close();
                            return false;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error checking duplicate username: " + ex.ToString());
                return false;
            }
        }

        public bool UsernameProceed(int id, string username)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL duplicate_username_proceed(@id, @username);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@username", username);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            connection.Close();
                            return true;
                        }
                        else
                        {
                            connection.Close();
                            return false;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error checking duplicate id and username: " + ex.ToString());
                return false;
            }
        }
    }
}
