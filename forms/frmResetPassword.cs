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
    public partial class frmResetPassword : Form
    {
        public frmResetPassword()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();

        functions.Account account = new functions.Account();

        private void frmResetPassword_Load(object sender, EventArgs e)
        {
            txtNewPassword.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("Failed to Reset Password, Password is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPassword.Focus();
            }
            else if(String.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Failed to Reset Password, Confirm Password is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
            }
            else if(txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Failed to Reset Password, Password do not Match!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(account.ResetPassword(val.AccountPrimaryID, txtNewPassword.Text))
            {
                MessageBox.Show("Password has been Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to Reset Password!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
