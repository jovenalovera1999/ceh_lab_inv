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
    public partial class frmAccounts : Form
    {
        public frmAccounts()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();

        functions.Account account = new functions.Account();

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            account.LoadBySearch(txtSearch.Text, gridAccounts);
            gridAccounts.ClearSelection();
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            this.SetBounds(Screen.PrimaryScreen.WorkingArea.Left, Screen.PrimaryScreen.WorkingArea.Top, Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height);

            account.Load(gridAccounts);

            DataGridViewButtonColumn btnResetPassword = new DataGridViewButtonColumn();
            btnResetPassword.HeaderText = "ACTION";
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Text = "RESET PASSWORD";
            btnResetPassword.UseColumnTextForButtonValue = true;
            gridAccounts.Columns.Insert(0, btnResetPassword);

            DataGridViewButtonColumn btnChangeUserType = new DataGridViewButtonColumn();
            btnChangeUserType.HeaderText = "";
            btnChangeUserType.Name = "btnChangeUserType";
            btnChangeUserType.Text = "CHANGE USER TYPE";
            btnChangeUserType.UseColumnTextForButtonValue = true;
            gridAccounts.Columns.Insert(1, btnChangeUserType);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "";
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "DELETE";
            btnDelete.UseColumnTextForButtonValue = true;
            gridAccounts.Columns.Insert(2, btnDelete);

            txtSearch.Focus();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            forms.frmCreateAccount create_account = new forms.frmCreateAccount();
            create_account.ShowDialog();
        }

        private void btnLoadAccount_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txtSearch.Text))
            {
                account.LoadBySearch(txtSearch.Text, gridAccounts);
            }
            else
            {
                account.Load(gridAccounts);
            }
            gridAccounts.ClearSelection();

            txtSearch.Focus();
        }

        private void gridAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridAccounts.Rows[e.RowIndex];

            if (gridAccounts.Columns[e.ColumnIndex].Name == "btnResetPassword")
            {
                if(MessageBox.Show("Are you sure you want to Reset this User's Account Password?", "Warning", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (account.Get(int.Parse(row.Cells["id"].Value.ToString())))
                    {
                        forms.frmResetPassword reset_password = new forms.frmResetPassword();
                        reset_password.ShowDialog();
                    }
                }
            }
            else if (gridAccounts.Columns[e.ColumnIndex].Name == "btnChangeUserType")
            {
                if (MessageBox.Show("Are you sure you want to Change this User's Type?", "Warning", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (account.Get(int.Parse(row.Cells["id"].Value.ToString())))
                    {
                        forms.frmChangeUserType change_user_type = new forms.frmChangeUserType();
                        change_user_type.ShowDialog();
                    }
                }
            }
            else if (gridAccounts.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                if (MessageBox.Show("Are you sure you want to Delete this User's Account?", "Warning", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (account.Delete(int.Parse(row.Cells["id"].Value.ToString())))
                    {
                        MessageBox.Show("Account has been Successfully Deleted!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        account.Load(gridAccounts);
                        gridAccounts.ClearSelection();

                        txtSearch.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete an Account!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void frmAccounts_VisibleChanged(object sender, EventArgs e)
        {
            gridAccounts.ClearSelection();
        }
    }
}
