using BusinessLogic;
using EntityModels;
using UI.Forms.FrontPage;
using UI.Forms.LoginPage;
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

            LawyerBl bl = new LawyerBl();

            Lawyer lawyer = new Lawyer()
            {
                
                FirstName = "Bilal",
                LastName = "Kinali",
                Email = "bilalkinali@gmail.com",
                AddressLine = "Lumbyesvej 16",
                PostalCode = 7000,
                PhoneNumber = 88888888,
                HireDate = DateTime.Now,
                //Title = "Jurist",

                LoginDetails = new LoginDetails()
                {
                    UserName = "bilalkinali@gmail.com",
                    PassWord = "kode123",
                    CreationDate = DateTime.Now,

                }

            };
            bool success = bl.CreateLawyer(lawyer);
        }
    }
}