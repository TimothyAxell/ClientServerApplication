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

    public partial class FormInsertRetur : Form
    {
        OracleConnection conn = Form1.conn;
        DataTable dt, dtretur;
        OracleDataAdapter da;
        OracleCommand cmd;

        int idx, idxr;
        string nomorNota;
        int stok, quantity;

        string namaBarang;
        int idBarang;
        string detail;

        string namaSupplier;
        string alamatSupplier;
        string kontakSupplier;
        int qtylama;
        int hargalama;
        Boolean klik = false;
        Boolean klikRetur = false;
        int idsup;

        public FormInsertRetur()
        {
            InitializeComponent();
            //conn.Open();
        }
        public void isiDgvHbeli()
        {

            string sql = "select h.nomor_nota, h.tanggal, s.nama, h.total, case when status_pengiriman = 0 then 'Pending' when status_pengiriman = 1 then 'Arrived' when status_pengiriman = 2 then 'Cancelled' end , h.id_supplier from hpembelian h, supplier s where h.id_supplier = s.id_supplier and status_pengiriman = 1";
            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvHbeli.DataSource = dt;
            dgvHbeli.Columns[0].HeaderText = "Nomor Nota";
            dgvHbeli.Columns[1].HeaderText = "Tanggal";
            dgvHbeli.Columns[2].HeaderText = "Supplier";
            dgvHbeli.Columns[3].HeaderText = "Total";
            dgvHbeli.Columns[4].HeaderText = "Status Pengiriman";
            dgvHbeli.Columns[5].HeaderText = "idsup";

            dgvHbeli.Columns[3].DefaultCellStyle.Format = "Rp 0,000.00##";
            dgvHbeli.Columns[5].Visible = false;
        }

        public void isiDgvDretur()
        {
            //string sql = "select from ";

        }

        public void isiDgvDbeli()
        {
            string sql = "select d.nomor_nota,d.id_barang,  nama, d.qty, d.harga from dpembelian d, barang b where d.id_barang = b.id and d.nomor_nota = '" + nomorNota + "' ";
            da = new OracleDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvDbeli.DataSource = dt;

            dgvDbeli.Columns[0].HeaderText = "Nomor Nota";
            dgvDbeli.Columns[1].HeaderText = "id_barang";
            dgvDbeli.Columns[2].HeaderText = "Nama Barang";
            dgvDbeli.Columns[3].HeaderText = "Jumlah";
            dgvDbeli.Columns[4].HeaderText = "Harga";

            dgvDbeli.Columns[4].DefaultCellStyle.Format = "Rp 0,000.00##";
            dgvDbeli.Columns[1].Visible = false;
        }

        public void clearDbeli()
        {
            string sql = "select d.nomor_nota, nama, stok, d.harga from dpembelian d, barang b where d.id_barang = b.id and d.nomor_nota = '" + nomorNota + "' ";
            da = new OracleDataAdapter(sql, conn);
            dt = (DataTable)dgvDbeli.DataSource;
            dt.Clear();
        }

        public void clear()
        {
            txtAlamatSupplier.Text = "";
            txtKontakSupplier.Text = "";
            txtNotaBeli.Text = "";
            txtSupplier.Text = "";
            txtQuantity.Text = "";
            txtDetail.Text = "";
            txtQuantity.Enabled = false;
            txtDetail.Enabled = false;
        }

        private void FormInsertRetur_Load(object sender, EventArgs e)
        {
            isiDgvHbeli();
            isiRetur();
            dgvHbeli.RowHeadersVisible = false;
            dgvDbeli.RowHeadersVisible = false;
            txtQuantity.Enabled = false;
            txtDetail.Enabled = false;
            cmd = new OracleCommand("select GenerateNomorRetur() from dual", conn);
            txtRetur.Text = cmd.ExecuteScalar().ToString();
        }

        

        

        

        

        public void isiRetur()
        {
            dtretur = new DataTable();
            dtretur.Columns.Add("id barang");
            dtretur.Columns.Add("Nama Barang");
            dtretur.Columns.Add("Quantity");
            dtretur.Columns.Add("Detail");
            dtretur.Columns.Add("harga");
            dgvRetur.DataSource = dtretur;

            dgvRetur.Columns[0].Visible = false;
        }

        

        

        private void dgvRetur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            klikRetur = true;
            idxr = e.RowIndex;
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            if (klikRetur == false)
            {
                MessageBox.Show("Pilih terlebih barang yang tidak jadi diretur");
            }
            else
            {
                //if (Convert.ToInt32(txtQuantity.Text) < 1)
                //{
                //    MessageBox.Show("Quantity tidak boleh kurang dari 1");
                //}
                //else {
                //    if (txtDetail.Text == "")
                //    {
                //        MessageBox.Show("Detail retur harus diisi");
                //    }
                //    else {
                //        if ((stok - Convert.ToInt32(txtQuantity.Text)) <= 0)
                //        {
                //            MessageBox.Show("Tidak boleh melebihi jumlah stok");
                //        }
                //        else { 

                //        }
                //    }
                //}
                dtretur.Rows.RemoveAt(idxr);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (klik == false)
            {
                MessageBox.Show("Pilih terlebih dahulu barang yang ingin diretur");
            }
            else
            {
                if (Convert.ToInt32(txtQuantity.Text) < 1)
                {
                    MessageBox.Show("Quantity tidak boleh kurang dari 1");
                }
                else
                {
                    if (txtDetail.Text == "")
                    {
                        MessageBox.Show("Detail retur harus diisi");
                    }
                    else
                    {
                        if ((stok - Convert.ToInt32(txtQuantity.Text)) < 0)
                        {
                            MessageBox.Show("Tidak boleh melebihi jumlah stok barang");
                        }
                        else
                        {



                            quantity = stok - Convert.ToInt32(txtQuantity.Text);
                            DataRow dtbaru = dt.Rows[dgvDbeli.CurrentCell.RowIndex];
                            //dtbaru[0] = idBarang;
                            //dtbaru[1] = namaBarang;
                            //dtbaru[2] = quantity;
                            //dtbaru[3] = txtDetail.Text;
                            String nama = dtbaru["nama"].ToString();
                            int idbarang = int.Parse(dtbaru["id_barang"].ToString());
                            int jumlah = int.Parse(txtQuantity.Text);
                            String detail = txtDetail.Text;
                            int harga = int.Parse(dtbaru["harga"].ToString());
                            int tempqty = 0;

                            for (int i = 0; i < dgvRetur.Rows.Count; i++)
                            {
                                //MessageBox.Show(dgvRetur.Rows[i].Cells[1].Value.ToString());
                                if (namaBarang == dgvRetur.Rows[i].Cells[1].Value.ToString())
                                {
                                    tempqty += int.Parse(dgvRetur.Rows[i].Cells[2].Value.ToString());
                                }
                            }

                            if (stok - (tempqty + jumlah) < 0)
                            {
                                MessageBox.Show("tidak boleh melebihi jumlah stok");
                            }
                            else
                            {
                                dtretur.Rows.Add(idbarang, nama, jumlah, detail, harga);
                            }
















                            //String sql = "update dpembelian set qty = '"+quantity+"' where nomor_nota = '"+nomorNota+"'";
                            //cmd = new OracleCommand(sql, conn);
                            //cmd.ExecuteNonQuery();
                            isiDgvDbeli();
                        }
                    }

                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (dgvRetur.Rows.Count < 1)
            {
                MessageBox.Show("silahkan pilih barang yang diretur");
            }
            else
            {
                using (OracleTransaction trans = Form1.conn.BeginTransaction())
                {
                    try
                    {
                        String nota = txtNotaBeli.Text;
                        String noretur = txtRetur.Text;
                        String tanggal = dtptanggal.Value.ToString("dd/MM/yyyy");

                        //insert ke Hretur
                        OracleCommand cmd = new OracleCommand($"insert into Hretur values('{noretur}','{nota}', to_date('{tanggal}', 'dd-mm-yyyy'), {idsup} )", conn);

                        cmd.ExecuteNonQuery();

                        foreach (DataRow row in dtretur.Rows)
                        {
                            //insert ke Dretur
                            OracleCommand cmd1 = new OracleCommand($"insert into Dretur values ('{noretur}', {row[0]} , {row[2]} , '{row[3]}')", conn);


                            cmd1.ExecuteNonQuery();

                            //ambil total pembayaran lama
                            OracleCommand cmd2 = new OracleCommand($"select total from dpembayaran where nomor_nota = '{nota}'  ", conn);

                            int ttllama = Convert.ToInt32(cmd2.ExecuteScalar().ToString());

                            ttllama = ttllama - (int.Parse(row[2].ToString()) * int.Parse(row[4].ToString()));
                            //update total pembayaran setelah retur
                            OracleCommand cmd3 = new OracleCommand($"update dpembayaran set total = {ttllama} where nomor_nota = '{nota}' ", conn);

                            cmd3.ExecuteNonQuery();
                            //ambil jumlah stok lama
                            OracleCommand cmd4 = new OracleCommand($"select stok from barang where id = {row[0]}", conn);

                            int qtylama = Convert.ToInt32(cmd4.ExecuteScalar().ToString());

                            qtylama = qtylama - int.Parse(row[2].ToString());
                            //update jumlah stok setelah retur
                            OracleCommand cmd5 = new OracleCommand($"update barang set stok = {qtylama} where id = {row[0]}", conn);
                            cmd5.ExecuteNonQuery();





                        }

                        trans.Commit();
                        dgvHbeli.Enabled = true;
                        clearDbeli();
                        clear();
                        dtretur.Clear();
                        MessageBox.Show("berhasil Retur");

                        cmd = new OracleCommand("select GenerateNomorRetur() from dual", conn);
                        txtRetur.Text = cmd.ExecuteScalar().ToString();


                    }
                    catch (Exception ex)
                    {

                        //throw;

                        trans.Rollback();

                        MessageBox.Show(ex.Message);

                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvHbeli.Enabled = true;
            clearDbeli();
            clear();
            dtretur.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //conn.Close();
            FormRetur fr = new FormRetur();
            this.Hide();
            fr.Show();
        }

        private void txtNotaBeli_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRetur_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtptanggal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            UserLogin f = new UserLogin();
            f.Show();
            this.Hide();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void btnKec_Click(object sender, EventArgs e)
        {
            btnMax.Visible = true;
            btnKec.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            btnKec.Visible = true;
            btnMax.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void dgvDbeli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            klik = true;
            txtDetail.Enabled = true;
            txtQuantity.Text = "0";
            idx = e.RowIndex;
            stok = Convert.ToInt32(dgvDbeli.Rows[idx].Cells[3].Value);
            namaBarang = dgvDbeli.Rows[idx].Cells[2].Value.ToString();
            hargalama = Convert.ToInt32(dgvDbeli.Rows[idx].Cells[4].Value);
            nomorNota = dgvDbeli.Rows[idx].Cells[0].Value.ToString();
            string sql = "select id from barang where nama = '" + namaBarang + "'";
            cmd = new OracleCommand(sql, conn);
            idBarang = Convert.ToInt32(cmd.ExecuteScalar());
        }

        private void dgvHbeli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
            nomorNota = dgvHbeli.Rows[idx].Cells[0].Value.ToString();
            txtSupplier.Text = dgvHbeli.Rows[idx].Cells[2].Value.ToString();
            idsup = int.Parse(dgvHbeli.Rows[idx].Cells[5].Value.ToString());
            txtNotaBeli.Text = nomorNota;
            string sql1 = "select kontak from supplier where nama = '" + txtSupplier.Text + "'";
            cmd = new OracleCommand(sql1, conn);
            txtKontakSupplier.Text = cmd.ExecuteScalar().ToString();

            string sql2 = "select alamat from supplier where nama = '" + txtSupplier.Text + "'";
            cmd = new OracleCommand(sql2, conn);
            txtAlamatSupplier.Text = cmd.ExecuteScalar().ToString();
            //txtRetur.Text = 
            isiDgvDbeli();
            txtQuantity.Enabled = true;
            dgvHbeli.Enabled = false;
        }

        

        

        private void dgvHbeli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
