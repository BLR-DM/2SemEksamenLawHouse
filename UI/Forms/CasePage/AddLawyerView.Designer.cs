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
            lblHelp = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLawyerView).BeginInit();
            SuspendLayout();
            // 
            // dgvLawyerView
            // 
            dgvLawyerView.AllowUserToAddRows = false;
            dgvLawyerView.AllowUserToDeleteRows = false;
            dgvLawyerView.AllowUserToResizeColumns = false;
            dgvLawyerView.AllowUserToResizeRows = false;
            dgvLawyerView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLawyerView.Location = new Point(12, 55);
            dgvLawyerView.MultiSelect = false;
            dgvLawyerView.Name = "dgvLawyerView";
            dgvLawyerView.ReadOnly = true;
            dgvLawyerView.Size = new Size(753, 321);
            dgvLawyerView.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(81, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Phonenumber";
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
            cboSpecialities.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSpecialities.FormattingEnabled = true;
            cboSpecialities.Location = new Point(611, 26);
            cboSpecialities.Name = "cboSpecialities";
            cboSpecialities.Size = new Size(154, 23);
            cboSpecialities.TabIndex = 42;
            // 
            // lblHelp
            // 
            lblHelp.AutoSize = true;
            lblHelp.Cursor = Cursors.Hand;
            lblHelp.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblHelp.ForeColor = Color.DarkBlue;
            lblHelp.Location = new Point(699, 379);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(66, 15);
            lblHelp.TabIndex = 53;
            lblHelp.Text = "Need help?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 93, 134);
            label1.Location = new Point(466, 24);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 54;
            label1.Text = "Sort by speciality:";
            // 
            // AddLawyerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(777, 399);
            Controls.Add(label1);
            Controls.Add(lblHelp);
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
        private Label lblHelp;
        private Label label1;
    }
}