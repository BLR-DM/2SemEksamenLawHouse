namespace UI.Forms.EmployeePage
{
    partial class EmployeesOverview
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
            dgvEmployees = new DataGridView();
            cboxShow = new ComboBox();
            lblShow = new Label();
            lblSort = new Label();
            cboxSort = new ComboBox();
            lblCurrentlyShowing = new Label();
            lblTotalEmployees = new Label();
            lblFilter = new Label();
            cboxFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(12, 131);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowTemplate.ReadOnly = true;
            dgvEmployees.Size = new Size(974, 445);
            dgvEmployees.TabIndex = 0;
            // 
            // cboxShow
            // 
            cboxShow.BackColor = SystemColors.GradientInactiveCaption;
            cboxShow.Cursor = Cursors.Hand;
            cboxShow.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxShow.FlatStyle = FlatStyle.Flat;
            cboxShow.FormattingEnabled = true;
            cboxShow.Location = new Point(76, 17);
            cboxShow.Name = "cboxShow";
            cboxShow.Size = new Size(152, 23);
            cboxShow.TabIndex = 1;
            // 
            // lblShow
            // 
            lblShow.Anchor = AnchorStyles.Top;
            lblShow.AutoSize = true;
            lblShow.BackColor = SystemColors.GradientInactiveCaption;
            lblShow.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblShow.ForeColor = Color.FromArgb(45, 93, 134);
            lblShow.Location = new Point(13, 18);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(47, 19);
            lblShow.TabIndex = 4;
            lblShow.Text = "Show:";
            // 
            // lblSort
            // 
            lblSort.Anchor = AnchorStyles.Top;
            lblSort.AutoSize = true;
            lblSort.BackColor = SystemColors.GradientInactiveCaption;
            lblSort.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSort.ForeColor = Color.FromArgb(45, 93, 134);
            lblSort.Location = new Point(276, 21);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(57, 19);
            lblSort.TabIndex = 4;
            lblSort.Text = "Sort by:";
            // 
            // cboxSort
            // 
            cboxSort.BackColor = SystemColors.GradientInactiveCaption;
            cboxSort.Cursor = Cursors.Hand;
            cboxSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxSort.FlatStyle = FlatStyle.Flat;
            cboxSort.FormattingEnabled = true;
            cboxSort.Location = new Point(339, 20);
            cboxSort.Name = "cboxSort";
            cboxSort.Size = new Size(152, 23);
            cboxSort.TabIndex = 8;
            // 
            // lblCurrentlyShowing
            // 
            lblCurrentlyShowing.Anchor = AnchorStyles.Top;
            lblCurrentlyShowing.AutoSize = true;
            lblCurrentlyShowing.BackColor = SystemColors.GradientInactiveCaption;
            lblCurrentlyShowing.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblCurrentlyShowing.ForeColor = Color.FromArgb(45, 93, 134);
            lblCurrentlyShowing.Location = new Point(13, 103);
            lblCurrentlyShowing.Name = "lblCurrentlyShowing";
            lblCurrentlyShowing.Size = new Size(104, 25);
            lblCurrentlyShowing.TabIndex = 4;
            lblCurrentlyShowing.Text = "Employees";
            // 
            // lblTotalEmployees
            // 
            lblTotalEmployees.Anchor = AnchorStyles.Top;
            lblTotalEmployees.BackColor = SystemColors.GradientInactiveCaption;
            lblTotalEmployees.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTotalEmployees.ForeColor = Color.FromArgb(45, 93, 134);
            lblTotalEmployees.Location = new Point(438, 102);
            lblTotalEmployees.Name = "lblTotalEmployees";
            lblTotalEmployees.Size = new Size(122, 25);
            lblTotalEmployees.TabIndex = 4;
            lblTotalEmployees.Text = "Employees";
            lblTotalEmployees.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblFilter
            // 
            lblFilter.Anchor = AnchorStyles.Top;
            lblFilter.AutoSize = true;
            lblFilter.BackColor = SystemColors.GradientInactiveCaption;
            lblFilter.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblFilter.ForeColor = Color.FromArgb(45, 93, 134);
            lblFilter.Location = new Point(15, 53);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(45, 19);
            lblFilter.TabIndex = 4;
            lblFilter.Text = "Filter:";
            // 
            // cboxFilter
            // 
            cboxFilter.BackColor = SystemColors.GradientInactiveCaption;
            cboxFilter.Cursor = Cursors.Hand;
            cboxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxFilter.FlatStyle = FlatStyle.Flat;
            cboxFilter.FormattingEnabled = true;
            cboxFilter.Location = new Point(76, 52);
            cboxFilter.Name = "cboxFilter";
            cboxFilter.Size = new Size(152, 23);
            cboxFilter.TabIndex = 1;
            // 
            // EmployeesOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(cboxSort);
            Controls.Add(cboxFilter);
            Controls.Add(cboxShow);
            Controls.Add(dgvEmployees);
            Controls.Add(lblTotalEmployees);
            Controls.Add(lblFilter);
            Controls.Add(lblCurrentlyShowing);
            Controls.Add(lblShow);
            Controls.Add(lblSort);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeesOverview";
            Text = "EmployeesManage";
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployees;
        private Label lblCurrentlyShowing;
        private ListBox listBox1;
        private ComboBox cboxShow;
        private Label lblShow;
        private Label lblSort;
        private ComboBox cboxSort;
        private Label lblTotalEmployees;
        private Label lblFilter;
        private ComboBox cboxFilter;
    }
}