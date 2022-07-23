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
    public partial class frmChangeUserType : Form
    {
        public frmChangeUserType()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();

        functions.Account account = new functions.Account();

        private void frmChangeUserType_Load(object sender, EventArgs e)
        {
            cmbUserType.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(cmbUserType.Text))
            {
                MessageBox.Show("Failed to Update User Type, User Type is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUserType.Focus();
            }
            else if(account.ChangeUserType(val.AccountPrimaryID, cmbUserType.Text))
            {
                MessageBox.Show("User Type has been Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to Update User Type!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
