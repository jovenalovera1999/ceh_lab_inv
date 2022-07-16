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
    public partial class frmSupplies : Form
    {
        public frmSupplies()
        {
            InitializeComponent();
        }

        components.Connection con = new components.Connection();
        components.Value val = new components.Value();
        functions.Supply supply = new functions.Supply();

        private void frmSupplies_Load(object sender, EventArgs e)
        {
            this.SetBounds(Screen.PrimaryScreen.WorkingArea.Left, Screen.PrimaryScreen.WorkingArea.Top, Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height);

            lblTotalSupplies.Text = val.CountSupplies;
            lblInTrash.Text = val.CountTrash;

            supply.Load(gridSupplies);

            DataGridViewButtonColumn btnUpdateRgt = new DataGridViewButtonColumn();
            btnUpdateRgt.HeaderText = "ACTION";
            btnUpdateRgt.Name = "btnUpdateRgt";
            btnUpdateRgt.Text = "UPDATE RGT";
            btnUpdateRgt.UseColumnTextForButtonValue = true;
            gridSupplies.Columns.Add(btnUpdateRgt);

            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.HeaderText = "";
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseColumnTextForButtonValue = true;
            gridSupplies.Columns.Add(btnUpdate);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "";
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "DELETE";
            btnDelete.UseColumnTextForButtonValue = true;
            gridSupplies.Columns.Add(btnDelete);

            txtSearch.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            forms.frmAddSupply add_supply = new forms.frmAddSupply();
            add_supply.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadSupplies_Click(object sender, EventArgs e)
        {
            supply.Load(gridSupplies);
            gridSupplies.ClearSelection();
        }

        private void btnLoadTrash_Click(object sender, EventArgs e)
        {

        }

        private void frmSupplies_VisibleChanged(object sender, EventArgs e)
        {
            gridSupplies.ClearSelection();
        }
    }
}
