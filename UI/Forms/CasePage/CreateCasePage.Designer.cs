namespace UI.Forms.CasePage
{
    partial class CreateCasePage
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
            pnlTopBar = new Panel();
            lblCreateCase = new Label();
            panel1 = new Panel();
            lblCaseInformation = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            lblEstimatedHours = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtEstimatedEndDate = new TextBox();
            lblEstimatedEndDate = new Label();
            txtTitle = new TextBox();
            lblTitle = new Label();
            panel2 = new Panel();
            btnClose = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            txtClientFirstname = new TextBox();
            lblPostal = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblPhoneAlt = new Label();
            lblLastname = new Label();
            lblFirstname = new Label();
            lblName = new Label();
            lblClientInformation = new Label();
            panel4 = new Panel();
            txtLawyerPhone = new TextBox();
            label7 = new Label();
            txtLawyerEmail = new TextBox();
            label6 = new Label();
            txtLawyerLastName = new TextBox();
            txtLawyerFirstName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblAddLawyer = new Label();
            txtClientEmail = new TextBox();
            txtClientPhoneNumber1 = new TextBox();
            txtClientPhoneNumber2 = new TextBox();
            txtClientLastName = new TextBox();
            txtClientAddress = new TextBox();
            txtClientPostalCode = new TextBox();
            pnlTopBar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopBar
            // 
            pnlTopBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTopBar.BackColor = SystemColors.GradientActiveCaption;
            pnlTopBar.Controls.Add(lblCreateCase);
            pnlTopBar.Location = new Point(12, 12);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(958, 60);
            pnlTopBar.TabIndex = 9;
            // 
            // lblCreateCase
            // 
            lblCreateCase.Anchor = AnchorStyles.Top;
            lblCreateCase.AutoSize = true;
            lblCreateCase.BackColor = SystemColors.GradientActiveCaption;
            lblCreateCase.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateCase.ForeColor = Color.FromArgb(45, 93, 134);
            lblCreateCase.Location = new Point(414, 20);
            lblCreateCase.Name = "lblCreateCase";
            lblCreateCase.Size = new Size(130, 25);
            lblCreateCase.TabIndex = 5;
            lblCreateCase.Text = "CREATE CASE";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblCaseInformation);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lblEstimatedHours);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txtEstimatedEndDate);
            panel1.Controls.Add(lblEstimatedEndDate);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(12, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 251);
            panel1.TabIndex = 10;
            // 
            // lblCaseInformation
            // 
            lblCaseInformation.AutoSize = true;
            lblCaseInformation.BackColor = SystemColors.GradientInactiveCaption;
            lblCaseInformation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCaseInformation.ForeColor = Color.FromArgb(45, 93, 134);
            lblCaseInformation.Location = new Point(135, 0);
            lblCaseInformation.Name = "lblCaseInformation";
            lblCaseInformation.Size = new Size(134, 21);
            lblCaseInformation.TabIndex = 20;
            lblCaseInformation.Text = "Case information";
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(239, 216);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(30, 23);
            iconButton1.TabIndex = 19;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 93, 134);
            label1.Location = new Point(0, 192);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 17;
            label1.Text = "Casetype";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 216);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 23);
            comboBox1.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(3, 162);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 27);
            textBox1.TabIndex = 17;
            // 
            // lblEstimatedHours
            // 
            lblEstimatedHours.AutoSize = true;
            lblEstimatedHours.BackColor = SystemColors.GradientInactiveCaption;
            lblEstimatedHours.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEstimatedHours.ForeColor = Color.FromArgb(45, 93, 134);
            lblEstimatedHours.Location = new Point(3, 138);
            lblEstimatedHours.Name = "lblEstimatedHours";
            lblEstimatedHours.Size = new Size(130, 21);
            lblEstimatedHours.TabIndex = 16;
            lblEstimatedHours.Text = "Estimated Hours";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(3, 112);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // txtEstimatedEndDate
            // 
            txtEstimatedEndDate.BackColor = Color.White;
            txtEstimatedEndDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstimatedEndDate.Location = new Point(17, 228);
            txtEstimatedEndDate.MaxLength = 50;
            txtEstimatedEndDate.Name = "txtEstimatedEndDate";
            txtEstimatedEndDate.Size = new Size(0, 27);
            txtEstimatedEndDate.TabIndex = 14;
            // 
            // lblEstimatedEndDate
            // 
            lblEstimatedEndDate.AutoSize = true;
            lblEstimatedEndDate.BackColor = SystemColors.GradientInactiveCaption;
            lblEstimatedEndDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEstimatedEndDate.ForeColor = Color.FromArgb(45, 93, 134);
            lblEstimatedEndDate.Location = new Point(3, 88);
            lblEstimatedEndDate.Name = "lblEstimatedEndDate";
            lblEstimatedEndDate.Size = new Size(151, 21);
            lblEstimatedEndDate.TabIndex = 13;
            lblEstimatedEndDate.Text = "Estimated End Date";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.White;
            txtTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(3, 58);
            txtTitle.MaxLength = 50;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(230, 27);
            txtTitle.TabIndex = 12;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.GradientInactiveCaption;
            lblTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(45, 93, 134);
            lblTitle.Location = new Point(3, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 21);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Title";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtClientPostalCode);
            panel2.Controls.Add(txtClientAddress);
            panel2.Controls.Add(txtClientLastName);
            panel2.Controls.Add(txtClientPhoneNumber2);
            panel2.Controls.Add(txtClientPhoneNumber1);
            panel2.Controls.Add(txtClientEmail);
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtClientFirstname);
            panel2.Controls.Add(lblPostal);
            panel2.Controls.Add(lblAddress);
            panel2.Controls.Add(lblPhone);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(lblPhoneAlt);
            panel2.Controls.Add(lblLastname);
            panel2.Controls.Add(lblFirstname);
            panel2.Controls.Add(lblName);
            panel2.Controls.Add(lblClientInformation);
            panel2.Location = new Point(494, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(476, 471);
            panel2.TabIndex = 11;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnClose.IconColor = Color.Black;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 30;
            btnClose.Location = new Point(98, 68);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 28);
            btnClose.TabIndex = 42;
            btnClose.TabStop = false;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(45, 93, 134);
            label2.Location = new Point(3, 71);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 41;
            label2.Text = "Add client:";
            // 
            // txtClientFirstname
            // 
            txtClientFirstname.BackColor = Color.White;
            txtClientFirstname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClientFirstname.Location = new Point(3, 136);
            txtClientFirstname.MaxLength = 50;
            txtClientFirstname.Name = "txtClientFirstname";
            txtClientFirstname.Size = new Size(230, 27);
            txtClientFirstname.TabIndex = 22;
            // 
            // lblPostal
            // 
            lblPostal.AutoSize = true;
            lblPostal.BackColor = SystemColors.GradientInactiveCaption;
            lblPostal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPostal.ForeColor = Color.FromArgb(45, 93, 134);
            lblPostal.Location = new Point(3, 408);
            lblPostal.Name = "lblPostal";
            lblPostal.Size = new Size(94, 21);
            lblPostal.TabIndex = 36;
            lblPostal.Text = "Postal code";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = SystemColors.GradientInactiveCaption;
            lblAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(45, 93, 134);
            lblAddress.Location = new Point(3, 342);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 21);
            lblAddress.TabIndex = 33;
            lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = SystemColors.GradientInactiveCaption;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(45, 93, 134);
            lblPhone.Location = new Point(3, 272);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(117, 21);
            lblPhone.TabIndex = 34;
            lblPhone.Text = "Phone number";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.GradientInactiveCaption;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(45, 93, 134);
            lblEmail.Location = new Point(3, 204);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 38;
            lblEmail.Text = "Email";
            // 
            // lblPhoneAlt
            // 
            lblPhoneAlt.AutoSize = true;
            lblPhoneAlt.BackColor = SystemColors.GradientInactiveCaption;
            lblPhoneAlt.Font = new Font("Segoe UI", 8.25F);
            lblPhoneAlt.ForeColor = Color.FromArgb(45, 93, 134);
            lblPhoneAlt.Location = new Point(242, 326);
            lblPhoneAlt.Name = "lblPhoneAlt";
            lblPhoneAlt.Size = new Size(142, 13);
            lblPhoneAlt.TabIndex = 31;
            lblPhoneAlt.Text = "Alternative phone number";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.BackColor = SystemColors.GradientInactiveCaption;
            lblLastname.Font = new Font("Segoe UI", 8.25F);
            lblLastname.ForeColor = Color.FromArgb(45, 93, 134);
            lblLastname.Location = new Point(242, 166);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(55, 13);
            lblLastname.TabIndex = 28;
            lblLastname.Text = "Lastname";
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.BackColor = SystemColors.GradientInactiveCaption;
            lblFirstname.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstname.ForeColor = Color.FromArgb(45, 93, 134);
            lblFirstname.Location = new Point(3, 166);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(57, 13);
            lblFirstname.TabIndex = 35;
            lblFirstname.Text = "Firstname";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.GradientInactiveCaption;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(45, 93, 134);
            lblName.Location = new Point(3, 112);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 21);
            lblName.TabIndex = 39;
            lblName.Text = "Name";
            // 
            // lblClientInformation
            // 
            lblClientInformation.AutoSize = true;
            lblClientInformation.BackColor = SystemColors.GradientInactiveCaption;
            lblClientInformation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblClientInformation.ForeColor = Color.FromArgb(45, 93, 134);
            lblClientInformation.Location = new Point(164, -1);
            lblClientInformation.Name = "lblClientInformation";
            lblClientInformation.Size = new Size(142, 21);
            lblClientInformation.TabIndex = 21;
            lblClientInformation.Text = "Client information";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtLawyerPhone);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(txtLawyerEmail);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtLawyerLastName);
            panel4.Controls.Add(txtLawyerFirstName);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(lblAddLawyer);
            panel4.Location = new Point(12, 352);
            panel4.Name = "panel4";
            panel4.Size = new Size(476, 210);
            panel4.TabIndex = 13;
            // 
            // txtLawyerPhone
            // 
            txtLawyerPhone.BackColor = Color.White;
            txtLawyerPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLawyerPhone.Location = new Point(3, 171);
            txtLawyerPhone.MaxLength = 50;
            txtLawyerPhone.Name = "txtLawyerPhone";
            txtLawyerPhone.Size = new Size(230, 27);
            txtLawyerPhone.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientInactiveCaption;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(45, 93, 134);
            label7.Location = new Point(3, 147);
            label7.Name = "label7";
            label7.Size = new Size(117, 21);
            label7.TabIndex = 48;
            label7.Text = "Phone number";
            // 
            // txtLawyerEmail
            // 
            txtLawyerEmail.BackColor = Color.White;
            txtLawyerEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLawyerEmail.Location = new Point(3, 111);
            txtLawyerEmail.MaxLength = 50;
            txtLawyerEmail.Name = "txtLawyerEmail";
            txtLawyerEmail.Size = new Size(230, 27);
            txtLawyerEmail.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientInactiveCaption;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(45, 93, 134);
            label6.Location = new Point(3, 87);
            label6.Name = "label6";
            label6.Size = new Size(48, 21);
            label6.TabIndex = 46;
            label6.Text = "Email";
            // 
            // txtLawyerLastName
            // 
            txtLawyerLastName.BackColor = Color.White;
            txtLawyerLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLawyerLastName.Location = new Point(242, 44);
            txtLawyerLastName.MaxLength = 50;
            txtLawyerLastName.Name = "txtLawyerLastName";
            txtLawyerLastName.Size = new Size(230, 27);
            txtLawyerLastName.TabIndex = 41;
            // 
            // txtLawyerFirstName
            // 
            txtLawyerFirstName.BackColor = Color.White;
            txtLawyerFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLawyerFirstName.Location = new Point(3, 44);
            txtLawyerFirstName.MaxLength = 50;
            txtLawyerFirstName.Name = "txtLawyerFirstName";
            txtLawyerFirstName.Size = new Size(230, 27);
            txtLawyerFirstName.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Segoe UI", 8.25F);
            label3.ForeColor = Color.FromArgb(45, 93, 134);
            label3.Location = new Point(242, 74);
            label3.Name = "label3";
            label3.Size = new Size(55, 13);
            label3.TabIndex = 42;
            label3.Text = "Lastname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(45, 93, 134);
            label4.Location = new Point(3, 74);
            label4.Name = "label4";
            label4.Size = new Size(57, 13);
            label4.TabIndex = 43;
            label4.Text = "Firstname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientInactiveCaption;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(45, 93, 134);
            label5.Location = new Point(3, 20);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 44;
            label5.Text = "Name";
            // 
            // lblAddLawyer
            // 
            lblAddLawyer.AutoSize = true;
            lblAddLawyer.BackColor = SystemColors.GradientInactiveCaption;
            lblAddLawyer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAddLawyer.ForeColor = Color.FromArgb(45, 93, 134);
            lblAddLawyer.Location = new Point(159, 0);
            lblAddLawyer.Name = "lblAddLawyer";
            lblAddLawyer.Size = new Size(151, 21);
            lblAddLawyer.TabIndex = 21;
            lblAddLawyer.Text = "Lawyer information";
            // 
            // txtClientEmail
            // 
            txtClientEmail.BackColor = Color.White;
            txtClientEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClientEmail.Location = new Point(3, 228);
            txtClientEmail.MaxLength = 50;
            txtClientEmail.Name = "txtClientEmail";
            txtClientEmail.Size = new Size(230, 27);
            txtClientEmail.TabIndex = 43;
            // 
            // txtClientPhoneNumber1
            // 
            txtClientPhoneNumber1.BackColor = Color.White;
            txtClientPhoneNumber1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClientPhoneNumber1.Location = new Point(3, 296);
            txtClientPhoneNumber1.MaxLength = 50;
            txtClientPhoneNumber1.Name = "txtClientPhoneNumber1";
            txtClientPhoneNumber1.Size = new Size(230, 27);
            txtClientPhoneNumber1.TabIndex = 44;
            // 
            // txtClientPhoneNumber2
            // 
            txtClientPhoneNumber2.BackColor = Color.White;
            txtClientPhoneNumber2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClientPhoneNumber2.Location = new Point(239, 296);
            txtClientPhoneNumber2.MaxLength = 50;
            txtClientPhoneNumber2.Name = "txtClientPhoneNumber2";
            txtClientPhoneNumber2.Size = new Size(230, 27);
            txtClientPhoneNumber2.TabIndex = 45;
            // 
            // txtClientLastName
            // 
            txtClientLastName.BackColor = Color.White;
            txtClientLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClientLastName.Location = new Point(239, 136);
            txtClientLastName.MaxLength = 50;
            txtClientLastName.Name = "txtClientLastName";
            txtClientLastName.Size = new Size(230, 27);
            txtClientLastName.TabIndex = 46;
            // 
            // txtClientAddress
            // 
            txtClientAddress.BackColor = Color.White;
            txtClientAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClientAddress.Location = new Point(3, 366);
            txtClientAddress.MaxLength = 50;
            txtClientAddress.Name = "txtClientAddress";
            txtClientAddress.Size = new Size(445, 27);
            txtClientAddress.TabIndex = 47;
            // 
            // txtClientPostalCode
            // 
            txtClientPostalCode.BackColor = Color.White;
            txtClientPostalCode.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClientPostalCode.Location = new Point(3, 432);
            txtClientPostalCode.MaxLength = 50;
            txtClientPostalCode.Name = "txtClientPostalCode";
            txtClientPostalCode.Size = new Size(104, 27);
            txtClientPostalCode.TabIndex = 48;
            // 
            // CreateCasePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(982, 574);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlTopBar);
            Name = "CreateCasePage";
            Text = "CreateCasePage";
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTopBar;
        private Label lblCreateCase;
        private Panel panel1;
        private Label lblTitle;
        private TextBox txtTitle;
        private DateTimePicker dateTimePicker1;
        private TextBox txtEstimatedEndDate;
        private Label lblEstimatedEndDate;
        private TextBox textBox1;
        private Label lblEstimatedHours;
        private Label label1;
        private ComboBox comboBox1;
        private Label lblCaseInformation;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel2;
        private Label lblClientInformation;
        private Panel panel4;
        private Label lblAddLawyer;
        private TextBox tboxLastname;
        private TextBox txtLawyerFirstName;
        private TextBox txtLawyerLastName;
        private TextBox textBox9;
        private TextBox txtLawyerEmail;
        private TextBox textBox8;
        private TextBox txtLawyerPhone;
        private TextBox txtClientFirstname;
        private Label lblPostal;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblPhoneAlt;
        private Label label3;
        private Label lblConfirmEmail;
        private Label lblLastname;
        private Label lblFirstname;
        private Label lblName;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnClose;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label5;
        private TextBox txtClientPhoneNumber2;
        private TextBox txtClientPhoneNumber1;
        private TextBox txtClientEmail;
        private TextBox txtClientAddress;
        private TextBox txtClientLastName;
        private TextBox txtClientPostalCode;
    }
}