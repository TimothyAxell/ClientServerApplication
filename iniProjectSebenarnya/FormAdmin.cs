using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace iniProjectSebenarnya
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        public static int TanggalJatuhTempo = 10; 

        private void masterKaryawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMasterKaryawanForm f = new AdminMasterKaryawanForm();
            f.MdiParent = this;
            f.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserLogin f = new UserLogin();
            f.Show();
            this.Hide();
        }

        private void masterSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMasterSupplierForm f = new AdminMasterSupplierForm();
            f.MdiParent = this;
            f.Show();
        }

        private void masterBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMasterBarang f = new AdminMasterBarang();
            f.MdiParent = this;
            f.Show();
        }

        private void jatuhTempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JatuhTempoForm f = new JatuhTempoForm();
            f.MdiParent = this;
            f.Show();
        }

        private void laporanPembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLaporanForm f = new AdminLaporanForm("Pembelian");
            f.MdiParent = this;
            f.Show();
        }

        private void laporanPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLaporanForm f = new AdminLaporanForm("Retur");
            f.MdiParent = this;
            f.Show();
        }

        private void laporanPembayaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLaporanForm f = new AdminLaporanForm("Pembayaran");
            f.MdiParent = this;
            f.Show();
        }
    }
}
