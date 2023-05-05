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
    public partial class FormPembelian : Form
    {
        public FormPembelian()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PenggantiPembelian f = new PenggantiPembelian();
            f.MdiParent = this;
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInsertPembelian f = new FormInsertPembelian();
            f.MdiParent = this;
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserLogin f = new UserLogin();
            f.Show();
            this.Hide();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            btnKec.Visible = true;
            btnMax.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnKec_Click(object sender, EventArgs e)
        {
            btnMax.Visible = true;
            btnKec.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
