namespace ProjekWinform.Models
{
    public class AlatPertanian
    {
        public int id_alat { get; set; }
        public string nama_alat { get; set; } = string.Empty;
        public decimal harga { get; set; }
        public int stok { get; set; }
        public string status_alat { get; set; } = string.Empty;
        public int id_jenis { get; set; }
    }
}