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
    public partial class frmAccounts : Form
    {
        public frmAccounts()
        {
            InitializeComponent();
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            forms.frmCreateAccount create_account = new forms.frmCreateAccount();
            create_account.Show();
        }
    }
}
