namespace ProjekWinform.Models
{
    public class Pengguna
    {
        public int id_akun { get; set; }
        public string username { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;

        public virtual string GetInfoLengkap()
        {
            return $"User: {username} ({email})";
        }
    }

    public class Akun : Pengguna
    {
        public string password_akun { get; set; } = string.Empty;
        public int id_role { get; set; }
        public string nama_role { get; set; } = string.Empty;

        public override string GetInfoLengkap()
        {
            return $"[AKUN SISTEM] Username: {username} | Role ID: {id_role}";
        }
    }
}