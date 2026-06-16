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
            BtnExit = new Button();
            DgProduk = new DataGridView();
            BtnEdit = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgProduk).BeginInit();
            SuspendLayout();
            // 
            // BtnTambah
            // 
            BtnTambah.BackColor = Color.Green;
            BtnTambah.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnTambah.ForeColor = SystemColors.ButtonHighlight;
            BtnTambah.Location = new Point(-1, 79);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(200, 54);
            BtnTambah.TabIndex = 0;
            BtnTambah.Text = "Tambahkan Produk";
            BtnTambah.UseVisualStyleBackColor = false;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // BtnRestok
            // 
            BtnRestok.BackColor = Color.Green;
            BtnRestok.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRestok.ForeColor = SystemColors.ButtonHighlight;
            BtnRestok.Location = new Point(-1, 199);
            BtnRestok.Name = "BtnRestok";
            BtnRestok.Size = new Size(200, 54);
            BtnRestok.TabIndex = 1;
            BtnRestok.Text = "Restok Produk";
            BtnRestok.UseVisualStyleBackColor = false;
            BtnRestok.Click += BtnRestok_Click;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.Red;
            BtnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExit.ForeColor = SystemColors.ButtonHighlight;
            BtnExit.Location = new Point(12, 398);
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
            DgProduk.Location = new Point(205, 9);
            DgProduk.Name = "DgProduk";
            DgProduk.RowHeadersWidth = 51;
            DgProduk.Size = new Size(593, 445);
            DgProduk.TabIndex = 4;
            DgProduk.CellContentClick += DgProduk_CellContentClick;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.FromArgb(0, 192, 0);
            BtnEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEdit.ForeColor = SystemColors.ButtonHighlight;
            BtnEdit.Location = new Point(-1, 139);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(200, 54);
            BtnEdit.TabIndex = 5;
            BtnEdit.Text = "Edit Produk";
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, 22);
            label1.Name = "label1";
            label1.Size = new Size(199, 31);
            label1.TabIndex = 6;
            label1.Text = "KELOLA PRODUK";
            // 
            // KelolaProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(BtnEdit);
            Controls.Add(DgProduk);
            Controls.Add(BtnExit);
            Controls.Add(BtnRestok);
            Controls.Add(BtnTambah);
            Name = "KelolaProduk";
            Text = "KelolaProduk";
            ((System.ComponentModel.ISupportInitialize)DgProduk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnTambah;
        private Button BtnRestok;
        private Button BtnExit;
        private DataGridView DgProduk;
        private Button BtnEdit;
        private Label label1;
    }
}