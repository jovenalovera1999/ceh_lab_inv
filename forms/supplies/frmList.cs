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

        private void frmList_VisibleChanged(object sender, EventArgs e)
        {
            gridSupplies.ClearSelection();
        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            forms.supplies.frmAdd supplies_add = new forms.supplies.frmAdd();
            supplies_add.Show();
        }
    }
}
