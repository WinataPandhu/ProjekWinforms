using Npgsql;
using ProjekWinform.Helpers;
using System;
using System.Collections.Generic;

namespace ProjekWinform.Models
{
    public class TransaksiContext
    {
        public List<Transaksi> ReadTransaksi()
        {
            List<Transaksi> list = new List<Transaksi>();
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = "SELECT id_transaksi, tanggal_transaksi, nama_pelanggan, kasir, nama_alat, quantity, harga_jual, subtotal, metode_bayar, metode_ambil FROM view_riwayat_transaksi ORDER BY tanggal_transaksi ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Transaksi
                        {
                            id_transaksi = reader.GetInt32(0),
                            tanggal_transaksi = reader.GetDateTime(1),
                            nama_pelanggan = reader.GetString(2),
                            kasir = reader.GetString(3),
                            nama_alat = reader.GetString(4),
                            quantity = reader.GetInt32(5),
                            harga_jual = reader.GetDecimal(6),
                            subtotal = reader.GetDecimal(7),
                            metode_bayar = reader.GetString(8),
                            metode_ambil = reader.GetString(9)
                        });
                    }
                }
            }
            return list;
        }

        public List<Transaksi> ReadTransaksiByKeyword(string keyword)
        {
            List<Transaksi> list = new List<Transaksi>();
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string query = @"SELECT id_transaksi, tanggal_transaksi, nama_pelanggan, kasir, nama_alat, quantity, harga_jual, subtotal, metode_bayar, metode_ambil 
                                FROM view_riwayat_transaksi
                                WHERE nama_pelanggan ILIKE @keyword
                                OR kasir ILIKE @keyword
                                OR nama_alat ILIKE @keyword
                                OR CAST(tanggal_transaksi AS TEXT) ILIKE @keyword
                                OR TO_CHAR(tanggal_transaksi, 'DD/MM/YYYY') ILIKE @keyword
                                OR metode_bayar ILIKE @keyword
                                OR metode_ambil ILIKE @keyword
                                ORDER BY tanggal_transaksi ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("keyword", "%" + keyword + "%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Transaksi
                            {
                                id_transaksi = reader.GetInt32(0),
                                tanggal_transaksi = reader.GetDateTime(1),
                                nama_pelanggan = reader.GetString(2),
                                kasir = reader.GetString(3),
                                nama_alat = reader.GetString(4),
                                quantity = reader.GetInt32(5),
                                harga_jual = reader.GetDecimal(6),
                                subtotal = reader.GetDecimal(7),
                                metode_bayar = reader.GetString(8),
                                metode_ambil = reader.GetString(9)
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}