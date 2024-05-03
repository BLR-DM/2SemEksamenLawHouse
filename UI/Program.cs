using BusinessLogic;
using EntityModels;
using Microsoft.Identity.Client;
using UI.Forms.ClientPage;
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


            //ClientBl clientBl = new ClientBl();

            //ClientUI clientUI = new ClientUI()
            //{
            //    FirstName = "Lucas",
            //    LastName = "MacQuarrie",
            //    Email = "Maclucas07@hotmail.com",
            //    AddressLine = "Korskaervej 16",
            //    PostalCode = 7000,
            //    City = "Fredericia",
            //    ClientSub = 0,
            //};
            //LoginDetailsUI loginDetailsUI = new LoginDetailsUI()
            //{
            //    UserName = clientUI.Email,
            //    PassWord = "kode123",
            //    CreationDate = DateTime.Now,
            //};

            //clientBl.Create(clientUI, loginDetailsUI);



            //LawyerBl bl = new LawyerBl();

            //Lawyer lawyer = new Lawyer()
            //{
            //FirstName = "Bilal",
            //LastName = "Kinali",
            //Email = "bilalkinali@gmail.com",
            //AddressLine = "Lumbyesvej 16",
            //PostalCode = 7000,
            //PhoneNumber = 88888888,
            //HireDate = DateTime.Now,
            //LawyerTitleID = 1,

            //    LoginDetails = new LoginDetails()
            //    {
            //        UserName = "bilalkinali@gmail.com",
            //        PassWord = "kode123",
            //        CreationDate = DateTime.Now,

            //    }

            //};
            //bool success = bl.CreateLawyer(lawyer);
        }
    }
}