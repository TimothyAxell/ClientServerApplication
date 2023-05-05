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
    public partial class Form1 : Form
    {
        public static OracleConnection conn;
        static string system, user, pass;

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

        public Form1()
        {
            InitializeComponent();
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 25, 25));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 12, 12));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 12, 12));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 12, 12));
        }

        public static Boolean login = false;

        static void connDB()
        {
            string sys = Form1.system;
            string id = Form1.user;
            string pw = Form1.pass;

            conn = new OracleConnection("Data Source = " + sys + "; User ID = " + id + "; password = " + pw);

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                login = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Connect Database : " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnKec.Visible = true;
            btnMax.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnMax.Visible = true;
            btnKec.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            system = tbSystem.Text;
            user = tbUser.Text;
            pass = tbPassword.Text;

            connDB();

            if (login == true)
            {
                this.Hide();
                UserLogin f = new UserLogin();
                f.Show();
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    system = tbSystem.Text;
        //    user = tbUser.Text;
        //    pass = tbPassword.Text;

        //    connDB();

        //    if(login == true)
        //    {
        //        this.Hide();
        //        UserLogin f = new UserLogin();
        //        f.Show();
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            login = false;
        }
    }
}
