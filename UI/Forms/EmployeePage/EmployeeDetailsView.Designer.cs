namespace UI.Forms.EmployeePage
{
    partial class EmployeeDetailsView
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
            btnEditDetails = new FontAwesome.Sharp.IconButton();
            btnCancel = new FontAwesome.Sharp.IconButton();
            pnlEmployeeDetails = new Panel();
            pnlEdit = new Panel();
            SuspendLayout();
            // 
            // btnEditDetails
            // 
            btnEditDetails.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEditDetails.IconColor = Color.Black;
            btnEditDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditDetails.Location = new Point(134, 533);
            btnEditDetails.Name = "btnEditDetails";
            btnEditDetails.Size = new Size(75, 23);
            btnEditDetails.TabIndex = 3;
            btnEditDetails.Text = "Edit details";
            btnEditDetails.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackgroundImageLayout = ImageLayout.None;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(45, 93, 134);
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancel.IconColor = Color.Black;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.Location = new Point(64, 533);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(58, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // pnlEmployeeDetails
            // 
            pnlEmployeeDetails.Location = new Point(9, 26);
            pnlEmployeeDetails.Name = "pnlEmployeeDetails";
            pnlEmployeeDetails.Size = new Size(329, 501);
            pnlEmployeeDetails.TabIndex = 0;
            // 
            // pnlEdit
            // 
            pnlEdit.Location = new Point(14, 12);
            pnlEdit.Name = "pnlEdit";
            pnlEdit.Size = new Size(323, 520);
            pnlEdit.TabIndex = 6;
            // 
            // EmployeeDetailsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(pnlEdit);
            Controls.Add(btnCancel);
            Controls.Add(pnlEmployeeDetails);
            Controls.Add(btnEditDetails);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeDetailsView";
            Text = "EmployeeDetailsView";
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnEditDetails;
        private FontAwesome.Sharp.IconButton btnCancel;
        private Panel pnlEmployeeDetails;
        private Panel pnlEdit;
    }
}