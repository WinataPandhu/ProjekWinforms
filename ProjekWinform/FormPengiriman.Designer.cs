namespace ProjekWinform
{
    partial class FormPengiriman
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
            btnStatus = new Button();
            dgAntar = new DataGridView();
            btnCari = new Button();
            textCari = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgAntar).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(651, 387);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(128, 51);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnStatus
            // 
            btnStatus.BackColor = Color.FromArgb(192, 192, 0);
            btnStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatus.ForeColor = Color.White;
            btnStatus.Location = new Point(314, 376);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(169, 62);
            btnStatus.TabIndex = 1;
            btnStatus.Text = "Ubah Status";
            btnStatus.UseVisualStyleBackColor = false;
            btnStatus.Click += btnStatus_Click;
            // 
            // dgAntar
            // 
            dgAntar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAntar.Location = new Point(12, 62);
            dgAntar.Name = "dgAntar";
            dgAntar.RowHeadersWidth = 51;
            dgAntar.Size = new Size(776, 295);
            dgAntar.TabIndex = 2;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(0, 192, 0);
            btnCari.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(702, 29);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(77, 32);
            btnCari.TabIndex = 3;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            // 
            // textCari
            // 
            textCari.Location = new Point(12, 29);
            textCari.Name = "textCari";
            textCari.Size = new Size(684, 27);
            textCari.TabIndex = 4;
            // 
            // FormPengiriman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textCari);
            Controls.Add(btnCari);
            Controls.Add(dgAntar);
            Controls.Add(btnStatus);
            Controls.Add(btnExit);
            Name = "FormPengiriman";
            Text = "FormPengiriman";
            ((System.ComponentModel.ISupportInitialize)dgAntar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnStatus;
        private DataGridView dgAntar;
        private Button btnCari;
        private TextBox textCari;
    }
}