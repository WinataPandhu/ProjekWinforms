namespace ProjekWinform
{
    partial class FormRestok
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
            label1 = new Label();
            label2 = new Label();
            txtJumlah = new TextBox();
            txtHargaBeli = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 104);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 0;
            label1.Text = "Jumlah Restok";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(334, 185);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 1;
            label2.Text = "Harga Beli";
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(318, 135);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(150, 27);
            txtJumlah.TabIndex = 2;
            // 
            // txtHargaBeli
            // 
            txtHargaBeli.Location = new Point(318, 216);
            txtHargaBeli.Name = "txtHargaBeli";
            txtHargaBeli.Size = new Size(150, 27);
            txtHargaBeli.TabIndex = 3;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Green;
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = SystemColors.ButtonHighlight;
            btnSimpan.Location = new Point(223, 291);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(154, 64);
            btnSimpan.TabIndex = 4;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(192, 0, 0);
            btnBatal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = SystemColors.ButtonHighlight;
            btnBatal.Location = new Point(401, 291);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(154, 64);
            btnBatal.TabIndex = 5;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(274, 24);
            label3.Name = "label3";
            label3.Size = new Size(237, 37);
            label3.TabIndex = 6;
            label3.Text = "RESTOK PRODUK";
            // 
            // FormRestok
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(txtHargaBeli);
            Controls.Add(txtJumlah);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRestok";
            Text = "FormRestok";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtJumlah;
        private TextBox txtHargaBeli;
        private Button btnSimpan;
        private Button btnBatal;
        private Label label3;
    }
}