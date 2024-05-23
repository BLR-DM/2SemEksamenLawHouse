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
            lblTotalEmployees = new Label();
            lblFilter = new Label();
            cboxFilter = new ComboBox();
            panel1 = new Panel();
            btnTrashSort = new FontAwesome.Sharp.IconButton();
            txtSearch = new TextBox();
            btnTrashFilter = new FontAwesome.Sharp.IconButton();
            flpnlFilters = new FlowLayoutPanel();
            lblSearch = new Label();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AllowUserToResizeColumns = false;
            dgvEmployees.AllowUserToResizeRows = false;
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
            cboxShow.Location = new Point(105, 125);
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
            lblShow.Location = new Point(52, 126);
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
            lblSort.Location = new Point(336, 23);
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
            cboxSort.Location = new Point(399, 22);
            cboxSort.Name = "cboxSort";
            cboxSort.Size = new Size(140, 23);
            cboxSort.TabIndex = 8;
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
            lblFilter.Location = new Point(27, 24);
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
            cboxFilter.Location = new Point(78, 22);
            cboxFilter.Name = "cboxFilter";
            cboxFilter.Size = new Size(142, 23);
            cboxFilter.Sorted = true;
            cboxFilter.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.CausesValidation = false;
            panel1.Controls.Add(btnTrashSort);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnTrashFilter);
            panel1.Controls.Add(flpnlFilters);
            panel1.Controls.Add(cboxSort);
            panel1.Controls.Add(cboxFilter);
            panel1.Controls.Add(lblFilter);
            panel1.Controls.Add(lblSearch);
            panel1.Controls.Add(lblSort);
            panel1.Location = new Point(25, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 76);
            panel1.TabIndex = 9;
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
            btnTrashSort.Location = new Point(545, 22);
            btnTrashSort.Name = "btnTrashSort";
            btnTrashSort.Size = new Size(27, 23);
            btnTrashSort.TabIndex = 11;
            btnTrashSort.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Location = new Point(787, 27);
            txtSearch.MaxLength = 15;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(131, 16);
            txtSearch.TabIndex = 0;
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
            btnTrashFilter.Location = new Point(226, 23);
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
            lblSearch.Location = new Point(727, 25);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(54, 19);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Search:";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.GradientInactiveCaption;
            btnRefresh.BackgroundImageLayout = ImageLayout.Center;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.ArrowsUpDownLeftRight;
            btnRefresh.IconColor = Color.FromArgb(45, 93, 134);
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 25;
            btnRefresh.Location = new Point(251, 123);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(30, 30);
            btnRefresh.TabIndex = 12;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // EmployeesOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(btnRefresh);
            Controls.Add(panel1);
            Controls.Add(cboxShow);
            Controls.Add(dgvEmployees);
            Controls.Add(lblShow);
            Controls.Add(lblTotalEmployees);
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
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnTrashSort;
        private FontAwesome.Sharp.IconButton btnRefresh;
    }
}