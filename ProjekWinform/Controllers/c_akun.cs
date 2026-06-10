using Npgsql;
using ProjekWinform.Helpers;
using ProjekWinform.Models;
using System.Collections.Generic;

namespace ProjekWinform.Controllers
{
    public class c_akun
    {
        public List<Akun> Read()
        {
            List<Akun> list = new List<Akun>();

            using (var conn = connectDB.GetConn())
            {
                string query = "SELECT id_akun, username, password_akun, email, id_role FROM akun";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Akun
                        {
                            id_akun = reader.GetInt32(0),
                            username = reader.GetString(1),
                            password_akun = reader.GetString(2),
                            email = reader.GetString(3),
                            id_role = reader.GetInt32(4)
                        });
                    }
                }
            }
            return list;
        }

        public string Create(Akun akun)
        {
            using (var conn = connectDB.GetConn())
            {
                string query = "INSERT INTO akun (username, password_akun, email, id_role) VALUES (@username, @password, @email, @id_role)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", akun.username);
                    cmd.Parameters.AddWithValue("password", akun.password_akun);
                    cmd.Parameters.AddWithValue("email", akun.email);
                    cmd.Parameters.AddWithValue("id_role", akun.id_role);
                    cmd.ExecuteNonQuery();
                }
            }
            return "Akun berhasil ditambahkan!";
        }

        public string Update(Akun akun)
        {
            using (var conn = connectDB.GetConn())
            {
                string query = "UPDATE akun SET username=@username, password_akun=@password, email=@email, id_role=@id_role WHERE id_akun=@id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", akun.username);
                    cmd.Parameters.AddWithValue("password", akun.password_akun);
                    cmd.Parameters.AddWithValue("email", akun.email);
                    cmd.Parameters.AddWithValue("id_role", akun.id_role);
                    cmd.Parameters.AddWithValue("id", akun.id_akun);
                    cmd.ExecuteNonQuery();
                }
            }
            return "Akun berhasil diupdate!";
        }

        public string Delete(int id_akun)
        {
            using (var conn = connectDB.GetConn())
            {
                string query = "DELETE FROM akun WHERE id_akun=@id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", id_akun);
                    cmd.ExecuteNonQuery();
                }
            }
            return "Akun berhasil dihapus!";
        }
    }
}