using Filters.Api.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Filters.Api.Controllers
{
    /// <summary>
    /// WeatherForecastController
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherForecastController"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Services the filter.
        /// </summary>
        /// <returns>Collection of WeatherForecast</returns>
        [HttpGet("service-filter")]
        [ServiceFilter(typeof(HelloServiceFilter))]
        public IEnumerable<WeatherForecast> ServiceFilter()
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

        /// <summary>
        /// Types the filter.
        /// </summary>
        /// <returns>Collection of WeatherForecast</returns>
        [HttpGet("type-filter")]
        [TypeFilter(typeof(HelloTypeFilter),Arguments = new[] { "Good Morning!!!" })]
        public IEnumerable<WeatherForecast> TypeFilter()
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
    }
}
