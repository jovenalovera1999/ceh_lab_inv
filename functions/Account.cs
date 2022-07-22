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
    }
}
