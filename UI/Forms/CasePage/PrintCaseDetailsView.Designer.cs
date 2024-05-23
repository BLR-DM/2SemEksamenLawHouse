namespace UI.Forms.CasePage
{
    partial class PrintCaseDetailsView
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
            txtPath = new TextBox();
            label1 = new Label();
            btnBrowse = new Button();
            saveFileDialog1 = new SaveFileDialog();
            btnSave = new Button();
            btnCancel = new Button();
            ckboxDetailedVersion = new CheckBox();
            SuspendLayout();
            // 
            // txtPath
            // 
            txtPath.Location = new Point(84, 37);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(272, 23);
            txtPath.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 40);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "FilePath:";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(362, 37);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(33, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(320, 95);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(26, 95);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // ckboxDetailedVersion
            // 
            ckboxDetailedVersion.AutoSize = true;
            ckboxDetailedVersion.CheckAlign = ContentAlignment.MiddleRight;
            ckboxDetailedVersion.Location = new Point(177, 98);
            ckboxDetailedVersion.Name = "ckboxDetailedVersion";
            ckboxDetailedVersion.Size = new Size(137, 19);
            ckboxDetailedVersion.TabIndex = 5;
            ckboxDetailedVersion.Text = "Print detailed version";
            ckboxDetailedVersion.UseVisualStyleBackColor = true;
            // 
            // PrintCaseDetailsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 130);
            Controls.Add(ckboxDetailedVersion);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnBrowse);
            Controls.Add(label1);
            Controls.Add(txtPath);
            Name = "PrintCaseDetailsView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PrintCaseDetailsView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPath;
        private Label label1;
        private Button btnBrowse;
        private SaveFileDialog saveFileDialog1;
        private Button btnSave;
        private Button btnCancel;
        private CheckBox ckboxDetailedVersion;
    }
}