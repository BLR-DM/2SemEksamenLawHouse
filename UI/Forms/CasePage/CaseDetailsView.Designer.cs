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
            panel4 = new Panel();
            txtLawyerPhone = new TextBox();
            label7 = new Label();
            txtLawyerLastName = new TextBox();
            txtLawyerFirstName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblAddLawyer = new Label();
            panel2 = new Panel();
            txtClientPostalCode = new TextBox();
            txtClientAddress = new TextBox();
            txtClientLastName = new TextBox();
            txtClientPhoneNumber1 = new TextBox();
            txtClientEmail = new TextBox();
            txtClientFirstname = new TextBox();
            lblPostal = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblMainPhone = new Label();
            lblLastname = new Label();
            lblFirstname = new Label();
            lblName = new Label();
            lblClientInformation = new Label();
            panel1 = new Panel();
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
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(163, 243);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(131, 35);
            btnAddService.TabIndex = 18;
            btnAddService.Text = "Add service";
            btnAddService.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtLawyerPhone);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(txtLawyerLastName);
            panel4.Controls.Add(txtLawyerFirstName);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(lblAddLawyer);
            panel4.Location = new Point(510, 383);
            panel4.Name = "panel4";
            panel4.Size = new Size(476, 171);
            panel4.TabIndex = 17;
            // 
            // txtLawyerPhone
            // 
            txtLawyerPhone.BackColor = Color.White;
            txtLawyerPhone.Enabled = false;
            txtLawyerPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLawyerPhone.Location = new Point(3, 114);
            txtLawyerPhone.MaxLength = 50;
            txtLawyerPhone.Name = "txtLawyerPhone";
            txtLawyerPhone.Size = new Size(230, 27);
            txtLawyerPhone.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientInactiveCaption;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(45, 93, 134);
            label7.Location = new Point(3, 90);
            label7.Name = "label7";
            label7.Size = new Size(117, 21);
            label7.TabIndex = 48;
            label7.Text = "Phone number";
            // 
            // txtLawyerLastName
            // 
            txtLawyerLastName.BackColor = Color.White;
            txtLawyerLastName.Enabled = false;
            txtLawyerLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLawyerLastName.Location = new Point(242, 46);
            txtLawyerLastName.MaxLength = 50;
            txtLawyerLastName.Name = "txtLawyerLastName";
            txtLawyerLastName.Size = new Size(230, 27);
            txtLawyerLastName.TabIndex = 41;
            // 
            // txtLawyerFirstName
            // 
            txtLawyerFirstName.BackColor = Color.White;
            txtLawyerFirstName.Enabled = false;
            txtLawyerFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLawyerFirstName.Location = new Point(3, 46);
            txtLawyerFirstName.MaxLength = 50;
            txtLawyerFirstName.Name = "txtLawyerFirstName";
            txtLawyerFirstName.Size = new Size(230, 27);
            txtLawyerFirstName.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Segoe UI", 8.25F);
            label3.ForeColor = Color.FromArgb(45, 93, 134);
            label3.Location = new Point(242, 76);
            label3.Name = "label3";
            label3.Size = new Size(55, 13);
            label3.TabIndex = 42;
            label3.Text = "Lastname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(45, 93, 134);
            label4.Location = new Point(3, 76);
            label4.Name = "label4";
            label4.Size = new Size(57, 13);
            label4.TabIndex = 43;
            label4.Text = "Firstname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientInactiveCaption;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(45, 93, 134);
            label5.Location = new Point(3, 22);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 44;
            label5.Text = "Name";
            // 
            // lblAddLawyer
            // 
            lblAddLawyer.AutoSize = true;
            lblAddLawyer.BackColor = SystemColors.GradientInactiveCaption;
            lblAddLawyer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAddLawyer.ForeColor = Color.FromArgb(45, 93, 134);
            lblAddLawyer.Location = new Point(162, 0);
            lblAddLawyer.Name = "lblAddLawyer";
            lblAddLawyer.Size = new Size(151, 21);
            lblAddLawyer.TabIndex = 21;
            lblAddLawyer.Text = "Lawyer information";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtClientPostalCode);
            panel2.Controls.Add(txtClientAddress);
            panel2.Controls.Add(txtClientLastName);
            panel2.Controls.Add(txtClientPhoneNumber1);
            panel2.Controls.Add(txtClientEmail);
            panel2.Controls.Add(txtClientFirstname);
            panel2.Controls.Add(lblPostal);
            panel2.Controls.Add(lblAddress);
            panel2.Controls.Add(lblPhone);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(lblMainPhone);
            panel2.Controls.Add(lblLastname);
            panel2.Controls.Add(lblFirstname);
            panel2.Controls.Add(lblName);
            panel2.Controls.Add(lblClientInformation);
            panel2.Location = new Point(510, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(476, 355);
            panel2.TabIndex = 16;
            // 
            // txtClientPostalCode
            // 
            txtClientPostalCode.BackColor = Color.White;
            txtClientPostalCode.Enabled = false;
            txtClientPostalCode.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClientPostalCode.Location = new Point(3, 317);
            txtClientPostalCode.MaxLength = 50;
            txtClientPostalCode.Name = "txtClientPostalCode";
            txtClientPostalCode.Size = new Size(104, 27);
            txtClientPostalCode.TabIndex = 48;
            // 
            // txtClientAddress
            // 
            txtClientAddress.BackColor = Color.White;
            txtClientAddress.Enabled = false;
            txtClientAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClientAddress.Location = new Point(3, 257);
            txtClientAddress.MaxLength = 50;
            txtClientAddress.Name = "txtClientAddress";
            txtClientAddress.Size = new Size(445, 27);
            txtClientAddress.TabIndex = 47;
            // 
            // txtClientLastName
            // 
            txtClientLastName.BackColor = Color.White;
            txtClientLastName.Enabled = false;
            txtClientLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClientLastName.Location = new Point(239, 52);
            txtClientLastName.MaxLength = 50;
            txtClientLastName.Name = "txtClientLastName";
            txtClientLastName.Size = new Size(230, 27);
            txtClientLastName.TabIndex = 46;
            // 
            // txtClientPhoneNumber1
            // 
            txtClientPhoneNumber1.BackColor = Color.White;
            txtClientPhoneNumber1.Enabled = false;
            txtClientPhoneNumber1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClientPhoneNumber1.Location = new Point(3, 177);
            txtClientPhoneNumber1.MaxLength = 50;
            txtClientPhoneNumber1.Name = "txtClientPhoneNumber1";
            txtClientPhoneNumber1.Size = new Size(230, 27);
            txtClientPhoneNumber1.TabIndex = 44;
            // 
            // txtClientEmail
            // 
            txtClientEmail.BackColor = Color.White;
            txtClientEmail.Enabled = false;
            txtClientEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClientEmail.Location = new Point(3, 122);
            txtClientEmail.MaxLength = 50;
            txtClientEmail.Name = "txtClientEmail";
            txtClientEmail.Size = new Size(230, 27);
            txtClientEmail.TabIndex = 43;
            // 
            // txtClientFirstname
            // 
            txtClientFirstname.BackColor = Color.White;
            txtClientFirstname.Enabled = false;
            txtClientFirstname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClientFirstname.Location = new Point(3, 52);
            txtClientFirstname.MaxLength = 50;
            txtClientFirstname.Name = "txtClientFirstname";
            txtClientFirstname.Size = new Size(230, 27);
            txtClientFirstname.TabIndex = 22;
            // 
            // lblPostal
            // 
            lblPostal.AutoSize = true;
            lblPostal.BackColor = SystemColors.GradientInactiveCaption;
            lblPostal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPostal.ForeColor = Color.FromArgb(45, 93, 134);
            lblPostal.Location = new Point(3, 292);
            lblPostal.Name = "lblPostal";
            lblPostal.Size = new Size(94, 21);
            lblPostal.TabIndex = 36;
            lblPostal.Text = "Postal code";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = SystemColors.GradientInactiveCaption;
            lblAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(45, 93, 134);
            lblAddress.Location = new Point(3, 233);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 21);
            lblAddress.TabIndex = 33;
            lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = SystemColors.GradientInactiveCaption;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(45, 93, 134);
            lblPhone.Location = new Point(3, 153);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(117, 21);
            lblPhone.TabIndex = 34;
            lblPhone.Text = "Phone number";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.GradientInactiveCaption;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(45, 93, 134);
            lblEmail.Location = new Point(3, 98);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 38;
            lblEmail.Text = "Email";
            // 
            // lblMainPhone
            // 
            lblMainPhone.AutoSize = true;
            lblMainPhone.BackColor = SystemColors.GradientInactiveCaption;
            lblMainPhone.Font = new Font("Segoe UI", 8.25F);
            lblMainPhone.ForeColor = Color.FromArgb(45, 93, 134);
            lblMainPhone.Location = new Point(3, 211);
            lblMainPhone.Name = "lblMainPhone";
            lblMainPhone.Size = new Size(113, 13);
            lblMainPhone.TabIndex = 31;
            lblMainPhone.Text = "Main phone number";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.BackColor = SystemColors.GradientInactiveCaption;
            lblLastname.Font = new Font("Segoe UI", 8.25F);
            lblLastname.ForeColor = Color.FromArgb(45, 93, 134);
            lblLastname.Location = new Point(242, 82);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(55, 13);
            lblLastname.TabIndex = 28;
            lblLastname.Text = "Lastname";
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.BackColor = SystemColors.GradientInactiveCaption;
            lblFirstname.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstname.ForeColor = Color.FromArgb(45, 93, 134);
            lblFirstname.Location = new Point(3, 82);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(57, 13);
            lblFirstname.TabIndex = 35;
            lblFirstname.Text = "Firstname";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.GradientInactiveCaption;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(45, 93, 134);
            lblName.Location = new Point(3, 28);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 21);
            lblName.TabIndex = 39;
            lblName.Text = "Name";
            // 
            // lblClientInformation
            // 
            lblClientInformation.AutoSize = true;
            lblClientInformation.BackColor = SystemColors.GradientInactiveCaption;
            lblClientInformation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblClientInformation.ForeColor = Color.FromArgb(45, 93, 134);
            lblClientInformation.Location = new Point(164, -1);
            lblClientInformation.Name = "lblClientInformation";
            lblClientInformation.Size = new Size(142, 21);
            lblClientInformation.TabIndex = 21;
            lblClientInformation.Text = "Client information";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
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
            panel1.Size = new Size(480, 238);
            panel1.TabIndex = 15;
            // 
            // lblCaseInformation
            // 
            lblCaseInformation.AutoSize = true;
            lblCaseInformation.BackColor = SystemColors.GradientInactiveCaption;
            lblCaseInformation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCaseInformation.ForeColor = Color.FromArgb(45, 93, 134);
            lblCaseInformation.Location = new Point(163, 0);
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
            label1.Location = new Point(0, 178);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 17;
            label1.Text = "Casetype";
            // 
            // cboxCaseType
            // 
            cboxCaseType.FormattingEnabled = true;
            cboxCaseType.Location = new Point(3, 202);
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
            dtpEstimatedEndDate.Location = new Point(3, 98);
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
            lblEstimatedEndDate.Location = new Point(3, 74);
            lblEstimatedEndDate.Name = "lblEstimatedEndDate";
            lblEstimatedEndDate.Size = new Size(151, 21);
            lblEstimatedEndDate.TabIndex = 13;
            lblEstimatedEndDate.Text = "Estimated End Date";
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
            panel3.Location = new Point(12, 271);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 283);
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
            dgvServices.Size = new Size(472, 203);
            dgvServices.TabIndex = 22;
            // 
            // lblServices
            // 
            lblServices.AutoSize = true;
            lblServices.BackColor = SystemColors.GradientInactiveCaption;
            lblServices.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblServices.ForeColor = Color.FromArgb(45, 93, 134);
            lblServices.Location = new Point(186, 0);
            lblServices.Name = "lblServices";
            lblServices.Size = new Size(71, 21);
            lblServices.TabIndex = 21;
            lblServices.Text = "Services";
            // 
            // CaseDetailsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CaseDetailsView";
            Text = "CaseDetailsView";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddService;
        private Panel panel4;
        private TextBox txtLawyerPhone;
        private Label label7;
        private TextBox txtLawyerLastName;
        private TextBox txtLawyerFirstName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblAddLawyer;
        private Panel panel2;
        private TextBox txtClientPostalCode;
        private TextBox txtClientAddress;
        private TextBox txtClientLastName;
        private TextBox txtClientPhoneNumber1;
        private TextBox txtClientEmail;
        private TextBox txtClientFirstname;
        private Label lblPostal;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblMainPhone;
        private Label lblLastname;
        private Label lblFirstname;
        private Label lblName;
        private Label lblClientInformation;
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
    }
}