namespace ProjekWinform
{
    partial class FormKurir
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            BtnAntar = new Button();
            BtnExit = new Button();
            BtnRiwayat = new Button();
            lblShopName = new Label();
            dgAntar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgAntar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(218, 12);
            label1.Name = "label1";
            label1.Size = new Size(272, 46);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 91);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BtnAntar
            // 
            BtnAntar.BackColor = Color.Orange;
            BtnAntar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAntar.ForeColor = SystemColors.ButtonHighlight;
            BtnAntar.Location = new Point(2, 181);
            BtnAntar.Name = "BtnAntar";
            BtnAntar.Size = new Size(200, 80);
            BtnAntar.TabIndex = 2;
            BtnAntar.Text = "Antar Pesanan";
            BtnAntar.UseVisualStyleBackColor = false;
            BtnAntar.Click += BtnAntar_Click;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.Red;
            BtnExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExit.ForeColor = SystemColors.ButtonHighlight;
            BtnExit.Location = new Point(12, 395);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(112, 43);
            BtnExit.TabIndex = 7;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnRiwayat
            // 
            BtnRiwayat.BackColor = Color.FromArgb(192, 192, 0);
            BtnRiwayat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRiwayat.ForeColor = SystemColors.ButtonHighlight;
            BtnRiwayat.Location = new Point(2, 267);
            BtnRiwayat.Name = "BtnRiwayat";
            BtnRiwayat.Size = new Size(200, 79);
            BtnRiwayat.TabIndex = 6;
            BtnRiwayat.Text = "Riwayat Pengiriman";
            BtnRiwayat.UseVisualStyleBackColor = false;
            BtnRiwayat.Click += BtnRiwayat_Click;
            // 
            // lblShopName
            // 
            lblShopName.BackColor = Color.Transparent;
            lblShopName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblShopName.ForeColor = Color.White;
            lblShopName.Location = new Point(12, 130);
            lblShopName.Name = "lblShopName";
            lblShopName.Size = new Size(190, 34);
            lblShopName.TabIndex = 9;
            lblShopName.Text = "Toko Pertanian";
            lblShopName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgAntar
            // 
            dgAntar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAntar.Location = new Point(218, 102);
            dgAntar.Name = "dgAntar";
            dgAntar.RowHeadersWidth = 51;
            dgAntar.Size = new Size(570, 336);
            dgAntar.TabIndex = 10;
            // 
            // FormKurir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgAntar);
            Controls.Add(lblShopName);
            Controls.Add(BtnExit);
            Controls.Add(BtnRiwayat);
            Controls.Add(BtnAntar);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "FormKurir";
            Text = "FormKurir";
            Load += FormKurir_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgAntar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button BtnAntar;
        private Button BtnExit;
        private Button BtnRiwayat;
        private Label lblShopName;
        private DataGridView dgAntar;
    }
}