using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ceh_lab_inv.forms.incoming_supplies
{
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();
        functions.IncomingSupply incoming_supply = new functions.IncomingSupply();

        private void frmView_Load(object sender, EventArgs e)
        {
            incoming_supply.Load(gridIncomingSupplies);
        }
    }
}
