using ProjekWinform.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekWinform.Controllers
{
    class c_user
    {
        UserContext context = new UserContext();

        public string Validation(User user)
        {
            if (string.IsNullOrWhiteSpace(user.nama) || string.IsNullOrWhiteSpace(user.no_handphone) || string.IsNullOrWhiteSpace(user.alamat))
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

            if (validation != null)
            {
                return validation;
            }
            context.Create(user);

            return "Data berhasil ditambahkan";
        }

        public string Update(User user)
        {
            string validation = Validation(user);

            if (validation != null)
            {
                return validation;
            }
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