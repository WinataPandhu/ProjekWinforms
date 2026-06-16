using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekWinform.Models
{
    public class Pelanggan
    {
        public int id_pelanggan { get; set; }
        public string nama_pelanggan { get; set; } = string.Empty;
        public string no_hp { get; set; } = string.Empty;
        public string alamat_pelanggan { get; set; } = string.Empty;
    }
}