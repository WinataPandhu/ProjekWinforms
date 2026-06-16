namespace ProjekWinform
{
    partial class FormAdmin
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
            LabelAdmin = new Label();
            pictureBox1 = new PictureBox();
            BtnAkun = new Button();
            BtnData = new Button();
            BtnKelola = new Button();
            BtnRiwayat = new Button();
            BtnExit = new Button();
            panelSidebar = new Panel();
            lblShopName = new Label();
            lblSubtitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // LabelAdmin
            // 
            LabelAdmin.AutoSize = true;
            LabelAdmin.BackColor = Color.Transparent;
            LabelAdmin.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LabelAdmin.ForeColor = Color.FromArgb(34, 112, 63);
            LabelAdmin.Location = new Point(250, 30);
            LabelAdmin.Name = "LabelAdmin";
            LabelAdmin.Size = new Size(242, 41);
            LabelAdmin.TabIndex = 0;
            LabelAdmin.Text = "Selamat Datang";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(50, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BtnAkun
            // 
            BtnAkun.BackColor = Color.FromArgb(34, 112, 63);
            BtnAkun.Cursor = Cursors.Hand;
            BtnAkun.FlatAppearance.BorderSize = 0;
            BtnAkun.FlatStyle = FlatStyle.Flat;
            BtnAkun.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            BtnAkun.ForeColor = Color.White;
            BtnAkun.Location = new Point(250, 130);
            BtnAkun.Name = "BtnAkun";
            BtnAkun.Size = new Size(270, 150);
            BtnAkun.TabIndex = 2;
            BtnAkun.Text = "Manage Akun\n(User Login)";
            BtnAkun.UseVisualStyleBackColor = false;
            BtnAkun.Click += BtnAkun_Click;
            // 
            // BtnData
            // 
            BtnData.BackColor = Color.FromArgb(34, 112, 63);
            BtnData.Cursor = Cursors.Hand;
            BtnData.FlatAppearance.BorderSize = 0;
            BtnData.FlatStyle = FlatStyle.Flat;
            BtnData.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            BtnData.ForeColor = Color.White;
            BtnData.Location = new Point(550, 130);
            BtnData.Name = "BtnData";
            BtnData.Size = new Size(270, 150);
            BtnData.TabIndex = 3;
            BtnData.Text = "Manage Data\n(Profil Karyawan)";
            BtnData.UseVisualStyleBackColor = false;
            BtnData.Click += BtnData_Click;
            // 
            // BtnKelola
            // 
            BtnKelola.BackColor = Color.FromArgb(34, 112, 63);
            BtnKelola.Cursor = Cursors.Hand;
            BtnKelola.FlatAppearance.BorderSize = 0;
            BtnKelola.FlatStyle = FlatStyle.Flat;
            BtnKelola.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            BtnKelola.ForeColor = Color.White;
            BtnKelola.Location = new Point(250, 310);
            BtnKelola.Name = "BtnKelola";
            BtnKelola.Size = new Size(270, 150);
            BtnKelola.TabIndex = 4;
            BtnKelola.Text = "Kelola Produk\n(Stok & Restok)";
            BtnKelola.UseVisualStyleBackColor = false;
            BtnKelola.Click += BtnKelola_Click;
            // 
            // BtnRiwayat
            // 
            BtnRiwayat.BackColor = Color.FromArgb(34, 112, 63);
            BtnRiwayat.Cursor = Cursors.Hand;
            BtnRiwayat.FlatAppearance.BorderSize = 0;
            BtnRiwayat.FlatStyle = FlatStyle.Flat;
            BtnRiwayat.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            BtnRiwayat.ForeColor = Color.White;
            BtnRiwayat.Location = new Point(550, 310);
            BtnRiwayat.Name = "BtnRiwayat";
            BtnRiwayat.Size = new Size(270, 150);
            BtnRiwayat.TabIndex = 5;
            BtnRiwayat.Text = "Riwayat Keuangan\n(Transaksi & Restok)";
            BtnRiwayat.UseVisualStyleBackColor = false;
            BtnRiwayat.Click += BtnRiwayat_Click;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.FromArgb(220, 53, 69);
            BtnExit.Cursor = Cursors.Hand;
            BtnExit.FlatAppearance.BorderSize = 0;
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnExit.ForeColor = Color.White;
            BtnExit.Location = new Point(20, 450);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(180, 45);
            BtnExit.TabIndex = 6;
            BtnExit.Text = "Keluar Aplikasi";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(34, 112, 63);
            panelSidebar.Controls.Add(pictureBox1);
            panelSidebar.Controls.Add(lblShopName);
            panelSidebar.Controls.Add(BtnExit);
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 520);
            panelSidebar.TabIndex = 7;
            // 
            // lblShopName
            // 
            lblShopName.BackColor = Color.Transparent;
            lblShopName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblShopName.ForeColor = Color.White;
            lblShopName.Location = new Point(10, 165);
            lblShopName.Name = "lblShopName";
            lblShopName.Size = new Size(200, 35);
            lblShopName.TabIndex = 8;
            lblShopName.Text = "Toko Pertanian";
            lblShopName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(80, 100, 85);
            lblSubtitle.Location = new Point(250, 75);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(570, 25);
            lblSubtitle.TabIndex = 9;
            lblSubtitle.Text = "Silakan pilih menu di bawah untuk mengelola sistem";
            // 
            // FormAdmin
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(244, 248, 244);
            ClientSize = new Size(850, 520);
            Controls.Add(lblSubtitle);
            Controls.Add(panelSidebar);
            Controls.Add(BtnRiwayat);
            Controls.Add(BtnKelola);
            Controls.Add(BtnData);
            Controls.Add(BtnAkun);
            Controls.Add(LabelAdmin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Utama Admin - Toko Alat Pertanian";
            Load += FormAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelAdmin;
        private PictureBox pictureBox1;
        private Button BtnAkun;
        private Button BtnData;
        private Button BtnKelola;
        private Button BtnRiwayat;
        private Button BtnExit;
        private Panel panelSidebar;
        private Label lblShopName;
        private Label lblSubtitle;
    }
}