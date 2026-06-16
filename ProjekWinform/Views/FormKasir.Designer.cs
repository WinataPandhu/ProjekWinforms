namespace ProjekWinform
{
    partial class FormKasir
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
            pictureBox1 = new PictureBox();
            BtnPesanan = new Button();
            LabelKasir = new Label();
            BtnRiwayat = new Button();
            BtnExit = new Button();
            lblShopName = new Label();
            dgStokProduk = new DataGridView();
            txtCari = new TextBox();
            btnCari = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgStokProduk).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(30, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 101);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnPesanan
            // 
            BtnPesanan.BackColor = Color.DarkGreen;
            BtnPesanan.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPesanan.ForeColor = SystemColors.ButtonHighlight;
            BtnPesanan.Location = new Point(-3, 177);
            BtnPesanan.Name = "BtnPesanan";
            BtnPesanan.Size = new Size(186, 95);
            BtnPesanan.TabIndex = 1;
            BtnPesanan.Text = "Buat Pesanan";
            BtnPesanan.UseVisualStyleBackColor = false;
            BtnPesanan.Click += BtnPesanan_Click;
            // 
            // LabelKasir
            // 
            LabelKasir.AutoSize = true;
            LabelKasir.BackColor = Color.Transparent;
            LabelKasir.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelKasir.ForeColor = SystemColors.ButtonHighlight;
            LabelKasir.Location = new Point(222, 26);
            LabelKasir.Name = "LabelKasir";
            LabelKasir.Size = new Size(272, 46);
            LabelKasir.TabIndex = 3;
            LabelKasir.Text = "Selamat Datang";
            // 
            // BtnRiwayat
            // 
            BtnRiwayat.BackColor = Color.LimeGreen;
            BtnRiwayat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRiwayat.ForeColor = Color.Snow;
            BtnRiwayat.Location = new Point(-3, 278);
            BtnRiwayat.Name = "BtnRiwayat";
            BtnRiwayat.Size = new Size(186, 85);
            BtnRiwayat.TabIndex = 4;
            BtnRiwayat.Text = "Riwayat Transaksi";
            BtnRiwayat.UseVisualStyleBackColor = false;
            BtnRiwayat.Click += BtnRiwayat_Click;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.Red;
            BtnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExit.ForeColor = SystemColors.ControlLightLight;
            BtnExit.Location = new Point(12, 403);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(127, 44);
            BtnExit.TabIndex = 5;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // lblShopName
            // 
            lblShopName.BackColor = Color.Transparent;
            lblShopName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblShopName.ForeColor = Color.White;
            lblShopName.Location = new Point(-3, 130);
            lblShopName.Name = "lblShopName";
            lblShopName.Size = new Size(200, 35);
            lblShopName.TabIndex = 9;
            lblShopName.Text = "Toko Pertanian";
            lblShopName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgStokProduk
            // 
            dgStokProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStokProduk.Location = new Point(189, 130);
            dgStokProduk.Name = "dgStokProduk";
            dgStokProduk.RowHeadersWidth = 51;
            dgStokProduk.Size = new Size(513, 308);
            dgStokProduk.TabIndex = 10;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(189, 97);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(411, 27);
            txtCari.TabIndex = 11;
            txtCari.TextChanged += txtCari_TextChanged;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(606, 95);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(96, 29);
            btnCari.TabIndex = 12;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // FormKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 450);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Controls.Add(dgStokProduk);
            Controls.Add(lblShopName);
            Controls.Add(BtnExit);
            Controls.Add(BtnRiwayat);
            Controls.Add(LabelKasir);
            Controls.Add(BtnPesanan);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "FormKasir";
            Text = "FormKasir";
            Load += FormKasir_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgStokProduk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnPesanan;
        private Label LabelKasir;
        private Button BtnRiwayat;
        private Button BtnExit;
        private Label lblShopName;
        private DataGridView dgStokProduk;
        private TextBox txtCari;
        private Button btnCari;
    }
}