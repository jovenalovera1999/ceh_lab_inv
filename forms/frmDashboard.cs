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

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();
        functions.Logout logout = new functions.Logout();

        void ShowHome()
        {
            pnlMain.Controls.Clear();
            forms.frmHome home = new forms.frmHome();
            home.TopLevel = false;
            pnlMain.Controls.Add(home);
            home.Dock = DockStyle.Fill;
            home.Show();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            if(val.UserRole != "Administrator")
            {
                btnAccounts.Visible = false;
            }
            ShowHome();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowHome();
        }

        private void btnSupplies_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            forms.frmSupplies supplies = new forms.frmSupplies();
            supplies.TopLevel = false;
            pnlMain.Controls.Add(supplies);
            supplies.Dock = DockStyle.Fill;
            supplies.Show();
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

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            forms.frmAccounts accounts = new forms.frmAccounts();
            accounts.TopLevel = false;
            pnlMain.Controls.Add(accounts);
            accounts.Dock = DockStyle.Fill;
            accounts.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            forms.frmProfile profile = new forms.frmProfile();
            profile.TopLevel = false;
            pnlMain.Controls.Add(profile);
            profile.Dock = DockStyle.Fill;
            profile.Show();
        }

        private void btnSwitchAccount_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Switch Account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(logout.LogoutUser(val.UserPrimaryID))
                {
                    forms.frmLogin login = new forms.frmLogin();
                    login.Show();
                    this.Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(logout.LogoutUser(val.UserPrimaryID))
                {
                    Application.OpenForms["frmLogin"].Close();
                    this.Close();
                }
            }
        }
    }
}
