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

namespace ceh_lab_inv.forms.accounts
{
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();
        functions.Account account = new functions.Account();
        functions.Duplicate duplicate = new functions.Duplicate();

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9 and backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCellphoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, backspace, plus sign, open and close parenthesis, and space
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 43 && e.KeyChar != 40 && e.KeyChar != 41 && e.KeyChar != 32))
            {
                e.Handled = true;
                return;
            }
            // Checks to make sure only 1 plus sign is allowed
            if (e.KeyChar == 43)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
            // Checks to make sure only 1 open parenthesis is allowed
            if (e.KeyChar == 40)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
            // Checks to make sure only 1 close parenthesis is allowed
            if (e.KeyChar == 41)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTelephoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, backspace, plus sign, open and close parenthesis, and space
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 43 && e.KeyChar != 40 && e.KeyChar != 41 && e.KeyChar != 32))
            {
                e.Handled = true;
                return;
            }
            // Checks to make sure only 1 plus sign is allowed
            if (e.KeyChar == 43)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
            // Checks to make sure only 1 open parenthesis is allowed
            if (e.KeyChar == 40)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
            // Checks to make sure only 1 close parenthesis is allowed
            if (e.KeyChar == 41)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            if(val.AccountProfilePicture != null)
            {
                MemoryStream ms = new MemoryStream(val.AccountProfilePicture);
                picProfile.Image = Image.FromStream(ms);
            }

            txtUsername.Text = val.AccountUsername;
            txtPassword.Text = val.AccountPassword;
            txtConfirmPassword.Text = val.AccountPassword;
            txtFirstName.Text = val.AccountFirstName;
            txtMiddleName.Text = val.AccountMiddleName;
            txtLastName.Text = val.AccountLastName;
            txtAge.Text = val.AccountAge.ToString();
            cmbGender.Text = val.AccountGender;
            txtAddress.Text = val.AccountAddress;
            dateBirthday.Value = val.AccountBirthday;
            txtCellphoneNumber.Text = val.AccountCellphoneNumber;
            txtTelephoneNumber.Text = val.AccountTelephoneNumber;
            txtEmail.Text = val.AccountEmail;
            cmbRole.Text = val.AccountRole;
            txtUsername.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("The username is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("The password is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("The confirm password is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("The password do not match!", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.ResetText();
                txtConfirmPassword.ResetText();
                txtPassword.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("The first name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("The last name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("The age is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAge.Focus();
            }
            else if (String.IsNullOrWhiteSpace(cmbGender.Text))
            {
                MessageBox.Show("The gender is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbGender.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("The address is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtCellphoneNumber.Text) && String.IsNullOrWhiteSpace(txtTelephoneNumber.Text) && String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("The contact information is required at least one (1)!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCellphoneNumber.Focus();
            }
            else if (String.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("The role is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbRole.Focus();
            }
            else if (duplicate.UsernameProceed(val.AccountPrimaryID, txtUsername.Text))
            {
                if (account.Update(val.AccountPrimaryID, txtUsername.Text.ToUpper(), txtPassword.Text, txtFirstName.Text.ToUpper(), txtMiddleName.Text.ToUpper(),
                    txtLastName.Text.ToUpper(), int.Parse(txtAge.Text), cmbGender.Text, txtAddress.Text.ToUpper(), dateBirthday.Value.Date, txtCellphoneNumber.Text,
                    txtTelephoneNumber.Text, txtEmail.Text, cmbRole.Text))
                {
                    MessageBox.Show("Account was successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update account!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (duplicate.Username(txtUsername.Text))
            {
                MessageBox.Show("Failed to update account, username is already taken!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.ResetText();
                txtUsername.Focus();
            }
            else if (account.Update(val.AccountPrimaryID, txtUsername.Text.ToUpper(), txtPassword.Text, txtFirstName.Text.ToUpper(), txtMiddleName.Text.ToUpper(),
                txtLastName.Text.ToUpper(), int.Parse(txtAge.Text), cmbGender.Text, txtAddress.Text.ToUpper(), dateBirthday.Value.Date, txtCellphoneNumber.Text,
                txtTelephoneNumber.Text, txtEmail.Text, cmbRole.Text))
            {
                MessageBox.Show("Account was successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update account!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            forms.accounts.frmList accounts_list = new forms.accounts.frmList();
            accounts_list.TopLevel = false;
            forms.dashboard.frmDashboard dashboard = (forms.dashboard.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlMain = (Panel)dashboard.Controls["pnlMain"];
            pnlMain.Controls.Add(accounts_list);
            accounts_list.Dock = DockStyle.Fill;
            accounts_list.Show();
            this.Close();
        }
    }
}
