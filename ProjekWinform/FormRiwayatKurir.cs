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
    public partial class FormRiwayatKurir : Form
    {
        c_pengiriman controller = new c_pengiriman();

        public FormRiwayatKurir()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dgRiwayatPengirim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgRiwayatPengirim.ReadOnly = true;
            LoadRiwayat();
        }

        private void LoadRiwayat(string tanggal = "")
        {
            dgRiwayatPengirim.DataSource = controller.ReadPengiriman(tanggal);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormKurir formKurir = new FormKurir();
            formKurir.Show();
            this.Hide();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string tanggal = dtpCari.Value.ToString("yyyy-MM-dd");
            LoadRiwayat(tanggal);
        }
    }
}
