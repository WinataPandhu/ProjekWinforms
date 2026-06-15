using ProjekWinform.Controllers;
using ProjekWinform.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProjekWinform
{
    public partial class FormRiwayat : Form
    {
        private string username;
        private int id_akun;
        private string modeAktif = "";
        c_alat controllerAlat = new c_alat();
        c_transaksi controllerTransaksi = new c_transaksi();

        public FormRiwayat(string username, int id_akun)
        {
            InitializeComponent();
            this.username = username;
            this.id_akun = id_akun;
            this.StartPosition = FormStartPosition.CenterScreen;
            DgRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgRiwayat.ReadOnly = true;
        }

        private void btnRiwayatRestok_Click(object sender, EventArgs e)
        {
            modeAktif = "restok";
            List<HistoriRestok> listRestok = controllerAlat.ReadRestok();
            DgRiwayat.DataSource = null;
            DgRiwayat.DataSource = listRestok;
        }

        private void btnRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            modeAktif = "transaksi";
            DataTable dtTransaksi = controllerTransaksi.ReadTransaksi();
            DgRiwayat.DataSource = null;
            DgRiwayat.DataSource = dtTransaksi;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin(username, id_akun);
            formAdmin.Show();
            this.Hide();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (modeAktif == "")
            {
                MessageBox.Show("Pilih dulu Riwayat Restok atau Riwayat Transaksi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (modeAktif == "transaksi")
            {
                DataTable dtTransaksi = controllerTransaksi.ReadTransaksiByKeyword(txtCari.Text);
                DgRiwayat.DataSource = null;
                DgRiwayat.DataSource = dtTransaksi;
            }
            else if (modeAktif == "restok")
            {
                List<HistoriRestok> listRestok = controllerAlat.ReadRestokByKeyword(txtCari.Text);
                DgRiwayat.DataSource = null;
                DgRiwayat.DataSource = listRestok;
            }
        }

        private void FormRiwayat_Load(object sender, EventArgs e)
        {

        }
    }
}