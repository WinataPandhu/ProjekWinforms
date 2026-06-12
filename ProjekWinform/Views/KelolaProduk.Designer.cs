namespace ProjekWinform
{
    partial class KelolaProduk
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
            BtnTambah = new Button();
            BtnRestok = new Button();
            BtnHarga = new Button();
            BtnExit = new Button();
            DgProduk = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgProduk).BeginInit();
            SuspendLayout();
            // 
            // BtnTambah
            // 
            BtnTambah.BackColor = Color.Green;
            BtnTambah.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnTambah.ForeColor = SystemColors.ButtonHighlight;
            BtnTambah.Location = new Point(-1, 333);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(243, 54);
            BtnTambah.TabIndex = 0;
            BtnTambah.Text = "Tambahkan Produk";
            BtnTambah.UseVisualStyleBackColor = false;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // BtnRestok
            // 
            BtnRestok.BackColor = Color.FromArgb(192, 64, 0);
            BtnRestok.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRestok.ForeColor = SystemColors.ButtonHighlight;
            BtnRestok.Location = new Point(275, 333);
            BtnRestok.Name = "BtnRestok";
            BtnRestok.Size = new Size(243, 54);
            BtnRestok.TabIndex = 1;
            BtnRestok.Text = "Restok Produk";
            BtnRestok.UseVisualStyleBackColor = false;
            BtnRestok.Click += BtnRestok_Click;
            // 
            // BtnHarga
            // 
            BtnHarga.BackColor = Color.Olive;
            BtnHarga.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnHarga.ForeColor = SystemColors.ButtonHighlight;
            BtnHarga.Location = new Point(555, 333);
            BtnHarga.Name = "BtnHarga";
            BtnHarga.Size = new Size(243, 54);
            BtnHarga.TabIndex = 2;
            BtnHarga.Text = "Ubah Harga";
            BtnHarga.UseVisualStyleBackColor = false;
            BtnHarga.Click += BtnHarga_Click;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.Red;
            BtnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExit.ForeColor = SystemColors.ButtonHighlight;
            BtnExit.Location = new Point(672, 407);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(116, 40);
            BtnExit.TabIndex = 3;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // DgProduk
            // 
            DgProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduk.Location = new Point(-1, 2);
            DgProduk.Name = "DgProduk";
            DgProduk.RowHeadersWidth = 51;
            DgProduk.Size = new Size(799, 325);
            DgProduk.TabIndex = 4;
            DgProduk.CellContentClick += DgProduk_CellContentClick;
            // 
            // KelolaProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgProduk);
            Controls.Add(BtnExit);
            Controls.Add(BtnHarga);
            Controls.Add(BtnRestok);
            Controls.Add(BtnTambah);
            Name = "KelolaProduk";
            Text = "KelolaProduk";
            ((System.ComponentModel.ISupportInitialize)DgProduk).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnTambah;
        private Button BtnRestok;
        private Button BtnHarga;
        private Button BtnExit;
        private DataGridView DgProduk;
    }
}