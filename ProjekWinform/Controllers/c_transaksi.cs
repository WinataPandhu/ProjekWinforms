using Npgsql;
using ProjekWinform.Helpers;
using System.Data;

namespace ProjekWinform.Controllers
{
    public class c_transaksi
    {
        public DataTable ReadTransaksi()
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = "SELECT * FROM view_riwayat_transaksi ORDER BY tanggal_transaksi ASC";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ReadTransaksiByKeyword(string keyword)
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = @"SELECT * FROM view_riwayat_transaksi
                        WHERE nama_pelanggan ILIKE @keyword
                        OR kasir ILIKE @keyword
                        OR nama_alat ILIKE @keyword
                        OR CAST(tanggal_transaksi AS TEXT) ILIKE @keyword
                        OR TO_CHAR(tanggal_transaksi, 'DD/MM/YYYY') ILIKE @keyword
                        OR metode_bayar ILIKE @keyword
                        ORDER BY tanggal_transaksi ASC";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                da.SelectCommand!.Parameters.AddWithValue("keyword", "%" + keyword + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}