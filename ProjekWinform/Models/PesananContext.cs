using Npgsql;
using ProjekWinform.Helpers;
using ProjekWinform.Models;
using System;
using System.Collections.Generic;

namespace ProjekWinform.Models
{
    public class PesananContext
    {
        public List<AlatPertanian> LoadBarang()
        {
            List<AlatPertanian> list = new List<AlatPertanian>();
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = "SELECT id_alat, nama_alat FROM alat_pertanian WHERE stok > 0 ORDER BY nama_alat ASC";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new AlatPertanian
                        {
                            id_alat = reader.GetInt32(0),
                            nama_alat = reader.GetString(1)
                        });
                    }
                }
            }
            return list;
        }

        public List<MetodePengambilan> LoadPengambilan()
        {
            List<MetodePengambilan> list = new List<MetodePengambilan>();
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = "SELECT id_pengambilan, nama_pengambilan FROM metode_pengambilan";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MetodePengambilan
                        {
                            id_pengambilan = reader.GetInt32(0),
                            nama_pengambilan = reader.GetString(1)
                        });
                    }
                }
            }
            return list;
        }

        public List<MetodePembayaran> LoadPembayaran()
        {
            List<MetodePembayaran> list = new List<MetodePembayaran>();
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = "SELECT id_pembayaran, nama_metode FROM metode_pembayaran";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MetodePembayaran
                        {
                            id_pembayaran = reader.GetInt32(0),
                            nama_metode = reader.GetString(1)
                        });
                    }
                }
            }
            return list;
        }

        public List<AlatPertanian> LoadKatalogBarang(string keyword = "")
        {
            List<AlatPertanian> list = new List<AlatPertanian>();
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = @"SELECT id_alat, nama_alat, stok, harga 
                                FROM alat_pertanian 
                                WHERE nama_alat ILIKE @keyword
                                ORDER BY nama_alat ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("keyword", "%" + keyword + "%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new AlatPertanian
                            {
                                id_alat = reader.GetInt32(0),
                                nama_alat = reader.GetString(1),
                                stok = reader.GetInt32(2),
                                harga = reader.GetDecimal(3)
                            });
                        }
                    }
                }
            }
            return list;
        }

        public decimal GetHargaAlat(int id_alat)
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = "SELECT func_get_harga_alat(@id)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", id_alat);
                    object? hasil = cmd.ExecuteScalar();
                    return Convert.ToDecimal(hasil ?? 0);
                }
            }
        }

        public int SimpanPelanggan(string nama, string noHp, string alamat)
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = "SELECT func_simpan_atau_cek_pelanggan(@nama, @hp, @alamat)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("nama", nama);
                    cmd.Parameters.AddWithValue("hp", noHp);
                    cmd.Parameters.AddWithValue("alamat", alamat);
                    return Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
                }
            }
        }

        public int SimpanTransaksi(DateTime tanggal, int id_user, int id_pelanggan, object id_pengambilan, object id_pembayaran)
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string sql = @"INSERT INTO transaksi (tanggal_transaksi, id_user, id_pelanggan, id_pengambilan, id_pembayaran)
                              VALUES (@tgl, @id_user, @pelanggan, @ambil, @bayar)
                              RETURNING id_transaksi";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("tgl", tanggal);
                    cmd.Parameters.AddWithValue("id_user", id_user);
                    cmd.Parameters.AddWithValue("pelanggan", id_pelanggan);
                    cmd.Parameters.AddWithValue("ambil", id_pengambilan);
                    cmd.Parameters.AddWithValue("bayar", id_pembayaran);
                    return Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
                }
            }
        }

        public void SimpanDetailTransaksi(int qty, decimal subtotal, decimal harga, int id_transaksi, int id_alat)
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                using (NpgsqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string queryProcedure = "CALL proc_simpan_dan_potong_stok(@qty, @sub, @harga, @trx, @alat)";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(queryProcedure, conn))
                        {
                            cmd.Transaction = transaction;

                            cmd.Parameters.AddWithValue("qty", qty);
                            cmd.Parameters.AddWithValue("sub", subtotal);
                            cmd.Parameters.AddWithValue("harga", harga);
                            cmd.Parameters.AddWithValue("trx", id_transaksi);
                            cmd.Parameters.AddWithValue("alat", id_alat);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Transaksi gagal diproses dan telah di-rollback. Error: " + ex.Message);
                    }
                }
            }
        }

        public void SimpanPengiriman(int id_transaksi, int id_user_kurir)
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = "CALL proc_simpan_pengiriman(@id_transaksi, @id_user)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id_user", id_user_kurir);
                    cmd.Parameters.AddWithValue("id_transaksi", id_transaksi);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int GetIdUserKurir()
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = "SELECT func_get_id_user_kurir()";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    object? hasil = cmd.ExecuteScalar();
                    return Convert.ToDecimal(hasil ?? 0) != 0 ? Convert.ToInt32(hasil) : 0;
                }
            }
        }

        public int GetIdUserByUsername(string username)
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = "SELECT func_get_id_user_by_username(@username)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    object? hasil = cmd.ExecuteScalar();
                    return Convert.ToDecimal(hasil ?? 0) != 0 ? Convert.ToInt32(hasil) : 0;
                }
            }
        }
    }
}