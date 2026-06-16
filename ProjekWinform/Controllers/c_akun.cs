using ProjekWinform.Models;
using System.Collections.Generic;

namespace ProjekWinform.Controllers
{
    public class c_akun
    {
        private AkunContext context = new AkunContext();

        public List<Akun> Read()
        {
            return context.Read();
        }

        public string Create(Akun akun)
        {
            if (context.IsUsernameExists(akun.username))
            {
                return "Username sudah digunakan, pilih username lain!";
            }

            if (context.IsEmailExists(akun.email))
            {
                return "Email sudah digunakan, pilih email lain!";
            }

            context.Create(akun);
            return "Akun berhasil ditambahkan!";
        }

        public int CreateAndGetId(Akun akun)
        {
            if (context.IsUsernameExists(akun.username)) return -1;
            if (context.IsEmailExists(akun.email)) return -2;

            return context.CreateAndGetId(akun);
        }

        public string Update(Akun akun)
        {
            context.Update(akun);
            return "Akun berhasil diupdate!";
        }

        public string Delete(int id_akun)
        {
            context.Delete(id_akun);
            return "Akun berhasil dihapus!";
        }
    }
}