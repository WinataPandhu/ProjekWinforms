namespace ProjekWinform.Views
{
    partial class FormRiwayatKasir
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
            btnCari = new Button();
            txtCari = new TextBox();
            dgRiwayat = new DataGridView();
            btnExit = new Button();
            lblShopName = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgRiwayat).BeginInit();
            SuspendLayout();
            // 
            // btnCari
            // 
            btnCari.Location = new Point(667, 18);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(121, 36);
            btnCari.TabIndex = 0;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(186, 23);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(475, 27);
            txtCari.TabIndex = 1;
            txtCari.TextChanged += txtCari_TextChanged;
            // 
            // dgRiwayat
            // 
            dgRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRiwayat.Location = new Point(186, 65);
            dgRiwayat.Name = "dgRiwayat";
            dgRiwayat.RowHeadersWidth = 51;
            dgRiwayat.Size = new Size(602, 373);
            dgRiwayat.TabIndex = 2;
            dgRiwayat.CellContentClick += dgRiwayat_CellContentClick;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 398);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(121, 40);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblShopName
            // 
            lblShopName.BackColor = Color.Transparent;
            lblShopName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblShopName.ForeColor = Color.White;
            lblShopName.Location = new Point(-22, 32);
            lblShopName.Name = "lblShopName";
            lblShopName.Size = new Size(183, 35);
            lblShopName.TabIndex = 9;
            lblShopName.Text = "RIWAYAT";
            lblShopName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 65);
            label1.Name = "label1";
            label1.Size = new Size(154, 35);
            label1.TabIndex = 10;
            label1.Text = "TRANSAKSI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormRiwayatKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblShopName);
            Controls.Add(btnExit);
            Controls.Add(dgRiwayat);
            Controls.Add(txtCari);
            Controls.Add(btnCari);
            Name = "FormRiwayatKasir";
            Text = "FormRiawayatKasir";
            Load += FormRiwayatKasir_Load;
            ((System.ComponentModel.ISupportInitialize)dgRiwayat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCari;
        private TextBox txtCari;
        private DataGridView dgRiwayat;
        private Button btnExit;
        private Label lblShopName;
        private Label label1;
    }
}