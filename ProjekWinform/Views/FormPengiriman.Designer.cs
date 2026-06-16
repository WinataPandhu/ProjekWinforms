namespace ProjekWinform
{
    partial class FormPengiriman
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
            btnExit = new Button();
            btnStatus = new Button();
            label2 = new Label();
            lblNama = new Label();
            lblNoHp = new Label();
            lblAlamat = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(28, 390);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 35);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnStatus
            // 
            btnStatus.BackColor = Color.FromArgb(192, 192, 0);
            btnStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatus.ForeColor = Color.White;
            btnStatus.Location = new Point(1, 114);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(212, 73);
            btnStatus.TabIndex = 1;
            btnStatus.Text = "Ubah Status";
            btnStatus.UseVisualStyleBackColor = false;
            btnStatus.Click += btnStatus_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 41);
            label2.Name = "label2";
            label2.Size = new Size(203, 31);
            label2.TabIndex = 6;
            label2.Text = "ANTAR PESANAN";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(314, 114);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(172, 28);
            lblNama.TabIndex = 7;
            lblNama.Text = "Nama Pelanggan";
            // 
            // lblNoHp
            // 
            lblNoHp.AutoSize = true;
            lblNoHp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoHp.Location = new Point(314, 170);
            lblNoHp.Name = "lblNoHp";
            lblNoHp.Size = new Size(73, 28);
            lblNoHp.TabIndex = 8;
            lblNoHp.Text = "No HP";
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlamat.Location = new Point(314, 232);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(150, 28);
            lblAlamat.TabIndex = 9;
            lblAlamat.Text = "Alamat Tujuan";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(314, 289);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(71, 28);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status";
            // 
            // FormPengiriman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(lblAlamat);
            Controls.Add(lblNoHp);
            Controls.Add(lblNama);
            Controls.Add(label2);
            Controls.Add(btnStatus);
            Controls.Add(btnExit);
            Name = "FormPengiriman";
            Text = "FormPengiriman";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnStatus;
        private Label label2;
        private Label lblNama;
        private Label lblNoHp;
        private Label lblAlamat;
        private Label lblStatus;
    }
}