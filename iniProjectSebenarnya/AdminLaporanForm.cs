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
    public partial class AdminLaporanForm : Form
    {
        public AdminLaporanForm(string mode)
        {
            InitializeComponent();
            judul = mode;
            lbJudul.Text = "Laporan " + judul;
        }

        string judul;
        private void AdminLaporanForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (judul == "Pembelian")
            {
                DateTime tgl1 = dtpAwal.Value;
                DateTime tgl2 = dtpAkhir.Value;
                if (tgl1 > tgl2)
                {
                    MessageBox.Show("Tanggal akhir harus lebih besar daripada tanggal awal");
                    return;
                }

                string tanggalAwal = dtpAwal.Value.ToString("dd-MMM-yyyy");
                string tanggalAkhir = dtpAkhir.Value.ToString("dd-MMM-yyyy");

                string awalsql = "select * from hpembelian where to_char(tanggal,'yyyymmdd')>= '" +
                        dtpAwal.Value.ToString("yyyyMMdd") + "'" +
                        " and to_char(tanggal,'yyyymmdd')<= '" + dtpAkhir.Value.ToString("yyyyMMdd") + "' ";
                //laporan pembelian

                DataSetLaporan ds = new DataSetLaporan();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Form1.conn;
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);

                cmd.CommandText = "select * from barang";
                adapter.Fill(ds, "barang");

                cmd.CommandText = "select * from supplier";
                adapter.Fill(ds, "supplier");

                //adapter = new OracleDataAdapter(awalsql, Form1.conn);
                //adapter.Fill(ds, "hpembelian");

                cmd.CommandText = awalsql;
                adapter.Fill(ds, "hpembelian");

                cmd.CommandText = "select * from dpembelian";
                adapter.Fill(ds, "dpembelian");

                CrystalReportPembelian report = new CrystalReportPembelian();
                report.SetDataSource(ds);
                report.SetParameterValue("tgl1", $"{tanggalAwal} - {tanggalAkhir}");
                //report.SetParameterValue("Date1", tgl1);
                //report.SetParameterValue("Date2", tgl2);

                crystalReportViewer1.ReportSource = report;
            }
            else if (judul == "Retur")
            {
                DateTime tgl1 = dtpAwal.Value;
                DateTime tgl2 = dtpAkhir.Value;
                if (tgl1 > tgl2)
                {
                    MessageBox.Show("Tanggal akhir harus lebih besar daripada tanggal awal");
                    return;
                }
                string tanggalAwal = dtpAwal.Value.ToString("dd-MMM-yyyy");
                string tanggalAkhir = dtpAkhir.Value.ToString("dd-MMM-yyyy");
                //laporan retur
                DataSetLaporan ds = new DataSetLaporan();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Form1.conn;
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);

                cmd.CommandText = "select * from barang";
                adapter.Fill(ds, "barang");

                cmd.CommandText = $"select * from hretur where to_char(tanggal,'yyyymmdd')>= '" +
                        dtpAwal.Value.ToString("yyyyMMdd") + "'" +
                        " and to_char(tanggal,'yyyymmdd')<= '" + dtpAkhir.Value.ToString("yyyyMMdd") + "' ";
                adapter.Fill(ds, "hretur");

                cmd.CommandText = "select * from dretur";
                adapter.Fill(ds, "dretur");

                cmd.CommandText = "select * from supplier";
                adapter.Fill(ds, "supplier");

                CrystalReportEdward report = new CrystalReportEdward();
                report.SetDataSource(ds);
                report.SetParameterValue("tgl1", $"{tanggalAwal} - {tanggalAkhir}");

                crystalReportViewer1.ReportSource = report;
            }
            else if (judul == "Barang")
            {
                //laporan barang

                DataSetLaporan ds = new DataSetLaporan();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Form1.conn;
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);

                cmd.CommandText = "select * from barang";
                adapter.Fill(ds, "barang");

                cmd.CommandText = "select * from hpembelian";
                adapter.Fill(ds, "hpembelian");

                cmd.CommandText = "select * from dpembelian";
                adapter.Fill(ds, "dpembelian");

                CrystalReportBarang report = new CrystalReportBarang();
                report.SetDataSource(ds);

                crystalReportViewer1.ReportSource = report;
            }
            else
            {
                //laporan pembayaran

                DataSetLaporan ds = new DataSetLaporan();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Form1.conn;
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);

                cmd.CommandText = "select * from barang";
                adapter.Fill(ds, "barang");

                cmd.CommandText = "select * from supplier";
                adapter.Fill(ds, "supplier");

                cmd.CommandText = "select * from hpembelian";
                adapter.Fill(ds, "hpembelian");

                cmd.CommandText = "select * from dpembayaran where status = 0";
                adapter.Fill(ds, "dpembayaran");

                CrystalReportPembayaran report = new CrystalReportPembayaran();
                report.SetDataSource(ds);
                report.SetParameterValue("periode", DateTime.Now);

                crystalReportViewer1.ReportSource = report;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
