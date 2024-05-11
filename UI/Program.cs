using BusinessLogic;
using EntityModels;
using Microsoft.Identity.Client;
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


            //hej
            //LawyerBL bl = new LawyerBL();

            //Lawyer lawyer1 = new Lawyer()
            //{
            //    Firstname = "Ramus",
            //    Lastname = "Skov",
            //    Email = "rasmus@skov.dk",
            //    AddressLine = "Lumbyesvej 16",
            //    PostalCode = 7000,
            //    City = "Fredericia",
            //    PhoneNumber = 22840883,
            //    HireDate = DateTime.Now,
            //    LawyerTitleID = 1,

            //    LoginDetails = new LoginDetails()
            //    {
            //        Username = "rasmus@skov.dk",
            //        Password = "skovesen",
            //        CreationDate = DateTime.Now,

            //    }

            //};
            //bool success = bl.CreateLawyer(lawyer1);


            //ClientBL clientBL = new ClientBL();

            //ClientUI clientUI = new ClientUI()
            //{
            //    Firstname = "Lucas",
            //    Lastname = "MacQuarrie",
            //    Email = "Maclucas07@hotmail.com",
            //    AddressLine = "Korskaervej 16",
            //    PostalCode = 7000,
            //    City = "Fredericia",
            //    ClientSub = 0,
            //};
            //LoginDetailsUI loginDetailsUI = new LoginDetailsUI()
            //{
            //    Username = clientUI.Email,
            //    Password = "kode123",
            //    CreationDate = DateTime.Now,
            //};

            //clientBL.Create(clientUI, loginDetailsUI);


            //LawyerBL bl = new LawyerBL();

            //Lawyer lawyer = new Lawyer()
            //{
            //    Firstname = "Bilal",
            //    Lastname = "Kinali",
            //    Email = "bilalkinali2@gmail.com",
            //    AddressLine = "Lumbyesvej 16",
            //    PostalCode = 7000,
            //    City = "Fredericia",
            //    PhoneNumber = 88888888,
            //    HireDate = DateTime.Now,
            //    LawyerTitleID = 1,

            //    LoginDetails = new LoginDetails()
            //    {
            //        Username = "bilalkinali2@gmail.com",
            //        Password = "kode123",
            //        CreationDate = DateTime.Now,

            //    }

            //};
            //bool success2 = bl.CreateLawyer(lawyer);

            //Lawyer lawyer2 = new Lawyer()
            //{
            //    Firstname = "Lawyer",
            //    Lastname = "lawyersen",
            //    Email = "lawyer@gmail.com",
            //    AddressLine = "lawyervej 16",
            //    PostalCode = 7000,
            //    City = "Fredericia",
            //    PhoneNumber = 87654321,
            //    HireDate = DateTime.Now,
            //    LawyerTitleID = 1,

            //    LoginDetails = new LoginDetails()
            //    {
            //        Username = "lawyer@gmail.com",
            //        Password = "lawyer",
            //        CreationDate = DateTime.Now,

            //    }

            //};
            //bool success3 = bl.CreateLawyer(lawyer2);

            Application.Run(new FrontPageView(4));
        }
    }
}