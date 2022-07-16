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
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL load_supplies();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.Columns["id"].Visible = false;
                        grid.Columns["item"].HeaderText = "ITEM";
                        grid.Columns["brand"].HeaderText = "BRAND";
                        grid.Columns["supplier"].HeaderText = "SUPPLIER";
                        grid.Columns["CONCAT(quantity, ' ', unit_of_quantity)"].HeaderText = "QUANTITY";
                        grid.Columns["CONCAT(qty, ' ', unit_of_qty)"].HeaderText = "QTY";
                        grid.Columns["CONCAT('₱', FORMAT(CAST(AES_DECRYPT(unit_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR), 2))"].HeaderText = "UNIT COST";
                        grid.Columns["CONCAT('₱', FORMAT(CAST(AES_DECRYPT(total_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR), 2))"].HeaderText = "TOTAL COST";
                        grid.Columns["CONCAT(exp_rgt_quantity, ' ', exp_rgt_unit)"].HeaderText = "EXP. RGT. QTY";
                        grid.Columns["CONCAT('₱', FORMAT(CAST(AES_DECRYPT(exp_rgt_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR), 2))"].HeaderText = "EXP. RGT. COST";
                        grid.Columns["DATE_FORMAT(expiration_date, '%m/%d/%y')"].HeaderText = "EXPIRATION DATE";
                        grid.Columns["CONCAT(DATEDIFF(expiration_date, NOW()), ' Days Left')"].HeaderText = "EXPIRED IN";
                        grid.Columns["DATE_FORMAT(created_at, '%m/%d/%y')"].HeaderText = "CREATED AT";
                        grid.Columns["DATE_FORMAT(updated_at, '%m/%d/%y')"].HeaderText = "UPDATED AT";
                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading supplies: " + ex.ToString());
            }
        }

        public bool AddWithDate(string item, string brand, string supplier, int quantity, string unit_of_quantity, int qty, string unit_of_qty,
            string unit_cost, string total_cost, DateTime expiration_date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL add_supply_with_date(@item, @brand, @supplier, @quantity, @unit_of_quantity, @qty, @unit_of_qty, @unit_cost,
                                    @total_cost, @expiration_date);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@item", item);
                        cmd.Parameters.AddWithValue("@brand", brand);
                        cmd.Parameters.AddWithValue("@supplier", supplier);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@unit_of_quantity", unit_of_quantity);
                        cmd.Parameters.AddWithValue("@qty", qty);
                        cmd.Parameters.AddWithValue("@unit_of_qty", unit_of_qty);
                        cmd.Parameters.AddWithValue("@unit_cost", unit_cost);
                        cmd.Parameters.AddWithValue("@total_cost", total_cost);
                        cmd.Parameters.AddWithValue("@expiration_date", expiration_date);

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
                Console.WriteLine("Error adding supply with date: " + ex.ToString());
                return false;
            }
        }

        public bool AddWithoutDate(string item, string brand, string supplier, int quantity, string unit_of_quantity, int qty, string unit_of_qty,
            string unit_cost, string total_cost)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL add_supply_without_date(@item, @brand, @supplier, @quantity, @unit_of_quantity, @qty, @unit_of_qty, @unit_cost,
                                    @total_cost);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@item", item);
                        cmd.Parameters.AddWithValue("@brand", brand);
                        cmd.Parameters.AddWithValue("@supplier", supplier);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@unit_of_quantity", unit_of_quantity);
                        cmd.Parameters.AddWithValue("@qty", qty);
                        cmd.Parameters.AddWithValue("@unit_of_qty", unit_of_qty);
                        cmd.Parameters.AddWithValue("@unit_cost", unit_cost);
                        cmd.Parameters.AddWithValue("@total_cost", total_cost);

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
                Console.WriteLine("Error adding supply without date: " + ex.ToString());
                return false;
            }
        }
    }
}
