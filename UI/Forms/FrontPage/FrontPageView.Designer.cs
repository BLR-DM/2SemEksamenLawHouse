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
            gradiantPanel2 = new Toolbox.GradiantPanel();
            SuspendLayout();
            // 
            // gradiantPanel1
            // 
            gradiantPanel1.Angle = 110F;
            gradiantPanel1.BackColor = Color.FromArgb(94, 103, 131);
            gradiantPanel1.BottomColor = Color.Empty;
            gradiantPanel1.Dock = DockStyle.Top;
            gradiantPanel1.Location = new Point(0, 0);
            gradiantPanel1.Name = "gradiantPanel1";
            gradiantPanel1.Size = new Size(1348, 61);
            gradiantPanel1.TabIndex = 1;
            gradiantPanel1.TopColor = Color.FromArgb(15, 30, 74);
            // 
            // gradiantPanel2
            // 
            gradiantPanel2.Angle = 0F;
            gradiantPanel2.BottomColor = Color.Empty;
            gradiantPanel2.Dock = DockStyle.Left;
            gradiantPanel2.Location = new Point(0, 61);
            gradiantPanel2.Name = "gradiantPanel2";
            gradiantPanel2.Size = new Size(200, 687);
            gradiantPanel2.TabIndex = 2;
            gradiantPanel2.TopColor = Color.Empty;
            // 
            // FrontPageView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 748);
            ControlBox = false;
            Controls.Add(gradiantPanel2);
            Controls.Add(gradiantPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrontPageView";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private Toolbox.GradiantPanel gradiantPanel1;
        private Toolbox.GradiantPanel gradiantPanel2;
    }
}