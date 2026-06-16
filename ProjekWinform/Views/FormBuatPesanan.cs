using ProjekWinform.Controllers;
using ProjekWinform.Models; // Tambahkan namespace model agar bisa mengenali kelas AlatPertanian dll
using System;
using System.Collections.Generic; // Untuk List<>
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
            // 1. Sinkronisasi Data ComboBox (Menggunakan List Objek)
            comboBoxbarang.DataSource = controller.LoadBarang();
            comboBoxbarang.DisplayMember = "nama_alat";
            comboBoxbarang.ValueMember = "id_alat";

            comboBoxPengambilan.DataSource = controller.LoadPengambilan();
            comboBoxPengambilan.DisplayMember = "nama_pengambilan";
            comboBoxPengambilan.ValueMember = "id_pengambilan";

            comboBoxBayar.DataSource = controller.LoadPembayaran();
            comboBoxBayar.DisplayMember = "nama_metode";
            comboBoxBayar.ValueMember = "id_pembayaran";

            // Muat data Katalog AlatPertanian ke dgList
            LoadKatalog();

            // 2. Inisialisasi dgPesanan (Keranjang Belanja) Tetap Unbound / Manual Kolom
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
            // Perubahan Utama: DataSource menerima List<AlatPertanian> dari controller
            List<AlatPertanian> katalog = controller.LoadKatalogBarang(keyword);
            dgList.DataSource = katalog;

            // Atur penataan judul kolom berdasarkan properti Model AlatPertanian
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
                // Bagian ini sensitif huruf besar-kecil (Case-Sensitive), pastikan nama kolom match dengan saat penambahan .Add("total", ...)
                if (row.Cells["total"].Value != null)
                    total += Convert.ToInt64(row.Cells["total"].Value);
            }
            txtTotalHarga.Text = total.ToString("N0");
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxbarang.SelectedValue == null)
                {
                    MessageBox.Show("Pilih barang");
                    return;
                }

                int idAlat = Convert.ToInt32(comboBoxbarang.SelectedValue);
                string namaBarang = comboBoxbarang.Text;
                int jumlah = (int)nudJumlahbeli.Value;

                if (jumlah <= 0)
                {
                    MessageBox.Show("Jumlah harus lebih dari 0");
                    return;
                }

                decimal harga = controller.GetHargaAlat(idAlat);
                bool barangSudahAda = false;

                foreach (DataGridViewRow row in dgPesanan.Rows)
                {
                    if (row.IsNewRow) continue;
                    // Menggunakan indeks indeks 0 demi keamanan struktural dgPesanan
                    if (row.Cells[0].Value != null && Convert.ToInt32(row.Cells[0].Value) == idAlat)
                    {
                        int jumlahBaru = Convert.ToInt32(row.Cells[2].Value) + jumlah;
                        row.Cells[2].Value = jumlahBaru;
                        row.Cells[4].Value = harga * jumlahBaru;
                        barangSudahAda = true;
                        break;
                    }
                }

                if (!barangSudahAda)
                    dgPesanan.Rows.Add(idAlat, namaBarang, jumlah, harga, harga * jumlah);

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
                // Perubahan Esensial: Konversi baris terpilih langsung kembali menjadi objek utuh AlatPertanian!
                // Ini menghilangkan ketergantungan nama kolom string yang rawan typo.
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

        // Event-event kosong bawaan desainer tetap dipertahankan agar tidak memicu error *Missing Event Link* di partial class desainer.
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