using CustomWeatherTool.Services;
using NUnit.Framework;
using CustomWeatherTool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherTool.NUnit
{
    public class FileServiceTest
    {
        private FileServices _fileservice { get; set; } = null!;
        private CityModel _citymodel1 { get; set; } = null!;
        private CityModel _citymodel2 { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            _fileservice = new FileServices();
            _citymodel1 = new CityModel();
            _citymodel2 = new CityModel();

            _citymodel1.city = "Mumbai";
            _citymodel1.lat = 18.9667;
            _citymodel1.lng = 72.8333;   
            _citymodel1.country = "India";   
            _citymodel1.iso2 = "IN";   
            _citymodel1.admin_name = "Mahārāshtra";   
            _citymodel1.capital = "admin";   
            _citymodel1.population = "23355000";   
            _citymodel1.population_proper = "12478447";

            _citymodel2.city = "Kolkata";
            _citymodel2.lat = 18.9667;
            _citymodel2.lng = 72.8333;
            _citymodel2.country = "India";
            _citymodel2.iso2 = "IN";
            _citymodel2.admin_name = "Mahārāshtra";
            _citymodel2.capital = "admin";
            _citymodel2.population = "23355000";
            _citymodel2.population_proper = "12478447";
        }

        [TestCase("Mumbai")]
        public void GetItemByNameAreEqualTest(string City)
        {
            var expected = JsonConvert.SerializeObject(_citymodel1);
            var result = JsonConvert.SerializeObject(_fileservice.GetItemByName(City));
           Assert.AreEqual(expected, result);
        }

        [TestCase("Kolkata")]
        public void GetItemByNameAreNotEqualTest(string City)
        {
            var expected = JsonConvert.SerializeObject(_citymodel2);
            var result = JsonConvert.SerializeObject(_fileservice.GetItemByName(City));
            Assert.AreNotEqual(expected, result);
        }
    }
}
