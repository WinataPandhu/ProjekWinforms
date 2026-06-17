using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekWinform.Models
{
    public abstract class BasePengiriman
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

        public abstract decimal HitungBiayaKirim();
    }

    public class Pengiriman : BasePengiriman
    {
        public override decimal HitungBiayaKirim()
        {
            return ongkir;
        }
    }

    public class PengirimanDalamKota : BasePengiriman
    {
        public override decimal HitungBiayaKirim()
        {
            return 10000;
        }
    }
}
