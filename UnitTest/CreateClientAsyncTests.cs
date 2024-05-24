using BusinessLogic;
using Interfaces;
using Moq;
using UIModels;

namespace UnitTest
{
    public class CreateClientAsyncTests
    {
        ClientBL clientBL;
        ClientUI client;
        List<PhoneUI> phoneList;
        LoginDetailsUI login;


        [SetUp]
        public void Setup()
        {
            clientBL = new ClientBL();

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
                new PhoneUI() {PhoneNumber = 28993856},
                new PhoneUI() {PhoneNumber = 28401072}
            };

        }


        [Test]
        public async Task CreateClientAsync_InvalidPhone_ReturnFalse()
        {
            bool expectedResult = false;

            phoneList.Add(new PhoneUI() { PhoneNumber = 123 });

            //Act
            bool result = await clientBL.CreateClientAsync(client, login, phoneList);


            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}