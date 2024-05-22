namespace UI.Forms.AdminPage
{
    partial class AdminCUDService
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
            txtServiceName = new TextBox();
            txtPrice = new TextBox();
            lblPrice = new Label();
            lblServiceName = new Label();
            lblDescription = new Label();
            txtDescription = new TextBox();
            cboPriceTypes = new ComboBox();
            lblPriceType = new Label();
            btnCreate = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // txtServiceName
            // 
            txtServiceName.BackColor = Color.White;
            txtServiceName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtServiceName.Location = new Point(12, 37);
            txtServiceName.MaxLength = 50;
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(200, 27);
            txtServiceName.TabIndex = 30;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.White;
            txtPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(12, 222);
            txtPrice.MaxLength = 50;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(108, 27);
            txtPrice.TabIndex = 33;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = SystemColors.GradientInactiveCaption;
            lblPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(45, 93, 134);
            lblPrice.Location = new Point(12, 197);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(46, 21);
            lblPrice.TabIndex = 39;
            lblPrice.Text = "Price";
            // 
            // lblServiceName
            // 
            lblServiceName.AutoSize = true;
            lblServiceName.BackColor = SystemColors.GradientInactiveCaption;
            lblServiceName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblServiceName.ForeColor = Color.FromArgb(45, 93, 134);
            lblServiceName.Location = new Point(12, 9);
            lblServiceName.Name = "lblServiceName";
            lblServiceName.Size = new Size(108, 21);
            lblServiceName.TabIndex = 40;
            lblServiceName.Text = "Service name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = SystemColors.GradientInactiveCaption;
            lblDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(45, 93, 134);
            lblDescription.Location = new Point(12, 75);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(94, 21);
            lblDescription.TabIndex = 37;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(12, 102);
            txtDescription.MaxLength = 50;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(313, 81);
            txtDescription.TabIndex = 32;
            // 
            // cboPriceTypes
            // 
            cboPriceTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPriceTypes.FormattingEnabled = true;
            cboPriceTypes.Location = new Point(12, 290);
            cboPriceTypes.Name = "cboPriceTypes";
            cboPriceTypes.Size = new Size(171, 23);
            cboPriceTypes.TabIndex = 41;
            // 
            // lblPriceType
            // 
            lblPriceType.AutoSize = true;
            lblPriceType.BackColor = SystemColors.GradientInactiveCaption;
            lblPriceType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPriceType.ForeColor = Color.FromArgb(45, 93, 134);
            lblPriceType.Location = new Point(12, 264);
            lblPriceType.Name = "lblPriceType";
            lblPriceType.Size = new Size(79, 21);
            lblPriceType.TabIndex = 42;
            lblPriceType.Text = "Pricetype";
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Bottom;
            btnCreate.BackColor = Color.FromArgb(45, 93, 134);
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnCreate.ForeColor = Color.White;
            btnCreate.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCreate.IconColor = Color.Black;
            btnCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCreate.IconSize = 70;
            btnCreate.Location = new Point(83, 354);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(179, 50);
            btnCreate.TabIndex = 43;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom;
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Transparent;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDelete.IconColor = Color.Transparent;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 70;
            btnDelete.Location = new Point(203, 354);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 50);
            btnDelete.TabIndex = 45;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom;
            btnUpdate.BackColor = Color.FromArgb(45, 93, 134);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            btnUpdate.IconColor = Color.Black;
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.IconSize = 70;
            btnUpdate.Location = new Point(12, 354);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(128, 50);
            btnUpdate.TabIndex = 46;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // AdminCUDService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(343, 426);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(lblPriceType);
            Controls.Add(cboPriceTypes);
            Controls.Add(txtServiceName);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(lblServiceName);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Name = "AdminCUDService";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AdminCUDService";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtServiceName;
        private TextBox txtPrice;
        private Label lblPrice;
        private Label lblServiceName;
        private Label lblDescription;
        private TextBox txtDescription;
        private ComboBox cboPriceTypes;
        private Label lblPriceType;
        private FontAwesome.Sharp.IconButton btnCreate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
    }
}