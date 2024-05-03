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
            btnClose = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            pnlLeft = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnEmployees = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            gradiantPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLeft.SuspendLayout();
            SuspendLayout();
            // 
            // gradiantPanel1
            // 
            gradiantPanel1.Angle = 80F;
            gradiantPanel1.BackColor = Color.FromArgb(60, 110, 170);
            gradiantPanel1.BottomColor = Color.Empty;
            gradiantPanel1.Controls.Add(btnClose);
            gradiantPanel1.Controls.Add(pictureBox1);
            gradiantPanel1.Dock = DockStyle.Top;
            gradiantPanel1.Location = new Point(0, 0);
            gradiantPanel1.Name = "gradiantPanel1";
            gradiantPanel1.Size = new Size(1348, 56);
            gradiantPanel1.TabIndex = 1;
            gradiantPanel1.TopColor = Color.FromArgb(197, 212, 230);
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.lawhouseLogo;
            pictureBox1.Location = new Point(0, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(194, 205, 240);
            pnlLeft.Controls.Add(iconButton1);
            pnlLeft.Controls.Add(btnEmployees);
            pnlLeft.Controls.Add(iconButton4);
            pnlLeft.Controls.Add(iconButton3);
            pnlLeft.Controls.Add(iconButton2);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 56);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(200, 692);
            pnlLeft.TabIndex = 2;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.Black;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 225);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(25, 0, 20, 0);
            iconButton1.Size = new Size(200, 75);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "Employees";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.Transparent;
            btnEmployees.Dock = DockStyle.Top;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployees.ForeColor = Color.Black;
            btnEmployees.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            btnEmployees.IconColor = Color.Black;
            btnEmployees.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEmployees.IconSize = 40;
            btnEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployees.Location = new Point(0, 150);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Padding = new Padding(25, 0, 20, 0);
            btnEmployees.Size = new Size(200, 75);
            btnEmployees.TabIndex = 0;
            btnEmployees.Text = "Employees";
            btnEmployees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployees.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.Transparent;
            iconButton4.Dock = DockStyle.Bottom;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton4.ForeColor = Color.Black;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 40;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(0, 617);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(25, 0, 20, 0);
            iconButton4.Size = new Size(200, 75);
            iconButton4.TabIndex = 0;
            iconButton4.Text = "Employees";
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.Transparent;
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton3.ForeColor = Color.Black;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 40;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 75);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(25, 0, 20, 0);
            iconButton3.Size = new Size(200, 75);
            iconButton3.TabIndex = 0;
            iconButton3.Text = "Employees";
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Transparent;
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = Color.Black;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 40;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 0);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(25, 0, 20, 0);
            iconButton2.Size = new Size(200, 75);
            iconButton2.TabIndex = 0;
            iconButton2.Text = "Employees";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // FrontPageView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 748);
            ControlBox = false;
            Controls.Add(pnlLeft);
            Controls.Add(gradiantPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrontPageView";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.Transparent;
            gradiantPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Toolbox.GradiantPanel gradiantPanel1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnClose;
        private Panel pnlLeft;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnEmployees;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}