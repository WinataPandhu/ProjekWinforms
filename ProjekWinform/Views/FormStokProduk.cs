using System;
using System.Collections.Generic;
using System.Data;
using System.Linq; // Dibutuhkan untuk memfilter data menggunakan LINQ
using System.Windows.Forms;
using ProjekWinform.Controllers; // Menghubungkan ke folder Controllers
using ProjekWinform.Models;      // Menghubungkan ke folder Models

namespace ProjekWinform.Views
{
    public partial class FormStokProduk : Form
    {
        private string usernameAktif;

        // Buat instance dari controller c_alat agar bisa digunakan di semua method form ini
        private c_alat controllerAlat = new c_alat();

        public FormStokProduk(string username)
        {
            InitializeComponent();
            this.usernameAktif = username;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Proteksi Read-Only untuk Kasir
            dgStokProduk.ReadOnly = true;
            dgStokProduk.AllowUserToAddRows = false;
            dgStokProduk.AllowUserToDeleteRows = false;
            ProjekWinform.Helpers.ThemeHelper.ApplyTheme(this);
        }

        private void FormStokProduk_Load(object sender, EventArgs e)
        {
            MuatDataStok(""); // Panggil data pertama kali tanpa filter
        }

        // Fungsi memuat data yang sekarang memanfaatkan c_alat.cs
        private void MuatDataStok(string keyword)
        {
            try
            {
                // 1. Ambil list data produk pertanian dari Controller c_alat
                List<AlatPertanian> semuaBarang = controllerAlat.Read();

                // 2. Jika ada keyword pencarian, saring list menggunakan LINQ
                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    semuaBarang = semuaBarang
                        .Where(a => a.nama_alat != null &&
                                    a.nama_alat.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                        .ToList();
                }

                // 3. Transformasikan ke anonymous object atau DataTable agar tampilan header grid rapi
                var dataTampil = semuaBarang.Select(a => new
                {
                    ID = a.id_alat,
                    NamaAlat = a.nama_alat,
                    Jenis = a.nama_jenis,
                    Harga = a.harga,
                    SisaStok = a.stok,
                    Status = a.status_alat
                }).ToList();

                // 4. Masukkan ke DataGridView
                dgStokProduk.DataSource = dataTampil;

                // 5. Opsional: Mempercantik Header Text pada Grid
                if (dgStokProduk.Columns.Count > 0)
                {
                    dgStokProduk.Columns["ID"].HeaderText = "ID";
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

        // Event Klik Tombol Cari
        private void btnCari_Click(object sender, EventArgs e)
        {
            MuatDataStok(txtCari.Text);
        }

        // Event Klik Tombol Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            FormKasir kasir = new FormKasir(usernameAktif);
            kasir.Show();
            this.Close();
        }

        private void dgStokProduk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}