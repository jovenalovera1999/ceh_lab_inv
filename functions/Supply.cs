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

        MySqlDataAdapter da;
        DataSet ds;

        int start_record;
        const int max_record = 20;

        public bool Get(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL get_supply(@id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        connection.Open();

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.SupplyPrimaryID = dt.Rows[0].Field<int>("id");
                            val.SupplyItem = dt.Rows[0].Field<string>("item");
                            val.SupplyBrand = dt.Rows[0].Field<string>("brand");
                            val.SupplySupplier = dt.Rows[0].Field<string>("supplier");
                            val.SupplyQuantity = dt.Rows[0].Field<int>("quantity");
                            val.SupplyUnitOfQuantity = dt.Rows[0].Field<string>("unit_of_quantity");
                            val.SupplyQty = dt.Rows[0].Field<int>("qty");
                            val.SupplyUnitOfQty = dt.Rows[0].Field<string>("unit_of_qty");
                            val.SupplyUnitCost = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(unit_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR)");
                            val.SupplyTotalCost = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(total_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR)");
                            val.SupplyExpRgtQuantity = dt.Rows[0].Field<int?>("exp_rgt_quantity");
                            val.SupplyExpRgtUnit = dt.Rows[0].Field<string>("exp_rgt_unit");
                            val.SupplyExpRgtCost = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(exp_rgt_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR)");
                            val.SupplyExpirationDate = dt.Rows[0].Field<DateTime?>("expiration_date");

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

                        da = new MySqlDataAdapter(cmd);
                        ds = new DataSet();

                        ds.Clear();
                        da.Fill(ds, start_record, max_record, "supplies");

                        grid.DataSource = ds;
                        grid.DataMember = "supplies";

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

                        val.IsSupplies = true;

                        val.IsSuppliesBySearch = false;
                        val.IsTrash = false;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading supplies: " + ex.ToString());
            }
        }

        public void LoadBySearch(string keyword, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL load_supplies_by_date(@keyword);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@keyword", string.Format("%{0}%", keyword));

                        connection.Open();

                        da = new MySqlDataAdapter(cmd);
                        ds = new DataSet();

                        ds.Clear();
                        da.Fill(ds, start_record, max_record, "supplies");

                        grid.DataSource = ds;
                        grid.DataMember = "supplies";

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

                        val.IsSuppliesBySearch = true;

                        val.IsSupplies = false;
                        val.IsTrash = false;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading supplies by date: " + ex.ToString());
            }
        }

        public void LoadTrash(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL load_trash();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        connection.Open();

                        da = new MySqlDataAdapter(cmd);
                        ds = new DataSet();

                        ds.Clear();
                        da.Fill(ds, start_record, max_record, "supplies");

                        grid.DataSource = ds;
                        grid.DataMember = "supplies";

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

                        val.IsTrash = true;

                        val.IsSupplies = false;
                        val.IsSuppliesBySearch = false;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading trash: " + ex.ToString());
            }
        }

        public void NextPage()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    connection.Open();

                    start_record += max_record;

                    if (val.IsSupplies == true && val.IsSuppliesBySearch == false && val.IsTrash == false)
                    {
                        if (start_record >= int.Parse(val.CountSupplies))
                        {
                            start_record = int.Parse(val.CountSupplies) - max_record;
                        }
                    }
                    else if (val.IsSupplies == false && val.IsSuppliesBySearch == true && val.IsTrash == false)
                    {
                        if (start_record >= int.Parse(val.CountSuppliesBySearch))
                        {
                            start_record = int.Parse(val.CountSuppliesBySearch) - max_record;
                        }
                    }
                    else
                    {
                        if (start_record >= int.Parse(val.CountSuppliesBySearch))
                        {
                            start_record = int.Parse(val.CountTrash) - max_record;
                        }
                    }

                    ds.Clear();
                    da.Fill(ds, start_record, max_record, "supplies");

                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error next paging: " + ex.ToString());
            }
        }

        public void PreviousPage()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    connection.Open();

                    start_record -= max_record;
                    if (start_record <= 0)
                    {
                        start_record = 0;
                    }

                    ds.Clear();
                    da.Fill(ds, start_record, max_record, "supplies");

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error previous paging: " + ex.ToString());
            }
        }

        public bool AddWithExpirationDate(string item, string brand, string supplier, int quantity, string unit_of_quantity, int qty, string unit_of_qty,
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

        public bool AddWithoutExpirationDate(string item, string brand, string supplier, int quantity, string unit_of_quantity, int qty, string unit_of_qty,
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

        public bool UpdateWithExpirationDate(int id, string item, string brand, string supplier, int quantity, string unit_of_quantity, int qty,
            string unit_of_qty, string unit_cost, string total_cost, DateTime expiration_date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL update_supply_with_expiration_date(@id, @item, @brand, @supplier, @quantity, @unit_of_quantity,
                                    @qty, @unit_of_qty, @unit_cost, @total_cost, @expiration_date);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
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
                Console.WriteLine("Error updating supply with expiration date: " + ex.ToString());
                return false;
            }
        }

        public bool UpdateWithoutExpirationDate(int id, string item, string brand, string supplier, int quantity, string unit_of_quantity, int qty,
            string unit_of_qty, string unit_cost, string total_cost)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL update_supply_without_expiration_date(@id, @item, @brand, @supplier, @quantity, @unit_of_quantity,
                                    @qty, @unit_of_qty, @unit_cost, @total_cost);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
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
                Console.WriteLine("Error updating supply without expiration date: " + ex.ToString());
                return false;
            }
        }

        public bool UpdateRgt(int id, int exp_rgt_quantity, string exp_rgt_unit, string exp_rgt_cost)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL update_supply_rgt(@id, @exp_rgt_quantity, @exp_rgt_unit, @exp_rgt_cost);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@exp_rgt_quantity", exp_rgt_quantity);
                        cmd.Parameters.AddWithValue("@exp_rgt_unit", exp_rgt_unit);
                        cmd.Parameters.AddWithValue("@exp_rgt_cost", exp_rgt_cost);

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
                Console.WriteLine("Error updating supply rgt: " + ex.ToString());
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL delete_supply(@id);";

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
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting supply: " + ex.ToString());
                return false;
            }
        }
    }
}
