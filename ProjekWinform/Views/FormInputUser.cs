using ProjekWinform.Models;
using System;
using System.Windows.Forms;

namespace ProjekWinform
{
    public partial class FormInputUser : Form
    {
        public User UserData { get; private set; }

        public FormInputUser()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public FormInputUser(User user) : this()
        {
            UserData = user;
            textBoxNama.Text = user.nama;
            textBoxUmur.Text = user.no_handphone;
            textBoxAsal.Text = user.alamat;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNama.Text) ||
                string.IsNullOrWhiteSpace(textBoxUmur.Text) ||
                string.IsNullOrWhiteSpace(textBoxAsal.Text))
            {
                MessageBox.Show("Semua data harus diisi!");
                return;
            }

            DialogResult dr = MessageBox.Show(
                "Apakah Anda yakin ingin menyimpan data ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (UserData == null)
                {
                    UserData = new User(0, textBoxNama.Text, textBoxUmur.Text, textBoxAsal.Text);
                }
                else
                {
                    UserData = new User(UserData.id, textBoxNama.Text, textBoxUmur.Text, textBoxAsal.Text);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Apakah Anda yakin ingin membatalkan perubahan?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}