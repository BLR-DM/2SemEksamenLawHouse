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
            panel1 = new Panel();
            lblMyPage = new Label();
            dataGridView1 = new DataGridView();
            lblBeregninger = new Label();
            lblMustSubscribe = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(lblMyPage);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 77);
            panel1.TabIndex = 10;
            // 
            // lblMyPage
            // 
            lblMyPage.Anchor = AnchorStyles.Top;
            lblMyPage.AutoSize = true;
            lblMyPage.BackColor = SystemColors.GradientActiveCaption;
            lblMyPage.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMyPage.ForeColor = Color.FromArgb(45, 93, 134);
            lblMyPage.Location = new Point(435, 25);
            lblMyPage.Name = "lblMyPage";
            lblMyPage.Size = new Size(89, 25);
            lblMyPage.TabIndex = 5;
            lblMyPage.Text = "My Page";
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
            Controls.Add(panel1);
            Name = "MyPageView";
            Text = "MyPageView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblMyPage;
        private DataGridView dataGridView1;
        private Label lblBeregninger;
        private Label lblMustSubscribe;
    }
}