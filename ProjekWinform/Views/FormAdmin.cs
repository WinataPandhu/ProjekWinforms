using System;
using System.Windows.Forms;

namespace ProjekWinform
{
    public partial class FormAdmin : Form
    {
        private string username;

        public FormAdmin(string username)
        {
            InitializeComponent();
            this.username = username;
            this.StartPosition = FormStartPosition.CenterScreen;
            LabelAdmin.Text = $"Selamat Datang, {username}!";
        }

        private void BtnAkun_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(username);
            dashboard.Show();
            this.Hide();
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            Dashboard_data dashboard = new Dashboard_data(username);
            dashboard.Show();
            this.Hide();
        }

        private void BtnKelola_Click(object sender, EventArgs e)
        {

        }

        private void BtnRiwayat_Click(object sender, EventArgs e)
        {

        }
    }
}