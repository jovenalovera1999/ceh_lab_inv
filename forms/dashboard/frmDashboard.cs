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

namespace ceh_lab_inv.forms.dashboard
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(val.UserProfilePicture.ToString()))
            {
                MemoryStream ms = new MemoryStream(val.UserProfilePicture);
                picProfile.Image = Image.FromStream(ms);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnDashboard.FillColor = Color.DarkGreen;
            btnSupplies.FillColor = Color.Green;
            btnCreateAccount.FillColor = Color.Green;
            btnProfile.FillColor = Color.Green;

            lblModuleName.Text = "DASHBOARD";

            pnlMain.Controls.Clear();
            forms.dashboard.frmLayout layout = new forms.dashboard.frmLayout();
            layout.TopLevel = false;
            pnlMain.Controls.Add(layout);
            layout.Dock = DockStyle.Fill;
            layout.Show();
        }

        private void btnSupplies_Click(object sender, EventArgs e)
        {
            btnDashboard.FillColor = Color.Green;
            btnSupplies.FillColor = Color.DarkGreen;
            btnCreateAccount.FillColor = Color.Green;
            btnProfile.FillColor = Color.Green;

            lblModuleName.Text = "LIST OF SUPPLIES";

            pnlMain.Controls.Clear();
            forms.supplies.frmList supplies_list = new forms.supplies.frmList();
            supplies_list.TopLevel = false;
            pnlMain.Controls.Add(supplies_list);
            supplies_list.Dock = DockStyle.Fill;
            supplies_list.Show();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            btnDashboard.FillColor = Color.Green;
            btnSupplies.FillColor = Color.Green;
            btnCreateAccount.FillColor = Color.DarkGreen;
            btnProfile.FillColor = Color.Green;

            lblModuleName.Text = "CREATE ACCOUNT";

            pnlMain.Controls.Clear();
            forms.users.frmAdd users_add = new forms.users.frmAdd();
            users_add.TopLevel = false;
            pnlMain.Controls.Add(users_add);
            users_add.Dock = DockStyle.Fill;
            users_add.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            btnDashboard.FillColor = Color.Green;
            btnSupplies.FillColor = Color.Green;
            btnCreateAccount.FillColor = Color.Green;
            btnProfile.FillColor = Color.DarkGreen;

            lblModuleName.Text = "PROFILE";

            pnlMain.Controls.Clear();
            forms.users.frmView users_view = new forms.users.frmView();
            users_view.TopLevel = false;
            pnlMain.Controls.Add(users_view);
            users_view.Dock = DockStyle.Fill;
            users_view.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                forms.frmLogin login = new forms.frmLogin();
                login.Show();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["frmLogin"].Close();
        }
    }
}
