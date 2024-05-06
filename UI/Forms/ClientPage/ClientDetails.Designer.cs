namespace UI.Forms.ClientPage
{
    partial class ClientDetails
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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnDeletePhone = new FontAwesome.Sharp.IconButton();
            btnAddPhone = new FontAwesome.Sharp.IconButton();
            dgvPhoneNumbers = new DataGridView();
            label11 = new Label();
            lblCity = new Label();
            txtAddPhone = new TextBox();
            label10 = new Label();
            lblSubscribed = new Label();
            txtPostal = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            label9 = new Label();
            txtLastname = new TextBox();
            txtFirstname = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            lblPhoneNumbersView = new Label();
            label7 = new Label();
            dataGridView2 = new DataGridView();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhoneNumbers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(493, 232);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(448, 136);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnDeletePhone);
            panel2.Controls.Add(btnAddPhone);
            panel2.Controls.Add(dgvPhoneNumbers);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(lblCity);
            panel2.Controls.Add(txtAddPhone);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lblSubscribed);
            panel2.Controls.Add(txtPostal);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtLastname);
            panel2.Controls.Add(txtFirstname);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblPhoneNumbersView);
            panel2.Location = new Point(27, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(421, 534);
            panel2.TabIndex = 34;
            // 
            // btnDeletePhone
            // 
            btnDeletePhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeletePhone.BackColor = Color.Brown;
            btnDeletePhone.BackgroundImageLayout = ImageLayout.Center;
            btnDeletePhone.FlatAppearance.BorderSize = 0;
            btnDeletePhone.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletePhone.IconChar = FontAwesome.Sharp.IconChar.Minus;
            btnDeletePhone.IconColor = Color.Black;
            btnDeletePhone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeletePhone.IconSize = 20;
            btnDeletePhone.Location = new Point(377, 412);
            btnDeletePhone.Name = "btnDeletePhone";
            btnDeletePhone.Size = new Size(30, 29);
            btnDeletePhone.TabIndex = 52;
            btnDeletePhone.TabStop = false;
            btnDeletePhone.UseVisualStyleBackColor = false;
            // 
            // btnAddPhone
            // 
            btnAddPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddPhone.BackgroundImageLayout = ImageLayout.Center;
            btnAddPhone.FlatAppearance.BorderSize = 0;
            btnAddPhone.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPhone.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAddPhone.IconColor = Color.Black;
            btnAddPhone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddPhone.IconSize = 25;
            btnAddPhone.Location = new Point(143, 445);
            btnAddPhone.Name = "btnAddPhone";
            btnAddPhone.Size = new Size(30, 28);
            btnAddPhone.TabIndex = 48;
            btnAddPhone.TabStop = false;
            btnAddPhone.UseVisualStyleBackColor = true;
            // 
            // dgvPhoneNumbers
            // 
            dgvPhoneNumbers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhoneNumbers.Location = new Point(213, 412);
            dgvPhoneNumbers.Name = "dgvPhoneNumbers";
            dgvPhoneNumbers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhoneNumbers.Size = new Size(158, 77);
            dgvPhoneNumbers.TabIndex = 51;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.GradientInactiveCaption;
            label11.Font = new Font("Segoe UI", 8.25F);
            label11.ForeColor = Color.FromArgb(45, 93, 134);
            label11.Location = new Point(416, 370);
            label11.Name = "label11";
            label11.Size = new Size(28, 13);
            label11.TabIndex = 47;
            label11.Text = "Add";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.BackColor = SystemColors.GradientInactiveCaption;
            lblCity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCity.ForeColor = Color.FromArgb(45, 93, 134);
            lblCity.Location = new Point(118, 316);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(82, 21);
            lblCity.TabIndex = 50;
            lblCity.Text = "Fredericia";
            // 
            // txtAddPhone
            // 
            txtAddPhone.BackColor = Color.White;
            txtAddPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddPhone.Location = new Point(11, 445);
            txtAddPhone.MaxLength = 50;
            txtAddPhone.Name = "txtAddPhone";
            txtAddPhone.Size = new Size(126, 27);
            txtAddPhone.TabIndex = 45;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.GradientInactiveCaption;
            label10.Font = new Font("Segoe UI", 8.25F);
            label10.ForeColor = Color.FromArgb(45, 93, 134);
            label10.Location = new Point(11, 476);
            label10.Name = "label10";
            label10.Size = new Size(151, 13);
            label10.TabIndex = 46;
            label10.Text = "Enter 8-digit phone number";
            // 
            // lblSubscribed
            // 
            lblSubscribed.AutoSize = true;
            lblSubscribed.BackColor = SystemColors.GradientInactiveCaption;
            lblSubscribed.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSubscribed.ForeColor = Color.FromArgb(45, 93, 134);
            lblSubscribed.Location = new Point(118, 365);
            lblSubscribed.Name = "lblSubscribed";
            lblSubscribed.Size = new Size(63, 21);
            lblSubscribed.TabIndex = 48;
            lblSubscribed.Text = "Yes/No";
            // 
            // txtPostal
            // 
            txtPostal.Location = new Point(118, 259);
            txtPostal.Name = "txtPostal";
            txtPostal.Size = new Size(63, 23);
            txtPostal.TabIndex = 49;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(118, 197);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(214, 23);
            txtAddress.TabIndex = 48;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(118, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 23);
            txtEmail.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.GradientInactiveCaption;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(45, 93, 134);
            label9.Location = new Point(24, 71);
            label9.Name = "label9";
            label9.Size = new Size(83, 21);
            label9.TabIndex = 46;
            label9.Text = "Lastname:";
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(118, 73);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(156, 23);
            txtLastname.TabIndex = 45;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(118, 16);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(156, 23);
            txtFirstname.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientInactiveCaption;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(45, 93, 134);
            label6.Location = new Point(11, 365);
            label6.Name = "label6";
            label6.Size = new Size(96, 21);
            label6.TabIndex = 43;
            label6.Text = "Subscribed:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientInactiveCaption;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(45, 93, 134);
            label5.Location = new Point(65, 316);
            label5.Name = "label5";
            label5.Size = new Size(42, 21);
            label5.TabIndex = 42;
            label5.Text = "City:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(45, 93, 134);
            label2.Location = new Point(7, 258);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 41;
            label2.Text = "Postal Code:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(45, 93, 134);
            label4.Location = new Point(33, 195);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 40;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(45, 93, 134);
            label3.Location = new Point(55, 132);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 39;
            label3.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 93, 134);
            label1.Location = new Point(22, 14);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 38;
            label1.Text = "Firstname:";
            // 
            // lblPhoneNumbersView
            // 
            lblPhoneNumbersView.AutoSize = true;
            lblPhoneNumbersView.BackColor = SystemColors.GradientInactiveCaption;
            lblPhoneNumbersView.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPhoneNumbersView.ForeColor = Color.FromArgb(45, 93, 134);
            lblPhoneNumbersView.Location = new Point(7, 412);
            lblPhoneNumbersView.Name = "lblPhoneNumbersView";
            lblPhoneNumbersView.Size = new Size(131, 21);
            lblPhoneNumbersView.TabIndex = 34;
            lblPhoneNumbersView.Text = "Phone Numbers:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientInactiveCaption;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(45, 93, 134);
            label7.Location = new Point(493, 204);
            label7.Name = "label7";
            label7.Size = new Size(51, 21);
            label7.TabIndex = 44;
            label7.Text = "Cases";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(493, 423);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(448, 135);
            dataGridView2.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.GradientInactiveCaption;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(45, 93, 134);
            label8.Location = new Point(493, 399);
            label8.Name = "label8";
            label8.Size = new Size(82, 21);
            label8.TabIndex = 46;
            label8.Text = "Formulars";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(624, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 118);
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
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
            btnUpdate.Location = new Point(146, 564);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(171, 37);
            btnUpdate.TabIndex = 48;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // ClientDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(btnUpdate);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(dataGridView2);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientDetails";
            Text = "ClientDetails";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhoneNumbers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label lblPhoneNumbersView;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView2;
        private Label label8;
        private PictureBox pictureBox1;
        private TextBox txtLastname;
        private TextBox txtFirstname;
        private Label lblSubscribed;
        private TextBox txtPostal;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private Label label9;
        private Label lblCity;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private DataGridView dgvPhoneNumbers;
        private FontAwesome.Sharp.IconButton btnAddPhone;
        private Label label11;
        private TextBox txtAddPhone;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnDeletePhone;
    }
}