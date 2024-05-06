namespace UI.Forms.CasePage
{
    partial class AddLawyerView
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
            dgvLawyerView = new DataGridView();
            txtSearch = new TextBox();
            lblSearch = new Label();
            cboSpecialities = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvLawyerView).BeginInit();
            SuspendLayout();
            // 
            // dgvLawyerView
            // 
            dgvLawyerView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLawyerView.Location = new Point(12, 55);
            dgvLawyerView.Name = "dgvLawyerView";
            dgvLawyerView.Size = new Size(753, 332);
            dgvLawyerView.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(81, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(164, 23);
            txtSearch.TabIndex = 3;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = SystemColors.GradientInactiveCaption;
            lblSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(45, 93, 134);
            lblSearch.Location = new Point(12, 24);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(63, 21);
            lblSearch.TabIndex = 41;
            lblSearch.Text = "Search:";
            // 
            // cboSpecialities
            // 
            cboSpecialities.FormattingEnabled = true;
            cboSpecialities.Location = new Point(611, 26);
            cboSpecialities.Name = "cboSpecialities";
            cboSpecialities.Size = new Size(154, 23);
            cboSpecialities.TabIndex = 42;
            // 
            // AddLawyerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(777, 399);
            Controls.Add(cboSpecialities);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvLawyerView);
            Name = "AddLawyerView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddLawyerView";
            ((System.ComponentModel.ISupportInitialize)dgvLawyerView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLawyerView;
        private TextBox txtSearch;
        private Label lblSearch;
        private ComboBox cboSpecialities;
    }
}