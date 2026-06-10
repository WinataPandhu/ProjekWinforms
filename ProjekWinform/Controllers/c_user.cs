using ProjekWinform.Models;
using System.Collections.Generic;

namespace ProjekWinform.Controllers
{
    class c_user
    {
        UserContext context = new UserContext();

        public string Validation(User user)
        {
            if (string.IsNullOrWhiteSpace(user.nama_lengkap) ||
                string.IsNullOrWhiteSpace(user.no_handphone) ||
                string.IsNullOrWhiteSpace(user.alamat) ||
                string.IsNullOrWhiteSpace(user.status))
            {
                return "Semua data harus diisi";
            }
            return null;
        }

        public List<User> Read()
        {
            return context.Read();
        }

        public string Create(User user)
        {
            string validation = Validation(user);
            if (validation != null) return validation;
            context.Create(user);
            return "Data berhasil ditambahkan";
        }

        public string Update(User user)
        {
            string validation = Validation(user);
            if (validation != null) return validation;
            context.Update(user);
            return "Data berhasil diupdate";
        }

        public string Delete(int id)
        {
            context.Delete(id);
            return "Data berhasil dihapus";
        }
    }
}