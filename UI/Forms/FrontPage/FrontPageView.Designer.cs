namespace UI.Forms.FrontPage
{
    partial class FrontPageView
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
            gradiantPanel1 = new Toolbox.GradiantPanel();
            pictureBox1 = new PictureBox();
            btnClose = new FontAwesome.Sharp.IconButton();
            gradiantPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gradiantPanel1
            // 
            gradiantPanel1.Angle = 110F;
            gradiantPanel1.BackColor = Color.FromArgb(94, 103, 131);
            gradiantPanel1.BottomColor = Color.Empty;
            gradiantPanel1.Controls.Add(btnClose);
            gradiantPanel1.Controls.Add(pictureBox1);
            gradiantPanel1.Dock = DockStyle.Top;
            gradiantPanel1.Location = new Point(0, 0);
            gradiantPanel1.Name = "gradiantPanel1";
            gradiantPanel1.Size = new Size(1348, 54);
            gradiantPanel1.TabIndex = 1;
            gradiantPanel1.TopColor = Color.FromArgb(62, 82, 150);
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.lawhouseLogo;
            pictureBox1.Location = new Point(0, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            btnClose.IconColor = Color.Black;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 30;
            btnClose.Location = new Point(1301, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 28);
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // FrontPageView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 748);
            ControlBox = false;
            Controls.Add(gradiantPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrontPageView";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.Transparent;
            gradiantPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Toolbox.GradiantPanel gradiantPanel1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}