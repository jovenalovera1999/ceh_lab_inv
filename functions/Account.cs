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
                        grid.Columns["username"].HeaderText = "USERNAME";
                        grid.Columns["CAST(AES_DECRYPT(password, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR)"].HeaderText = "PASSWORD";
                        grid.Columns["role"].HeaderText = "ROLE";
                        grid.Columns["DATE_FORMAT(ceh_lab_inv_db.accounts.date_created, '%m/%d/%y')"].HeaderText = "DATE CREATED";
                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading accounts: " + ex.ToString());
            }
        }
    }
}
