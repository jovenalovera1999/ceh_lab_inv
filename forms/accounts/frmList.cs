using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ceh_lab_inv.forms.accounts
{
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();
        functions.Account account = new functions.Account();

        private void frmList_Load(object sender, EventArgs e)
        {
            account.Load(gridAccounts);

            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.HeaderText = "ACTION";
            btnUpdate.Text = "UPDATE";
            btnUpdate.Name = "btnUpdate";
            btnUpdate.UseColumnTextForButtonValue = true;
            gridAccounts.Columns.Add(btnUpdate);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "";
            btnDelete.Text = "DELETE";
            btnDelete.Name = "btnDelete";
            btnDelete.UseColumnTextForButtonValue = true;
            gridAccounts.Columns.Add(btnDelete);
        }

        private void gridAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridAccounts.Rows[e.RowIndex];

            if (gridAccounts.Columns[e.ColumnIndex].Name == "btnUpdate")
            {
                if (account.Get(int.Parse(row.Cells["id"].Value.ToString())))
                {
                    forms.accounts.frmEdit accounts_edit = new forms.accounts.frmEdit();
                    accounts_edit.TopLevel = false;
                    forms.dashboard.frmDashboard dashboard = (forms.dashboard.frmDashboard)Application.OpenForms["frmDashboard"];
                    Panel pnlMain = (Panel)dashboard.Controls["pnlMain"];
                    pnlMain.Controls.Add(accounts_edit);
                    accounts_edit.Dock = DockStyle.Fill;
                    accounts_edit.Show();
                    this.Close();
                }
            }
            else if(gridAccounts.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                if(MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (account.Delete(int.Parse(row.Cells["id"].Value.ToString())))
                    {
                        MessageBox.Show("Account successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete account!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void gridAccounts_VisibleChanged(object sender, EventArgs e)
        {
            gridAccounts.ClearSelection();
        }
    }
}
