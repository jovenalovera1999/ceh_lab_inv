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
    internal class Supply
    {
        components.Connection con = new components.Connection();
        components.Value val = new components.Value();

        public void Load(DataGridView grid)
        {
            using (MySqlConnection connection = new MySqlConnection(con.conString()))
            {
                string sql = @"CALL supply_load();";

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
                    grid.Columns["DATE_FORMAT(expiration_date, '%m/%d/%y')"].HeaderText = "EXP. DATE";
                    grid.Columns["CONCAT(DATEDIFF(expiration_date, NOW()), ' ', 'DAYS LEFT')"].HeaderText = "EXPIRED IN";
                    grid.Columns["CONCAT(quantity, ' ', unit_of_quantity)"].HeaderText = "QUANTITY";
                    grid.Columns["item"].HeaderText = "ITEM";
                    grid.Columns["brand"].HeaderText = "BRAND";
                    grid.Columns["CONCAT(qty, ' ', unit_of_qty)"].HeaderText = "QTY";
                    grid.Columns["supplier"].HeaderText = "SUPPLIER";
                    grid.Columns["CAST(AES_DECRYPT(unit_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR)"].HeaderText = "UNIT COST";
                    grid.Columns["CAST(AES_DECRYPT(total_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR)"].HeaderText = "TOTAL COST";
                    grid.Columns["CONCAT(exp_rgt_quantity, ' ', exp_rgt_unit)"].HeaderText = "EXP. RGT. QTY";
                    grid.Columns["CAST(AES_DECRYPT(exp_rgt_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR)"].HeaderText = "EXP. RGT. COST";
                    grid.Columns["CAST(AES_DECRYPT(exp_rgt_total_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR)"].HeaderText = "EXP. RGT. TOTAL COST";
                    grid.Columns["DATE_FORMAT(date_created, '%m/%d/%y')"].HeaderText = "DATE ADDED";
                    connection.Close();
                }
            }
        }

        public bool Get()
        {
            try
            {
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error getting supply: " + ex.ToString());
                return false;
            }
        }

        public bool Add(string item, string brand, string supplier, int quantity, string unit_of_quantity, DateTime expiration_date, int qty, string unit_of_qty, string unit_cost, string total_cost)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL supply_add(@item, @brand, @supplier, @quantity, @unit_of_quantity, @expiration_date, @qty, @unit_of_qty, @unit_cost, @total_cost);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@item", item);
                        cmd.Parameters.AddWithValue("@brand", brand);
                        cmd.Parameters.AddWithValue("@supplier", supplier);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@unit_of_quantity", unit_of_quantity);
                        cmd.Parameters.AddWithValue("@expiration_date", expiration_date);
                        cmd.Parameters.AddWithValue("@qty", qty);
                        cmd.Parameters.AddWithValue("@unit_of_qty", unit_of_qty);
                        cmd.Parameters.AddWithValue("@unit_cost", unit_cost);
                        cmd.Parameters.AddWithValue("@total_cost", total_cost);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                        connection.Close();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error adding supply: " + ex.ToString());
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error updating supply: " + ex.ToString());
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error deleting supply: " + ex.ToString());
                return false;
            }
        }
    }
}
