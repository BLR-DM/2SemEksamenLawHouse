namespace UI.Forms.FrontPage
{
    partial class FrontPageView
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
            pnlLeft = new Panel();
            btnAdminPage = new FontAwesome.Sharp.IconButton();
            btnMyPageLawyer = new FontAwesome.Sharp.IconButton();
            btnCalculations = new FontAwesome.Sharp.IconButton();
            btnCase = new FontAwesome.Sharp.IconButton();
            btnMyPageClient = new FontAwesome.Sharp.IconButton();
            btnForms = new FontAwesome.Sharp.IconButton();
            btnLawyers = new FontAwesome.Sharp.IconButton();
            btnClients = new FontAwesome.Sharp.IconButton();
            gradiantPanel1 = new Toolbox.GradiantPanel();
            lblCurrentUserName = new Label();
            lblCurrentUser = new Label();
            btnClose = new FontAwesome.Sharp.IconButton();
            pboxLogo = new PictureBox();
            pnlContext = new Panel();
            pnlLeft.SuspendLayout();
            gradiantPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(194, 205, 240);
            pnlLeft.Controls.Add(btnAdminPage);
            pnlLeft.Controls.Add(btnMyPageLawyer);
            pnlLeft.Controls.Add(btnCalculations);
            pnlLeft.Controls.Add(btnCase);
            pnlLeft.Controls.Add(btnMyPageClient);
            pnlLeft.Controls.Add(btnForms);
            pnlLeft.Controls.Add(btnLawyers);
            pnlLeft.Controls.Add(btnClients);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 60);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(200, 613);
            pnlLeft.TabIndex = 2;
            // 
            // btnAdminPage
            // 
            btnAdminPage.AccessibleName = "";
            btnAdminPage.BackColor = Color.Transparent;
            btnAdminPage.Dock = DockStyle.Bottom;
            btnAdminPage.FlatAppearance.BorderSize = 0;
            btnAdminPage.FlatStyle = FlatStyle.Flat;
            btnAdminPage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminPage.ForeColor = Color.Black;
            btnAdminPage.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            btnAdminPage.IconColor = Color.Black;
            btnAdminPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdminPage.IconSize = 40;
            btnAdminPage.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdminPage.Location = new Point(0, 388);
            btnAdminPage.Name = "btnAdminPage";
            btnAdminPage.Padding = new Padding(25, 0, 20, 0);
            btnAdminPage.Size = new Size(200, 75);
            btnAdminPage.TabIndex = 2;
            btnAdminPage.Text = "Admin Page";
            btnAdminPage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdminPage.UseVisualStyleBackColor = false;
            // 
            // btnMyPageLawyer
            // 
            btnMyPageLawyer.AccessibleName = "";
            btnMyPageLawyer.BackColor = Color.Transparent;
            btnMyPageLawyer.Dock = DockStyle.Bottom;
            btnMyPageLawyer.FlatAppearance.BorderSize = 0;
            btnMyPageLawyer.FlatStyle = FlatStyle.Flat;
            btnMyPageLawyer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyPageLawyer.ForeColor = Color.Black;
            btnMyPageLawyer.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            btnMyPageLawyer.IconColor = Color.Black;
            btnMyPageLawyer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMyPageLawyer.IconSize = 40;
            btnMyPageLawyer.ImageAlign = ContentAlignment.MiddleLeft;
            btnMyPageLawyer.Location = new Point(0, 463);
            btnMyPageLawyer.Name = "btnMyPageLawyer";
            btnMyPageLawyer.Padding = new Padding(25, 0, 20, 0);
            btnMyPageLawyer.Size = new Size(200, 75);
            btnMyPageLawyer.TabIndex = 1;
            btnMyPageLawyer.Text = "My Page (Lawyer)";
            btnMyPageLawyer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMyPageLawyer.UseVisualStyleBackColor = false;
            // 
            // btnCalculations
            // 
            btnCalculations.BackColor = Color.Transparent;
            btnCalculations.Dock = DockStyle.Top;
            btnCalculations.FlatAppearance.BorderSize = 0;
            btnCalculations.FlatStyle = FlatStyle.Flat;
            btnCalculations.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculations.ForeColor = Color.Black;
            btnCalculations.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            btnCalculations.IconColor = Color.Black;
            btnCalculations.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCalculations.IconSize = 40;
            btnCalculations.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalculations.Location = new Point(0, 300);
            btnCalculations.Name = "btnCalculations";
            btnCalculations.Padding = new Padding(25, 0, 20, 0);
            btnCalculations.Size = new Size(200, 75);
            btnCalculations.TabIndex = 0;
            btnCalculations.Text = "Calculations";
            btnCalculations.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalculations.UseVisualStyleBackColor = false;
            // 
            // btnCase
            // 
            btnCase.BackColor = Color.Transparent;
            btnCase.Dock = DockStyle.Top;
            btnCase.FlatAppearance.BorderSize = 0;
            btnCase.FlatStyle = FlatStyle.Flat;
            btnCase.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCase.ForeColor = Color.Black;
            btnCase.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            btnCase.IconColor = Color.Black;
            btnCase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCase.IconSize = 40;
            btnCase.ImageAlign = ContentAlignment.MiddleLeft;
            btnCase.Location = new Point(0, 225);
            btnCase.Name = "btnCase";
            btnCase.Padding = new Padding(25, 0, 20, 0);
            btnCase.Size = new Size(200, 75);
            btnCase.TabIndex = 0;
            btnCase.Text = "Cases";
            btnCase.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCase.UseVisualStyleBackColor = false;
            // 
            // btnMyPageClient
            // 
            btnMyPageClient.BackColor = Color.Transparent;
            btnMyPageClient.Dock = DockStyle.Bottom;
            btnMyPageClient.FlatAppearance.BorderSize = 0;
            btnMyPageClient.FlatStyle = FlatStyle.Flat;
            btnMyPageClient.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyPageClient.ForeColor = Color.Black;
            btnMyPageClient.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            btnMyPageClient.IconColor = Color.Black;
            btnMyPageClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMyPageClient.IconSize = 40;
            btnMyPageClient.ImageAlign = ContentAlignment.MiddleLeft;
            btnMyPageClient.Location = new Point(0, 538);
            btnMyPageClient.Name = "btnMyPageClient";
            btnMyPageClient.Padding = new Padding(25, 0, 20, 0);
            btnMyPageClient.Size = new Size(200, 75);
            btnMyPageClient.TabIndex = 0;
            btnMyPageClient.Text = "My Page (Client)";
            btnMyPageClient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMyPageClient.UseVisualStyleBackColor = false;
            // 
            // btnForms
            // 
            btnForms.BackColor = Color.Transparent;
            btnForms.Dock = DockStyle.Top;
            btnForms.FlatAppearance.BorderSize = 0;
            btnForms.FlatStyle = FlatStyle.Flat;
            btnForms.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnForms.ForeColor = Color.Black;
            btnForms.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            btnForms.IconColor = Color.Black;
            btnForms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnForms.IconSize = 40;
            btnForms.ImageAlign = ContentAlignment.MiddleLeft;
            btnForms.Location = new Point(0, 150);
            btnForms.Name = "btnForms";
            btnForms.Padding = new Padding(25, 0, 20, 0);
            btnForms.Size = new Size(200, 75);
            btnForms.TabIndex = 0;
            btnForms.Text = "Formulars";
            btnForms.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnForms.UseVisualStyleBackColor = false;
            // 
            // btnLawyers
            // 
            btnLawyers.BackColor = Color.Transparent;
            btnLawyers.Dock = DockStyle.Top;
            btnLawyers.FlatAppearance.BorderSize = 0;
            btnLawyers.FlatStyle = FlatStyle.Flat;
            btnLawyers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLawyers.ForeColor = Color.Black;
            btnLawyers.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            btnLawyers.IconColor = Color.Black;
            btnLawyers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLawyers.IconSize = 40;
            btnLawyers.ImageAlign = ContentAlignment.MiddleLeft;
            btnLawyers.Location = new Point(0, 75);
            btnLawyers.Name = "btnLawyers";
            btnLawyers.Padding = new Padding(25, 0, 20, 0);
            btnLawyers.Size = new Size(200, 75);
            btnLawyers.TabIndex = 0;
            btnLawyers.Text = "Lawyers";
            btnLawyers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLawyers.UseVisualStyleBackColor = false;
            // 
            // btnClients
            // 
            btnClients.BackColor = Color.Transparent;
            btnClients.Dock = DockStyle.Top;
            btnClients.FlatAppearance.BorderSize = 0;
            btnClients.FlatStyle = FlatStyle.Flat;
            btnClients.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClients.ForeColor = Color.Black;
            btnClients.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            btnClients.IconColor = Color.Black;
            btnClients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClients.IconSize = 40;
            btnClients.ImageAlign = ContentAlignment.MiddleLeft;
            btnClients.Location = new Point(0, 0);
            btnClients.Name = "btnClients";
            btnClients.Padding = new Padding(25, 0, 20, 0);
            btnClients.Size = new Size(200, 75);
            btnClients.TabIndex = 0;
            btnClients.Text = "Clients";
            btnClients.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClients.UseVisualStyleBackColor = false;
            // 
            // gradiantPanel1
            // 
            gradiantPanel1.Angle = 80F;
            gradiantPanel1.BackColor = Color.FromArgb(60, 110, 170);
            gradiantPanel1.BottomColor = Color.Empty;
            gradiantPanel1.Controls.Add(lblCurrentUserName);
            gradiantPanel1.Controls.Add(lblCurrentUser);
            gradiantPanel1.Controls.Add(btnClose);
            gradiantPanel1.Controls.Add(pboxLogo);
            gradiantPanel1.Dock = DockStyle.Top;
            gradiantPanel1.Location = new Point(0, 0);
            gradiantPanel1.Name = "gradiantPanel1";
            gradiantPanel1.Size = new Size(1198, 60);
            gradiantPanel1.TabIndex = 2;
            gradiantPanel1.TopColor = Color.FromArgb(197, 212, 230);
            // 
            // lblCurrentUserName
            // 
            lblCurrentUserName.AutoSize = true;
            lblCurrentUserName.BackColor = Color.Transparent;
            lblCurrentUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCurrentUserName.ForeColor = Color.White;
            lblCurrentUserName.Location = new Point(1092, 19);
            lblCurrentUserName.Name = "lblCurrentUserName";
            lblCurrentUserName.Size = new Size(81, 21);
            lblCurrentUserName.TabIndex = 1;
            lblCurrentUserName.Text = "Firstname";
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.BackColor = Color.Transparent;
            lblCurrentUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCurrentUser.ForeColor = Color.White;
            lblCurrentUser.Location = new Point(206, 19);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(100, 21);
            lblCurrentUser.TabIndex = 1;
            lblCurrentUser.Text = "Current user";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            btnClose.IconColor = Color.Black;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 30;
            btnClose.Location = new Point(1151, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 28);
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // pboxLogo
            // 
            pboxLogo.BackColor = Color.Transparent;
            pboxLogo.Image = Properties.Resources.lawhouseLogo;
            pboxLogo.Location = new Point(0, -14);
            pboxLogo.Name = "pboxLogo";
            pboxLogo.Size = new Size(200, 81);
            pboxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pboxLogo.TabIndex = 3;
            pboxLogo.TabStop = false;
            // 
            // pnlContext
            // 
            pnlContext.BackColor = SystemColors.ControlDark;
            pnlContext.Location = new Point(200, 60);
            pnlContext.Name = "pnlContext";
            pnlContext.Size = new Size(998, 613);
            pnlContext.TabIndex = 3;
            // 
            // FrontPageView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 673);
            ControlBox = false;
            Controls.Add(pnlLeft);
            Controls.Add(gradiantPanel1);
            Controls.Add(pnlContext);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrontPageView";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            pnlLeft.ResumeLayout(false);
            gradiantPanel1.ResumeLayout(false);
            gradiantPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private FontAwesome.Sharp.IconButton btnMyPageLawyer;
        private FontAwesome.Sharp.IconButton btnCalculations;
        private FontAwesome.Sharp.IconButton btnCase;
        private FontAwesome.Sharp.IconButton btnMyPageClient;
        private FontAwesome.Sharp.IconButton btnForms;
        private FontAwesome.Sharp.IconButton btnLawyers;
        private FontAwesome.Sharp.IconButton btnClients;
        private Toolbox.GradiantPanel gradiantPanel1;
        private FontAwesome.Sharp.IconButton btnClose;
        private PictureBox pboxLogo;
        private Panel pnlContext;
        private Label lblCurrentUser;
        private Label lblCurrentUserName;
        private FontAwesome.Sharp.IconButton btnAdminPage;
    }
}