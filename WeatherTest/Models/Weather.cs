using Newtonsoft.Json;
using System;
using System.Net;

namespace WeatherTest.Models
{
    public class Weather
    {
        public Object getWeatherForecast()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Kiev&APPID=142d7747f0cf06ba859330d7c5433396&units=imperial";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var jsoncontent = JsonConvert.DeserializeObject(content);
            return jsoncontent;
        }
    }
}
