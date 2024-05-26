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
            dtpStartDate = new DateTimePicker();
            lblStartDate = new Label();
            txtCaseType = new TextBox();
            dtpEstimatedEndDate = new DateTimePicker();
            btnUpdateCase = new Button();
            lblEstimatedEndDate = new Label();
            lblStatus = new Label();
            lblStatusHeadline = new Label();
            lblTotalHours = new Label();
            txtTotalHours = new TextBox();
            txtCaseID = new TextBox();
            lblCaseID = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            lblTotalPrice = new Label();
            txtTotalPrice = new TextBox();
            lblCaseInformation = new Label();
            label1 = new Label();
            txtEstimatedHours = new TextBox();
            lblEstimatedHours = new Label();
            txtEstimatedEndDate = new TextBox();
            txtTitle = new TextBox();
            lblTitle = new Label();
            btnPrintDetails = new Button();
            panel3 = new Panel();
            dgvServices = new DataGridView();
            lblServices = new Label();
            btnUpdateCaseStatus = new Button();
            lblHelp = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(285, 214);
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
            pnlLawyerInformation.Size = new Size(281, 206);
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
            panel1.Controls.Add(dtpStartDate);
            panel1.Controls.Add(lblStartDate);
            panel1.Controls.Add(txtCaseType);
            panel1.Controls.Add(dtpEstimatedEndDate);
            panel1.Controls.Add(btnUpdateCase);
            panel1.Controls.Add(lblEstimatedEndDate);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lblStatusHeadline);
            panel1.Controls.Add(lblTotalHours);
            panel1.Controls.Add(txtTotalHours);
            panel1.Controls.Add(txtCaseID);
            panel1.Controls.Add(lblCaseID);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(lblTotalPrice);
            panel1.Controls.Add(txtTotalPrice);
            panel1.Controls.Add(lblCaseInformation);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtEstimatedHours);
            panel1.Controls.Add(lblEstimatedHours);
            panel1.Controls.Add(txtEstimatedEndDate);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(687, 326);
            panel1.TabIndex = 15;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(273, 64);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(208, 23);
            dtpStartDate.TabIndex = 33;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.BackColor = SystemColors.GradientInactiveCaption;
            lblStartDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblStartDate.ForeColor = Color.FromArgb(45, 93, 134);
            lblStartDate.Location = new Point(273, 40);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(83, 21);
            lblStartDate.TabIndex = 32;
            lblStartDate.Text = "Start Date";
            // 
            // txtCaseType
            // 
            txtCaseType.BackColor = Color.White;
            txtCaseType.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCaseType.Location = new Point(104, 56);
            txtCaseType.MaxLength = 50;
            txtCaseType.Name = "txtCaseType";
            txtCaseType.Size = new Size(125, 27);
            txtCaseType.TabIndex = 31;
            // 
            // dtpEstimatedEndDate
            // 
            dtpEstimatedEndDate.Location = new Point(273, 123);
            dtpEstimatedEndDate.Name = "dtpEstimatedEndDate";
            dtpEstimatedEndDate.Size = new Size(208, 23);
            dtpEstimatedEndDate.TabIndex = 15;
            // 
            // btnUpdateCase
            // 
            btnUpdateCase.Location = new Point(569, 277);
            btnUpdateCase.Name = "btnUpdateCase";
            btnUpdateCase.Size = new Size(103, 33);
            btnUpdateCase.TabIndex = 20;
            btnUpdateCase.Text = "Update Case";
            btnUpdateCase.UseVisualStyleBackColor = true;
            // 
            // lblEstimatedEndDate
            // 
            lblEstimatedEndDate.AutoSize = true;
            lblEstimatedEndDate.BackColor = SystemColors.GradientInactiveCaption;
            lblEstimatedEndDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEstimatedEndDate.ForeColor = Color.FromArgb(45, 93, 134);
            lblEstimatedEndDate.Location = new Point(273, 98);
            lblEstimatedEndDate.Name = "lblEstimatedEndDate";
            lblEstimatedEndDate.Size = new Size(151, 21);
            lblEstimatedEndDate.TabIndex = 13;
            lblEstimatedEndDate.Text = "Estimated End Date";
            // 
            // lblStatus
            // 
            lblStatus.BackColor = SystemColors.GradientInactiveCaption;
            lblStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(594, 31);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(77, 21);
            lblStatus.TabIndex = 28;
            lblStatus.Text = "Closed";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatusHeadline
            // 
            lblStatusHeadline.AutoSize = true;
            lblStatusHeadline.BackColor = SystemColors.GradientInactiveCaption;
            lblStatusHeadline.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblStatusHeadline.ForeColor = Color.FromArgb(45, 93, 134);
            lblStatusHeadline.Location = new Point(585, 10);
            lblStatusHeadline.Name = "lblStatusHeadline";
            lblStatusHeadline.Size = new Size(91, 21);
            lblStatusHeadline.TabIndex = 27;
            lblStatusHeadline.Text = "Case status";
            // 
            // lblTotalHours
            // 
            lblTotalHours.AutoSize = true;
            lblTotalHours.BackColor = SystemColors.GradientInactiveCaption;
            lblTotalHours.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTotalHours.ForeColor = Color.FromArgb(45, 93, 134);
            lblTotalHours.Location = new Point(581, 166);
            lblTotalHours.Name = "lblTotalHours";
            lblTotalHours.Size = new Size(90, 21);
            lblTotalHours.TabIndex = 30;
            lblTotalHours.Text = "Total hours";
            // 
            // txtTotalHours
            // 
            txtTotalHours.BackColor = Color.White;
            txtTotalHours.BorderStyle = BorderStyle.None;
            txtTotalHours.Enabled = false;
            txtTotalHours.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalHours.Location = new Point(573, 189);
            txtTotalHours.MaxLength = 50;
            txtTotalHours.Name = "txtTotalHours";
            txtTotalHours.Size = new Size(97, 20);
            txtTotalHours.TabIndex = 29;
            txtTotalHours.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCaseID
            // 
            txtCaseID.BackColor = SystemColors.GradientInactiveCaption;
            txtCaseID.BorderStyle = BorderStyle.None;
            txtCaseID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCaseID.Location = new Point(125, 19);
            txtCaseID.MaxLength = 50;
            txtCaseID.Name = "txtCaseID";
            txtCaseID.ReadOnly = true;
            txtCaseID.Size = new Size(64, 20);
            txtCaseID.TabIndex = 26;
            txtCaseID.Text = "3";
            // 
            // lblCaseID
            // 
            lblCaseID.AutoSize = true;
            lblCaseID.BackColor = SystemColors.GradientInactiveCaption;
            lblCaseID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCaseID.ForeColor = Color.FromArgb(45, 93, 134);
            lblCaseID.Location = new Point(17, 18);
            lblCaseID.Name = "lblCaseID";
            lblCaseID.Size = new Size(106, 21);
            lblCaseID.TabIndex = 25;
            lblCaseID.Text = "Casenumber:";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(17, 186);
            txtDescription.MaxLength = 300;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(464, 124);
            txtDescription.TabIndex = 24;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = SystemColors.GradientInactiveCaption;
            lblDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(45, 93, 134);
            lblDescription.Location = new Point(17, 162);
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
            lblTotalPrice.Location = new Point(585, 222);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(86, 21);
            lblTotalPrice.TabIndex = 22;
            lblTotalPrice.Text = "Total price";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.BackColor = Color.White;
            txtTotalPrice.BorderStyle = BorderStyle.None;
            txtTotalPrice.Enabled = false;
            txtTotalPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalPrice.Location = new Point(569, 246);
            txtTotalPrice.MaxLength = 50;
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(101, 20);
            txtTotalPrice.TabIndex = 21;
            txtTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCaseInformation
            // 
            lblCaseInformation.AutoSize = true;
            lblCaseInformation.BackColor = SystemColors.GradientInactiveCaption;
            lblCaseInformation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCaseInformation.ForeColor = Color.FromArgb(45, 93, 134);
            lblCaseInformation.Location = new Point(280, 0);
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
            label1.Location = new Point(17, 58);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 17;
            label1.Text = "Casetype:";
            // 
            // txtEstimatedHours
            // 
            txtEstimatedHours.BackColor = Color.White;
            txtEstimatedHours.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstimatedHours.Location = new Point(619, 119);
            txtEstimatedHours.MaxLength = 50;
            txtEstimatedHours.Name = "txtEstimatedHours";
            txtEstimatedHours.Size = new Size(51, 27);
            txtEstimatedHours.TabIndex = 17;
            txtEstimatedHours.TextAlign = HorizontalAlignment.Right;
            // 
            // lblEstimatedHours
            // 
            lblEstimatedHours.AutoSize = true;
            lblEstimatedHours.BackColor = SystemColors.GradientInactiveCaption;
            lblEstimatedHours.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEstimatedHours.ForeColor = Color.FromArgb(45, 93, 134);
            lblEstimatedHours.Location = new Point(542, 95);
            lblEstimatedHours.Name = "lblEstimatedHours";
            lblEstimatedHours.Size = new Size(130, 21);
            lblEstimatedHours.TabIndex = 16;
            lblEstimatedHours.Text = "Estimated Hours";
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
            // txtTitle
            // 
            txtTitle.BackColor = Color.White;
            txtTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(17, 122);
            txtTitle.MaxLength = 50;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(212, 27);
            txtTitle.TabIndex = 12;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.GradientInactiveCaption;
            lblTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(45, 93, 134);
            lblTitle.Location = new Point(17, 98);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 21);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Title";
            // 
            // btnPrintDetails
            // 
            btnPrintDetails.Location = new Point(705, 560);
            btnPrintDetails.Name = "btnPrintDetails";
            btnPrintDetails.Size = new Size(116, 34);
            btnPrintDetails.TabIndex = 22;
            btnPrintDetails.Text = "Print Details";
            btnPrintDetails.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvServices);
            panel3.Controls.Add(btnAddService);
            panel3.Controls.Add(lblServices);
            panel3.Location = new Point(12, 344);
            panel3.Name = "panel3";
            panel3.Size = new Size(687, 257);
            panel3.TabIndex = 19;
            // 
            // dgvServices
            // 
            dgvServices.AllowUserToAddRows = false;
            dgvServices.AllowUserToDeleteRows = false;
            dgvServices.AllowUserToResizeColumns = false;
            dgvServices.AllowUserToResizeRows = false;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(17, 36);
            dgvServices.MultiSelect = false;
            dgvServices.Name = "dgvServices";
            dgvServices.ReadOnly = true;
            dgvServices.Size = new Size(655, 172);
            dgvServices.TabIndex = 22;
            // 
            // lblServices
            // 
            lblServices.AutoSize = true;
            lblServices.BackColor = SystemColors.GradientInactiveCaption;
            lblServices.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblServices.ForeColor = Color.FromArgb(45, 93, 134);
            lblServices.Location = new Point(316, 6);
            lblServices.Name = "lblServices";
            lblServices.Size = new Size(71, 21);
            lblServices.TabIndex = 21;
            lblServices.Text = "Services";
            // 
            // btnUpdateCaseStatus
            // 
            btnUpdateCaseStatus.Location = new Point(870, 560);
            btnUpdateCaseStatus.Name = "btnUpdateCaseStatus";
            btnUpdateCaseStatus.Size = new Size(116, 34);
            btnUpdateCaseStatus.TabIndex = 21;
            btnUpdateCaseStatus.Text = "Close case";
            btnUpdateCaseStatus.UseVisualStyleBackColor = true;
            // 
            // lblHelp
            // 
            lblHelp.AutoSize = true;
            lblHelp.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblHelp.ForeColor = Color.DarkBlue;
            lblHelp.Location = new Point(920, 597);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(66, 15);
            lblHelp.TabIndex = 53;
            lblHelp.Text = "Need help?";
            // 
            // CaseDetailsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(lblHelp);
            Controls.Add(btnUpdateCaseStatus);
            Controls.Add(btnPrintDetails);
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
            PerformLayout();
        }

        #endregion

        private Button btnAddService;
        private Panel pnlLawyerInformation;
        private Panel pnlClientInformation;
        private Panel panel1;
        private Label lblCaseInformation;
        private Label label1;
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
        private Button btnUpdateCaseStatus;
        private TextBox txtCaseID;
        private Label lblCaseID;
        private Label lblStatus;
        private Label lblStatusHeadline;
        private Button btnPrintDetails;
        private Label lblTotalHours;
        private TextBox txtTotalHours;
        private TextBox txtCaseType;
        private DateTimePicker dtpStartDate;
        private Label lblStartDate;
        private Label lblHelp;
    }
}