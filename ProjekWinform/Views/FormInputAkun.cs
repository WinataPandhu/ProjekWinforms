using ProjekWinform.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProjekWinform
{
    public partial class FormInputAkun : Form
    {

        public Akun AkunData = new Akun();

        public FormInputAkun()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            IsiComboRole();
        }

        // Constructor untuk Edit
        public FormInputAkun(Akun akun)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            IsiComboRole();

            // Isi form dengan data yang dipilih
            txtUsername.Text = akun.username;
            txtPassword.Text = akun.password_akun;
            txtEmail.Text = akun.email;
            cmbRole.SelectedValue = akun.id_role;

            AkunData = akun;
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

            if (AkunData == null)
            {
                // Mode Tambah
                AkunData = new Akun();
            }

            AkunData.username = txtUsername.Text;
            AkunData.password_akun = txtPassword.Text;
            AkunData.email = txtEmail.Text;
            AkunData.id_role = roleSelected.Id;

            this.DialogResult = DialogResult.OK;
            this.Close();
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

    // Class helper untuk ComboBox role
    public class RoleItem
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public override string ToString() => Nama;
    }
}