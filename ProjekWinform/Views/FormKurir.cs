using ProjekWinform.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjekWinform
{
    public partial class FormKurir : Form
    {
        private string username;
        private int idPengirimanTerpilih = 0;

        c_pengiriman controller = new c_pengiriman();
        public FormKurir(string username)
        {
            InitializeComponent();
            this.username = username;
            this.StartPosition = FormStartPosition.CenterScreen;
            label1.Text = $"Selamat Datang, {username}!";
            ProjekWinform.Helpers.ThemeHelper.ApplyTheme(this);
            ProjekWinform.Helpers.ThemeHelper.LoadLogo(pictureBox1);

            dgAntar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgAntar.ReadOnly = true;
            LoadData();
        }

        private void LoadData()
        {
            dgAntar.DataSource = controller.ReadPengiriman();
            DataTable dt = controller.ReadPengiriman();

            DataView dv = new DataView(dt);
            dv.RowFilter = "status_pengiriman = 'Belum Dikirim'";

            dgAntar.DataSource = dv;

            if (dgAntar.Columns["nama_pelanggan"] != null)
                dgAntar.Columns["nama_pelanggan"].HeaderText = "Nama Pelanggan";
            if (dgAntar.Columns["no_hp"] != null)
                dgAntar.Columns["no_hp"].HeaderText = "No HP";
            if (dgAntar.Columns["alamat_tujuan"] != null)
                dgAntar.Columns["alamat_tujuan"].HeaderText = "Alamat";
            if (dgAntar.Columns["status_pengiriman"] != null)
                dgAntar.Columns["status_pengiriman"].HeaderText = "Status Pesanan";
            if (dgAntar.Columns["id_pengirim"] != null)
                dgAntar.Columns["id_pengirim"].Visible = false;
        }

        private void BtnAntar_Click(object sender, EventArgs e)
        {
            if (dgAntar.CurrentRow == null)
            {
                MessageBox.Show("Pilih data pengiriman dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id_pengirim = Convert.ToInt32(dgAntar.CurrentRow.Cells["id_pengirim"].Value);
            string nama = dgAntar.CurrentRow.Cells["nama_pelanggan"].Value.ToString();
            string noHp = dgAntar.CurrentRow.Cells["no_hp"].Value.ToString();
            string alamat = dgAntar.CurrentRow.Cells["alamat_pelanggan"].Value.ToString();
            string status = dgAntar.CurrentRow.Cells["status_pengiriman"].Value.ToString();

            FormPengiriman frmPengiriman = new FormPengiriman(id_pengirim, nama, noHp, alamat, status, this.username);
            frmPengiriman.Show();
            this.Hide();
        }

        private void BtnRiwayat_Click(object sender, EventArgs e)
        {
            FormRiwayatKurir riwayat = new FormRiwayatKurir();
            riwayat.Show();
            this.Hide();
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void FormKurir_Load(object sender, EventArgs e)
        {

        }
    }
}
