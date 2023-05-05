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
    public partial class FormInsertPembelian : Form
    {
        public FormInsertPembelian()
        {
            InitializeComponent();
        }

        DataTable dtSupp, dtBarang, dtCart;
        OracleDataAdapter daSupp, daBarang, daCart;
        OracleCommand cmd;
        int total;
        int selectedIndex = -1;
        int tempMin = 0;

        private void FormInsertPembelian_Load(object sender, EventArgs e)
        {
            total = 0;
            lbTotal.Text = total + "";

            cartStructure();

            button1.Enabled = false;
            button5.Enabled = false;

            bikinNota();
            loadSupplier();

            string supp = cmbSupplier.SelectedItem.ToString();
            loadBarang(supp);
        }

        void cartStructure()
        {
            dtCart = new DataTable();

            dtCart.Columns.Add("id"); //0
            dtCart.Columns.Add("NAMA"); //1
            dtCart.Columns.Add("HARGA"); //2
            dtCart.Columns.Add("JUMLAH"); //3
            dtCart.Columns.Add("SUBTOTAL"); //4
            dtCart.Columns.Add("ID_SUPPLIER"); //5

            dgvDetail.DataSource = dtCart.DefaultView;
            dgvDetail.Columns["id"].Visible = false;
            dgvDetail.Columns["ID_SUPPLIER"].Visible = false;
        }

        void loadSupplier()
        {
            daSupp = new OracleDataAdapter("select * from supplier", Form1.conn);
            dtSupp = new DataTable();
            daSupp.Fill(dtSupp);
            foreach (DataRow row in dtSupp.Rows)
            {
                cmbSupplier.Items.Add(row["NAMA"].ToString());
            }
            cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplier.SelectedIndex = 0;
        }

        void loadBarang(string supp)
        {
            daBarang = new OracleDataAdapter($"select b.id, b.nama, b.harga, r.id_supplier from barang b, rbarang r, supplier s where b.id = r.id_barang and r.ID_SUPPLIER = s.ID_SUPPLIER and s.nama = '{supp}' ", Form1.conn);
            dtBarang = new DataTable();
            daBarang.Fill(dtBarang);
            dgvBarang.DataSource = dtBarang.DefaultView;
            dgvBarang.ClearSelection();
            dgvBarang.Columns["ID_SUPPLIER"].Visible = false;
            checkRadButton(supp);
        }

        void checkRadButton(string supp) //auto centang radio button metode pembayaran sesuai dengan supplier
        {
            cmd = new OracleCommand();
            cmd.Connection = Form1.conn;
            cmd.CommandText = $"select metode_pembayaran from supplier where nama = '{supp}'";
            string temp = cmd.ExecuteScalar().ToString();

            temp = temp.ToUpper();
            if (temp == "CASH")
            {
                rdCash.Checked = true;
                rdTf.Checked = false;
                rdCredit.Checked = false;
            }
            else if (temp == "TRANSFER")
            {
                rdCash.Checked = false;
                rdTf.Checked = true;
                rdCredit.Checked = false;
            }
            else if (temp == "CREDIT")
            {
                rdCash.Checked = false;
                rdTf.Checked = false;
                rdCredit.Checked = true;
            }
        }

        public void clearDgvSelection1() // jika unfocus dari dgv
        {
            button1.Enabled = false;
            button5.Enabled = false;
            dgvBarang.ClearSelection();
            numericUpDown1.Value = 1;
        }

        public void clearDgvSelection2() // jika unfocus dari dgv
        {
            button1.Enabled = false;
            button5.Enabled = false;
            dgvDetail.ClearSelection();
            numericUpDown1.Value = 1;
            tempMin = 0;
        }

        void bikinNota()
        {
            string tgl = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            tgl = tgl.Replace("/", "");

            OracleCommand cmd = new OracleCommand($"select GenerateNomorNota('{tgl}') from dual", Form1.conn);
            string hasilnota = cmd.ExecuteScalar().ToString();
            lbNomorNota.Text = hasilnota;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (dgvDetail.Rows.Count < 1)
            {
                MessageBox.Show("silahkan pilih barang !");
            }
            else
            {
                using (OracleTransaction trans = Form1.conn.BeginTransaction())
                {
                    try
                    {
                        int idsup = cmbSupplier.SelectedIndex + 1;
                        string nota = lbNomorNota.Text;
                        string tanggal = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                        int total = Convert.ToInt32(lbTotal.Text);


                        //insert header
                        OracleCommand cmd = new OracleCommand($"insert into HPEMBELIAN values('{nota}',to_date('{tanggal}','dd/mm/yyyy'),{idsup},{total},{0})", Form1.conn);
                        cmd.ExecuteNonQuery();

                        foreach (DataRow row in dtCart.Rows)
                        {                                                                         //nota  , id barang, harga   , qty   , subtotal
                            OracleCommand cmd1 = new OracleCommand($"insert into DPEMBELIAN values('{nota}',{row[0]},'{row[2]}',{row[3]},{row[4]})", Form1.conn);
                            cmd1.ExecuteNonQuery();

                            OracleCommand cmd3 = new OracleCommand($"select stok from BARANG where id = {row[0]}", Form1.conn);
                            int tempStok = Convert.ToInt32(cmd3.ExecuteScalar().ToString());
                            int totalStok = tempStok + Convert.ToInt32(row[3].ToString());
                            OracleCommand cmd2 = new OracleCommand($"update BARANG set STOK = {totalStok} where ID = '{row[0]}'", Form1.conn);
                            cmd2.ExecuteNonQuery();
                        }
                        trans.Commit();
                        clearDgvSelection2();
                        dgvDetail.DataSource = null;
                        total = 0;
                        lbTotal.Text = total + "";
                        cartStructure();
                        MessageBox.Show("berhasil insert");

                        //
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();

                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dgvBarang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = false;
            button5.Enabled = true;
            selectedIndex = dgvBarang.CurrentCell.RowIndex;
        }

        private void FormInsertPembelian_Click(object sender, EventArgs e)
        {
            clearDgvSelection1();
            clearDgvSelection2();
        }

        private void cmbSupplier_Enter(object sender, EventArgs e)
        {
            clearDgvSelection1();
            clearDgvSelection2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRow selectedMenu = dtBarang.Rows[dgvBarang.CurrentCell.RowIndex];
            int id = int.Parse(selectedMenu["id"].ToString());
            string nama = selectedMenu["NAMA"].ToString();
            int harga = int.Parse(selectedMenu["HARGA"].ToString());
            int jumlah = Convert.ToInt32(numericUpDown1.Value);
            int idsup = int.Parse(selectedMenu["ID_SUPPLIER"].ToString());

            bool adaData = false;
            foreach (DataRow item in dtCart.Rows)
            {
                if (item[0].ToString() == id.ToString())
                {
                    adaData = true;
                    item[3] = jumlah + Int32.Parse(item[3].ToString());
                    item[4] = Int32.Parse(item[3].ToString()) * Int32.Parse(item[2].ToString());
                }
            }

            if (!adaData)
            {
                //add row baru
                DataRow dt = dtCart.NewRow();

                dt[0] = id;
                dt[1] = nama;
                dt[2] = harga;
                dt[3] = jumlah;
                dt[4] = harga * jumlah;
                dt[5] = idsup;

                dtCart.Rows.Add(dt);
            }

            int total = 0;
            foreach (DataRow item in dtCart.Rows)
            {
                total += int.Parse(item[4].ToString());
            }
            lbTotal.Text = total + "";
        }

        private void dgvDetail_Enter(object sender, EventArgs e)
        {
            clearDgvSelection1();
        }

        private void dgvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
            button5.Enabled = false;
            selectedIndex = dgvDetail.CurrentCell.RowIndex;

            DataGridViewRow row = dgvDetail.Rows[e.RowIndex];
            tempMin = Convert.ToInt32(row.Cells[3].Value);
        }

        private void dgvBarang_Enter(object sender, EventArgs e)
        {
            clearDgvSelection2();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            bikinNota();
        }


        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmbSupplier_Enter_1(object sender, EventArgs e)
        {
            clearDgvSelection1();
            clearDgvSelection2();
        }

        private void cmbSupplier_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string supp = cmbSupplier.SelectedItem.ToString();
            loadBarang(supp);
            clearDgvSelection2();
            dgvDetail.DataSource = null;
            total = 0;
            //lbTotal.Text = total + "";
            cartStructure();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvDetail.Rows.RemoveAt(selectedIndex);
            total -= tempMin;
            clearDgvSelection2();
            lbTotal.Text = total + "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearDgvSelection2();
            dgvDetail.DataSource = null;
            total = 0;
            lbTotal.Text = total + "";
            cartStructure();
        }

        //private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string supp = cmbSupplier.SelectedItem.ToString();
        //    loadBarang(supp);
        //    clearDgvSelection2();
        //    dgvDetail.DataSource = null;
        //    total = 0;
        //    lbTotal.Text = total + "";
        //    cartStructure();
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            PenggantiPembelian f = new PenggantiPembelian();
            f.Show();
            this.Hide();
        }
    }
}
