namespace UI.Forms.CasePage
{
    partial class AddServiceView
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
            panel1 = new Panel();
            txtTotalPrice = new TextBox();
            lblTotalPrice = new Label();
            txtUnits = new TextBox();
            lblUnites = new Label();
            cboServices = new ComboBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            txtServiceDescription = new TextBox();
            lblServiceDescription = new Label();
            lblServiceInformation = new Label();
            lblPickAService = new Label();
            panel4 = new Panel();
            btnAddLawyer = new FontAwesome.Sharp.IconButton();
            txtLawyerPhone = new TextBox();
            label7 = new Label();
            txtLawyerLastName = new TextBox();
            txtLawyerFirstName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblLawyerInformaion = new Label();
            btnAddService = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtTotalPrice);
            panel1.Controls.Add(lblTotalPrice);
            panel1.Controls.Add(txtUnits);
            panel1.Controls.Add(lblUnites);
            panel1.Controls.Add(cboServices);
            panel1.Controls.Add(lblPrice);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(txtServiceDescription);
            panel1.Controls.Add(lblServiceDescription);
            panel1.Controls.Add(lblServiceInformation);
            panel1.Controls.Add(lblPickAService);
            panel1.Location = new Point(10, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 297);
            panel1.TabIndex = 20;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.BackColor = Color.White;
            txtTotalPrice.Enabled = false;
            txtTotalPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalPrice.Location = new Point(341, 251);
            txtTotalPrice.MaxLength = 50;
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(108, 27);
            txtTotalPrice.TabIndex = 66;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.BackColor = SystemColors.GradientInactiveCaption;
            lblTotalPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTotalPrice.ForeColor = Color.FromArgb(45, 93, 134);
            lblTotalPrice.Location = new Point(368, 227);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(86, 21);
            lblTotalPrice.TabIndex = 65;
            lblTotalPrice.Text = "Total price";
            // 
            // txtUnits
            // 
            txtUnits.BackColor = Color.White;
            txtUnits.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnits.Location = new Point(383, 133);
            txtUnits.MaxLength = 50;
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(66, 27);
            txtUnits.TabIndex = 64;
            // 
            // lblUnites
            // 
            lblUnites.AutoSize = true;
            lblUnites.BackColor = SystemColors.GradientInactiveCaption;
            lblUnites.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblUnites.ForeColor = Color.FromArgb(45, 93, 134);
            lblUnites.Location = new Point(403, 109);
            lblUnites.Name = "lblUnites";
            lblUnites.Size = new Size(47, 21);
            lblUnites.TabIndex = 63;
            lblUnites.Text = "Units";
            // 
            // cboServices
            // 
            cboServices.FormattingEnabled = true;
            cboServices.Location = new Point(3, 59);
            cboServices.Name = "cboServices";
            cboServices.Size = new Size(224, 23);
            cboServices.TabIndex = 62;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = SystemColors.GradientInactiveCaption;
            lblPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(45, 93, 134);
            lblPrice.Location = new Point(403, 167);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(46, 21);
            lblPrice.TabIndex = 53;
            lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.White;
            txtPrice.Enabled = false;
            txtPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(346, 197);
            txtPrice.MaxLength = 50;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(103, 27);
            txtPrice.TabIndex = 52;
            // 
            // txtServiceDescription
            // 
            txtServiceDescription.BackColor = Color.White;
            txtServiceDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtServiceDescription.Location = new Point(3, 109);
            txtServiceDescription.MaxLength = 300;
            txtServiceDescription.Multiline = true;
            txtServiceDescription.Name = "txtServiceDescription";
            txtServiceDescription.Size = new Size(224, 169);
            txtServiceDescription.TabIndex = 51;
            // 
            // lblServiceDescription
            // 
            lblServiceDescription.AutoSize = true;
            lblServiceDescription.BackColor = SystemColors.GradientInactiveCaption;
            lblServiceDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblServiceDescription.ForeColor = Color.FromArgb(45, 93, 134);
            lblServiceDescription.Location = new Point(3, 85);
            lblServiceDescription.Name = "lblServiceDescription";
            lblServiceDescription.Size = new Size(94, 21);
            lblServiceDescription.TabIndex = 50;
            lblServiceDescription.Text = "Description";
            // 
            // lblServiceInformation
            // 
            lblServiceInformation.AutoSize = true;
            lblServiceInformation.BackColor = SystemColors.GradientInactiveCaption;
            lblServiceInformation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblServiceInformation.ForeColor = Color.FromArgb(45, 93, 134);
            lblServiceInformation.Location = new Point(148, 0);
            lblServiceInformation.Name = "lblServiceInformation";
            lblServiceInformation.Size = new Size(154, 21);
            lblServiceInformation.TabIndex = 22;
            lblServiceInformation.Text = "Service information";
            // 
            // lblPickAService
            // 
            lblPickAService.AutoSize = true;
            lblPickAService.BackColor = SystemColors.GradientInactiveCaption;
            lblPickAService.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPickAService.ForeColor = Color.FromArgb(45, 93, 134);
            lblPickAService.Location = new Point(3, 31);
            lblPickAService.Name = "lblPickAService";
            lblPickAService.Size = new Size(107, 21);
            lblPickAService.TabIndex = 45;
            lblPickAService.Text = "Pick a service";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnAddLawyer);
            panel4.Controls.Add(txtLawyerPhone);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(txtLawyerLastName);
            panel4.Controls.Add(txtLawyerFirstName);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(lblLawyerInformaion);
            panel4.Location = new Point(10, 315);
            panel4.Name = "panel4";
            panel4.Size = new Size(455, 187);
            panel4.TabIndex = 67;
            // 
            // btnAddLawyer
            // 
            btnAddLawyer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddLawyer.BackColor = SystemColors.GradientActiveCaption;
            btnAddLawyer.FlatAppearance.BorderSize = 0;
            btnAddLawyer.FlatStyle = FlatStyle.Flat;
            btnAddLawyer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddLawyer.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnAddLawyer.IconColor = Color.Black;
            btnAddLawyer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddLawyer.IconSize = 30;
            btnAddLawyer.Location = new Point(161, 23);
            btnAddLawyer.Name = "btnAddLawyer";
            btnAddLawyer.Size = new Size(135, 38);
            btnAddLawyer.TabIndex = 50;
            btnAddLawyer.TabStop = false;
            btnAddLawyer.Text = "Add lawyer";
            btnAddLawyer.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAddLawyer.UseVisualStyleBackColor = false;
            // 
            // txtLawyerPhone
            // 
            txtLawyerPhone.BackColor = Color.White;
            txtLawyerPhone.Enabled = false;
            txtLawyerPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLawyerPhone.Location = new Point(3, 152);
            txtLawyerPhone.MaxLength = 50;
            txtLawyerPhone.Name = "txtLawyerPhone";
            txtLawyerPhone.Size = new Size(224, 27);
            txtLawyerPhone.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientInactiveCaption;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(45, 93, 134);
            label7.Location = new Point(3, 128);
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
            txtLawyerLastName.Location = new Point(233, 84);
            txtLawyerLastName.MaxLength = 50;
            txtLawyerLastName.Name = "txtLawyerLastName";
            txtLawyerLastName.Size = new Size(216, 27);
            txtLawyerLastName.TabIndex = 41;
            // 
            // txtLawyerFirstName
            // 
            txtLawyerFirstName.BackColor = Color.White;
            txtLawyerFirstName.Enabled = false;
            txtLawyerFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLawyerFirstName.Location = new Point(3, 84);
            txtLawyerFirstName.MaxLength = 50;
            txtLawyerFirstName.Name = "txtLawyerFirstName";
            txtLawyerFirstName.Size = new Size(224, 27);
            txtLawyerFirstName.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Segoe UI", 8.25F);
            label3.ForeColor = Color.FromArgb(45, 93, 134);
            label3.Location = new Point(233, 114);
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
            label4.Location = new Point(3, 114);
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
            label5.Location = new Point(3, 60);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 44;
            label5.Text = "Name";
            // 
            // lblLawyerInformaion
            // 
            lblLawyerInformaion.AutoSize = true;
            lblLawyerInformaion.BackColor = SystemColors.GradientInactiveCaption;
            lblLawyerInformaion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblLawyerInformaion.ForeColor = Color.FromArgb(45, 93, 134);
            lblLawyerInformaion.Location = new Point(161, -1);
            lblLawyerInformaion.Name = "lblLawyerInformaion";
            lblLawyerInformaion.Size = new Size(151, 21);
            lblLawyerInformaion.TabIndex = 21;
            lblLawyerInformaion.Text = "Lawyer information";
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(172, 508);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(127, 35);
            btnAddService.TabIndex = 68;
            btnAddService.Text = "Add service";
            btnAddService.UseVisualStyleBackColor = true;
            // 
            // AddServiceView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(477, 555);
            Controls.Add(btnAddService);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "AddServiceView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddServiceView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblPrice;
        private TextBox txtPrice;
        private TextBox txtServiceDescription;
        private Label lblServiceDescription;
        private Label lblServiceInformation;
        private Label lblPickAService;
        private ComboBox cboServices;
        private TextBox txtTotalPrice;
        private Label lblTotalPrice;
        private TextBox txtUnits;
        private Label lblUnites;
        private Panel panel4;
        private TextBox txtLawyerPhone;
        private Label label7;
        private TextBox txtLawyerLastName;
        private TextBox txtLawyerFirstName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblLawyerInformaion;
        private Button btnAddService;
        private FontAwesome.Sharp.IconButton btnAddLawyer;
    }
}