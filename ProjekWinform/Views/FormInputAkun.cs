using ProjekWinform.Controllers;
using ProjekWinform.Models;
using System;
using System.Windows.Forms;

namespace ProjekWinform
{
    public partial class FormInputAkun : Form
    {
        public Akun AkunData = new Akun();
        private c_akun akunController = new c_akun();

        public FormInputAkun()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            IsiComboRole();
            ProjekWinform.Helpers.ThemeHelper.ApplyTheme(this);
        }

        public FormInputAkun(Akun akun)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            IsiComboRole();

            txtUsername.Text = akun.username;
            txtPassword.Text = akun.password_akun;
            txtEmail.Text = akun.email;
            cmbRole.SelectedValue = akun.id_role;

            AkunData = akun;
            ProjekWinform.Helpers.ThemeHelper.ApplyTheme(this);
        }

        private void IsiComboRole()
        {
            cmbRole.Items.Clear();
            cmbRole.Items.Add(new RoleItem { Id = 1, Nama = "Admin" });
            cmbRole.Items.Add(new RoleItem { Id = 2, Nama = "Kasir" });
            cmbRole.Items.Add(new RoleItem { Id = 3, Nama = "Kurir" });
            cmbRole.DisplayMember = "Nama";
            cmbRole.ValueMember = "Id";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RoleItem roleSelected = (RoleItem)cmbRole.SelectedItem;

            AkunData.username = txtUsername.Text;
            AkunData.password_akun = txtPassword.Text;
            AkunData.email = txtEmail.Text;
            AkunData.id_role = roleSelected.Id;

            if (AkunData.id_akun == 0)
            {
                int newIdAkun = akunController.CreateAndGetId(AkunData);

                if (newIdAkun == -1)
                {
                    MessageBox.Show("Username sudah digunakan, pilih username lain!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (newIdAkun == -2)
                {
                    MessageBox.Show("Email sudah digunakan, pilih email lain!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (newIdAkun <= 0)
                {
                    MessageBox.Show("Gagal menyimpan akun!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FormInputUser formUser = new FormInputUser(newIdAkun);
                this.Hide();

                if (formUser.ShowDialog() == DialogResult.OK)
                {
                    c_user userController = new c_user();
                    string result = userController.Create(formUser.UserData);
                    MessageBox.Show(result, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void txtEmail_TextChanged(object sender, EventArgs e) { }
        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e) { }
    }

}