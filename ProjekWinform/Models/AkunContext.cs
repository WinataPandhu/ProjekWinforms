using Npgsql;
using ProjekWinform.Helpers;
using ProjekWinform.Models;
using System;
using System.Collections.Generic;

namespace ProjekWinform.Models
{
    public class AkunContext
    {
        public List<Akun> Read()
        {
            List<Akun> list = new List<Akun>();
            using (var conn = connectDB.GetConn())
            {
                string query = @"SELECT a.id_akun, a.username, a.password_akun, a.email, a.id_role, r.nama_role 
                         FROM akun a
                         JOIN roles r ON a.id_role = r.id_role";

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
                            id_role = reader.GetInt32(4),
                            nama_role = reader.GetString(5)
                        });
                    }
                }
            }
            return list;
        }

        public bool IsUsernameExists(string username)
        {
            using (var conn = connectDB.GetConn())
            {
                string query = "SELECT COUNT(*) FROM akun WHERE username = @username";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public bool IsEmailExists(string email)
        {
            using (var conn = connectDB.GetConn())
            {
                string query = "SELECT COUNT(*) FROM akun WHERE email = @email";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("email", email);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public void Create(Akun akun)
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
        }

        public int CreateAndGetId(Akun akun)
        {
            using (var conn = connectDB.GetConn())
            {
                string query = "SELECT func_tambah_akun_get_id(@username, @password, @email, @id_role)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", akun.username);
                    cmd.Parameters.AddWithValue("password", akun.password_akun);
                    cmd.Parameters.AddWithValue("email", akun.email);
                    cmd.Parameters.AddWithValue("id_role", akun.id_role);

                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public void Update(Akun akun)
        {
            using (var conn = connectDB.GetConn())
            {
                string query = "CALL proc_update_akun(@id, @username, @password, @email, @id_role)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", akun.id_akun);
                    cmd.Parameters.AddWithValue("username", akun.username);
                    cmd.Parameters.AddWithValue("password", akun.password_akun);
                    cmd.Parameters.AddWithValue("email", akun.email);
                    cmd.Parameters.AddWithValue("id_role", akun.id_role);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id_akun)
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
        }
    }
}