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
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgRiwayat).BeginInit();
            SuspendLayout();
            // 
            // DgRiwayat
            // 
            DgRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgRiwayat.Location = new Point(180, 47);
            DgRiwayat.Name = "DgRiwayat";
            DgRiwayat.RowHeadersWidth = 51;
            DgRiwayat.Size = new Size(620, 391);
            DgRiwayat.TabIndex = 0;
            // 
            // btnRiwayatRestok
            // 
            btnRiwayatRestok.BackColor = Color.MidnightBlue;
            btnRiwayatRestok.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatRestok.ForeColor = SystemColors.ButtonHighlight;
            btnRiwayatRestok.Location = new Point(-1, 112);
            btnRiwayatRestok.Name = "btnRiwayatRestok";
            btnRiwayatRestok.Size = new Size(179, 132);
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
            btnRiwayatTransaksi.Location = new Point(-1, 250);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Size = new Size(179, 132);
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
            btnExit.Location = new Point(12, 388);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(119, 50);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(180, 14);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(483, 27);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(111, 31);
            label2.TabIndex = 6;
            label2.Text = "RIWAYAT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(141, 31);
            label1.TabIndex = 7;
            label1.Text = "KEUANGAN";
            // 
            // FormRiwayat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Controls.Add(btnExit);
            Controls.Add(btnRiwayatTransaksi);
            Controls.Add(btnRiwayatRestok);
            Controls.Add(DgRiwayat);
            Name = "FormRiwayat";
            Text = "FormRiwayat";
            Load += FormRiwayat_Load;
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
        private Label label2;
        private Label label1;
    }
}