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
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();
        functions.User user = new functions.User();
        functions.Duplicate duplicate = new functions.Duplicate();

        int age;

        void ResetFields()
        {
            btnUpload.Visible = false;
            btnRemove.Visible = false;
            txtUsername.Enabled = false;
            lblPassword.Visible = false;
            txtPassword.Visible = false;
            lblConfirmPassword.Visible = false;
            txtConfirmPassword.Visible = false;
            txtFirstName.Enabled = false;
            txtMiddleName.Enabled = false;
            txtLastName.Enabled = false;
            txtGender.Visible = true;
            cmbGender.Visible = false;
            txtAddress.Enabled = false;
            txtBirthday.Visible = true;
            dateBirthday.Visible = false;
            txtCellphoneNumber.Enabled = false;
            txtTelephoneNumber.Enabled = false;
            txtEmail.Enabled = false;
            btnUpdate.Visible = true;
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }

        void UpdateOne()
        {
            if (user.Update(val.UserPrimaryID, val.UserProfilePicture, txtFirstName.Text.ToUpper(), txtMiddleName.Text.ToUpper(),
                txtLastName.Text.ToUpper(), age, cmbGender.Text, txtAddress.Text.ToUpper(), dateBirthday.Value.Date, txtCellphoneNumber.Text,
                txtTelephoneNumber.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Your Account was Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFields();
            }
            else
            {
                MessageBox.Show("Failed to Update your Account!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void UpdateTwo()
        {
            byte[] profile_picture = null;
            FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            profile_picture = br.ReadBytes((int)fs.Length);

            if (user.Update(val.UserPrimaryID, profile_picture, txtFirstName.Text.ToUpper(), txtMiddleName.Text.ToUpper(),
                txtLastName.Text.ToUpper(), age, cmbGender.Text, txtAddress.Text.ToUpper(), dateBirthday.Value.Date, txtCellphoneNumber.Text,
                txtTelephoneNumber.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Your Account has been Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFields();
            }
            else
            {
                MessageBox.Show("Failed to Update your Account!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void frmProfile_Load(object sender, EventArgs e)
        {
            this.SetBounds(Screen.PrimaryScreen.WorkingArea.Left, Screen.PrimaryScreen.WorkingArea.Top, Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height);

            if(val.UserProfilePicture != null)
            {
                MemoryStream ms = new MemoryStream(val.UserProfilePicture);
                picProfile.Image = Image.FromStream(ms);
            }

            txtUsername.Text = val.UserUsername;
            txtPassword.Text = val.UserPassword;
            txtFirstName.Text = val.UserFirstName;
            txtMiddleName.Text = val.UserMiddleName;
            txtLastName.Text = val.UserLastName;
            txtGender.Text = val.UserGender;
            cmbGender.Text = val.UserGender;
            txtAddress.Text = val.UserAddress;
            txtBirthday.Text = val.UserBirthday.ToString("D");
            dateBirthday.Value = val.UserBirthday;
            txtCellphoneNumber.Text = val.UserCellphoneNumber;
            txtTelephoneNumber.Text = val.UserTelephoneNumber;
            txtEmail.Text = val.UserEmail;
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
            txtConfirmPassword.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            val.UserProfilePicture = null;
            imgLocation = null;
            picProfile.ImageLocation = null;
            picProfile.Image = null;
            txtConfirmPassword.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpload.Visible = true;
            btnRemove.Visible = true;
            txtUsername.Enabled = true;
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            lblConfirmPassword.Visible = true;
            txtConfirmPassword.Visible = true;
            txtFirstName.Enabled = true;
            txtMiddleName.Enabled = true;
            txtLastName.Enabled = true;
            cmbGender.Visible = true;
            txtGender.Visible = false;
            txtAddress.Enabled = true;
            dateBirthday.Visible = true;
            txtBirthday.Visible = false;
            txtCellphoneNumber.Enabled = true;
            txtTelephoneNumber.Enabled = true;
            txtEmail.Enabled = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnUpdate.Visible = false;
            txtUsername.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            age = DateTime.Now.Year - dateBirthday.Value.Year;

            if (dateBirthday.Value.Date > DateTime.Now.AddYears(-age)) age--;

            if (String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Failed to Create Account, Username is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Failed to Create Account, Password is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Failed to Create Account, Confirm Password is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Failed to Create Account, First Name is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Failed to Create Account, Last Name is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(cmbGender.Text))
            {
                MessageBox.Show("Failed to Create Account, Gender is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbGender.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Failed to Create Account, Address is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtCellphoneNumber.Text) && String.IsNullOrWhiteSpace(txtTelephoneNumber.Text) &&
                String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Failed to Create Account, Contact Information is Required at least one!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCellphoneNumber.Focus();
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Failed to Create Account, Password do not Match!", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else if(duplicate.DuplicateUsernameProceed(val.UserPrimaryID, txtUsername.Text))
            {
                if (String.IsNullOrWhiteSpace(imgLocation) && txtPassword.Text == txtConfirmPassword.Text)
                {
                    UpdateOne();
                }
                else if (!String.IsNullOrWhiteSpace(imgLocation) && txtPassword.Text == txtConfirmPassword.Text)
                {
                    UpdateTwo();
                }
            }
            else if (duplicate.DuplicateUsername(txtUsername.Text))
            {
                MessageBox.Show("Failed to Create Account, Username is Already Taken!", "Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.ResetText();
                txtUsername.Focus();
            }
            else if(String.IsNullOrWhiteSpace(imgLocation) && txtPassword.Text == txtConfirmPassword.Text)
            {
                UpdateOne();
            }
            else if(!String.IsNullOrWhiteSpace(imgLocation) && txtPassword.Text == txtConfirmPassword.Text)
            {
                UpdateTwo();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void frmProfile_VisibleChanged(object sender, EventArgs e)
        {
            user.Get(val.UserPrimaryID);
        }
    }
}
