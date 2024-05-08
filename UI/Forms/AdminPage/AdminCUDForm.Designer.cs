namespace UI.Forms.AdminPage
{
    partial class AdminCUDForm
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
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCreateForm = new FontAwesome.Sharp.IconButton();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(127, 29);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(44, 101);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(183, 158);
            txtDescription.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(127, 274);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 32);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "Form Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 83);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 277);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Price:";
            // 
            // btnCreateForm
            // 
            btnCreateForm.Anchor = AnchorStyles.Bottom;
            btnCreateForm.BackColor = Color.FromArgb(45, 93, 134);
            btnCreateForm.Cursor = Cursors.Hand;
            btnCreateForm.FlatAppearance.BorderSize = 0;
            btnCreateForm.FlatStyle = FlatStyle.Flat;
            btnCreateForm.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnCreateForm.ForeColor = Color.White;
            btnCreateForm.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCreateForm.IconColor = Color.Black;
            btnCreateForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCreateForm.IconSize = 70;
            btnCreateForm.Location = new Point(56, 327);
            btnCreateForm.Name = "btnCreateForm";
            btnCreateForm.Size = new Size(171, 37);
            btnCreateForm.TabIndex = 50;
            btnCreateForm.Text = "Create";
            btnCreateForm.UseVisualStyleBackColor = false;
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
            btnUpdate.Location = new Point(9, 327);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 37);
            btnUpdate.TabIndex = 51;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom;
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 70;
            btnDelete.Location = new Point(159, 327);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 37);
            btnDelete.TabIndex = 52;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // AdminCUDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(279, 376);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreateForm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Name = "AdminCUDForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CUD Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnCreateForm;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
    }
}