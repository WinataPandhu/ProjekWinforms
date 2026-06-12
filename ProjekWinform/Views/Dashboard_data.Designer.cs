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
            ((System.ComponentModel.ISupportInitialize)DgUser).BeginInit();
            SuspendLayout();
            // 
            // DgUser
            // 
            DgUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgUser.Location = new Point(12, 12);
            DgUser.Name = "DgUser";
            DgUser.RowHeadersWidth = 51;
            DgUser.Size = new Size(776, 350);
            DgUser.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.ForestGreen;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(12, 392);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(184, 49);
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
            BtnKembali.Location = new Point(596, 400);
            BtnKembali.Name = "BtnKembali";
            BtnKembali.Size = new Size(192, 41);
            BtnKembali.TabIndex = 4;
            BtnKembali.Text = "Exit";
            BtnKembali.UseVisualStyleBackColor = false;
            BtnKembali.Click += BtnKembali_Click;
            // 
            // Dashboard_data
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnKembali);
            Controls.Add(btnEdit);
            Controls.Add(DgUser);
            Name = "Dashboard_data";
            Text = "Dashboard_data";
            ((System.ComponentModel.ISupportInitialize)DgUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgUser;
        private Button btnEdit;
        private Button BtnKembali;
    }
}