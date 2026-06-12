using ProjekWinform.Controllers;
using ProjekWinform.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjekWinform
{
    public partial class FormRiwayat : Form
    {
        private string username;
        private int id_akun;
        c_alat controller = new c_alat();

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
            List<HistoriRestok> listRestok = controller.ReadRestok();
            DgRiwayat.DataSource = null;
            DgRiwayat.DataSource = listRestok;
        }

        private void btnRiwayatTransaksi_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin(username, id_akun);
            formAdmin.Show();
            this.Hide();
        }
    }
}