namespace UI.Forms.EmployeePage
{
    partial class MyPageLawyerView
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
            lblFullname = new Label();
            lblLawyerTitle = new Label();
            lblCity = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.Location = new Point(33, 43);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(56, 15);
            lblFullname.TabIndex = 0;
            lblFullname.Text = "Fullname";
            // 
            // lblLawyerTitle
            // 
            lblLawyerTitle.AutoSize = true;
            lblLawyerTitle.Location = new Point(33, 69);
            lblLawyerTitle.Name = "lblLawyerTitle";
            lblLawyerTitle.Size = new Size(66, 15);
            lblLawyerTitle.TabIndex = 0;
            lblLawyerTitle.Text = "LawyerTitle";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(33, 98);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(28, 15);
            lblCity.TabIndex = 0;
            lblCity.Text = "City";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(33, 126);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(33, 158);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // MyPageLawyerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblCity);
            Controls.Add(lblLawyerTitle);
            Controls.Add(lblFullname);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MyPageLawyerView";
            Text = "MyPageLawyerView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullname;
        private Label lblLawyerTitle;
        private Label lblCity;
        private Label lblPhone;
        private Label lblEmail;
    }
}