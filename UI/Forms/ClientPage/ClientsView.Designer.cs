namespace UI.Forms.ClientPage
{
    partial class ClientsView
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
            lblSøgPris = new Label();
            ckboxNotSubscribed = new CheckBox();
            ckboxSubscribed = new CheckBox();
            txtSearchPhone = new TextBox();
            lblSearchPhone = new Label();
            dgvClients = new DataGridView();
            btnCreate = new FontAwesome.Sharp.IconButton();
            lblClientAmmount = new Label();
            txtSearchPostal = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.CausesValidation = false;
            panel1.Controls.Add(txtSearchPostal);
            panel1.Controls.Add(lblSøgPris);
            panel1.Controls.Add(ckboxNotSubscribed);
            panel1.Controls.Add(ckboxSubscribed);
            panel1.Controls.Add(txtSearchPhone);
            panel1.Controls.Add(lblSearchPhone);
            panel1.Location = new Point(25, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 68);
            panel1.TabIndex = 8;
            // 
            // lblSøgPris
            // 
            lblSøgPris.AutoSize = true;
            lblSøgPris.Location = new Point(763, 28);
            lblSøgPris.Name = "lblSøgPris";
            lblSøgPris.Size = new Size(45, 15);
            lblSøgPris.TabIndex = 13;
            lblSøgPris.Text = "Search:";
            // 
            // ckboxNotSubscribed
            // 
            ckboxNotSubscribed.AutoSize = true;
            ckboxNotSubscribed.Location = new Point(487, 24);
            ckboxNotSubscribed.Name = "ckboxNotSubscribed";
            ckboxNotSubscribed.Size = new Size(106, 19);
            ckboxNotSubscribed.TabIndex = 10;
            ckboxNotSubscribed.Text = "Not subscribed";
            ckboxNotSubscribed.UseVisualStyleBackColor = true;
            // 
            // ckboxSubscribed
            // 
            ckboxSubscribed.AutoSize = true;
            ckboxSubscribed.Location = new Point(356, 23);
            ckboxSubscribed.Name = "ckboxSubscribed";
            ckboxSubscribed.Size = new Size(84, 19);
            ckboxSubscribed.TabIndex = 9;
            ckboxSubscribed.Text = "Subscribed";
            ckboxSubscribed.UseVisualStyleBackColor = true;
            // 
            // txtSearchPhone
            // 
            txtSearchPhone.Location = new Point(71, 21);
            txtSearchPhone.Name = "txtSearchPhone";
            txtSearchPhone.PlaceholderText = "phonenumber";
            txtSearchPhone.Size = new Size(100, 23);
            txtSearchPhone.TabIndex = 8;
            // 
            // lblSearchPhone
            // 
            lblSearchPhone.AutoSize = true;
            lblSearchPhone.Location = new Point(20, 25);
            lblSearchPhone.Name = "lblSearchPhone";
            lblSearchPhone.Size = new Size(45, 15);
            lblSearchPhone.TabIndex = 7;
            lblSearchPhone.Text = "Search:";
            // 
            // dgvClients
            // 
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(25, 183);
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.Size = new Size(948, 404);
            dgvClients.TabIndex = 9;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Bottom;
            btnCreate.BackColor = Color.FromArgb(45, 93, 134);
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCreate.ForeColor = Color.White;
            btnCreate.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCreate.IconColor = Color.Black;
            btnCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCreate.IconSize = 70;
            btnCreate.Location = new Point(25, 113);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(156, 41);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Create new client";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // lblClientAmmount
            // 
            lblClientAmmount.AutoSize = true;
            lblClientAmmount.Font = new Font("Segoe UI", 14F);
            lblClientAmmount.Location = new Point(423, 120);
            lblClientAmmount.Name = "lblClientAmmount";
            lblClientAmmount.Size = new Size(128, 25);
            lblClientAmmount.TabIndex = 13;
            lblClientAmmount.Text = "10.000 Clients";
            // 
            // txtSearchPostal
            // 
            txtSearchPostal.Location = new Point(814, 24);
            txtSearchPostal.Name = "txtSearchPostal";
            txtSearchPostal.PlaceholderText = "Postalcode";
            txtSearchPostal.Size = new Size(100, 23);
            txtSearchPostal.TabIndex = 14;
            // 
            // ClientsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(lblClientAmmount);
            Controls.Add(btnCreate);
            Controls.Add(dgvClients);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientsView";
            Text = "ClientsView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox cboSorterEfter;
        private Label lblTextTilSøgPris;
        private ComboBox cboBoligType;
        private Label lblSøgPris;
        private TextBox txtSøgPrisHøj;
        private TextBox txtSøgPrisLav;
        private CheckBox ckboxNotSubscribed;
        private CheckBox ckboxSubscribed;
        private TextBox txtSearchPhone;
        private Label lblSearchPhone;
        private DataGridView dgvClients;
        private FontAwesome.Sharp.IconButton btnCreate;
        private Label lblClientAmmount;
        private TextBox txtSearchPostal;
    }
}