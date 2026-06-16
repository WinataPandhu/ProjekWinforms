using ProjekWinform.Controllers;
using ProjekWinform.Models;
using ProjekWinform.Views;
using System;
using System.Windows.Forms;

namespace ProjekWinform
{
    public partial class FormKasir : Form
    {
        private string username;
        private int id_user;
        c_pesanan controller = new c_pesanan();
        private c_alat controllerAlat = new c_alat();

        public FormKasir(string username)
        {
            InitializeComponent();
            this.username = username;
            this.StartPosition = FormStartPosition.CenterScreen;
            LabelKasir.Text = $"Selamat Datang, {username}!";
            id_user = controller.GetIdUserByUsername(username);
            ProjekWinform.Helpers.ThemeHelper.ApplyTheme(this);
            ProjekWinform.Helpers.ThemeHelper.LoadLogo(pictureBox1);
            dgStokProduk.ReadOnly = true;
            dgStokProduk.AllowUserToAddRows = false;
            dgStokProduk.AllowUserToDeleteRows = false;
            ProjekWinform.Helpers.ThemeHelper.ApplyTheme(this);
        }

        private void MuatDataStok(string keyword)
        {
            try
            {
                List<AlatPertanian> semuaBarang = controllerAlat.Read();

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    semuaBarang = semuaBarang
                        .Where(a =>
                            (a.nama_alat != null && a.nama_alat.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||

                            (a.nama_jenis != null && a.nama_jenis.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||

                            (a.status_alat != null && a.status_alat.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||

                            (a.harga.ToString().IndexOf(keyword) >= 0) ||

                            (a.stok.ToString().IndexOf(keyword) >= 0)
                        )
                        .ToList();
                }

                var dataTampil = semuaBarang.Select(a => new
                {
                    ID = a.id_alat,
                    NamaAlat = a.nama_alat,
                    Jenis = a.nama_jenis,
                    Harga = a.harga,
                    SisaStok = a.stok,
                    Status = a.status_alat
                }).ToList();

                dgStokProduk.DataSource = dataTampil;

                if (dgStokProduk.Columns.Count > 0)
                {
                    dgStokProduk.Columns["ID"].Visible = false;
                    dgStokProduk.Columns["NamaAlat"].HeaderText = "Nama Alat";
                    dgStokProduk.Columns["Jenis"].HeaderText = "Nama Jenis";
                    dgStokProduk.Columns["Harga"].HeaderText = "Harga (Rp)";
                    dgStokProduk.Columns["SisaStok"].HeaderText = "Sisa Stok";
                    dgStokProduk.Columns["Status"].HeaderText = "Status Alat";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data stok dari controller: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPesanan_Click(object sender, EventArgs e)
        {
            FormBuatPesanan pesan = new FormBuatPesanan(username, id_user);
            pesan.Show();
            this.Hide();
        }


        private void BtnRiwayat_Click(object sender, EventArgs e)
        {
            FormRiwayatKasir riwayatKasir = new FormRiwayatKasir(username);
            riwayatKasir.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void FormKasir_Load(object sender, EventArgs e) 
        {
            MuatDataStok("");
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            MuatDataStok(txtCari.Text);
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCari.Text))
            {
                MuatDataStok(txtCari.Text);
            }
        }
    }
}