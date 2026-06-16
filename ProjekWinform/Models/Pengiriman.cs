using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekWinform.Models
{
    public class Pengiriman
    {
        public int id_pengirim { get; set; }
        public decimal ongkir { get; set; }
        public DateTime tanggal_pengiriman { get; set; }
        public string status_pengiriman { get; set; } = string.Empty;
        public int id_user { get; set; }
        public int id_transaksi { get; set; }

        public string nama_pelanggan { get; set; } = string.Empty;
        public string no_hp { get; set; } = string.Empty;
        public string alamat_pelanggan { get; set; } = string.Empty;
    }
}
