using UI.Forms.CreateUserPage;
using UI.Forms.FrontPage;
using UIModels;

namespace UI.Forms.LoginPage
{
    public partial class LoginPageView : Form
    {
        Color rgbColorBlue;

        public LoginPageView()
        {
            rgbColorBlue = Color.FromArgb(45, 93, 134);

            InitializeComponent();    
            btnClose.Click += BtnClose_Click;
            pboxEye.Click += PBoxEye_Click;
            btnLogin.Click += BtnLogin_Click;
            lblRegister.Click += LblRegister_Click;
        }

        private void LblRegister_Click(object? sender, EventArgs e)
        {
            new CreateUserView(this).Show();
            Hide();
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            new FrontPageView().Show();
            Hide();
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
