using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekWinform.Models
{
    public class HistoriRestok
    {
        public int id_histori { get; set; }
        public int harga_beli { get; set; }
        public int stok_dibeli { get; set; }
        public DateTime tanggal_pembelian { get; set; }
        public string nama_lengkap { get; set; } = string.Empty;
        public string nama_alat { get; set; } = string.Empty;
    }
}
