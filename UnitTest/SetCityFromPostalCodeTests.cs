using BusinessLogic;
using BusinessLogic.HelpServices;
using EntityModels;
using Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;

namespace UnitTest
{
    internal class SetCityFromPostalCodeTests
    {
        string postal;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task SetCityFromPostalCode_ValidInput_ReturnCity()
        {
            string excpectedResult = "Fredericia";

            postal = "7000";

            //act
            string result = GetCityFromPostalCode.SetCityFromPostalCode(postal);

            //Assert
            Assert.That(result, Is.EqualTo(excpectedResult));
        }

        [Test]
        public async Task SetCityFromPostalCode_NegInput_ReturnHyphen()
        {
            string excpectedResult = "-";

            postal = "-7000";

            //act
            string result = GetCityFromPostalCode.SetCityFromPostalCode(postal);

            //Assert
            Assert.That(result, Is.EqualTo(excpectedResult));
        }


        [Test]
        public async Task SetCityFromPostalCode_NonExistInput_ReturnHyphen()
        {
            string excpectedResult = "-";

            postal = "1000000000000000000000000000000000";

            //act
            string result = GetCityFromPostalCode.SetCityFromPostalCode(postal);

            //Assert
            Assert.That(result, Is.EqualTo(excpectedResult));
        }

        [Test]
        public async Task SetCityFromPostalCode_LettersInput_ReturnHyphen()
        {
            string excpectedResult = "-";

            postal = "hej";

            //act
            string result = GetCityFromPostalCode.SetCityFromPostalCode(postal);

            //Assert
            Assert.That(result, Is.EqualTo(excpectedResult));
        }
    }
}
