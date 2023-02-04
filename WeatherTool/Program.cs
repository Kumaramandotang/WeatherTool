using CustomWeatherTool.Model;
using CustomWeatherTool.Services;
using WeatherTool.Model;
using WeatherTool.Services;

var validation = new ValidateServices();
var fileservice = new FileServices();
var apiservice = new APIServices();
var displayservice = new DisplayService();

var CityName = args.AsEnumerable().FirstOrDefault();
  

if (CityName == null) 
    {

    do
    {
        Console.WriteLine("Please provide an Indian city name (or type Exit to close application): ");
        CityName = Console.ReadLine();
        if (CityName.ToLower().Trim() == "exit")
        { 
        Environment.Exit(0);    
        }
    }
    while (CityName == null || CityName =="");

    }
if (validation.ValidateCityName(CityName.Trim()))
    {
        CityModel CityDetails = fileservice.GetItemByName(CityName.Trim());
        WeatherModel WeatherReport = await apiservice.CallApiAsync(CityDetails.lat, CityDetails.lng);
        if (WeatherReport.generationtime_ms != null && WeatherReport.generationtime_ms != 0)
        {
            displayservice.DisplayResponse(WeatherReport, CityName.Trim());
        }
        else
        {
            Console.WriteLine("Something went wrong please try again.");
        }
    }
    else {
        Console.WriteLine("No city found with specified name please try again.");
    }

