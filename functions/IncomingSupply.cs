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
                        grid.ClearSelection();

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
                        grid.Columns["DATE_FORMAT(date_created, '%W, %d %M %Y')"].HeaderText = "DATE ADDED";
                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading incoming supplies: " + ex.ToString());
            }
        }

        public bool Get(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL incoming_supply_get(@id);";

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
                            val.SupplyArrivalDate = dt.Rows[0].Field<DateTime>("arrival_date");
                            val.SupplyExpirationDate = dt.Rows[0].Field<DateTime>("expiration_date");
                            val.SupplyQuantity = dt.Rows[0].Field<string>("quantity");
                            val.SupplyItem = dt.Rows[0].Field<string>("item");
                            val.SupplyBrand = dt.Rows[0].Field<string>("brand");
                            val.SupplyQty = dt.Rows[0].Field<string>("qty");
                            val.SupplySupplier = dt.Rows[0].Field<string>("supplier");
                            val.SupplyUnitCost = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(unit_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR)");
                            val.SupplyNumberOfUnit = dt.Rows[0].Field<int>("number_of_unit");
                            val.SupplyTotalCost = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(total_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR)");
                            val.SupplyExpRgtCost = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(exp_rgt_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR)");
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

        public bool Add(DateTime arrival_date, DateTime expiration_date, string quantity, string item, string brand, string qty, string supplier, string unit_cost, int number_of_unit,
            string total_cost)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL incoming_supply_add(@arrival_date, @expiration_date, @quantity, @item, @brand, @qty, @supplier, @unit_cost, @number_of_unit,
                                    @total_cost, 'INCOMING');";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@arrival_date", arrival_date);
                        cmd.Parameters.AddWithValue("@expiration_date", expiration_date);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@item", item);
                        cmd.Parameters.AddWithValue("@brand", brand);
                        cmd.Parameters.AddWithValue("@qty", qty);
                        cmd.Parameters.AddWithValue("@supplier", supplier);
                        cmd.Parameters.AddWithValue("@unit_cost", unit_cost);
                        cmd.Parameters.AddWithValue("@number_of_unit", number_of_unit);
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
                Console.WriteLine("Error adding incoming supply: " + ex.ToString());
                return false;
            }
        }

        public bool Update(int id, DateTime arrival_date, DateTime expiration_date, string quantity, string item, string brand, string qty, string supplier, string unit_cost, int number_of_unit,
            string total_cost)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL incoming_supply_update(@id, @arrival_date, @expiration_date, @quantity, @item, @brand, @qty, @supplier, @unit_cost, @number_of_unit, @total_cost)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@arrival_date", arrival_date);
                        cmd.Parameters.AddWithValue("@expiration_date", expiration_date);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@item", item);
                        cmd.Parameters.AddWithValue("@brand", brand);
                        cmd.Parameters.AddWithValue("@qty", qty);
                        cmd.Parameters.AddWithValue("@supplier", supplier);
                        cmd.Parameters.AddWithValue("@unit_cost", unit_cost);
                        cmd.Parameters.AddWithValue("@number_of_unit", number_of_unit);
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
                Console.WriteLine("Error updating incoming supply: " + ex.ToString());
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL incoming_supply_delete(@id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

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
                Console.WriteLine("Error deleting incoming supply: " + ex.ToString());
                return false;
            }
        }
    }
}
