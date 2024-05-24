namespace UI.Forms.AdminPage
{
    partial class AdminSpecialityView
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
            dgvSpecialities = new DataGridView();
            lblText = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSpecialities).BeginInit();
            SuspendLayout();
            // 
            // dgvSpecialities
            // 
            dgvSpecialities.AllowUserToAddRows = false;
            dgvSpecialities.AllowUserToDeleteRows = false;
            dgvSpecialities.AllowUserToResizeColumns = false;
            dgvSpecialities.AllowUserToResizeRows = false;
            dgvSpecialities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSpecialities.Location = new Point(52, 55);
            dgvSpecialities.MultiSelect = false;
            dgvSpecialities.Name = "dgvSpecialities";
            dgvSpecialities.ReadOnly = true;
            dgvSpecialities.Size = new Size(173, 298);
            dgvSpecialities.TabIndex = 3;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(72, 24);
            lblText.Name = "lblText";
            lblText.Size = new Size(134, 15);
            lblText.TabIndex = 4;
            lblText.Text = "Double click a Speciality";
            // 
            // AdminSpecialityView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(279, 376);
            Controls.Add(lblText);
            Controls.Add(dgvSpecialities);
            Name = "AdminSpecialityView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AdminSpecialityView";
            ((System.ComponentModel.ISupportInitialize)dgvSpecialities).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSpecialities;
        private Label lblText;
    }
}