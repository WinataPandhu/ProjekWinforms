using ProjekWinform.Controllers;
using ProjekWinform.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjekWinform
{
    public partial class Dashboard : Form
    {
        private string username;
        private int id_akun;
        c_akun controller = new c_akun();

        public Dashboard(string username, int id_akun)
        {
            InitializeComponent();
            this.username = username;
            this.id_akun = id_akun;
            this.StartPosition = FormStartPosition.CenterScreen;
            DgUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadData();
            DgUser.ReadOnly = true;
        }

        public void LoadData()
        {
            List<Akun> listAkun = controller.Read();
            DgUser.DataSource = null;
            DgUser.DataSource = listAkun;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormInputAkun form = new FormInputAkun();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (DgUser.CurrentRow != null)
            {
                Akun selectedAkun = (Akun)DgUser.CurrentRow.DataBoundItem;
                FormInputAkun form = new FormInputAkun(selectedAkun);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    string result = controller.Update(form.AkunData);
                    MessageBox.Show(result, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("Pilih data yang ingin diedit", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (DgUser.CurrentRow != null)
            {
                Akun selectedAkun = (Akun)DgUser.CurrentRow.DataBoundItem;
                DialogResult dr = MessageBox.Show(
                    "Apakah Anda yakin ingin menghapus akun ini?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    string result = controller.Delete(selectedAkun.id_akun);
                    MessageBox.Show(result, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang ingin dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin(username, id_akun);
            formAdmin.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e) { }
    }
}