using System;

namespace ProjekWinform.Models
{
    public class Orang
    {
        public string Nama { get; set; } = string.Empty;
        public string NoHandphone { get; set; } = string.Empty;
        public string Alamat { get; set; } = string.Empty;
    }

    public class User : Orang
    {
        public int id_user { get; set; }
        public string status { get; set; } = string.Empty;
        public int id_akun { get; set; }

        public string nama_lengkap
        {
            get => Nama;
            set => Nama = value;
        }

        public string no_handphone
        {
            get => NoHandphone;
            set => NoHandphone = value;
        }

        public string alamat
        {
            get => Alamat;
            set => Alamat = value;
        }
    }
}