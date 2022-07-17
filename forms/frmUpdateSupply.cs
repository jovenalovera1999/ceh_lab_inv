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
            if(switchExpirationDate.Checked)
            {
                dateExpirationDate.Enabled = true;
            }
            else
            {
                dateExpirationDate.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
