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
            textBox1 = new TextBox();
            lblName = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvLawyerView).BeginInit();
            SuspendLayout();
            // 
            // dgvLawyerView
            // 
            dgvLawyerView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLawyerView.Location = new Point(12, 55);
            dgvLawyerView.Name = "dgvLawyerView";
            dgvLawyerView.Size = new Size(753, 332);
            dgvLawyerView.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.GradientInactiveCaption;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(45, 93, 134);
            lblName.Location = new Point(12, 24);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 21);
            lblName.TabIndex = 41;
            lblName.Text = "Search:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(611, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 23);
            comboBox1.TabIndex = 42;
            // 
            // AddLawyerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(777, 399);
            Controls.Add(comboBox1);
            Controls.Add(lblName);
            Controls.Add(textBox1);
            Controls.Add(dgvLawyerView);
            Name = "AddLawyerView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddLawyerView";
            ((System.ComponentModel.ISupportInitialize)dgvLawyerView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLawyerView;
        private TextBox textBox1;
        private Label lblName;
        private ComboBox comboBox1;
    }
}