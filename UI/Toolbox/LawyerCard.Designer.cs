namespace UI.Toolbox
{
    partial class LawyerCard
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
            pboxProfile = new FontAwesome.Sharp.IconPictureBox();
            lblName = new Label();
            lblDetails = new Label();
            lblPhoneNumber = new Label();
            pboxClick = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pboxProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxClick).BeginInit();
            SuspendLayout();
            // 
            // pboxProfile
            // 
            pboxProfile.BackColor = SystemColors.GradientActiveCaption;
            pboxProfile.Cursor = Cursors.Hand;
            pboxProfile.ForeColor = SystemColors.ControlText;
            pboxProfile.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            pboxProfile.IconColor = SystemColors.ControlText;
            pboxProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pboxProfile.IconSize = 154;
            pboxProfile.Location = new Point(29, 12);
            pboxProfile.Name = "pboxProfile";
            pboxProfile.Size = new Size(154, 154);
            pboxProfile.SizeMode = PictureBoxSizeMode.AutoSize;
            pboxProfile.TabIndex = 0;
            pboxProfile.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Cursor = Cursors.Hand;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(45, 93, 134);
            lblName.Location = new Point(29, 169);
            lblName.Name = "lblName";
            lblName.Size = new Size(154, 21);
            lblName.TabIndex = 1;
            lblName.Text = "Firstname Lastname";
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Cursor = Cursors.Hand;
            lblDetails.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetails.Location = new Point(29, 190);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(92, 17);
            lblDetails.TabIndex = 1;
            lblDetails.Text = "Title . Location";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Cursor = Cursors.Hand;
            lblPhoneNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(29, 207);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(87, 17);
            lblPhoneNumber.TabIndex = 2;
            lblPhoneNumber.Text = "+4512345678";
            // 
            // pboxClick
            // 
            pboxClick.BackColor = SystemColors.GradientInactiveCaption;
            pboxClick.Cursor = Cursors.Hand;
            pboxClick.Location = new Point(29, 160);
            pboxClick.Name = "pboxClick";
            pboxClick.Size = new Size(154, 64);
            pboxClick.TabIndex = 3;
            pboxClick.TabStop = false;
            // 
            // LawyerCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblName);
            Controls.Add(lblPhoneNumber);
            Controls.Add(pboxProfile);
            Controls.Add(lblDetails);
            Controls.Add(pboxClick);
            Firstname = "LawyerCard";
            Size = new Size(212, 240);
            ((System.ComponentModel.ISupportInitialize)pboxProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxClick).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox pboxProfile;
        private Label lblName;
        private Label lblDetails;
        private Label lblPhoneNumber;
        private PictureBox pboxClick;
    }
}
