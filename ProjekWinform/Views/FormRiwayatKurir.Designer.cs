namespace ProjekWinform
{
    partial class FormRiwayatKurir
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
            dgRiwayatPengirim = new DataGridView();
            dtpCari = new DateTimePicker();
            btnCari = new Button();
            ((System.ComponentModel.ISupportInitialize)dgRiwayatPengirim).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Firebrick;
            btnExit.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Transparent;
            btnExit.Location = new Point(578, 368);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(190, 70);
            btnExit.TabIndex = 0;
            btnExit.Text = "KELUAR";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // dgRiwayatPengirim
            // 
            dgRiwayatPengirim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRiwayatPengirim.Location = new Point(25, 31);
            dgRiwayatPengirim.Name = "dgRiwayatPengirim";
            dgRiwayatPengirim.RowHeadersWidth = 51;
            dgRiwayatPengirim.Size = new Size(743, 331);
            dgRiwayatPengirim.TabIndex = 1;
            // 
            // dtpCari
            // 
            dtpCari.Location = new Point(37, 391);
            dtpCari.Name = "dtpCari";
            dtpCari.Size = new Size(260, 27);
            dtpCari.TabIndex = 2;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.Lime;
            btnCari.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCari.Location = new Point(303, 385);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(110, 37);
            btnCari.TabIndex = 3;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            // 
            // FormRiwayatKurir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCari);
            Controls.Add(dtpCari);
            Controls.Add(dgRiwayatPengirim);
            Controls.Add(btnExit);
            Name = "FormRiwayatKurir";
            Text = "FormRiwayatKurir";
            ((System.ComponentModel.ISupportInitialize)dgRiwayatPengirim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private DataGridView dgRiwayatPengirim;
        private DateTimePicker dtpCari;
        private Button btnCari;
    }
}