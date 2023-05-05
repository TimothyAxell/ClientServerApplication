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
    public partial class FormRetur : Form
    {
        OracleConnection conn;
        DataTable dt;
        OracleDataAdapter da;
        OracleCommand cmd;
        string retur;
        int idx;
        string name;
        public FormRetur()
        {
            //this.name = UserLogin.nama;

            conn = Form1.conn;
            InitializeComponent();
            conn.Close();
            conn.Open();
        }

        //private void isiDgvHbeli() {
        //    string sql = "select h.nomor_nota, h.tanggal, s.nama, h.total, status_pengiriman from hpembelian h, supplier s where h.id_supplier = s.id_supplier";
        //    da = new OracleDataAdapter(sql, conn);
        //    dt = new DataTable();
        //    da.Fill(dt);
        //    dgvHretur.DataSource = dt;

        //    dgvHretur.Columns[0].HeaderText = "Nomor Nota";
        //    dgvHretur.Columns[1].HeaderText = "Tanggal";
        //    dgvHretur.Columns[2].HeaderText = "Nama Supplier";
        //    dgvHretur.Columns[3].HeaderText = "Total";
        //    dgvHretur.Columns[4].HeaderText = "Status Pengiriman";


        //    dgvHretur.Columns[3].DefaultCellStyle.Format = "Rp 0,000.00##";
        //}

        private void isiDgvHretur()
        {
            string sql = "select nomor_retur ,nomor_nota, tanggal, nama, hretur.id_supplier from hretur, supplier where hretur.id_supplier = supplier.id_supplier ";
            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvHretur.DataSource = dt;

            dgvHretur.Columns[0].HeaderText = "Nomor Retur";
            dgvHretur.Columns[1].HeaderText = "Nomor Nota";
            dgvHretur.Columns[2].HeaderText = "Tanggal";
            dgvHretur.Columns[3].HeaderText = "Nama Supplier";
            dgvHretur.Columns[4].HeaderText = "id";

            dgvHretur.Columns[4].Visible = false;
        }

        private void isiDgvDretur()
        {
            string sql = "select nomor_retur, nama, qty, detail from dretur d, barang b where nomor_retur = '" + retur + "' and d.id_barang = b.id";
            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvDretur.DataSource = dt;

            dgvDretur.Columns[0].HeaderText = "Nomor Retur";
            dgvDretur.Columns[1].HeaderText = "Nama Barang";
            dgvDretur.Columns[2].HeaderText = "Quantity";
            dgvDretur.Columns[3].HeaderText = "Detail";

            //dgvDretur.Columns[4].Visible = true;
        }
        private void FormRetur_Load(object sender, EventArgs e)
        {
            lblNama.Text = name;
            dgvHretur.RowHeadersVisible = false;
            dgvDretur.RowHeadersVisible = false;
            isiDgvHretur();
            cmbkategori.SelectedIndex = 0;
        }

       

        void gantikolom()
        {
            if (cmbkategori.SelectedIndex == 1)
            {
                txtSearch.Visible = true;
                dtpawal.Visible = false;
                dtpakir.Visible = false;
                lblsd.Visible = false;
            }
            else
            {
                txtSearch.Visible = true;
                dtpawal.Visible = false;
                dtpakir.Visible = false;
                lblsd.Visible = false;
            }


        }

        

        

        

        private void cmbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            gantikolom();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInsertRetur FIR = new FormInsertRetur();
            FIR.Show();
            this.Hide();
        }

        //private void btnLogOut_Click(object sender, EventArgs e)
        //{
        //    //conn.Close();
        //    //UserLogin ul = new UserLogin();
        //    //ul.Show();
        //    //this.Hide();
        //}

        private void dgvHretur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
            int idSupplier = Convert.ToInt32(dgvHretur.Rows[idx].Cells[4].Value);
            //MessageBox.Show(idSupplier.ToString());
            cmd = new OracleCommand("select kontak from supplier where id_supplier = '" + idSupplier + "'", conn);
            txtKontak.Text = cmd.ExecuteScalar().ToString();
            OracleCommand cmd1 = new OracleCommand("select alamat from supplier where id_supplier = '" + idSupplier + "'", conn);
            txtAlamat.Text = cmd1.ExecuteScalar().ToString();
            txtNomorRetur.Text = dgvHretur.Rows[idx].Cells[0].Value.ToString();
            txtNomorPembelian.Text = dgvHretur.Rows[idx].Cells[1].Value.ToString();
            txtNama.Text = dgvHretur.Rows[idx].Cells[3].Value.ToString();
            dtpTanggal.Value = (DateTime)dgvHretur.Rows[idx].Cells[2].Value;
            retur = txtNomorRetur.Text;
            isiDgvHretur();
            isiDgvDretur();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string kata = txtSearch.Text;
            string sql = "";


            if (cmbkategori.SelectedIndex == 0)
            {
                sql = "select nomor_retur ,nomor_nota, tanggal, nama, hretur.id_supplier from hretur, supplier where hretur.id_supplier = supplier.id_supplier and nama like '%" + kata + "%'";
            }
            //else if (cmbkategori.SelectedIndex == 1)
            //{
            //    DateTime dtawal = dtpawal.Value;
            //    DateTime dtakir = dtpakir.Value;

            //    string tempdtawal = dtawal.ToString("dd-MMM-yyyy");
            //    string tempdtakir = dtakir.ToString("dd/MMM-yyyy");

            //    //sql = $"select nomor_retur ,nomor_nota, tanggal, nama, hretur.id_supplier from hretur, supplier where hretur.id_supplier = supplier.id_supplier and hretur.tanngal >= to_date({tempdtawal} , 'DD-MM-YYYY') and hretur.tanggal <= to_date({tempdtakir}, 'DD-MM-YYYY')";
            //}
            else if (cmbkategori.SelectedIndex == 1)
            {
                sql = "select nomor_retur ,nomor_nota, tanggal, nama, hretur.id_supplier from hretur, supplier where hretur.id_supplier = supplier.id_supplier and nomor_retur like '%" + kata + "%'";
            }
            else if (cmbkategori.SelectedIndex == 2)
            {
                sql = "select nomor_retur ,nomor_nota, tanggal, nama, hretur.id_supplier from hretur, supplier where hretur.id_supplier = supplier.id_supplier and  nomor_nota like '%" + kata + "%' ";
            }
            //belum selesai untuk search


            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvHretur.DataSource = dt;

            dgvHretur.Columns[0].HeaderText = "Nomor Retur";
            dgvHretur.Columns[1].HeaderText = "Nomor Nota";
            dgvHretur.Columns[2].HeaderText = "Tanggal";
            dgvHretur.Columns[3].HeaderText = "Nama Supplier";
            dgvHretur.Columns[4].HeaderText = "id";

            dgvHretur.Columns[4].Visible = false;
        }


        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //conn.Close();
            UserLogin ul = new UserLogin();
            ul.Show();
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
    }
}
