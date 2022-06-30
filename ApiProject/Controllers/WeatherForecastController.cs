using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public static List<string> Summaries = new List<string>();

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public int Post( string words)
        {

            Summaries = null;
            Summaries = words.Split(" ").ToList();
            int maxsize = Summaries.Count();

            //string mk = "Methon khan";
            //int chunkSizee = 3;
            //Summaries = mk.Split(" ").ToList();
            //var lineSize = Enumerable.Range(0, words.Length / chunkSize)
            //.Select(i => words.Substring(i * chunkSize, chunkSize));

            //foreach (var data in lineSize)
            //{
            //    Summaries.Add(data);
            //}


            return StatusCodes.Status201Created;
        }
        [HttpGet]
        public List<string> Get()
        {

            return (Summaries);
        }
    }
}
