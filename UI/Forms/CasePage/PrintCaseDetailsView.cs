using UIModels;

namespace UI.Forms.CasePage
{
    public partial class PrintCaseDetailsView : Form
    {
        CaseUI selectedCase;

        public PrintCaseDetailsView(CaseUI caseUI)
        {
            this.selectedCase = caseUI;


            InitializeComponent();
            btnBrowse.Click += BtnBrowse_Click;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;

        }


        private async void BtnSave_Click(object? sender, EventArgs e)
        {
            btnSave.Enabled = false;

            bool success;

            if(ckboxDetailedVersion.Checked)
            {
                success = await selectedCase.PrintWithExtraDetailsAsync(txtPath.Text);
            }
            else
            {
                success = await selectedCase.PrintDetailsAsync(txtPath.Text);
            }

            if(success)
            {
                MessageBox.Show("File has been created!");
            }
            else
            {
                MessageBox.Show("ERROR! File not created");
            }


           
            this.Close();

        }

        private void BtnBrowse_Click(object? sender, EventArgs e)
        {
            // opret savefiledialog til at gemme fil
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Only save as .csv
                saveFileDialog.Filter = "Textfile (*.txt)|*.txt";
                saveFileDialog.DefaultExt = "txt"; // default exit sat til txt

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = saveFileDialog.FileName;      // Filepath
                }
            }
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
