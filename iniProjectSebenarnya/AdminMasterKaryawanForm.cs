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
    public partial class AdminMasterKaryawanForm : Form
    {
        
        public AdminMasterKaryawanForm()
        {
            InitializeComponent();
        }

        int selectedIndex;

        private void AdminMasterKaryawanForm_Load(object sender, EventArgs e)
        {
            selectedIndex = -1;

            changeMode();
            dgv.DataSource = DB.getTableKaryawan();
        }

        void changeMode()
        {
            if(selectedIndex > -1)
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

                OracleCommand cmd = new OracleCommand("select max(id_karyawan) from karyawan", Form1.conn);
                int id = Convert.ToInt32(cmd.ExecuteScalar().ToString()) + 1;
                lbID.Text = id.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearField();
        }

        void clearField()
        {
            lbID.Text = "<id>";
            tbUsername.Text = "";
            tbPassword.Text = "";
            cmbJabatan.SelectedIndex = -1;
            rAktif.Checked = false;
            rNonAktif.Checked = false;
            selectedIndex = -1;
            dgv.ClearSelection();

            changeMode();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //get max id
            int id = Int32.Parse(lbID.Text);

            if(tbUsername.Text == "" || tbPassword.Text == "" || cmbJabatan.SelectedIndex < 0)
            {
                MessageBox.Show("Inputan tidak valid !");
                return;
            }

            string username = tbUsername.Text;
            string password = tbPassword.Text;

            int jabatan = -1;
            if (cmbJabatan.SelectedIndex == 0)
            {
                jabatan = 99;
            }
            else if (cmbJabatan.SelectedIndex == 1)
            {
                jabatan = 1;
            }
            else if (cmbJabatan.SelectedIndex == 2)
            {
                jabatan = 2;
            }
            else if (cmbJabatan.SelectedIndex == 3)
            {
                jabatan = 3;
            }

            int status = -1;
            if (rAktif.Checked == true)
            {
                status = 1;
            }
            else if (rNonAktif.Checked == true)
            {
                status = 0;
            }

            if (status == -1)
            {
                MessageBox.Show("Inputan tidak valid !");
                return;
            }

            DB.insertKaryawan(id, username, password, jabatan, status);

            dgv.DataSource = DB.getTableKaryawan();

            clearField();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(lbID.Text);

            if (tbUsername.Text == "" || tbPassword.Text == "" || cmbJabatan.SelectedIndex < 0)
            {
                MessageBox.Show("Inputan tidak valid !");
                return;
            }

            string username = tbUsername.Text;
            string password = tbPassword.Text;

            int jabatan = -1;
            if (cmbJabatan.SelectedIndex == 0)
            {
                jabatan = 99;
            }
            else if (cmbJabatan.SelectedIndex == 1)
            {
                jabatan = 1;
            }
            else if (cmbJabatan.SelectedIndex == 2)
            {
                jabatan = 2;
            }
            else if (cmbJabatan.SelectedIndex == 3)
            {
                jabatan = 3;
            }

            int status = -1;
            if (rAktif.Checked == true)
            {
                status = 1;
            }
            else if (rNonAktif.Checked == true)
            {
                status = 0;
            }

            if (status == -1)
            {
                MessageBox.Show("Inputan tidak valid !");
                return;
            }

            DB.updateKaryawan(id, username, password, jabatan, status);

            dgv.DataSource = DB.getTableKaryawan();

            clearField();
            changeMode();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DB.deleteKaryawan(Int32.Parse(lbID.Text));

            dgv.DataSource = DB.getTableKaryawan();

            clearField();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;

            lbID.Text = dgv.Rows[selectedIndex].Cells[0].Value.ToString();
            tbUsername.Text = dgv.Rows[selectedIndex].Cells[1].Value.ToString();
            tbPassword.Text = dgv.Rows[selectedIndex].Cells[2].Value.ToString();

            string jabatan = dgv.Rows[selectedIndex].Cells[3].Value.ToString();
            int idx = -1;
            for (int i = 0; i < cmbJabatan.Items.Count; i++)
            {
                if (cmbJabatan.GetItemText(cmbJabatan.Items[i]) == jabatan)
                {
                    idx = i;
                }
            }
            cmbJabatan.SelectedIndex = idx;

            string status = dgv.Rows[selectedIndex].Cells[4].Value.ToString();
            if (status == "aktif")
            {
                rAktif.Checked = true;
            }
            else
            {
                rNonAktif.Checked = true;
            }

            changeMode();
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                //if (row.Cells[4].Value.ToString() == "aktif")
                //{

                //}
                //else
                //{
                //    row.DefaultCellStyle.BackColor = Color.DarkSalmon;
                //}

                if (e.ColumnIndex == 2 && e.Value != null)
                {
                    e.Value = new String('*', e.Value.ToString().Length);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
