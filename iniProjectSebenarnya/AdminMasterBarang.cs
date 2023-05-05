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
    public partial class AdminMasterBarang : Form
    {
        public AdminMasterBarang()
        {
            InitializeComponent();
        }

        int selectedIndex;

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

                OracleCommand cmd = new OracleCommand("select max(id) from barang", Form1.conn);
                int id = Convert.ToInt32(cmd.ExecuteScalar().ToString()) + 1;
                lbID.Text = id.ToString();
            }
        }

        void clearField()
        {
            lbID.Text = "<id>";
            tbNama.Text = "";
            tbStok.Text = "";
            tbHarga.Text = "";

            selectedIndex = -1;
            dgv.ClearSelection();

            changeMode();
        }

        private void AdminMasterBarang_Load(object sender, EventArgs e)
        {
            tbStok.Enabled = false;

            selectedIndex = -1;

            changeMode();
            dgv.DataSource = DB.getTableBarang();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearField();
            changeMode();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(lbID.Text);

            if(tbNama.Text == "" || tbHarga.Text == "")
            {
                MessageBox.Show("Inputan tidak valid !");
                return;
            }

            string nama = tbNama.Text;
            int harga = Int32.Parse(tbHarga.Text);

            if (harga <= 0)
            {
                MessageBox.Show("Harga harus diatas 0");
                return;
            }

            DB.insertBarang(id, nama, 0, harga);

            dgv.DataSource = DB.getTableBarang();

            clearField();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;

            lbID.Text = dgv.Rows[selectedIndex].Cells[0].Value.ToString();
            tbNama.Text = dgv.Rows[selectedIndex].Cells[1].Value.ToString();
            tbHarga.Text = dgv.Rows[selectedIndex].Cells[3].Value.ToString();
            tbStok.Text = dgv.Rows[selectedIndex].Cells[2].Value.ToString();

            changeMode();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DB.updateBarang(Int32.Parse(lbID.Text), tbNama.Text, Int32.Parse(tbHarga.Text));

            dgv.DataSource = DB.getTableBarang();

            clearField();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DB.deleteBarang(Int32.Parse(lbID.Text));

            dgv.DataSource = DB.getTableBarang();

            clearField();
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (Int32.Parse(row.Cells[2].Value.ToString()) < 10)
                {
                    row.DefaultCellStyle.BackColor = Color.DarkSalmon;
                }
            }

            if (e.ColumnIndex == 3 && e.RowIndex != this.dgv.NewRowIndex)
            {
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("#,##0");
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
