using Npgsql;
using ProjekWinform.Helpers;
using System;
using System.Data;

namespace ProjekWinform.Controllers
{
    public class c_pesanan
    {
        public DataTable LoadBarang()
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = "SELECT id_alat, nama_alat FROM alat_pertanian WHERE stok > 0 ";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable LoadPengambilan()
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = "SELECT id_pengambilan, nama_pengambilan FROM metode_pengambilan";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable LoadPembayaran()
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = "SELECT id_pembayaran, nama_metode FROM metode_pembayaran";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable LoadKatalogBarang(string keyword = "")
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = @"SELECT id_alat, nama_alat AS ""Nama Alat"", stok AS ""Stok"", harga AS ""Harga"" 
                        FROM alat_pertanian 
                        WHERE nama_alat ILIKE @keyword
                        ORDER BY nama_alat ASC";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                da.SelectCommand!.Parameters.AddWithValue("keyword", "%" + keyword + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public decimal GetHargaAlat(int id_alat)
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = "SELECT harga FROM alat_pertanian WHERE id_alat=@id";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id", id_alat);
                object? hasil = cmd.ExecuteScalar();
                return Convert.ToDecimal(hasil ?? 0);
            }
        }

        public int SimpanPelanggan(string nama, string noHp, string alamat)
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string cek = "SELECT id_pelanggan FROM pelanggan WHERE no_hp=@hp";
                NpgsqlCommand cmd = new NpgsqlCommand(cek, conn);
                cmd.Parameters.AddWithValue("hp", noHp);
                object? hasil = cmd.ExecuteScalar();

                if (hasil != null && hasil != DBNull.Value)
                    return Convert.ToInt32(hasil);

                string insert = @"INSERT INTO pelanggan (nama_pelanggan, no_hp, alamat_pelanggan)
                                VALUES (@nama, @hp, @alamat)
                                RETURNING id_pelanggan";

                cmd = new NpgsqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("nama", nama);
                cmd.Parameters.AddWithValue("hp", noHp);
                cmd.Parameters.AddWithValue("alamat", alamat);
                return Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
            }
        }

        public int SimpanTransaksi(DateTime tanggal, int id_user, int id_pelanggan, object id_pengambilan, object id_pembayaran)
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string sql = @"INSERT INTO transaksi (tanggal_transaksi, id_user, id_pelanggan, id_pengambilan, id_pembayaran)
                              VALUES (@tgl, @id_user, @pelanggan, @ambil, @bayar)
                              RETURNING id_transaksi";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("tgl", tanggal);
                cmd.Parameters.AddWithValue("id_user", id_user);
                cmd.Parameters.AddWithValue("pelanggan", id_pelanggan);
                cmd.Parameters.AddWithValue("ambil", id_pengambilan);
                cmd.Parameters.AddWithValue("bayar", id_pembayaran);
                return Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
            }
        }

        public void SimpanDetailTransaksi(int qty, decimal subtotal, decimal harga, int id_transaksi, int id_alat)
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string detail = @"INSERT INTO detail_transaksi (quantity, subtotal, harga_jual, id_transaksi, id_alat)
                                VALUES (@qty, @sub, @harga, @trx, @alat)";

                NpgsqlCommand cmd = new NpgsqlCommand(detail, conn);
                cmd.Parameters.AddWithValue("qty", qty);
                cmd.Parameters.AddWithValue("sub", subtotal);
                cmd.Parameters.AddWithValue("harga", harga);
                cmd.Parameters.AddWithValue("trx", id_transaksi);
                cmd.Parameters.AddWithValue("alat", id_alat);
                cmd.ExecuteNonQuery();

                // update stok otomatis dikurangi
                string updateStok = "UPDATE alat_pertanian SET stok = stok - @qty WHERE id_alat = @alat";
                NpgsqlCommand cmdStok = new NpgsqlCommand(updateStok, conn);
                cmdStok.Parameters.AddWithValue("qty", qty);
                cmdStok.Parameters.AddWithValue("alat", id_alat);
                cmdStok.ExecuteNonQuery();
            }
        }

        public void SimpanPengiriman(int id_transaksi, int id_user_kurir)
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = @"INSERT INTO pengiriman (ongkir, tanggal_pengiriman, status_pengiriman, id_user, id_transaksi)
                        VALUES (@ongkir, @tanggal, 'Belum Dikirim', @id_user, @id_transaksi)";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("ongkir", 15000); // ongkir default, bisa diubah
                cmd.Parameters.AddWithValue("tanggal", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("id_user", id_user_kurir);
                cmd.Parameters.AddWithValue("id_transaksi", id_transaksi);
                cmd.ExecuteNonQuery();
            }
        }

        public int GetIdUserKurir()
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = @"SELECT u.id_user FROM users u
                        JOIN akun a ON u.id_akun = a.id_akun
                        JOIN roles r ON a.id_role = r.id_role
                        WHERE r.nama_role = 'Kurir'
                        LIMIT 1";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                object? hasil = cmd.ExecuteScalar();
                return Convert.ToInt32(hasil ?? 0);
            }
        }

        public int GetIdUserByUsername(string username)
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = @"SELECT u.id_user FROM users u
                        JOIN akun a ON u.id_akun = a.id_akun
                        WHERE a.username = @username";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("username", username);
                object? hasil = cmd.ExecuteScalar();
                return Convert.ToInt32(hasil ?? 0);
            }
        }
    }
}