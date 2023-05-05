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
    public partial class JatuhTempoForm : Form
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
        public JatuhTempoForm()
        {
            InitializeComponent();
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 25, 25));
        }

        private void JatuhTempoForm_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = FormAdmin.TanggalJatuhTempo;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
