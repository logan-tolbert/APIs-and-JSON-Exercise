using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        HttpClient client = new HttpClient();
       
        public void GetCurrentWeather()
        {
            var url = "https://api.openweathermap.org/data/2.5/weather?lat=33.7286935&lon=-87.0904188&appid=37f5e1a451216ff25f7fc8e1890c4070&units=imperial";
            var apiResponse = client.GetStringAsync(url).Result;
            JsonNode weatherData = JsonNode.Parse(apiResponse);
            Console.WriteLine($"Description: {weatherData["weather"][0]["description"]}");
            Console.WriteLine($"Temperature: {weatherData["main"]["temp"]} F");
            Console.WriteLine($"Feels like: {weatherData["main"]["feels_like"]} F");
            Console.WriteLine($"Humidity: {weatherData["main"]["humidity"]}%");
            Console.WriteLine($"Wind speed: {weatherData["wind"]["speed"]} MPH");
            
        }
    }
}
