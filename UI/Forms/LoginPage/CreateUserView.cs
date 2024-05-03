using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms.LoginPage;

namespace UI.Forms.CreateUserPage
{
    public partial class CreateUserView : Form
    {
        LoginPageView loginPage;
        public CreateUserView(LoginPageView login)
        {
            loginPage = login;
            InitializeComponent();

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            loginPage.Show();
        }
    }
}
