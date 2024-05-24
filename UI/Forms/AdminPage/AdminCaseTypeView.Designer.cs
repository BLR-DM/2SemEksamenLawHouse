namespace UI.Forms.AdminPage
{
    partial class AdminCaseTypeView
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
            dgvCaseType = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCaseType).BeginInit();
            SuspendLayout();
            // 
            // dgvCaseType
            // 
            dgvCaseType.AllowUserToAddRows = false;
            dgvCaseType.AllowUserToDeleteRows = false;
            dgvCaseType.AllowUserToResizeColumns = false;
            dgvCaseType.AllowUserToResizeRows = false;
            dgvCaseType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaseType.Location = new Point(12, 64);
            dgvCaseType.Name = "dgvCaseType";
            dgvCaseType.ReadOnly = true;
            dgvCaseType.Size = new Size(207, 305);
            dgvCaseType.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 32);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 4;
            label1.Text = "Double click a casetype";
            // 
            // AdminCaseTypeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(231, 380);
            Controls.Add(label1);
            Controls.Add(dgvCaseType);
            Name = "AdminCaseTypeView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AdminCaseTypeView";
            ((System.ComponentModel.ISupportInitialize)dgvCaseType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCaseType;
        private Label label1;
    }
}