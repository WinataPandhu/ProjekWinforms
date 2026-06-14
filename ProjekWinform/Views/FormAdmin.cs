using System;
using System.Windows.Forms;

namespace ProjekWinform
{
    public partial class FormAdmin : Form
    {
        private string username;
        private int id_akun;

        public FormAdmin(string username, int id_akun)
        {
            InitializeComponent();
            this.username = username;
            this.id_akun = id_akun;
            this.StartPosition = FormStartPosition.CenterScreen;
            LabelAdmin.Text = $"Selamat Datang, {username}!";
        }

        private void BtnAkun_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(username, id_akun);
            dashboard.Show();
            this.Hide();
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            Dashboard_data dashboard = new Dashboard_data(username, id_akun);
            dashboard.Show();
            this.Hide();
        }

        private void BtnKelola_Click(object sender, EventArgs e)
        {
            KelolaProduk kelolaProduk = new KelolaProduk(username, id_akun);
            kelolaProduk.Show();
            this.Hide();
        }

        private void BtnRiwayat_Click(object sender, EventArgs e) 
        {
            FormRiwayat formRiwayat = new FormRiwayat(username, id_akun);
            formRiwayat.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}