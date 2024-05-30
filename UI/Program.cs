using BusinessLogic;
using EntityModels;
using Microsoft.Identity.Client;
using UI.Forms.AdminPage;
using UI.Forms.CasePage;
using UI.Forms.ClientPage;
using UI.Forms.CreateUserPage;
using UI.Forms.EmployeePage;
using UI.Forms.FrontPage;
using UI.Forms.LoginPage;
using UIModels;
namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginPageView());     
        }
    }
}

