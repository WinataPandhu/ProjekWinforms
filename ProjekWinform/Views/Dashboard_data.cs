using ProjekWinform.Controllers;
using ProjekWinform.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjekWinform
{
    public partial class Dashboard_data : Form
    {
        private string username;
        private int id_akun;
        c_user controller = new c_user();

        public Dashboard_data(string username, int id_akun)
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
            List<User> listUser = controller.Read();
            DgUser.DataSource = null;
            DgUser.DataSource = listUser;
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