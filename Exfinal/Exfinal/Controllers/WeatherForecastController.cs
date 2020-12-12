using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Exfinal.Controllers
{
    [ApiController]
    [Route("operaciones")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [Route("{numero}")]
        public string Edit(int numero)
        {
            if (numero < 0)
            {
                return "ERROR";
            }
            if (numero == 0)
            {
                return "Realizado por Maria Laura Suarez";
            }
            if (numero > 0)
            {
                return "https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg";
            }
            return "otro";
        }
    }
}
