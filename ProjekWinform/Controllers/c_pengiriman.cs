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
                    query = "SELECT * FROM view_riwayat_pengiriman ORDER BY tanggal_pengiriman ASC";
                }
                else
                {
                    query = @"SELECT * FROM view_riwayat_pengiriman 
                     WHERE CAST(tanggal_pengiriman AS TEXT) ILIKE @tanggal
                     ORDER BY tanggal_pengiriman ASC";
                }

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);

                if (!string.IsNullOrEmpty(tanggal))
                {
                    da.SelectCommand!.Parameters.AddWithValue("tanggal", "%" + tanggal + "%");
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
                string query = @"SELECT * FROM view_riwayat_pengiriman
                        WHERE nama_pelanggan ILIKE @keyword
                        ORDER BY tanggal_pengiriman ASC";

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