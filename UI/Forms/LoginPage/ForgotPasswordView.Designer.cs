namespace UI.Forms.LoginPage
{
    partial class ForgotPasswordView
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
            panel1 = new Panel();
            lblRetrievePassword = new Label();
            lblCancel = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(520, 77);
            panel1.TabIndex = 8;
            // 
            // lblRetrievePassword
            // 
            lblRetrievePassword.Anchor = AnchorStyles.Top;
            lblRetrievePassword.AutoSize = true;
            lblRetrievePassword.BackColor = SystemColors.GradientActiveCaption;
            lblRetrievePassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRetrievePassword.ForeColor = Color.FromArgb(45, 93, 134);
            lblRetrievePassword.Location = new Point(169, 39);
            lblRetrievePassword.Name = "lblRetrievePassword";
            lblRetrievePassword.Size = new Size(206, 25);
            lblRetrievePassword.TabIndex = 4;
            lblRetrievePassword.Text = "RETRIEVE PASSWORD";
            // 
            // lblCancel
            // 
            lblCancel.Anchor = AnchorStyles.Bottom;
            lblCancel.AutoSize = true;
            lblCancel.BackColor = SystemColors.GradientInactiveCaption;
            lblCancel.Cursor = Cursors.Hand;
            lblCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCancel.ForeColor = Color.FromArgb(45, 93, 134);
            lblCancel.Location = new Point(54, 523);
            lblCancel.Name = "lblCancel";
            lblCancel.Size = new Size(58, 21);
            lblCancel.TabIndex = 0;
            lblCancel.Text = "Cancel";
            // 
            // ForgotPasswordView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(544, 584);
            ControlBox = false;
            Controls.Add(lblRetrievePassword);
            Controls.Add(panel1);
            Controls.Add(lblCancel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ForgotPasswordView";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblRetrievePassword;
        private Label lblCancel;
    }
}