using ProjekWinform.Controllers;
using ProjekWinform.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjekWinform
{
    public partial class ManageData : Form
    {
        private string username;
        private int id_akun;
        c_user controller = new c_user();

        public ManageData(string username, int id_akun)
        {
            InitializeComponent();
            this.username = username;
            this.id_akun = id_akun;
            this.StartPosition = FormStartPosition.CenterScreen;
            DgUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgUser.ReadOnly = true;
            ProjekWinform.Helpers.ThemeHelper.ApplyTheme(this);

            LoadData();
        }

        public void LoadData()
        {
            List<User> listUser = controller.Read();
            DgUser.DataSource = null;
            DgUser.DataSource = listUser;

            if (DgUser.Columns.Count > 0)
            {
                if (DgUser.Columns["Nama"] != null) DgUser.Columns["Nama"].Visible = false;
                if (DgUser.Columns["NoHandphone"] != null) DgUser.Columns["NoHandphone"].Visible = false;
                if (DgUser.Columns["Alamat"] != null) DgUser.Columns["Alamat"].Visible = false;

                DgUser.Columns["id_user"].HeaderText = "ID User";
                DgUser.Columns["nama_lengkap"].HeaderText = "Nama Lengkap";
                DgUser.Columns["no_handphone"].HeaderText = "No HP";
                DgUser.Columns["alamat"].HeaderText = "Alamat";
                DgUser.Columns["status"].HeaderText = "Status";
                if (DgUser.Columns["id_akun"] != null)
                {
                    DgUser.Columns["id_akun"].HeaderText = "ID Akun";
                    DgUser.Columns["id_akun"].Visible = true;
                }

                DgUser.Columns["id_user"].DisplayIndex = 0;
                DgUser.Columns["nama_lengkap"].DisplayIndex = 1;
                DgUser.Columns["no_handphone"].DisplayIndex = 2;
                DgUser.Columns["alamat"].DisplayIndex = 3;
                DgUser.Columns["status"].DisplayIndex = 4;
                if (DgUser.Columns["id_akun"] != null)
                {
                    DgUser.Columns["id_akun"].DisplayIndex = 5;
                }
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (DgUser.CurrentRow != null)
            {
                User selectedUser = (User)DgUser.CurrentRow.DataBoundItem;
                FormInputUser form = new FormInputUser(selectedUser);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    string result = controller.Update(form.UserData);
                    MessageBox.Show(result, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("Pilih data yang ingin diedit", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void BtnKembali_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin(username, id_akun);
            formAdmin.Show();
            this.Hide();
        }

        private void Dashboard_data_Load(object sender, EventArgs e) { }
    }
}