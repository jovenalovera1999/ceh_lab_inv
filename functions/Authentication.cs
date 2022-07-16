using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ceh_lab_inv.functions
{
    internal class Authentication
    {
        components.Connection con = new components.Connection();
        components.Value val = new components.Value();

        public bool Login(string username, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL login(@username, @password);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.UserPrimaryID = dt.Rows[0].Field<int>("id");
                            val.UserProfilePicture = dt.Rows[0].Field<byte[]>("profile_picture");
                            val.UserFirstName = dt.Rows[0].Field<string>("first_name");
                            val.UserMiddleName = dt.Rows[0].Field<string>("middle_name");
                            val.UserLastName = dt.Rows[0].Field<string>("last_name");
                            val.UserGender = dt.Rows[0].Field<string>("gender");
                            val.UserAge = dt.Rows[0].Field<int>("age");
                            val.UserAddress = dt.Rows[0].Field<string>("address");
                            val.UserBirthday = dt.Rows[0].Field<DateTime>("birthday");
                            val.UserCellphoneNumber = dt.Rows[0].Field<string>("cellphone_number");
                            val.UserTelephoneNumber = dt.Rows[0].Field<string>("telephone_number");
                            val.UserEmail = dt.Rows[0].Field<string>("email");
                            val.UserUsername = dt.Rows[0].Field<string>("username");
                            val.UserPassword = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(password, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR)");
                            val.UserType = dt.Rows[0].Field<string>("user_type");
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
                Console.WriteLine("Error authenticating user: " + ex.ToString());
                return false;
            }
        }

        public bool Logout(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL logout(@id);";

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
                Console.WriteLine("Error unauthenticating user: " + ex.ToString());
                return false;
            }
        }
    }
}
