namespace UI.Forms.ClientPage
{
    partial class MyPageView
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
            dataGridView1 = new DataGridView();
            lblBeregninger = new Label();
            lblMustSubscribe = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(681, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(271, 352);
            dataGridView1.TabIndex = 11;
            // 
            // lblBeregninger
            // 
            lblBeregninger.Anchor = AnchorStyles.Top;
            lblBeregninger.AutoSize = true;
            lblBeregninger.BackColor = SystemColors.GradientActiveCaption;
            lblBeregninger.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBeregninger.ForeColor = Color.FromArgb(45, 93, 134);
            lblBeregninger.Location = new Point(753, 121);
            lblBeregninger.Name = "lblBeregninger";
            lblBeregninger.Size = new Size(119, 25);
            lblBeregninger.TabIndex = 6;
            lblBeregninger.Text = "Calculations";
            // 
            // lblMustSubscribe
            // 
            lblMustSubscribe.Anchor = AnchorStyles.Top;
            lblMustSubscribe.AutoSize = true;
            lblMustSubscribe.BackColor = SystemColors.ControlDark;
            lblMustSubscribe.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMustSubscribe.ForeColor = Color.FromArgb(45, 93, 134);
            lblMustSubscribe.Location = new Point(725, 259);
            lblMustSubscribe.Name = "lblMustSubscribe";
            lblMustSubscribe.Size = new Size(99, 25);
            lblMustSubscribe.TabIndex = 6;
            lblMustSubscribe.Text = "Subscribe";
            // 
            // MyPageView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(982, 574);
            Controls.Add(lblMustSubscribe);
            Controls.Add(lblBeregninger);
            Controls.Add(dataGridView1);
            Name = "MyPageView";
            Text = "MyPageView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label lblBeregninger;
        private Label lblMustSubscribe;
    }
}