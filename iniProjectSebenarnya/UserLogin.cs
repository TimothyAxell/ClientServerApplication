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
using System.Runtime.InteropServices;

namespace iniProjectSebenarnya
{
    public partial class UserLogin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeft,
               int nTop,
               int nRight,
               int nBottom,
               int nWidthEllipse,
               int nHeightEllipse
           );
        OracleConnection conn;

        String queryStr;
        OracleCommand query;
        OracleDataAdapter adapter;

        String cmdStr;
        OracleCommand cmd;

        public static string nama;
        String password;
        string namaTest;
        int mode = -1;
        public UserLogin()
        {
            InitializeComponent();
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 25, 25));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 12, 12));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 12, 12));
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
           
        //}

        //private void exit_click(object sender, EventArgs e)
        //{
        //    //this.Hide();
        //    //Form1 f = new Form1();
        //    //f.Show();
        //}

        private void UserLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string user = tbUser.Text;
            string pass = tbPass.Text;

            //if(tbUser.Text == "admin" && tbPass.Text == "admin")
            //{
            //    FormAdmin f = new FormAdmin();
            //    f.Show();
            //    this.Hide();
            //}
            //else
            //{

            //}
            int role = DB.identifyRole(user, pass);
            if (role == 1)
            {
                //FormPembelian f = new FormPembelian();
                //PenggantiPembelian f = new PenggantiPembelian();

                FormPembelian f = new FormPembelian();
                f.Show();
                this.Hide();
            }
            else if (role == 2)
            {
                FormRetur f = new FormRetur();
                f.Show();
                this.Hide();
            }
            else if (role == 3)
            {
                FormPembayaran f = new FormPembayaran();
                f.Show();
                this.Hide();
            }
            else if (role == 99)
            {
                FormAdminI f = new FormAdminI();
                f.Show();
                this.Hide();
            }
            else if (role == 0)
            {
                MessageBox.Show($"User {user} tidak aktif");
            }
            else
            {
                MessageBox.Show("User tidak ditemukan");
            }


            //nama = tbUser.Text.ToString();
            ///*
            //if(textBox1.Text == "admin" && textBox2.Text == "admin")
            //{
            //    FormAdmin f = new FormAdmin();
            //    f.Show();
            //}
            //else
            //{

            //}
            //*/
            //try
            //{
            //    /*
            //    conn.Open();
            //    cmdStr = "Select k.nama from karyawan k where  lower(k.username) = '" + tbUsername.Text.ToLower() + "' ";
            //    cmd = new OracleCommand(cmdStr, conn);
            //    nama = (cmd.ExecuteScalar()).ToString();
            //    //MessageBox.Show("Nama : "+nama);
            //    conn.Close();
            //    */

            //    conn.Open();
            //    cmdStr = "Select k.password from karyawan k where  lower(k.username) = '" + tbUser.Text.ToLower() + "' ";
            //    cmd = new OracleCommand(cmdStr, conn);
            //    password = (cmd.ExecuteScalar()).ToString();

            //    conn.Close();
            //}
            //catch (Exception)
            //{

            //    //throw;
            //}


            //if (tbUser.Text != null)
            //{
            //    //MessageBox.Show("Password : " + password);
            //    if (tbPass.Text == password)
            //    {
            //        conn.Open();

            //        cmdStr = "Select k.jabatan from karyawan k where lower(k.username) = '" + tbUser.Text.ToLower() + "' and k.password = '" + tbPass.Text + "'";
            //        cmd = new OracleCommand(cmdStr, conn);
            //        mode = Convert.ToInt32(cmd.ExecuteScalar());
            //        //MessageBox.Show("jabatan : "+mode);
            //        conn.Close();

            //        if (mode == 99)
            //        {
            //            this.Hide();
            //            FormAdmin f = new FormAdmin();
            //            f.Show();
            //        }
            //        else if (mode == 1)
            //        {
            //            //this.Hide();
            //            //FormPembelian f = new FormPembelian();
            //            //f.Show();


            //            MDIPembelian f = new MDIPembelian();
            //            f.Show();
            //            this.Hide();

            //        }
            //        else if (mode == 2)
            //        {
            //            this.Hide();
            //            FormRetur f = new FormRetur();

            //            f.Show();
            //        }
            //        else if (mode == 3)
            //        {
            //            this.Hide();
            //            FormPembayaran f = new FormPembayaran();
            //            f.Show();
            //        }
            //        else
            //        {
            //            MessageBox.Show("tidak ada akses");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("login gagal karena password salah");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("User tidak ditemukan, login gagal");
            //}
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
