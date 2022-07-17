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
    public partial class frmUpdateSupply : Form
    {
        public frmUpdateSupply()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();

        functions.Supply supply = new functions.Supply();

        void Calculate()
        {
            if (String.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                txtQuantity.Text = "";
                txtUnitCost.Text = "";
            }
            else if (String.IsNullOrWhiteSpace(txtUnitCost.Text))
            {
                txtUnitCost.Text = "";
            }
            else
            {
                double total_cost = (double.Parse(txtUnitCost.Text) / int.Parse(txtQty.Text)) * int.Parse(txtQuantity.Text);
                txtTotalCost.Text = total_cost.ToString("0.00");
            }
        }

        private void frmUpdateSupply_Load(object sender, EventArgs e)
        {
            txtItem.Text = val.SupplyItem;
            txtBrand.Text = val.SupplyBrand;
            txtSupplier.Text = val.SupplySupplier;
            txtQuantity.Text = val.SupplyQuantity.ToString();
            txtUnitOfQuantity.Text = val.SupplyUnitOfQuantity;
            txtQty.Text = val.SupplyQty.ToString();
            txtUnitOfQty.Text = val.SupplyUnitOfQty;
            txtUnitCost.Text = val.SupplyUnitCost;
            txtTotalCost.Text = val.SupplyTotalCost;

            if(val.SupplyExpirationDate.HasValue)
            {
                switchExpirationDate.Checked = true;
                dateExpirationDate.Enabled = true;

                dateExpirationDate.Value = val.SupplyExpirationDate.Value;
            }
            else
            {
                switchExpirationDate.Checked = false;
                dateExpirationDate.Enabled = false;

                dateExpirationDate.Value = DateTime.Now;
            }

            txtItem.Focus();
        }

        private void switchExpirationDate_CheckedChanged(object sender, EventArgs e)
        {
            if (switchExpirationDate.Checked)
            {
                dateExpirationDate.Enabled = true;
                dateExpirationDate.TabStop = true;
            }
            else
            {
                dateExpirationDate.Enabled = false;
                dateExpirationDate.TabStop = false;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9 and backspace
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9 and backspace
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtUnitCost_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtUnitCost_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtItem.Text))
            {
                MessageBox.Show("Failed to Add Supply, Item is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItem.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtBrand.Text))
            {
                MessageBox.Show("Failed to Add Supply, Brand is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrand.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtSupplier.Text))
            {
                MessageBox.Show("Failed to Add Supply, Supplier is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSupplier.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Failed to Add Supply, Quantity is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUnitOfQuantity.Text))
            {
                MessageBox.Show("Failed to Add Supply, Unit of Quantity is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnitOfQuantity.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtQty.Text))
            {
                MessageBox.Show("Failed to Add Supply, Qty is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQty.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUnitOfQty.Text))
            {
                MessageBox.Show("Failed to Add Supply, Unit of Qty is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnitOfQty.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUnitCost.Text))
            {
                MessageBox.Show("Failed to Add Supply, Unit Cost is Required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnitCost.Focus();
            }
            else if (!switchExpirationDate.Checked && !dateExpirationDate.Enabled)
            {
                if (supply.UpdateWithoutExpirationDate(val.SupplyPrimaryID, txtItem.Text.ToUpper(), txtBrand.Text.ToUpper(),
                    txtSupplier.Text.ToUpper(), int.Parse(txtQuantity.Text), txtUnitOfQuantity.Text.ToUpper(), int.Parse(txtQty.Text),
                    txtUnitOfQty.Text.ToUpper(), txtUnitCost.Text, txtTotalCost.Text))
                {
                    MessageBox.Show("Supply has been Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Update Supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (switchExpirationDate.Checked && dateExpirationDate.Enabled)
            {
                if (supply.UpdateWithExpirationDate(val.SupplyPrimaryID, txtItem.Text.ToUpper(), txtBrand.Text.ToUpper(), txtSupplier.Text.ToUpper(),
                    int.Parse(txtQuantity.Text), txtUnitOfQuantity.Text.ToUpper(), int.Parse(txtQty.Text), txtUnitOfQty.Text.ToUpper(),
                    txtUnitCost.Text, txtTotalCost.Text, dateExpirationDate.Value.Date))
                {
                    MessageBox.Show("Supply has been Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Update Supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
