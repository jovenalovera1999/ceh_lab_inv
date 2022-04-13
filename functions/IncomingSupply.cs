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
    internal class IncomingSupply
    {
        components.Connection con = new components.Connection();
        components.Value val = new components.Value();

        public void Load(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL incoming_supply_load();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;

                        grid.Columns["id"].Visible = false;
                        grid.Columns["DATE_FORMAT(expiration_date, '%W, %d %M %Y')"].HeaderText = "EXPIRATION DATE";
                        grid.Columns["CONCAT(DATEDIFF(expiration_date, NOW()), ' DAYS LEFT')"].HeaderText = "EXPIRED IN";
                        grid.Columns["quantity"].HeaderText = "QUANTITY";
                        grid.Columns["item"].HeaderText = "ITEM";
                        grid.Columns["brand"].HeaderText = "BRAND";
                        grid.Columns["qty"].HeaderText = "QTY";
                        grid.Columns["supplier"].HeaderText = "SUPPLIER";
                        grid.Columns["CAST(AES_DECRYPT(unit_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR)"].HeaderText = "UNIT COST";
                        grid.Columns["number_of_unit"].HeaderText = "NUMBER OF UNIT";
                        grid.Columns["CAST(AES_DECRYPT(total_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR)"].HeaderText = "TOTAL COST";
                        grid.Columns["CAST(AES_DECRYPT(exp_rgt_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR)"].HeaderText = "EXP. RGT. COST";
                        grid.Columns["status"].Visible = false;
                        grid.Columns["DATE_FORMAT(arrival_date, '%W, %d %M %Y')"].HeaderText = "ARRIVAL DATE";
                        grid.Columns["CONCAT(DATEDIFF(arrival_date, NOW()), ' DAYS LEFT')"].HeaderText = "ARRIVED IN";
                        grid.Columns["DATE_FORMAT(date_created, '%W, %d %M %Y')"].HeaderText = "Date Added";
                        connection.Close();

                        DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
                        btnUpdate.HeaderText = "ACTION";
                        btnUpdate.Text = "UPDATE";
                        btnUpdate.Name = "btnUpdate";
                        btnUpdate.UseColumnTextForButtonValue = true;
                        grid.Columns.Add(btnUpdate);

                        DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                        btnDelete.HeaderText = "";
                        btnDelete.Text = "DELETE";
                        btnDelete.Name = "btnDelete";
                        btnDelete.UseColumnTextForButtonValue = true;
                        grid.Columns.Add(btnDelete);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading incoming supplies: " + ex.ToString());
            }
        }
    }
}
