using Microsoft.AspNetCore.Mvc;
using WeatherTest.Models;

namespace WeatherTest.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Weather()
        {
            return View(GetWeather());
        }

        public JsonResult GetWeather()
        {
            Weather weather = new Weather();
            return Json(weather.getWeatherForecast());
        }
    }
}