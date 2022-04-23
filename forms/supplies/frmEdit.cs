using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ceh_lab_inv.forms.supplies
{
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();
        functions.Supply supply = new functions.Supply();

        void Calculate_1()
        {
            double total_cost = ((double.Parse(txtUnitCost.Text) / int.Parse(txtQty.Text)) * int.Parse(txtQuantity.Text));
            txtTotalCost.Text = total_cost.ToString("0.00");
        }

        void Calculate_2()
        {
            double exp_rgt_cost = ((double.Parse(txtUnitCost.Text) / int.Parse(txtQty.Text)) * int.Parse(txtExpRgtQuantity.Text));
            txtExpRgtCost.Text = exp_rgt_cost.ToString("0.00");
        }

        void RefreshSuppliesList()
        {
            forms.supplies.frmList supplies_list = (forms.supplies.frmList)Application.OpenForms["frmList"];
            DataGridView gridSupplies = (DataGridView)supplies_list.Controls["gridSupplies"];
            supply.Load(gridSupplies);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9 and backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9 and backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtUnitCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, decimal and backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
            // Check to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtExpRgtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9 and backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtQuantity.Text) || String.IsNullOrWhiteSpace(txtQty.Text) || String.IsNullOrWhiteSpace(txtUnitCost.Text))
            {
                txtTotalCost.Text = "";
            }
            else
            {
                Calculate_1();
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtQuantity.Text) || String.IsNullOrWhiteSpace(txtQty.Text) || String.IsNullOrWhiteSpace(txtUnitCost.Text))
            {
                txtTotalCost.Text = "";
            }
            else
            {
                Calculate_1();
            }
        }

        private void txtUnitCost_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtQuantity.Text) || String.IsNullOrWhiteSpace(txtQty.Text) || String.IsNullOrWhiteSpace(txtUnitCost.Text))
            {
                txtTotalCost.Text = "";
            }
            else
            {
                Calculate_1();
            }
        }

        private void txtExpRgtQuantity_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtQuantity.Text) || String.IsNullOrWhiteSpace(txtQty.Text) || String.IsNullOrWhiteSpace(txtUnitCost.Text) ||
                String.IsNullOrWhiteSpace(txtExpRgtQuantity.Text))
            {
                txtExpRgtCost.Text = "";
            }
            else
            {
                Calculate_2();
            }
        }

        private void frmEdit_Load(object sender, EventArgs e)
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
            txtExpRgtQuantity.Text = val.SupplyExpRgtQuantity.ToString();
            txtExpRgtUnit.Text = val.SupplyExpRgtUnit;
            txtExpRgtCost.Text = val.SupplyExpRgtCost;
            dateExpiration.Value = val.SupplyExpirationDate;
            this.txtItem.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtItem.Text))
            {
                MessageBox.Show("The item name is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItem.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtBrand.Text))
            {
                MessageBox.Show("The brand is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrand.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtSupplier.Text))
            {
                MessageBox.Show("The supplier is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSupplier.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("The quantity is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUnitOfQuantity.Text))
            {
                MessageBox.Show("The unit of quantity is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnitOfQuantity.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtQty.Text))
            {
                MessageBox.Show("The qty is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQty.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUnitOfQty.Text))
            {
                MessageBox.Show("The unit of qty is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnitOfQty.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUnitCost.Text))
            {
                MessageBox.Show("The unit cost is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrand.Focus();
            }
            else if(supply.Update(val.SupplyPrimaryID, txtItem.Text.ToUpper(), txtBrand.Text.ToUpper(), txtSupplier.Text.ToUpper(), int.Parse(txtQuantity.Text),
                txtUnitOfQuantity.Text.ToUpper(), int.Parse(txtQty.Text), txtUnitOfQty.Text.ToUpper(), txtUnitCost.Text, txtTotalCost.Text, int.Parse(txtExpRgtQuantity.Text),
                txtExpRgtUnit.Text.ToUpper(), txtExpRgtCost.Text, dateExpiration.Value.Date))
            {
                MessageBox.Show("Supply successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshSuppliesList();               
            }
            else
            {
                MessageBox.Show("Failed to update supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
