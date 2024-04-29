using UI.Forms.FrontPage;

namespace UI.Forms.LoginPage
{
    public partial class LoginPage : Form
    {
        Color rgbColorBlue;

        public LoginPage()
        {
            rgbColorBlue = Color.FromArgb(45, 93, 134);

            InitializeComponent();    
            btnClose.Click += BtnClose_Click;
            pboxEye.Click += PBoxEye_Click;
            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            Hide();
            new FrontPageView().Show();
        }

        private void PBoxEye_Click(object? sender, EventArgs e)
        {
            if (pboxEye.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                pboxEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                tboxPassword.PasswordChar = '\0'; // Default password char
            }
            else
            {
                pboxEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
                tboxPassword.PasswordChar = '\u2022'; // Unicode for bullet point '•'
            }
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
