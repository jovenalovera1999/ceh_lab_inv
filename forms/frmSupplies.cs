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

        int count_entries;
        const int max_rows = 20;

        void CountSuppliesAndTrash()
        {
            count.Supplies();
            lblTotalSupplies.Text = val.CountSupplies;

            count.Trash();
            lblInTrash.Text = val.CountTrash;
        }

        void LabelPaging()
        {
            count_entries = gridSupplies.Rows.Count;
            lblPageLabel.Text = string.Format("Entries: {0}/{1}", count_entries, val.CountSupplies);
        }

        void ButtonControls()
        {
            if (count_entries <= int.Parse(val.CountSupplies) && int.Parse(val.CountSupplies) > max_rows == false)
            {
                btnNextPage.Enabled = false;
                btnPreviousPage.Enabled = false;
            }
            else if(count_entries == max_rows)
            {
                btnNextPage.Enabled = true;

                btnPreviousPage.Enabled = false;
            }
            else if(count_entries == int.Parse(val.CountSupplies))
            {
                btnPreviousPage.Enabled = true;

                btnNextPage.Enabled = false;
            }
            else
            {
                btnNextPage.Enabled = true;
                btnPreviousPage.Enabled = true;
            }
        }

        private void frmSupplies_Load(object sender, EventArgs e)
        {
            this.SetBounds(Screen.PrimaryScreen.WorkingArea.Left, Screen.PrimaryScreen.WorkingArea.Top, Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height);

            CountSuppliesAndTrash();

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

            LabelPaging();
            ButtonControls();

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
            CountSuppliesAndTrash();

            supply.Load(gridSupplies);
            gridSupplies.ClearSelection();
        }

        private void btnLoadTrash_Click(object sender, EventArgs e)
        {

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
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete this Supply?", "Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (supply.Delete(int.Parse(row.Cells["id"].Value.ToString())))
                    {
                        MessageBox.Show("Supply Successfully Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        supply.Load(gridSupplies);
                        gridSupplies.ClearSelection();

                        CountSuppliesAndTrash();
                        LabelPaging();
                        ButtonControls();
                    }
                }
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            supply.NextPage();
            gridSupplies.ClearSelection();

            count_entries += gridSupplies.Rows.Count;
            if (count_entries > int.Parse(val.CountSupplies))
            {
                count_entries = gridSupplies.Rows.Count;
            }

            LabelPaging();
            ButtonControls();

            txtSearch.Focus();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (count_entries == int.Parse(val.CountSupplies) && gridSupplies.Rows.Count < max_rows)
            {
                count_entries -= gridSupplies.Rows.Count;

                supply.PreviousPage();
                gridSupplies.ClearSelection();
            }
            else
            {
                supply.PreviousPage();
                gridSupplies.ClearSelection();

                count_entries -= gridSupplies.Rows.Count;
                if (count_entries <= 0)
                {
                    count_entries = gridSupplies.Rows.Count;
                }
            }

            LabelPaging();
            ButtonControls();

            txtSearch.Focus();
        }

        private void frmSupplies_VisibleChanged(object sender, EventArgs e)
        {
            gridSupplies.ClearSelection();
        }
    }
}
