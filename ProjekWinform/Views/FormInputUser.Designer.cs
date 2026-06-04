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
            label3 = new Label();
            textBoxAsal = new TextBox();
            label2 = new Label();
            textBoxUmur = new TextBox();
            label1 = new Label();
            textBoxNama = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.card;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxAsal);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxUmur);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxNama);
            panel1.Location = new Point(47, 31);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 405);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 270);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 23);
            label3.TabIndex = 5;
            label3.Text = "Asal";
            // 
            // textBoxAsal
            // 
            textBoxAsal.Location = new Point(34, 304);
            textBoxAsal.Margin = new Padding(2, 2, 2, 2);
            textBoxAsal.Name = "textBoxAsal";
            textBoxAsal.Size = new Size(314, 27);
            textBoxAsal.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 173);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 3;
            label2.Text = "Umur";
            // 
            // textBoxUmur
            // 
            textBoxUmur.Location = new Point(34, 207);
            textBoxUmur.Margin = new Padding(2, 2, 2, 2);
            textBoxUmur.Name = "textBoxUmur";
            textBoxUmur.Size = new Size(314, 27);
            textBoxUmur.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 78);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 1;
            label1.Text = "Nama";
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(34, 113);
            textBoxNama.Margin = new Padding(2, 2, 2, 2);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(314, 27);
            textBoxNama.TabIndex = 0;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Green;
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(530, 276);
            btnSimpan.Margin = new Padding(2, 2, 2, 2);
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
            btnBatal.Margin = new Padding(2, 2, 2, 2);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(212, 66);
            btnBatal.TabIndex = 3;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // FormInputUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(831, 478);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
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
        private TextBox textBoxAsal;
        private Label label2;
        private TextBox textBoxUmur;
        private Label label1;
        private TextBox textBoxNama;
    }
}