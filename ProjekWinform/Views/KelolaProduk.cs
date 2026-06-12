using ProjekWinform.Controllers;
using ProjekWinform.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjekWinform
{
    public partial class KelolaProduk : Form
    {
        private string username;
        private int id_akun;
        c_alat controller = new c_alat();

        public KelolaProduk(string username, int id_akun)
        {
            InitializeComponent();
            this.username = username;
            this.id_akun = id_akun;
            this.StartPosition = FormStartPosition.CenterScreen;
            DgProduk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadData();
            DgProduk.ReadOnly = true;
        }

        public void LoadData()
        {
            List<AlatPertanian> listAlat = controller.Read();
            DgProduk.DataSource = null;
            DgProduk.DataSource = listAlat;
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            FormInputAlat form = new FormInputAlat();
            if (form.ShowDialog() == DialogResult.OK)
            {
                string result = controller.Create(form.AlatData);
                MessageBox.Show(result, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void BtnRestok_Click(object sender, EventArgs e)
        {
            if (DgProduk.CurrentRow != null)
            {
                AlatPertanian selectedAlat = (AlatPertanian)DgProduk.CurrentRow.DataBoundItem;
                FormRestok form = new FormRestok();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    string result = controller.Restok(selectedAlat, form.JumlahRestok, form.HargaBeli, id_akun);
                    MessageBox.Show(result, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Pilih produk yang ingin direstok!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnHarga_Click(object sender, EventArgs e)
        {
            if (DgProduk.CurrentRow != null)
            {
                AlatPertanian selectedAlat = (AlatPertanian)DgProduk.CurrentRow.DataBoundItem;
                FormHargaBaru form = new FormHargaBaru(selectedAlat);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    string result = controller.UpdateHarga(form.AlatData);
                    MessageBox.Show(result, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Pilih produk yang ingin diubah harganya!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin(username, id_akun);
            formAdmin.Show();
            this.Hide();
        }

        private void DgProduk_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}