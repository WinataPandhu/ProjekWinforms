namespace ProjekWinform.Views
{
    partial class FormStokProduk
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
            txtCari = new TextBox();
            btnCari = new Button();
            dgStokProduk = new DataGridView();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgStokProduk).BeginInit();
            SuspendLayout();
            // 
            // txtCari
            // 
            txtCari.Location = new Point(12, 12);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(647, 27);
            txtCari.TabIndex = 0;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(681, 10);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(96, 29);
            btnCari.TabIndex = 1;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            // 
            // dgStokProduk
            // 
            dgStokProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStokProduk.Location = new Point(12, 45);
            dgStokProduk.Name = "dgStokProduk";
            dgStokProduk.RowHeadersWidth = 51;
            dgStokProduk.Size = new Size(647, 372);
            dgStokProduk.TabIndex = 2;
            dgStokProduk.CellContentClick += dgStokProduk_CellContentClick;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(681, 397);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 41);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FormStokProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(dgStokProduk);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Name = "FormStokProduk";
            Text = "FormStokProduk";
            Load += FormStokProduk_Load;
            ((System.ComponentModel.ISupportInitialize)dgStokProduk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCari;
        private Button btnCari;
        private DataGridView dgStokProduk;
        private Button btnExit;
    }
}