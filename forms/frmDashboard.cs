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

        functions.Authentication authentication = new functions.Authentication();

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            this.SetBounds(Screen.PrimaryScreen.WorkingArea.Left, Screen.PrimaryScreen.WorkingArea.Top, Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height);
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

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            forms.frmAccounts accounts = new frmAccounts();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(authentication.Logout(val.UserPrimaryID))
                {
                    Application.Exit();
                }
            }
        }

        private void btnSwitchAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Switch Account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (authentication.Logout(val.UserPrimaryID))
                {
                    forms.frmLogin login = new forms.frmLogin();
                    login.Show();
                    this.Close();
                }
            }
        }
    }
}
