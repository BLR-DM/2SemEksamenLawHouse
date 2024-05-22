namespace UI.Forms.Self_Service
{
    partial class FormDetails
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
            lblTitle = new Label();
            lblPrice = new Label();
            txtDescription = new TextBox();
            btnResendMail = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(153, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(29, 15);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Title";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(151, 349);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 16;
            lblPrice.Text = "Price";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.GradientInactiveCaption;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Location = new Point(82, 101);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(170, 196);
            txtDescription.TabIndex = 17;
            txtDescription.TabStop = false;
            // 
            // btnResendMail
            // 
            btnResendMail.Anchor = AnchorStyles.Bottom;
            btnResendMail.BackColor = Color.FromArgb(45, 93, 134);
            btnResendMail.Cursor = Cursors.Hand;
            btnResendMail.FlatAppearance.BorderSize = 0;
            btnResendMail.FlatStyle = FlatStyle.Flat;
            btnResendMail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnResendMail.ForeColor = Color.White;
            btnResendMail.IconChar = FontAwesome.Sharp.IconChar.None;
            btnResendMail.IconColor = Color.Black;
            btnResendMail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnResendMail.IconSize = 70;
            btnResendMail.Location = new Point(89, 381);
            btnResendMail.Name = "btnResendMail";
            btnResendMail.Size = new Size(156, 41);
            btnResendMail.TabIndex = 18;
            btnResendMail.Text = "Resend Mail";
            btnResendMail.UseVisualStyleBackColor = false;
            // 
            // FormDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(334, 454);
            Controls.Add(btnResendMail);
            Controls.Add(txtDescription);
            Controls.Add(lblPrice);
            Controls.Add(lblTitle);
            Name = "FormDetails";
            Text = "Form Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private Label lblPrice;
        private TextBox txtDescription;
        private FontAwesome.Sharp.IconButton btnResendMail;
    }
}