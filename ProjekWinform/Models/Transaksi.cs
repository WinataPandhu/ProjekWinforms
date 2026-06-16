using System;

namespace ProjekWinform.Models
{
    public class Transaksi
    {
        public int id_transaksi { get; set; }
        public DateTime tanggal_transaksi { get; set; }
        public string nama_pelanggan { get; set; } = string.Empty;
        public string kasir { get; set; } = string.Empty;
        public string nama_alat { get; set; } = string.Empty;
        public int quantity { get; set; }
        public decimal harga_jual { get; set; }
        public decimal subtotal { get; set; }
        public string metode_bayar { get; set; } = string.Empty;
        public string metode_ambil { get; set; } = string.Empty;
    }
}