namespace UI.Forms.AdminPage
{
    partial class AdminCUDCaseType
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
            lblServiceName = new Label();
            txtCaseType = new TextBox();
            btnCreate = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // lblServiceName
            // 
            lblServiceName.AutoSize = true;
            lblServiceName.BackColor = SystemColors.GradientInactiveCaption;
            lblServiceName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblServiceName.ForeColor = Color.FromArgb(45, 93, 134);
            lblServiceName.Location = new Point(12, 46);
            lblServiceName.Name = "lblServiceName";
            lblServiceName.Size = new Size(77, 21);
            lblServiceName.TabIndex = 41;
            lblServiceName.Text = "Casetype";
            // 
            // txtCaseType
            // 
            txtCaseType.BackColor = Color.White;
            txtCaseType.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCaseType.Location = new Point(95, 44);
            txtCaseType.MaxLength = 50;
            txtCaseType.Name = "txtCaseType";
            txtCaseType.Size = new Size(200, 27);
            txtCaseType.TabIndex = 42;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Bottom;
            btnCreate.BackColor = Color.FromArgb(45, 93, 134);
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnCreate.ForeColor = Color.White;
            btnCreate.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCreate.IconColor = Color.Black;
            btnCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCreate.IconSize = 70;
            btnCreate.Location = new Point(91, 90);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(125, 38);
            btnCreate.TabIndex = 47;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // AdminCUDCaseType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(307, 140);
            Controls.Add(btnCreate);
            Controls.Add(txtCaseType);
            Controls.Add(lblServiceName);
            Name = "AdminCUDCaseType";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AdminCUDCaseType";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblServiceName;
        private TextBox txtCaseType;
        private FontAwesome.Sharp.IconButton btnCreate;
    }
}