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
                        grid.Columns["item"].HeaderText = "ITEM";
                        grid.Columns["brand"].HeaderText = "BRAND";
                        grid.Columns["supplier"].HeaderText = "SUPPLIER";
                        grid.Columns["CONCAT(FORMAT(quantity, 0), ' ', unit_of_quantity)"].HeaderText = "QUANTITY";
                        grid.Columns["CONCAT(FORMAT(qty, 0), ' ', unit_of_qty)"].HeaderText = "QTY";
                        grid.Columns["CONCAT('₱', FORMAT(CAST(AES_DECRYPT(unit_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), 2))"].HeaderText = "UNIT COST";
                        grid.Columns["CONCAT('₱', FORMAT(CAST(AES_DECRYPT(total_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), 2))"].HeaderText = "TOTAL COST";
                        grid.Columns["CONCAT(FORMAT(exp_rgt_quantity, 0), ' ', exp_rgt_unit)"].HeaderText = "EXP. RGT. QUANTITY";
                        grid.Columns["CONCAT('₱', FORMAT(CAST(AES_DECRYPT(exp_rgt_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), 2))"].HeaderText = "EXP. RGT. COST";
                        grid.Columns["DATE_FORMAT(expiration_date, '%m/%d/%y')"].HeaderText = "EXPIRATION DATE";
                        grid.Columns["CONCAT(DATEDIFF(expiration_date, NOW()), ' DAYS LEFT')"].HeaderText = "EXPIRED IN";
                        grid.Columns["DATE_FORMAT(date_created, '%m/%d/%y')"].HeaderText = "DATE ADDED";
                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading supplies: " + ex.ToString());
            }
        }

        public bool Get(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL supply_get(@id);";

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
                            val.SupplyPrimaryID = dt.Rows[0].Field<int>("id");
                            val.SupplyItem = dt.Rows[0].Field<string>("item");
                            val.SupplyBrand = dt.Rows[0].Field<string>("brand");
                            val.SupplySupplier = dt.Rows[0].Field<string>("supplier");
                            val.SupplyQuantity = dt.Rows[0].Field<int>("quantity");
                            val.SupplyUnitOfQuantity = dt.Rows[0].Field<string>("unit_of_quantity");
                            val.SupplyQty = dt.Rows[0].Field<int>("qty");
                            val.SupplyUnitOfQty = dt.Rows[0].Field<string>("unit_of_qty");
                            val.SupplyUnitCost = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(unit_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR)");
                            val.SupplyTotalCost = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(total_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR)");
                            val.SupplyExpRgtQuantity = dt.Rows[0].Field<int>("exp_rgt_quantity");
                            val.SupplyExpRgtUnit = dt.Rows[0].Field<string>("exp_rgt_unit");
                            val.SupplyExpRgtCost = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(exp_rgt_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR)");
                            val.SupplyExpirationDate = dt.Rows[0].Field<DateTime>("expiration_date");
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
                Console.WriteLine("Error getting supply: " + ex.ToString());
                return false;
            }
        }

        public bool Add(string item, string brand, string supplier, int quantity, string unit_of_quantity, int qty, string unit_of_qty, string unit_cost, string total_cost,
            DateTime expiration_date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL supply_add(@item, @brand, @supplier, @quantity, @unit_of_quantity, @qty, @unit_of_qty, @unit_cost, @total_cost, @expiration_date);";

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
                Console.WriteLine("Error adding supply: " + ex.ToString());
                return false;
            }
        }

        public bool Update(int id, string item, string brand, string supplier, int quantity, string unit_of_quantity, int qty, string unit_of_qty, string unit_cost, string total_cost,
            int exp_rgt_quantity, string exp_rgt_unit, string exp_rgt_cost, DateTime expiration_date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL supply_update(@id, @item, @brand, @supplier, @quantity, @unit_of_quantity, @qty, @unit_of_qty, @unit_cost, @total_cost, @exp_rgt_quantity,
                                    @exp_rgt_unit, @exp_rgt_cost, @expiration_date);";

                    using(MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@item", item);
                        cmd.Parameters.AddWithValue("@brand", brand);
                        cmd.Parameters.AddWithValue("@supplier", supplier);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@unit_of_quantity", unit_of_quantity);
                        cmd.Parameters.AddWithValue("@qty", qty);
                        cmd.Parameters.AddWithValue("@unit_of_qty", unit_of_qty);
                        cmd.Parameters.AddWithValue("@unit_cost", unit_cost);
                        cmd.Parameters.AddWithValue("@total_cost", total_cost);
                        cmd.Parameters.AddWithValue("@exp_rgt_quantity", exp_rgt_quantity);
                        cmd.Parameters.AddWithValue("@exp_rgt_unit", exp_rgt_unit);
                        cmd.Parameters.AddWithValue("@exp_rgt_cost", exp_rgt_cost);
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
                Console.WriteLine("Error updating supply: " + ex.ToString());
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"supply_delete(@id);";

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
                Console.WriteLine("Error deleting supply: " + ex.ToString());
                return false;
            }
        }
    }
}
