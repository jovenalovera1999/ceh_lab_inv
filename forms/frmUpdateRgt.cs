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
    public partial class frmUpdateRgt : Form
    {
        public frmUpdateRgt()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();

        functions.Supply supply = new functions.Supply();

        void Calculate()
        {
            if(String.IsNullOrWhiteSpace(txtExpRgtQuantity.Text))
            {
                txtExpRgtQuantity.Text = "";
                txtExpRgtCost.Text = "";
            }
            else
            {
                double exp_rgt_cost = (double.Parse(val.SupplyUnitCost) / val.SupplyQty) * int.Parse(txtExpRgtQuantity.Text);
                txtExpRgtCost.Text = exp_rgt_cost.ToString("0.00");
            }
        }

        private void txtExpRgtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9 and backspace
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtExpRgtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, backspace and period
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            // Checks to make sure only 1 period is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtExpRgtQuantity_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void frmUpdateRgt_Load(object sender, EventArgs e)
        {
            txtExpRgtQuantity.Text = val.SupplyExpRgtQuantity.ToString();
            txtExpRgtUnit.Text = val.SupplyExpRgtUnit;
            txtExpRgtCost.Text = val.SupplyExpRgtCost;

            txtExpRgtQuantity.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtExpRgtQuantity.Text))
            {
                MessageBox.Show("Failed to Update Supply, EXP. RGT. Quantity is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExpRgtQuantity.Focus();
            }
            else if(String.IsNullOrWhiteSpace(txtExpRgtUnit.Text))
            {
                MessageBox.Show("Failed to Update Supply, EXP. RGT. Unit is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExpRgtUnit.Focus();
            }
            else if(supply.UpdateRgt(val.SupplyPrimaryID, int.Parse(txtExpRgtQuantity.Text), txtExpRgtUnit.Text.ToUpper(), txtExpRgtCost.Text))
            {
                MessageBox.Show("Supply has been Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to Update Supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
