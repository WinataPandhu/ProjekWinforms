using Npgsql;
using ProjekWinform.Helpers;
using System;
using System.Windows.Forms;

namespace ProjekWinform
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ProjekWinform.Helpers.ThemeHelper.ApplyTheme(this);
            ProjekWinform.Helpers.ThemeHelper.LoadLogo(pictureBox1);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernameInput = TbUsername.Text.Trim();
            string passwordInput = TbPassword.Text.Trim();

            if (string.IsNullOrEmpty(usernameInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = connectDB.GetConn())
                {
                    string query = @"
                        SELECT a.id_akun, r.nama_role 
                        FROM akun a
                        JOIN roles r ON a.id_role = r.id_role
                        WHERE a.username = @username 
                          AND a.password_akun = @password";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", usernameInput);
                        cmd.Parameters.AddWithValue("password", passwordInput);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["nama_role"].ToString();
                                int id_akun = Convert.ToInt32(reader["id_akun"]);

                                MessageBox.Show("Login Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (role == "Admin")
                                {
                                    FormAdmin formAdmin = new FormAdmin(usernameInput, id_akun);
                                    formAdmin.Show();
                                    this.Hide();
                                }
                                else if (role == "Kasir")
                                {
                                    FormKasir formKasir = new FormKasir(usernameInput);
                                    formKasir.Show();
                                    this.Hide();
                                }
                                else if (role == "Kurir")
                                {
                                    FormKurir formKurir = new FormKurir(usernameInput);
                                    formKurir.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Role tidak dikenali!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username atau Password salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void TbUsername_TextChanged(object sender, EventArgs e) { }
    }
}