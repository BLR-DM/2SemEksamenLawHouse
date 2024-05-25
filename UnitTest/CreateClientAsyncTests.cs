using BusinessLogic;
using Interfaces;
using Moq;
using UIModels;
using EntityModels;
using DataAccess;

namespace UnitTest
{
    public class CreateClientAsyncTests
    {
        Mock<IClientBL> clientBL;
        ClientUI client;
        List<PhoneUI> phoneList;
        LoginDetailsUI login;



        [SetUp]
        public void Setup()
        {
            clientBL = new Mock<IClientBL>();

            login = new LoginDetailsUI()
            {
                CreationDate = DateTime.Now,
                Password = "lucas",
                Username = "maclucas07@gmail.com"
            };

            client = new ClientUI()
            {
                Firstname = "Lucas",
                Lastname = "MacQuarrie",
                Email = "maclucas07@gmail.com",
                AddressLine = "Korskærvej 11",
                PostalCode = 7000,
                City = "Fredericia",
            };

            phoneList = new List<PhoneUI>()
            {
                new PhoneUI() {PhoneNumber = 87239565},
            };


        }


        [Test]
        public async Task CreateClientAsync_InvalidPhone_ReturnFalse()
        {
            //clientBL.Setup(bl => bl.CreateClientAsync(client, login, phoneList)).ReturnsAsync(true);
            

            //phoneList.Add(new PhoneUI() { PhoneNumber = 123 });

            //Act
            //bool result = await clientBL.CreateClientAsync(client, login, phoneList);
            bool result = await clientBL.Object.CreateClientAsync(client, login, phoneList);


            Assert.That(result, Is.False);
        }
    }
}