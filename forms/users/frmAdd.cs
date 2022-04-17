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

namespace ceh_lab_inv.forms.users
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();
        functions.User user = new functions.User();
        functions.Duplicate duplicate = new functions.Duplicate();

        void Reset()
        {
            imgLocation = null;
            picProfile.ImageLocation = null;
            picProfile.Image = null;
            txtUsername.ResetText();
            txtPassword.ResetText();
            txtConfirmPassword.ResetText();
            txtFirstName.ResetText();
            txtMiddleName.ResetText();
            txtLastName.ResetText();
            txtAge.ResetText();
            cmbGender.Text = null;
            txtAddress.ResetText();
            txtCellphoneNumber.ResetText();
            txtTelephoneNumber.ResetText();
            txtEmail.ResetText();
            cmbRole.Text = null;
            txtUsername.Focus();
        }

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

        private void frmAdd_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            dateBirthday.Value = DateTime.Now;
        }

        string imgLocation = "";
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All files(*.*)|*.*|PNG files(*.png)|*.png|JPG files(*.jpg)|*.jpg";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                picProfile.ImageLocation = imgLocation;
            }
            txtUsername.Focus();
        }

        private void btnRemovePhoto_Click(object sender, EventArgs e)
        {
            imgLocation = null;
            picProfile.ImageLocation = null;
            picProfile.Image = null;
            txtUsername.Focus();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if(duplicate.Username(txtUsername.Text))
            {
                MessageBox.Show("The username is already taken!", "Already Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.ResetText();
                txtUsername.Focus();
            }
            else if(String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("The username is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if(String.IsNullOrWhiteSpace(txtPassword.Text))
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
            else if(String.IsNullOrWhiteSpace(txtFirstName.Text))
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
            else if (String.IsNullOrWhiteSpace(txtCellphoneNumber.Text) || String.IsNullOrWhiteSpace(txtTelephoneNumber.Text) || String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("The contact information is required at least one (1)!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCellphoneNumber.Focus();
            }
            else if (String.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("The role is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbRole.Focus();
            }
            else if(String.IsNullOrWhiteSpace(imgLocation))
            {
                if (user.Add(null, txtUsername.Text.ToUpper(), txtPassword.Text, txtFirstName.Text.ToUpper(), txtMiddleName.Text.ToUpper(), txtLastName.Text.ToUpper(),
                    int.Parse(txtAge.Text), cmbGender.Text, txtAddress.Text.ToUpper(), dateBirthday.Value.Date, txtCellphoneNumber.Text, txtTelephoneNumber.Text, txtEmail.Text, cmbRole.Text))
                {
                    MessageBox.Show("Account successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Failed to create account!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                byte[] profile_picture = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                profile_picture = br.ReadBytes((int)fs.Length);

                if (user.Add(profile_picture, txtUsername.Text.ToUpper(), txtPassword.Text, txtFirstName.Text.ToUpper(), txtMiddleName.Text.ToUpper(), txtLastName.Text.ToUpper(),
                    int.Parse(txtAge.Text), cmbGender.Text, txtAddress.Text.ToUpper(), dateBirthday.Value.Date, txtCellphoneNumber.Text, txtTelephoneNumber.Text, txtEmail.Text, cmbRole.Text))
                {
                    MessageBox.Show("Account successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Failed to create account!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
