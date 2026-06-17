using ProjekWinform.Controllers;
using ProjekWinform.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjekWinform
{
    public partial class FormBuatPesanan : Form
    {
        private string username;
        private int id_user;
        c_pesanan controller = new c_pesanan();

        public FormBuatPesanan(string username, int id_user)
        {
            InitializeComponent();
            this.username = username;
            this.id_user = id_user;
            this.StartPosition = FormStartPosition.CenterScreen;
            ProjekWinform.Helpers.ThemeHelper.ApplyTheme(this);
        }

        private void FormBuatPesanan_Load(object sender, EventArgs e)
        {
            comboBoxbarang.DataSource = controller.LoadBarang();
            comboBoxbarang.DisplayMember = "nama_alat";
            comboBoxbarang.ValueMember = "id_alat";

            comboBoxPengambilan.DataSource = controller.LoadPengambilan();
            comboBoxPengambilan.DisplayMember = "nama_pengambilan";
            comboBoxPengambilan.ValueMember = "id_pengambilan";

            comboBoxBayar.DataSource = controller.LoadPembayaran();
            comboBoxBayar.DisplayMember = "nama_metode";
            comboBoxBayar.ValueMember = "id_pembayaran";

            LoadKatalog();

            dgPesanan.Columns.Clear();
            dgPesanan.Columns.Add("id", "ID");
            dgPesanan.Columns.Add("barang", "Barang");
            dgPesanan.Columns.Add("jumlah", "Jumlah");
            dgPesanan.Columns.Add("harga", "Harga");
            dgPesanan.Columns.Add("total", "Total");

            if (dgPesanan.Columns["id"] != null)
                dgPesanan.Columns["id"]!.Visible = false;
        }

        private void LoadKatalog(string keyword = "")
        {
            List<AlatPertanian> katalog = controller.LoadKatalogBarang(keyword);
            dgList.DataSource = katalog;

            if (dgList.Columns["id_alat"] != null) dgList.Columns["id_alat"]!.Visible = false;
            if (dgList.Columns["id_jenis"] != null) dgList.Columns["id_jenis"]!.Visible = false;

            if (dgList.Columns["nama_alat"] != null) dgList.Columns["nama_alat"]!.HeaderText = "Nama Alat";
            if (dgList.Columns["stok"] != null) dgList.Columns["stok"]!.HeaderText = "Stok";
            if (dgList.Columns["harga"] != null) dgList.Columns["harga"]!.HeaderText = "Harga";
            if (dgList.Columns["status_alat"] != null) dgList.Columns["status_alat"]!.HeaderText = "Status";
            if (dgList.Columns["nama_jenis"] != null) dgList.Columns["nama_jenis"]!.HeaderText = "Jenis Alat";
        }

        private void HitungTotalBelanjaan()
        {
            long total = 0;
            foreach (DataGridViewRow row in dgPesanan.Rows)
            {
                if (row.Cells["total"].Value != null)
                    total += Convert.ToInt64(row.Cells["total"].Value);
            }
            txtTotalHarga.Text = total.ToString("N0");
        }

        private int AmbilStokKatalog(int idAlat)
        {
            foreach (DataGridViewRow row in dgList.Rows)
            {
                if (row.DataBoundItem is AlatPertanian alat && alat.id_alat == idAlat)
                {
                    return alat.stok;
                }
            }
            return 0;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxbarang.SelectedValue == null)
                {
                    MessageBox.Show("Pilih barang", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idAlat = Convert.ToInt32(comboBoxbarang.SelectedValue);
                string namaBarang = comboBoxbarang.Text;
                int jumlahBeli = (int)nudJumlahbeli.Value;

                if (jumlahBeli <= 0)
                {
                    MessageBox.Show("Jumlah harus lebih dari 0", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int stokTersedia = AmbilStokKatalog(idAlat);

                int jumlahSudahAdaDiKeranjang = 0;
                DataGridViewRow existingRow = null;

                foreach (DataGridViewRow row in dgPesanan.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells[0].Value != null && Convert.ToInt32(row.Cells[0].Value) == idAlat)
                    {
                        jumlahSudahAdaDiKeranjang = Convert.ToInt32(row.Cells[2].Value);
                        existingRow = row;
                        break;
                    }
                }

                int totalPermintaan = jumlahSudahAdaDiKeranjang + jumlahBeli;

                if (totalPermintaan > stokTersedia)
                {
                    MessageBox.Show(
                        $"Stok tidak mencukupi!\nSisa stok tersedia: {stokTersedia}\nJumlah di keranjang: {jumlahSudahAdaDiKeranjang}\nPermintaan baru: {jumlahBeli}",
                        "Peringatan Stok Limit",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                decimal harga = controller.GetHargaAlat(idAlat);

                if (existingRow != null)
                {
                    existingRow.Cells[2].Value = totalPermintaan;
                    existingRow.Cells[4].Value = harga * totalPermintaan;
                }
                else
                {
                    dgPesanan.Rows.Add(idAlat, namaBarang, jumlahBeli, harga, harga * jumlahBeli);
                }

                HitungTotalBelanjaan();
                nudJumlahbeli.Value = 0;
                comboBoxbarang.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSimpanPesanan_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgPesanan.Rows.Count == 0 || (dgPesanan.Rows.Count == 1 && dgPesanan.Rows[0].IsNewRow))
                {
                    MessageBox.Show("Keranjang belanja masih kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (comboBoxPengambilan.SelectedValue == null || comboBoxBayar.SelectedValue == null)
                {
                    MessageBox.Show("Metode pengambilan dan pembayaran harus dipilih.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNama.Text))
                {
                    MessageBox.Show("Nama Pelanggan tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNama.Focus();
                    return;
                }

                if (comboBoxPengambilan.Text.Contains("Diantar"))
                {
                    if (string.IsNullOrWhiteSpace(txtNohp.Text))
                    {
                        MessageBox.Show("Untuk pengiriman diantar, Nomor HP wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNohp.Focus();
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txtAlamat.Text))
                    {
                        MessageBox.Show("Untuk pengiriman diantar, Alamat wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAlamat.Focus();
                        return;
                    }
                }

                foreach (DataGridViewRow row in dgPesanan.Rows)
                {
                    if (row.IsNewRow) continue;
                    int idAlat = Convert.ToInt32(row.Cells[0].Value);
                    int jumlahBeli = Convert.ToInt32(row.Cells[2].Value);
                    int stokTerbaruDatabase = AmbilStokKatalog(idAlat);

                    if (jumlahBeli > stokTerbaruDatabase)
                    {
                        string namaBarang = row.Cells[1].Value.ToString();
                        MessageBox.Show(
                            $"Gagal menyimpan! Stok untuk barang '{namaBarang}' tidak mencukupi.\nStok terkini: {stokTerbaruDatabase}",
                            "Kesalahan Stok",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return;
                    }
                }

                int idPelanggan = controller.SimpanPelanggan(txtNama.Text, txtNohp.Text, txtAlamat.Text);
                int idTransaksi = controller.SimpanTransaksi(
                    dtpTanggalbeli.Value,
                    id_user,
                    idPelanggan,
                    comboBoxPengambilan.SelectedValue,
                    comboBoxBayar.SelectedValue
                );

                foreach (DataGridViewRow row in dgPesanan.Rows)
                {
                    if (row.IsNewRow) continue;
                    controller.SimpanDetailTransaksi(
                        Convert.ToInt32(row.Cells[2].Value ?? 0),
                        Convert.ToDecimal(row.Cells[4].Value ?? 0),
                        Convert.ToDecimal(row.Cells[3].Value ?? 0),
                        idTransaksi,
                        Convert.ToInt32(row.Cells[0].Value ?? 0)
                    );
                }

                if (comboBoxPengambilan.Text.Contains("Diantar"))
                {
                    int idKurir = controller.GetIdUserKurir();
                    controller.SimpanPengiriman(idTransaksi, idKurir);
                }

                MessageBox.Show("Pesanan berhasil disimpan!");
                dgPesanan.Rows.Clear();
                txtNama.Clear();
                txtNohp.Clear();
                txtAlamat.Clear();
                txtTotalHarga.Text = "0";
                LoadKatalog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var alatTerpilih = (AlatPertanian)dgList.Rows[e.RowIndex].DataBoundItem;

                if (alatTerpilih != null)
                {
                    comboBoxbarang.SelectedValue = alatTerpilih.id_alat;
                    nudJumlahbeli.Focus();
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgPesanan.CurrentRow != null && !dgPesanan.CurrentRow.IsNewRow)
            {
                dgPesanan.Rows.Remove(dgPesanan.CurrentRow);
                HitungTotalBelanjaan();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormKasir kasir = new FormKasir(username);
            kasir.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void lblKembalian_Click(object sender, EventArgs e) { }
        private void comboBoxbarang_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBoxPengambilan_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBoxBayar_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dgPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void comboBoxPengambilan_SelectedIndexChanged_1(object sender, EventArgs e) { }
        private void dgList_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}