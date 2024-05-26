namespace UI.Forms.CasePage
{
    partial class AddClientView
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
            dgvClientView = new DataGridView();
            txtSearch = new TextBox();
            lblName = new Label();
            lblHelp = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientView).BeginInit();
            SuspendLayout();
            // 
            // dgvClientView
            // 
            dgvClientView.AllowUserToAddRows = false;
            dgvClientView.AllowUserToDeleteRows = false;
            dgvClientView.AllowUserToResizeColumns = false;
            dgvClientView.AllowUserToResizeRows = false;
            dgvClientView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientView.Location = new Point(12, 55);
            dgvClientView.MultiSelect = false;
            dgvClientView.Name = "dgvClientView";
            dgvClientView.ReadOnly = true;
            dgvClientView.Size = new Size(753, 320);
            dgvClientView.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(307, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Phonenumber";
            txtSearch.Size = new Size(164, 23);
            txtSearch.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.GradientInactiveCaption;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(45, 93, 134);
            lblName.Location = new Point(238, 26);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 21);
            lblName.TabIndex = 40;
            lblName.Text = "Search:";
            // 
            // lblHelp
            // 
            lblHelp.AutoSize = true;
            lblHelp.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblHelp.ForeColor = Color.DarkBlue;
            lblHelp.Location = new Point(699, 378);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(66, 15);
            lblHelp.TabIndex = 53;
            lblHelp.Text = "Need help?";
            // 
            // AddClientView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(777, 399);
            Controls.Add(lblHelp);
            Controls.Add(lblName);
            Controls.Add(txtSearch);
            Controls.Add(dgvClientView);
            Name = "AddClientView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddClientView";
            ((System.ComponentModel.ISupportInitialize)dgvClientView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientView;
        private TextBox txtSearch;
        private Label lblName;
        private Label lblHelp;
    }
}