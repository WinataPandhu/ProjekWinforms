namespace ProjekWinform
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            TbPassword = new TextBox();
            TbUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(45, 45, 110);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(90, 400);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 46);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "MASUK";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // TbPassword
            // 
            TbPassword.BackColor = Color.FromArgb(248, 248, 252);
            TbPassword.BorderStyle = BorderStyle.FixedSingle;
            TbPassword.Font = new Font("Segoe UI", 10.5F);
            TbPassword.ForeColor = Color.FromArgb(30, 30, 80);
            TbPassword.Location = new Point(90, 338);
            TbPassword.Name = "TbPassword";
            TbPassword.PasswordChar = '●';
            TbPassword.Size = new Size(300, 31);
            TbPassword.TabIndex = 4;
            // 
            // TbUsername
            // 
            TbUsername.BackColor = Color.FromArgb(248, 248, 252);
            TbUsername.BorderStyle = BorderStyle.FixedSingle;
            TbUsername.Font = new Font("Segoe UI", 10.5F);
            TbUsername.ForeColor = Color.FromArgb(30, 30, 80);
            TbUsername.Location = new Point(90, 263);
            TbUsername.Name = "TbUsername";
            TbUsername.Size = new Size(300, 31);
            TbUsername.TabIndex = 2;
            TbUsername.TextChanged += TbUsername_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(100, 100, 130);
            label3.Location = new Point(90, 315);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(100, 100, 130);
            label2.Location = new Point(90, 240);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(30, 30, 80);
            label1.Location = new Point(40, 175);
            label1.Name = "label1";
            label1.Size = new Size(400, 45);
            label1.TabIndex = 0;
            label1.Text = "Toko Alat Pertanian";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(180, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = true;
            // 
            // Login
            // 
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(480, 540);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(TbUsername);
            Controls.Add(label3);
            Controls.Add(TbPassword);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            Text = "Login - Toko Alat Pertanian";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TbPassword;
        private TextBox TbUsername;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLogin;
        private PictureBox pictureBox1;
    }
}
