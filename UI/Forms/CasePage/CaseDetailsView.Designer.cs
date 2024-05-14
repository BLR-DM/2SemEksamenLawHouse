namespace UI.Forms.CasePage
{
    partial class CaseDetailsView
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
            btnAddService = new Button();
            pnlLawyerInformation = new Panel();
            pnlClientInformation = new Panel();
            panel1 = new Panel();
            txtDescription = new TextBox();
            lblDescription = new Label();
            lblTotalPrice = new Label();
            txtTotalPrice = new TextBox();
            lblCaseInformation = new Label();
            label1 = new Label();
            cboxCaseType = new ComboBox();
            txtEstimatedHours = new TextBox();
            lblEstimatedHours = new Label();
            dtpEstimatedEndDate = new DateTimePicker();
            txtEstimatedEndDate = new TextBox();
            lblEstimatedEndDate = new Label();
            txtTitle = new TextBox();
            lblTitle = new Label();
            panel3 = new Panel();
            dgvServices = new DataGridView();
            lblServices = new Label();
            btnUpdateCase = new Button();
            btnCloseCase = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(271, 303);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(131, 35);
            btnAddService.TabIndex = 18;
            btnAddService.Text = "Add service";
            btnAddService.UseVisualStyleBackColor = true;
            // 
            // pnlLawyerInformation
            // 
            pnlLawyerInformation.BorderStyle = BorderStyle.FixedSingle;
            pnlLawyerInformation.Location = new Point(705, 344);
            pnlLawyerInformation.Name = "pnlLawyerInformation";
            pnlLawyerInformation.Size = new Size(281, 171);
            pnlLawyerInformation.TabIndex = 17;
            // 
            // pnlClientInformation
            // 
            pnlClientInformation.BorderStyle = BorderStyle.FixedSingle;
            pnlClientInformation.Location = new Point(705, 12);
            pnlClientInformation.Name = "pnlClientInformation";
            pnlClientInformation.Size = new Size(281, 326);
            pnlClientInformation.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(lblTotalPrice);
            panel1.Controls.Add(txtTotalPrice);
            panel1.Controls.Add(lblCaseInformation);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboxCaseType);
            panel1.Controls.Add(txtEstimatedHours);
            panel1.Controls.Add(lblEstimatedHours);
            panel1.Controls.Add(dtpEstimatedEndDate);
            panel1.Controls.Add(txtEstimatedEndDate);
            panel1.Controls.Add(lblEstimatedEndDate);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(687, 238);
            panel1.TabIndex = 15;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(271, 44);
            txtDescription.MaxLength = 300;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(411, 131);
            txtDescription.TabIndex = 24;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = SystemColors.GradientInactiveCaption;
            lblDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(45, 93, 134);
            lblDescription.Location = new Point(430, 20);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(94, 21);
            lblDescription.TabIndex = 23;
            lblDescription.Text = "Description";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.BackColor = SystemColors.GradientInactiveCaption;
            lblTotalPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTotalPrice.ForeColor = Color.FromArgb(45, 93, 134);
            lblTotalPrice.Location = new Point(515, 178);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(86, 21);
            lblTotalPrice.TabIndex = 22;
            lblTotalPrice.Text = "Total price";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.BackColor = Color.White;
            txtTotalPrice.Enabled = false;
            txtTotalPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalPrice.Location = new Point(515, 202);
            txtTotalPrice.MaxLength = 50;
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(167, 27);
            txtTotalPrice.TabIndex = 21;
            // 
            // lblCaseInformation
            // 
            lblCaseInformation.AutoSize = true;
            lblCaseInformation.BackColor = SystemColors.GradientInactiveCaption;
            lblCaseInformation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCaseInformation.ForeColor = Color.FromArgb(45, 93, 134);
            lblCaseInformation.Location = new Point(268, -4);
            lblCaseInformation.Name = "lblCaseInformation";
            lblCaseInformation.Size = new Size(134, 21);
            lblCaseInformation.TabIndex = 20;
            lblCaseInformation.Text = "Case information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 93, 134);
            label1.Location = new Point(3, 74);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 17;
            label1.Text = "Casetype";
            // 
            // cboxCaseType
            // 
            cboxCaseType.FormattingEnabled = true;
            cboxCaseType.Location = new Point(3, 98);
            cboxCaseType.Name = "cboxCaseType";
            cboxCaseType.Size = new Size(230, 23);
            cboxCaseType.TabIndex = 18;
            // 
            // txtEstimatedHours
            // 
            txtEstimatedHours.BackColor = Color.White;
            txtEstimatedHours.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstimatedHours.Location = new Point(3, 148);
            txtEstimatedHours.MaxLength = 50;
            txtEstimatedHours.Name = "txtEstimatedHours";
            txtEstimatedHours.Size = new Size(230, 27);
            txtEstimatedHours.TabIndex = 17;
            // 
            // lblEstimatedHours
            // 
            lblEstimatedHours.AutoSize = true;
            lblEstimatedHours.BackColor = SystemColors.GradientInactiveCaption;
            lblEstimatedHours.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEstimatedHours.ForeColor = Color.FromArgb(45, 93, 134);
            lblEstimatedHours.Location = new Point(3, 124);
            lblEstimatedHours.Name = "lblEstimatedHours";
            lblEstimatedHours.Size = new Size(130, 21);
            lblEstimatedHours.TabIndex = 16;
            lblEstimatedHours.Text = "Estimated Hours";
            // 
            // dtpEstimatedEndDate
            // 
            dtpEstimatedEndDate.Location = new Point(3, 199);
            dtpEstimatedEndDate.Name = "dtpEstimatedEndDate";
            dtpEstimatedEndDate.Size = new Size(230, 23);
            dtpEstimatedEndDate.TabIndex = 15;
            // 
            // txtEstimatedEndDate
            // 
            txtEstimatedEndDate.BackColor = Color.White;
            txtEstimatedEndDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstimatedEndDate.Location = new Point(17, 228);
            txtEstimatedEndDate.MaxLength = 50;
            txtEstimatedEndDate.Name = "txtEstimatedEndDate";
            txtEstimatedEndDate.Size = new Size(0, 27);
            txtEstimatedEndDate.TabIndex = 14;
            // 
            // lblEstimatedEndDate
            // 
            lblEstimatedEndDate.AutoSize = true;
            lblEstimatedEndDate.BackColor = SystemColors.GradientInactiveCaption;
            lblEstimatedEndDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEstimatedEndDate.ForeColor = Color.FromArgb(45, 93, 134);
            lblEstimatedEndDate.Location = new Point(3, 178);
            lblEstimatedEndDate.Name = "lblEstimatedEndDate";
            lblEstimatedEndDate.Size = new Size(178, 21);
            lblEstimatedEndDate.TabIndex = 13;
            lblEstimatedEndDate.Text = "Estimated End EndDate";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.White;
            txtTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(3, 44);
            txtTitle.MaxLength = 50;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(230, 27);
            txtTitle.TabIndex = 12;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.GradientInactiveCaption;
            lblTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(45, 93, 134);
            lblTitle.Location = new Point(3, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 21);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Title";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dgvServices);
            panel3.Controls.Add(btnAddService);
            panel3.Controls.Add(lblServices);
            panel3.Location = new Point(12, 256);
            panel3.Name = "panel3";
            panel3.Size = new Size(687, 345);
            panel3.TabIndex = 19;
            // 
            // dgvServices
            // 
            dgvServices.AllowUserToAddRows = false;
            dgvServices.AllowUserToDeleteRows = false;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(3, 34);
            dgvServices.Name = "dgvServices";
            dgvServices.ReadOnly = true;
            dgvServices.Size = new Size(679, 263);
            dgvServices.TabIndex = 22;
            // 
            // lblServices
            // 
            lblServices.AutoSize = true;
            lblServices.BackColor = SystemColors.GradientInactiveCaption;
            lblServices.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblServices.ForeColor = Color.FromArgb(45, 93, 134);
            lblServices.Location = new Point(304, 0);
            lblServices.Name = "lblServices";
            lblServices.Size = new Size(71, 21);
            lblServices.TabIndex = 21;
            lblServices.Text = "Services";
            // 
            // btnUpdateCase
            // 
            btnUpdateCase.Location = new Point(705, 560);
            btnUpdateCase.Name = "btnUpdateCase";
            btnUpdateCase.Size = new Size(143, 41);
            btnUpdateCase.TabIndex = 20;
            btnUpdateCase.Text = "Update Case information";
            btnUpdateCase.UseVisualStyleBackColor = true;
            // 
            // btnCloseCase
            // 
            btnCloseCase.Location = new Point(870, 560);
            btnCloseCase.Name = "btnCloseCase";
            btnCloseCase.Size = new Size(116, 41);
            btnCloseCase.TabIndex = 21;
            btnCloseCase.Text = "Close case";
            btnCloseCase.UseVisualStyleBackColor = true;
            // 
            // CaseDetailsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(btnCloseCase);
            Controls.Add(btnUpdateCase);
            Controls.Add(panel3);
            Controls.Add(pnlLawyerInformation);
            Controls.Add(pnlClientInformation);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CaseDetailsView";
            Text = "CaseDetailsView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddService;
        private Panel pnlLawyerInformation;
        private Panel pnlClientInformation;
        private Panel panel1;
        private Label lblCaseInformation;
        private Label label1;
        private ComboBox cboxCaseType;
        private TextBox txtEstimatedHours;
        private Label lblEstimatedHours;
        private DateTimePicker dtpEstimatedEndDate;
        private TextBox txtEstimatedEndDate;
        private Label lblEstimatedEndDate;
        private TextBox txtTitle;
        private Label lblTitle;
        private Panel panel3;
        private Label lblServices;
        private DataGridView dgvServices;
        private Button btnUpdateCase;
        private Label lblTotalPrice;
        private TextBox txtTotalPrice;
        private TextBox txtDescription;
        private Label lblDescription;
        private Button btnCloseCase;
    }
}