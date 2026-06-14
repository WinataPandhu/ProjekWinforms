namespace ProjekWinform
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            DgUser = new DataGridView();
            btnTambah = new Button();
            btnEdit = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            BtnKembali = new Button();
            btnLihat = new Button();
            ((System.ComponentModel.ISupportInitialize)DgUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DgUser
            // 
            DgUser.BackgroundColor = Color.White;
            DgUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgUser.Location = new Point(226, 31);
            DgUser.Margin = new Padding(2);
            DgUser.Name = "DgUser";
            DgUser.RowHeadersWidth = 62;
            DgUser.Size = new Size(617, 322);
            DgUser.TabIndex = 1;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.LimeGreen;
            btnTambah.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(-1, 65);
            btnTambah.Margin = new Padding(2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(196, 72);
            btnTambah.TabIndex = 2;
            btnTambah.Text = "Tambah Akun";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 192, 192);
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(-1, 161);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(173, 69);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit Akun";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-1, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 570);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(11, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 41);
            label1.TabIndex = 6;
            label1.Text = "Fitur";
            // 
            // BtnKembali
            // 
            BtnKembali.BackColor = Color.Red;
            BtnKembali.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnKembali.ForeColor = Color.White;
            BtnKembali.Location = new Point(-1, 344);
            BtnKembali.Margin = new Padding(2);
            BtnKembali.Name = "BtnKembali";
            BtnKembali.Size = new Size(108, 57);
            BtnKembali.TabIndex = 7;
            BtnKembali.Text = "Exit";
            BtnKembali.UseVisualStyleBackColor = false;
            BtnKembali.Click += BtnKembali_Click;
            // 
            // btnLihat
            // 
            btnLihat.BackColor = Color.FromArgb(255, 128, 0);
            btnLihat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLihat.ForeColor = Color.White;
            btnLihat.Location = new Point(-1, 252);
            btnLihat.Margin = new Padding(2);
            btnLihat.Name = "btnLihat";
            btnLihat.Size = new Size(145, 65);
            btnLihat.TabIndex = 4;
            btnLihat.Text = "Lihat Pemilik";
            btnLihat.UseVisualStyleBackColor = false;
            btnLihat.Click += btnLihat_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(854, 474);
            Controls.Add(BtnKembali);
            Controls.Add(btnLihat);
            Controls.Add(btnEdit);
            Controls.Add(label1);
            Controls.Add(btnTambah);
            Controls.Add(pictureBox1);
            Controls.Add(DgUser);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)DgUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DgUser;
        private Button btnTambah;
        private Button btnEdit;
        private PictureBox pictureBox1;
        private Label label1;
        private Button BtnKembali;
        private Button btnLihat;
    }
}