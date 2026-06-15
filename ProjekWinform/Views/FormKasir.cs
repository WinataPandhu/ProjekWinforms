using ProjekWinform.Controllers;
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

        public FormKasir(string username)
        {
            InitializeComponent();
            this.username = username;
            this.StartPosition = FormStartPosition.CenterScreen;
            LabelKasir.Text = $"Selamat Datang, {username}!";
            id_user = controller.GetIdUserByUsername(username);
        }

        private void BtnPesanan_Click(object sender, EventArgs e)
        {
            FormBuatPesanan pesan = new FormBuatPesanan(username, id_user);
            pesan.Show();
            this.Hide();
        }

        private void BtnStok_Click(object sender, EventArgs e)
        {
            FormStokProduk stokProduk = new FormStokProduk(username);
            stokProduk.Show();
            this.Close();
        }

        private void BtnRiwayat_Click(object sender, EventArgs e)
        {
            FormRiwayatKasir riwayatKasir = new FormRiwayatKasir();
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
        private void FormKasir_Load(object sender, EventArgs e) { }
    }
}