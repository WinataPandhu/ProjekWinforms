namespace ProjekWinform
{
    partial class FormInputUser
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
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            cmbStatus = new ComboBox();
            label3 = new Label();
            txtAlamat = new TextBox();
            label2 = new Label();
            txtNoHp = new TextBox();
            label1 = new Label();
            txtNama = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            cmbIdAkun = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(cmbIdAkun);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtAlamat);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNoHp);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNama);
            panel1.Location = new Point(47, 31);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 405);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 313);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 23);
            label5.TabIndex = 9;
            label5.Text = "ID Akun";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 245);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 8;
            label4.Text = "Status";
            label4.Click += label4_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(36, 268);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 169);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 5;
            label3.Text = "Alamat";
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(34, 194);
            txtAlamat.Margin = new Padding(2);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(314, 27);
            txtAlamat.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 99);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 3;
            label2.Text = "No Handphone";
            // 
            // txtNoHp
            // 
            txtNoHp.Location = new Point(34, 124);
            txtNoHp.Margin = new Padding(2);
            txtNoHp.Name = "txtNoHp";
            txtNoHp.Size = new Size(314, 27);
            txtNoHp.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 1;
            label1.Text = "Nama";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(34, 50);
            txtNama.Margin = new Padding(2);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(314, 27);
            txtNama.TabIndex = 0;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Green;
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(530, 276);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(212, 66);
            btnSimpan.TabIndex = 2;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Red;
            btnBatal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(531, 370);
            btnBatal.Margin = new Padding(2);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(212, 66);
            btnBatal.TabIndex = 3;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // cmbIdAkun
            // 
            cmbIdAkun.FormattingEnabled = true;
            cmbIdAkun.Location = new Point(36, 339);
            cmbIdAkun.Name = "cmbIdAkun";
            cmbIdAkun.Size = new Size(151, 28);
            cmbIdAkun.TabIndex = 10;
            // 
            // FormInputUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(831, 478);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "FormInputUser";
            Text = "FormInputUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSimpan;
        private Button btnBatal;
        private Label label3;
        private TextBox txtAlamat;
        private Label label2;
        private TextBox txtNoHp;
        private Label label1;
        private TextBox txtNama;
        private ComboBox cmbStatus;
        private Label label4;
        private Label label5;
        private ComboBox cmbIdAkun;
    }
}