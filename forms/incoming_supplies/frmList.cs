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
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();
        functions.IncomingSupply incoming_supply = new functions.IncomingSupply();

        private void frmList_Load(object sender, EventArgs e)
        {
            incoming_supply.Load(gridIncomingSupplies);

            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.HeaderText = "ACTION";
            btnUpdate.Text = "UPDATE";
            btnUpdate.Name = "btnUpdate";
            btnUpdate.UseColumnTextForButtonValue = true;
            gridIncomingSupplies.Columns.Add(btnUpdate);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "";
            btnDelete.Text = "DELETE";
            btnDelete.Name = "btnDelete";
            btnDelete.UseColumnTextForButtonValue = true;
            gridIncomingSupplies.Columns.Add(btnDelete);
        }

        private void btnAddIncomingSupply_Click(object sender, EventArgs e)
        {
            forms.incoming_supplies.frmAdd add_incoming_supply = new forms.incoming_supplies.frmAdd();
            add_incoming_supply.Show();
        }

        private void gridIncomingSupplies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gridIncomingSupplies.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                if(MessageBox.Show("Are you sure you want to delete it?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow row = gridIncomingSupplies.Rows[e.RowIndex];

                    if (incoming_supply.Delete(int.Parse(row.Cells["id"].Value.ToString())))
                    {
                        MessageBox.Show("Item successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        incoming_supply.Load(gridIncomingSupplies);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete item!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if(gridIncomingSupplies.Columns[e.ColumnIndex].Name == "btnUpdate")
            {
                DataGridViewRow row = gridIncomingSupplies.Rows[e.RowIndex];

                if(incoming_supply.Get(int.Parse(row.Cells["id"].Value.ToString())))
                {
                    forms.incoming_supplies.frmEdit edit_incoming_supply = new forms.incoming_supplies.frmEdit();
                    edit_incoming_supply.Show();
                }
            }
        }
    }
}
