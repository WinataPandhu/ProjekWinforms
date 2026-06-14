namespace ProjekWinform
{
    partial class FormInputAlat
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
            txtNamaAlat = new TextBox();
            txtHarga = new TextBox();
            cmbStatus = new ComboBox();
            cmbJenis = new ComboBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtNamaAlat
            // 
            txtNamaAlat.Location = new Point(34, 79);
            txtNamaAlat.Name = "txtNamaAlat";
            txtNamaAlat.Size = new Size(202, 27);
            txtNamaAlat.TabIndex = 0;
            txtNamaAlat.TextChanged += txtNamaAlat_TextChanged;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(34, 159);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(202, 27);
            txtHarga.TabIndex = 1;
            txtHarga.TextChanged += txtHarga_TextChanged;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(300, 79);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(202, 28);
            cmbStatus.TabIndex = 3;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // cmbJenis
            // 
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Location = new Point(300, 158);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(202, 28);
            cmbJenis.TabIndex = 4;
            cmbJenis.SelectedIndexChanged += cmbJenis_SelectedIndexChanged;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(0, 192, 0);
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = SystemColors.ButtonHighlight;
            btnSimpan.Location = new Point(575, 222);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(199, 58);
            btnSimpan.TabIndex = 5;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(192, 0, 0);
            btnBatal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = SystemColors.ButtonHighlight;
            btnBatal.Location = new Point(575, 300);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(199, 58);
            btnBatal.TabIndex = 6;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 48);
            label1.Name = "label1";
            label1.Size = new Size(113, 28);
            label1.TabIndex = 7;
            label1.Text = "Nama Alat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 128);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 8;
            label2.Text = "Harga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 210);
            label3.Name = "label3";
            label3.Size = new Size(54, 28);
            label3.TabIndex = 9;
            label3.Text = "Stok";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(300, 48);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 10;
            label4.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(300, 127);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 11;
            label5.Text = "Jenis";
            // 
            // FormInputAlat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(cmbJenis);
            Controls.Add(cmbStatus);
            Controls.Add(txtHarga);
            Controls.Add(txtNamaAlat);
            Name = "FormInputAlat";
            Text = "FormInputAlat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNamaAlat;
        private TextBox txtHarga;
        private ComboBox cmbStatus;
        private ComboBox cmbJenis;
        private Button btnSimpan;
        private Button btnBatal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}