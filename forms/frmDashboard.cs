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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            forms.frmCreateAccount create_account = new forms.frmCreateAccount();
            create_account.TopLevel = false;
            pnlMain.Controls.Add(create_account);
            create_account.Dock = DockStyle.Fill;
            create_account.Show();
        }
    }
}
