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
            panel1 = new Panel();
            btnTrashFilter = new FontAwesome.Sharp.IconButton();
            flpnlFilters = new FlowLayoutPanel();
            lblSearch = new Label();
            textBox1 = new TextBox();
            btnTrashSort = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(25, 171);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowTemplate.ReadOnly = true;
            dgvEmployees.Size = new Size(948, 416);
            dgvEmployees.TabIndex = 0;
            // 
            // cboxShow
            // 
            cboxShow.BackColor = SystemColors.Window;
            cboxShow.Cursor = Cursors.Hand;
            cboxShow.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxShow.FormattingEnabled = true;
            cboxShow.Location = new Point(787, 22);
            cboxShow.Name = "cboxShow";
            cboxShow.Size = new Size(140, 23);
            cboxShow.TabIndex = 1;
            // 
            // lblShow
            // 
            lblShow.Anchor = AnchorStyles.Top;
            lblShow.AutoSize = true;
            lblShow.BackColor = Color.Transparent;
            lblShow.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblShow.ForeColor = SystemColors.ControlText;
            lblShow.Location = new Point(734, 23);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(47, 19);
            lblShow.TabIndex = 4;
            lblShow.Text = "Show:";
            // 
            // lblSort
            // 
            lblSort.Anchor = AnchorStyles.Top;
            lblSort.AutoSize = true;
            lblSort.BackColor = Color.Transparent;
            lblSort.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSort.ForeColor = SystemColors.ControlText;
            lblSort.Location = new Point(282, 23);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(57, 19);
            lblSort.TabIndex = 4;
            lblSort.Text = "Sort by:";
            // 
            // cboxSort
            // 
            cboxSort.BackColor = SystemColors.Window;
            cboxSort.Cursor = Cursors.Hand;
            cboxSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxSort.FormattingEnabled = true;
            cboxSort.Location = new Point(345, 22);
            cboxSort.Name = "cboxSort";
            cboxSort.Size = new Size(140, 23);
            cboxSort.TabIndex = 8;
            // 
            // lblCurrentlyShowing
            // 
            lblCurrentlyShowing.Anchor = AnchorStyles.Top;
            lblCurrentlyShowing.AutoSize = true;
            lblCurrentlyShowing.BackColor = SystemColors.GradientInactiveCaption;
            lblCurrentlyShowing.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblCurrentlyShowing.ForeColor = Color.FromArgb(45, 93, 134);
            lblCurrentlyShowing.Location = new Point(25, 121);
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
            lblTotalEmployees.Location = new Point(435, 120);
            lblTotalEmployees.Name = "lblTotalEmployees";
            lblTotalEmployees.Size = new Size(122, 25);
            lblTotalEmployees.TabIndex = 4;
            lblTotalEmployees.Text = "Loading...";
            lblTotalEmployees.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblFilter
            // 
            lblFilter.Anchor = AnchorStyles.Top;
            lblFilter.AutoSize = true;
            lblFilter.BackColor = Color.Transparent;
            lblFilter.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblFilter.ForeColor = SystemColors.ControlText;
            lblFilter.Location = new Point(26, 23);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(45, 19);
            lblFilter.TabIndex = 4;
            lblFilter.Text = "Filter:";
            // 
            // cboxFilter
            // 
            cboxFilter.BackColor = SystemColors.Window;
            cboxFilter.Cursor = Cursors.Hand;
            cboxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxFilter.FormattingEnabled = true;
            cboxFilter.Location = new Point(77, 22);
            cboxFilter.Name = "cboxFilter";
            cboxFilter.Size = new Size(140, 23);
            cboxFilter.Sorted = true;
            cboxFilter.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.CausesValidation = false;
            panel1.Controls.Add(btnTrashSort);
            panel1.Controls.Add(btnTrashFilter);
            panel1.Controls.Add(flpnlFilters);
            panel1.Controls.Add(cboxShow);
            panel1.Controls.Add(cboxSort);
            panel1.Controls.Add(lblShow);
            panel1.Controls.Add(cboxFilter);
            panel1.Controls.Add(lblFilter);
            panel1.Controls.Add(lblSort);
            panel1.Location = new Point(25, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 76);
            panel1.TabIndex = 9;
            // 
            // btnTrashFilter
            // 
            btnTrashFilter.BackColor = Color.Transparent;
            btnTrashFilter.BackgroundImageLayout = ImageLayout.Stretch;
            btnTrashFilter.Cursor = Cursors.Hand;
            btnTrashFilter.FlatAppearance.BorderSize = 0;
            btnTrashFilter.FlatStyle = FlatStyle.Flat;
            btnTrashFilter.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnTrashFilter.IconColor = Color.FromArgb(45, 93, 134);
            btnTrashFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTrashFilter.IconSize = 22;
            btnTrashFilter.Location = new Point(222, 22);
            btnTrashFilter.Name = "btnTrashFilter";
            btnTrashFilter.Size = new Size(27, 23);
            btnTrashFilter.TabIndex = 11;
            btnTrashFilter.UseVisualStyleBackColor = false;
            // 
            // flpnlFilters
            // 
            flpnlFilters.Location = new Point(3, 45);
            flpnlFilters.Name = "flpnlFilters";
            flpnlFilters.Size = new Size(942, 27);
            flpnlFilters.TabIndex = 10;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Top;
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSearch.ForeColor = SystemColors.ControlText;
            lblSearch.Location = new Point(752, 127);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(54, 19);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Search:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(812, 129);
            textBox1.MaxLength = 15;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 16);
            textBox1.TabIndex = 0;
            // 
            // btnTrashSort
            // 
            btnTrashSort.BackColor = Color.Transparent;
            btnTrashSort.BackgroundImageLayout = ImageLayout.Stretch;
            btnTrashSort.Cursor = Cursors.Hand;
            btnTrashSort.FlatAppearance.BorderSize = 0;
            btnTrashSort.FlatStyle = FlatStyle.Flat;
            btnTrashSort.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnTrashSort.IconColor = Color.FromArgb(45, 93, 134);
            btnTrashSort.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTrashSort.IconSize = 22;
            btnTrashSort.Location = new Point(491, 22);
            btnTrashSort.Name = "btnTrashSort";
            btnTrashSort.Size = new Size(27, 23);
            btnTrashSort.TabIndex = 11;
            btnTrashSort.UseVisualStyleBackColor = false;
            // 
            // EmployeesOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(dgvEmployees);
            Controls.Add(lblTotalEmployees);
            Controls.Add(lblCurrentlyShowing);
            Controls.Add(lblSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeesOverview";
            Text = "EmployeesManage";
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployees;
        private Label lblCurrentlyShowing;
        private ComboBox cboxShow;
        private Label lblShow;
        private Label lblSort;
        private ComboBox cboxSort;
        private Label lblTotalEmployees;
        private Label lblFilter;
        private ComboBox cboxFilter;
        private Panel panel1;
        private FlowLayoutPanel flpnlFilters;
        private FontAwesome.Sharp.IconButton btnTrashFilter;
        private Label lblSearch;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnTrashSort;
    }
}