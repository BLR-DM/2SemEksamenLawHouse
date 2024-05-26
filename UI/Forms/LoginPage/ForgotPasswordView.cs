using BusinessLogic;
using BusinessLogic.Validation;

namespace UI.Forms.LoginPage
{
    public partial class ForgotPasswordView : Form
    {
        LoginBL loginBL;
        PersonValidator pValidator;
        bool validEmailFormat;
        public ForgotPasswordView(LoginBL loginBL, PersonValidator personValidator)
        {
            // Assign medbragte BL instanser for at undgå gentagne initialiseringer
            this.loginBL = loginBL; 
            pValidator = personValidator;

            InitializeComponent();

            btnRetrievePassword.Enabled = false;

            lblCancel.MouseHover += LblCancel_MouseHover;
            lblCancel.MouseLeave += LblCancel_MouseLeave;
            lblCancel.Click += LblCancel_Click;
            btnRetrievePassword.Click += BtnRetrievePassword_Click;
            txtEmail.TextChanged += TxtEmail_TextChanged;
        }

        private void TxtEmail_TextChanged(object? sender, EventArgs e)
        {
            validEmailFormat = pValidator.ValidEmail(txtEmail.Text);
            btnRetrievePassword.Enabled = validEmailFormat;
            // Skift tekstfarve på email input efter resultat af validering
            txtEmail.ForeColor = validEmailFormat ? Color.Black : Color.OrangeRed;
        }

        private async void BtnRetrievePassword_Click(object? sender, EventArgs e)
        {
            btnRetrievePassword.Enabled = false;

            /* -- Simulering af gendannelse af brugerens kode --
             * Denne besked bliver vist, uafhængigt af om brugeren findes i systemet, så det ikke 
               er muligt at finde et validt brugernavn i databasen af sikkerhedsmæssige årsager */

            MessageBox.Show("A link to reset your password has been sent to" +
                " your email. Please check your email to complete the process.",
                "Email Sent");

            // Kodeordet hentes fra systemet. Her ville man dog normalt åbne sin email og gendanne det
            string password = await loginBL.RetrievePasswordAsync(txtEmail.Text);

            if (!string.IsNullOrEmpty(password))
            {
                DialogResult result = MessageBox.Show("Would you like to display your" +
                " password?", "Show Password", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {                    
                    MessageBox.Show($"Your password is: {password}");
                }
            }
            btnRetrievePassword.Enabled = true;
        }

        // Underline på "Cancel" knap ved markør over knappen
        private void LblCancel_MouseHover(object? sender, EventArgs e)
        {
            lblCancel.Font = new Font(lblCancel.Font, FontStyle.Underline);
        }

        private void LblCancel_MouseLeave(object? sender, EventArgs e)
        {
            lblCancel.Font = new Font(lblCancel.Font, FontStyle.Regular);
        }

        private void LblCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
