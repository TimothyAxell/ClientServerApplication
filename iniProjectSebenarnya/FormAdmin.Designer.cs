namespace iniProjectSebenarnya
{
    partial class FormAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterKaryawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jatuhTempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPembelianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPembayaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterKaryawanToolStripMenuItem,
            this.masterSupplierToolStripMenuItem,
            this.masterBarangToolStripMenuItem,
            this.jatuhTempoToolStripMenuItem,
            this.laporanToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterKaryawanToolStripMenuItem
            // 
            this.masterKaryawanToolStripMenuItem.Name = "masterKaryawanToolStripMenuItem";
            this.masterKaryawanToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.masterKaryawanToolStripMenuItem.Text = "Master Karyawan";
            this.masterKaryawanToolStripMenuItem.Click += new System.EventHandler(this.masterKaryawanToolStripMenuItem_Click);
            // 
            // masterSupplierToolStripMenuItem
            // 
            this.masterSupplierToolStripMenuItem.Name = "masterSupplierToolStripMenuItem";
            this.masterSupplierToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.masterSupplierToolStripMenuItem.Text = "Master Supplier";
            this.masterSupplierToolStripMenuItem.Click += new System.EventHandler(this.masterSupplierToolStripMenuItem_Click);
            // 
            // masterBarangToolStripMenuItem
            // 
            this.masterBarangToolStripMenuItem.Name = "masterBarangToolStripMenuItem";
            this.masterBarangToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.masterBarangToolStripMenuItem.Text = "Master Barang";
            this.masterBarangToolStripMenuItem.Click += new System.EventHandler(this.masterBarangToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laporanPembelianToolStripMenuItem,
            this.laporanPenjualanToolStripMenuItem,
            this.laporanPembayaranToolStripMenuItem});
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // jatuhTempoToolStripMenuItem
            // 
            this.jatuhTempoToolStripMenuItem.Name = "jatuhTempoToolStripMenuItem";
            this.jatuhTempoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.jatuhTempoToolStripMenuItem.Text = "Jatuh Tempo";
            this.jatuhTempoToolStripMenuItem.Click += new System.EventHandler(this.jatuhTempoToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // laporanPembelianToolStripMenuItem
            // 
            this.laporanPembelianToolStripMenuItem.Name = "laporanPembelianToolStripMenuItem";
            this.laporanPembelianToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.laporanPembelianToolStripMenuItem.Text = "Laporan Pembelian";
            this.laporanPembelianToolStripMenuItem.Click += new System.EventHandler(this.laporanPembelianToolStripMenuItem_Click);
            // 
            // laporanPenjualanToolStripMenuItem
            // 
            this.laporanPenjualanToolStripMenuItem.Name = "laporanPenjualanToolStripMenuItem";
            this.laporanPenjualanToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.laporanPenjualanToolStripMenuItem.Text = "Laporan Retur";
            this.laporanPenjualanToolStripMenuItem.Click += new System.EventHandler(this.laporanPenjualanToolStripMenuItem_Click);
            // 
            // laporanPembayaranToolStripMenuItem
            // 
            this.laporanPembayaranToolStripMenuItem.Name = "laporanPembayaranToolStripMenuItem";
            this.laporanPembayaranToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.laporanPembayaranToolStripMenuItem.Text = "Laporan Pembayaran";
            this.laporanPembayaranToolStripMenuItem.Click += new System.EventHandler(this.laporanPembayaranToolStripMenuItem_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterKaryawanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jatuhTempoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanPembelianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanPenjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanPembayaranToolStripMenuItem;
    }
}