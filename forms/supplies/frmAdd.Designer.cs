namespace ceh_lab_inv.forms.supplies
{
    partial class frmAdd
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
            this.txtItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnitOfQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupplier = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnitOfQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateExpiration = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveSupply = new Guna.UI2.WinForms.Guna2Button();
            this.txtUnitCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.txtItem.Location = new System.Drawing.Point(16, 61);
            this.txtItem.Margin = new System.Windows.Forms.Padding(4);
            this.txtItem.MaxLength = 255;
            this.txtItem.Name = "txtItem";
            this.txtItem.PasswordChar = '\0';
            this.txtItem.PlaceholderText = "INPUT ITEM NAME";
            this.txtItem.SelectedText = "";
            this.txtItem.Size = new System.Drawing.Size(413, 36);
            this.txtItem.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "ITEM";
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
            this.txtQuantity.Location = new System.Drawing.Point(16, 253);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.MaxLength = 255;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "INPUT ITEM QUANTITY";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(413, 36);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(12, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "QUANTITY";
            // 
            // txtUnitOfQuantity
            // 
            this.txtUnitOfQuantity.Animated = true;
            this.txtUnitOfQuantity.BorderRadius = 3;
            this.txtUnitOfQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnitOfQuantity.DefaultText = "";
            this.txtUnitOfQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUnitOfQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUnitOfQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnitOfQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnitOfQuantity.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.txtUnitOfQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUnitOfQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtUnitOfQuantity.HoverState.BorderColor = System.Drawing.Color.Green;
            this.txtUnitOfQuantity.Location = new System.Drawing.Point(16, 317);
            this.txtUnitOfQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitOfQuantity.MaxLength = 255;
            this.txtUnitOfQuantity.Name = "txtUnitOfQuantity";
            this.txtUnitOfQuantity.PasswordChar = '\0';
            this.txtUnitOfQuantity.PlaceholderText = "INPUT ITEM UNIT OF QUANTITY";
            this.txtUnitOfQuantity.SelectedText = "";
            this.txtUnitOfQuantity.Size = new System.Drawing.Size(413, 36);
            this.txtUnitOfQuantity.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(12, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "UNIT OF QUANTITY";
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
            this.txtBrand.Location = new System.Drawing.Point(16, 125);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrand.MaxLength = 255;
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.PasswordChar = '\0';
            this.txtBrand.PlaceholderText = "INPUT ITEM BRAND";
            this.txtBrand.SelectedText = "";
            this.txtBrand.Size = new System.Drawing.Size(413, 36);
            this.txtBrand.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "BRAND";
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
            this.txtSupplier.Location = new System.Drawing.Point(16, 189);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplier.MaxLength = 255;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.PasswordChar = '\0';
            this.txtSupplier.PlaceholderText = "INPUT ITEM SUPPLIER";
            this.txtSupplier.SelectedText = "";
            this.txtSupplier.Size = new System.Drawing.Size(413, 36);
            this.txtSupplier.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "SUPPLIER";
            // 
            // txtUnitOfQty
            // 
            this.txtUnitOfQty.Animated = true;
            this.txtUnitOfQty.BorderRadius = 3;
            this.txtUnitOfQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnitOfQty.DefaultText = "";
            this.txtUnitOfQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUnitOfQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUnitOfQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnitOfQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnitOfQty.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.txtUnitOfQty.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUnitOfQty.ForeColor = System.Drawing.Color.Black;
            this.txtUnitOfQty.HoverState.BorderColor = System.Drawing.Color.Green;
            this.txtUnitOfQty.Location = new System.Drawing.Point(16, 445);
            this.txtUnitOfQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitOfQty.MaxLength = 255;
            this.txtUnitOfQty.Name = "txtUnitOfQty";
            this.txtUnitOfQty.PasswordChar = '\0';
            this.txtUnitOfQty.PlaceholderText = "INPUT ITEM UNIT OF QTY";
            this.txtUnitOfQty.SelectedText = "";
            this.txtUnitOfQty.Size = new System.Drawing.Size(413, 36);
            this.txtUnitOfQty.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(12, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "UNIT OF QTY";
            // 
            // txtQty
            // 
            this.txtQty.Animated = true;
            this.txtQty.BorderRadius = 3;
            this.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.DefaultText = "";
            this.txtQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQty.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtQty.ForeColor = System.Drawing.Color.Black;
            this.txtQty.HoverState.BorderColor = System.Drawing.Color.Green;
            this.txtQty.Location = new System.Drawing.Point(16, 381);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtQty.MaxLength = 255;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.PlaceholderText = "INPUT ITEM QTY";
            this.txtQty.SelectedText = "";
            this.txtQty.Size = new System.Drawing.Size(413, 36);
            this.txtQty.TabIndex = 5;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(12, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "QTY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(12, 613);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "EXPIRATION DATE";
            // 
            // dateExpiration
            // 
            this.dateExpiration.BackColor = System.Drawing.Color.Green;
            this.dateExpiration.BorderRadius = 3;
            this.dateExpiration.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateExpiration.ForeColor = System.Drawing.Color.White;
            this.dateExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateExpiration.FormatCustom = null;
            this.dateExpiration.Location = new System.Drawing.Point(16, 636);
            this.dateExpiration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateExpiration.Name = "dateExpiration";
            this.dateExpiration.Size = new System.Drawing.Size(413, 36);
            this.dateExpiration.TabIndex = 8;
            this.dateExpiration.Value = new System.DateTime(2022, 4, 12, 14, 1, 1, 137);
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
            this.btnClose.Location = new System.Drawing.Point(84, 680);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 40);
            this.btnClose.TabIndex = 34;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "CLOSE";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveSupply
            // 
            this.btnSaveSupply.Animated = true;
            this.btnSaveSupply.BorderColor = System.Drawing.Color.Transparent;
            this.btnSaveSupply.BorderRadius = 3;
            this.btnSaveSupply.BorderThickness = 1;
            this.btnSaveSupply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveSupply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveSupply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveSupply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveSupply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveSupply.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveSupply.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSaveSupply.ForeColor = System.Drawing.Color.White;
            this.btnSaveSupply.HoverState.BorderColor = System.Drawing.Color.Green;
            this.btnSaveSupply.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveSupply.Location = new System.Drawing.Point(227, 680);
            this.btnSaveSupply.Name = "btnSaveSupply";
            this.btnSaveSupply.Size = new System.Drawing.Size(137, 40);
            this.btnSaveSupply.TabIndex = 33;
            this.btnSaveSupply.TabStop = false;
            this.btnSaveSupply.Text = "SAVE SUPPLY";
            this.btnSaveSupply.Click += new System.EventHandler(this.btnSaveSupply_Click);
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
            this.txtUnitCost.Location = new System.Drawing.Point(16, 509);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(12, 485);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "UNIT COST";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Animated = true;
            this.txtTotalCost.BorderRadius = 3;
            this.txtTotalCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalCost.DefaultText = "";
            this.txtTotalCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalCost.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.txtTotalCost.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTotalCost.ForeColor = System.Drawing.Color.Black;
            this.txtTotalCost.HoverState.BorderColor = System.Drawing.Color.Green;
            this.txtTotalCost.Location = new System.Drawing.Point(16, 573);
            this.txtTotalCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalCost.MaxLength = 255;
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.PasswordChar = '\0';
            this.txtTotalCost.PlaceholderText = "";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.SelectedText = "";
            this.txtTotalCost.Size = new System.Drawing.Size(413, 36);
            this.txtTotalCost.TabIndex = 37;
            this.txtTotalCost.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(12, 549);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "TOTAL COST";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 28);
            this.label11.TabIndex = 39;
            this.label11.Text = "ADD SUPPLY";
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 731);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUnitCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveSupply);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateExpiration);
            this.Controls.Add(this.txtUnitOfQty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUnitOfQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD SUPPLY";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtItem;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtUnitOfQuantity;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtBrand;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtSupplier;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtUnitOfQty;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuDatepicker dateExpiration;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSaveSupply;
        private Guna.UI2.WinForms.Guna2TextBox txtUnitCost;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalCost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}