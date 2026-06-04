using System;

namespace ProjekWinform.Models
{
    public class User
    {
        public int id { get; set; }
        public string nama { get; set; }
        public string no_handphone { get; set; }
        public string alamat { get; set; }

        public User(int id, string nama, string no_handphone, string alamat)
        {
            this.id = id;
            this.nama = nama;
            this.no_handphone = no_handphone;
            this.alamat = alamat;
        }
    }
}