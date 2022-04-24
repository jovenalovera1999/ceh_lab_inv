using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ceh_lab_inv.forms.accounts
{
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();
        functions.Account account = new functions.Account();

        private void frmList_Load(object sender, EventArgs e)
        {
            account.Load(gridAccounts);
        }

        private void gridAccounts_VisibleChanged(object sender, EventArgs e)
        {
            gridAccounts.ClearSelection();
        }
    }
}
