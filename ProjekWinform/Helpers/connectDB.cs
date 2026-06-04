using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekWinform.Helpers
{
    public class connectDB
    {
        private static string connString =
            "Host=localhost;" +
            "Port=5432;" +
            "Username=postgres;" +
            "Password=2621;" +
            "Database=ProjekQuery;";
        public static NpgsqlConnection GetConn()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connString);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal di : " + ex.Message);
            }

            return conn;
        }

    }
}
