namespace UI.Forms.AdminPage
{
    partial class AdminServiceView
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
            dgvServiceList = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvServiceList).BeginInit();
            SuspendLayout();
            // 
            // dgvServiceList
            // 
            dgvServiceList.AllowUserToAddRows = false;
            dgvServiceList.AllowUserToDeleteRows = false;
            dgvServiceList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiceList.Location = new Point(24, 61);
            dgvServiceList.Name = "dgvServiceList";
            dgvServiceList.ReadOnly = true;
            dgvServiceList.Size = new Size(294, 342);
            dgvServiceList.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 31);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 3;
            label1.Text = "Double click a service";
            // 
            // AdminServiceView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(343, 426);
            Controls.Add(label1);
            Controls.Add(dgvServiceList);
            Name = "AdminServiceView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AdminServiceView";
            ((System.ComponentModel.ISupportInitialize)dgvServiceList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvServiceList;
        private Label label1;
    }
}