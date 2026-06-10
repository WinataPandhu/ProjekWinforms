using System;

namespace ProjekWinform.Models
{
    public class User
    {
        public int id_user { get; set; }
        public string nama_lengkap { get; set; } = string.Empty;
        public string no_handphone { get; set; } = string.Empty;
        public string alamat { get; set; } = string.Empty;
        public string status { get; set; } = string.Empty;
        public int id_akun { get; set; }
    }
}