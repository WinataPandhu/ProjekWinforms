namespace ProjekWinform
{
    partial class FormHargaBaru
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
            txtHargaBaru = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(323, 88);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 0;
            label1.Text = "Harga Baru";
            // 
            // txtHargaBaru
            // 
            txtHargaBaru.Location = new Point(274, 128);
            txtHargaBaru.Name = "txtHargaBaru";
            txtHargaBaru.Size = new Size(220, 27);
            txtHargaBaru.TabIndex = 1;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Green;
            btnSimpan.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = SystemColors.ButtonHighlight;
            btnSimpan.Location = new Point(203, 194);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(169, 56);
            btnSimpan.TabIndex = 2;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click_1;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(192, 0, 0);
            btnBatal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = SystemColors.ButtonHighlight;
            btnBatal.Location = new Point(390, 194);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(169, 56);
            btnBatal.TabIndex = 3;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click_1;
            // 
            // FormHargaBaru
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(txtHargaBaru);
            Controls.Add(label1);
            Name = "FormHargaBaru";
            Text = "FormHargaBaru";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHargaBaru;
        private Button btnSimpan;
        private Button btnBatal;
    }
}