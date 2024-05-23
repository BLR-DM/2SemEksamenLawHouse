using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIModels;

namespace UI.Forms.CasePage
{
    public partial class PrintCaseDetailsView : Form
    {
        CaseUI caseUI;
        CaseBL caseBL;

        CaseUI caseUItest;

        public PrintCaseDetailsView(CaseUI caseUI)
        {
            caseBL = new CaseBL();
            this.caseUI = caseUI;


            InitializeComponent();
            btnBrowse.Click += BtnBrowse_Click;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
            Load += PrintCaseDetailsView_Load;
        }

        private async void PrintCaseDetailsView_Load(object? sender, EventArgs e)
        {
            caseUItest = await caseBL.GetCaseWithAllCollectionsAsync(caseUI.CaseID);
        }

        private async void BtnSave_Click(object? sender, EventArgs e)
        {
            btnSave.Enabled = false;

            bool success;

            if(ckboxDetailedVersion.Checked)
            {
                success = await caseUItest.PrintWithExtraDetailsAsync(txtPath.Text);
            }
            else
            {
                success = await caseUItest.PrintDetails(txtPath.Text);
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
