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
            txtResult = new TextBox();
            txtDestination = new TextBox();
            txtOrigin = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(52, 127);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(52, 165);
            txtResult.Name = "txtResult";
            txtResult.PlaceholderText = "Result";
            txtResult.Size = new Size(124, 23);
            txtResult.TabIndex = 0;
            txtResult.TabStop = false;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(52, 87);
            txtDestination.Name = "txtDestination";
            txtDestination.PlaceholderText = "Destination";
            txtDestination.Size = new Size(236, 23);
            txtDestination.TabIndex = 2;
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new Point(52, 47);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.PlaceholderText = "Origin";
            txtOrigin.Size = new Size(236, 23);
            txtOrigin.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(213, 164);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // DistanceCalculatorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(348, 230);
            Controls.Add(btnSave);
            Controls.Add(btnSearch);
            Controls.Add(txtResult);
            Controls.Add(txtDestination);
            Controls.Add(txtOrigin);
            Name = "DistanceCalculatorView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DistanceCalculatorView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtResult;
        private TextBox txtDestination;
        private TextBox txtOrigin;
        private Button btnSave;
    }
}