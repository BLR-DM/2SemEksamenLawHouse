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
            lblTitlelbl = new Label();
            lblDescriptionlbl = new Label();
            lblPricelbl = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(89, 53);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(29, 15);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Title";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(166, 349);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 16;
            lblPrice.Text = "Price";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.GradientInactiveCaption;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Location = new Point(82, 120);
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
            // lblTitlelbl
            // 
            lblTitlelbl.AutoSize = true;
            lblTitlelbl.BackColor = SystemColors.GradientInactiveCaption;
            lblTitlelbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitlelbl.ForeColor = Color.FromArgb(45, 93, 134);
            lblTitlelbl.Location = new Point(82, 32);
            lblTitlelbl.Name = "lblTitlelbl";
            lblTitlelbl.Size = new Size(46, 21);
            lblTitlelbl.TabIndex = 43;
            lblTitlelbl.Text = "Title:";
            // 
            // lblDescriptionlbl
            // 
            lblDescriptionlbl.AutoSize = true;
            lblDescriptionlbl.BackColor = SystemColors.GradientInactiveCaption;
            lblDescriptionlbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDescriptionlbl.ForeColor = Color.FromArgb(45, 93, 134);
            lblDescriptionlbl.Location = new Point(82, 96);
            lblDescriptionlbl.Name = "lblDescriptionlbl";
            lblDescriptionlbl.Size = new Size(98, 21);
            lblDescriptionlbl.TabIndex = 44;
            lblDescriptionlbl.Text = "Description:";
            // 
            // lblPricelbl
            // 
            lblPricelbl.AutoSize = true;
            lblPricelbl.BackColor = SystemColors.GradientInactiveCaption;
            lblPricelbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPricelbl.ForeColor = Color.FromArgb(45, 93, 134);
            lblPricelbl.Location = new Point(95, 343);
            lblPricelbl.Name = "lblPricelbl";
            lblPricelbl.Size = new Size(50, 21);
            lblPricelbl.TabIndex = 45;
            lblPricelbl.Text = "Price:";
            // 
            // FormDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(334, 454);
            Controls.Add(lblPricelbl);
            Controls.Add(lblDescriptionlbl);
            Controls.Add(lblTitlelbl);
            Controls.Add(btnResendMail);
            Controls.Add(txtDescription);
            Controls.Add(lblPrice);
            Controls.Add(lblTitle);
            Name = "FormDetails";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private Label lblPrice;
        private TextBox txtDescription;
        private FontAwesome.Sharp.IconButton btnResendMail;
        private Label lblTitlelbl;
        private Label lblDescriptionlbl;
        private Label lblPricelbl;
    }
}