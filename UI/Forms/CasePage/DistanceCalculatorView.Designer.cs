namespace UI.Forms.CasePage
{
    partial class DistanceCalculatorView
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
            btnSearch = new Button();
            txtDestination = new TextBox();
            txtOrigin = new TextBox();
            lblOrigin = new Label();
            lblDestination = new Label();
            panel2 = new Panel();
            btnSave = new Button();
            txtResult = new TextBox();
            lblDistance = new Label();
            txtDuration = new TextBox();
            lblDuration = new Label();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(41, 169);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(41, 131);
            txtDestination.Name = "txtDestination";
            txtDestination.PlaceholderText = "Destination address";
            txtDestination.Size = new Size(236, 23);
            txtDestination.TabIndex = 2;
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new Point(41, 76);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.PlaceholderText = "Start address";
            txtOrigin.Size = new Size(236, 23);
            txtOrigin.TabIndex = 1;
            // 
            // lblOrigin
            // 
            lblOrigin.AutoSize = true;
            lblOrigin.BackColor = SystemColors.GradientInactiveCaption;
            lblOrigin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblOrigin.ForeColor = Color.FromArgb(45, 93, 134);
            lblOrigin.Location = new Point(41, 58);
            lblOrigin.Name = "lblOrigin";
            lblOrigin.Size = new Size(40, 15);
            lblOrigin.TabIndex = 46;
            lblOrigin.Text = "Origin";
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.BackColor = SystemColors.GradientInactiveCaption;
            lblDestination.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDestination.ForeColor = Color.FromArgb(45, 93, 134);
            lblDestination.Location = new Point(41, 113);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(68, 15);
            lblDestination.TabIndex = 46;
            lblDestination.Text = "Destination";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Location = new Point(298, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 176);
            panel2.TabIndex = 51;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(325, 169);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(325, 131);
            txtResult.Name = "txtResult";
            txtResult.PlaceholderText = "Result";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(144, 23);
            txtResult.TabIndex = 0;
            txtResult.TabStop = false;
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.BackColor = SystemColors.GradientInactiveCaption;
            lblDistance.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDistance.ForeColor = Color.FromArgb(45, 93, 134);
            lblDistance.Location = new Point(325, 113);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(53, 15);
            lblDistance.TabIndex = 46;
            lblDistance.Text = "Distance";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(325, 76);
            txtDuration.Name = "txtDuration";
            txtDuration.PlaceholderText = "Estimated duration";
            txtDuration.ReadOnly = true;
            txtDuration.Size = new Size(144, 23);
            txtDuration.TabIndex = 0;
            txtDuration.TabStop = false;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.BackColor = SystemColors.GradientInactiveCaption;
            lblDuration.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDuration.ForeColor = Color.FromArgb(45, 93, 134);
            lblDuration.Location = new Point(325, 58);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(54, 15);
            lblDuration.TabIndex = 46;
            lblDuration.Text = "Duration";
            // 
            // DistanceCalculatorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(516, 240);
            Controls.Add(panel2);
            Controls.Add(lblDuration);
            Controls.Add(lblDestination);
            Controls.Add(txtDuration);
            Controls.Add(lblOrigin);
            Controls.Add(lblDistance);
            Controls.Add(btnSearch);
            Controls.Add(txtResult);
            Controls.Add(txtDestination);
            Controls.Add(btnSave);
            Controls.Add(txtOrigin);
            Name = "DistanceCalculatorView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DistanceCalculatorView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtDestination;
        private TextBox txtOrigin;
        private Label lblOrigin;
        private Label lblDestination;
        private Panel panel2;
        private Button btnSave;
        private TextBox txtResult;
        private Label lblDistance;
        private TextBox txtDuration;
        private Label lblDuration;
    }
}