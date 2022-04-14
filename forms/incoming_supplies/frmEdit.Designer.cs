namespace ceh_lab_inv.forms.incoming_supplies
{
    partial class frmEdit
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
            this.label11 = new System.Windows.Forms.Label();
            this.dateArrival = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateIncomingSupply = new Guna.UI2.WinForms.Guna2Button();
            this.txtTotalCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumberOfUnit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUnitCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSupplier = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQTY = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateExpiration = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 20);
            this.label11.TabIndex = 82;
            this.label11.Text = "ARRIVAL DATE";
            // 
            // dateArrival
            // 
            this.dateArrival.BackColor = System.Drawing.Color.Green;
            this.dateArrival.BorderRadius = 3;
            this.dateArrival.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateArrival.ForeColor = System.Drawing.Color.White;
            this.dateArrival.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateArrival.FormatCustom = null;
            this.dateArrival.Location = new System.Drawing.Point(16, 32);
            this.dateArrival.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateArrival.Name = "dateArrival";
            this.dateArrival.Size = new System.Drawing.Size(413, 36);
            this.dateArrival.TabIndex = 0;
            this.dateArrival.Value = new System.DateTime(2022, 4, 12, 14, 1, 1, 137);
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BorderColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 3;
            this.btnClose.BorderThickness = 1;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.BorderColor = System.Drawing.Color.Green;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(458, 328);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(213, 40);
            this.btnClose.TabIndex = 80;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "CLOSE";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdateIncomingSupply
            // 
            this.btnUpdateIncomingSupply.Animated = true;
            this.btnUpdateIncomingSupply.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdateIncomingSupply.BorderRadius = 3;
            this.btnUpdateIncomingSupply.BorderThickness = 1;
            this.btnUpdateIncomingSupply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateIncomingSupply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateIncomingSupply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateIncomingSupply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateIncomingSupply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateIncomingSupply.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateIncomingSupply.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnUpdateIncomingSupply.ForeColor = System.Drawing.Color.White;
            this.btnUpdateIncomingSupply.HoverState.BorderColor = System.Drawing.Color.Green;
            this.btnUpdateIncomingSupply.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateIncomingSupply.Location = new System.Drawing.Point(677, 328);
            this.btnUpdateIncomingSupply.Name = "btnUpdateIncomingSupply";
            this.btnUpdateIncomingSupply.Size = new System.Drawing.Size(213, 40);
            this.btnUpdateIncomingSupply.TabIndex = 79;
            this.btnUpdateIncomingSupply.TabStop = false;
            this.btnUpdateIncomingSupply.Text = "UPDATE INCOMING SUPPLY";
            this.btnUpdateIncomingSupply.Click += new System.EventHandler(this.btnUpdateIncomingSupply_Click);
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Animated = true;
            this.txtTotalCost.BorderRadius = 3;
            this.txtTotalCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalCost.DefaultText = "0.00";
            this.txtTotalCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalCost.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.txtTotalCost.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTotalCost.ForeColor = System.Drawing.Color.Black;
            this.txtTotalCost.HoverState.BorderColor = System.Drawing.Color.Green;
            this.txtTotalCost.Location = new System.Drawing.Point(477, 285);
            this.txtTotalCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalCost.MaxLength = 255;
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.PasswordChar = '\0';
            this.txtTotalCost.PlaceholderText = "";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.SelectedText = "";
            this.txtTotalCost.Size = new System.Drawing.Size(413, 36);
            this.txtTotalCost.TabIndex = 9;
            this.txtTotalCost.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(473, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 76;
            this.label9.Text = "TOTAL COST";
            // 
            // txtNumberOfUnit
            // 
            this.txtNumberOfUnit.Animated = true;
            this.txtNumberOfUnit.BorderRadius = 3;
            this.txtNumberOfUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberOfUnit.DefaultText = "";
            this.txtNumberOfUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumberOfUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumberOfUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberOfUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberOfUnit.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.txtNumberOfUnit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNumberOfUnit.ForeColor = System.Drawing.Color.Black;
            this.txtNumberOfUnit.HoverState.BorderColor = System.Drawing.Color.Green;
            this.txtNumberOfUnit.Location = new System.Drawing.Point(477, 221);
            this.txtNumberOfUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumberOfUnit.MaxLength = 255;
            this.txtNumberOfUnit.Name = "txtNumberOfUnit";
            this.txtNumberOfUnit.PasswordChar = '\0';
            this.txtNumberOfUnit.PlaceholderText = "INPUT NUMBER OF UNIT";
            this.txtNumberOfUnit.SelectedText = "";
            this.txtNumberOfUnit.Size = new System.Drawing.Size(413, 36);
            this.txtNumberOfUnit.TabIndex = 8;
            this.txtNumberOfUnit.TextChanged += new System.EventHandler(this.txtNumberOfUnit_TextChanged);
            this.txtNumberOfUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberOfUnit_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(473, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 74;
            this.label8.Text = "NUMBER OF UNIT";
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Animated = true;
            this.txtUnitCost.BorderRadius = 3;
            this.txtUnitCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnitCost.DefaultText = "";
            this.txtUnitCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUnitCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUnitCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnitCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnitCost.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.txtUnitCost.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUnitCost.ForeColor = System.Drawing.Color.Black;
            this.txtUnitCost.HoverState.BorderColor = System.Drawing.Color.Green;
            this.txtUnitCost.Location = new System.Drawing.Point(477, 157);
            this.txtUnitCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitCost.MaxLength = 255;
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.PasswordChar = '\0';
            this.txtUnitCost.PlaceholderText = "INPUT ITEM UNIT COST";
            this.txtUnitCost.SelectedText = "";
            this.txtUnitCost.Size = new System.Drawing.Size(413, 36);
            this.txtUnitCost.TabIndex = 7;
            this.txtUnitCost.TextChanged += new System.EventHandler(this.txtUnitCost_TextChanged);
            this.txtUnitCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitCost_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(473, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 72;
            this.label7.Text = "UNIT COST";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Animated = true;
            this.txtSupplier.BorderRadius = 3;
            this.txtSupplier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplier.DefaultText = "";
            this.txtSupplier.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplier.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplier.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.txtSupplier.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSupplier.ForeColor = System.Drawing.Color.Black;
            this.txtSupplier.HoverState.BorderColor = System.Drawing.Color.Green;
            this.txtSupplier.Location = new System.Drawing.Point(477, 94);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplier.MaxLength = 255;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.PasswordChar = '\0';
            this.txtSupplier.PlaceholderText = "INPUT SUPPLIER";
            this.txtSupplier.SelectedText = "";
            this.txtSupplier.Size = new System.Drawing.Size(413, 36);
            this.txtSupplier.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(473, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 70;
            this.label6.Text = "SUPPLIER";
            // 
            // txtQTY
            // 
            this.txtQTY.Animated = true;
            this.txtQTY.BorderRadius = 3;
            this.txtQTY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQTY.DefaultText = "";
            this.txtQTY.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQTY.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQTY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQTY.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQTY.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.txtQTY.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtQTY.ForeColor = System.Drawing.Color.Black;
            this.txtQTY.HoverState.BorderColor = System.Drawing.Color.Green;
            this.txtQTY.Location = new System.Drawing.Point(477, 30);
            this.txtQTY.Margin = new System.Windows.Forms.Padding(4);
            this.txtQTY.MaxLength = 255;
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.PasswordChar = '\0';
            this.txtQTY.PlaceholderText = "INPUT ITEM QTY";
            this.txtQTY.SelectedText = "";
            this.txtQTY.Size = new System.Drawing.Size(413, 36);
            this.txtQTY.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(473, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "QTY";
            // 
            // txtBrand
            // 
            this.txtBrand.Animated = true;
            this.txtBrand.BorderRadius = 3;
            this.txtBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrand.DefaultText = "";
            this.txtBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBrand.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.txtBrand.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBrand.ForeColor = System.Drawing.Color.Black;
            this.txtBrand.HoverState.BorderColor = System.Drawing.Color.Green;
            this.txtBrand.Location = new System.Drawing.Point(16, 285);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrand.MaxLength = 255;
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.PasswordChar = '\0';
            this.txtBrand.PlaceholderText = "INPUT ITEM BRAND";
            this.txtBrand.SelectedText = "";
            this.txtBrand.Size = new System.Drawing.Size(413, 36);
            this.txtBrand.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(12, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "BRAND";
            // 
            // txtItem
            // 
            this.txtItem.Animated = true;
            this.txtItem.BorderRadius = 3;
            this.txtItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItem.DefaultText = "";
            this.txtItem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItem.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.txtItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtItem.ForeColor = System.Drawing.Color.Black;
            this.txtItem.HoverState.BorderColor = System.Drawing.Color.Green;
            this.txtItem.Location = new System.Drawing.Point(16, 221);
            this.txtItem.Margin = new System.Windows.Forms.Padding(4);
            this.txtItem.MaxLength = 255;
            this.txtItem.Name = "txtItem";
            this.txtItem.PasswordChar = '\0';
            this.txtItem.PlaceholderText = "INPUT ITEM NAME";
            this.txtItem.SelectedText = "";
            this.txtItem.Size = new System.Drawing.Size(413, 36);
            this.txtItem.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "ITEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "EXPIRATION DATE";
            // 
            // dateExpiration
            // 
            this.dateExpiration.BackColor = System.Drawing.Color.Green;
            this.dateExpiration.BorderRadius = 3;
            this.dateExpiration.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateExpiration.ForeColor = System.Drawing.Color.White;
            this.dateExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateExpiration.FormatCustom = null;
            this.dateExpiration.Location = new System.Drawing.Point(16, 94);
            this.dateExpiration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateExpiration.Name = "dateExpiration";
            this.dateExpiration.Size = new System.Drawing.Size(413, 36);
            this.dateExpiration.TabIndex = 1;
            this.dateExpiration.Value = new System.DateTime(2022, 4, 12, 14, 1, 1, 137);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Animated = true;
            this.txtQuantity.BorderRadius = 3;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.Green;
            this.txtQuantity.Location = new System.Drawing.Point(16, 157);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.MaxLength = 255;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "INPUT ITEM QUANTITY";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(413, 36);
            this.txtQuantity.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "QUANTITY";
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 376);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateArrival);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdateIncomingSupply);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNumberOfUnit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUnitCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQTY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateExpiration);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDIT INCOMING SUPPLY";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuDatepicker dateArrival;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnUpdateIncomingSupply;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalCost;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtNumberOfUnit;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtUnitCost;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtSupplier;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtQTY;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtBrand;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker dateExpiration;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label label3;
    }
}