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
            txtCari = new TextBox();
            btnCari = new Button();
            ((System.ComponentModel.ISupportInitialize)DgRiwayat).BeginInit();
            SuspendLayout();
            // 
            // DgRiwayat
            // 
            DgRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgRiwayat.Location = new Point(2, 47);
            DgRiwayat.Name = "DgRiwayat";
            DgRiwayat.RowHeadersWidth = 51;
            DgRiwayat.Size = new Size(798, 265);
            DgRiwayat.TabIndex = 0;
            // 
            // btnRiwayatRestok
            // 
            btnRiwayatRestok.BackColor = Color.MidnightBlue;
            btnRiwayatRestok.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatRestok.ForeColor = SystemColors.ButtonHighlight;
            btnRiwayatRestok.Location = new Point(137, 318);
            btnRiwayatRestok.Name = "btnRiwayatRestok";
            btnRiwayatRestok.Size = new Size(190, 132);
            btnRiwayatRestok.TabIndex = 1;
            btnRiwayatRestok.Text = "Riwayat Restok";
            btnRiwayatRestok.UseVisualStyleBackColor = false;
            btnRiwayatRestok.Click += btnRiwayatRestok_Click;
            // 
            // btnRiwayatTransaksi
            // 
            btnRiwayatTransaksi.BackColor = Color.Green;
            btnRiwayatTransaksi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatTransaksi.ForeColor = SystemColors.ButtonHighlight;
            btnRiwayatTransaksi.Location = new Point(431, 318);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Size = new Size(190, 132);
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
            btnExit.Location = new Point(669, 388);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(119, 50);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(12, 14);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(651, 27);
            txtCari.TabIndex = 4;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(0, 192, 0);
            btnCari.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCari.ForeColor = SystemColors.ButtonHighlight;
            btnCari.Location = new Point(669, 12);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(108, 29);
            btnCari.TabIndex = 5;
            btnCari.Text = "Search";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            // 
            // FormRiwayat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Controls.Add(btnExit);
            Controls.Add(btnRiwayatTransaksi);
            Controls.Add(btnRiwayatRestok);
            Controls.Add(DgRiwayat);
            Name = "FormRiwayat";
            Text = "FormRiwayat";
            ((System.ComponentModel.ISupportInitialize)DgRiwayat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgRiwayat;
        private Button btnRiwayatRestok;
        private Button btnRiwayatTransaksi;
        private Button btnExit;
        private TextBox txtCari;
        private Button btnCari;
    }
}