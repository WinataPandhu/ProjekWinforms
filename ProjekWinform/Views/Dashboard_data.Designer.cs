namespace ProjekWinform
{
    partial class Dashboard_data
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
            DgUser = new DataGridView();
            btnEdit = new Button();
            BtnKembali = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgUser).BeginInit();
            SuspendLayout();
            // 
            // DgUser
            // 
            DgUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgUser.Location = new Point(228, 12);
            DgUser.Name = "DgUser";
            DgUser.RowHeadersWidth = 51;
            DgUser.Size = new Size(560, 426);
            DgUser.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.ForestGreen;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(2, 93);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(194, 58);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit Data";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // BtnKembali
            // 
            BtnKembali.BackColor = Color.Red;
            BtnKembali.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnKembali.ForeColor = SystemColors.ButtonHighlight;
            BtnKembali.Location = new Point(24, 392);
            BtnKembali.Name = "BtnKembali";
            BtnKembali.Size = new Size(134, 46);
            BtnKembali.TabIndex = 4;
            BtnKembali.Text = "Exit";
            BtnKembali.UseVisualStyleBackColor = false;
            BtnKembali.Click += BtnKembali_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 25);
            label2.Name = "label2";
            label2.Size = new Size(212, 37);
            label2.TabIndex = 6;
            label2.Text = "MANAGE DATA";
            // 
            // Dashboard_data
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(BtnKembali);
            Controls.Add(btnEdit);
            Controls.Add(DgUser);
            Name = "Dashboard_data";
            Text = "Dashboard_data";
            ((System.ComponentModel.ISupportInitialize)DgUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgUser;
        private Button btnEdit;
        private Button BtnKembali;
        private Label label2;
    }
}