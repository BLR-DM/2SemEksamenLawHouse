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

            btnClose.Click += BtnClose_Click;
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            loginPage.Show();
        }
    }
}
