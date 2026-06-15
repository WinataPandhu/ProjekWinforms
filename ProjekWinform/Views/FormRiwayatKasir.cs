using ProjekWinform.Controllers;
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
        public FormRiwayatKasir()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dgRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgRiwayat.ReadOnly = true;
            LoadData();
        }

        private void LoadData()
        {
            dgRiwayat.DataSource = controllerTransaksi.ReadTransaksi();
        }

        private void FormRiwayatKasir_Load(object sender, EventArgs e)
        {

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            DataTable dtTransaksi = controllerTransaksi.ReadTransaksiByKeyword(txtCari.Text);
            dgRiwayat.DataSource = null;
            dgRiwayat.DataSource = dtTransaksi;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormKasir dashboard = new FormKasir(username);
            dashboard.Show();
            this.Hide();
        }
    }
}
