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
    public partial class FormAdminI : Form
    {

        public FormAdminI()
        {
            InitializeComponent();
            customDesign();
        }

        public static int TanggalJatuhTempo = 10;

        private void customDesign()
        {
            panelSubMenuLaporan.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSubMenuLaporan.Visible == true)
                panelSubMenuLaporan.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuLaporan);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AdminLaporanForm f = new AdminLaporanForm("Pembelian");
            f.MdiParent = this;
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AdminLaporanForm f = new AdminLaporanForm("Retur");
            f.MdiParent = this;
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AdminLaporanForm f = new AdminLaporanForm("Pembayaran");
            f.MdiParent = this;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMasterKaryawanForm f = new AdminMasterKaryawanForm();
            f.MdiParent = this;
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminMasterSupplierForm f = new AdminMasterSupplierForm();
            f.MdiParent = this;
            f.Show();
        }

        //private void btnClose_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    Form1 f = new Form1();
        //    f.Show();
        //}

        private void btnMax_Click(object sender, EventArgs e)
        {
            btnKec.Visible = true;
            btnMax.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnKec_Click(object sender, EventArgs e)
        {
            btnMax.Visible = true;
            btnKec.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminMasterBarang f = new AdminMasterBarang();
            f.MdiParent = this;
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            JatuhTempoForm f = new JatuhTempoForm();
            f.MdiParent = this;
            f.Show();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin f = new UserLogin();
            f.Show();
        }

        private void FormAdminI_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.DimGray;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AdminLaporanForm f = new AdminLaporanForm("Barang");
            f.MdiParent = this;
            f.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
