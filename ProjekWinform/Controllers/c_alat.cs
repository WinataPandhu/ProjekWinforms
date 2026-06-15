using Npgsql;
using ProjekWinform.Helpers;
using ProjekWinform.Models;
using System.Collections.Generic;

namespace ProjekWinform.Controllers
{
    public class c_alat
    {
        public List<AlatPertanian> Read()
        {
            List<AlatPertanian> list = new List<AlatPertanian>();

            using (var conn = connectDB.GetConn())
            {
                // KODE DIPERBARUI: Menggunakan INNER JOIN untuk mengambil nama_jenis
                // Sesuaikan "jenis_alat" dan "nama_jenis" dengan nama tabel/kolom asli di databasemu
                string query = @"SELECT a.id_alat, a.nama_alat, a.harga, a.stok, a.status_alat, a.id_jenis, j.nama_jenis 
                        FROM alat_pertanian a
                        INNER JOIN jenis_alat j ON a.id_jenis = j.id_jenis
                        ORDER BY a.id_alat ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new AlatPertanian
                        {
                            id_alat = reader.GetInt32(0),
                            nama_alat = reader.GetString(1),
                            harga = reader.GetDecimal(2),
                            stok = reader.GetInt32(3),
                            status_alat = reader.GetString(4),
                            id_jenis = reader.GetInt32(5),

                            // TAMBAHKAN INI: Membaca nama jenis dari indeks ke-6 hasil query
                            nama_jenis = reader.IsDBNull(6) ? "" : reader.GetString(6)
                        });
                    }
                }
            }
            return list;
        }

        public string Create(AlatPertanian alat)
        {
            using (var conn = connectDB.GetConn())
            {
                string query = "INSERT INTO alat_pertanian (nama_alat, harga, stok, status_alat, id_jenis) VALUES (@nama, @harga, @stok, @status, @id_jenis)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("nama", alat.nama_alat);
                    cmd.Parameters.AddWithValue("harga", alat.harga);
                    cmd.Parameters.AddWithValue("stok", alat.stok);
                    cmd.Parameters.AddWithValue("status", alat.status_alat);
                    cmd.Parameters.AddWithValue("id_jenis", alat.id_jenis);
                    cmd.ExecuteNonQuery();
                }
            }
            return "Produk berhasil ditambahkan!";
        }

        public string UpdateHarga(AlatPertanian alat)
        {
            using (var conn = connectDB.GetConn())
            {
                string query = "UPDATE alat_pertanian SET harga=@harga WHERE id_alat=@id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("harga", alat.harga);
                    cmd.Parameters.AddWithValue("id", alat.id_alat);
                    cmd.ExecuteNonQuery();
                }
            }
            return "Harga berhasil diupdate!";
        }

        public string Restok(AlatPertanian alat, int jumlah, int hargaBeli, int id_user)
        {
            using (var conn = connectDB.GetConn())
            {
                string queryHistori = @"INSERT INTO histori_restok 
            (harga_beli, stok_dibeli, tanggal_pembelian, id_user, id_alat) 
            VALUES (@harga_beli, @stok_dibeli, @tanggal, @id_user, @id_alat)";

                using (var cmd = new NpgsqlCommand(queryHistori, conn))
                {
                    cmd.Parameters.AddWithValue("harga_beli", hargaBeli);
                    cmd.Parameters.AddWithValue("stok_dibeli", jumlah);
                    cmd.Parameters.AddWithValue("tanggal", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("id_user", id_user);
                    cmd.Parameters.AddWithValue("id_alat", alat.id_alat);
                    cmd.ExecuteNonQuery();
                }
            }
            return "Restok berhasil!";
        }

        public List<HistoriRestok> ReadRestok()
        {
            List<HistoriRestok> list = new List<HistoriRestok>();

            using (var conn = connectDB.GetConn())
            {
                string query = "SELECT * FROM view_riwayat_restok ORDER BY id_histori ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new HistoriRestok
                        {
                            id_histori = reader.GetInt32(0),
                            harga_beli = reader.GetInt32(1),
                            stok_dibeli = reader.GetInt32(2),
                            tanggal_pembelian = reader.GetDateTime(3),
                            nama_lengkap = reader.GetString(4),
                            nama_alat = reader.GetString(5)
                        });
                    }
                }
            }
            return list;
        }

        public List<HistoriRestok> ReadRestokByKeyword(string keyword)
        {
            List<HistoriRestok> list = new List<HistoriRestok>();

            using (var conn = connectDB.GetConn())
            {
                string query = @"SELECT * FROM view_riwayat_restok
                        WHERE nama_lengkap ILIKE @keyword
                        OR nama_alat ILIKE @keyword
                        OR CAST(tanggal_pembelian AS TEXT) ILIKE @keyword
                        OR CAST(tanggal_pembelian AS TEXT) ILIKE @keyword
                        OR TO_CHAR(tanggal_pembelian, 'DD/MM/YYYY') ILIKE @keyword
                        ORDER BY id_histori ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("keyword", "%" + keyword + "%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new HistoriRestok
                            {
                                id_histori = reader.GetInt32(0),
                                harga_beli = reader.GetInt32(1),
                                stok_dibeli = reader.GetInt32(2),
                                tanggal_pembelian = reader.GetDateTime(3),
                                nama_lengkap = reader.GetString(4),
                                nama_alat = reader.GetString(5)
                            });
                        }
                    }
                }
            }
            return list;
        }

        public string Update(AlatPertanian alat)
        {
            using (var conn = connectDB.GetConn())
            {
                string query = @"UPDATE alat_pertanian 
                        SET nama_alat=@nama, harga=@harga, status_alat=@status, id_jenis=@id_jenis 
                        WHERE id_alat=@id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("nama", alat.nama_alat);
                    cmd.Parameters.AddWithValue("harga", alat.harga);
                    cmd.Parameters.AddWithValue("status", alat.status_alat);
                    cmd.Parameters.AddWithValue("id_jenis", alat.id_jenis);
                    cmd.Parameters.AddWithValue("id", alat.id_alat);
                    cmd.ExecuteNonQuery();
                }
            }
            return "Produk berhasil diupdate!";
        }
    }
}