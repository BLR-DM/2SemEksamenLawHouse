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
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            rtxtPhoneNumbers = new RichTextBox();
            lblPhoneNumbersView = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
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
            lblBeregninger.Location = new Point(761, 121);
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
            lblMustSubscribe.Location = new Point(733, 259);
            lblMustSubscribe.Name = "lblMustSubscribe";
            lblMustSubscribe.Size = new Size(99, 25);
            lblMustSubscribe.TabIndex = 6;
            lblMustSubscribe.Text = "Subscribe";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(rtxtPhoneNumbers);
            panel2.Controls.Add(lblPhoneNumbersView);
            panel2.Location = new Point(34, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(421, 519);
            panel2.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientInactiveCaption;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(45, 93, 134);
            label6.Location = new Point(16, 346);
            label6.Name = "label6";
            label6.Size = new Size(96, 21);
            label6.TabIndex = 43;
            label6.Text = "Subscribed:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientInactiveCaption;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(45, 93, 134);
            label5.Location = new Point(16, 278);
            label5.Name = "label5";
            label5.Size = new Size(42, 21);
            label5.TabIndex = 42;
            label5.Text = "City:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(45, 93, 134);
            label2.Location = new Point(16, 211);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 41;
            label2.Text = "Postal Code:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(45, 93, 134);
            label4.Location = new Point(16, 142);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 40;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(45, 93, 134);
            label3.Location = new Point(16, 77);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 39;
            label3.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 93, 134);
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 38;
            label1.Text = "Name:";
            // 
            // rtxtPhoneNumbers
            // 
            rtxtPhoneNumbers.Location = new Point(193, 414);
            rtxtPhoneNumbers.Name = "rtxtPhoneNumbers";
            rtxtPhoneNumbers.Size = new Size(183, 83);
            rtxtPhoneNumbers.TabIndex = 35;
            rtxtPhoneNumbers.Text = "";
            // 
            // lblPhoneNumbersView
            // 
            lblPhoneNumbersView.AutoSize = true;
            lblPhoneNumbersView.BackColor = SystemColors.GradientInactiveCaption;
            lblPhoneNumbersView.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPhoneNumbersView.ForeColor = Color.FromArgb(45, 93, 134);
            lblPhoneNumbersView.Location = new Point(16, 412);
            lblPhoneNumbersView.Name = "lblPhoneNumbersView";
            lblPhoneNumbersView.Size = new Size(131, 21);
            lblPhoneNumbersView.TabIndex = 34;
            lblPhoneNumbersView.Text = "Phone Numbers:";
            // 
            // MyPageView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(panel2);
            Controls.Add(lblMustSubscribe);
            Controls.Add(lblBeregninger);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MyPageView";
            Text = "MyPageView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label lblBeregninger;
        private Label lblMustSubscribe;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private RichTextBox rtxtPhoneNumbers;
        private Label lblPhoneNumbersView;
    }
}