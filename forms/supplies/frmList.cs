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
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();
        functions.Supply supply = new functions.Supply();

        private void frmList_Load(object sender, EventArgs e)
        {
            supply.Load(gridSupplies);

            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.HeaderText = "ACTION";
            btnUpdate.Text = "UPDATE";
            btnUpdate.Name = "btnUpdate";
            btnUpdate.UseColumnTextForButtonValue = true;
            gridSupplies.Columns.Add(btnUpdate);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "";
            btnDelete.Text = "DELETE";
            btnDelete.Name = "btnDelete";
            btnDelete.UseColumnTextForButtonValue = true;
            gridSupplies.Columns.Add(btnDelete);
        }

        private void gridSupplies_VisibleChanged(object sender, EventArgs e)
        {
            gridSupplies.ClearSelection();
        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            forms.supplies.frmAdd add_supply = new forms.supplies.frmAdd();
            add_supply.Show();
        }

        private void gridSupplies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gridSupplies.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                if(MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow row = gridSupplies.Rows[e.RowIndex];

                    if(supply.Delete(int.Parse(row.Cells["id"].Value.ToString())))
                    {
                        MessageBox.Show("Item successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        supply.Load(gridSupplies);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete item!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
