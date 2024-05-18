namespace UI.Toolbox
{
    partial class FilterSpeciality
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnFilter = new Button();
            SuspendLayout();
            // 
            // btnFilter
            // 
            btnFilter.AutoSize = true;
            btnFilter.BackColor = SystemColors.ActiveCaption;
            btnFilter.BackgroundImageLayout = ImageLayout.Center;
            btnFilter.Dock = DockStyle.Fill;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 8F);
            btnFilter.Location = new Point(0, 0);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(63, 25);
            btnFilter.TabIndex = 0;
            btnFilter.Text = "button1";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // FilterSpeciality
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            Controls.Add(btnFilter);
            Name = "FilterSpeciality";
            Size = new Size(63, 25);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFilter;
    }
}
