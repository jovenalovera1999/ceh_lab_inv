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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();
        functions.Supply supply = new functions.Supply();

        void Reset()
        {
            txtItem.ResetText();
            txtBrand.ResetText();
            txtSupplier.ResetText();
            txtQuantity.ResetText();
            txtUnitOfQuantity.ResetText();
            dateExpiration.Value = DateTime.Now;
            txtQTY.ResetText();
            txtUnitOfQTY.ResetText();
            txtUnitCost.ResetText();
            txtTotalCost.ResetText();
            txtItem.Focus();
        }

        void Calculate()
        {
            if(txtUnitCost.Text == ".")
            {
                txtTotalCost.Text = "0.00";
            }
            else
            {
                double total_cost = (int.Parse(txtQuantity.Text) * double.Parse(txtUnitCost.Text));
                txtTotalCost.Text = total_cost.ToString("0.00");
            }
        }

        void RefreshSuppliesList()
        {
            forms.supplies.frmList supplies_list = (forms.supplies.frmList)Application.OpenForms["frmList"];
            DataGridView gridSupplies = (DataGridView)supplies_list.Controls["gridSupplies"];
            supply.Load(gridSupplies);
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtQuantity.Text) || String.IsNullOrWhiteSpace(txtUnitCost.Text))
            {
                txtTotalCost.Text = "0.00";
            }
            else
            {
                Calculate();
            }
        }

        private void txtUnitCost_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtQuantity.Text) || String.IsNullOrWhiteSpace(txtUnitCost.Text))
            {
                txtTotalCost.Text = "0.00";
            }
            else
            {
                Calculate();
            }
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

        private void txtQTY_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmAdd_Load(object sender, EventArgs e)
        {
            txtItem.Focus();
            dateExpiration.Value = DateTime.Now;
        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtItem.Text))
            {
                MessageBox.Show("The item name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItem.Focus();
            }
            else if(String.IsNullOrWhiteSpace(txtBrand.Text))
            {
                MessageBox.Show("The brand is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrand.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtSupplier.Text))
            {
                MessageBox.Show("The supplier is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSupplier.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("The quantity is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUnitOfQuantity.Text))
            {
                MessageBox.Show("The unit of quantity is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnitOfQuantity.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtQTY.Text))
            {
                MessageBox.Show("The QTY is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQTY.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUnitOfQTY.Text))
            {
                MessageBox.Show("The brand is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnitOfQTY.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUnitCost.Text))
            {
                MessageBox.Show("The brand is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnitCost.Focus();
            }
            else if(supply.Add(txtItem.Text.ToUpper(), txtBrand.Text.ToUpper(), txtSupplier.Text.ToUpper(), int.Parse(txtQuantity.Text), txtUnitOfQuantity.Text.ToUpper(),
                dateExpiration.Value.Date, int.Parse(txtQTY.Text), txtUnitOfQTY.Text.ToUpper(), txtUnitCost.Text, txtTotalCost.Text))
            {
                MessageBox.Show("Supply successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshSuppliesList();
                Reset();
            }
            else
            {
                MessageBox.Show("Failed to add supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            RefreshSuppliesList();
            this.Close();
        }
    }
}
