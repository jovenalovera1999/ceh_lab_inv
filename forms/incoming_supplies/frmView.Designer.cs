namespace ceh_lab_inv.forms.incoming_supplies
{
    partial class frmView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddIncomingSupply = new Guna.UI2.WinForms.Guna2Button();
            this.gridIncomingSupplies = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridIncomingSupplies)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddIncomingSupply
            // 
            this.btnAddIncomingSupply.Animated = true;
            this.btnAddIncomingSupply.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddIncomingSupply.BorderRadius = 3;
            this.btnAddIncomingSupply.BorderThickness = 1;
            this.btnAddIncomingSupply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddIncomingSupply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddIncomingSupply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddIncomingSupply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddIncomingSupply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddIncomingSupply.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddIncomingSupply.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAddIncomingSupply.ForeColor = System.Drawing.Color.White;
            this.btnAddIncomingSupply.HoverState.BorderColor = System.Drawing.Color.Green;
            this.btnAddIncomingSupply.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddIncomingSupply.Location = new System.Drawing.Point(12, 12);
            this.btnAddIncomingSupply.Name = "btnAddIncomingSupply";
            this.btnAddIncomingSupply.Size = new System.Drawing.Size(191, 40);
            this.btnAddIncomingSupply.TabIndex = 12;
            this.btnAddIncomingSupply.TabStop = false;
            this.btnAddIncomingSupply.Text = "ADD INCOMING SUPPLY";
            // 
            // gridIncomingSupplies
            // 
            this.gridIncomingSupplies.AllowUserToAddRows = false;
            this.gridIncomingSupplies.AllowUserToDeleteRows = false;
            this.gridIncomingSupplies.AllowUserToResizeColumns = false;
            this.gridIncomingSupplies.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gridIncomingSupplies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridIncomingSupplies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridIncomingSupplies.BackgroundColor = System.Drawing.Color.White;
            this.gridIncomingSupplies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridIncomingSupplies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridIncomingSupplies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridIncomingSupplies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridIncomingSupplies.ColumnHeadersHeight = 35;
            this.gridIncomingSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridIncomingSupplies.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridIncomingSupplies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridIncomingSupplies.EnableHeadersVisualStyles = false;
            this.gridIncomingSupplies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridIncomingSupplies.Location = new System.Drawing.Point(0, 58);
            this.gridIncomingSupplies.Name = "gridIncomingSupplies";
            this.gridIncomingSupplies.ReadOnly = true;
            this.gridIncomingSupplies.RowHeadersVisible = false;
            this.gridIncomingSupplies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridIncomingSupplies.RowTemplate.Height = 30;
            this.gridIncomingSupplies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridIncomingSupplies.Size = new System.Drawing.Size(1726, 909);
            this.gridIncomingSupplies.TabIndex = 11;
            this.gridIncomingSupplies.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridIncomingSupplies.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridIncomingSupplies.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridIncomingSupplies.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridIncomingSupplies.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridIncomingSupplies.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridIncomingSupplies.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridIncomingSupplies.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Green;
            this.gridIncomingSupplies.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridIncomingSupplies.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridIncomingSupplies.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridIncomingSupplies.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridIncomingSupplies.ThemeStyle.HeaderStyle.Height = 35;
            this.gridIncomingSupplies.ThemeStyle.ReadOnly = true;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.Height = 30;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1726, 967);
            this.Controls.Add(this.btnAddIncomingSupply);
            this.Controls.Add(this.gridIncomingSupplies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INCOMING SUPPLIES";
            ((System.ComponentModel.ISupportInitialize)(this.gridIncomingSupplies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAddIncomingSupply;
        private Guna.UI2.WinForms.Guna2DataGridView gridIncomingSupplies;
    }
}