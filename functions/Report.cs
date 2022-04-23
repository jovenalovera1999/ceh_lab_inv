using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ceh_lab_inv.functions
{
    class Report
    {
        components.Connection con = new components.Connection();
        components.Value val = new components.Value();

        //public void LoadSupplies(ReportViewer report)
        //{
            //using (MySqlConnection connection = new MySqlConnection(con.conString()))
            //{
                //string sql = @"CALL report_load_supplies();";

                //using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                //{
                    //connection.Open();
                    //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    //DataTable dt = new DataTable();
                    //dt.Clear();
                    //da.Fill(dt);

                    //report.LocalReport.DataSources.Clear();
                    //ReportDataSource source = new ReportDataSource("dtSupplies", dt);
                    //report.LocalReport.DataSources.Add(source);
                    //report.RefreshReport();
                    //connection.Close();
                //}
            //}
        //}
    }
}
