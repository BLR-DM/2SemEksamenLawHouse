using BusinessLogic.API;
using BusinessLogic.HelpServices;
using BusinessLogic.Validation;
using UIModels;

namespace UI.Forms.CasePage
{
    public partial class DistanceCalculatorView : Form
    {
        DistanceMatrixBL distanceMatrixBL;
        CaseValidator cValidator;
        public event EventHandler<string> saveResult;
        public DistanceCalculatorView(CaseValidator caseValidator)
        {
            distanceMatrixBL = new DistanceMatrixBL();
            cValidator = caseValidator;

            InitializeComponent();

            btnSearch.Enabled = false;
            btnSave.Enabled = false;

            txtOrigin.TextChanged += TxtOrigin_TextChanged;
            txtDestination.TextChanged += TxtDestination_TextChanged;
            btnSearch.Click += BtnSearch_Click;
            btnSave.Click += BtnSave_Click;
            txtResult.TextChanged += TxtResult_TextChanged;
            lblHelp.Click += LblHelp_Click;
        }

        private void LblHelp_Click(object? sender, EventArgs e)
        {
            OpenPDF.ShowPDF("DistanceCalculatorHelp");
        }

        private void TxtResult_TextChanged(object? sender, EventArgs e)
        {
            btnSave.Enabled = !string.IsNullOrEmpty(txtResult.Text);
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            string saveDistance = txtResult.Text.Split(' ')[0];
            saveDistance = saveDistance.Replace('.', ',');
            saveResult?.Invoke(this, saveDistance);
            this.Close();
        }

        private void TxtDestination_TextChanged(object? sender, EventArgs e)
        {
            txtDestination.ForeColor = cValidator.ValidAddress(txtDestination.Text) ? Color.Black : Color.OrangeRed;
            btnSearch.Enabled = txtDestination.ForeColor == Color.Black && txtOrigin.ForeColor == Color.Black;
        }

        private void TxtOrigin_TextChanged(object? sender, EventArgs e)
        {
            txtOrigin.ForeColor = cValidator.ValidAddress(txtOrigin.Text) ? Color.Black : Color.OrangeRed;
            btnSearch.Enabled = txtDestination.ForeColor == Color.Black && txtOrigin.ForeColor == Color.Black;
        }

        private async void BtnSearch_Click(object? sender, EventArgs e)
        {
            DistanceMatrix calcResult = await distanceMatrixBL.GetDistanceAsync(txtOrigin.Text, txtDestination.Text);

            if (calcResult.status == "OK")
            {
                if (calcResult.rows[0].elements[0].status == "OK")
                {
                    txtResult.Text = calcResult.rows[0].elements[0].distance.text;
                    txtDuration.Text = calcResult.rows[0].elements[0].duration.text; 
                }
                else
                    MessageBox.Show("Couldn't find address", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Could'nt connect to service, please try again later or contact costumer support",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
