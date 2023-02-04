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
    public class FileServices : IFileServices
    {
        public CityModel GetItemByName(string CityName)
        {
            var CityList = JsonConvert.DeserializeObject<List<CityModel>>(StaticDB.StaticDB.JsonData);
            CityModel City = CityList.AsQueryable().Where(item=> item.city.ToString().ToLower() == CityName.ToLower()).FirstOrDefault();
            return City;
        }
    }
}
