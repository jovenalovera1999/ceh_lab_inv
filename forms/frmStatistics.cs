using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ceh_lab_inv.forms
{
    public partial class frmStatistics : Form
    {
        public frmStatistics()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();

        functions.Count count = new functions.Count();
        functions.Sum sum = new functions.Sum();

        void Count()
        {
            count.SuppliesWithDate(dateFrom.Value.Date, dateTo.Value.Date);
            count.TrashWithDate(dateFrom.Value.Date, dateTo.Value.Date);

            if(String.IsNullOrWhiteSpace(val.CountSuppliesWithDate))
            {
                lblTotalSupplies.Text = "0";
            }
            else
            {
                lblTotalSupplies.Text = val.CountSuppliesWithDate;
            }

            if (String.IsNullOrWhiteSpace(val.CountTrashWithDate))
            {
                lblTotalTrash.Text = "0";
            }
            else
            {
                lblTotalTrash.Text = val.CountTrashWithDate;
            }
        }

        void Sum()
        {
            sum.SumTotalCost(dateFrom.Value.Date, dateTo.Value.Date);
            sum.SumTotalExpRgtCost(dateFrom.Value.Date, dateTo.Value.Date);

            if(String.IsNullOrWhiteSpace(val.SumTotalCost))
            {
                lblTotalCost.Text = "0";
            }
            else
            {
                lblTotalCost.Text = val.SumTotalCost;
            }

            if(String.IsNullOrWhiteSpace(val.SumTotalExpRgtCost))
            {
                lblTotalExpRgtCost.Text = "0";
            }
            else
            {
                lblTotalExpRgtCost.Text = val.SumTotalExpRgtCost;
            }
        }

        void LoadCharts()
        {
            foreach (var series_column in chartColumn.Series)
            {
                series_column.Points.Clear();
            }

            foreach (var series_pie in chartPie.Series)
            {
                series_pie.Points.Clear();
            }

            foreach (var series_funnel in chartFunnel.Series)
            {
                series_funnel.Points.Clear();
            }

            chartColumn.Series[0].Points.AddXY("Supplies", lblTotalSupplies.Text);
            chartColumn.Series[0].Points.AddXY("Trash", lblTotalTrash.Text);

            chartPie.Series[0].Points.AddXY("Total Cost", lblTotalCost.Text);
            chartPie.Series[0].Points.AddXY("Total Exp. Rgt. Cost", lblTotalExpRgtCost.Text);

            chartFunnel.Series[0].Points.AddXY("Supplies", lblTotalSupplies.Text);
            chartFunnel.Series[0].Points.AddXY("Trash", lblTotalTrash.Text);
            chartFunnel.Series[0].Points.AddXY("Total Cost", lblTotalCost.Text);
            chartFunnel.Series[0].Points.AddXY("Total Exp. Rgt. Cost", lblTotalExpRgtCost.Text);
        }

        private void frmStatistics_Load(object sender, EventArgs e)
        {
            if(val.UserProfilePicture != null)
            {
                MemoryStream ms = new MemoryStream(val.UserProfilePicture);
                picProfile.Image = Image.FromStream(ms);
            }

            lblFullName.Text = val.UserFullName;
            lblUserType.Text = val.UserType;

            dateFrom.Value = DateTime.Now;
            dateTo.Value = DateTime.Now;

            Count();
            Sum();
            LoadCharts();
        }

        private void dateFrom_onValueChanged(object sender, EventArgs e)
        {
            Count();
            Sum();
            LoadCharts();
        }

        private void dateTo_onValueChanged(object sender, EventArgs e)
        {
            Count();
            Sum();
            LoadCharts();
        }
    }
}
