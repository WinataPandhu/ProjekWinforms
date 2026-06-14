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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKurir));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            BtnAntar = new Button();
            BtnExit = new Button();
            BtnRiwayat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(272, 46);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(251, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(503, 328);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BtnAntar
            // 
            BtnAntar.BackColor = Color.Orange;
            BtnAntar.BackgroundImage = (Image)resources.GetObject("BtnAntar.BackgroundImage");
            BtnAntar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnAntar.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAntar.ForeColor = SystemColors.ButtonHighlight;
            BtnAntar.Location = new Point(251, 110);
            BtnAntar.Name = "BtnAntar";
            BtnAntar.Size = new Size(260, 266);
            BtnAntar.TabIndex = 2;
            BtnAntar.Text = "Antar Pesanan";
            BtnAntar.UseVisualStyleBackColor = false;
            BtnAntar.Click += BtnAntar_Click;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.Red;
            BtnExit.BackgroundImage = (Image)resources.GetObject("BtnExit.BackgroundImage");
            BtnExit.BackgroundImageLayout = ImageLayout.Stretch;
            BtnExit.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExit.ForeColor = SystemColors.ButtonHighlight;
            BtnExit.Location = new Point(251, 371);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(503, 67);
            BtnExit.TabIndex = 7;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnRiwayat
            // 
            BtnRiwayat.BackColor = Color.FromArgb(192, 192, 0);
            BtnRiwayat.BackgroundImage = (Image)resources.GetObject("BtnRiwayat.BackgroundImage");
            BtnRiwayat.BackgroundImageLayout = ImageLayout.Stretch;
            BtnRiwayat.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRiwayat.ForeColor = SystemColors.ButtonHighlight;
            BtnRiwayat.Location = new Point(507, 110);
            BtnRiwayat.Name = "BtnRiwayat";
            BtnRiwayat.Size = new Size(247, 266);
            BtnRiwayat.TabIndex = 6;
            BtnRiwayat.Text = "Riwayat Pengiriman";
            BtnRiwayat.UseVisualStyleBackColor = false;
            BtnRiwayat.Click += BtnRiwayat_Click;
            // 
            // FormKurir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnExit);
            Controls.Add(BtnRiwayat);
            Controls.Add(BtnAntar);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "FormKurir";
            Text = "FormKurir";
            Load += FormKurir_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button BtnAntar;
        private Button BtnExit;
        private Button BtnRiwayat;
    }
}