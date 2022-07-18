using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ceh_lab_inv.forms
{
    public partial class frmPrint : Form
    {
        public frmPrint()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();

        functions.Print print = new functions.Print();

        private void frmPrint_Load(object sender, EventArgs e)
        {
            this.SetBounds(Screen.PrimaryScreen.WorkingArea.Left, Screen.PrimaryScreen.WorkingArea.Top, Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height);

            dateFrom.Value = DateTime.Now;
            dateTo.Value = DateTime.Now;
        }

        private void dateFrom_onValueChanged(object sender, EventArgs e)
        {
            print.LoadPrintSuppliesByDate(dateFrom.Value.Date, dateTo.Value.Date, rprtSupplies);
        }

        private void dateTo_onValueChanged(object sender, EventArgs e)
        {
            print.LoadPrintSuppliesByDate(dateFrom.Value.Date, dateTo.Value.Date, rprtSupplies);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
