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
            txtSearchPostal = new TextBox();
            lblSøgPris = new Label();
            ckboxNotSubscribed = new CheckBox();
            ckboxSubscribed = new CheckBox();
            txtSearchPhone = new TextBox();
            lblSearchPhone = new Label();
            dgvClients = new DataGridView();
            lblClientAmmount = new Label();
            btnCreate = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.CausesValidation = false;
            panel1.Controls.Add(txtSearchPostal);
            panel1.Controls.Add(lblSøgPris);
            panel1.Controls.Add(ckboxNotSubscribed);
            panel1.Controls.Add(ckboxSubscribed);
            panel1.Controls.Add(txtSearchPhone);
            panel1.Controls.Add(lblSearchPhone);
            panel1.Location = new Point(25, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 76);
            panel1.TabIndex = 8;
            // 
            // txtSearchPostal
            // 
            txtSearchPostal.Location = new Point(806, 26);
            txtSearchPostal.Name = "txtSearchPostal";
            txtSearchPostal.PlaceholderText = "Postalcode";
            txtSearchPostal.Size = new Size(100, 23);
            txtSearchPostal.TabIndex = 14;
            // 
            // lblSøgPris
            // 
            lblSøgPris.AutoSize = true;
            lblSøgPris.Location = new Point(755, 30);
            lblSøgPris.Name = "lblSøgPris";
            lblSøgPris.Size = new Size(45, 15);
            lblSøgPris.TabIndex = 13;
            lblSøgPris.Text = "Search:";
            // 
            // ckboxNotSubscribed
            // 
            ckboxNotSubscribed.AutoSize = true;
            ckboxNotSubscribed.Location = new Point(479, 29);
            ckboxNotSubscribed.Name = "ckboxNotSubscribed";
            ckboxNotSubscribed.Size = new Size(106, 19);
            ckboxNotSubscribed.TabIndex = 10;
            ckboxNotSubscribed.Text = "Not subscribed";
            ckboxNotSubscribed.UseVisualStyleBackColor = true;
            // 
            // ckboxSubscribed
            // 
            ckboxSubscribed.AutoSize = true;
            ckboxSubscribed.Location = new Point(359, 28);
            ckboxSubscribed.Name = "ckboxSubscribed";
            ckboxSubscribed.Size = new Size(84, 19);
            ckboxSubscribed.TabIndex = 9;
            ckboxSubscribed.Text = "Subscribed";
            ckboxSubscribed.UseVisualStyleBackColor = true;
            // 
            // txtSearchPhone
            // 
            txtSearchPhone.Location = new Point(77, 24);
            txtSearchPhone.Name = "txtSearchPhone";
            txtSearchPhone.PlaceholderText = "phonenumber";
            txtSearchPhone.Size = new Size(100, 23);
            txtSearchPhone.TabIndex = 8;
            // 
            // lblSearchPhone
            // 
            lblSearchPhone.AutoSize = true;
            lblSearchPhone.Location = new Point(26, 28);
            lblSearchPhone.Name = "lblSearchPhone";
            lblSearchPhone.Size = new Size(45, 15);
            lblSearchPhone.TabIndex = 7;
            lblSearchPhone.Text = "Search:";
            // 
            // dgvClients
            // 
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(25, 171);
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.Size = new Size(948, 416);
            dgvClients.TabIndex = 9;
            // 
            // lblClientAmmount
            // 
            lblClientAmmount.AutoSize = true;
            lblClientAmmount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblClientAmmount.ForeColor = Color.FromArgb(45, 93, 134);
            lblClientAmmount.Location = new Point(462, 123);
            lblClientAmmount.Name = "lblClientAmmount";
            lblClientAmmount.Size = new Size(81, 21);
            lblClientAmmount.TabIndex = 13;
            lblClientAmmount.Text = "Loading...";
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreate.BackColor = SystemColors.GradientActiveCaption;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnCreate.IconColor = Color.Black;
            btnCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCreate.IconSize = 30;
            btnCreate.Location = new Point(25, 115);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(135, 38);
            btnCreate.TabIndex = 51;
            btnCreate.TabStop = false;
            btnCreate.Text = "Create client";
            btnCreate.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // ClientsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(btnCreate);
            Controls.Add(lblClientAmmount);
            Controls.Add(dgvClients);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientsView";
            Tag = "";
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
        private Label lblClientAmmount;
        private TextBox txtSearchPostal;
        private FontAwesome.Sharp.IconButton btnCreate;
    }
}