namespace UI.Forms.CasePage
{
    partial class ServiceDetailsView
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
            lblPriceType = new Label();
            txtTotalHours = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            txtServiceDescription = new TextBox();
            lblServiceDescription = new Label();
            lblServiceInformation = new Label();
            txtServiceName = new TextBox();
            lblServiceName = new Label();
            pnlTasks = new Panel();
            lblTasks = new Label();
            txtHoursWorked = new TextBox();
            lblHoursWorked = new Label();
            btnSubmit = new Button();
            dgvServiceEntry = new DataGridView();
            pnlLawyerInformation = new Panel();
            btnClose = new Button();
            panel1.SuspendLayout();
            pnlTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServiceEntry).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtTotalPrice);
            panel1.Controls.Add(lblTotalPrice);
            panel1.Controls.Add(txtUnits);
            panel1.Controls.Add(lblUnites);
            panel1.Controls.Add(lblPriceType);
            panel1.Controls.Add(txtTotalHours);
            panel1.Controls.Add(lblPrice);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(txtServiceDescription);
            panel1.Controls.Add(lblServiceDescription);
            panel1.Controls.Add(lblServiceInformation);
            panel1.Controls.Add(txtServiceName);
            panel1.Controls.Add(lblServiceName);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 293);
            panel1.TabIndex = 19;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.BackColor = Color.White;
            txtTotalPrice.Enabled = false;
            txtTotalPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalPrice.Location = new Point(449, 249);
            txtTotalPrice.MaxLength = 50;
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(108, 27);
            txtTotalPrice.TabIndex = 59;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.BackColor = SystemColors.GradientInactiveCaption;
            lblTotalPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTotalPrice.ForeColor = Color.FromArgb(45, 93, 134);
            lblTotalPrice.Location = new Point(473, 220);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(86, 21);
            lblTotalPrice.TabIndex = 58;
            lblTotalPrice.Text = "Total price";
            // 
            // txtUnits
            // 
            txtUnits.BackColor = Color.White;
            txtUnits.Enabled = false;
            txtUnits.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnits.Location = new Point(491, 190);
            txtUnits.MaxLength = 50;
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(66, 27);
            txtUnits.TabIndex = 57;
            // 
            // lblUnites
            // 
            lblUnites.AutoSize = true;
            lblUnites.BackColor = SystemColors.GradientInactiveCaption;
            lblUnites.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblUnites.ForeColor = Color.FromArgb(45, 93, 134);
            lblUnites.Location = new Point(510, 169);
            lblUnites.Name = "lblUnites";
            lblUnites.Size = new Size(47, 21);
            lblUnites.TabIndex = 56;
            lblUnites.Text = "Units";
            // 
            // lblPriceType
            // 
            lblPriceType.AutoSize = true;
            lblPriceType.BackColor = SystemColors.GradientInactiveCaption;
            lblPriceType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPriceType.ForeColor = Color.FromArgb(45, 93, 134);
            lblPriceType.Location = new Point(469, 61);
            lblPriceType.Name = "lblPriceType";
            lblPriceType.Size = new Size(90, 21);
            lblPriceType.TabIndex = 55;
            lblPriceType.Text = "Total hours";
            // 
            // txtTotalHours
            // 
            txtTotalHours.BackColor = Color.White;
            txtTotalHours.Enabled = false;
            txtTotalHours.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalHours.Location = new Point(467, 85);
            txtTotalHours.MaxLength = 50;
            txtTotalHours.Name = "txtTotalHours";
            txtTotalHours.Size = new Size(90, 27);
            txtTotalHours.TabIndex = 54;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = SystemColors.GradientInactiveCaption;
            lblPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(45, 93, 134);
            lblPrice.Location = new Point(511, 115);
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
            txtPrice.Location = new Point(454, 139);
            txtPrice.MaxLength = 50;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(103, 27);
            txtPrice.TabIndex = 52;
            // 
            // txtServiceDescription
            // 
            txtServiceDescription.BackColor = Color.White;
            txtServiceDescription.Enabled = false;
            txtServiceDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtServiceDescription.Location = new Point(3, 109);
            txtServiceDescription.MaxLength = 50;
            txtServiceDescription.Multiline = true;
            txtServiceDescription.Name = "txtServiceDescription";
            txtServiceDescription.Size = new Size(340, 167);
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
            lblServiceInformation.Location = new Point(205, 0);
            lblServiceInformation.Name = "lblServiceInformation";
            lblServiceInformation.Size = new Size(154, 21);
            lblServiceInformation.TabIndex = 22;
            lblServiceInformation.Text = "Service information";
            // 
            // txtServiceName
            // 
            txtServiceName.BackColor = Color.White;
            txtServiceName.Enabled = false;
            txtServiceName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtServiceName.Location = new Point(3, 55);
            txtServiceName.MaxLength = 50;
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(224, 27);
            txtServiceName.TabIndex = 49;
            // 
            // lblServiceName
            // 
            lblServiceName.AutoSize = true;
            lblServiceName.BackColor = SystemColors.GradientInactiveCaption;
            lblServiceName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblServiceName.ForeColor = Color.FromArgb(45, 93, 134);
            lblServiceName.Location = new Point(3, 31);
            lblServiceName.Name = "lblServiceName";
            lblServiceName.Size = new Size(53, 21);
            lblServiceName.TabIndex = 45;
            lblServiceName.Text = "Name";
            // 
            // pnlTasks
            // 
            pnlTasks.BorderStyle = BorderStyle.FixedSingle;
            pnlTasks.Controls.Add(lblTasks);
            pnlTasks.Controls.Add(txtHoursWorked);
            pnlTasks.Controls.Add(lblHoursWorked);
            pnlTasks.Controls.Add(btnSubmit);
            pnlTasks.Controls.Add(dgvServiceEntry);
            pnlTasks.Location = new Point(12, 323);
            pnlTasks.Name = "pnlTasks";
            pnlTasks.Size = new Size(280, 233);
            pnlTasks.TabIndex = 20;
            // 
            // lblTasks
            // 
            lblTasks.AutoSize = true;
            lblTasks.BackColor = SystemColors.GradientInactiveCaption;
            lblTasks.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTasks.ForeColor = Color.FromArgb(45, 93, 134);
            lblTasks.Location = new Point(111, 0);
            lblTasks.Name = "lblTasks";
            lblTasks.Size = new Size(47, 21);
            lblTasks.TabIndex = 59;
            lblTasks.Text = "Tasks";
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.BackColor = Color.White;
            txtHoursWorked.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoursWorked.Location = new Point(122, 191);
            txtHoursWorked.MaxLength = 50;
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(66, 27);
            txtHoursWorked.TabIndex = 58;
            // 
            // lblHoursWorked
            // 
            lblHoursWorked.AutoSize = true;
            lblHoursWorked.BackColor = SystemColors.GradientInactiveCaption;
            lblHoursWorked.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblHoursWorked.ForeColor = Color.FromArgb(45, 93, 134);
            lblHoursWorked.Location = new Point(3, 193);
            lblHoursWorked.Name = "lblHoursWorked";
            lblHoursWorked.Size = new Size(113, 21);
            lblHoursWorked.TabIndex = 46;
            lblHoursWorked.Text = "Hours worked";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(194, 189);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(72, 33);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // dgvServiceEntry
            // 
            dgvServiceEntry.AllowUserToAddRows = false;
            dgvServiceEntry.AllowUserToDeleteRows = false;
            dgvServiceEntry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiceEntry.Location = new Point(3, 33);
            dgvServiceEntry.Name = "dgvServiceEntry";
            dgvServiceEntry.ReadOnly = true;
            dgvServiceEntry.Size = new Size(263, 142);
            dgvServiceEntry.TabIndex = 0;
            // 
            // pnlLawyerInformation
            // 
            pnlLawyerInformation.BorderStyle = BorderStyle.FixedSingle;
            pnlLawyerInformation.Location = new Point(298, 324);
            pnlLawyerInformation.Name = "pnlLawyerInformation";
            pnlLawyerInformation.Size = new Size(281, 175);
            pnlLawyerInformation.TabIndex = 21;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(399, 517);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(85, 31);
            btnClose.TabIndex = 22;
            btnClose.Text = "Close service";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // ServiceDetailsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(584, 573);
            Controls.Add(btnClose);
            Controls.Add(pnlLawyerInformation);
            Controls.Add(pnlTasks);
            Controls.Add(panel1);
            Name = "ServiceDetailsView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ServiceDetailsView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlTasks.ResumeLayout(false);
            pnlTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServiceEntry).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox txtServiceName;
        private Label lblServiceName;
        private Label lblServiceInformation;
        private Label lblPriceType;
        private TextBox txtTotalHours;
        private Label lblPrice;
        private TextBox txtPrice;
        private TextBox txtServiceDescription;
        private Label lblServiceDescription;
        private TextBox txtTotalPrice;
        private Label lblTotalPrice;
        private TextBox txtUnits;
        private Label lblUnites;
        private Panel pnlTasks;
        private DataGridView dgvServiceEntry;
        private TextBox txtHoursWorked;
        private Label lblHoursWorked;
        private Button btnSubmit;
        private Label lblTasks;
        private Panel pnlLawyerInformation;
        private Button btnClose;
    }
}