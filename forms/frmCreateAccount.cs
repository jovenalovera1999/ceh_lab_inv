using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace ceh_lab_inv.forms
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();
        functions.User user = new functions.User();
        functions.Duplicate duplicate = new functions.Duplicate();

        TextInfo text_info = new CultureInfo("en-US", false).TextInfo;

        void Reset()
        {
            txtUsername.ResetText();
            txtPassword.ResetText();
            txtConfirmPassword.ResetText();
            txtFirstName.ResetText();
            txtMiddleName.ResetText();
            txtLastName.ResetText();
            cmbGender.Text = null;
            cmbAge.Text = null;
            txtAddress.ResetText();
            dateBirthday.Value = DateTime.Now;
            txtCellphoneNumber.ResetText();
            txtTelephoneNumber.ResetText();
            txtEmail.ResetText();
            cmbUserTypeOrRole.Text = null;
            txtUsername.Focus();
        }

        void RemoveImage()
        {
            imgLocation = null;
            picProfilePicture.ImageLocation = null;
            picProfilePicture.Image = null;
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

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 200; i++)
            {
                cmbAge.Items.Add(i.ToString());
            }
            dateBirthday.Value = DateTime.Now;
            txtUsername.Focus();
        }

        string imgLocation = "";
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All files(*.*)|*.*|PNG files(*.png)|*.png|JPG files(*.jpg)|*.jpg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                picProfilePicture.ImageLocation = imgLocation;
            }
            txtUsername.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveImage();
            txtUsername.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Failed to Create Account! Username is Missing!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if(String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Failed to Create Account! Password is Missing!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else if(String.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Failed to Create Account! Confirm Password is Missing!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
            }
            else if(txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Failed to Create Account! Password do not Match!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.ResetText();
                txtConfirmPassword.ResetText();
                txtPassword.Focus();
            }
            else if(String.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Failed to Create Account! First Name is Missing!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
            }
            else if(String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Failed to Create Account! Last Name is Missing!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
            }
            else if(String.IsNullOrWhiteSpace(cmbGender.Text))
            {
                MessageBox.Show("Failed to Create Account! Gender is Missing!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbGender.Focus();
            }
            else if(String.IsNullOrWhiteSpace(cmbAge.Text))
            {
                MessageBox.Show("Failed to Create Account! Age is Missing!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbAge.Focus();
            }
            else if(String.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Failed to Create Account! Address is Missing!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
            }
            else if(String.IsNullOrWhiteSpace(txtCellphoneNumber.Text) && String.IsNullOrWhiteSpace(txtTelephoneNumber.Text) &&
                String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Failed to Create Account! Contact Information is Missing! Input at least one Contact Information!", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCellphoneNumber.Focus();
            }
            else if(String.IsNullOrWhiteSpace(cmbUserTypeOrRole.Text))
            {
                MessageBox.Show("Failed to Create Account! User Type or Role is Missing!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUserTypeOrRole.Focus();
            }
            else if(duplicate.Username(txtUsername.Text.ToLower()))
            {
                MessageBox.Show("Failed to Create Account! Username is Missing!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.ResetText();
                txtUsername.Focus();
            }
            else if(String.IsNullOrWhiteSpace(imgLocation) && txtPassword.Text == txtConfirmPassword.Text)
            {
                if(user.Add(null, txtUsername.Text.ToLower(), txtPassword.Text, text_info.ToTitleCase(txtFirstName.Text),
                    text_info.ToTitleCase(txtMiddleName.Text), text_info.ToTitleCase(txtLastName.Text), int.Parse(cmbAge.Text), cmbGender.Text,
                    text_info.ToTitleCase(txtAddress.Text), dateBirthday.Value.Date, txtCellphoneNumber.Text, txtTelephoneNumber.Text, txtEmail.Text,
                    cmbUserTypeOrRole.Text))
                {
                    MessageBox.Show("Account Successfully Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Failed to Create Account!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(!String.IsNullOrWhiteSpace(imgLocation) && txtPassword.Text == txtConfirmPassword.Text)
            {
                byte[] profile_picture = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                profile_picture = br.ReadBytes((int)fs.Length);

                if (user.Add(profile_picture, txtUsername.Text.ToLower(), txtPassword.Text, text_info.ToTitleCase(txtFirstName.Text),
                    text_info.ToTitleCase(txtMiddleName.Text), text_info.ToTitleCase(txtLastName.Text), int.Parse(cmbAge.Text), cmbGender.Text,
                    text_info.ToTitleCase(txtAddress.Text), dateBirthday.Value.Date, txtCellphoneNumber.Text, txtTelephoneNumber.Text, txtEmail.Text,
                    cmbUserTypeOrRole.Text))
                {
                    MessageBox.Show("Account Successfully Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoveImage();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Failed to Create Account!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
