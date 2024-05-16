namespace UI.Toolbox
{
    partial class LawyerInformation
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
            lblAddLawyer = new Label();
            txtFirstname = new TextBox();
            lblFirstname = new Label();
            txtLastname = new TextBox();
            lblLastname = new Label();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // lblAddLawyer
            // 
            lblAddLawyer.AutoSize = true;
            lblAddLawyer.BackColor = SystemColors.GradientInactiveCaption;
            lblAddLawyer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAddLawyer.ForeColor = Color.FromArgb(45, 93, 134);
            lblAddLawyer.Location = new Point(65, 6);
            lblAddLawyer.Name = "lblAddLawyer";
            lblAddLawyer.Size = new Size(151, 21);
            lblAddLawyer.TabIndex = 22;
            lblAddLawyer.Text = "Lawyer information";
            // 
            // txtFirstname
            // 
            txtFirstname.BackColor = Color.White;
            txtFirstname.BorderStyle = BorderStyle.None;
            txtFirstname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstname.Location = new Point(10, 62);
            txtFirstname.MaxLength = 50;
            txtFirstname.Name = "txtFirstname";
            txtFirstname.ReadOnly = true;
            txtFirstname.Size = new Size(120, 20);
            txtFirstname.TabIndex = 58;
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.BackColor = SystemColors.GradientInactiveCaption;
            lblFirstname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblFirstname.ForeColor = Color.FromArgb(45, 93, 134);
            lblFirstname.Location = new Point(10, 38);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(81, 21);
            lblFirstname.TabIndex = 59;
            lblFirstname.Text = "Firstname";
            // 
            // txtLastname
            // 
            txtLastname.BackColor = Color.White;
            txtLastname.BorderStyle = BorderStyle.None;
            txtLastname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastname.Location = new Point(147, 62);
            txtLastname.MaxLength = 50;
            txtLastname.Name = "txtLastname";
            txtLastname.ReadOnly = true;
            txtLastname.Size = new Size(120, 20);
            txtLastname.TabIndex = 58;
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.BackColor = SystemColors.GradientInactiveCaption;
            lblLastname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblLastname.ForeColor = Color.FromArgb(45, 93, 134);
            lblLastname.Location = new Point(147, 38);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(79, 21);
            lblLastname.TabIndex = 59;
            lblLastname.Text = "Lastname";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = SystemColors.GradientInactiveCaption;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(45, 93, 134);
            lblPhone.Location = new Point(10, 94);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(117, 21);
            lblPhone.TabIndex = 59;
            lblPhone.Text = "Phone number";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(10, 118);
            txtPhone.MaxLength = 50;
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(120, 20);
            txtPhone.TabIndex = 58;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.GradientInactiveCaption;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(45, 93, 134);
            lblEmail.Location = new Point(10, 151);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 59;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(10, 175);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(120, 20);
            txtEmail.TabIndex = 58;
            // 
            // LawyerInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(txtLastname);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtFirstname);
            Controls.Add(lblEmail);
            Controls.Add(lblLastname);
            Controls.Add(lblPhone);
            Controls.Add(lblFirstname);
            Controls.Add(lblAddLawyer);
            Name = "LawyerInformation";
            Size = new Size(281, 202);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddLawyer;
        private TextBox txtFirstname;
        private Label lblFirstname;
        private TextBox txtLastname;
        private Label lblLastname;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
    }
}
