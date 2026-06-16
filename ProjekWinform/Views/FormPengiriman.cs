using ProjekWinform.Controllers;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjekWinform
{
    public partial class FormPengiriman : Form
    {
        private int id_pengirim;
        private string savedUsername;

        c_pengiriman controller = new c_pengiriman();

        public FormPengiriman(int id, string nama, string noHp, string alamat, string status, string username)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ProjekWinform.Helpers.ThemeHelper.ApplyTheme(this);

            this.id_pengirim = id;
            this.savedUsername = username;

            lblNama.Text = "Nama Pelanggan: " + nama;
            lblNoHp.Text = "No HP: " + noHp;
            lblAlamat.Text = "Alamat Tujuan: " + alamat;
            lblStatus.Text = "Status: " + status;
        }



        private void btnStatus_Click(object sender, EventArgs e)
        {
            string statusSekarang = lblStatus.Text;

            if (statusSekarang.Contains("Sudah Dikirim"))
            {
                MessageBox.Show("Status Sudah Dikirim!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dr = MessageBox.Show(
                "Ubah status menjadi Sudah Dikirim?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string result = controller.UbahStatus(id_pengirim);
                MessageBox.Show(result, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Update text label status di layar biar langsung berubah
                lblStatus.Text = "Status: Sudah Dikirim";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormKurir kurir = new FormKurir(savedUsername);
            kurir.Show();
            this.Hide();
        }
    }
}