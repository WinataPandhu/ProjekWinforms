using ProjekWinform.Controllers;
using ProjekWinform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjekWinform.Views
{
    public partial class FormRiwayatKasir : Form
    {
        public string username;
        c_transaksi controllerTransaksi = new c_transaksi();
        public FormRiwayatKasir(string username)
        {
            InitializeComponent();
            this.username = username;
            this.StartPosition = FormStartPosition.CenterScreen;
            dgRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgRiwayat.ReadOnly = true;
            LoadRiwayatTransaksi();
            ProjekWinform.Helpers.ThemeHelper.ApplyTheme(this);
        }


        private void LoadRiwayatTransaksi()
        {
            List<Transaksi> listTransaksi = controllerTransaksi.ReadTransaksi();

            dgRiwayat.DataSource = null;
            dgRiwayat.DataSource = listTransaksi;

            AturHeaderTabel();
        }

        private void AturHeaderTabel()
        {
            if (dgRiwayat.Columns["id_transaksi"] != null) dgRiwayat.Columns["id_transaksi"]!.Visible = false;

            if (dgRiwayat.Columns["tanggal_transaksi"] != null) dgRiwayat.Columns["tanggal_transaksi"]!.HeaderText = "Tanggal";
            if (dgRiwayat.Columns["nama_pelanggan"] != null) dgRiwayat.Columns["nama_pelanggan"]!.HeaderText = "Nama Pelanggan";
            if (dgRiwayat.Columns["kasir"] != null) dgRiwayat.Columns["kasir"]!.HeaderText = "Kasir";
            if (dgRiwayat.Columns["nama_alat"] != null) dgRiwayat.Columns["nama_alat"]!.HeaderText = "Nama Barang";
            if (dgRiwayat.Columns["quantity"] != null) dgRiwayat.Columns["quantity"]!.HeaderText = "Qty";
            if (dgRiwayat.Columns["harga_jual"] != null) dgRiwayat.Columns["harga_jual"]!.HeaderText = "Harga";
            if (dgRiwayat.Columns["subtotal"] != null) dgRiwayat.Columns["subtotal"]!.HeaderText = "Subtotal";
            if (dgRiwayat.Columns["metode_bayar"] != null) dgRiwayat.Columns["metode_bayar"]!.HeaderText = "Metode Pembayaran";
            if (dgRiwayat.Columns["metode_ambil"] != null) dgRiwayat.Columns["metode_ambil"]!.HeaderText = "Metode Pengambilan";
        }
        private void FormRiwayatKasir_Load(object sender, EventArgs e)
        {

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            List<Transaksi> listTransaksi = controllerTransaksi.ReadTransaksiByKeyword(txtCari.Text);

            dgRiwayat.DataSource = null;
            dgRiwayat.DataSource = listTransaksi;

            AturHeaderTabel();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormKasir dashboard = new FormKasir(username);
            dashboard.Show();
            this.Hide();
        }

        private void dgRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            // Jika textbox kosong (baik karena dihapus atau di-backspace), otomatis reset data ke awal
            if (string.IsNullOrWhiteSpace(txtCari.Text))
            {
                LoadRiwayatTransaksi();
            }
        }
    }
}
