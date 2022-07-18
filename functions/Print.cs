using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ceh_lab_inv.functions
{
    internal class Print
    {
        components.Connection con = new components.Connection();
        components.Value val = new components.Value();

        public void LoadPrintSuppliesByDate(DateTime from, DateTime to)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@from", from);
                        cmd.Parameters.AddWithValue("@to", to);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading print supplies by date: " + ex.ToString());
            }
        }
    }
}
