using ProjekWinform.Helpers;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekWinform.Models
{
    class UserContext
    {
        public List<User> Read()
        {
            List<User> listuser = new List<User>();

            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string sql = "SELECT id_user, nama_lengkap, no_handphone, alamat FROM users ORDER BY id_user ASC";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    using (NpgsqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listuser.Add(new User(
                                Convert.ToInt32(dr["id_user"]),
                                dr["nama_lengkap"].ToString(),
                                dr["no_handphone"].ToString(),
                                dr["alamat"].ToString()
                            ));
                        }
                    }
                }
            }

            return listuser;
        }

        public void Create(User user)
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string sql = "INSERT INTO users (nama_lengkap, no_handphone, alamat, status, id_akun) VALUES (@nama, @no_handphone, @alamat, 'Aktif', 1)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("nama", user.nama);
                    cmd.Parameters.AddWithValue("no_handphone", user.no_handphone);
                    cmd.Parameters.AddWithValue("alamat", user.alamat);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(User user)
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string sql = "UPDATE users SET nama_lengkap=@nama, no_handphone=@no_handphone, alamat=@alamat WHERE id_user=@id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("nama", user.nama);
                    cmd.Parameters.AddWithValue("no_handphone", user.no_handphone);
                    cmd.Parameters.AddWithValue("alamat", user.alamat);
                    cmd.Parameters.AddWithValue("id", user.id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string sql = "DELETE FROM users WHERE id_user=@id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}