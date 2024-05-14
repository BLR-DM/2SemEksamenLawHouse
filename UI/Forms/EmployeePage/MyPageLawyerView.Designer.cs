namespace UI.Forms.EmployeePage
{
    partial class MyPageLawyerView
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
            dgvCases = new DataGridView();
            dgvServices = new DataGridView();
            chboxShowAll = new CheckBox();
            lblTask = new Label();
            btnEditDetails = new FontAwesome.Sharp.IconButton();
            pnlLawyerDetails = new Panel();
            pnlEdit = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCases).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
            // 
            // dgvCases
            // 
            dgvCases.AllowUserToAddRows = false;
            dgvCases.AllowUserToDeleteRows = false;
            dgvCases.AllowUserToResizeColumns = false;
            dgvCases.AllowUserToResizeRows = false;
            dgvCases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCases.Location = new Point(331, 12);
            dgvCases.Name = "dgvCases";
            dgvCases.ReadOnly = true;
            dgvCases.Size = new Size(655, 254);
            dgvCases.TabIndex = 1;
            // 
            // dgvServices
            // 
            dgvServices.AllowUserToAddRows = false;
            dgvServices.AllowUserToDeleteRows = false;
            dgvServices.AllowUserToResizeColumns = false;
            dgvServices.AllowUserToResizeRows = false;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(331, 311);
            dgvServices.Name = "dgvServices";
            dgvServices.ReadOnly = true;
            dgvServices.Size = new Size(655, 291);
            dgvServices.TabIndex = 1;
            // 
            // chboxShowAll
            // 
            chboxShowAll.AutoSize = true;
            chboxShowAll.Location = new Point(370, 292);
            chboxShowAll.Name = "chboxShowAll";
            chboxShowAll.Size = new Size(72, 19);
            chboxShowAll.TabIndex = 2;
            chboxShowAll.Text = "Show All";
            chboxShowAll.UseVisualStyleBackColor = true;
            // 
            // lblTask
            // 
            lblTask.AutoSize = true;
            lblTask.Location = new Point(331, 293);
            lblTask.Name = "lblTask";
            lblTask.Size = new Size(34, 15);
            lblTask.TabIndex = 0;
            lblTask.Text = "Tasks";
            // 
            // btnEditDetails
            // 
            btnEditDetails.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEditDetails.IconColor = Color.Black;
            btnEditDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditDetails.Location = new Point(126, 563);
            btnEditDetails.Name = "btnEditDetails";
            btnEditDetails.Size = new Size(75, 23);
            btnEditDetails.TabIndex = 3;
            btnEditDetails.Text = "Edit details";
            btnEditDetails.UseVisualStyleBackColor = true;
            // 
            // pnlLawyerDetails
            // 
            pnlLawyerDetails.Location = new Point(12, 57);
            pnlLawyerDetails.Name = "pnlLawyerDetails";
            pnlLawyerDetails.Size = new Size(283, 451);
            pnlLawyerDetails.TabIndex = 4;
            // 
            // pnlEdit
            // 
            pnlEdit.Location = new Point(2, 34);
            pnlEdit.Name = "pnlEdit";
            pnlEdit.Size = new Size(323, 523);
            pnlEdit.TabIndex = 5;
            // 
            // MyPageLawyerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(pnlEdit);
            Controls.Add(pnlLawyerDetails);
            Controls.Add(btnEditDetails);
            Controls.Add(chboxShowAll);
            Controls.Add(dgvServices);
            Controls.Add(lblTask);
            Controls.Add(dgvCases);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MyPageLawyerView";
            Tag = "My page";
            Text = "MyPageLawyerView";
            ((System.ComponentModel.ISupportInitialize)dgvCases).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvCases;
        private DataGridView dgvServices;
        private CheckBox chboxShowAll;
        private Label lblTask;
        private FontAwesome.Sharp.IconButton btnEditDetails;
        private Panel pnlLawyerDetails;
        private Panel pnlEdit;
    }
}