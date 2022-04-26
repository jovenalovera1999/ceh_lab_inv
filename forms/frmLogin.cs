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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();
        functions.Login login = new functions.Login();

        void Login()
        {
            if (String.IsNullOrWhiteSpace(txtUsername.Text) && String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("The username and password are required!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("The username is required!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("The password is required!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else if (login.UserAuthentication(txtUsername.Text.ToUpper(), txtPassword.Text))
            {
                forms.dashboard.frmDashboard dashboard = new forms.dashboard.frmDashboard();
                dashboard.Show();
                forms.dashboard.frmLayout layout = new forms.dashboard.frmLayout();
                layout.TopLevel = false;
                forms.dashboard.frmDashboard dashboard_1 = (forms.dashboard.frmDashboard)Application.OpenForms["frmDashboard"];
                Panel pnlMain = (Panel)dashboard_1.Controls["pnlMain"];
                pnlMain.Controls.Add(layout);
                layout.Dock = DockStyle.Fill;
                layout.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your username and password do not match the record!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.ResetText();
                txtPassword.ResetText();
                txtUsername.Focus();
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Login();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Login();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.OpenForms["frmLogin"].Close();
            this.Close();
        }
    }
}
