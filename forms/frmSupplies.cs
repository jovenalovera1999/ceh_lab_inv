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
        functions.Count count = new functions.Count();

        bool isSupplies;
        bool isTrash;

        void CountSuppliesAndTrash()
        {
            count.Supplies();
            lblTotalSupplies.Text = val.CountSupplies;

            count.Trash();
            lblInTrash.Text = val.CountTrash;
        }

        void ButtonWithinGridControls()
        {
            if(isSupplies == true && isTrash == false)
            {
                if (gridSupplies.Columns.Contains("btnUpdateRgt") == true && gridSupplies.Columns.Contains("btnUpdate") == true &&
                    gridSupplies.Columns.Contains("btnDelete") == true)
                {
                    gridSupplies.Columns.Remove("btnUpdateRgt");
                    gridSupplies.Columns.Remove("btnUpdate");
                    gridSupplies.Columns.Remove("btnDelete");
                }
                else
                {
                    gridSupplies.Columns.Remove("btnRestore");
                    gridSupplies.Columns.Remove("btnPermanentDelete");
                }

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
            }
            else if(isTrash == true && isSupplies == false)
            {
                if (gridSupplies.Columns.Contains("btnUpdateRgt") == true && gridSupplies.Columns.Contains("btnUpdate") == true &&
                    gridSupplies.Columns.Contains("btnDelete") == true)
                {
                    gridSupplies.Columns.Remove("btnUpdateRgt");
                    gridSupplies.Columns.Remove("btnUpdate");
                    gridSupplies.Columns.Remove("btnDelete");
                }
                else
                {
                    gridSupplies.Columns.Remove("btnRestore");
                    gridSupplies.Columns.Remove("btnPermanentDelete");
                }

                DataGridViewButtonColumn btnRestore = new DataGridViewButtonColumn();
                btnRestore.HeaderText = "ACTION";
                btnRestore.Name = "btnRestore";
                btnRestore.Text = "RESTORE";
                btnRestore.UseColumnTextForButtonValue = true;
                gridSupplies.Columns.Add(btnRestore);

                DataGridViewButtonColumn btnPermanentDelete = new DataGridViewButtonColumn();
                btnPermanentDelete.HeaderText = "";
                btnPermanentDelete.Name = "btnPermanentDelete";
                btnPermanentDelete.Text = "DELETE";
                btnPermanentDelete.UseColumnTextForButtonValue = true;
                gridSupplies.Columns.Add(btnPermanentDelete);
            }
            else
            {
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
            }
            gridSupplies.ClearSelection();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(isSupplies == true)
            {
                supply.LoadBySearch(txtSearch.Text, gridSupplies);
                gridSupplies.ClearSelection();
            }
        }

        private void frmSupplies_Load(object sender, EventArgs e)
        {
            this.SetBounds(Screen.PrimaryScreen.WorkingArea.Left, Screen.PrimaryScreen.WorkingArea.Top, Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height);

            supply.Load(gridSupplies);

            ButtonWithinGridControls();
            CountSuppliesAndTrash();

            isSupplies = true;
            isTrash = false;

            txtSearch.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            forms.frmAddSupply add_supply = new forms.frmAddSupply();
            add_supply.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            forms.frmPrint print = new forms.frmPrint();
            print.Show();
        }

        private void btnLoadSupplies_Click(object sender, EventArgs e)
        {
            isSupplies = true;
            isTrash = false;

            supply.Load(gridSupplies);
            gridSupplies.ClearSelection();

            ButtonWithinGridControls();
            CountSuppliesAndTrash();

            txtSearch.ResetText();
            txtSearch.Focus();
        }

        private void btnLoadTrash_Click(object sender, EventArgs e)
        {
            isTrash = true;
            isSupplies = false;

            supply.LoadTrash(gridSupplies);
            gridSupplies.ClearSelection();

            ButtonWithinGridControls();
            CountSuppliesAndTrash();

            txtSearch.ResetText();
            txtSearch.Focus();
        }

        private void gridSupplies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridSupplies.Rows[e.RowIndex];

            if (gridSupplies.Columns[e.ColumnIndex].Name == "btnUpdateRgt")
            {
                if (supply.Get(int.Parse(row.Cells["id"].Value.ToString())))
                {
                    forms.frmUpdateRgt update_rgt = new forms.frmUpdateRgt();
                    update_rgt.Show();
                }
            }
            else if (gridSupplies.Columns[e.ColumnIndex].Name == "btnUpdate")
            {
                if (supply.Get(int.Parse(row.Cells["id"].Value.ToString())))
                {
                    forms.frmUpdateSupply update_supply = new forms.frmUpdateSupply();
                    update_supply.Show();
                }
            }
            else if (gridSupplies.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                if (MessageBox.Show("Are you sure you want to Delete this Supply?", "Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (supply.Delete(int.Parse(row.Cells["id"].Value.ToString())))
                    {
                        MessageBox.Show("Supply has been Successfully Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if(!String.IsNullOrWhiteSpace(txtSearch.Text))
                        {
                            supply.LoadBySearch(txtSearch.Text, gridSupplies);
                        }
                        else
                        {
                            supply.Load(gridSupplies);
                        }

                        gridSupplies.ClearSelection();
                        CountSuppliesAndTrash();
                    }
                }
            }
            else if (gridSupplies.Columns[e.ColumnIndex].Name == "btnRestore")
            {
                if (supply.Restore(int.Parse(row.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("Supply has been Successfully Restored!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    supply.LoadTrash(gridSupplies);
                    gridSupplies.ClearSelection();

                    CountSuppliesAndTrash();
                }
            }
            else if (gridSupplies.Columns[e.ColumnIndex].Name == "btnPermanentDelete")
            {
                if(MessageBox.Show("Are you sure you want you to Permanently Delete this Supply?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (supply.PermanentDelete(int.Parse(row.Cells["id"].Value.ToString())))
                    {
                        MessageBox.Show("Supply has been Successfully Permanent Deleted!", "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        supply.LoadTrash(gridSupplies);
                        gridSupplies.ClearSelection();

                        CountSuppliesAndTrash();
                    }
                }
            }
        }

        private void frmSupplies_VisibleChanged(object sender, EventArgs e)
        {
            gridSupplies.ClearSelection();
        }
    }
}
