namespace ProjekWinform
{
    partial class FormBuatPesanan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgPesanan = new DataGridView();
            dgList = new DataGridView();
            label1 = new Label();
            txtNama = new TextBox();
            txtNohp = new TextBox();
            txtAlamat = new TextBox();
            dtpTanggalbeli = new DateTimePicker();
            comboBoxbarang = new ComboBox();
            nudJumlahbeli = new NumericUpDown();
            buttonTambah = new Button();
            comboBoxPengambilan = new ComboBox();
            comboBoxBayar = new ComboBox();
            txtCari = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnSimpanPesanan = new Button();
            btnExit = new Button();
            lblKembalian = new Label();
            label7 = new Label();
            txtTotalHarga = new Label();
            btnHapus = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPesanan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudJumlahbeli).BeginInit();
            SuspendLayout();
            // 
            // dgPesanan
            // 
            dgPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPesanan.Location = new Point(458, 12);
            dgPesanan.Name = "dgPesanan";
            dgPesanan.RowHeadersWidth = 51;
            dgPesanan.Size = new Size(330, 188);
            dgPesanan.TabIndex = 0;
            dgPesanan.CellContentClick += dgPesanan_CellContentClick;
            // 
            // dgList
            // 
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgList.Location = new Point(22, 257);
            dgList.Name = "dgList";
            dgList.RowHeadersWidth = 51;
            dgList.Size = new Size(396, 150);
            dgList.TabIndex = 1;
            dgList.CellClick += dgList_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 2;
            label1.Text = "Nama Pelanggan";
            label1.Click += label1_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(22, 40);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(161, 27);
            txtNama.TabIndex = 12;
            // 
            // txtNohp
            // 
            txtNohp.Location = new Point(22, 101);
            txtNohp.Name = "txtNohp";
            txtNohp.Size = new Size(161, 27);
            txtNohp.TabIndex = 13;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(22, 162);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(161, 27);
            txtAlamat.TabIndex = 14;
            // 
            // dtpTanggalbeli
            // 
            dtpTanggalbeli.Location = new Point(22, 224);
            dtpTanggalbeli.Name = "dtpTanggalbeli";
            dtpTanggalbeli.Size = new Size(250, 27);
            dtpTanggalbeli.TabIndex = 15;
            // 
            // comboBoxbarang
            // 
            comboBoxbarang.FormattingEnabled = true;
            comboBoxbarang.Location = new Point(290, 41);
            comboBoxbarang.Name = "comboBoxbarang";
            comboBoxbarang.Size = new Size(151, 28);
            comboBoxbarang.TabIndex = 16;
            // 
            // nudJumlahbeli
            // 
            nudJumlahbeli.Location = new Point(290, 102);
            nudJumlahbeli.Name = "nudJumlahbeli";
            nudJumlahbeli.Size = new Size(150, 27);
            nudJumlahbeli.TabIndex = 17;
            // 
            // buttonTambah
            // 
            buttonTambah.Location = new Point(315, 135);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(94, 29);
            buttonTambah.TabIndex = 18;
            buttonTambah.Text = "Tambah";
            buttonTambah.UseVisualStyleBackColor = true;
            buttonTambah.Click += buttonTambah_Click;
            // 
            // comboBoxPengambilan
            // 
            comboBoxPengambilan.FormattingEnabled = true;
            comboBoxPengambilan.Location = new Point(458, 277);
            comboBoxPengambilan.Name = "comboBoxPengambilan";
            comboBoxPengambilan.Size = new Size(151, 28);
            comboBoxPengambilan.TabIndex = 19;
            comboBoxPengambilan.SelectedIndexChanged += comboBoxPengambilan_SelectedIndexChanged_1;
            // 
            // comboBoxBayar
            // 
            comboBoxBayar.FormattingEnabled = true;
            comboBoxBayar.Location = new Point(458, 339);
            comboBoxBayar.Name = "comboBoxBayar";
            comboBoxBayar.Size = new Size(151, 28);
            comboBoxBayar.TabIndex = 20;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(22, 413);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(125, 27);
            txtCari.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 70);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 23;
            label2.Text = "No Hp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 131);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 24;
            label3.Text = "Alamat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 193);
            label4.Name = "label4";
            label4.Size = new Size(86, 28);
            label4.TabIndex = 25;
            label4.Text = "Tanggal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(291, 9);
            label5.Name = "label5";
            label5.Size = new Size(79, 28);
            label5.TabIndex = 26;
            label5.Text = "Barang";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(291, 70);
            label6.Name = "label6";
            label6.Size = new Size(80, 28);
            label6.TabIndex = 27;
            label6.Text = "Jumlah";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(458, 246);
            label8.Name = "label8";
            label8.Size = new Size(134, 28);
            label8.TabIndex = 28;
            label8.Text = "Pengambilan";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(458, 308);
            label9.Name = "label9";
            label9.Size = new Size(128, 28);
            label9.TabIndex = 29;
            label9.Text = "Pembayaran";
            // 
            // btnSimpanPesanan
            // 
            btnSimpanPesanan.BackColor = Color.FromArgb(0, 192, 0);
            btnSimpanPesanan.Location = new Point(644, 339);
            btnSimpanPesanan.Name = "btnSimpanPesanan";
            btnSimpanPesanan.Size = new Size(144, 47);
            btnSimpanPesanan.TabIndex = 31;
            btnSimpanPesanan.Text = "Simpan Pesanan";
            btnSimpanPesanan.UseVisualStyleBackColor = false;
            btnSimpanPesanan.Click += btnSimpanPesanan_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Location = new Point(644, 403);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(144, 47);
            btnExit.TabIndex = 32;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblKembalian
            // 
            lblKembalian.AutoSize = true;
            lblKembalian.Location = new Point(351, 352);
            lblKembalian.Name = "lblKembalian";
            lblKembalian.Size = new Size(42, 20);
            lblKembalian.TabIndex = 33;
            lblKembalian.Text = "Hasil";
            lblKembalian.Click += lblKembalian_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(575, 203);
            label7.Name = "label7";
            label7.Size = new Size(70, 28);
            label7.TabIndex = 34;
            label7.Text = "Total :";
            // 
            // txtTotalHarga
            // 
            txtTotalHarga.AutoSize = true;
            txtTotalHarga.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalHarga.Location = new Point(651, 203);
            txtTotalHarga.Name = "txtTotalHarga";
            txtTotalHarga.Size = new Size(0, 28);
            txtTotalHarga.TabIndex = 35;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(644, 277);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(144, 40);
            btnHapus.TabIndex = 36;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // FormBuatPesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHapus);
            Controls.Add(txtTotalHarga);
            Controls.Add(label7);
            Controls.Add(dgList);
            Controls.Add(lblKembalian);
            Controls.Add(btnExit);
            Controls.Add(btnSimpanPesanan);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCari);
            Controls.Add(comboBoxBayar);
            Controls.Add(comboBoxPengambilan);
            Controls.Add(buttonTambah);
            Controls.Add(nudJumlahbeli);
            Controls.Add(comboBoxbarang);
            Controls.Add(dtpTanggalbeli);
            Controls.Add(txtAlamat);
            Controls.Add(txtNohp);
            Controls.Add(txtNama);
            Controls.Add(label1);
            Controls.Add(dgPesanan);
            Name = "FormBuatPesanan";
            Text = "FormBuatPesanan";
            Load += FormBuatPesanan_Load;
            ((System.ComponentModel.ISupportInitialize)dgPesanan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudJumlahbeli).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgPesanan;
        private DataGridView dgList;
        private Label label1;
        private TextBox txtNama;
        private TextBox txtNohp;
        private TextBox txtAlamat;
        private DateTimePicker dtpTanggalbeli;
        private ComboBox comboBoxbarang;
        private NumericUpDown nudJumlahbeli;
        private Button buttonTambah;
        private ComboBox comboBoxPengambilan;
        private ComboBox comboBoxBayar;
        private TextBox txtCari;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Button btnSimpanPesanan;
        private Button btnExit;
        private Label lblKembalian;
        private Label label7;
        private Label txtTotalHarga;
        private Button btnHapus;
    }
}