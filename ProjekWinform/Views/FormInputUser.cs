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
            IsiComboStatus();
            IsiComboAkun();
        }

        public FormInputUser(User user) : this()
        {
            UserData = user;
            txtNama.Text = user.nama_lengkap;
            txtNoHp.Text = user.no_handphone;
            txtAlamat.Text = user.alamat;
            cmbStatus.Text = user.status;
            cmbIdAkun.Text = user.id_akun.ToString();
        }

        private void IsiComboStatus()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Aktif");
            cmbStatus.Items.Add("Tidak Aktif");
        }

        private void IsiComboAkun()
        {
            // isi manual sesuai data akun yang ada
            cmbIdAkun.Items.Clear();
            cmbIdAkun.Items.Add("1");
            cmbIdAkun.Items.Add("2");
            cmbIdAkun.Items.Add("3");
            cmbIdAkun.Items.Add("4");
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtNoHp.Text) ||
                string.IsNullOrWhiteSpace(txtAlamat.Text) ||
                cmbStatus.SelectedItem == null ||
                cmbIdAkun.SelectedItem == null)
            {
                MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UserData == null) UserData = new User();

            UserData.nama_lengkap = txtNama.Text;
            UserData.no_handphone = txtNoHp.Text;
            UserData.alamat = txtAlamat.Text;
            UserData.status = cmbStatus.SelectedItem.ToString();
            UserData.id_akun = Convert.ToInt32(cmbIdAkun.SelectedItem);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}