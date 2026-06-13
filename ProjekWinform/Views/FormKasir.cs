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
    public partial class FormKasir : Form
    {
        private string username;
        public FormKasir(string username)
        {
            InitializeComponent();
            this.username = username;
            this.StartPosition = FormStartPosition.CenterScreen;
            LabelKasir.Text = $"Selamat Datang, {username}!";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnStok_Click(object sender, EventArgs e)
        {

        }

        private void BtnPesanan_Click(object sender, EventArgs e)
        {
            FormBuatPesanan pesan = new FormBuatPesanan();
            pesan.Show();
            this.Hide();
        }

        private void BtnRiwayat_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
