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
            lblSearch = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLawyerView).BeginInit();
            SuspendLayout();
            // 
            // dgvLawyerView
            // 
            dgvLawyerView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLawyerView.Location = new Point(12, 55);
            dgvLawyerView.Name = "dgvLawyerView";
            dgvLawyerView.Size = new Size(735, 332);
            dgvLawyerView.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(12, 29);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Search:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 3;
            // 
            // AddLawyerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(759, 399);
            Controls.Add(lblSearch);
            Controls.Add(textBox1);
            Controls.Add(dgvLawyerView);
            Name = "AddLawyerView";
            Text = "AddLawyerView";
            ((System.ComponentModel.ISupportInitialize)dgvLawyerView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLawyerView;
        private Label lblSearch;
        private TextBox textBox1;
    }
}