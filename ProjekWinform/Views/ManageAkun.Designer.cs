namespace ProjekWinform
{
    partial class ManageAkun
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DgUser = new DataGridView();
            btnTambah = new Button();
            btnEdit = new Button();
            BtnKembali = new Button();
            btnLihat = new Button();
            panelSidebar = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgUser).BeginInit();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // DgUser
            // 
            DgUser.AllowUserToAddRows = false;
            DgUser.AllowUserToDeleteRows = false;
            DgUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgUser.BackgroundColor = Color.White;
            DgUser.BorderStyle = BorderStyle.None;
            DgUser.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 30, 80);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(30, 30, 80);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgUser.ColumnHeadersHeight = 40;
            DgUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(100, 100, 130);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 235, 250);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 30, 80);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgUser.DefaultCellStyle = dataGridViewCellStyle2;
            DgUser.EnableHeadersVisualStyles = false;
            DgUser.GridColor = Color.FromArgb(240, 240, 245);
            DgUser.Location = new Point(250, 25);
            DgUser.Name = "DgUser";
            DgUser.ReadOnly = true;
            DgUser.RowHeadersVisible = false;
            DgUser.RowHeadersWidth = 51;
            DgUser.RowTemplate.Height = 35;
            DgUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgUser.Size = new Size(575, 445);
            DgUser.TabIndex = 5;
            DgUser.CellContentClick += DgUser_CellContentClick;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.Transparent;
            btnTambah.Cursor = Cursors.Hand;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 35, 90);
            btnTambah.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 55, 130);
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTambah.ForeColor = Color.FromArgb(240, 240, 255);
            btnTambah.Location = new Point(0, 100);
            btnTambah.Name = "btnTambah";
            btnTambah.Padding = new Padding(20, 0, 0, 0);
            btnTambah.Size = new Size(220, 50);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "  Tambah Akun";
            btnTambah.TextAlign = ContentAlignment.MiddleLeft;
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 35, 90);
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 55, 130);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEdit.ForeColor = Color.FromArgb(240, 240, 255);
            btnEdit.Location = new Point(0, 155);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(20, 0, 0, 0);
            btnEdit.Size = new Size(220, 50);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "  Edit Akun";
            btnEdit.TextAlign = ContentAlignment.MiddleLeft;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // BtnKembali
            // 
            BtnKembali.BackColor = Color.FromArgb(215, 60, 60);
            BtnKembali.Cursor = Cursors.Hand;
            BtnKembali.FlatAppearance.BorderSize = 0;
            BtnKembali.FlatStyle = FlatStyle.Flat;
            BtnKembali.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnKembali.ForeColor = Color.White;
            BtnKembali.Location = new Point(24, 425);
            BtnKembali.Name = "BtnKembali";
            BtnKembali.Size = new Size(172, 45);
            BtnKembali.TabIndex = 4;
            BtnKembali.Text = "Keluar / Exit";
            BtnKembali.UseVisualStyleBackColor = false;
            BtnKembali.Click += BtnKembali_Click;
            // 
            // btnLihat
            // 
            btnLihat.BackColor = Color.Transparent;
            btnLihat.Cursor = Cursors.Hand;
            btnLihat.FlatAppearance.BorderSize = 0;
            btnLihat.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 35, 90);
            btnLihat.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 55, 130);
            btnLihat.FlatStyle = FlatStyle.Flat;
            btnLihat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLihat.ForeColor = Color.FromArgb(240, 240, 255);
            btnLihat.Location = new Point(0, 210);
            btnLihat.Name = "btnLihat";
            btnLihat.Padding = new Padding(20, 0, 0, 0);
            btnLihat.Size = new Size(220, 50);
            btnLihat.TabIndex = 3;
            btnLihat.Text = "  Lihat Pemilik";
            btnLihat.TextAlign = ContentAlignment.MiddleLeft;
            btnLihat.UseVisualStyleBackColor = false;
            btnLihat.Click += btnLihat_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(45, 45, 110);
            panelSidebar.Controls.Add(label2);
            panelSidebar.Controls.Add(btnTambah);
            panelSidebar.Controls.Add(btnEdit);
            panelSidebar.Controls.Add(btnLihat);
            panelSidebar.Controls.Add(BtnKembali);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 500);
            panelSidebar.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 25);
            label2.Name = "label2";
            label2.Size = new Size(220, 37);
            label2.TabIndex = 5;
            label2.Text = "MANAGE AKUN";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(854, 500);
            Controls.Add(DgUser);
            Controls.Add(panelSidebar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - Toko Alat Pertanian";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)DgUser).EndInit();
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView DgUser;
        private Button btnTambah;
        private Button btnEdit;
        private Label label1;
        private Button BtnKembali;
        private Button btnLihat;
        private Panel panelSidebar;
        private Label label2;
    }
}