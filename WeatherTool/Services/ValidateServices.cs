using CustomWeatherTool.Abstraction;
using CustomWeatherTool.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWeatherTool.Services
{
    public class ValidateServices : IValidateServices
    {
        public bool ValidateCityName(string CityName)
        {
            if (CityName != null || CityName != "") {
            var CityList = JsonConvert.DeserializeObject<List<CityModel>>(StaticDB.StaticDB.JsonData);
            if (CityList.AsQueryable().Where(item => item.city.ToString().ToLower() == CityName.ToLower()).FirstOrDefault() != null)
            {
                return true;
            }
            }
            return false;
        }
    }
}
