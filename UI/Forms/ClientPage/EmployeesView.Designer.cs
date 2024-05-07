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
            dgv = new DataGridView();
            lblName = new Label();
            lblDetails = new Label();
            flpnlLawyers = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(24, 462);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.Size = new Size(949, 118);
            dgv.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(45, 93, 134);
            lblName.Location = new Point(24, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 21);
            lblName.TabIndex = 1;
            lblName.Text = "name";
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetails.Location = new Point(24, 41);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(40, 17);
            lblDetails.TabIndex = 1;
            lblDetails.Text = "name";
            // 
            // flpnlLawyers
            // 
            flpnlLawyers.Location = new Point(24, 78);
            flpnlLawyers.Name = "flpnlLawyers";
            flpnlLawyers.Size = new Size(949, 366);
            flpnlLawyers.TabIndex = 2;
            // 
            // EmployeesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(flpnlLawyers);
            Controls.Add(lblDetails);
            Controls.Add(lblName);
            Controls.Add(dgv);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeesView";
            Text = "EmployeesView";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Label lblName;
        private Label lblDetails;
        private FlowLayoutPanel flpnlLawyers;
    }
}