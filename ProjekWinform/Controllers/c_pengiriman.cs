using Npgsql;
using ProjekWinform.Helpers;
using System;
using System.Data;

namespace ProjekWinform.Controllers
{
    public class c_pengiriman
    {
        public DataTable ReadPengiriman(string tanggal = "")
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query;

                if (string.IsNullOrEmpty(tanggal))
                {
                    query = @"SELECT p.id_pengirim, p.ongkir, p.tanggal_pengiriman, 
                             p.status_pengiriman, u.nama_lengkap AS nama_kurir,
                             t.id_transaksi
                             FROM pengiriman p
                             JOIN users u ON p.id_user = u.id_user
                             JOIN transaksi t ON p.id_transaksi = t.id_transaksi
                             ORDER BY p.tanggal_pengiriman ASC";
                }
                else
                {
                    query = @"SELECT p.id_pengirim, p.ongkir, p.tanggal_pengiriman, 
                             p.status_pengiriman, u.nama_lengkap AS nama_kurir,
                             t.id_transaksi
                             FROM pengiriman p
                             JOIN users u ON p.id_user = u.id_user
                             JOIN transaksi t ON p.id_transaksi = t.id_transaksi
                             WHERE p.tanggal_pengiriman = @tanggal
                             ORDER BY p.tanggal_pengiriman ASC";
                }

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);

                if (!string.IsNullOrEmpty(tanggal))
                {
                    da.SelectCommand!.Parameters.AddWithValue("tanggal", DateTime.Parse(tanggal));
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ReadPengirimanByNama(string keyword = "")
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = @"SELECT p.id_pengirim, pl.nama_pelanggan, pl.no_hp, 
                        pl.alamat_pelanggan, p.ongkir, 
                        p.tanggal_pengiriman, p.status_pengiriman
                        FROM pengiriman p
                        JOIN transaksi t ON p.id_transaksi = t.id_transaksi
                        JOIN pelanggan pl ON t.id_pelanggan = pl.id_pelanggan
                        WHERE pl.nama_pelanggan ILIKE @keyword
                        ORDER BY p.tanggal_pengiriman ASC";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                da.SelectCommand!.Parameters.AddWithValue("keyword", "%" + keyword + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public string UbahStatus(int id_pengirim)
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = "UPDATE pengiriman SET status_pengiriman = 'Sudah Dikirim' WHERE id_pengirim = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", id_pengirim);
                    cmd.ExecuteNonQuery();
                }
            }
            return "Status berhasil diubah!";
        }
    }
}