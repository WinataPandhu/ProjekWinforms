using ProjekWinform.Controllers;
using ProjekWinform.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjekWinform
{
    public partial class ManageAkun : Form
    {
        private string username;
        private int id_akun;
        c_akun controller = new c_akun();

        public ManageAkun(string username, int id_akun)
        {
            InitializeComponent();
            this.username = username;
            this.id_akun = id_akun;
            this.StartPosition = FormStartPosition.CenterScreen;
            DgUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadData();
            DgUser.ReadOnly = true;
            ProjekWinform.Helpers.ThemeHelper.ApplyTheme(this);
        }

        public void LoadData()
        {
            List<Akun> listAkun = controller.Read();
            DgUser.DataSource = null;
            DgUser.DataSource = listAkun;

            if (DgUser.Columns.Count > 0)
            {
                DgUser.Columns["id_akun"].HeaderText = "ID Akun";
                DgUser.Columns["username"].HeaderText = "Username";
                DgUser.Columns["password_akun"].HeaderText = "Password";
                DgUser.Columns["email"].HeaderText = "Email";
                DgUser.Columns["nama_role"].HeaderText = "Role";
                DgUser.Columns["id_role"].Visible = false;


                DgUser.Columns["id_akun"].DisplayIndex = 0;
                DgUser.Columns["username"].DisplayIndex = 1;
                DgUser.Columns["email"].DisplayIndex = 2;
                DgUser.Columns["password_akun"].DisplayIndex = 3;
                DgUser.Columns["nama_role"].DisplayIndex = 4;
            }
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

        private void btnLihat_Click(object sender, EventArgs e)
        {
            if (DgUser.CurrentRow != null)
            {
                Akun selectedAkun = (Akun)DgUser.CurrentRow.DataBoundItem;
                c_user userController = new c_user();
                User user = userController.GetUserByAkun(selectedAkun.id_akun);

                string info = $"Username : {selectedAkun.username}\n" +
                              $"Nama     : {user.nama_lengkap}\n" +
                              $"No HP    : {user.no_handphone}\n" +
                              $"Alamat   : {user.alamat}\n" +
                              $"Status   : {user.status}";

                MessageBox.Show(info, "Info Pemilik Akun", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pilih akun terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin(username, id_akun);
            formAdmin.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e) { }

        private void DgUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}