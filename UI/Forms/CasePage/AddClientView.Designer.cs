﻿namespace UI.Forms.CasePage
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
            ((System.ComponentModel.ISupportInitialize)dgvClientView).BeginInit();
            SuspendLayout();
            // 
            // dgvClientView
            // 
            dgvClientView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientView.Location = new Point(12, 55);
            dgvClientView.Name = "dgvClientView";
            dgvClientView.Size = new Size(735, 332);
            dgvClientView.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(12, 29);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search:";
            // 
            // AddClientView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(759, 399);
            Controls.Add(lblSearch);
            Controls.Add(textBox1);
            Controls.Add(dgvClientView);
            Name = "AddClientView";
            Text = "AddClientView";
            ((System.ComponentModel.ISupportInitialize)dgvClientView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientView;
        private TextBox textBox1;
        private Label lblSearch;
    }
}