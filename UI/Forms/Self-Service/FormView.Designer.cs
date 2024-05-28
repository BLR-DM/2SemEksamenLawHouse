namespace UI.Forms.Self_Service
{
    partial class FormView
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
            dgvForms = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            txtSelectForm = new TextBox();
            btnResendMail = new FontAwesome.Sharp.IconButton();
            lblPricelbl = new Label();
            lblDescriptionlbl = new Label();
            lblTitlelbl = new Label();
            btnBuy = new FontAwesome.Sharp.IconButton();
            lblPrice = new Label();
            txtDescription = new TextBox();
            lblTitle = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvForms).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvForms
            // 
            dgvForms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvForms.Location = new Point(76, 77);
            dgvForms.Name = "dgvForms";
            dgvForms.Size = new Size(290, 445);
            dgvForms.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 93, 134);
            label1.Location = new Point(186, 44);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 41;
            label1.Text = "Forms";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtSelectForm);
            panel1.Controls.Add(btnResendMail);
            panel1.Controls.Add(lblPricelbl);
            panel1.Controls.Add(lblDescriptionlbl);
            panel1.Controls.Add(lblTitlelbl);
            panel1.Controls.Add(btnBuy);
            panel1.Controls.Add(lblPrice);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(624, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 445);
            panel1.TabIndex = 42;
            // 
            // txtSelectForm
            // 
            txtSelectForm.BackColor = SystemColors.GradientInactiveCaption;
            txtSelectForm.BorderStyle = BorderStyle.None;
            txtSelectForm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSelectForm.ForeColor = Color.FromArgb(45, 93, 134);
            txtSelectForm.Location = new Point(66, 130);
            txtSelectForm.Multiline = true;
            txtSelectForm.Name = "txtSelectForm";
            txtSelectForm.Size = new Size(183, 149);
            txtSelectForm.TabIndex = 46;
            txtSelectForm.Text = "Please Select a form \r\nto get further details, \r\nand purchase the form\r\n";
            // 
            // btnResendMail
            // 
            btnResendMail.Anchor = AnchorStyles.Bottom;
            btnResendMail.BackColor = Color.FromArgb(45, 93, 134);
            btnResendMail.Cursor = Cursors.Hand;
            btnResendMail.FlatAppearance.BorderSize = 0;
            btnResendMail.FlatStyle = FlatStyle.Flat;
            btnResendMail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnResendMail.ForeColor = Color.White;
            btnResendMail.IconChar = FontAwesome.Sharp.IconChar.None;
            btnResendMail.IconColor = Color.Black;
            btnResendMail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnResendMail.IconSize = 70;
            btnResendMail.Location = new Point(66, 380);
            btnResendMail.Name = "btnResendMail";
            btnResendMail.Size = new Size(156, 41);
            btnResendMail.TabIndex = 45;
            btnResendMail.Text = "Resend Mail";
            btnResendMail.UseVisualStyleBackColor = false;
            // 
            // lblPricelbl
            // 
            lblPricelbl.AutoSize = true;
            lblPricelbl.BackColor = SystemColors.GradientInactiveCaption;
            lblPricelbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPricelbl.ForeColor = Color.FromArgb(45, 93, 134);
            lblPricelbl.Location = new Point(57, 321);
            lblPricelbl.Name = "lblPricelbl";
            lblPricelbl.Size = new Size(50, 21);
            lblPricelbl.TabIndex = 44;
            lblPricelbl.Text = "Price:";
            // 
            // lblDescriptionlbl
            // 
            lblDescriptionlbl.AutoSize = true;
            lblDescriptionlbl.BackColor = SystemColors.GradientInactiveCaption;
            lblDescriptionlbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDescriptionlbl.ForeColor = Color.FromArgb(45, 93, 134);
            lblDescriptionlbl.Location = new Point(57, 88);
            lblDescriptionlbl.Name = "lblDescriptionlbl";
            lblDescriptionlbl.Size = new Size(98, 21);
            lblDescriptionlbl.TabIndex = 43;
            lblDescriptionlbl.Text = "Description:";
            // 
            // lblTitlelbl
            // 
            lblTitlelbl.AutoSize = true;
            lblTitlelbl.BackColor = SystemColors.GradientInactiveCaption;
            lblTitlelbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitlelbl.ForeColor = Color.FromArgb(45, 93, 134);
            lblTitlelbl.Location = new Point(57, 18);
            lblTitlelbl.Name = "lblTitlelbl";
            lblTitlelbl.Size = new Size(46, 21);
            lblTitlelbl.TabIndex = 42;
            lblTitlelbl.Text = "Title:";
            // 
            // btnBuy
            // 
            btnBuy.Anchor = AnchorStyles.Bottom;
            btnBuy.BackColor = Color.FromArgb(45, 93, 134);
            btnBuy.Cursor = Cursors.Hand;
            btnBuy.FlatAppearance.BorderSize = 0;
            btnBuy.FlatStyle = FlatStyle.Flat;
            btnBuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBuy.ForeColor = Color.White;
            btnBuy.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuy.IconColor = Color.Black;
            btnBuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuy.IconSize = 70;
            btnBuy.Location = new Point(66, 380);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(156, 41);
            btnBuy.TabIndex = 21;
            btnBuy.Text = "Buy Form";
            btnBuy.UseVisualStyleBackColor = false;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(131, 327);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 19;
            lblPrice.Text = "Price";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.GradientInactiveCaption;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Location = new Point(57, 112);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(183, 196);
            txtDescription.TabIndex = 18;
            txtDescription.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(57, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(29, 15);
            lblTitle.TabIndex = 15;
            lblTitle.Text = "Title";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 93, 134);
            panel2.Location = new Point(499, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 445);
            panel2.TabIndex = 43;
            // 
            // FormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dgvForms);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormView";
            Text = "FormularView";
            ((System.ComponentModel.ISupportInitialize)dgvForms).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvForms;
        private Label label1;
        private Panel panel1;
        private Label lblTitle;
        private TextBox txtDescription;
        private Label lblPrice;
        private FontAwesome.Sharp.IconButton btnBuy;
        private Panel panel2;
        private Label lblPricelbl;
        private Label lblDescriptionlbl;
        private Label lblTitlelbl;
        private FontAwesome.Sharp.IconButton btnResendMail;
        private TextBox txtSelectForm;
    }
}