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

        public FormKurir()
        {
            InitializeComponent();
        }

        private void BtnAntar_Click(object sender, EventArgs e)
        {
            FormPengiriman kirim = new FormPengiriman();
            kirim.Show();
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
