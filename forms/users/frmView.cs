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
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();
        functions.User user = new functions.User();

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

        private void frmView_Load(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(val.UserProfilePicture.ToString()))
            {
                MemoryStream ms = new MemoryStream(val.UserProfilePicture);
                picProfile.Image = Image.FromStream(ms);
            }

            txtUsername.Text = val.UserUsername;
            txtPassword.Text = val.UserPassword;
            txtConfirmPassword.Text = val.UserPassword;
            txtFirstName.Text = val.UserFirstName;
            txtMiddleName.Text = val.UserMiddleName;
            txtLastName.Text = val.UserLastName;
            txtAge.Text = val.UserAge.ToString();
            txtGender.Text = val.UserGender;
            cmbGender.Text = val.UserGender;
            txtAddress.Text = val.UserAddress;
            dateBirthday.Value = val.UserBirthday;
            txtCellphoneNumber.Text = val.UserCellphoneNumber;
            txtTelephoneNumber.Text = val.UserTelephoneNumber;
            txtEmail.Text = val.UserEmail;
            txtRole.Text = val.UserRole;
            cmbRole.Text = val.UserRole;
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            btnUploadPhoto.Visible = true;
            btnRemovePhoto.Visible = true;
            lblConfirmPassword.Visible = true;
            txtConfirmPassword.Visible = true;
            btnSaveAccount.Visible = true;
            btnCancel.Visible = true;
            btnEditAccount.Visible = false;

            txtUsername.TabStop = true;
            txtPassword.TabStop = true;
            txtConfirmPassword.TabStop = true;
            txtFirstName.TabStop = true;
            txtMiddleName.TabStop = true;
            txtLastName.TabStop = true;
            txtAge.TabStop = true;
            cmbGender.Visible = true;
            cmbGender.TabStop = true;
            txtGender.Visible = false;
            txtAddress.TabStop = true;
            dateBirthday.Enabled = true;
            txtCellphoneNumber.TabStop = true;
            txtTelephoneNumber.TabStop = true;
            txtEmail.TabStop = true;
            cmbRole.Visible = true;
            txtRole.Visible = false;

            txtUsername.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtConfirmPassword.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtMiddleName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtAge.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtCellphoneNumber.ReadOnly = false;
            txtTelephoneNumber.ReadOnly = false;
            txtEmail.ReadOnly = false;
        }
    }
}
