using ProjekWinform.Models;
using System;
using System.Windows.Forms;

namespace ProjekWinform
{
    public partial class FormInputAlat : Form
    {
        public AlatPertanian AlatData = new AlatPertanian();

        public FormInputAlat()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            IsiComboStatus();
            IsiComboJenis();
            ProjekWinform.Helpers.ThemeHelper.ApplyTheme(this);
        }

        public FormInputAlat(AlatPertanian alat) : this()
        {
            AlatData = alat;
            txtNamaAlat.Text = alat.nama_alat;
            txtHarga.Text = alat.harga.ToString();

            if (alat.status_alat == "For Sale")
            {
                cmbStatus.SelectedIndex = 0;
            }
            else if (alat.status_alat == "Not Sale")
            {
                cmbStatus.SelectedIndex = 1;
            }

            cmbJenis.SelectedIndex = alat.id_jenis - 1;
        }

        private void IsiComboStatus()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("For Sale");
            cmbStatus.Items.Add("Not Sale");
        }

        private void IsiComboJenis()
        {
            cmbJenis.Items.Clear();
            cmbJenis.Items.Add(new JenisItem { Id = 1, Nama = "Alat Berat" });
            cmbJenis.Items.Add(new JenisItem { Id = 2, Nama = "Alat Ringan" });
            cmbJenis.Items.Add(new JenisItem { Id = 3, Nama = "Alat Elektronik" });
            cmbJenis.DisplayMember = "Nama";
            cmbJenis.ValueMember = "Id";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaAlat.Text) ||
                string.IsNullOrWhiteSpace(txtHarga.Text) ||
                cmbStatus.SelectedItem == null ||
                cmbJenis.SelectedItem == null)
            {
                MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            JenisItem jenisSelected = (JenisItem)cmbJenis.SelectedItem;

            AlatData.nama_alat = txtNamaAlat.Text;
            AlatData.harga = Convert.ToDecimal(txtHarga.Text);
            AlatData.status_alat = cmbStatus.SelectedItem.ToString();
            AlatData.id_jenis = jenisSelected.Id;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtNamaAlat_TextChanged(object sender, EventArgs e) { }
        private void txtHarga_TextChanged(object sender, EventArgs e) { }
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbJenis_SelectedIndexChanged(object sender, EventArgs e) { }

    }
}