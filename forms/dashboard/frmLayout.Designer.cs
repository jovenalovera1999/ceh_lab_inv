namespace ceh_lab_inv.forms.dashboard
{
    partial class frmLayout
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
            this.btnManageSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.gridCurrentSupplies = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lblTotalIncomingSupplies = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.lblTotalCurrentSupplies = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCurrentSupplies)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageSupplies
            // 
            this.btnManageSupplies.Animated = true;
            this.btnManageSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.btnManageSupplies.BorderRadius = 3;
            this.btnManageSupplies.BorderThickness = 1;
            this.btnManageSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageSupplies.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnManageSupplies.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnManageSupplies.ForeColor = System.Drawing.Color.White;
            this.btnManageSupplies.HoverState.BorderColor = System.Drawing.Color.Green;
            this.btnManageSupplies.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnManageSupplies.Location = new System.Drawing.Point(1547, 119);
            this.btnManageSupplies.Name = "btnManageSupplies";
            this.btnManageSupplies.Size = new System.Drawing.Size(167, 40);
            this.btnManageSupplies.TabIndex = 13;
            this.btnManageSupplies.TabStop = false;
            this.btnManageSupplies.Text = "MANAGE SUPPLIES";
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
            this.gridCurrentSupplies.Location = new System.Drawing.Point(0, 168);
            this.gridCurrentSupplies.Name = "gridCurrentSupplies";
            this.gridCurrentSupplies.ReadOnly = true;
            this.gridCurrentSupplies.RowHeadersVisible = false;
            this.gridCurrentSupplies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCurrentSupplies.RowTemplate.Height = 30;
            this.gridCurrentSupplies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCurrentSupplies.Size = new System.Drawing.Size(1726, 799);
            this.gridCurrentSupplies.TabIndex = 12;
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
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Green;
            this.bunifuCards1.Controls.Add(this.lblTotalIncomingSupplies);
            this.bunifuCards1.Controls.Add(this.label5);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(6, 3);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(452, 110);
            this.bunifuCards1.TabIndex = 11;
            // 
            // lblTotalIncomingSupplies
            // 
            this.lblTotalIncomingSupplies.AutoSize = true;
            this.lblTotalIncomingSupplies.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIncomingSupplies.ForeColor = System.Drawing.Color.Green;
            this.lblTotalIncomingSupplies.Location = new System.Drawing.Point(3, 30);
            this.lblTotalIncomingSupplies.Name = "lblTotalIncomingSupplies";
            this.lblTotalIncomingSupplies.Size = new System.Drawing.Size(54, 62);
            this.lblTotalIncomingSupplies.TabIndex = 4;
            this.lblTotalIncomingSupplies.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "TOTAL INCOMING SUPPLIES:";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Green;
            this.bunifuCards2.Controls.Add(this.lblTotalCurrentSupplies);
            this.bunifuCards2.Controls.Add(this.label6);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(638, 3);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(452, 110);
            this.bunifuCards2.TabIndex = 10;
            // 
            // lblTotalCurrentSupplies
            // 
            this.lblTotalCurrentSupplies.AutoSize = true;
            this.lblTotalCurrentSupplies.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCurrentSupplies.ForeColor = System.Drawing.Color.Green;
            this.lblTotalCurrentSupplies.Location = new System.Drawing.Point(3, 30);
            this.lblTotalCurrentSupplies.Name = "lblTotalCurrentSupplies";
            this.lblTotalCurrentSupplies.Size = new System.Drawing.Size(54, 62);
            this.lblTotalCurrentSupplies.TabIndex = 4;
            this.lblTotalCurrentSupplies.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "TOTAL CURRENT SUPPLIES:";
            // 
            // frmLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1726, 967);
            this.Controls.Add(this.btnManageSupplies);
            this.Controls.Add(this.gridCurrentSupplies);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.bunifuCards2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DASHBOARD";
            ((System.ComponentModel.ISupportInitialize)(this.gridCurrentSupplies)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnManageSupplies;
        private Guna.UI2.WinForms.Guna2DataGridView gridCurrentSupplies;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label lblTotalIncomingSupplies;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.Label lblTotalCurrentSupplies;
        private System.Windows.Forms.Label label6;
    }
}