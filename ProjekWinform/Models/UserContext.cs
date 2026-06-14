using ProjekWinform.Helpers;
using Npgsql;
using System;
using System.Collections.Generic;

namespace ProjekWinform.Models
{
    class UserContext
    {
        public List<User> Read()
        {
            List<User> listuser = new List<User>();

            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string sql = "SELECT id_user, nama_lengkap, no_handphone, alamat, status, id_akun FROM users ORDER BY id_user ASC";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    using (NpgsqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listuser.Add(new User
                            {
                                id_user = Convert.ToInt32(dr["id_user"]),
                                nama_lengkap = dr["nama_lengkap"].ToString(),
                                no_handphone = dr["no_handphone"].ToString(),
                                alamat = dr["alamat"].ToString(),
                                status = dr["status"].ToString(),
                                id_akun = Convert.ToInt32(dr["id_akun"])
                            });
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
                string sql = "INSERT INTO users (nama_lengkap, no_handphone, alamat, status, id_akun) VALUES (@nama, @no_handphone, @alamat, @status, @id_akun)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("nama", user.nama_lengkap);
                    cmd.Parameters.AddWithValue("no_handphone", user.no_handphone);
                    cmd.Parameters.AddWithValue("alamat", user.alamat);
                    cmd.Parameters.AddWithValue("status", user.status);
                    cmd.Parameters.AddWithValue("id_akun", user.id_akun);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(User user)
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string sql = "UPDATE users SET nama_lengkap=@nama, no_handphone=@no_handphone, alamat=@alamat, status=@status, id_akun=@id_akun WHERE id_user=@id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("nama", user.nama_lengkap);
                    cmd.Parameters.AddWithValue("no_handphone", user.no_handphone);
                    cmd.Parameters.AddWithValue("alamat", user.alamat);
                    cmd.Parameters.AddWithValue("status", user.status);
                    cmd.Parameters.AddWithValue("id_akun", user.id_akun);
                    cmd.Parameters.AddWithValue("id", user.id_user);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public User GetUserByAkun(int id_akun)
        {
            using (NpgsqlConnection conn = connectDB.GetConn())
            {
                string sql = "SELECT id_user, nama_lengkap, no_handphone, alamat, status, id_akun FROM users WHERE id_akun = @id_akun";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("id_akun", id_akun);
                    using (NpgsqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new User
                            {
                                id_user = Convert.ToInt32(dr["id_user"]),
                                nama_lengkap = dr["nama_lengkap"].ToString(),
                                no_handphone = dr["no_handphone"].ToString(),
                                alamat = dr["alamat"].ToString(),
                                status = dr["status"].ToString(),
                                id_akun = Convert.ToInt32(dr["id_akun"])
                            };
                        }
                        return null;
                    }
                }
            }
        }
    }
}