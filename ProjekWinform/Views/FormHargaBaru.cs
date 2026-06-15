using ProjekWinform.Models;
using System;
using System.Windows.Forms;

namespace ProjekWinform
{
    public partial class FormHargaBaru : Form
    {
        public AlatPertanian AlatData;

        public FormHargaBaru(AlatPertanian alat)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            AlatData = alat;
            txtHargaBaru.Text = alat.harga.ToString();
            ProjekWinform.Helpers.ThemeHelper.ApplyTheme(this);
        }



        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHargaBaru.Text))
            {
                MessageBox.Show("Harga tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AlatData.harga = Convert.ToDecimal(txtHargaBaru.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBatal_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}