namespace ceh_lab_inv.forms.current_supplies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridCurrentSupplies = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAddSupply = new Guna.UI2.WinForms.Guna2Button();
            this.dateFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dateTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCurrentSupplies)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCurrentSupplies
            // 
            this.gridCurrentSupplies.AllowUserToAddRows = false;
            this.gridCurrentSupplies.AllowUserToDeleteRows = false;
            this.gridCurrentSupplies.AllowUserToResizeColumns = false;
            this.gridCurrentSupplies.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridCurrentSupplies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCurrentSupplies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCurrentSupplies.BackgroundColor = System.Drawing.Color.White;
            this.gridCurrentSupplies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCurrentSupplies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridCurrentSupplies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCurrentSupplies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCurrentSupplies.ColumnHeadersHeight = 35;
            this.gridCurrentSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCurrentSupplies.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridCurrentSupplies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridCurrentSupplies.EnableHeadersVisualStyles = false;
            this.gridCurrentSupplies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridCurrentSupplies.Location = new System.Drawing.Point(0, 59);
            this.gridCurrentSupplies.Name = "gridCurrentSupplies";
            this.gridCurrentSupplies.ReadOnly = true;
            this.gridCurrentSupplies.RowHeadersVisible = false;
            this.gridCurrentSupplies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCurrentSupplies.RowTemplate.Height = 30;
            this.gridCurrentSupplies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCurrentSupplies.Size = new System.Drawing.Size(1726, 908);
            this.gridCurrentSupplies.TabIndex = 8;
            this.gridCurrentSupplies.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridCurrentSupplies.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridCurrentSupplies.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridCurrentSupplies.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridCurrentSupplies.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridCurrentSupplies.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridCurrentSupplies.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridCurrentSupplies.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Green;
            this.gridCurrentSupplies.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridCurrentSupplies.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridCurrentSupplies.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridCurrentSupplies.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridCurrentSupplies.ThemeStyle.HeaderStyle.Height = 35;
            this.gridCurrentSupplies.ThemeStyle.ReadOnly = true;
            this.gridCurrentSupplies.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridCurrentSupplies.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridCurrentSupplies.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridCurrentSupplies.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridCurrentSupplies.ThemeStyle.RowsStyle.Height = 30;
            this.gridCurrentSupplies.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridCurrentSupplies.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // btnAddSupply
            // 
            this.btnAddSupply.Animated = true;
            this.btnAddSupply.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddSupply.BorderRadius = 3;
            this.btnAddSupply.BorderThickness = 1;
            this.btnAddSupply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSupply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSupply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSupply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSupply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddSupply.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddSupply.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAddSupply.ForeColor = System.Drawing.Color.White;
            this.btnAddSupply.HoverState.BorderColor = System.Drawing.Color.Green;
            this.btnAddSupply.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddSupply.Location = new System.Drawing.Point(12, 12);
            this.btnAddSupply.Name = "btnAddSupply";
            this.btnAddSupply.Size = new System.Drawing.Size(117, 40);
            this.btnAddSupply.TabIndex = 10;
            this.btnAddSupply.TabStop = false;
            this.btnAddSupply.Text = "ADD SUPPLY";
            // 
            // dateFrom
            // 
            this.dateFrom.BackColor = System.Drawing.Color.Green;
            this.dateFrom.BorderRadius = 3;
            this.dateFrom.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.ForeColor = System.Drawing.Color.White;
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateFrom.FormatCustom = null;
            this.dateFrom.Location = new System.Drawing.Point(764, 12);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(454, 40);
            this.dateFrom.TabIndex = 11;
            this.dateFrom.Value = new System.DateTime(2022, 4, 12, 14, 1, 1, 137);
            // 
            // dateTo
            // 
            this.dateTo.BackColor = System.Drawing.Color.Green;
            this.dateTo.BorderRadius = 3;
            this.dateTo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.ForeColor = System.Drawing.Color.White;
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTo.FormatCustom = null;
            this.dateTo.Location = new System.Drawing.Point(1259, 12);
            this.dateTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(454, 40);
            this.dateTo.TabIndex = 12;
            this.dateTo.Value = new System.DateTime(2022, 4, 12, 14, 1, 1, 137);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(1225, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "TO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(708, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "FROM";
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1726, 967);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.btnAddSupply);
            this.Controls.Add(this.gridCurrentSupplies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CURRENT SUPPLIES";
            ((System.ComponentModel.ISupportInitialize)(this.gridCurrentSupplies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gridCurrentSupplies;
        private Guna.UI2.WinForms.Guna2Button btnAddSupply;
        private Bunifu.Framework.UI.BunifuDatepicker dateFrom;
        private Bunifu.Framework.UI.BunifuDatepicker dateTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}