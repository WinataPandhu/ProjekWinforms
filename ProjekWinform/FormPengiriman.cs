using ProjekWinform.Controllers;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjekWinform
{
    public partial class FormPengiriman : Form
    {
        c_pengiriman controller = new c_pengiriman();

        public FormPengiriman()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dgAntar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgAntar.ReadOnly = true;
            LoadData();
        }

        private void LoadData(string keyword = "")
        {
            dgAntar.DataSource = controller.ReadPengirimanByNama(keyword);
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            LoadData(textCari.Text);
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (dgAntar.CurrentRow == null)
            {
                MessageBox.Show("Pilih data pengiriman terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id_pengirim = Convert.ToInt32(dgAntar.CurrentRow.Cells["id_pengirim"].Value);
            string statusSekarang = dgAntar.CurrentRow.Cells["status_pengiriman"].Value.ToString();

            if (statusSekarang == "Sudah Dikirim")
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
                LoadData(textCari.Text);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormKurir kurir = new FormKurir();
            kurir.Show();
            this.Hide();
        }
    }
}