using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ceh_lab_inv.functions
{
    internal class Account
    {
        components.Connection con = new components.Connection();
        components.Value val = new components.Value();

        public bool Get(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"get_account(@id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        connection.Open();

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.AccountPrimaryID = dt.Rows[0].Field<int>("id");

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
                Console.WriteLine("Error getting account: " + ex.ToString());
                return false;
            }
        }

        public void Load(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL load_accounts();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        connection.Open();

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.Columns["id"].Visible = false;
                        grid.Columns["first_name"].HeaderText = "FIRST NAME";
                        grid.Columns["middle_name"].HeaderText = "MIDDLE NAME";
                        grid.Columns["last_name"].HeaderText = "LAST NAME";
                        grid.Columns["age"].HeaderText = "AGE";
                        grid.Columns["gender"].HeaderText = "GENDER";
                        grid.Columns["address"].HeaderText = "ADDRESS";
                        grid.Columns["user_type"].HeaderText = "USER TYPE";
                        grid.Columns["DATE_FORMAT(ceh_lab_inv_db.users.created_at, '%m/%d/%y')"].HeaderText = "CREATED AT";
                        grid.Columns["DATE_FORMAT(ceh_lab_inv_db.users.updated_at, '%m/%d/%y')"].HeaderText = "UPDATED AT";

                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading accounts: " + ex.ToString());
            }
        }

        public bool ResetPassword(int id, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL update_password(@id, @password);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@password", password);

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
                Console.WriteLine("Error updating password: " + ex.ToString());
                return false;
            }
        }

        public bool ChangeUserType(int id, string user_type)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL update_user_type(@id, @user_type);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@user_type", user_type);

                        connection.Open();

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();

                        connection.Close();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating user type: " + ex.ToString());
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL delete_account(@id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

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
                Console.WriteLine("Error deleting account: " + ex.ToString());
                return false;
            }
        }
    }
}
