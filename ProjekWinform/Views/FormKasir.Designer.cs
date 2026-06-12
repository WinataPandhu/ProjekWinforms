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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKasir));
            pictureBox1 = new PictureBox();
            BtnPesanan = new Button();
            BtnStok = new Button();
            LabelKasir = new Label();
            BtnRiwayat = new Button();
            BtnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(29, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(663, 358);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BtnPesanan
            // 
            BtnPesanan.BackColor = Color.DarkGreen;
            BtnPesanan.BackgroundImage = (Image)resources.GetObject("BtnPesanan.BackgroundImage");
            BtnPesanan.BackgroundImageLayout = ImageLayout.Stretch;
            BtnPesanan.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPesanan.ForeColor = SystemColors.ButtonHighlight;
            BtnPesanan.Location = new Point(29, 80);
            BtnPesanan.Name = "BtnPesanan";
            BtnPesanan.Size = new Size(358, 358);
            BtnPesanan.TabIndex = 1;
            BtnPesanan.Text = "Buat Pesanan";
            BtnPesanan.UseVisualStyleBackColor = false;
            BtnPesanan.Click += BtnPesanan_Click;
            // 
            // BtnStok
            // 
            BtnStok.BackColor = Color.MediumSeaGreen;
            BtnStok.BackgroundImage = (Image)resources.GetObject("BtnStok.BackgroundImage");
            BtnStok.BackgroundImageLayout = ImageLayout.Stretch;
            BtnStok.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnStok.ForeColor = SystemColors.ControlLightLight;
            BtnStok.Location = new Point(389, 80);
            BtnStok.Name = "BtnStok";
            BtnStok.Size = new Size(303, 149);
            BtnStok.TabIndex = 2;
            BtnStok.Text = "Stock Produk";
            BtnStok.UseVisualStyleBackColor = false;
            BtnStok.Click += BtnStok_Click;
            // 
            // LabelKasir
            // 
            LabelKasir.AutoSize = true;
            LabelKasir.BackColor = Color.Transparent;
            LabelKasir.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelKasir.ForeColor = SystemColors.ButtonHighlight;
            LabelKasir.Location = new Point(29, 20);
            LabelKasir.Name = "LabelKasir";
            LabelKasir.Size = new Size(272, 46);
            LabelKasir.TabIndex = 3;
            LabelKasir.Text = "Selamat Datang";
            // 
            // BtnRiwayat
            // 
            BtnRiwayat.BackColor = Color.LimeGreen;
            BtnRiwayat.BackgroundImage = (Image)resources.GetObject("BtnRiwayat.BackgroundImage");
            BtnRiwayat.BackgroundImageLayout = ImageLayout.Stretch;
            BtnRiwayat.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRiwayat.ForeColor = Color.Snow;
            BtnRiwayat.Location = new Point(389, 224);
            BtnRiwayat.Name = "BtnRiwayat";
            BtnRiwayat.Size = new Size(303, 134);
            BtnRiwayat.TabIndex = 4;
            BtnRiwayat.Text = "Riwayat Transaksi";
            BtnRiwayat.UseVisualStyleBackColor = false;
            BtnRiwayat.Click += BtnRiwayat_Click;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.Red;
            BtnExit.BackgroundImage = (Image)resources.GetObject("BtnExit.BackgroundImage");
            BtnExit.BackgroundImageLayout = ImageLayout.Stretch;
            BtnExit.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExit.ForeColor = SystemColors.ControlLightLight;
            BtnExit.Location = new Point(389, 355);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(303, 83);
            BtnExit.TabIndex = 5;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // FormKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(714, 450);
            Controls.Add(BtnExit);
            Controls.Add(BtnRiwayat);
            Controls.Add(LabelKasir);
            Controls.Add(BtnStok);
            Controls.Add(BtnPesanan);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "FormKasir";
            Text = "FormKasir";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnPesanan;
        private Button BtnStok;
        private Label LabelKasir;
        private Button BtnRiwayat;
        private Button BtnExit;
    }
}