namespace UI.Toolbox
{
    partial class SideMenuButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNavButton = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // btnNavButton
            // 
            btnNavButton.BackColor = Color.FromArgb(194, 205, 240);
            btnNavButton.Dock = DockStyle.Fill;
            btnNavButton.FlatStyle = FlatStyle.Flat;
            btnNavButton.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNavButton.IconColor = Color.Black;
            btnNavButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNavButton.Location = new Point(0, 0);
            btnNavButton.Name = "btnNavButton";
            btnNavButton.Size = new Size(200, 75);
            btnNavButton.TabIndex = 0;
            btnNavButton.Text = "Test";
            btnNavButton.UseVisualStyleBackColor = false;
            // 
            // SideMenuButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 205, 240);
            Controls.Add(btnNavButton);
            Name = "SideMenuButton";
            Size = new Size(200, 75);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnNavButton;
    }
}
