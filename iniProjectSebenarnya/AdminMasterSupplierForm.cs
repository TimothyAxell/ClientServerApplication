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
    public partial class AdminMasterSupplierForm : Form
    {
        public AdminMasterSupplierForm()
        {
            InitializeComponent();
        }

        int selectedIndex;

        private void AdminMasterSupplierForm_Load(object sender, EventArgs e)
        {
            selectedIndex = -1;

            changeMode();
            dgv.DataSource = DB.getTableSupplier();
        }

        void clearField()
        {
            lbID.Text = "<id>";
            tbNama.Text = "";
            tbKontak.Text = "";
            tbAlamat.Text = "";
            cmbPembayaran.SelectedIndex = -1;

            selectedIndex = -1;
            dgv.ClearSelection();

            changeMode();

            dgvSupply.DataSource = new DataTable();
            dgvBarang.DataSource = new DataTable();
        }

        void changeMode()
        {
            if (selectedIndex > -1)
            {
                btnInsert.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnInsert.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                OracleCommand cmd = new OracleCommand("select max(id_supplier) from supplier", Form1.conn);
                int id = Convert.ToInt32(cmd.ExecuteScalar().ToString()) + 1;
                lbID.Text = id.ToString();
            }
        }

        DataTable dtBarang, dtSupplied;
        OracleDataAdapter adapter;
        OracleCommand cmd;
        List<int> listIdBarang;

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSupply.Columns.Clear();
            
            selectedIndex = e.RowIndex;

            lbID.Text = dgv.Rows[selectedIndex].Cells[0].Value.ToString();
            tbNama.Text = dgv.Rows[selectedIndex].Cells[1].Value.ToString();
            tbKontak.Text = dgv.Rows[selectedIndex].Cells[2].Value.ToString();
            tbAlamat.Text = dgv.Rows[selectedIndex].Cells[3].Value.ToString();

            string metode = dgv.Rows[selectedIndex].Cells[4].Value.ToString();
            int idx = -1;
            for (int i = 0; i < cmbPembayaran.Items.Count; i++)
            {
                if (cmbPembayaran.GetItemText(cmbPembayaran.Items[i]) == metode)
                {
                    idx = i;
                }
            }
            cmbPembayaran.SelectedIndex = idx;

            isiBarang();

            changeMode();
        }

        void isiBarang()
        {
            dgvBarang.DataSource = new DataTable();

            //isi list barang yang bisa di supply
            dtSupplied = new DataTable();
            adapter = new OracleDataAdapter($"select b.id, b.nama from barang b, rbarang r where r.id_supplier = {Int32.Parse(lbID.Text)} and b.id = r.id_barang", Form1.conn);
            adapter.Fill(dtSupplied);

            dgvSupply.DataSource = dtSupplied;

            //isi list barang
            List<Barang> lstBarang = new List<Barang>();
            string query = "select * from barang";
            cmd = new OracleCommand(query, Form1.conn);
            using (OracleDataReader reader = cmd.ExecuteReader()){
                while (reader.Read())
                {
                    lstBarang.Add(new Barang(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3)));
                }
            }

            //hilangkan duplikat
            for (int i = 0; i < dtSupplied.Rows.Count; i++)
            {
                DataRow row = dtSupplied.Rows[i];
                int idx = -1;
                for (int j = 0; j < lstBarang.Count; j++)
                {
                    if (row[0].ToString() == lstBarang[j].id.ToString())
                    {
                        lstBarang.RemoveAt(j);
                    }
                }
            }

            //buat datatable kosong untuk kolom
            dtBarang = new DataTable();
            adapter = new OracleDataAdapter("select * from barang where 1 = 2", Form1.conn);
            adapter.Fill(dtBarang);

            //masukan data yang tidak duplikat kedalam datatable
            foreach (Barang item in lstBarang)
            {
                object[] o = { item.id, item.nama, item.stok, item.harga };
                dtBarang.Rows.Add(o);
            }

            dgvBarang.DataSource = dtBarang;


            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
            dgvBarang.ClearSelection();
            dgvSupply.ClearSelection();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearField();
            changeMode();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "" || tbKontak.Text == "" || tbAlamat.Text == "" || cmbPembayaran.SelectedIndex == -1)
            {
                MessageBox.Show("Invalid input");
                return;
            }

            DB.insertSupplier(Int32.Parse(lbID.Text), tbNama.Text, tbKontak.Text, tbAlamat.Text, cmbPembayaran.SelectedItem.ToString());

            clearField();
            dgv.DataSource = DB.getTableSupplier();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DB.deleteSupplier(Int32.Parse(lbID.Text));

            clearField();
            dgv.DataSource = DB.getTableSupplier();
        }

        int idAdd = -1;
        int idRemove = -1;
        private void dgvBarang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = true;
            btnRemove.Enabled = false;

            idAdd = Int32.Parse(dgvBarang.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void dgvSupply_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRemove.Enabled = true;
            btnAdd.Enabled = false;

            idRemove = Int32.Parse(dgvSupply.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (idAdd != -1)
            {
                cmd = new OracleCommand($"insert into rbarang values ({lbID.Text}, {idAdd})", Form1.conn);
                cmd.ExecuteNonQuery();

                isiBarang();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (idRemove != -1)
            {
                cmd = new OracleCommand($"delete from rbarang where id_supplier = {lbID.Text} and id_barang =  {idRemove}", Form1.conn);
                cmd.ExecuteNonQuery();

                isiBarang();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "" || tbKontak.Text == "" || tbAlamat.Text == "" || cmbPembayaran.SelectedIndex == -1)
            {
                MessageBox.Show("Invalid input");
                return;
            }

            DB.updateSupplier(Int32.Parse(lbID.Text), tbNama.Text, tbKontak.Text, tbAlamat.Text, cmbPembayaran.SelectedItem.ToString());

            dgv.DataSource = DB.getTableSupplier();
        }

        
    }

    public class Barang
    {
        public string nama;
        public int id, stok, harga;

        public Barang(int id, string nama, int stok, int harga)
        {
            this.id = id;
            this.nama = nama;
            this.stok = stok;
            this.harga = harga;
        }
    }
}
