using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iniProjectSebenarnya
{
    public partial class MDIPembelian : Form
    {
        public MDIPembelian()
        {
            InitializeComponent();
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PenggantiPembelian f = new PenggantiPembelian();
            f.MdiParent = this;
            f.Show();
        }

        private void insertPembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsertPembelian f = new FormInsertPembelian();
            f.MdiParent = this;
            f.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserLogin f = new UserLogin();
            f.Show();
            this.Hide();
        }
    }
}
