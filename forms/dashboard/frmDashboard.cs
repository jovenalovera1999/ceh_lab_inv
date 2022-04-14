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
            btnIncomingSupplies.FillColor = Color.Green;
            btnCurrentSupplies.FillColor = Color.Green;
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

        private void btnIncomingSupplies_Click(object sender, EventArgs e)
        {
            btnDashboard.FillColor = Color.Green;
            btnIncomingSupplies.FillColor = Color.DarkGreen;
            btnCurrentSupplies.FillColor = Color.Green;
            btnCreateAccount.FillColor = Color.Green;
            btnProfile.FillColor = Color.Green;

            lblModuleName.Text = "LIST OF INCOMING SUPPLIES";

            pnlMain.Controls.Clear();
            forms.incoming_supplies.frmList incoming_supplies = new forms.incoming_supplies.frmList();
            incoming_supplies.TopLevel = false;
            pnlMain.Controls.Add(incoming_supplies);
            incoming_supplies.Dock = DockStyle.Fill;
            incoming_supplies.Show();
        }

        private void btnCurrentSupplies_Click(object sender, EventArgs e)
        {
            btnDashboard.FillColor = Color.Green;
            btnIncomingSupplies.FillColor = Color.Green;
            btnCurrentSupplies.FillColor = Color.DarkGreen;
            btnCreateAccount.FillColor = Color.Green;
            btnProfile.FillColor = Color.Green;

            lblModuleName.Text = "LIST OF CURRENT SUPPLIES";
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            btnDashboard.FillColor = Color.Green;
            btnIncomingSupplies.FillColor = Color.Green;
            btnCurrentSupplies.FillColor = Color.Green;
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
            btnIncomingSupplies.FillColor = Color.Green;
            btnCurrentSupplies.FillColor = Color.Green;
            btnCreateAccount.FillColor = Color.Green;
            btnProfile.FillColor = Color.DarkGreen;

            lblModuleName.Text = "PROFILE";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
