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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            LabelAdmin = new Label();
            pictureBox1 = new PictureBox();
            BtnAkun = new Button();
            BtnData = new Button();
            BtnKelola = new Button();
            BtnRiwayat = new Button();
            BtnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LabelAdmin
            // 
            LabelAdmin.AutoSize = true;
            LabelAdmin.BackColor = Color.Transparent;
            LabelAdmin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelAdmin.ForeColor = SystemColors.ActiveCaptionText;
            LabelAdmin.Location = new Point(12, 9);
            LabelAdmin.Name = "LabelAdmin";
            LabelAdmin.Size = new Size(242, 41);
            LabelAdmin.TabIndex = 0;
            LabelAdmin.Text = "Selamat Datang";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(243, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(519, 355);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BtnAkun
            // 
            BtnAkun.BackColor = Color.LightSeaGreen;
            BtnAkun.BackgroundImage = (Image)resources.GetObject("BtnAkun.BackgroundImage");
            BtnAkun.BackgroundImageLayout = ImageLayout.Stretch;
            BtnAkun.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAkun.ForeColor = SystemColors.ButtonHighlight;
            BtnAkun.Location = new Point(243, 72);
            BtnAkun.Name = "BtnAkun";
            BtnAkun.Size = new Size(260, 152);
            BtnAkun.TabIndex = 2;
            BtnAkun.Text = "Manage Akun";
            BtnAkun.UseVisualStyleBackColor = false;
            BtnAkun.Click += BtnAkun_Click;
            // 
            // BtnData
            // 
            BtnData.BackColor = Color.MediumTurquoise;
            BtnData.BackgroundImage = (Image)resources.GetObject("BtnData.BackgroundImage");
            BtnData.BackgroundImageLayout = ImageLayout.Stretch;
            BtnData.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnData.ForeColor = SystemColors.ButtonHighlight;
            BtnData.Location = new Point(502, 72);
            BtnData.Name = "BtnData";
            BtnData.Size = new Size(260, 152);
            BtnData.TabIndex = 3;
            BtnData.Text = "Manage Data";
            BtnData.UseVisualStyleBackColor = false;
            BtnData.Click += BtnData_Click;
            // 
            // BtnKelola
            // 
            BtnKelola.BackColor = Color.OliveDrab;
            BtnKelola.BackgroundImage = (Image)resources.GetObject("BtnKelola.BackgroundImage");
            BtnKelola.BackgroundImageLayout = ImageLayout.Stretch;
            BtnKelola.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnKelola.ForeColor = SystemColors.ButtonHighlight;
            BtnKelola.Location = new Point(243, 220);
            BtnKelola.Name = "BtnKelola";
            BtnKelola.Size = new Size(260, 152);
            BtnKelola.TabIndex = 4;
            BtnKelola.Text = "Kelola Produk";
            BtnKelola.UseVisualStyleBackColor = false;
            BtnKelola.Click += BtnKelola_Click;
            // 
            // BtnRiwayat
            // 
            BtnRiwayat.BackColor = Color.YellowGreen;
            BtnRiwayat.BackgroundImage = (Image)resources.GetObject("BtnRiwayat.BackgroundImage");
            BtnRiwayat.BackgroundImageLayout = ImageLayout.Stretch;
            BtnRiwayat.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRiwayat.ForeColor = SystemColors.ButtonHighlight;
            BtnRiwayat.Location = new Point(502, 220);
            BtnRiwayat.Name = "BtnRiwayat";
            BtnRiwayat.Size = new Size(260, 152);
            BtnRiwayat.TabIndex = 5;
            BtnRiwayat.Text = "Riwayat Keuangan";
            BtnRiwayat.UseVisualStyleBackColor = false;
            BtnRiwayat.Click += BtnRiwayat_Click;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.Red;
            BtnExit.BackgroundImage = (Image)resources.GetObject("BtnExit.BackgroundImage");
            BtnExit.BackgroundImageLayout = ImageLayout.Stretch;
            BtnExit.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExit.ForeColor = SystemColors.ButtonHighlight;
            BtnExit.Location = new Point(243, 370);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(519, 57);
            BtnExit.TabIndex = 6;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnExit);
            Controls.Add(BtnRiwayat);
            Controls.Add(BtnKelola);
            Controls.Add(BtnData);
            Controls.Add(BtnAkun);
            Controls.Add(pictureBox1);
            Controls.Add(LabelAdmin);
            DoubleBuffered = true;
            Name = "FormAdmin";
            Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}