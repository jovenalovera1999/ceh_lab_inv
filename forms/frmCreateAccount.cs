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

        functions.Signup sign_up = new functions.Signup();
        functions.Duplicate duplicate = new functions.Duplicate();

        void ResetFields()
        {
            if(!String.IsNullOrWhiteSpace(imgLocation))
            {
                imgLocation = null;
                picProfile.ImageLocation = null;
                picProfile.Image = null;
            }

            txtUsername.ResetText();
            txtPassword.ResetText();
            txtConfirmPassword.ResetText();
            txtFirstName.ResetText();
            txtMiddleName.ResetText();
            txtLastName.ResetText();
            txtAddress.ResetText();
            txtCellphoneNumber.ResetText();
            txtTelephoneNumber.ResetText();
            txtEmail.ResetText();
            
            cmbGender.Text = null;
            cmbUserType.Text = null;
            
            dateBirthday.Value = DateTime.Now;

            txtUsername.Focus();
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
            dateBirthday.Value = DateTime.Now;
            txtUsername.Focus();
        }

        string imgLocation = "";
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG files(*.png)|*.png|JPG files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                picProfile.ImageLocation = imgLocation;
            }

            txtUsername.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            imgLocation = null;
            picProfile.ImageLocation = null;
            picProfile.Image = null;

            txtUsername.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - dateBirthday.Value.Year;

            if (dateBirthday.Value.Date > DateTime.Now.AddYears(-age)) age--;

            if (String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Failed to Create Account, Username is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if(String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Failed to Create Account, Password is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else if(String.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Failed to Create Account, Confirm Password is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
            }
            else if(String.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Failed to Create Account, First Name is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
            }
            else if(String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Failed to Create Account, Last Name is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
            }
            else if(String.IsNullOrWhiteSpace(cmbGender.Text))
            {
                MessageBox.Show("Failed to Create Account, Gender is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbGender.Focus();
            }
            else if(String.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Failed to Create Account, Address is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
            }
            else if(String.IsNullOrWhiteSpace(txtCellphoneNumber.Text) && String.IsNullOrWhiteSpace(txtTelephoneNumber.Text) &&
                String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Failed to Create Account, Contact Information is Required at least one!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCellphoneNumber.Focus();
            }
            else if(String.IsNullOrWhiteSpace(cmbUserType.Text))
            {
                MessageBox.Show("Failed to Create Account, User Type is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUserType.Focus();
            }
            else if (duplicate.DuplicateUsername(txtUsername.Text))
            {
                MessageBox.Show("Failed to Create Account, Username is Already Taken!", "Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.ResetText();
                txtUsername.Focus();
            }
            else if(txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Failed to Create Account, Password do not Match!", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else if(String.IsNullOrWhiteSpace(imgLocation) && txtPassword.Text == txtConfirmPassword.Text)
            {
                if(sign_up.SignUp(null, txtFirstName.Text.ToUpper(), txtMiddleName.Text.ToUpper(), txtLastName.Text.ToUpper(), age, cmbGender.Text,
                    txtAddress.Text.ToUpper(), dateBirthday.Value.Date, txtCellphoneNumber.Text, txtTelephoneNumber.Text, txtEmail.Text,
                    txtUsername.Text, txtPassword.Text, cmbUserType.Text))
                {
                    MessageBox.Show("Account Successfully Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetFields();
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

                if (sign_up.SignUp(profile_picture, txtFirstName.Text.ToUpper(), txtMiddleName.Text.ToUpper(), txtLastName.Text.ToUpper(),
                    int.Parse(age.ToString()), cmbGender.Text, txtAddress.Text.ToUpper(), dateBirthday.Value.Date, txtCellphoneNumber.Text,
                    txtTelephoneNumber.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text, cmbUserType.Text))
                {
                    MessageBox.Show("Account Successfully Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetFields();
                }
                else
                {
                    MessageBox.Show("Failed to Create Account!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
