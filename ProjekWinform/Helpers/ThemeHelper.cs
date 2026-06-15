using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjekWinform.Helpers
{
    public static class ThemeHelper
    {
        // Agricultural Green Palette
        public static readonly Color ColorPrimaryDark = Color.FromArgb(34, 112, 63);    // Forest Emerald Green
        public static readonly Color ColorPrimaryLight = Color.FromArgb(244, 248, 244); // Soft Sage/Mint Base Background
        public static readonly Color ColorAccent = Color.FromArgb(46, 139, 87);          // Sea Green for accents
        public static readonly Color ColorTextDark = Color.FromArgb(24, 51, 33);        // Deep Forest Charcoal
        public static readonly Color ColorTextLight = Color.White;
        public static readonly Color ColorWarning = Color.FromArgb(220, 53, 69);        // Rich red for exit/delete
        public static readonly Color ColorWarningHover = Color.FromArgb(200, 35, 51);
        public static readonly Color ColorInputBg = Color.White;
        public static readonly Color ColorGridAltRow = Color.FromArgb(245, 250, 245);  // Light mint grid alternate
        public static readonly Color ColorBorder = Color.FromArgb(200, 220, 200);

        /// <summary>
        /// Applies the green agricultural design theme to a form and all its controls recursively.
        /// </summary>
        public static void ApplyTheme(Form form)
        {
            form.BackColor = ColorPrimaryLight;
            form.ForeColor = ColorTextDark;
            form.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);

            // Recursively style controls
            StyleControls(form.Controls);
        }

        private static void StyleControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                // Recursive call for nested container controls
                if (ctrl.HasChildren)
                {
                    StyleControls(ctrl.Controls);
                }

                // Apply styling based on control type
                if (ctrl is Panel panel)
                {
                    // Card look or transparent panel container
                    if (panel.BackColor != Color.Transparent && panel.BackColor != ColorPrimaryLight)
                    {
                        panel.BackColor = Color.White;
                    }
                }
                else if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
                    btn.Cursor = Cursors.Hand;

                    string text = btn.Text.ToLower();
                    if (text.Contains("exit") || text.Contains("keluar") || text.Contains("batal") || text.Contains("cancel") || text.Contains("hapus"))
                    {
                        btn.BackColor = ColorWarning;
                        btn.ForeColor = ColorTextLight;
                    }
                    else if (text.Contains("tambah") || text.Contains("simpan") || text.Contains("buat") || text.Contains("save") || text.Contains("update"))
                    {
                        btn.BackColor = ColorPrimaryDark;
                        btn.ForeColor = ColorTextLight;
                    }
                    else
                    {
                        // Default primary green button
                        btn.BackColor = ColorPrimaryDark;
                        btn.ForeColor = ColorTextLight;
                    }

                    // Hover effects can be added dynamically
                    btn.MouseEnter += (s, e) =>
                    {
                        if (btn.BackColor == ColorWarning)
                            btn.BackColor = ColorWarningHover;
                        else
                            btn.BackColor = ColorAccent;
                    };
                    btn.MouseLeave += (s, e) =>
                    {
                        if (btn.BackColor == ColorWarningHover)
                            btn.BackColor = ColorWarning;
                        else
                            btn.BackColor = ColorPrimaryDark;
                    };
                }
                else if (ctrl is Label lbl)
                {
                    // Don't modify labels marked as transparent or background holders
                    if (lbl.BackColor != Color.Transparent)
                    {
                        lbl.BackColor = Color.Transparent;
                    }

                    if (lbl.Font.Size >= 14)
                    {
                        // Titles and Headings
                        lbl.ForeColor = ColorPrimaryDark;
                        lbl.Font = new Font("Segoe UI", lbl.Font.Size, FontStyle.Bold, GraphicsUnit.Point);
                    }
                    else
                    {
                        // Subtitles and descriptive labels
                        lbl.ForeColor = ColorTextDark;
                        lbl.Font = new Font("Segoe UI", lbl.Font.Size, FontStyle.Bold, GraphicsUnit.Point);
                    }
                }
                else if (ctrl is TextBox txt)
                {
                    txt.BackColor = ColorInputBg;
                    txt.ForeColor = ColorTextDark;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
                else if (ctrl is ComboBox cb)
                {
                    cb.BackColor = ColorInputBg;
                    cb.ForeColor = ColorTextDark;
                    cb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
                else if (ctrl is NumericUpDown nud)
                {
                    nud.BackColor = ColorInputBg;
                    nud.ForeColor = ColorTextDark;
                    nud.BorderStyle = BorderStyle.FixedSingle;
                    nud.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
                else if (ctrl is DataGridView dgv)
                {
                    // Style DataGridViews to look clean and premium
                    dgv.BackgroundColor = Color.White;
                    dgv.BorderStyle = BorderStyle.None;
                    dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dgv.GridColor = ColorBorder;
                    dgv.RowHeadersVisible = false;

                    // Row & Column styles
                    dgv.AlternatingRowsDefaultCellStyle.BackColor = ColorGridAltRow;
                    dgv.DefaultCellStyle.BackColor = Color.White;
                    dgv.DefaultCellStyle.ForeColor = ColorTextDark;
                    dgv.DefaultCellStyle.SelectionBackColor = ColorAccent;
                    dgv.DefaultCellStyle.SelectionForeColor = ColorTextLight;
                    dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);

                    // Header styling
                    dgv.EnableHeadersVisualStyles = false;
                    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorPrimaryDark;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = ColorTextLight;
                    dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorPrimaryDark;
                    dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = ColorTextLight;
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
                    dgv.ColumnHeadersHeight = 35;
                }
            }
        }

        /// <summary>
        /// Loads the agricultural shop logo into a PictureBox, sets visual size mode, and makes it visible.
        /// </summary>
        public static void LoadLogo(PictureBox pictureBox)
        {
            if (pictureBox == null) return;
            try
            {
                string logoPath = Path.Combine(Application.StartupPath, "Resources", "logo.png");
                if (File.Exists(logoPath))
                {
                    pictureBox.Image = Image.FromFile(logoPath);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Visible = true;
                    pictureBox.BackColor = Color.Transparent;
                }
            }
            catch
            {
                // Fallback silently if loading issues arise (like file locks)
            }
        }
    }
}
