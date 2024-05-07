namespace UI.Forms.ClientPage
{
    partial class EmployeesView
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
            flpnlLawyers = new FlowLayoutPanel();
            lblSelected = new Label();
            lblLawyers = new Label();
            SuspendLayout();
            // 
            // flpnlLawyers
            // 
            flpnlLawyers.Location = new Point(11, 61);
            flpnlLawyers.Name = "flpnlLawyers";
            flpnlLawyers.Size = new Size(512, 540);
            flpnlLawyers.TabIndex = 2;
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSelected.ForeColor = Color.FromArgb(45, 93, 134);
            lblSelected.Location = new Point(792, 69);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(116, 21);
            lblSelected.TabIndex = 3;
            lblSelected.Text = "Selected (test)";
            // 
            // lblLawyers
            // 
            lblLawyers.Anchor = AnchorStyles.Top;
            lblLawyers.AutoSize = true;
            lblLawyers.BackColor = SystemColors.GradientInactiveCaption;
            lblLawyers.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLawyers.ForeColor = Color.FromArgb(45, 93, 134);
            lblLawyers.Location = new Point(38, 26);
            lblLawyers.Name = "lblLawyers";
            lblLawyers.Size = new Size(83, 25);
            lblLawyers.TabIndex = 4;
            lblLawyers.Text = "Lawyers";
            // 
            // EmployeesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(lblSelected);
            Controls.Add(flpnlLawyers);
            Controls.Add(lblLawyers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeesView";
            Text = "EmployeesView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flpnlLawyers;
        private Label lblSelected;
        private Label lblLawyers;
    }
}