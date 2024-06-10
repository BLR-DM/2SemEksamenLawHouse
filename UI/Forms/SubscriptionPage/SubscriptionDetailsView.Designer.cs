namespace UI.Forms.SubscriptionPage
{
    partial class SubscriptionDetailsView
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
            dgvSubscriptions = new DataGridView();
            label6 = new Label();
            lblSubscribed = new Label();
            lblHelp = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSubscriptions).BeginInit();
            SuspendLayout();
            // 
            // dgvSubscriptions
            // 
            dgvSubscriptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubscriptions.Location = new Point(37, 28);
            dgvSubscriptions.Name = "dgvSubscriptions";
            dgvSubscriptions.RowHeadersVisible = false;
            dgvSubscriptions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubscriptions.Size = new Size(443, 140);
            dgvSubscriptions.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientInactiveCaption;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(45, 93, 134);
            label6.Location = new Point(37, 202);
            label6.Name = "label6";
            label6.Size = new Size(96, 21);
            label6.TabIndex = 44;
            label6.Text = "Subscribed:";
            // 
            // lblSubscribed
            // 
            lblSubscribed.AutoSize = true;
            lblSubscribed.BackColor = SystemColors.GradientInactiveCaption;
            lblSubscribed.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSubscribed.ForeColor = Color.FromArgb(45, 93, 134);
            lblSubscribed.Location = new Point(139, 202);
            lblSubscribed.Name = "lblSubscribed";
            lblSubscribed.Size = new Size(63, 21);
            lblSubscribed.TabIndex = 49;
            lblSubscribed.Text = "Yes/No";
            // 
            // lblHelp
            // 
            lblHelp.AutoSize = true;
            lblHelp.Cursor = Cursors.Hand;
            lblHelp.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblHelp.ForeColor = Color.DarkBlue;
            lblHelp.Location = new Point(437, 238);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(66, 15);
            lblHelp.TabIndex = 76;
            lblHelp.Text = "Need help?";
            // 
            // SubscriptionDetailsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(515, 262);
            Controls.Add(lblHelp);
            Controls.Add(lblSubscribed);
            Controls.Add(label6);
            Controls.Add(dgvSubscriptions);
            Name = "SubscriptionDetailsView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SubscriptionDetailsView";
            ((System.ComponentModel.ISupportInitialize)dgvSubscriptions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSubscriptions;
        private Label label6;
        private Label lblSubscribed;
        private Label lblHelp;
    }
}