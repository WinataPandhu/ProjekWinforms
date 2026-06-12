using Npgsql;
using ProjekWinform.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjekWinform
{
    public partial class FormBuatPesanan : Form
    {
        public FormBuatPesanan()
        {
            InitializeComponent();
        }

        private void LoadBarang()
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = "SELECT id_alat, nama_alat FROM alat_pertanian";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxbarang.DataSource = dt;
                comboBoxbarang.DisplayMember = "nama_alat";
                comboBoxbarang.ValueMember = "id_alat";
            }
        }

        private void LoadPengambilan()
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = "SELECT id_pengambilan, nama_pengambilan FROM metode_pengambilan";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxPengambilan.DataSource = dt;
                comboBoxPengambilan.DisplayMember = "nama_pengambilan";
                comboBoxPengambilan.ValueMember = "id_pengambilan";
            }
        }

        private void LoadPembayaran()
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = "SELECT id_pembayaran, nama_metode FROM metode_pembayaran";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxBayar.DataSource = dt;
                comboBoxBayar.DisplayMember = "nama_metode";
                comboBoxBayar.ValueMember = "id_pembayaran";
            }
        }

        private void LoadKatalogBarang(string keyword = "")
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                // Ambil ID (buat logika klik), Nama, Stok, dan Harga
                string query = @"
            SELECT id_alat, nama_alat AS ""Nama Alat"", stok AS ""Stok"", harga AS ""Harga"" 
            FROM alat_pertanian 
            WHERE nama_alat ILIKE @keyword
            ORDER BY nama_alat ASC";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                da.SelectCommand!.Parameters.AddWithValue("keyword", "%" + keyword + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgList.DataSource = dt;

                // ID Alat disembunyikan agar kasir tidak bingung melihat angka primary key database
                if (dgList.Columns["id_alat"] != null)
                {
                    dgList.Columns["id_alat"]?.Visible = false;
                }
            }
        }
        private int SimpanPelanggan()
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string cek = "SELECT id_pelanggan FROM pelanggan WHERE no_hp=@hp";
                NpgsqlCommand cmd = new NpgsqlCommand(cek, conn);
                cmd.Parameters.AddWithValue("hp", txtNohp.Text);

                object? hasil = cmd.ExecuteScalar();

                if (hasil != null && hasil != DBNull.Value)
                {
                    return Convert.ToInt32(hasil);
                }

                string insert = @"
                    INSERT INTO pelanggan (nama_pelanggan, no_hp, alamat_pelanggan)
                    VALUES (@nama, @hp, @alamat)
                    RETURNING id_pelanggan";

                cmd = new NpgsqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("nama", txtNama.Text);
                cmd.Parameters.AddWithValue("hp", txtNohp.Text);
                cmd.Parameters.AddWithValue("alamat", txtAlamat.Text);

                object? hasilInsert = cmd.ExecuteScalar();
                return Convert.ToInt32(hasilInsert ?? 0);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void FormBuatPesanan_Load(object sender, EventArgs e)
        {
            LoadBarang();
            LoadPengambilan();
            LoadPembayaran();
            LoadKatalogBarang();

            dgPesanan.Columns.Add("id", "ID");
            dgPesanan.Columns.Add("barang", "Barang");
            dgPesanan.Columns.Add("jumlah", "Jumlah");
            dgPesanan.Columns.Add("harga", "Harga");
            dgPesanan.Columns.Add("total", "Total");

            if (dgPesanan.Columns["id"] != null)
            {
                dgPesanan.Columns["id"]!.Visible = false;
            }
        }

        private void comboBoxbarang_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBoxPengambilan_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBoxBayar_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dgPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxbarang.SelectedValue == null)
                {
                    MessageBox.Show("Pilih barang");
                    return;
                }

                int idAlat = Convert.ToInt32(comboBoxbarang.SelectedValue);
                string namaBarang = comboBoxbarang.Text;
                int jumlah = (int)nudJumlahbeli.Value;

                if (jumlah <= 0)
                {
                    MessageBox.Show("Jumlah harus lebih dari 0");
                    return;
                }

                decimal harga = 0;

                using (NpgsqlConnection conn = connectDB.GetConn())
                {
                    string query = "SELECT harga FROM alat_pertanian WHERE id_alat=@id";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("id", idAlat);

                    object? hasilHarga = cmd.ExecuteScalar();
                    harga = Convert.ToDecimal(hasilHarga ?? 0);
                }

                decimal total = harga * jumlah;

                dgPesanan.Rows.Add(idAlat, namaBarang, jumlah, harga, total);

                nudJumlahbeli.Value = 0;
                comboBoxbarang.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSimpanPesanan_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPengambilan.SelectedValue == null || comboBoxBayar.SelectedValue == null)
                {
                    MessageBox.Show("Metode pengambilan dan pembayaran harus dipilih.");
                    return;
                }

                using (NpgsqlConnection conn = connectDB.GetConn())
                {
                    int idPelanggan = SimpanPelanggan();

                    string sql = @"
                        INSERT INTO transaksi (tanggal_transaksi, id_user, id_pelanggan, id_pengambilan, id_pembayaran)
                        VALUES (@tgl, 3, @pelanggan, @ambil, @bayar)
                        RETURNING id_transaksi";

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("tgl", dtpTanggalbeli.Value);
                    cmd.Parameters.AddWithValue("pelanggan", idPelanggan);
                    cmd.Parameters.AddWithValue("ambil", comboBoxPengambilan.SelectedValue);
                    cmd.Parameters.AddWithValue("bayar", comboBoxBayar.SelectedValue);

                    object? hasilTrx = cmd.ExecuteScalar();
                    int idTransaksi = Convert.ToInt32(hasilTrx ?? 0);

                    foreach (DataGridViewRow row in dgPesanan.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string detail = @"
                            INSERT INTO detail_transaksi (quantity, subtotal, harga_jual, id_transaksi, id_alat)
                            VALUES (@qty, @sub, @harga, @trx, @alat)";

                        cmd = new NpgsqlCommand(detail, conn);

                        object qtyValue = row.Cells[2].Value ?? 0;
                        object subValue = row.Cells[4].Value ?? 0;
                        object hargaValue = row.Cells[3].Value ?? 0;
                        object alatValue = row.Cells[0].Value ?? 0;

                        cmd.Parameters.AddWithValue("qty", Convert.ToInt32(qtyValue));
                        cmd.Parameters.AddWithValue("sub", Convert.ToDecimal(subValue));
                        cmd.Parameters.AddWithValue("harga", Convert.ToDecimal(hargaValue));
                        cmd.Parameters.AddWithValue("trx", idTransaksi);
                        cmd.Parameters.AddWithValue("alat", Convert.ToInt32(alatValue));

                        cmd.ExecuteNonQuery();

                        string updateStok = "UPDATE alat_pertanian SET stok = stok - @qty WHERE id_alat = @alat";
                        using (NpgsqlCommand cmdStok = new NpgsqlCommand(updateStok, conn))
                        {
                            cmdStok.Parameters.AddWithValue("qty", Convert.ToInt32(qtyValue));
                            cmdStok.Parameters.AddWithValue("alat", Convert.ToInt32(alatValue));
                            cmdStok.ExecuteNonQuery();
                        }

                    }

                    MessageBox.Show("Pesanan berhasil disimpan");
                    dgPesanan.Rows.Clear();
                    LoadKatalogBarang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            LoadKatalogBarang(txtCari.Text);
        }

        private decimal HitungGrandTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgPesanan.Rows)
            {
                if (row.IsNewRow) continue;
                total += Convert.ToDecimal(row.Cells[4].Value ?? 0);
            }
            return total;
        }


        private void dgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgList.Rows[e.RowIndex];
                object? idAlat = row.Cells["id_alat"].Value;

                if (idAlat != null)
                {
                    comboBoxbarang.SelectedValue = idAlat;
                    nudJumlahbeli.Focus();
                }
            }
        }

        private void lblKembalian_Click(object sender, EventArgs e)
        {

        }
    }
}