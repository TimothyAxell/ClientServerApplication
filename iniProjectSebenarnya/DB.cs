using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace iniProjectSebenarnya
{
    class DB
    {
        static DataTable dt;
        static OracleDataAdapter da;
        static String query;

        public static DataTable getTableBarang()
        {
            dt = new DataTable();
            query = "Select id, initcap(nama) as \"Nama Barang\", stok as \"Stok Barang\", harga as \"Harga Barang\" from barang";
            da = new OracleDataAdapter(query, Form1.conn);
            da.Fill(dt);

            return dt;
        }

        public static DataTable getTableSupplier()
        {
            dt = new DataTable();
            query = "select id_supplier, initcap(nama) as \"Nama Supplier\", kontak as \"Kontak Supplier\", alamat as \"Alamat Supplier\", metode_pembayaran from supplier";
            da = new OracleDataAdapter(query, Form1.conn);
            da.Fill(dt);

            return dt;
        }

        public static DataTable getTableKaryawan()
        {
            dt = new DataTable();
            query = "select id_karyawan, username as \"Username Karyawan\", password as \"Password Karyawan\", case jabatan when 99 then 'Admin' when 1 then 'Pembelian' when 2 then 'Retur' else 'Pembayaran' end as \"Jabatan\", case status when 0 then 'non-aktif' else 'aktif' end as \"Status\" from karyawan";
            da = new OracleDataAdapter(query, Form1.conn);
            da.Fill(dt);

            return dt;
        }

        public static void insertKaryawan(int id, string username, string password, int jabatan, int status)
        {
            try
            {
                string query = $"insert into karyawan values ({id}, '{username}', '{password}', {jabatan}, {status})";
                OracleCommand cmd = new OracleCommand(query, Form1.conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Berhasil Insert Karyawan {username} dengan ID : {id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void updateKaryawan(int id, string username, string password, int jabatan, int status)
        {
            try
            {
                string query = $"update karyawan set username = '{username}', password = '{password}', jabatan = {jabatan}, status = {status} where id_karyawan = {id}";
                OracleCommand cmd = new OracleCommand(query, Form1.conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Berhasil Update Karyawan {username} dengan ID : {id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void deleteKaryawan(int id)
        {
            try
            {
                string query = $"delete from karyawan where id_karyawan = {id}";
                OracleCommand cmd = new OracleCommand(query, Form1.conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Berhasil Delete Karyawan dengan ID : {id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void insertBarang(int id, string nama, int stok, int harga)
        {
            try
            {
                string query = $"insert into barang values ({id}, '{nama}', {stok}, {harga})";
                OracleCommand cmd = new OracleCommand(query, Form1.conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Berhasil Insert Barang {nama} dengan ID : {id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void updateBarang(int id, string nama, int harga)
        {
            try
            {
                string query = $"update barang set nama = '{nama}', harga = {harga} where id = {id}";
                OracleCommand cmd = new OracleCommand(query, Form1.conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Berhasil Update Barang {nama} dengan ID : {id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        public static void deleteBarang(int id)
        {
            try
            {
                string query = $"delete from barang where id = {id}";
                OracleCommand cmd = new OracleCommand(query, Form1.conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Berhasil Delete Barang dengan ID : {id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void deleteSupplier(int id)
        {
            try
            {
                string query = $"delete from supplier where id_supplier = {id}";
                OracleCommand cmd = new OracleCommand(query, Form1.conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Berhasil Delete Supplier dengan ID : {id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void insertSupplier(int id, string nama, string kontak, string alamat, string metode)
        {
            try
            {
                string query = $"insert into supplier values ({id}, '{nama}', '{kontak}', '{alamat}', '{metode}')";
                OracleCommand cmd = new OracleCommand(query, Form1.conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Berhasil Insert Supplier {nama} dengan ID : {id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void updateSupplier(int id, string nama, string kontak, string alamat, string metode)
        {
            try
            {
                string query = $"update supplier set nama = '{nama}', kontak = '{kontak}', alamat = '{alamat}', metode_pembayaran = '{metode}' where id_supplier = {id}";
                OracleCommand cmd = new OracleCommand(query, Form1.conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Berhasil Update Supplier {nama} dengan ID : {id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static int identifyRole(string username, string password)
        {
            int role = -1;

            OracleCommand cmd = new OracleCommand($"select jabatan, status from karyawan where username = '{username}' and password = '{password}'", Form1.conn);
            //role = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr.GetInt32(1) == 1)
                    {
                        role = dr.GetInt32(0);
                    }
                    else
                    {
                        role = 0;
                    }
                }
            }

            return role;
        }
    }
}
