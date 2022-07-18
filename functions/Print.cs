using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Microsoft.Reporting.WinForms;

namespace ceh_lab_inv.functions
{
    internal class Print
    {
        components.Connection con = new components.Connection();
        components.Value val = new components.Value();

        public void LoadPrintSuppliesByDate(DateTime from, DateTime to, ReportViewer report)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL load_print_supplies_by_date(@from, @to);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@from", from);
                        cmd.Parameters.AddWithValue("@to", to);

                        connection.Open();

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        report.LocalReport.DataSources.Clear();

                        ReportParameterCollection parameters = new ReportParameterCollection();
                        parameters.Add(new ReportParameter("pFrom", from.ToString("MMMM d, yyyy")));
                        parameters.Add(new ReportParameter("pTo", to.ToString("MMMM d, yyyy")));
                        report.LocalReport.SetParameters(parameters);

                        ReportDataSource source = new ReportDataSource("dtSupplies", dt);
                        report.LocalReport.DataSources.Add(source);
                        report.SetDisplayMode(DisplayMode.PrintLayout);
                        report.RefreshReport();

                        connection.Close();
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
