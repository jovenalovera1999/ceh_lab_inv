namespace ceh_lab_inv.forms.dashboard
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCreateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnIncomingSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnCurrentSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(194, 113);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1726, 967);
            this.pnlMain.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picProfile);
            this.panel1.Controls.Add(this.lblModuleName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(194, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1726, 113);
            this.panel1.TabIndex = 6;
            // 
            // picProfile
            // 
            this.picProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.picProfile.Image = ((System.Drawing.Image)(resources.GetObject("picProfile.Image")));
            this.picProfile.ImageRotate = 0F;
            this.picProfile.Location = new System.Drawing.Point(1613, 0);
            this.picProfile.Name = "picProfile";
            this.picProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picProfile.Size = new System.Drawing.Size(113, 113);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 4;
            this.picProfile.TabStop = false;
            // 
            // lblModuleName
            // 
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleName.ForeColor = System.Drawing.Color.Green;
            this.lblModuleName.Location = new System.Drawing.Point(119, 37);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(129, 28);
            this.lblModuleName.TabIndex = 3;
            this.lblModuleName.Text = "DASHBOARD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "CAPIZ EMMANUEL HOSPITAL LABORATORY INVENTORY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.btnCreateAccount);
            this.panel2.Controls.Add(this.btnProfile);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnCurrentSupplies);
            this.panel2.Controls.Add(this.btnIncomingSupplies);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 1080);
            this.panel2.TabIndex = 5;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Animated = true;
            this.btnCreateAccount.BorderColor = System.Drawing.Color.Transparent;
            this.btnCreateAccount.BorderRadius = 3;
            this.btnCreateAccount.BorderThickness = 1;
            this.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateAccount.FillColor = System.Drawing.Color.Green;
            this.btnCreateAccount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnCreateAccount.HoverState.FillColor = System.Drawing.Color.Green;
            this.btnCreateAccount.Location = new System.Drawing.Point(0, 114);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(194, 38);
            this.btnCreateAccount.TabIndex = 15;
            this.btnCreateAccount.TabStop = false;
            this.btnCreateAccount.Text = "CREATE ACCOUNT";
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Animated = true;
            this.btnProfile.BorderColor = System.Drawing.Color.Transparent;
            this.btnProfile.BorderRadius = 3;
            this.btnProfile.BorderThickness = 1;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnProfile.FillColor = System.Drawing.Color.Green;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnProfile.HoverState.FillColor = System.Drawing.Color.Green;
            this.btnProfile.Location = new System.Drawing.Point(0, 966);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(194, 38);
            this.btnProfile.TabIndex = 14;
            this.btnProfile.TabStop = false;
            this.btnProfile.Text = "PROFILE";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderRadius = 3;
            this.btnLogout.BorderThickness = 1;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FillColor = System.Drawing.Color.Green;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.Green;
            this.btnLogout.Location = new System.Drawing.Point(0, 1004);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(194, 38);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.TabStop = false;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.BorderColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = 3;
            this.btnExit.BorderThickness = 1;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FillColor = System.Drawing.Color.Green;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Green;
            this.btnExit.Location = new System.Drawing.Point(0, 1042);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(194, 38);
            this.btnExit.TabIndex = 12;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "EXIT";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnIncomingSupplies
            // 
            this.btnIncomingSupplies.Animated = true;
            this.btnIncomingSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.btnIncomingSupplies.BorderRadius = 3;
            this.btnIncomingSupplies.BorderThickness = 1;
            this.btnIncomingSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncomingSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIncomingSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIncomingSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIncomingSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIncomingSupplies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIncomingSupplies.FillColor = System.Drawing.Color.Green;
            this.btnIncomingSupplies.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnIncomingSupplies.ForeColor = System.Drawing.Color.White;
            this.btnIncomingSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnIncomingSupplies.HoverState.FillColor = System.Drawing.Color.Green;
            this.btnIncomingSupplies.Location = new System.Drawing.Point(0, 38);
            this.btnIncomingSupplies.Name = "btnIncomingSupplies";
            this.btnIncomingSupplies.Size = new System.Drawing.Size(194, 38);
            this.btnIncomingSupplies.TabIndex = 10;
            this.btnIncomingSupplies.TabStop = false;
            this.btnIncomingSupplies.Text = "INCOMING SUPPLIES";
            this.btnIncomingSupplies.Click += new System.EventHandler(this.btnIncomingSupplies_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Animated = true;
            this.btnDashboard.BorderColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BorderRadius = 3;
            this.btnDashboard.BorderThickness = 1;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FillColor = System.Drawing.Color.DarkGreen;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.Green;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(194, 38);
            this.btnDashboard.TabIndex = 9;
            this.btnDashboard.TabStop = false;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnCurrentSupplies
            // 
            this.btnCurrentSupplies.Animated = true;
            this.btnCurrentSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.btnCurrentSupplies.BorderRadius = 3;
            this.btnCurrentSupplies.BorderThickness = 1;
            this.btnCurrentSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCurrentSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCurrentSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCurrentSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCurrentSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCurrentSupplies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrentSupplies.FillColor = System.Drawing.Color.Green;
            this.btnCurrentSupplies.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCurrentSupplies.ForeColor = System.Drawing.Color.White;
            this.btnCurrentSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnCurrentSupplies.HoverState.FillColor = System.Drawing.Color.Green;
            this.btnCurrentSupplies.Location = new System.Drawing.Point(0, 76);
            this.btnCurrentSupplies.Name = "btnCurrentSupplies";
            this.btnCurrentSupplies.Size = new System.Drawing.Size(194, 38);
            this.btnCurrentSupplies.TabIndex = 11;
            this.btnCurrentSupplies.TabStop = false;
            this.btnCurrentSupplies.Text = "CURRENT SUPPLIES";
            this.btnCurrentSupplies.Click += new System.EventHandler(this.btnCurrentSupplies_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DASHBOARD";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picProfile;
        private System.Windows.Forms.Label lblModuleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnCreateAccount;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnIncomingSupplies;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnCurrentSupplies;
    }
}