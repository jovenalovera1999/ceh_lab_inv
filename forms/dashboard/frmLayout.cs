using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ceh_lab_inv.forms.dashboard
{
    public partial class frmLayout : Form
    {
        public frmLayout()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();
        functions.Report report = new functions.Report();
        functions.Count count = new functions.Count();

        private void frmLayout_Load(object sender, EventArgs e)
        {
            dateFrom.Value = DateTime.Now;
            dateTo.Value = DateTime.Now;
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            count.SuppliesByDate(dateFrom.Value, dateTo.Value);
            lblTotalSupplies.Text = val.CountSupplies;
            report.LoadSuppliesByDate(dateFrom.Value, dateTo.Value, rprtSupplies);
        }
    }
}
