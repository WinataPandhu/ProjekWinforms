namespace ProjekWinform
{
    partial class FormRiwayat
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
            DgRiwayat = new DataGridView();
            btnRiwayatRestok = new Button();
            btnRiwayatTransaksi = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)DgRiwayat).BeginInit();
            SuspendLayout();
            // 
            // DgRiwayat
            // 
            DgRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgRiwayat.Location = new Point(12, 12);
            DgRiwayat.Name = "DgRiwayat";
            DgRiwayat.RowHeadersWidth = 51;
            DgRiwayat.Size = new Size(589, 437);
            DgRiwayat.TabIndex = 0;
            // 
            // btnRiwayatRestok
            // 
            btnRiwayatRestok.BackColor = Color.Blue;
            btnRiwayatRestok.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatRestok.ForeColor = SystemColors.ButtonHighlight;
            btnRiwayatRestok.Location = new Point(607, 49);
            btnRiwayatRestok.Name = "btnRiwayatRestok";
            btnRiwayatRestok.Size = new Size(190, 76);
            btnRiwayatRestok.TabIndex = 1;
            btnRiwayatRestok.Text = "Riwayat Restok";
            btnRiwayatRestok.UseVisualStyleBackColor = false;
            btnRiwayatRestok.Click += btnRiwayatRestok_Click;
            // 
            // btnRiwayatTransaksi
            // 
            btnRiwayatTransaksi.BackColor = Color.LimeGreen;
            btnRiwayatTransaksi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatTransaksi.ForeColor = SystemColors.ButtonHighlight;
            btnRiwayatTransaksi.Location = new Point(607, 171);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Size = new Size(190, 76);
            btnRiwayatTransaksi.TabIndex = 2;
            btnRiwayatTransaksi.Text = "Riwayat Transaksi";
            btnRiwayatTransaksi.UseVisualStyleBackColor = false;
            btnRiwayatTransaksi.Click += btnRiwayatTransaksi_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(639, 388);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(119, 50);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FormRiwayat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnRiwayatTransaksi);
            Controls.Add(btnRiwayatRestok);
            Controls.Add(DgRiwayat);
            Name = "FormRiwayat";
            Text = "FormRiwayat";
            ((System.ComponentModel.ISupportInitialize)DgRiwayat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgRiwayat;
        private Button btnRiwayatRestok;
        private Button btnRiwayatTransaksi;
        private Button btnExit;
    }
}