namespace UI.Forms.EmployeePage
{
    partial class LawyerDetailsView
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
            chboxServicesShowAll = new CheckBox();
            btnEditDetails = new FontAwesome.Sharp.IconButton();
            pnlLawyerDetails = new Panel();
            pnlEdit = new Panel();
            btnCancel = new FontAwesome.Sharp.IconButton();
            chboxCasesShowAll = new CheckBox();
            lblCases = new Label();
            lblServices = new Label();
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
            dgvCases.Location = new Point(331, 34);
            dgvCases.MultiSelect = false;
            dgvCases.Name = "dgvCases";
            dgvCases.ReadOnly = true;
            dgvCases.Size = new Size(655, 265);
            dgvCases.TabIndex = 1;
            // 
            // dgvServices
            // 
            dgvServices.AllowUserToAddRows = false;
            dgvServices.AllowUserToDeleteRows = false;
            dgvServices.AllowUserToResizeColumns = false;
            dgvServices.AllowUserToResizeRows = false;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(331, 337);
            dgvServices.MultiSelect = false;
            dgvServices.Name = "dgvServices";
            dgvServices.ReadOnly = true;
            dgvServices.Size = new Size(655, 265);
            dgvServices.TabIndex = 1;
            // 
            // chboxServicesShowAll
            // 
            chboxServicesShowAll.AutoSize = true;
            chboxServicesShowAll.Location = new Point(331, 317);
            chboxServicesShowAll.Name = "chboxServicesShowAll";
            chboxServicesShowAll.Size = new Size(72, 19);
            chboxServicesShowAll.TabIndex = 2;
            chboxServicesShowAll.Text = "Show All";
            chboxServicesShowAll.UseVisualStyleBackColor = true;
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
            pnlLawyerDetails.Location = new Point(15, 12);
            pnlLawyerDetails.Name = "pnlLawyerDetails";
            pnlLawyerDetails.Size = new Size(283, 545);
            pnlLawyerDetails.TabIndex = 4;
            // 
            // pnlEdit
            // 
            pnlEdit.Location = new Point(2, 15);
            pnlEdit.Name = "pnlEdit";
            pnlEdit.Size = new Size(323, 539);
            pnlEdit.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackgroundImageLayout = ImageLayout.None;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(45, 93, 134);
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancel.IconColor = Color.Black;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.Location = new Point(56, 563);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(58, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // chboxCasesShowAll
            // 
            chboxCasesShowAll.AutoSize = true;
            chboxCasesShowAll.Location = new Point(331, 15);
            chboxCasesShowAll.Name = "chboxCasesShowAll";
            chboxCasesShowAll.Size = new Size(72, 19);
            chboxCasesShowAll.TabIndex = 2;
            chboxCasesShowAll.Text = "Show All";
            chboxCasesShowAll.UseVisualStyleBackColor = true;
            // 
            // lblCases
            // 
            lblCases.Anchor = AnchorStyles.Top;
            lblCases.BackColor = SystemColors.GradientInactiveCaption;
            lblCases.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblCases.ForeColor = Color.FromArgb(45, 93, 134);
            lblCases.Location = new Point(597, 6);
            lblCases.Name = "lblCases";
            lblCases.Size = new Size(122, 25);
            lblCases.TabIndex = 15;
            lblCases.Text = "Cases";
            lblCases.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblServices
            // 
            lblServices.Anchor = AnchorStyles.Top;
            lblServices.BackColor = SystemColors.GradientInactiveCaption;
            lblServices.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblServices.ForeColor = Color.FromArgb(45, 93, 134);
            lblServices.Location = new Point(597, 309);
            lblServices.Name = "lblServices";
            lblServices.Size = new Size(122, 25);
            lblServices.TabIndex = 15;
            lblServices.Text = "Case Services";
            lblServices.TextAlign = ContentAlignment.BottomCenter;
            // 
            // LawyerDetailsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(lblServices);
            Controls.Add(lblCases);
            Controls.Add(btnCancel);
            Controls.Add(pnlEdit);
            Controls.Add(pnlLawyerDetails);
            Controls.Add(btnEditDetails);
            Controls.Add(chboxCasesShowAll);
            Controls.Add(chboxServicesShowAll);
            Controls.Add(dgvServices);
            Controls.Add(dgvCases);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LawyerDetailsView";
            Tag = "";
            Text = "MyPageLawyerView";
            ((System.ComponentModel.ISupportInitialize)dgvCases).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvCases;
        private DataGridView dgvServices;
        private CheckBox chboxServicesShowAll;
        private FontAwesome.Sharp.IconButton btnEditDetails;
        private Panel pnlLawyerDetails;
        private Panel pnlEdit;
        private FontAwesome.Sharp.IconButton btnCancel;
        private CheckBox chboxCasesShowAll;
        private Label lblCases;
        private Label lblServices;
    }
}