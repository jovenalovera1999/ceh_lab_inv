using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

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
        functions.Supply supply = new functions.Supply();
        functions.Report report = new functions.Report();

        private void frmLayout_Load(object sender, EventArgs e)
        {
            supply.Load(gridSupplies);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "CAPIZ EMMANUEL HOSPITAL, Inc.";
            printer.SubTitle = "SUPPLIES";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "LIST OF SUPPLIES";
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(gridSupplies);
        }
    }
}
