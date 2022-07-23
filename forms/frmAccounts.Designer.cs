namespace ceh_lab_inv.forms
{
    partial class frmAccounts
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
            this.btnCreateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.gridAccounts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLoadAccount = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Animated = true;
            this.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateAccount.FillColor = System.Drawing.Color.Green;
            this.btnCreateAccount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(12, 12);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(152, 36);
            this.btnCreateAccount.TabIndex = 9;
            this.btnCreateAccount.TabStop = false;
            this.btnCreateAccount.Text = "CREATE ACCOUNT";
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // gridAccounts
            // 
            this.gridAccounts.AllowUserToAddRows = false;
            this.gridAccounts.AllowUserToDeleteRows = false;
            this.gridAccounts.AllowUserToResizeColumns = false;
            this.gridAccounts.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridAccounts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridAccounts.ColumnHeadersHeight = 46;
            this.gridAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAccounts.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridAccounts.EnableHeadersVisualStyles = false;
            this.gridAccounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridAccounts.Location = new System.Drawing.Point(0, 54);
            this.gridAccounts.MultiSelect = false;
            this.gridAccounts.Name = "gridAccounts";
            this.gridAccounts.ReadOnly = true;
            this.gridAccounts.RowHeadersVisible = false;
            this.gridAccounts.RowTemplate.Height = 46;
            this.gridAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAccounts.Size = new System.Drawing.Size(1763, 926);
            this.gridAccounts.TabIndex = 8;
            this.gridAccounts.TabStop = false;
            this.gridAccounts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridAccounts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridAccounts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridAccounts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridAccounts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridAccounts.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridAccounts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridAccounts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Green;
            this.gridAccounts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridAccounts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridAccounts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridAccounts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridAccounts.ThemeStyle.HeaderStyle.Height = 46;
            this.gridAccounts.ThemeStyle.ReadOnly = true;
            this.gridAccounts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridAccounts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridAccounts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridAccounts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridAccounts.ThemeStyle.RowsStyle.Height = 46;
            this.gridAccounts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.gridAccounts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAccounts_CellContentClick);
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
            this.txtSearch.Location = new System.Drawing.Point(1445, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(306, 36);
            this.txtSearch.TabIndex = 0;
            // 
            // btnLoadAccount
            // 
            this.btnLoadAccount.Animated = true;
            this.btnLoadAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadAccount.FillColor = System.Drawing.Color.Green;
            this.btnLoadAccount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLoadAccount.ForeColor = System.Drawing.Color.White;
            this.btnLoadAccount.Location = new System.Drawing.Point(170, 12);
            this.btnLoadAccount.Name = "btnLoadAccount";
            this.btnLoadAccount.Size = new System.Drawing.Size(140, 36);
            this.btnLoadAccount.TabIndex = 10;
            this.btnLoadAccount.TabStop = false;
            this.btnLoadAccount.Text = "LOAD ACCOUNT";
            this.btnLoadAccount.Click += new System.EventHandler(this.btnLoadAccount_Click);
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1763, 980);
            this.Controls.Add(this.btnLoadAccount);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.gridAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCOUNTS";
            this.Load += new System.EventHandler(this.frmAccounts_Load);
            this.VisibleChanged += new System.EventHandler(this.frmAccounts_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gridAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCreateAccount;
        private Guna.UI2.WinForms.Guna2DataGridView gridAccounts;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnLoadAccount;
    }
}