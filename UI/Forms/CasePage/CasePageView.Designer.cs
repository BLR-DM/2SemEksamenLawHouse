namespace UI.Forms.CasePage
{
    partial class CasePageView
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
            dgvCaseList = new DataGridView();
            panelTopBar = new Panel();
            cboLawyers = new ComboBox();
            cboCaseType = new ComboBox();
            cboxFinsished = new CheckBox();
            ckboxOngoing = new CheckBox();
            lblNumberOfCases = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCaseList).BeginInit();
            panelTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCaseList
            // 
            dgvCaseList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaseList.Location = new Point(12, 157);
            dgvCaseList.Name = "dgvCaseList";
            dgvCaseList.Size = new Size(974, 444);
            dgvCaseList.TabIndex = 0;
            // 
            // panelTopBar
            // 
            panelTopBar.Anchor = AnchorStyles.Top;
            panelTopBar.BackColor = SystemColors.GradientActiveCaption;
            panelTopBar.Controls.Add(cboLawyers);
            panelTopBar.Controls.Add(cboCaseType);
            panelTopBar.Controls.Add(cboxFinsished);
            panelTopBar.Controls.Add(ckboxOngoing);
            panelTopBar.Location = new Point(12, 12);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(974, 88);
            panelTopBar.TabIndex = 9;
            // 
            // cboLawyers
            // 
            cboLawyers.FormattingEnabled = true;
            cboLawyers.Location = new Point(651, 34);
            cboLawyers.Name = "cboLawyers";
            cboLawyers.Size = new Size(148, 23);
            cboLawyers.TabIndex = 3;
            // 
            // cboCaseType
            // 
            cboCaseType.FormattingEnabled = true;
            cboCaseType.Location = new Point(817, 34);
            cboCaseType.Name = "cboCaseType";
            cboCaseType.Size = new Size(142, 23);
            cboCaseType.TabIndex = 2;
            // 
            // cboxFinsished
            // 
            cboxFinsished.AutoSize = true;
            cboxFinsished.Location = new Point(158, 56);
            cboxFinsished.Name = "cboxFinsished";
            cboxFinsished.Size = new Size(70, 19);
            cboxFinsished.TabIndex = 1;
            cboxFinsished.Text = "Finished";
            cboxFinsished.UseVisualStyleBackColor = true;
            // 
            // ckboxOngoing
            // 
            ckboxOngoing.AutoSize = true;
            ckboxOngoing.Location = new Point(158, 21);
            ckboxOngoing.Name = "ckboxOngoing";
            ckboxOngoing.Size = new Size(76, 19);
            ckboxOngoing.TabIndex = 0;
            ckboxOngoing.Text = "On going";
            ckboxOngoing.UseVisualStyleBackColor = true;
            // 
            // lblNumberOfCases
            // 
            lblNumberOfCases.AutoSize = true;
            lblNumberOfCases.BackColor = SystemColors.GradientInactiveCaption;
            lblNumberOfCases.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblNumberOfCases.ForeColor = Color.FromArgb(45, 93, 134);
            lblNumberOfCases.Location = new Point(452, 115);
            lblNumberOfCases.Name = "lblNumberOfCases";
            lblNumberOfCases.Size = new Size(79, 21);
            lblNumberOfCases.TabIndex = 21;
            lblNumberOfCases.Text = "120 Cases";
            // 
            // CasePageView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(lblNumberOfCases);
            Controls.Add(panelTopBar);
            Controls.Add(dgvCaseList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CasePageView";
            Text = "CasePageView";
            ((System.ComponentModel.ISupportInitialize)dgvCaseList).EndInit();
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCaseList;
        private Panel panelTopBar;
        private Label lblNumberOfCases;
        private CheckBox ckboxOngoing;
        private ComboBox cboLawyers;
        private ComboBox cboCaseType;
        private CheckBox cboxFinsished;
    }
}