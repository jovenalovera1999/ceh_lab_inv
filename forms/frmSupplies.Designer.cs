﻿namespace ceh_lab_inv.forms
{
    partial class frmSupplies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplies));
            this.gridSupplies = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalSupplies = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblInTrash = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLoadTrash = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoadSupplies = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplies)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSupplies
            // 
            this.gridSupplies.AllowUserToAddRows = false;
            this.gridSupplies.AllowUserToDeleteRows = false;
            this.gridSupplies.AllowUserToResizeColumns = false;
            this.gridSupplies.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridSupplies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSupplies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSupplies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridSupplies.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridSupplies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSupplies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridSupplies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSupplies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridSupplies.ColumnHeadersHeight = 46;
            this.gridSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSupplies.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridSupplies.EnableHeadersVisualStyles = false;
            this.gridSupplies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridSupplies.Location = new System.Drawing.Point(0, 179);
            this.gridSupplies.MultiSelect = false;
            this.gridSupplies.Name = "gridSupplies";
            this.gridSupplies.ReadOnly = true;
            this.gridSupplies.RowHeadersVisible = false;
            this.gridSupplies.RowTemplate.Height = 46;
            this.gridSupplies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSupplies.Size = new System.Drawing.Size(1124, 405);
            this.gridSupplies.TabIndex = 0;
            this.gridSupplies.TabStop = false;
            this.gridSupplies.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridSupplies.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridSupplies.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridSupplies.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridSupplies.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridSupplies.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridSupplies.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridSupplies.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Green;
            this.gridSupplies.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridSupplies.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridSupplies.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridSupplies.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSupplies.ThemeStyle.HeaderStyle.Height = 46;
            this.gridSupplies.ThemeStyle.ReadOnly = true;
            this.gridSupplies.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridSupplies.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridSupplies.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridSupplies.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridSupplies.ThemeStyle.RowsStyle.Height = 46;
            this.gridSupplies.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.gridSupplies.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridSupplies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSupplies_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Green;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(12, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 36);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Animated = true;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.Green;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(121, 136);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 36);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.TabStop = false;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Green;
            this.guna2Panel1.Controls.Add(this.lblTotalSupplies);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(291, 118);
            this.guna2Panel1.TabIndex = 9;
            // 
            // lblTotalSupplies
            // 
            this.lblTotalSupplies.AutoSize = true;
            this.lblTotalSupplies.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSupplies.ForeColor = System.Drawing.Color.White;
            this.lblTotalSupplies.Location = new System.Drawing.Point(3, 42);
            this.lblTotalSupplies.Name = "lblTotalSupplies";
            this.lblTotalSupplies.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalSupplies.Size = new System.Drawing.Size(33, 37);
            this.lblTotalSupplies.TabIndex = 12;
            this.lblTotalSupplies.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "TOTAL SUPPLIES";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Green;
            this.guna2Panel2.Controls.Add(this.lblInTrash);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Location = new System.Drawing.Point(309, 12);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(291, 118);
            this.guna2Panel2.TabIndex = 10;
            // 
            // lblInTrash
            // 
            this.lblInTrash.AutoSize = true;
            this.lblInTrash.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInTrash.ForeColor = System.Drawing.Color.White;
            this.lblInTrash.Location = new System.Drawing.Point(3, 42);
            this.lblInTrash.Name = "lblInTrash";
            this.lblInTrash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInTrash.Size = new System.Drawing.Size(33, 37);
            this.lblInTrash.TabIndex = 13;
            this.lblInTrash.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "IN TRASH";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Animated = true;
            this.txtSearch.BorderRadius = 3;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.Green;
            this.txtSearch.Location = new System.Drawing.Point(805, 136);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(306, 36);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnLoadTrash
            // 
            this.btnLoadTrash.Animated = true;
            this.btnLoadTrash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadTrash.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadTrash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadTrash.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadTrash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadTrash.FillColor = System.Drawing.Color.Green;
            this.btnLoadTrash.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLoadTrash.ForeColor = System.Drawing.Color.White;
            this.btnLoadTrash.Location = new System.Drawing.Point(369, 136);
            this.btnLoadTrash.Name = "btnLoadTrash";
            this.btnLoadTrash.Size = new System.Drawing.Size(119, 36);
            this.btnLoadTrash.TabIndex = 12;
            this.btnLoadTrash.TabStop = false;
            this.btnLoadTrash.Text = "LOAD TRASH";
            this.btnLoadTrash.Click += new System.EventHandler(this.btnLoadTrash_Click);
            // 
            // btnLoadSupplies
            // 
            this.btnLoadSupplies.Animated = true;
            this.btnLoadSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadSupplies.FillColor = System.Drawing.Color.Green;
            this.btnLoadSupplies.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLoadSupplies.ForeColor = System.Drawing.Color.White;
            this.btnLoadSupplies.Location = new System.Drawing.Point(230, 136);
            this.btnLoadSupplies.Name = "btnLoadSupplies";
            this.btnLoadSupplies.Size = new System.Drawing.Size(133, 36);
            this.btnLoadSupplies.TabIndex = 13;
            this.btnLoadSupplies.TabStop = false;
            this.btnLoadSupplies.Text = "LOAD SUPPLIES";
            this.btnLoadSupplies.Click += new System.EventHandler(this.btnLoadSupplies_Click);
            // 
            // frmSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1123, 584);
            this.Controls.Add(this.btnLoadSupplies);
            this.Controls.Add(this.btnLoadTrash);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridSupplies);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1123, 584);
            this.Name = "frmSupplies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUPPLIES";
            this.Load += new System.EventHandler(this.frmSupplies_Load);
            this.VisibleChanged += new System.EventHandler(this.frmSupplies_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplies)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gridSupplies;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalSupplies;
        private System.Windows.Forms.Label lblInTrash;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnLoadTrash;
        private Guna.UI2.WinForms.Guna2Button btnLoadSupplies;
    }
}