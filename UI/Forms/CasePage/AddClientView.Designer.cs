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
            textBox1 = new TextBox();
            lblSearch = new Label();
            pnlTopBar = new Panel();
            lblCreateCase = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientView).BeginInit();
            pnlTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientView
            // 
            dgvClientView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientView.Location = new Point(12, 107);
            dgvClientView.Name = "dgvClientView";
            dgvClientView.Size = new Size(759, 329);
            dgvClientView.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(12, 81);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search:";
            // 
            // pnlTopBar
            // 
            pnlTopBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTopBar.BackColor = SystemColors.GradientActiveCaption;
            pnlTopBar.Controls.Add(lblCreateCase);
            pnlTopBar.Location = new Point(12, 12);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(759, 49);
            pnlTopBar.TabIndex = 10;
            // 
            // lblCreateCase
            // 
            lblCreateCase.Anchor = AnchorStyles.Top;
            lblCreateCase.AutoSize = true;
            lblCreateCase.BackColor = SystemColors.GradientActiveCaption;
            lblCreateCase.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateCase.ForeColor = Color.FromArgb(45, 93, 134);
            lblCreateCase.Location = new Point(314, 13);
            lblCreateCase.Name = "lblCreateCase";
            lblCreateCase.Size = new Size(122, 25);
            lblCreateCase.TabIndex = 5;
            lblCreateCase.Text = "ADD CLIENT";
            // 
            // AddClientView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(783, 448);
            Controls.Add(pnlTopBar);
            Controls.Add(lblSearch);
            Controls.Add(textBox1);
            Controls.Add(dgvClientView);
            Name = "AddClientView";
            Text = "AddClientView";
            ((System.ComponentModel.ISupportInitialize)dgvClientView).EndInit();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientView;
        private TextBox textBox1;
        private Label lblSearch;
        private Panel pnlTopBar;
        private Label lblCreateCase;
    }
}