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
            ((System.ComponentModel.ISupportInitialize)dgRiwayat).BeginInit();
            SuspendLayout();
            // 
            // btnCari
            // 
            btnCari.Location = new Point(649, 23);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(121, 36);
            btnCari.TabIndex = 0;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(12, 23);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(631, 27);
            txtCari.TabIndex = 1;
            // 
            // dgRiwayat
            // 
            dgRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRiwayat.Location = new Point(12, 56);
            dgRiwayat.Name = "dgRiwayat";
            dgRiwayat.RowHeadersWidth = 51;
            dgRiwayat.Size = new Size(631, 340);
            dgRiwayat.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(649, 398);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(121, 40);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FormRiawayatKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(dgRiwayat);
            Controls.Add(txtCari);
            Controls.Add(btnCari);
            Name = "FormRiawayatKasir";
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
    }
}