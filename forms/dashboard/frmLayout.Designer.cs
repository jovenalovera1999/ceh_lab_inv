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
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.lblTotalSupplies = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrintPreview = new Guna.UI2.WinForms.Guna2Button();
            this.rprtSupplies = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dateFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCards2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Green;
            this.bunifuCards2.Controls.Add(this.lblTotalSupplies);
            this.bunifuCards2.Controls.Add(this.label6);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(12, 12);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(452, 110);
            this.bunifuCards2.TabIndex = 10;
            // 
            // lblTotalSupplies
            // 
            this.lblTotalSupplies.AutoSize = true;
            this.lblTotalSupplies.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSupplies.ForeColor = System.Drawing.Color.Green;
            this.lblTotalSupplies.Location = new System.Drawing.Point(3, 30);
            this.lblTotalSupplies.Name = "lblTotalSupplies";
            this.lblTotalSupplies.Size = new System.Drawing.Size(54, 62);
            this.lblTotalSupplies.TabIndex = 4;
            this.lblTotalSupplies.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "TOTAL SUPPLIES:";
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Animated = true;
            this.btnPrintPreview.BackColor = System.Drawing.Color.White;
            this.btnPrintPreview.BorderColor = System.Drawing.Color.Transparent;
            this.btnPrintPreview.BorderRadius = 3;
            this.btnPrintPreview.BorderThickness = 1;
            this.btnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintPreview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintPreview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintPreview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrintPreview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrintPreview.FillColor = System.Drawing.Color.Gainsboro;
            this.btnPrintPreview.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPrintPreview.ForeColor = System.Drawing.Color.Black;
            this.btnPrintPreview.HoverState.BorderColor = System.Drawing.Color.Green;
            this.btnPrintPreview.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.btnPrintPreview.Location = new System.Drawing.Point(1547, 119);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(167, 40);
            this.btnPrintPreview.TabIndex = 15;
            this.btnPrintPreview.TabStop = false;
            this.btnPrintPreview.Text = "PRINT PREVIEW";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // rprtSupplies
            // 
            this.rprtSupplies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rprtSupplies.LocalReport.ReportEmbeddedResource = "ceh_lab_inv.reports.rprtSupplies.rdlc";
            this.rprtSupplies.Location = new System.Drawing.Point(0, 166);
            this.rprtSupplies.Name = "rprtSupplies";
            this.rprtSupplies.Size = new System.Drawing.Size(1726, 801);
            this.rprtSupplies.TabIndex = 16;
            this.rprtSupplies.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(535, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "FROM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(1052, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 23;
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
            this.dateTo.Location = new System.Drawing.Point(1086, 119);
            this.dateTo.Margin = new System.Windows.Forms.Padding(4);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(454, 40);
            this.dateTo.TabIndex = 22;
            this.dateTo.TabStop = false;
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
            this.dateFrom.Location = new System.Drawing.Point(591, 119);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(454, 40);
            this.dateFrom.TabIndex = 21;
            this.dateFrom.TabStop = false;
            this.dateFrom.Value = new System.DateTime(2022, 4, 12, 14, 1, 1, 137);
            // 
            // frmLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1726, 967);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.rprtSupplies);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.bunifuCards2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DASHBOARD";
            this.Load += new System.EventHandler(this.frmLayout_Load);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.Label lblTotalSupplies;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnPrintPreview;
        private Microsoft.Reporting.WinForms.ReportViewer rprtSupplies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker dateTo;
        private Bunifu.Framework.UI.BunifuDatepicker dateFrom;
    }
}