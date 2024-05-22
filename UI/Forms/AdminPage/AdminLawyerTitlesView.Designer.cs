namespace UI.Forms.AdminPage
{
    partial class AdminLawyerTitlesView
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
            label1 = new Label();
            dgvTitles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTitles).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 24);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 4;
            label1.Text = "Double click a title";
            // 
            // dgvTitles
            // 
            dgvTitles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTitles.Location = new Point(53, 55);
            dgvTitles.Name = "dgvTitles";
            dgvTitles.Size = new Size(173, 298);
            dgvTitles.TabIndex = 3;
            // 
            // AdminLawyerTitlesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(279, 376);
            Controls.Add(label1);
            Controls.Add(dgvTitles);
            Name = "AdminLawyerTitlesView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AdminLawyerTitlesView";
            ((System.ComponentModel.ISupportInitialize)dgvTitles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvTitles;
    }
}