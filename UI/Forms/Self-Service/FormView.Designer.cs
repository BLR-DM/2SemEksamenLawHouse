namespace UI.Forms.Self_Service
{
    partial class FormView
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
            dgvForms = new DataGridView();
            dgvBoughtForms = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvForms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBoughtForms).BeginInit();
            SuspendLayout();
            // 
            // dgvForms
            // 
            dgvForms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvForms.Location = new Point(41, 77);
            dgvForms.Name = "dgvForms";
            dgvForms.Size = new Size(290, 445);
            dgvForms.TabIndex = 0;
            // 
            // dgvBoughtForms
            // 
            dgvBoughtForms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoughtForms.Location = new Point(625, 77);
            dgvBoughtForms.Name = "dgvBoughtForms";
            dgvBoughtForms.Size = new Size(290, 445);
            dgvBoughtForms.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 93, 134);
            label1.Location = new Point(145, 44);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 41;
            label1.Text = "Forms";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(45, 93, 134);
            label2.Location = new Point(714, 44);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 41;
            label2.Text = "Bought forms";
            // 
            // FormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvBoughtForms);
            Controls.Add(dgvForms);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormView";
            Text = "FormularView";
            ((System.ComponentModel.ISupportInitialize)dgvForms).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBoughtForms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvForms;
        private DataGridView dgvBoughtForms;
        private Label label1;
        private Label label2;
    }
}