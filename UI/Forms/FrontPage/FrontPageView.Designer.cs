﻿namespace UI.Forms.FrontPage
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
            btnMyPageLawyer = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnEmployees = new FontAwesome.Sharp.IconButton();
            btnMyPageClient = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            btnClients = new FontAwesome.Sharp.IconButton();
            pnlContext = new Panel();
            pnlLeft.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(194, 205, 240);
            pnlLeft.Controls.Add(btnMyPageLawyer);
            pnlLeft.Controls.Add(iconButton1);
            pnlLeft.Controls.Add(btnEmployees);
            pnlLeft.Controls.Add(btnMyPageClient);
            pnlLeft.Controls.Add(iconButton3);
            pnlLeft.Controls.Add(btnClients);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(200, 673);
            pnlLeft.TabIndex = 2;
            // 
            // btnMyPageLawyer
            // 
            btnMyPageLawyer.AccessibleName = "Navigation button";
            btnMyPageLawyer.AccessibleRole = AccessibleRole.MenuItem;
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
            btnMyPageLawyer.Location = new Point(0, 523);
            btnMyPageLawyer.Name = "btnMyPageLawyer";
            btnMyPageLawyer.Padding = new Padding(25, 0, 20, 0);
            btnMyPageLawyer.Size = new Size(200, 75);
            btnMyPageLawyer.TabIndex = 1;
            btnMyPageLawyer.Text = "My Page";
            btnMyPageLawyer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMyPageLawyer.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.Black;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 225);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(25, 0, 20, 0);
            iconButton1.Size = new Size(200, 75);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "Employees";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.Transparent;
            btnEmployees.Dock = DockStyle.Top;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployees.ForeColor = Color.Black;
            btnEmployees.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            btnEmployees.IconColor = Color.Black;
            btnEmployees.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEmployees.IconSize = 40;
            btnEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployees.Location = new Point(0, 150);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Padding = new Padding(25, 0, 20, 0);
            btnEmployees.Size = new Size(200, 75);
            btnEmployees.TabIndex = 0;
            btnEmployees.Text = "Employees";
            btnEmployees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployees.UseVisualStyleBackColor = false;
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
            btnMyPageClient.Location = new Point(0, 598);
            btnMyPageClient.Name = "btnMyPageClient";
            btnMyPageClient.Padding = new Padding(25, 0, 20, 0);
            btnMyPageClient.Size = new Size(200, 75);
            btnMyPageClient.TabIndex = 0;
            btnMyPageClient.Text = "My Page";
            btnMyPageClient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMyPageClient.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.Transparent;
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton3.ForeColor = Color.Black;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 40;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 75);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(25, 0, 20, 0);
            iconButton3.Size = new Size(200, 75);
            iconButton3.TabIndex = 0;
            iconButton3.Text = "Employees";
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
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
            // pnlContext
            // 
            pnlContext.BackColor = SystemColors.ControlDark;
            pnlContext.Dock = DockStyle.Fill;
            pnlContext.Location = new Point(200, 0);
            pnlContext.Name = "pnlContext";
            pnlContext.Size = new Size(998, 673);
            pnlContext.TabIndex = 3;
            // 
            // FrontPageView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 673);
            ControlBox = false;
            Controls.Add(pnlContext);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrontPageView";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.Transparent;
            pnlLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlLeft;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnEmployees;
        private FontAwesome.Sharp.IconButton btnMyPageClient;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnClients;
        private FontAwesome.Sharp.IconButton btnMyPageLawyer;
        private Panel pnlContext;
    }
}