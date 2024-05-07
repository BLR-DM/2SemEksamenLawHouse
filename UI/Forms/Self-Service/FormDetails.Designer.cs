namespace UI.Forms.Self_Service
{
    partial class FormDetails
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
            btnBuy = new FontAwesome.Sharp.IconButton();
            lblTitle = new Label();
            lblPrice = new Label();
            txtDescription = new TextBox();
            SuspendLayout();
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
            btnBuy.Location = new Point(89, 389);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(156, 41);
            btnBuy.TabIndex = 13;
            btnBuy.Text = "Buy Form";
            btnBuy.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(153, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(29, 15);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Title";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(144, 348);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 16;
            lblPrice.Text = "Price";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.GradientInactiveCaption;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Location = new Point(82, 109);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(170, 196);
            txtDescription.TabIndex = 17;
            // 
            // FormDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(334, 454);
            Controls.Add(txtDescription);
            Controls.Add(lblPrice);
            Controls.Add(lblTitle);
            Controls.Add(btnBuy);
            Name = "FormDetails";
            Text = "Form Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBuy;
        private Label lblTitle;
        private Label lblPrice;
        private TextBox txtDescription;
    }
}