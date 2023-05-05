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
    public partial class FormPembayaran : Form
    {
        public FormPembayaran()
        {
            InitializeComponent();
        }

        OracleCommand cmd;
        OracleDataAdapter adapter;
        DataTable dtPembayaran;
        DataSet dtSupp;

        void loadSupplier()
        {
            cmd = new OracleCommand("Select id_supplier, initcap(nama) as nama from supplier",Form1.conn);
            adapter = new OracleDataAdapter(cmd);
            dtSupp = new DataSet();

            adapter.Fill(dtSupp, "supplier");
            cmbSupplier.DataSource = dtSupp.Tables["supplier"];
            cmbSupplier.ValueMember = "id_supplier";
            cmbSupplier.DisplayMember = "nama";
        }

        void changeColor()
        {
            foreach (DataGridViewRow item in dgvHead.Rows)
            {
                if (item.Cells[3].Value.ToString() == "Belum Bayar")
                {
                    item.DefaultCellStyle.BackColor = Color.LightSalmon;
                }
            }
        }

        void clear()
        {
            lbNota.Text = "-";
            lbSupplier.Text = "-";
            lbTanggal.Text = "-";
            lbTotal.Text = "-";

            dgvDetail.DataSource = new DataTable();
        }

        void loadDGVHead()
        {
            try
            {
                int idsupp = int.Parse(cmbSupplier.SelectedValue.ToString());
                //MessageBox.Show(cmbSupplier.SelectedValue.ToString());
                adapter = new OracleDataAdapter($"select id_pembayaran as id, nomor_nota as \"nomor nota\", total, case when status = 0 then 'Belum Bayar' Else 'Lunas' end as status from dpembayaran d, supplier s where s.id_supplier = d.id_supplier and s.id_supplier = {idsupp}", Form1.conn);
                dtPembayaran = new DataTable();

                adapter.Fill(dtPembayaran);
                dgvHead.DataSource = dtPembayaran;

                int total = 0;
                foreach (DataRow item in dtPembayaran.Rows)
                {
                    if (item[3].ToString() == "Belum Bayar")
                    {
                        total += int.Parse(item[2].ToString());
                    }
                }
                lbTotalHutang.Text = "Rp. " + total;

                if (total > 0)
                {
                    btnBayarSemua.Enabled = true;
                }
                else
                {
                    btnBayarSemua.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                //throw;
            }
        }

        DataTable getDetailPembayaran(string nota)
        {
            DataTable dt = new DataTable();
            adapter = new OracleDataAdapter($"select * from hpembelian where nomor_nota = '{nota}'", Form1.conn);
            adapter.Fill(dt);

            //get supplier
            int supp = int.Parse(dt.Rows[0][2].ToString());
            cmd = new OracleCommand($"select initcap(nama) as nama from supplier where id_supplier = {supp}", Form1.conn);
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbSupplier.Text = reader.GetString(0);
            }
            //fill information text
            lbTanggal.Text = dt.Rows[0][1].ToString();
            lbTotal.Text = "Rp. " + dt.Rows[0][3].ToString();

            dt = new DataTable();
            adapter = new OracleDataAdapter($"select * from dpembelian where nomor_nota = '{nota}'", Form1.conn);
            adapter.Fill(dt);

            return dt;
        }

        void bayar(int id)
        {
            cmd = new OracleCommand($"update dpembayaran set status = 1 where id_pembayaran = '{id}'", Form1.conn);
            cmd.ExecuteNonQuery();

            loadDGVHead();
            changeColor();
            clear();
        }

        private void FormPembayaran_Load(object sender, EventArgs e)
        {
            loadSupplier();
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDGVHead();
            changeColor();
            clear();
        }

        string nomorNota = "";
        private void dgvHead_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbID.Text = dtPembayaran.Rows[e.RowIndex][0].ToString();
            nomorNota = dtPembayaran.Rows[e.RowIndex][1].ToString();
            lbNota.Text = nomorNota;

            dgvDetail.DataSource = getDetailPembayaran(nomorNota);

            //
            if (dgvHead.Rows[e.RowIndex].Cells[3].Value.ToString() == "Lunas")
            {
                btnBayar.Enabled = false;
            }
            else
            {
                btnBayar.Enabled = true;
            }
        }

        private void btnBayarSemua_Click(object sender, EventArgs e)
        {
            foreach (DataRow item in dtPembayaran.Rows)
            {
                if (item[3].ToString() == "Belum Bayar")
                {
                    int id = int.Parse(item[0].ToString());
                    bayar(id);
                }
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (lbID.Text == "-")
            {
                MessageBox.Show("Pilih ID");
                return;
            }
            int id = int.Parse(lbID.Text);
            bayar(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UserLogin f = new UserLogin();
            //f.Show();
            //this.Hide();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            UserLogin f = new UserLogin();
            f.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbTotal_Click(object sender, EventArgs e)
        {

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
