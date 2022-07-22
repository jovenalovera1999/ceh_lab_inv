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

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            this.SetBounds(Screen.PrimaryScreen.WorkingArea.Left, Screen.PrimaryScreen.WorkingArea.Top, Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height);

            account.Load(gridAccounts);

            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.HeaderText = "ACTION";
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseColumnTextForButtonValue = true;
            gridAccounts.Columns.Add(btnUpdate);

            txtSearch.Focus();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            forms.frmCreateAccount create_account = new forms.frmCreateAccount();
            create_account.Show();
        }

        private void frmAccounts_VisibleChanged(object sender, EventArgs e)
        {
            gridAccounts.ClearSelection();
        }
    }
}
