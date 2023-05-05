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
    public partial class PenggantiPembelian : Form
    {
        public PenggantiPembelian()
        {
            InitializeComponent();
        }

        OracleCommand query;
        OracleDataAdapter adapter;
        DataSet dataset, datasetHeader, datasetDetail;
        string queryStr;

        private void PenggantiPembelian_Load(object sender, EventArgs e)
        {
            loadSupplier();
            loadDGV();

            dgvHeader.RowHeadersVisible = false;
            dgvDetail.RowHeadersVisible = false;

            groupBox1.Enabled = false;
        }

        void loadSupplier()
        {
            query = new OracleCommand("Select id_supplier, initcap(nama) as nama from supplier", Form1.conn);
            adapter = new OracleDataAdapter(query);
            dataset = new DataSet();

            adapter.Fill(dataset, "supplier");
            cmbSupplier.DataSource = dataset.Tables["supplier"];
            cmbSupplier.ValueMember = "id_supplier";
            cmbSupplier.DisplayMember = "nama";
        }

        void loadDGV()
        {
            queryStr = "SELECT h.nomor_nota, h.tanggal, s.nama, h.total, h.status_pengiriman,s.metode_pembayaran from hpembelian h,supplier s where s.id_supplier=h.id_supplier";
            query = new OracleCommand(queryStr, Form1.conn);
            adapter = new OracleDataAdapter(query);
            dataset = new DataSet();

            adapter.Fill(dataset, "hbeli");

            dgvHeader.DataSource = dataset;
            dgvHeader.DataMember = "hbeli";

            dgvHeader.Columns[0].HeaderText = "Nomor Nota";
            dgvHeader.Columns[1].HeaderText = "Tanggal";
            dgvHeader.Columns[2].HeaderText = "Nama Supplier";
            dgvHeader.Columns[3].HeaderText = "Total";
            dgvHeader.Columns[4].Visible = false;
            dgvHeader.Columns[5].Visible = false;
            //dgvHeader.Columns[6].Visible = false;
        }

        void loadDGVDetail(string nota)
        {
            queryStr = $"Select d.nomor_nota, initcap(b.nama), b.harga,d.qty,d.subtotal from dpembelian d, barang b where d.id_barang = b.id and d.nomor_nota = '{nota}'";
            query = new OracleCommand(queryStr, Form1.conn);
            adapter = new OracleDataAdapter(query);
            datasetDetail = new DataSet();

            adapter.Fill(datasetDetail, "dbeli");

            dgvDetail.DataSource = datasetDetail;
            dgvDetail.DataMember = "dbeli";

            dgvDetail.Columns[0].HeaderText = "Nomor Nota";
            dgvDetail.Columns[1].HeaderText = "Nama Barang";
            dgvDetail.Columns[2].HeaderText = "Harga";
            dgvDetail.Columns[3].HeaderText = "QTY";
            dgvDetail.Columns[4].HeaderText = "Subtotal";
            dgvDetail.Columns[2].DefaultCellStyle.Format = "Rp 0,000.00##";
            dgvDetail.Columns[4].DefaultCellStyle.Format = "Rp 0,000.00##";
        }

        int idx = -1;
        int idx2 = -1;

        private void dgvHeader_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;

            string nota = dgvHeader.Rows[idx].Cells[0].Value.ToString();
            loadDGVDetail(nota);
            lbNomorNota.Text = nota;

            dateTimePicker1.Value = Convert.ToDateTime(dgvHeader.Rows[idx].Cells[1].Value);
            cmbSupplier.Text = dgvHeader.Rows[idx].Cells[2].Value.ToString();
            lbTotal.Text = dgvHeader.Rows[idx].Cells[3].Value.ToString();

            string status = dgvHeader.Rows[idx].Cells[4].Value.ToString();
            string metode = dgvHeader.Rows[idx].Cells[5].Value.ToString();

            //metode
            if (metode.ToUpper() == "TUNAI")
            {
                rdCash.Checked = true;
                rdCredit.Checked = false;
                rdTf.Checked = false;
            }
            else if (metode.ToUpper() == "CREDIT")
            {
                rdCash.Checked = false;
                rdCredit.Checked = true;
                rdTf.Checked = false;
            }
            else
            {
                rdCash.Checked = false;
                rdCredit.Checked = false;
                rdTf.Checked = true;
            }

            //status pengiriman
            if (status == "0")
            {
                rdPending.Checked = true;
                rdDone.Checked = false;
                rdCancel.Checked = false;

                groupBox2.Enabled = true;
            }
            else if (status == "1")
            {
                rdPending.Checked = false;
                rdDone.Checked = true;
                rdCancel.Checked = false;

                groupBox2.Enabled = false;
            }
            else if (status == "2")
            {
                rdPending.Checked = false;
                rdDone.Checked = false;
                rdCancel.Checked = true;

                groupBox2.Enabled = false;
            }

            btnInsert.Text = "Update";
        }

        private void dgvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idx2 = e.RowIndex;

            lbNama.Text = dgvDetail.Rows[idx2].Cells[1].Value.ToString();
            numHarga.Value = Convert.ToInt32(dgvDetail.Rows[idx2].Cells[2].Value);
            numQTY.Value = Convert.ToInt32(dgvDetail.Rows[idx2].Cells[3].Value);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            btnInsert.Text = "Insert";

            loadSupplier();
            loadDGV();

            dgvHeader.RowHeadersVisible = false;
            dgvDetail.RowHeadersVisible = false;

            groupBox1.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (idx > -1)
            {
                //update
                string status = dgvHeader.Rows[idx].Cells[4].Value.ToString();

                if (status == "0")
                {
                    string baru = "";
                    if (rdDone.Checked == true)
                    {
                        baru = "1";
                    }
                    else if (rdCancel.Checked == true)
                    {
                        baru = "2";
                    }
                    UpdateStatus(baru);
                }
            }
            else
            {
                //insert
                FormInsertPembelian f = new FormInsertPembelian();
                f.Show();
                //this.Hide();
            }
        }

        void UpdateStatus(string baru)
        {
            if (baru == "")
            {
                MessageBox.Show("Silahkan pilih status done / cancel");
                return;
            }

            int status = Convert.ToInt32(baru);
            string id = dgvHeader.Rows[idx].Cells[0].Value.ToString();
            string quer = $"update hpembelian set status_pengiriman = {status} where nomor_nota = '{id}'";

            OracleCommand cmd = new OracleCommand(quer, Form1.conn);
            cmd.ExecuteNonQuery();

            if (status == 1)
            {
                //buat dpembelian
                cmd = new OracleCommand("select max(id) from barang", Form1.conn);
                int idbaru = Convert.ToInt32(cmd.ExecuteScalar().ToString()) + 1;

                int total = int.Parse(dgvHeader.Rows[idx].Cells[3].Value.ToString());

                cmd = new OracleCommand($"insert into dpembayaran values ({idbaru}, '{id}', {cmbSupplier.SelectedValue.ToString()}, {total}, 0)", Form1.conn);
                cmd.ExecuteNonQuery();

                foreach(DataRow item in dgvDetail.Rows)
                {
                    string nama = item[1].ToString();
                    int qty = int.Parse(item[3].ToString());

                    cmd = new OracleCommand($"select id from barang where nama = '{nama}'", Form1.conn);
                    int idb = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                    cmd = new OracleCommand($"select stok from barang where id = {idb}", Form1.conn);
                    int stoklama = int.Parse(cmd.ExecuteScalar().ToString());

                    cmd = new OracleCommand($"update barang set stok = {stoklama + qty} where id = {idb}", Form1.conn);
                    cmd.ExecuteNonQuery();
                }



            }

            MessageBox.Show("Berhasil update !");
            clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            UserLogin f = new UserLogin();
            f.Show();
            this.Hide();
        }

        private void dgvHeader_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //4
            for (int i = 0; i < dgvHeader.Rows.Count; i++)
            {
                if (dataset.Tables["hbeli"].Rows[i][4].ToString() == "1")
                {
                    dgvHeader.Rows[i].DefaultCellStyle.BackColor = Color.ForestGreen;
                }
                if (dataset.Tables["hbeli"].Rows[i][4].ToString() == "2")
                {
                    dgvHeader.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void clear()
        {
            idx = -1;
            idx2 = -1;

            dgvHeader.DataSource = new DataTable();
            dgvHeader.ClearSelection();

            dgvDetail.DataSource = new DataTable();
            dgvDetail.ClearSelection();

            //clear bagian header
            lbNomorNota.Text = "-";
            dateTimePicker1.Value = DateTime.Now;
            cmbSupplier.SelectedIndex = -1;
            lbTotal.Text = "Rp.";
            rdCash.Checked = false;
            rdCredit.Checked = false;
            rdTf.Checked = false;

            //clear bagian detail
            lbNama.Text = "";
            numHarga.Value = 0;
            numQTY.Value = 0;

            loadDGV();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    //UserLogin f = new UserLogin();
        //    //f.Show();
        //    //this.Hide();
        //}
    }
}
