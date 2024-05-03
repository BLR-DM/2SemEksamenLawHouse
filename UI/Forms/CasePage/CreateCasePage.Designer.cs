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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            lblSearch = new Label();
            panel3 = new Panel();
            pnlTopBar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Size = new Size(452, 296);
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
            iconButton1.Location = new Point(235, 250);
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
            label1.Location = new Point(3, 226);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 17;
            label1.Text = "Casetype";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 250);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 23);
            comboBox1.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(3, 183);
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
            lblEstimatedHours.Location = new Point(3, 159);
            lblEstimatedHours.Name = "lblEstimatedHours";
            lblEstimatedHours.Size = new Size(130, 21);
            lblEstimatedHours.TabIndex = 16;
            lblEstimatedHours.Text = "Estimated Hours";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(3, 127);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // txtEstimatedEndDate
            // 
            txtEstimatedEndDate.BackColor = Color.White;
            txtEstimatedEndDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstimatedEndDate.Location = new Point(17, 239);
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
            lblEstimatedEndDate.Location = new Point(3, 103);
            lblEstimatedEndDate.Name = "lblEstimatedEndDate";
            lblEstimatedEndDate.Size = new Size(151, 21);
            lblEstimatedEndDate.TabIndex = 13;
            lblEstimatedEndDate.Text = "Estimated End Date";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.White;
            txtTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(3, 69);
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
            lblTitle.Location = new Point(3, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 21);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Title";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblSearch);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(470, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 296);
            panel2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(45, 93, 134);
            label2.Location = new Point(205, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 21;
            label2.Text = "Add client";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(472, 222);
            dataGridView1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(82, 34);
            textBox2.MaxLength = 50;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 27);
            textBox2.TabIndex = 21;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = SystemColors.GradientInactiveCaption;
            lblSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(45, 93, 134);
            lblSearch.Location = new Point(13, 36);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(63, 21);
            lblSearch.TabIndex = 21;
            lblSearch.Text = "Search:";
            // 
            // panel3
            // 
            panel3.Location = new Point(470, 393);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 169);
            panel3.TabIndex = 12;
            // 
            // CreateCasePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(982, 574);
            Controls.Add(panel3);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label2;
        private DataGridView dataGridView1;
        private Label lblSearch;
        private TextBox textBox2;
        private Panel panel3;
    }
}