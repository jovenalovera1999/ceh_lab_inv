using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ceh_lab_inv.functions
{
    internal class Login
    {
        components.Connection con = new components.Connection();
        components.Value val = new components.Value();

        public bool UserAuthentication(string username, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = "CALL login(@username, @password);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count > 0)
                        {
                            val.UserPrimaryID = dt.Rows[0].Field<int>("id");
                            val.UserProfilePicture = dt.Rows[0].Field<byte[]>("profile_picture");
                            val.UserFirstName = dt.Rows[0].Field<string>("first_name");
                            val.UserMiddleName = dt.Rows[0].Field<string>("middle_name");
                            val.UserLastName = dt.Rows[0].Field<string>("last_name");
                            val.UserAge = dt.Rows[0].Field<int>("age");
                            val.UserGender = dt.Rows[0].Field<string>("gender");
                            val.UserAddress = dt.Rows[0].Field<string>("address");
                            val.UserCellphoneNumber = dt.Rows[0].Field<string>("cellphone_number");
                            val.UserTelephoneNumber = dt.Rows[0].Field<string>("telephone_number");
                            val.UserEmail = dt.Rows[0].Field<string>("email");
                            val.UserUsername = dt.Rows[0].Field<string>("username");
                            val.UserPassword = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(password, 'J0V3NCUT3GW4P0P3R0J0KEL4NG09434071429') AS CHAR)");
                            val.UserRole = dt.Rows[0].Field<string>("role");
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
            catch (Exception ex)
            {
                Console.WriteLine("Error authenticating user: " + ex.ToString());
                return false;
            }
        }
    }
}
