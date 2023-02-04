using CustomWeatherTool.Services;
using NUnit.Framework;

namespace WeatherTool.NUnit
{
    public class ValidateServicesTest
    {

        private ValidateServices _validateservice { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            _validateservice = new ValidateServices();    
        }

        [TestCase("Kolkata")]
        [TestCase("Patna")]
        [TestCase("Mumbai")]
        [TestCase("Pune")]
        public void ValidateCityNameIsTrueTest(string City)
        {  
                Assert.IsTrue(_validateservice.ValidateCityName(City));
        }

        [TestCase("Paris")]
        [TestCase("New York")]
        [TestCase("London")]
        [TestCase("Dubai")]
        public void ValidateCityNameIsFalseTest(string City)
        {
            Assert.IsFalse(_validateservice.ValidateCityName(City));
        }
    }
}