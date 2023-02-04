using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherTool.Model;
using WeatherTool.Services;

namespace WeatherTool.NUnit
{
    public class APIServiceTest
    {
        private APIServices _apiservice { get; set; } = null!;
        private WeatherModel _mockdata { get; set; } = null!;
       

        [SetUp]
        public void Setup()
        {
            _apiservice = new APIServices();
            _mockdata = new WeatherModel();       

            _mockdata.elevation = 11.0;
            
        }

       
        [TestCase(18.9667, 72.8333)]
        public async Task CallApiAsyncAreEqualTest(double lat, double lon)
        {
            var expected = _mockdata.elevation;
            var actual = await  _apiservice.CallApiAsync(lat, lon);    

            Assert.AreEqual(expected, actual.elevation);
        }



        [TestCase(12.9699, 77.5980)]
        public async Task CallApiAsyncAreNotEqualTest(double lat, double lon)
        {
            var expected = _mockdata.elevation;
            var actual = await _apiservice.CallApiAsync(lat, lon);

            Assert.AreNotEqual(expected, actual.elevation);
        }

    }
}
