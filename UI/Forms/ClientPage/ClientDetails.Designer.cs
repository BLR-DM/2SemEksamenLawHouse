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
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            rtxtPhoneNumbers = new RichTextBox();
            lblPhoneNumbersView = new Label();
            label7 = new Label();
            dataGridView2 = new DataGridView();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            label9 = new Label();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtPostal = new TextBox();
            txtCity = new TextBox();
            lblSubscribed = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
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
            panel2.Controls.Add(lblSubscribed);
            panel2.Controls.Add(txtCity);
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
            panel2.Controls.Add(rtxtPhoneNumbers);
            panel2.Controls.Add(lblPhoneNumbersView);
            panel2.Location = new Point(27, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(421, 534);
            panel2.TabIndex = 34;
            panel2.Paint += this.panel2_Paint;
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
            label3.Click += label3_Click;
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
            // rtxtPhoneNumbers
            // 
            rtxtPhoneNumbers.Location = new Point(175, 414);
            rtxtPhoneNumbers.Name = "rtxtPhoneNumbers";
            rtxtPhoneNumbers.Size = new Size(183, 83);
            rtxtPhoneNumbers.TabIndex = 35;
            rtxtPhoneNumbers.Text = "";
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
            // txtFirstname
            // 
            txtFirstname.Location = new Point(118, 12);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(156, 23);
            txtFirstname.TabIndex = 44;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(118, 73);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(156, 23);
            txtLastname.TabIndex = 45;
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
            // txtEmail
            // 
            txtEmail.Location = new Point(118, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 23);
            txtEmail.TabIndex = 47;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(118, 197);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(156, 23);
            txtAddress.TabIndex = 48;
            // 
            // txtPostal
            // 
            txtPostal.Location = new Point(118, 259);
            txtPostal.Name = "txtPostal";
            txtPostal.Size = new Size(156, 23);
            txtPostal.TabIndex = 49;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(118, 318);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(156, 23);
            txtCity.TabIndex = 50;
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
            // ClientDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
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
        private RichTextBox rtxtPhoneNumbers;
        private Label lblPhoneNumbersView;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView2;
        private Label label8;
        private PictureBox pictureBox1;
        private TextBox txtLastname;
        private TextBox txtFirstname;
        private Label lblSubscribed;
        private TextBox txtCity;
        private TextBox txtPostal;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private Label label9;
    }
}