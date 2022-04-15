namespace ceh_lab_inv.forms.supplies
{
    partial class frmList
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dateFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnAddSupply = new Guna.UI2.WinForms.Guna2Button();
            this.gridSupplies = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplies)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(708, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "FROM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(1225, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "TO";
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
            this.dateTo.Margin = new System.Windows.Forms.Padding(4);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(454, 40);
            this.dateTo.TabIndex = 17;
            this.dateTo.Value = new System.DateTime(2022, 4, 12, 14, 1, 1, 137);
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
            this.dateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(454, 40);
            this.dateFrom.TabIndex = 16;
            this.dateFrom.Value = new System.DateTime(2022, 4, 12, 14, 1, 1, 137);
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
            this.btnAddSupply.TabIndex = 15;
            this.btnAddSupply.TabStop = false;
            this.btnAddSupply.Text = "ADD SUPPLY";
            this.btnAddSupply.Click += new System.EventHandler(this.btnAddSupply_Click);
            // 
            // gridSupplies
            // 
            this.gridSupplies.AllowUserToAddRows = false;
            this.gridSupplies.AllowUserToDeleteRows = false;
            this.gridSupplies.AllowUserToResizeColumns = false;
            this.gridSupplies.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridSupplies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSupplies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridSupplies.BackgroundColor = System.Drawing.Color.White;
            this.gridSupplies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSupplies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSupplies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridSupplies.ColumnHeadersHeight = 40;
            this.gridSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSupplies.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridSupplies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridSupplies.DoubleBuffered = true;
            this.gridSupplies.EnableHeadersVisualStyles = false;
            this.gridSupplies.GridColor = System.Drawing.Color.Silver;
            this.gridSupplies.HeaderBgColor = System.Drawing.Color.Green;
            this.gridSupplies.HeaderForeColor = System.Drawing.Color.White;
            this.gridSupplies.Location = new System.Drawing.Point(0, 59);
            this.gridSupplies.MultiSelect = false;
            this.gridSupplies.Name = "gridSupplies";
            this.gridSupplies.ReadOnly = true;
            this.gridSupplies.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridSupplies.RowTemplate.Height = 40;
            this.gridSupplies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSupplies.Size = new System.Drawing.Size(1726, 908);
            this.gridSupplies.TabIndex = 20;
            this.gridSupplies.TabStop = false;
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1726, 967);
            this.Controls.Add(this.gridSupplies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.btnAddSupply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIST OF SUPPLIES";
            this.Load += new System.EventHandler(this.frmList_Load);
            this.VisibleChanged += new System.EventHandler(this.frmList_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker dateTo;
        private Bunifu.Framework.UI.BunifuDatepicker dateFrom;
        private Guna.UI2.WinForms.Guna2Button btnAddSupply;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridSupplies;
    }
}