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
            lblHoursWorked = new Label();
            txtHoursWorked = new TextBox();
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
            pnlLawyerInformation = new Panel();
            panel2 = new Panel();
            btnAddLawyer = new FontAwesome.Sharp.IconButton();
            btnAddService = new Button();
            panel1.SuspendLayout();
            pnlLawyerInformation.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblHoursWorked);
            panel1.Controls.Add(txtHoursWorked);
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
            // lblHoursWorked
            // 
            lblHoursWorked.Anchor = AnchorStyles.Right;
            lblHoursWorked.BackColor = SystemColors.GradientInactiveCaption;
            lblHoursWorked.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblHoursWorked.ForeColor = Color.FromArgb(45, 93, 134);
            lblHoursWorked.Location = new Point(324, 98);
            lblHoursWorked.Name = "lblHoursWorked";
            lblHoursWorked.RightToLeft = RightToLeft.No;
            lblHoursWorked.Size = new Size(120, 21);
            lblHoursWorked.TabIndex = 68;
            lblHoursWorked.Text = "Hours worked";
            lblHoursWorked.TextAlign = ContentAlignment.TopRight;
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.BackColor = Color.White;
            txtHoursWorked.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoursWorked.Location = new Point(375, 122);
            txtHoursWorked.MaxLength = 50;
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(66, 27);
            txtHoursWorked.TabIndex = 67;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.BackColor = Color.White;
            txtTotalPrice.Enabled = false;
            txtTotalPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalPrice.Location = new Point(336, 251);
            txtTotalPrice.MaxLength = 50;
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(108, 27);
            txtTotalPrice.TabIndex = 66;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.BackColor = SystemColors.GradientInactiveCaption;
            lblTotalPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTotalPrice.ForeColor = Color.FromArgb(45, 93, 134);
            lblTotalPrice.Location = new Point(336, 227);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(108, 21);
            lblTotalPrice.TabIndex = 65;
            lblTotalPrice.Text = "Total price";
            lblTotalPrice.TextAlign = ContentAlignment.TopRight;
            // 
            // txtUnits
            // 
            txtUnits.BackColor = Color.White;
            txtUnits.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnits.Location = new Point(375, 68);
            txtUnits.MaxLength = 50;
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(66, 27);
            txtUnits.TabIndex = 64;
            // 
            // lblUnites
            // 
            lblUnites.Anchor = AnchorStyles.Right;
            lblUnites.BackColor = SystemColors.GradientInactiveCaption;
            lblUnites.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblUnites.ForeColor = Color.FromArgb(45, 93, 134);
            lblUnites.Location = new Point(344, 44);
            lblUnites.Name = "lblUnites";
            lblUnites.RightToLeft = RightToLeft.No;
            lblUnites.Size = new Size(100, 21);
            lblUnites.TabIndex = 63;
            lblUnites.Text = "Kilometer";
            lblUnites.TextAlign = ContentAlignment.TopRight;
            // 
            // cboServices
            // 
            cboServices.DropDownStyle = ComboBoxStyle.DropDownList;
            cboServices.FormattingEnabled = true;
            cboServices.Location = new Point(15, 59);
            cboServices.Name = "cboServices";
            cboServices.Size = new Size(241, 23);
            cboServices.TabIndex = 62;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Right;
            lblPrice.BackColor = SystemColors.GradientInactiveCaption;
            lblPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(45, 93, 134);
            lblPrice.Location = new Point(336, 162);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(108, 21);
            lblPrice.TabIndex = 53;
            lblPrice.Text = "Price/km";
            lblPrice.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.White;
            txtPrice.Enabled = false;
            txtPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(336, 186);
            txtPrice.MaxLength = 50;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(108, 27);
            txtPrice.TabIndex = 52;
            // 
            // txtServiceDescription
            // 
            txtServiceDescription.BackColor = Color.White;
            txtServiceDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtServiceDescription.Location = new Point(12, 109);
            txtServiceDescription.MaxLength = 300;
            txtServiceDescription.Multiline = true;
            txtServiceDescription.Name = "txtServiceDescription";
            txtServiceDescription.Size = new Size(429, 169);
            txtServiceDescription.TabIndex = 51;
            // 
            // lblServiceDescription
            // 
            lblServiceDescription.AutoSize = true;
            lblServiceDescription.BackColor = SystemColors.GradientInactiveCaption;
            lblServiceDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblServiceDescription.ForeColor = Color.FromArgb(45, 93, 134);
            lblServiceDescription.Location = new Point(15, 85);
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
            lblPickAService.Location = new Point(15, 35);
            lblPickAService.Name = "lblPickAService";
            lblPickAService.Size = new Size(107, 21);
            lblPickAService.TabIndex = 45;
            lblPickAService.Text = "Pick a service";
            // 
            // pnlLawyerInformation
            // 
            pnlLawyerInformation.BorderStyle = BorderStyle.FixedSingle;
            pnlLawyerInformation.Controls.Add(panel2);
            pnlLawyerInformation.Controls.Add(btnAddLawyer);
            pnlLawyerInformation.Location = new Point(471, 13);
            pnlLawyerInformation.Name = "pnlLawyerInformation";
            pnlLawyerInformation.Size = new Size(281, 296);
            pnlLawyerInformation.TabIndex = 67;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Location = new Point(42, 196);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 3);
            panel2.TabIndex = 51;
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
            btnAddLawyer.Location = new Point(78, 239);
            btnAddLawyer.Name = "btnAddLawyer";
            btnAddLawyer.Size = new Size(135, 38);
            btnAddLawyer.TabIndex = 50;
            btnAddLawyer.TabStop = false;
            btnAddLawyer.Text = "Assign lawyer";
            btnAddLawyer.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAddLawyer.UseVisualStyleBackColor = false;
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(171, 315);
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
            ClientSize = new Size(759, 359);
            Controls.Add(btnAddService);
            Controls.Add(pnlLawyerInformation);
            Controls.Add(panel1);
            Name = "AddServiceView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddServiceView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlLawyerInformation.ResumeLayout(false);
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
        private Panel pnlLawyerInformation;
        private Button btnAddService;
        private Label lblHoursWorked;
        private TextBox txtHoursWorked;
        private FontAwesome.Sharp.IconButton btnAddLawyer;
        private Panel panel2;
    }
}