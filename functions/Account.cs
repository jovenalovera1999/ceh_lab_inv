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

        public void Load(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL account_load();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.ClearSelection();

                        grid.Columns["id"].Visible = false;
                        grid.Columns["first_name"].HeaderText = "FIRST NAME";
                        grid.Columns["middle_name"].HeaderText = "MIDDLE NAME";
                        grid.Columns["last_name"].HeaderText = "LAST NAME";
                        grid.Columns["age"].HeaderText = "AGE";
                        grid.Columns["gender"].HeaderText = "GENDER";
                        grid.Columns["role"].HeaderText = "ROLE";
                        grid.Columns["DATE_FORMAT(ceh_lab_inv_db.users.created_at, '%m/%d/%y')"].HeaderText = "CREATED AT";
                        grid.Columns["DATE_FORMAT(ceh_lab_inv_db.users.updated_at, '%m/%d/%y')"].HeaderText = "UPDATED AT";
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading accounts: " + ex.ToString());
            }
        }

        public bool Get(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = "CALL account_get(@id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            val.AccountPrimaryID = dt.Rows[0].Field<int>("id");
                            val.AccountProfilePicture = dt.Rows[0].Field<byte[]>("profile_picture");
                            val.AccountFirstName = dt.Rows[0].Field<string>("first_name");
                            val.AccountMiddleName = dt.Rows[0].Field<string>("middle_name");
                            val.AccountLastName = dt.Rows[0].Field<string>("last_name");
                            val.AccountAge = dt.Rows[0].Field<int>("age");
                            val.AccountGender = dt.Rows[0].Field<string>("gender");
                            val.AccountAddress = dt.Rows[0].Field<string>("address");
                            val.AccountBirthday = dt.Rows[0].Field<DateTime>("birthday");
                            val.AccountCellphoneNumber = dt.Rows[0].Field<string>("cellphone_number");
                            val.AccountTelephoneNumber = dt.Rows[0].Field<string>("telephone_number");
                            val.AccountEmail = dt.Rows[0].Field<string>("email");
                            val.AccountUsername = dt.Rows[0].Field<string>("username");
                            val.AccountPassword = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(password, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR)");
                            val.AccountRole = dt.Rows[0].Field<string>("role");
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

        public bool Update(int id, string username, string password, string first_name, string middle_name, string last_name, int age, string gender, string address,
            DateTime birthday, string cellphone_number, string telephone_number, string email, string role)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL account_update(@id, @username, @password, @first_name, @middle_name, @last_name, @age, @gender, @address, @birthday,
                                    @cellphone_number, @telephone_number, @email, @role);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@first_name", first_name);
                        cmd.Parameters.AddWithValue("@middle_name", middle_name);
                        cmd.Parameters.AddWithValue("@last_name", last_name);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@birthday", birthday);
                        cmd.Parameters.AddWithValue("@cellphone_number", cellphone_number);
                        cmd.Parameters.AddWithValue("@telephone_number", telephone_number);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@role", role);

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
                Console.WriteLine("Error updating account: " + ex.ToString());
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL account_delete(@id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count > 0)
                        {
                            val.AccountPrimaryID = dt.Rows[0].Field<int>("id");
                        }
                        else
                        {
                            connection.Close();
                            return false;
                        }
                    }

                    sql = @"CALL account_delete_1(@user_id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@user_id", val.AccountPrimaryID);

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
