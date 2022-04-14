using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ceh_lab_inv.forms.incoming_supplies
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();
        functions.IncomingSupply incoming_supply = new functions.IncomingSupply();

        void Reset()
        {
            dateArrival.Value = DateTime.Now;
            dateExpiration.Value = DateTime.Now;
            txtQuantity.ResetText();
            txtItem.ResetText();
            txtBrand.ResetText();
            txtQTY.ResetText();
            txtSupplier.ResetText();
            txtUnitCost.ResetText();
            txtNumberOfUnit.ResetText();
            txtTotalCost.Text = "0.00";
            dateArrival.Focus();
        }

        void RefreshIncomingSuppliesList()
        {
            forms.incoming_supplies.frmList incoming_supplies_list = (forms.incoming_supplies.frmList)Application.OpenForms["frmList"];
            DataGridView gridIncomingSupplies = (DataGridView)incoming_supplies_list.Controls["gridIncomingSupplies"];
            incoming_supply.Load(gridIncomingSupplies);
        }

        void Calculate()
        {
            double total_cost = (double.Parse(txtUnitCost.Text) * int.Parse(txtNumberOfUnit.Text));
            txtTotalCost.Text = total_cost.ToString("0.00");
        }

        private void txtUnitCost_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtUnitCost.Text) || String.IsNullOrWhiteSpace(txtNumberOfUnit.Text))
            {
                txtTotalCost.Text = "0.00";
            }
            else
            {
                Calculate();
            }
        }

        private void txtNumberOfUnit_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUnitCost.Text) || String.IsNullOrWhiteSpace(txtNumberOfUnit.Text))
            {
                txtTotalCost.Text = "0.00";
            }
            else
            {
                Calculate();
            }
        }

        private void txtUnitCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, decimal and backspace
            if((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
            // Check to make sure only 1 decimal is allowed
            if(e.KeyChar == 46)
            {
                if((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtNumberOfUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            dateArrival.Value = DateTime.Now;
            dateExpiration.Value = DateTime.Now;
        }

        private void btnAddIncomingSupply_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("The quantity is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtItem.Text))
            {
                MessageBox.Show("The item is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItem.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtBrand.Text))
            {
                MessageBox.Show("The brand is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrand.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtQTY.Text))
            {
                MessageBox.Show("The QTY is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQTY.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtSupplier.Text))
            {
                MessageBox.Show("The supplier is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSupplier.Focus();
            }
            else if (incoming_supply.Add(dateArrival.Value.Date, dateExpiration.Value.Date, txtQuantity.Text.ToUpper(), txtItem.Text.ToUpper(), txtBrand.Text.ToUpper(),
                    txtQTY.Text.ToUpper(), txtSupplier.Text.ToUpper(), txtUnitCost.Text, int.Parse(txtNumberOfUnit.Text), txtTotalCost.Text))
            {
                MessageBox.Show("Incoming supply successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                RefreshIncomingSuppliesList();
            }
            else
            {
                MessageBox.Show("Failed to add incoming supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
