using ProjekWinform.Controllers;
using ProjekWinform.Models;
using System;
using System.Collections.Generic;
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
            ProjekWinform.Helpers.ThemeHelper.ApplyTheme(this);
        }

        public FormInputUser(User user) : this()
        {
            UserData = user;
            txtNama.Text = user.nama_lengkap;
            txtNoHp.Text = user.no_handphone;
            txtAlamat.Text = user.alamat;
            cmbStatus.Text = user.status;
            cmbIdAkun.Text = user.id_akun.ToString();
            cmbIdAkun.Enabled = false;
        }

        public FormInputUser(int idAkun) : this()
        {
            cmbIdAkun.Text = idAkun.ToString();
            cmbIdAkun.Enabled = false;
        }

        private void IsiComboStatus()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Aktif");
            cmbStatus.Items.Add("Tidak Aktif");
        }

        private void IsiComboAkun()
        {
            cmbIdAkun.Items.Clear();
            c_akun akunController = new c_akun();
            List<Akun> listAkun = akunController.Read();

            foreach (Akun akun in listAkun)
            {
                cmbIdAkun.Items.Add(akun.id_akun.ToString());
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtNoHp.Text) ||
                string.IsNullOrWhiteSpace(txtAlamat.Text) ||
                cmbStatus.SelectedItem == null ||
                string.IsNullOrWhiteSpace(cmbIdAkun.Text))
            {
                MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string noHp = txtNoHp.Text.Trim();
            bool isAngka = true;

            foreach (char c in noHp)
            {
                if (!char.IsDigit(c))
                {
                    isAngka = false;
                    break;
                }
            }

            if (!isAngka || noHp.Length < 8 || noHp.Length > 14)
            {
                MessageBox.Show("Nomor HP harus berupa angka dan berjumlah antara 8 hingga 14 digit!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UserData == null) UserData = new User();

            UserData.nama_lengkap = txtNama.Text;
            UserData.no_handphone = txtNoHp.Text;
            UserData.alamat = txtAlamat.Text;
            UserData.status = cmbStatus.SelectedItem.ToString();
            UserData.id_akun = Convert.ToInt32(cmbIdAkun.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e) { }
    }
}